using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stTestStruct", "Plc", TypeComplexityEnum.Complex)]
	public partial class stTestStruct : Vortex.Connector.IVortexObject, IstTestStruct, IShadowstTestStruct, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _BOOL_val;
		public Vortex.Connector.ValueTypes.OnlinerBool BOOL_val
		{
			get
			{
				return _BOOL_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstTestStruct.BOOL_val
		{
			get
			{
				return BOOL_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstTestStruct.BOOL_val
		{
			get
			{
				return BOOL_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _BYTE_val;
		public Vortex.Connector.ValueTypes.OnlinerByte BYTE_val
		{
			get
			{
				return _BYTE_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte IstTestStruct.BYTE_val
		{
			get
			{
				return BYTE_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowstTestStruct.BYTE_val
		{
			get
			{
				return BYTE_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _WORD_val;
		public Vortex.Connector.ValueTypes.OnlinerWord WORD_val
		{
			get
			{
				return _WORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord IstTestStruct.WORD_val
		{
			get
			{
				return WORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowstTestStruct.WORD_val
		{
			get
			{
				return WORD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _DWORD_val;
		public Vortex.Connector.ValueTypes.OnlinerDWord DWORD_val
		{
			get
			{
				return _DWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IstTestStruct.DWORD_val
		{
			get
			{
				return DWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowstTestStruct.DWORD_val
		{
			get
			{
				return DWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLWord _LWORD_val;
		public Vortex.Connector.ValueTypes.OnlinerLWord LWORD_val
		{
			get
			{
				return _LWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLWord IstTestStruct.LWORD_val
		{
			get
			{
				return LWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLWord IShadowstTestStruct.LWORD_val
		{
			get
			{
				return LWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerSInt _SINT_val;
		public Vortex.Connector.ValueTypes.OnlinerSInt SINT_val
		{
			get
			{
				return _SINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineSInt IstTestStruct.SINT_val
		{
			get
			{
				return SINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowSInt IShadowstTestStruct.SINT_val
		{
			get
			{
				return SINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _USINT_val;
		public Vortex.Connector.ValueTypes.OnlinerUSInt USINT_val
		{
			get
			{
				return _USINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IstTestStruct.USINT_val
		{
			get
			{
				return USINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowstTestStruct.USINT_val
		{
			get
			{
				return USINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _INT_val;
		public Vortex.Connector.ValueTypes.OnlinerInt INT_val
		{
			get
			{
				return _INT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IstTestStruct.INT_val
		{
			get
			{
				return INT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstTestStruct.INT_val
		{
			get
			{
				return INT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _UINT_val;
		public Vortex.Connector.ValueTypes.OnlinerUInt UINT_val
		{
			get
			{
				return _UINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IstTestStruct.UINT_val
		{
			get
			{
				return UINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowstTestStruct.UINT_val
		{
			get
			{
				return UINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _DINT_val;
		public Vortex.Connector.ValueTypes.OnlinerDInt DINT_val
		{
			get
			{
				return _DINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IstTestStruct.DINT_val
		{
			get
			{
				return DINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowstTestStruct.DINT_val
		{
			get
			{
				return DINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _UDINT_val;
		public Vortex.Connector.ValueTypes.OnlinerUDInt UDINT_val
		{
			get
			{
				return _UDINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IstTestStruct.UDINT_val
		{
			get
			{
				return UDINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowstTestStruct.UDINT_val
		{
			get
			{
				return UDINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLInt _LINT_val;
		public Vortex.Connector.ValueTypes.OnlinerLInt LINT_val
		{
			get
			{
				return _LINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLInt IstTestStruct.LINT_val
		{
			get
			{
				return LINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLInt IShadowstTestStruct.LINT_val
		{
			get
			{
				return LINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerULInt _ULINT_val;
		public Vortex.Connector.ValueTypes.OnlinerULInt ULINT_val
		{
			get
			{
				return _ULINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineULInt IstTestStruct.ULINT_val
		{
			get
			{
				return ULINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowULInt IShadowstTestStruct.ULINT_val
		{
			get
			{
				return ULINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _REAL_val;
		public Vortex.Connector.ValueTypes.OnlinerReal REAL_val
		{
			get
			{
				return _REAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstTestStruct.REAL_val
		{
			get
			{
				return REAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstTestStruct.REAL_val
		{
			get
			{
				return REAL_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal _LREAL_val;
		public Vortex.Connector.ValueTypes.OnlinerLReal LREAL_val
		{
			get
			{
				return _LREAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IstTestStruct.LREAL_val
		{
			get
			{
				return LREAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowstTestStruct.LREAL_val
		{
			get
			{
				return LREAL_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _STRING_val;
		public Vortex.Connector.ValueTypes.OnlinerString STRING_val
		{
			get
			{
				return _STRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstTestStruct.STRING_val
		{
			get
			{
				return STRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstTestStruct.STRING_val
		{
			get
			{
				return STRING_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWString _WSTRING_val;
		public Vortex.Connector.ValueTypes.OnlinerWString WSTRING_val
		{
			get
			{
				return _WSTRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWString IstTestStruct.WSTRING_val
		{
			get
			{
				return WSTRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWString IShadowstTestStruct.WSTRING_val
		{
			get
			{
				return WSTRING_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _TIME_val;
		public Vortex.Connector.ValueTypes.OnlinerTime TIME_val
		{
			get
			{
				return _TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime IstTestStruct.TIME_val
		{
			get
			{
				return TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowstTestStruct.TIME_val
		{
			get
			{
				return TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTimeOfDay _TIME_OF_DAY_val;
		public Vortex.Connector.ValueTypes.OnlinerTimeOfDay TIME_OF_DAY_val
		{
			get
			{
				return _TIME_OF_DAY_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay IstTestStruct.TIME_OF_DAY_val
		{
			get
			{
				return TIME_OF_DAY_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay IShadowstTestStruct.TIME_OF_DAY_val
		{
			get
			{
				return TIME_OF_DAY_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDate _DATE_val;
		public Vortex.Connector.ValueTypes.OnlinerDate DATE_val
		{
			get
			{
				return _DATE_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate IstTestStruct.DATE_val
		{
			get
			{
				return DATE_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate IShadowstTestStruct.DATE_val
		{
			get
			{
				return DATE_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _DATE_AND_TIME_val;
		public Vortex.Connector.ValueTypes.OnlinerDateTime DATE_AND_TIME_val
		{
			get
			{
				return _DATE_AND_TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstTestStruct.DATE_AND_TIME_val
		{
			get
			{
				return DATE_AND_TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstTestStruct.DATE_AND_TIME_val
		{
			get
			{
				return DATE_AND_TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTimeOfDay _TOD_val;
		public Vortex.Connector.ValueTypes.OnlinerTimeOfDay TOD_val
		{
			get
			{
				return _TOD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay IstTestStruct.TOD_val
		{
			get
			{
				return TOD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay IShadowstTestStruct.TOD_val
		{
			get
			{
				return TOD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _DT_val;
		public Vortex.Connector.ValueTypes.OnlinerDateTime DT_val
		{
			get
			{
				return _DT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstTestStruct.DT_val
		{
			get
			{
				return DT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstTestStruct.DT_val
		{
			get
			{
				return DT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLTime _LTIME_val;
		public Vortex.Connector.ValueTypes.OnlinerLTime LTIME_val
		{
			get
			{
				return _LTIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLTime IstTestStruct.LTIME_val
		{
			get
			{
				return LTIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLTime IShadowstTestStruct.LTIME_val
		{
			get
			{
				return LTIME_val;
			}
		}

		public Vortex.Connector.ValueTypes.OnlinerInt[,, ] ValueTypeArray
		{
			get;
			set;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt[,, ] IstTestStruct.ValueTypeArray
		{
			get
			{
				return ValueTypeArray;
			}

			set
			{
				ValueTypeArray = (Vortex.Connector.ValueTypes.OnlinerInt[,, ])value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt[,, ] IShadowstTestStruct.ValueTypeArray
		{
			get
			{
				return ValueTypeArray;
			}
		}

		public void LazyOnlineToShadow()
		{
			BOOL_val.Shadow = BOOL_val.LastValue;
			BYTE_val.Shadow = BYTE_val.LastValue;
			WORD_val.Shadow = WORD_val.LastValue;
			DWORD_val.Shadow = DWORD_val.LastValue;
			LWORD_val.Shadow = LWORD_val.LastValue;
			SINT_val.Shadow = SINT_val.LastValue;
			USINT_val.Shadow = USINT_val.LastValue;
			INT_val.Shadow = INT_val.LastValue;
			UINT_val.Shadow = UINT_val.LastValue;
			DINT_val.Shadow = DINT_val.LastValue;
			UDINT_val.Shadow = UDINT_val.LastValue;
			LINT_val.Shadow = LINT_val.LastValue;
			ULINT_val.Shadow = ULINT_val.LastValue;
			REAL_val.Shadow = REAL_val.LastValue;
			LREAL_val.Shadow = LREAL_val.LastValue;
			STRING_val.Shadow = STRING_val.LastValue;
			WSTRING_val.Shadow = WSTRING_val.LastValue;
			TIME_val.Shadow = TIME_val.LastValue;
			TIME_OF_DAY_val.Shadow = TIME_OF_DAY_val.LastValue;
			DATE_val.Shadow = DATE_val.LastValue;
			DATE_AND_TIME_val.Shadow = DATE_AND_TIME_val.LastValue;
			TOD_val.Shadow = TOD_val.LastValue;
			DT_val.Shadow = DT_val.LastValue;
			LTIME_val.Shadow = LTIME_val.LastValue;
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray);
		}

		public void LazyShadowToOnline()
		{
			BOOL_val.Cyclic = BOOL_val.Shadow;
			BYTE_val.Cyclic = BYTE_val.Shadow;
			WORD_val.Cyclic = WORD_val.Shadow;
			DWORD_val.Cyclic = DWORD_val.Shadow;
			LWORD_val.Cyclic = LWORD_val.Shadow;
			SINT_val.Cyclic = SINT_val.Shadow;
			USINT_val.Cyclic = USINT_val.Shadow;
			INT_val.Cyclic = INT_val.Shadow;
			UINT_val.Cyclic = UINT_val.Shadow;
			DINT_val.Cyclic = DINT_val.Shadow;
			UDINT_val.Cyclic = UDINT_val.Shadow;
			LINT_val.Cyclic = LINT_val.Shadow;
			ULINT_val.Cyclic = ULINT_val.Shadow;
			REAL_val.Cyclic = REAL_val.Shadow;
			LREAL_val.Cyclic = LREAL_val.Shadow;
			STRING_val.Cyclic = STRING_val.Shadow;
			WSTRING_val.Cyclic = WSTRING_val.Shadow;
			TIME_val.Cyclic = TIME_val.Shadow;
			TIME_OF_DAY_val.Cyclic = TIME_OF_DAY_val.Shadow;
			DATE_val.Cyclic = DATE_val.Shadow;
			DATE_AND_TIME_val.Cyclic = DATE_AND_TIME_val.Shadow;
			TOD_val.Cyclic = TOD_val.Shadow;
			DT_val.Cyclic = DT_val.Shadow;
			LTIME_val.Cyclic = LTIME_val.Shadow;
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray);
		}

		public PlainstTestStruct CreatePlainerType()
		{
			var cloned = new PlainstTestStruct();
			cloned.ValueTypeArray = new System.Int16[6, 4, 3];
			return cloned;
		}

		protected PlainstTestStruct CreatePlainerType(PlainstTestStruct cloned)
		{
			cloned.ValueTypeArray = new System.Int16[6, 4, 3];
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

		public void FlushPlainToOnline(Plc.PlainstTestStruct source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstTestStruct source)
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

		public void FlushOnlineToPlain(Plc.PlainstTestStruct source)
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

		public stTestStruct(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_BOOL_val = @Connector.Online.Adapter.CreateBOOL(this, "BOOL", "BOOL_val");
			BOOL_val.AttributeName = "BOOL";
			_BYTE_val = @Connector.Online.Adapter.CreateBYTE(this, "BYTE", "BYTE_val");
			BYTE_val.AttributeName = "BYTE";
			_WORD_val = @Connector.Online.Adapter.CreateWORD(this, "WORD", "WORD_val");
			WORD_val.AttributeName = "WORD";
			_DWORD_val = @Connector.Online.Adapter.CreateDWORD(this, "DWORD", "DWORD_val");
			DWORD_val.AttributeName = "DWORD";
			_LWORD_val = @Connector.Online.Adapter.CreateLWORD(this, "LWORD", "LWORD_val");
			LWORD_val.AttributeName = "LWORD";
			_SINT_val = @Connector.Online.Adapter.CreateSINT(this, "SINT", "SINT_val");
			SINT_val.AttributeName = "SINT";
			_USINT_val = @Connector.Online.Adapter.CreateUSINT(this, "USINT", "USINT_val");
			USINT_val.AttributeName = "USINT";
			_INT_val = @Connector.Online.Adapter.CreateINT(this, "INT", "INT_val");
			INT_val.AttributeName = "INT";
			_UINT_val = @Connector.Online.Adapter.CreateUINT(this, "UINT", "UINT_val");
			UINT_val.AttributeName = "UINT";
			_DINT_val = @Connector.Online.Adapter.CreateDINT(this, "DINT", "DINT_val");
			DINT_val.AttributeName = "DINT";
			_UDINT_val = @Connector.Online.Adapter.CreateUDINT(this, "UDINT", "UDINT_val");
			UDINT_val.AttributeName = "UDINT";
			_LINT_val = @Connector.Online.Adapter.CreateLINT(this, "LINT", "LINT_val");
			LINT_val.AttributeName = "LINT";
			_ULINT_val = @Connector.Online.Adapter.CreateULINT(this, "ULINT", "ULINT_val");
			ULINT_val.AttributeName = "ULINT";
			_REAL_val = @Connector.Online.Adapter.CreateREAL(this, "REAL", "REAL_val");
			REAL_val.AttributeName = "REAL";
			_LREAL_val = @Connector.Online.Adapter.CreateLREAL(this, "LREAL", "LREAL_val");
			LREAL_val.AttributeName = "LREAL";
			_STRING_val = @Connector.Online.Adapter.CreateSTRING(this, "STRING(82)", "STRING_val");
			STRING_val.AttributeName = "STRING(82)";
			_WSTRING_val = @Connector.Online.Adapter.CreateWSTRING(this, "WSTRING(82)", "WSTRING_val");
			WSTRING_val.AttributeName = "WSTRING(82)";
			_TIME_val = @Connector.Online.Adapter.CreateTIME(this, "TIME", "TIME_val");
			TIME_val.AttributeName = "TIME";
			_TIME_OF_DAY_val = @Connector.Online.Adapter.CreateTIME_OF_DAY(this, "TIME OF DAY", "TIME_OF_DAY_val");
			TIME_OF_DAY_val.AttributeName = "TIME OF DAY";
			_DATE_val = @Connector.Online.Adapter.CreateDATE(this, "DATE", "DATE_val");
			DATE_val.AttributeName = "DATE";
			_DATE_AND_TIME_val = @Connector.Online.Adapter.CreateDATE_TIME(this, "DATE TIME", "DATE_AND_TIME_val");
			DATE_AND_TIME_val.AttributeName = "DATE TIME";
			_TOD_val = @Connector.Online.Adapter.CreateTIME_OF_DAY(this, "TOD", "TOD_val");
			TOD_val.AttributeName = "TOD";
			_DT_val = @Connector.Online.Adapter.CreateDATE_TIME(this, "DT", "DT_val");
			DT_val.AttributeName = "DT";
			_LTIME_val = @Connector.Online.Adapter.CreateLTIME(this, "LTIME", "LTIME_val");
			LTIME_val.AttributeName = "LTIME";
			ValueTypeArray = new Vortex.Connector.ValueTypes.OnlinerInt[6, 4, 3];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(ValueTypeArray, this, "ARRAY OF BASE TYPES", "ValueTypeArray", (p, rt, st) => @Connector.Online.Adapter.CreateINT(p, rt, st));
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stTestStruct()
		{
			PexPreConstructorParameterless();
			_BOOL_val = Vortex.Connector.IConnectorFactory.CreateBOOL();
			BOOL_val.AttributeName = "BOOL";
			_BYTE_val = Vortex.Connector.IConnectorFactory.CreateBYTE();
			BYTE_val.AttributeName = "BYTE";
			_WORD_val = Vortex.Connector.IConnectorFactory.CreateWORD();
			WORD_val.AttributeName = "WORD";
			_DWORD_val = Vortex.Connector.IConnectorFactory.CreateDWORD();
			DWORD_val.AttributeName = "DWORD";
			_LWORD_val = Vortex.Connector.IConnectorFactory.CreateLWORD();
			LWORD_val.AttributeName = "LWORD";
			_SINT_val = Vortex.Connector.IConnectorFactory.CreateSINT();
			SINT_val.AttributeName = "SINT";
			_USINT_val = Vortex.Connector.IConnectorFactory.CreateUSINT();
			USINT_val.AttributeName = "USINT";
			_INT_val = Vortex.Connector.IConnectorFactory.CreateINT();
			INT_val.AttributeName = "INT";
			_UINT_val = Vortex.Connector.IConnectorFactory.CreateUINT();
			UINT_val.AttributeName = "UINT";
			_DINT_val = Vortex.Connector.IConnectorFactory.CreateDINT();
			DINT_val.AttributeName = "DINT";
			_UDINT_val = Vortex.Connector.IConnectorFactory.CreateUDINT();
			UDINT_val.AttributeName = "UDINT";
			_LINT_val = Vortex.Connector.IConnectorFactory.CreateLINT();
			LINT_val.AttributeName = "LINT";
			_ULINT_val = Vortex.Connector.IConnectorFactory.CreateULINT();
			ULINT_val.AttributeName = "ULINT";
			_REAL_val = Vortex.Connector.IConnectorFactory.CreateREAL();
			REAL_val.AttributeName = "REAL";
			_LREAL_val = Vortex.Connector.IConnectorFactory.CreateLREAL();
			LREAL_val.AttributeName = "LREAL";
			_STRING_val = Vortex.Connector.IConnectorFactory.CreateSTRING();
			STRING_val.AttributeName = "STRING(82)";
			_WSTRING_val = Vortex.Connector.IConnectorFactory.CreateWSTRING();
			WSTRING_val.AttributeName = "WSTRING(82)";
			_TIME_val = Vortex.Connector.IConnectorFactory.CreateTIME();
			TIME_val.AttributeName = "TIME";
			_TIME_OF_DAY_val = Vortex.Connector.IConnectorFactory.CreateTIME_OF_DAY();
			TIME_OF_DAY_val.AttributeName = "TIME OF DAY";
			_DATE_val = Vortex.Connector.IConnectorFactory.CreateDATE();
			DATE_val.AttributeName = "DATE";
			_DATE_AND_TIME_val = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			DATE_AND_TIME_val.AttributeName = "DATE TIME";
			_TOD_val = Vortex.Connector.IConnectorFactory.CreateTIME_OF_DAY();
			TOD_val.AttributeName = "TOD";
			_DT_val = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			DT_val.AttributeName = "DT";
			_LTIME_val = Vortex.Connector.IConnectorFactory.CreateLTIME();
			LTIME_val.AttributeName = "LTIME";
			ValueTypeArray = new Vortex.Connector.ValueTypes.OnlinerInt[6, 4, 3];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(ValueTypeArray, () => Vortex.Connector.IConnectorFactory.CreateINT());
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstTestStruct
	{
		public void CopyPlainToCyclic(Plc.stTestStruct target)
		{
			target.BOOL_val.Cyclic = BOOL_val;
			target.BYTE_val.Cyclic = BYTE_val;
			target.WORD_val.Cyclic = WORD_val;
			target.DWORD_val.Cyclic = DWORD_val;
			target.LWORD_val.Cyclic = LWORD_val;
			target.SINT_val.Cyclic = SINT_val;
			target.USINT_val.Cyclic = USINT_val;
			target.INT_val.Cyclic = INT_val;
			target.UINT_val.Cyclic = UINT_val;
			target.DINT_val.Cyclic = DINT_val;
			target.UDINT_val.Cyclic = UDINT_val;
			target.LINT_val.Cyclic = LINT_val;
			target.ULINT_val.Cyclic = ULINT_val;
			target.REAL_val.Cyclic = REAL_val;
			target.LREAL_val.Cyclic = LREAL_val;
			target.STRING_val.Cyclic = STRING_val;
			target.WSTRING_val.Cyclic = WSTRING_val;
			target.TIME_val.Cyclic = TIME_val;
			target.TIME_OF_DAY_val.Cyclic = TIME_OF_DAY_val;
			target.DATE_val.Cyclic = DATE_val;
			target.DATE_AND_TIME_val.Cyclic = DATE_AND_TIME_val;
			target.TOD_val.Cyclic = TOD_val;
			target.DT_val.Cyclic = DT_val;
			target.LTIME_val.Cyclic = LTIME_val;
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.Int16, Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray, target.ValueTypeArray);
		}

		public void CopyPlainToCyclic(Plc.IstTestStruct target)
		{
			this.CopyPlainToCyclic((Plc.stTestStruct)target);
		}

		public void CopyPlainToShadow(Plc.stTestStruct target)
		{
			target.BOOL_val.Shadow = BOOL_val;
			target.BYTE_val.Shadow = BYTE_val;
			target.WORD_val.Shadow = WORD_val;
			target.DWORD_val.Shadow = DWORD_val;
			target.LWORD_val.Shadow = LWORD_val;
			target.SINT_val.Shadow = SINT_val;
			target.USINT_val.Shadow = USINT_val;
			target.INT_val.Shadow = INT_val;
			target.UINT_val.Shadow = UINT_val;
			target.DINT_val.Shadow = DINT_val;
			target.UDINT_val.Shadow = UDINT_val;
			target.LINT_val.Shadow = LINT_val;
			target.ULINT_val.Shadow = ULINT_val;
			target.REAL_val.Shadow = REAL_val;
			target.LREAL_val.Shadow = LREAL_val;
			target.STRING_val.Shadow = STRING_val;
			target.WSTRING_val.Shadow = WSTRING_val;
			target.TIME_val.Shadow = TIME_val;
			target.TIME_OF_DAY_val.Shadow = TIME_OF_DAY_val;
			target.DATE_val.Shadow = DATE_val;
			target.DATE_AND_TIME_val.Shadow = DATE_AND_TIME_val;
			target.TOD_val.Shadow = TOD_val;
			target.DT_val.Shadow = DT_val;
			target.LTIME_val.Shadow = LTIME_val;
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.Int16, Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray, target.ValueTypeArray);
		}

		public void CopyPlainToShadow(Plc.IShadowstTestStruct target)
		{
			this.CopyPlainToShadow((Plc.stTestStruct)target);
		}

		public void CopyCyclicToPlain(Plc.stTestStruct source)
		{
			BOOL_val = source.BOOL_val.LastValue;
			BYTE_val = source.BYTE_val.LastValue;
			WORD_val = source.WORD_val.LastValue;
			DWORD_val = source.DWORD_val.LastValue;
			LWORD_val = source.LWORD_val.LastValue;
			SINT_val = source.SINT_val.LastValue;
			USINT_val = source.USINT_val.LastValue;
			INT_val = source.INT_val.LastValue;
			UINT_val = source.UINT_val.LastValue;
			DINT_val = source.DINT_val.LastValue;
			UDINT_val = source.UDINT_val.LastValue;
			LINT_val = source.LINT_val.LastValue;
			ULINT_val = source.ULINT_val.LastValue;
			REAL_val = source.REAL_val.LastValue;
			LREAL_val = source.LREAL_val.LastValue;
			STRING_val = source.STRING_val.LastValue;
			WSTRING_val = source.WSTRING_val.LastValue;
			TIME_val = source.TIME_val.LastValue;
			TIME_OF_DAY_val = source.TIME_OF_DAY_val.LastValue;
			DATE_val = source.DATE_val.LastValue;
			DATE_AND_TIME_val = source.DATE_AND_TIME_val.LastValue;
			TOD_val = source.TOD_val.LastValue;
			DT_val = source.DT_val.LastValue;
			LTIME_val = source.LTIME_val.LastValue;
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerInt, System.Int16>(source.ValueTypeArray, ValueTypeArray);
		}

		public void CopyCyclicToPlain(Plc.IstTestStruct source)
		{
			this.CopyCyclicToPlain((Plc.stTestStruct)source);
		}

		public void CopyShadowToPlain(Plc.stTestStruct source)
		{
			BOOL_val = source.BOOL_val.Shadow;
			BYTE_val = source.BYTE_val.Shadow;
			WORD_val = source.WORD_val.Shadow;
			DWORD_val = source.DWORD_val.Shadow;
			LWORD_val = source.LWORD_val.Shadow;
			SINT_val = source.SINT_val.Shadow;
			USINT_val = source.USINT_val.Shadow;
			INT_val = source.INT_val.Shadow;
			UINT_val = source.UINT_val.Shadow;
			DINT_val = source.DINT_val.Shadow;
			UDINT_val = source.UDINT_val.Shadow;
			LINT_val = source.LINT_val.Shadow;
			ULINT_val = source.ULINT_val.Shadow;
			REAL_val = source.REAL_val.Shadow;
			LREAL_val = source.LREAL_val.Shadow;
			STRING_val = source.STRING_val.Shadow;
			WSTRING_val = source.WSTRING_val.Shadow;
			TIME_val = source.TIME_val.Shadow;
			TIME_OF_DAY_val = source.TIME_OF_DAY_val.Shadow;
			DATE_val = source.DATE_val.Shadow;
			DATE_AND_TIME_val = source.DATE_AND_TIME_val.Shadow;
			TOD_val = source.TOD_val.Shadow;
			DT_val = source.DT_val.Shadow;
			LTIME_val = source.LTIME_val.Shadow;
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerInt, System.Int16>(source.ValueTypeArray, ValueTypeArray);
		}

		public void CopyShadowToPlain(Plc.IShadowstTestStruct source)
		{
			this.CopyShadowToPlain((Plc.stTestStruct)source);
		}
	}
}