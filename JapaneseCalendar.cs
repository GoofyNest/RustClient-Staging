public class JapaneseCalendar : Calendar // TypeDefIndex: 712
{	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x13844E0 Offset: 0x1382AE0 VA: 0x1813844E0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1384480 Offset: 0x1382A80 VA: 0x181384480 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1383BC0 Offset: 0x13821C0 VA: 0x181383BC0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x1383AC0 Offset: 0x13820C0 VA: 0x181383AC0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1384330 Offset: 0x1382930 VA: 0x181384330
	public void .ctor() { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1383A90 Offset: 0x1382090 VA: 0x181383A90 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1383A50 Offset: 0x1382050 VA: 0x181383A50 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1383A70 Offset: 0x1382070 VA: 0x181383A70 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1384090 Offset: 0x1382690 VA: 0x181384090 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1384050 Offset: 0x1382650 VA: 0x181384050 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x1384070 Offset: 0x1382670 VA: 0x181384070 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x13840B0 Offset: 0x13826B0 VA: 0x1813840B0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x13840D0 Offset: 0x13826D0 VA: 0x1813840D0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1384110 Offset: 0x1382710 VA: 0x181384110 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1384140 Offset: 0x1382740 VA: 0x181384140 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1384460 Offset: 0x1382A60 VA: 0x181384460 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x1383920 Offset: 0x1381F20 VA: 0x181383920
	internal static string[] EraNames() { }

	// RVA: 0x13836C0 Offset: 0x1381CC0 VA: 0x1813836C0
	internal static string[] AbbrevEraNames() { }

	// RVA: 0x13837F0 Offset: 0x1381DF0 VA: 0x1813837F0
	internal static string[] EnglishEraNames() { }

	// RVA: 0x13840F0 Offset: 0x13826F0 VA: 0x1813840F0 Slot: 23
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x1384540 Offset: 0x1382B40 VA: 0x181384540 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x13842D0 Offset: 0x13828D0 VA: 0x1813842D0
	private static void .cctor() { }

}

