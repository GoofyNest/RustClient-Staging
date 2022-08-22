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

	// RVA: 0x13872E0 Offset: 0x13858E0 VA: 0x1813872E0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1387860 Offset: 0x1385E60 VA: 0x181387860 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1387800 Offset: 0x1385E00 VA: 0x181387800 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x13876D0 Offset: 0x1385CD0 VA: 0x1813876D0
	public void .ctor() { }

	// RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1383D50 Offset: 0x1382350 VA: 0x181383D50 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1383D10 Offset: 0x1382310 VA: 0x181383D10 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1383D30 Offset: 0x1382330 VA: 0x181383D30 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1384350 Offset: 0x1382950 VA: 0x181384350 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1384310 Offset: 0x1382910 VA: 0x181384310 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x1384330 Offset: 0x1382930 VA: 0x181384330 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1384370 Offset: 0x1382970 VA: 0x181384370 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x1384390 Offset: 0x1382990 VA: 0x181384390 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x13843D0 Offset: 0x13829D0 VA: 0x1813843D0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1384720 Offset: 0x1382D20 VA: 0x181384720 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x1384800 Offset: 0x1382E00 VA: 0x181384800 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x13873E0 Offset: 0x13859E0 VA: 0x1813873E0 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1387570 Offset: 0x1385B70 VA: 0x181387570
	private static void .cctor() { }

}

