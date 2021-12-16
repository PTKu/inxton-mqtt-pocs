using System;

namespace PlcDocu.Plc
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MAIN
	{
		public object Hello_World;
		public object Counter;
		public object Variable;
		public stTestStruct _testStruct;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MAIN()
		{
		}
	}
#endif
}