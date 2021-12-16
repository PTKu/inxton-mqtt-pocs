using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstTestStruct : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool BOOL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte BYTE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord WORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord DWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLWord LWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineSInt SINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt USINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt INT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt UINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt DINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt UDINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLInt LINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineULInt ULINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal REAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal LREAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString STRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWString WSTRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay TIME_OF_DAY_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate DATE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime DATE_AND_TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay TOD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime DT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLTime LTIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt[,, ] ValueTypeArray
		{
			get;
			set;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstTestStruct CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstTestStruct source);
		void FlushOnlineToPlain(Plc.PlainstTestStruct source);
	}
}