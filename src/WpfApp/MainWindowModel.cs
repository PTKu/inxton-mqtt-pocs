using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using MQTTnet.Server;
using MQTTnet.TestApp.NetCore;
using Newtonsoft.Json;
using Plc;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Vortex.Presentation.Wpf;
using Vortex.Connector;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        const string STR_Send_As_Json = "send_as_json";
        const string STR_Send_As_Items = "send_as_items";
        const string STR_Send_As_Xml = "send_as_xml";

        public MainWindowModel()
        {            
            MAIN = Entry.Plc.MAIN;

            MqttNetConsoleLogger.ForwardToConsole();

            factory = new MqttFactory();            
            forwarderClient = factory.CreateMqttClient();
            subscriberClient = factory.CreateMqttClient();
            
            var clientOptions = new MqttClientOptionsBuilder().WithTcpServer("mqtt.eclipse.org").Build();
            forwarderClient.ConnectAsync(clientOptions).Wait();

            var subscriberOptions = new MqttClientOptionsBuilder().WithTcpServer("mqtt.eclipse.org").Build();
            subscriberClient.ConnectAsync(subscriberOptions).Wait();

            subscriberClient.SubscribeAsync(STR_Send_As_Json).Wait();
            subscriberClient.SubscribeAsync(STR_Send_As_Items).Wait();
            subscriberClient.SubscribeAsync(STR_Send_As_Xml).Wait();

            subscriberClient.UseApplicationMessageReceivedHandler((a) => {
                Received += $"\n{DateTime.Now}\n{a.ApplicationMessage.Topic}:\n{a.ApplicationMessage.ConvertPayloadToString()}";                
            });

            SendMessageCommand = new RelayCommand(a => Send());
            ClearReceiveBoxCommand = new RelayCommand(a => this.Received = string.Empty, b => this.Received != string.Empty);
        }

        public MAIN MAIN { get; set; }

        private readonly MqttFactory factory;        
        private readonly IMqttClient forwarderClient;
        private readonly IMqttClient subscriberClient;

        public event PropertyChangedEventHandler PropertyChanged;

        private async void Send()
        {
            MAIN.Read();
          
            var plain = MAIN.CreatePlainerType();
            plain.CopyCyclicToPlain(MAIN);

            await BroadCastAsJson(plain, STR_Send_As_Json);
            await BroadcastAsItems(MAIN, STR_Send_As_Items);
            // await BroadcastAsXml(plain, STR_Send_As_Xml);                      
        }

        private async Task BroadCastAsJson(IPlain plain, string topic)
        {
            string json = JsonConvert.SerializeObject(plain, Formatting.Indented);
            await forwarderClient.PublishAsync($"{topic}", $"{json}");
        }

        private async Task BroadcastAsItems(IVortexObject obj, string topic)
        {
            // Send as items
            var sb = new StringBuilder();
            foreach (var item in obj.RetrieveValueTags())
            {
                var value = ((dynamic)item);
                sb.AppendLine($"{item.Symbol}:{value.LastValue.GetType()}:{value.LastValue}");
            }

            await forwarderClient.PublishAsync($"{topic}", $"{sb}");
        }

        private async Task BroadcastAsXml(IPlain plain, string topic)
        {
            var stream = new System.IO.MemoryStream();
            using (var st = new System.IO.StreamWriter(stream))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(plain.GetType());
                serializer.Serialize(st, plain);

                stream.Position = 0;
                using (var str = new System.IO.StreamReader(stream))
                {
                    await forwarderClient.PublishAsync($"{topic}", $"{str.ReadToEnd()}");
                }
            }
        }

        public RelayCommand SendMessageCommand { get; }

        public RelayCommand ClearReceiveBoxCommand { get; }

        string recieved;
        public string Received
        {
            get => recieved; set
            {
                if (recieved == value)
                {
                    return;
                }

                recieved = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Received)));
            }
        }
    }    
}