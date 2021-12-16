using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstTestStruct : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool BOOL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte BYTE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord WORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord DWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLWord LWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowSInt SINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt USINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt INT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt UINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt DINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt UDINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLInt LINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowULInt ULINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal REAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal LREAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString STRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWString WSTRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay TIME_OF_DAY_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate DATE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime DATE_AND_TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay TOD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime DT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLTime LTIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt[,, ] ValueTypeArray
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstTestStruct CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstTestStruct source);
	}
}