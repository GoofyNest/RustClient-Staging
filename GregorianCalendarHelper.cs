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

	// RVA: 0x16F1180 Offset: 0x16EF780 VA: 0x1816F1180
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x16F0760 Offset: 0x16EED60 VA: 0x1816F0760
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x16F0BC0 Offset: 0x16EF1C0 VA: 0x1816F0BC0
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x16F01F0 Offset: 0x16EE7F0 VA: 0x1816F01F0 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16EFFE0 Offset: 0x16EE5E0 VA: 0x1816EFFE0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x16EFF60 Offset: 0x16EE560 VA: 0x1816EFF60
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x16F0C70 Offset: 0x16EF270 VA: 0x1816F0C70
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16EFDA0 Offset: 0x16EE3A0 VA: 0x1816EFDA0
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x16F0410 Offset: 0x16EEA10 VA: 0x1816F0410
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F0450 Offset: 0x16EEA50 VA: 0x1816F0450
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F04C0 Offset: 0x16EEAC0 VA: 0x1816F04C0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F0680 Offset: 0x16EEC80 VA: 0x1816F0680
	public int GetEra(DateTime time) { }

	// RVA: 0x16F1260 Offset: 0x16EF860 VA: 0x1816F1260
	public int[] get_Eras() { }

	// RVA: 0x16F09F0 Offset: 0x16EEFF0 VA: 0x1816F09F0
	public int GetMonth(DateTime time) { }

	// RVA: 0x16F0A30 Offset: 0x16EF030 VA: 0x1816F0A30
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F0A50 Offset: 0x16EF050 VA: 0x1816F0A50
	public int GetYear(DateTime time) { }

	// RVA: 0x16F0B50 Offset: 0x16EF150 VA: 0x1816F0B50
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F0E10 Offset: 0x16EF410 VA: 0x1816F0E10
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F10D0 Offset: 0x16EF6D0 VA: 0x1816F10D0
	private static void .cctor() { }

}

