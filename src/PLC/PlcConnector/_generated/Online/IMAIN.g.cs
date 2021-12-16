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
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		[Container(Layout.Stack)]
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

		[Container(Layout.Stack)]
		IstTestStruct _testStruct
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
}