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

	// RVA: 0x13847A0 Offset: 0x1382DA0 VA: 0x1813847A0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1384740 Offset: 0x1382D40 VA: 0x181384740 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1383E80 Offset: 0x1382480 VA: 0x181383E80
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x1383D80 Offset: 0x1382380 VA: 0x181383D80
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x13845F0 Offset: 0x1382BF0 VA: 0x1813845F0
	public void .ctor() { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 7
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

	// RVA: 0x1384400 Offset: 0x1382A00 VA: 0x181384400 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1384720 Offset: 0x1382D20 VA: 0x181384720 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x1383BE0 Offset: 0x13821E0 VA: 0x181383BE0
	internal static string[] EraNames() { }

	// RVA: 0x1383980 Offset: 0x1381F80 VA: 0x181383980
	internal static string[] AbbrevEraNames() { }

	// RVA: 0x1383AB0 Offset: 0x13820B0 VA: 0x181383AB0
	internal static string[] EnglishEraNames() { }

	// RVA: 0x13843B0 Offset: 0x13829B0 VA: 0x1813843B0 Slot: 23
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x1384800 Offset: 0x1382E00 VA: 0x181384800 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1384590 Offset: 0x1382B90 VA: 0x181384590
	private static void .cctor() { }

}

