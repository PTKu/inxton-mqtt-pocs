using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String _Hello_World;
		public System.String Hello_World
		{
			get
			{
				return _Hello_World;
			}

			set
			{
				if (_Hello_World != value)
				{
					_Hello_World = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Hello_World)));
				}
			}
		}

		System.Int16 _Counter;
		public System.Int16 Counter
		{
			get
			{
				return _Counter;
			}

			set
			{
				if (_Counter != value)
				{
					_Counter = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Counter)));
				}
			}
		}

		System.String _Variable;
		public System.String Variable
		{
			get
			{
				return _Variable;
			}

			set
			{
				if (_Variable != value)
				{
					_Variable = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variable)));
				}
			}
		}

		PlainstTestStruct __testStruct;
		public PlainstTestStruct _testStruct
		{
			get
			{
				return __testStruct;
			}

			set
			{
				if (__testStruct != value)
				{
					__testStruct = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_testStruct)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
			__testStruct = new PlainstTestStruct();
		}
	}
}