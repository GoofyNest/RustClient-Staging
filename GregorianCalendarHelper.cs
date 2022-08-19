internal class GregorianCalendarHelper // TypeDefIndex: 704
{	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal int m_maxYear; // 0x10
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal int[] m_eras; // 0x28
	[OptionalFieldAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int get_MaxYear() { }

	// RVA: 0x16F32D0 Offset: 0x16F18D0 VA: 0x1816F32D0
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x16F28B0 Offset: 0x16F0EB0 VA: 0x1816F28B0
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x16F2D10 Offset: 0x16F1310 VA: 0x1816F2D10
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x16F2340 Offset: 0x16F0940 VA: 0x1816F2340 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F2130 Offset: 0x16F0730 VA: 0x1816F2130
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x16F20B0 Offset: 0x16F06B0 VA: 0x1816F20B0
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x16F2DC0 Offset: 0x16F13C0 VA: 0x1816F2DC0
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16F1EF0 Offset: 0x16F04F0 VA: 0x1816F1EF0
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x16F2560 Offset: 0x16F0B60 VA: 0x1816F2560
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F25A0 Offset: 0x16F0BA0 VA: 0x1816F25A0
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F2610 Offset: 0x16F0C10 VA: 0x1816F2610
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F27D0 Offset: 0x16F0DD0 VA: 0x1816F27D0
	public int GetEra(DateTime time) { }

	// RVA: 0x16F33B0 Offset: 0x16F19B0 VA: 0x1816F33B0
	public int[] get_Eras() { }

	// RVA: 0x16F2B40 Offset: 0x16F1140 VA: 0x1816F2B40
	public int GetMonth(DateTime time) { }

	// RVA: 0x16F2B80 Offset: 0x16F1180 VA: 0x1816F2B80
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F2BA0 Offset: 0x16F11A0 VA: 0x1816F2BA0
	public int GetYear(DateTime time) { }

	// RVA: 0x16F2CA0 Offset: 0x16F12A0 VA: 0x1816F2CA0
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F2F60 Offset: 0x16F1560 VA: 0x1816F2F60
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F3220 Offset: 0x16F1820 VA: 0x1816F3220
	private static void .cctor() { }

}

