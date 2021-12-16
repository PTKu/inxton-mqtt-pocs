using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Container(Layout.Tabs)]
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
		[Container(Layout.Stack)]
		public Vortex.Connector.ValueTypes.OnlinerString Hello_World
		{
			get
			{
				return _Hello_World;
			}
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Online.IOnlineString IMAIN.Hello_World
		{
			get
			{
				return Hello_World;
			}
		}

		[Container(Layout.Stack)]
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

		stTestStruct __testStruct;
		[Container(Layout.Stack)]
		public stTestStruct _testStruct
		{
			get
			{
				return __testStruct;
			}
		}

		[Container(Layout.Stack)]
		IstTestStruct IMAIN._testStruct
		{
			get
			{
				return _testStruct;
			}
		}

		[Container(Layout.Stack)]
		IShadowstTestStruct IShadowMAIN._testStruct
		{
			get
			{
				return _testStruct;
			}
		}

		public void LazyOnlineToShadow()
		{
			Hello_World.Shadow = Hello_World.LastValue;
			Counter.Shadow = Counter.LastValue;
			Variable.Shadow = Variable.LastValue;
			_testStruct.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			Hello_World.Cyclic = Hello_World.Shadow;
			Counter.Cyclic = Counter.Shadow;
			Variable.Cyclic = Variable.Shadow;
			_testStruct.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned._testStruct = _testStruct.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned._testStruct = _testStruct.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
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

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

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
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Hello_World = @Connector.Online.Adapter.CreateSTRING(this, "Hello world", "Hello_World");
			Hello_World.AttributeName = "Hello world";
			_Counter = @Connector.Online.Adapter.CreateINT(this, "Counter", "Counter");
			Counter.AttributeName = "Counter";
			_Variable = @Connector.Online.Adapter.CreateSTRING(this, "Change me", "Variable");
			Variable.AttributeName = "Change me";
			__testStruct = new stTestStruct(this, "", "_testStruct");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
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
			__testStruct = new stTestStruct();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN
	{
		public void CopyPlainToCyclic(Plc.MAIN target)
		{
			target.Hello_World.Cyclic = Hello_World;
			target.Counter.Cyclic = Counter;
			target.Variable.Cyclic = Variable;
			_testStruct.CopyPlainToCyclic(target._testStruct);
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
			_testStruct.CopyPlainToShadow(target._testStruct);
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
			_testStruct.CopyCyclicToPlain(source._testStruct);
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
			_testStruct.CopyShadowToPlain(source._testStruct);
		}

		public void CopyShadowToPlain(Plc.IShadowMAIN source)
		{
			this.CopyShadowToPlain((Plc.MAIN)source);
		}
	}
}