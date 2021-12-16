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
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		[Container(Layout.Stack)]
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

		[Container(Layout.Stack)]
		IShadowstTestStruct _testStruct
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
}