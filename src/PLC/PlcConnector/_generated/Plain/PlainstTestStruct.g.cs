using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstTestStruct : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _BOOL_val;
		public System.Boolean BOOL_val
		{
			get
			{
				return _BOOL_val;
			}

			set
			{
				if (_BOOL_val != value)
				{
					_BOOL_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BOOL_val)));
				}
			}
		}

		System.Byte _BYTE_val;
		public System.Byte BYTE_val
		{
			get
			{
				return _BYTE_val;
			}

			set
			{
				if (_BYTE_val != value)
				{
					_BYTE_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BYTE_val)));
				}
			}
		}

		System.UInt16 _WORD_val;
		public System.UInt16 WORD_val
		{
			get
			{
				return _WORD_val;
			}

			set
			{
				if (_WORD_val != value)
				{
					_WORD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WORD_val)));
				}
			}
		}

		System.UInt32 _DWORD_val;
		public System.UInt32 DWORD_val
		{
			get
			{
				return _DWORD_val;
			}

			set
			{
				if (_DWORD_val != value)
				{
					_DWORD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DWORD_val)));
				}
			}
		}

		System.UInt64 _LWORD_val;
		public System.UInt64 LWORD_val
		{
			get
			{
				return _LWORD_val;
			}

			set
			{
				if (_LWORD_val != value)
				{
					_LWORD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LWORD_val)));
				}
			}
		}

		System.SByte _SINT_val;
		public System.SByte SINT_val
		{
			get
			{
				return _SINT_val;
			}

			set
			{
				if (_SINT_val != value)
				{
					_SINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SINT_val)));
				}
			}
		}

		System.Byte _USINT_val;
		public System.Byte USINT_val
		{
			get
			{
				return _USINT_val;
			}

			set
			{
				if (_USINT_val != value)
				{
					_USINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(USINT_val)));
				}
			}
		}

		System.Int16 _INT_val;
		public System.Int16 INT_val
		{
			get
			{
				return _INT_val;
			}

			set
			{
				if (_INT_val != value)
				{
					_INT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(INT_val)));
				}
			}
		}

		System.UInt16 _UINT_val;
		public System.UInt16 UINT_val
		{
			get
			{
				return _UINT_val;
			}

			set
			{
				if (_UINT_val != value)
				{
					_UINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(UINT_val)));
				}
			}
		}

		System.Int32 _DINT_val;
		public System.Int32 DINT_val
		{
			get
			{
				return _DINT_val;
			}

			set
			{
				if (_DINT_val != value)
				{
					_DINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DINT_val)));
				}
			}
		}

		System.UInt32 _UDINT_val;
		public System.UInt32 UDINT_val
		{
			get
			{
				return _UDINT_val;
			}

			set
			{
				if (_UDINT_val != value)
				{
					_UDINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(UDINT_val)));
				}
			}
		}

		System.Int64 _LINT_val;
		public System.Int64 LINT_val
		{
			get
			{
				return _LINT_val;
			}

			set
			{
				if (_LINT_val != value)
				{
					_LINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LINT_val)));
				}
			}
		}

		System.UInt64 _ULINT_val;
		public System.UInt64 ULINT_val
		{
			get
			{
				return _ULINT_val;
			}

			set
			{
				if (_ULINT_val != value)
				{
					_ULINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ULINT_val)));
				}
			}
		}

		System.Single _REAL_val;
		public System.Single REAL_val
		{
			get
			{
				return _REAL_val;
			}

			set
			{
				if (_REAL_val != value)
				{
					_REAL_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(REAL_val)));
				}
			}
		}

		System.Double _LREAL_val;
		public System.Double LREAL_val
		{
			get
			{
				return _LREAL_val;
			}

			set
			{
				if (_LREAL_val != value)
				{
					_LREAL_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LREAL_val)));
				}
			}
		}

		System.String _STRING_val;
		public System.String STRING_val
		{
			get
			{
				return _STRING_val;
			}

			set
			{
				if (_STRING_val != value)
				{
					_STRING_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(STRING_val)));
				}
			}
		}

		System.String _WSTRING_val;
		public System.String WSTRING_val
		{
			get
			{
				return _WSTRING_val;
			}

			set
			{
				if (_WSTRING_val != value)
				{
					_WSTRING_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WSTRING_val)));
				}
			}
		}

		System.TimeSpan _TIME_val;
		public System.TimeSpan TIME_val
		{
			get
			{
				return _TIME_val;
			}

			set
			{
				if (_TIME_val != value)
				{
					_TIME_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TIME_val)));
				}
			}
		}

		System.TimeSpan _TIME_OF_DAY_val;
		public System.TimeSpan TIME_OF_DAY_val
		{
			get
			{
				return _TIME_OF_DAY_val;
			}

			set
			{
				if (_TIME_OF_DAY_val != value)
				{
					_TIME_OF_DAY_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TIME_OF_DAY_val)));
				}
			}
		}

		System.DateTime _DATE_val;
		public System.DateTime DATE_val
		{
			get
			{
				return _DATE_val;
			}

			set
			{
				if (_DATE_val != value)
				{
					_DATE_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DATE_val)));
				}
			}
		}

		System.DateTime _DATE_AND_TIME_val;
		public System.DateTime DATE_AND_TIME_val
		{
			get
			{
				return _DATE_AND_TIME_val;
			}

			set
			{
				if (_DATE_AND_TIME_val != value)
				{
					_DATE_AND_TIME_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DATE_AND_TIME_val)));
				}
			}
		}

		System.TimeSpan _TOD_val;
		public System.TimeSpan TOD_val
		{
			get
			{
				return _TOD_val;
			}

			set
			{
				if (_TOD_val != value)
				{
					_TOD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TOD_val)));
				}
			}
		}

		System.DateTime _DT_val;
		public System.DateTime DT_val
		{
			get
			{
				return _DT_val;
			}

			set
			{
				if (_DT_val != value)
				{
					_DT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DT_val)));
				}
			}
		}

		System.TimeSpan _LTIME_val;
		public System.TimeSpan LTIME_val
		{
			get
			{
				return _LTIME_val;
			}

			set
			{
				if (_LTIME_val != value)
				{
					_LTIME_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LTIME_val)));
				}
			}
		}

		public System.Int16[,, ] ValueTypeArray
		{
			get;
			set;
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstTestStruct()
		{
			ValueTypeArray = new System.Int16[6, 4, 3];
		}
	}
}