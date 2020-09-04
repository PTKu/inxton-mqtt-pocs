using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "Plc", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerString _Hello_World;
		public Vortex.Connector.ValueTypes.OnlinerString Hello_World
		{
			get
			{
				return _Hello_World;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IMAIN.Hello_World
		{
			get
			{
				return Hello_World;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowMAIN.Hello_World
		{
			get
			{
				return Hello_World;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Counter;
		public Vortex.Connector.ValueTypes.OnlinerInt Counter
		{
			get
			{
				return _Counter;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IMAIN.Counter
		{
			get
			{
				return Counter;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowMAIN.Counter
		{
			get
			{
				return Counter;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable;
		public Vortex.Connector.ValueTypes.OnlinerString Variable
		{
			get
			{
				return _Variable;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IMAIN.Variable
		{
			get
			{
				return Variable;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowMAIN.Variable
		{
			get
			{
				return Variable;
			}
		}

		public void LazyOnlineToShadow()
		{
			Hello_World.Shadow = Hello_World.LastValue;
			Counter.Shadow = Counter.LastValue;
			Variable.Shadow = Variable.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Hello_World.Cyclic = Hello_World.Shadow;
			Counter.Cyclic = Counter.Shadow;
			Variable.Cyclic = Variable.Shadow;
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainMAIN source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainMAIN source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Hello_World = @Connector.Online.Adapter.CreateSTRING(this, "Hello world", "Hello_World");
			Hello_World.AttributeName = "Hello world";
			_Counter = @Connector.Online.Adapter.CreateINT(this, "Counter", "Counter");
			Counter.AttributeName = "Counter";
			_Variable = @Connector.Online.Adapter.CreateSTRING(this, "Change me", "Variable");
			Variable.AttributeName = "Change me";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			_Hello_World = Vortex.Connector.IConnectorFactory.CreateSTRING();
			Hello_World.AttributeName = "Hello world";
			_Counter = Vortex.Connector.IConnectorFactory.CreateINT();
			Counter.AttributeName = "Counter";
			_Variable = Vortex.Connector.IConnectorFactory.CreateSTRING();
			Variable.AttributeName = "Change me";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString Hello_World
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString Variable
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainMAIN source);
		void FlushOnlineToPlain(Plc.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString Hello_World
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString Variable
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainMAIN source);
	}

	
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

		public void CopyPlainToCyclic(Plc.MAIN target)
		{
			target.Hello_World.Cyclic = Hello_World;
			target.Counter.Cyclic = Counter;
			target.Variable.Cyclic = Variable;
		}

		public void CopyPlainToCyclic(Plc.IMAIN target)
		{
			this.CopyPlainToCyclic((Plc.MAIN)target);
		}

		public void CopyPlainToShadow(Plc.MAIN target)
		{
			target.Hello_World.Shadow = Hello_World;
			target.Counter.Shadow = Counter;
			target.Variable.Shadow = Variable;
		}

		public void CopyPlainToShadow(Plc.IShadowMAIN target)
		{
			this.CopyPlainToShadow((Plc.MAIN)target);
		}

		public void CopyCyclicToPlain(Plc.MAIN source)
		{
			Hello_World = source.Hello_World.LastValue;
			Counter = source.Counter.LastValue;
			Variable = source.Variable.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IMAIN source)
		{
			this.CopyCyclicToPlain((Plc.MAIN)source);
		}

		public void CopyShadowToPlain(Plc.MAIN source)
		{
			Hello_World = source.Hello_World.Shadow;
			Counter = source.Counter.Shadow;
			Variable = source.Variable.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowMAIN source)
		{
			this.CopyShadowToPlain((Plc.MAIN)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
		}
	}
}