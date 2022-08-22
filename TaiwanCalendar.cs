public class TaiwanCalendar : Calendar // TypeDefIndex: 717
{	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x13863E0 Offset: 0x13849E0 VA: 0x1813863E0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1386960 Offset: 0x1384F60 VA: 0x181386960 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1386900 Offset: 0x1384F00 VA: 0x181386900 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x13867D0 Offset: 0x1384DD0 VA: 0x1813867D0
	public void .ctor() { }

	// RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1382E50 Offset: 0x1381450 VA: 0x181382E50 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1382E10 Offset: 0x1381410 VA: 0x181382E10 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1382E30 Offset: 0x1381430 VA: 0x181382E30 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1383450 Offset: 0x1381A50 VA: 0x181383450 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1383410 Offset: 0x1381A10 VA: 0x181383410 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x1383430 Offset: 0x1381A30 VA: 0x181383430 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1383470 Offset: 0x1381A70 VA: 0x181383470 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x1383490 Offset: 0x1381A90 VA: 0x181383490 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x13834D0 Offset: 0x1381AD0 VA: 0x1813834D0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1383820 Offset: 0x1381E20 VA: 0x181383820 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x1383900 Offset: 0x1381F00 VA: 0x181383900 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x13864E0 Offset: 0x1384AE0 VA: 0x1813864E0 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1386670 Offset: 0x1384C70 VA: 0x181386670
	private static void .cctor() { }

}

