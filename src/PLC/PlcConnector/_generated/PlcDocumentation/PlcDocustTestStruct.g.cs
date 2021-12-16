using System;

namespace PlcDocu.Plc
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class stTestStruct
	{
		public object BOOL_val;
		public object BYTE_val;
		public object WORD_val;
		public object DWORD_val;
		public object LWORD_val;
		public object SINT_val;
		public object USINT_val;
		public object INT_val;
		public object UINT_val;
		public object DINT_val;
		public object UDINT_val;
		public object LINT_val;
		public object ULINT_val;
		public object REAL_val;
		public object LREAL_val;
		public object STRING_val;
		public object WSTRING_val;
		public object TIME_val;
		public object TIME_OF_DAY_val;
		public object DATE_val;
		public object DATE_AND_TIME_val;
		public object TOD_val;
		public object DT_val;
		public object LTIME_val;
		public object ValueTypeArray;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public stTestStruct()
		{
		}
	}
#endif
}