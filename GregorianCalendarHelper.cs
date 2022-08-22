internal class GregorianCalendarHelper // TypeDefIndex: 704
{	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal int m_maxYear; // 0x10
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal int[] m_eras; // 0x28
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int get_MaxYear() { }

	// RVA: 0x16F3590 Offset: 0x16F1B90 VA: 0x1816F3590
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x16F2B70 Offset: 0x16F1170 VA: 0x1816F2B70
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x16F2FD0 Offset: 0x16F15D0 VA: 0x1816F2FD0
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x16F2600 Offset: 0x16F0C00 VA: 0x1816F2600 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F23F0 Offset: 0x16F09F0 VA: 0x1816F23F0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x16F2370 Offset: 0x16F0970 VA: 0x1816F2370
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x16F3080 Offset: 0x16F1680 VA: 0x1816F3080
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16F21B0 Offset: 0x16F07B0 VA: 0x1816F21B0
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x16F2820 Offset: 0x16F0E20 VA: 0x1816F2820
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F2860 Offset: 0x16F0E60 VA: 0x1816F2860
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F28D0 Offset: 0x16F0ED0 VA: 0x1816F28D0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F2A90 Offset: 0x16F1090 VA: 0x1816F2A90
	public int GetEra(DateTime time) { }

	// RVA: 0x16F3670 Offset: 0x16F1C70 VA: 0x1816F3670
	public int[] get_Eras() { }

	// RVA: 0x16F2E00 Offset: 0x16F1400 VA: 0x1816F2E00
	public int GetMonth(DateTime time) { }

	// RVA: 0x16F2E40 Offset: 0x16F1440 VA: 0x1816F2E40
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F2E60 Offset: 0x16F1460 VA: 0x1816F2E60
	public int GetYear(DateTime time) { }

	// RVA: 0x16F2F60 Offset: 0x16F1560 VA: 0x1816F2F60
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F3220 Offset: 0x16F1820 VA: 0x1816F3220
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F34E0 Offset: 0x16F1AE0 VA: 0x1816F34E0
	private static void .cctor() { }

}

