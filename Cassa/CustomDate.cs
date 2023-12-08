using System;

namespace Cassa
{
	internal struct CustomDate
	{
		internal ushort wYear;

		internal ushort wMonth;

		internal ushort wDay;

		/** inserire parametro a 0 per impostare il corrispettivo odierno */
		internal CustomDate(int year, int month = 1, int day = 1)
		{
			CustomDate today = Today;
			if(year == 0)
				wYear = (ushort)today.Year;
			else wYear = (ushort)year;
			if(month == 0)
				wMonth = (ushort)today.Month;
			else wMonth = (ushort)month;
			if(day == 0)
				wDay = (ushort)today.Day;
			else wDay = (ushort)day;
		}

		public static CustomDate Today => (CustomDate)DateTime.Today;

		public static int ThisYear => DateTime.Today.Year;

		public override bool Equals(object obj)
		{
			return obj is CustomDate date&&
						 wYear==date.wYear&&
						 wMonth==date.wMonth&&
						 wDay==date.wDay;
		}

		public override int GetHashCode()
		{
			int hashCode = -370995715;
			hashCode=hashCode*-1521134295+wYear.GetHashCode();
			hashCode=hashCode*-1521134295+wMonth.GetHashCode();
			hashCode=hashCode*-1521134295+wDay.GetHashCode();
			return hashCode;
		}

		public static bool operator ==(CustomDate left, CustomDate right)
		{
			return left.wYear == right.wYear && left.wMonth == right.wMonth && left.wDay == right.wDay;
		}
		public static bool operator !=(CustomDate left, CustomDate right)
		{
			return left.wYear != right.wYear && left.wMonth != right.wMonth && left.wDay != right.wDay;
		}

		public static explicit operator CustomDate(DateTime v)
		{
			return new CustomDate
			{
				Year = v.Year,
				Month = v.Month,
				Day = v.Day
			};
		}

		public override string ToString() => $"{Day:D2}/{Month:D2}/{Year:D4}";

		public int Year
		{
			get => wYear;
			set => wYear = (ushort)value;
		}
		public int Month
		{
			get => wMonth;
			set => wMonth = (ushort)value;
		}
		public int Day
		{
			get => wDay;
			set => wDay = (ushort)value;
		}

	}
}
