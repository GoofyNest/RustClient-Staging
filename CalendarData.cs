internal class CalendarData // TypeDefIndex: 688
{	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0

	// Methods

	// RVA: 0x10D2520 Offset: 0x10D0B20 VA: 0x1810D2520
	private void .ctor() { }

	// RVA: 0x10D05B0 Offset: 0x10CEBB0 VA: 0x1810D05B0
	private static void .cctor() { }

	// RVA: 0x10D1DC0 Offset: 0x10D03C0 VA: 0x1810D1DC0
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x10CFDE0 Offset: 0x10CE3E0 VA: 0x1810CFDE0
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x10CF930 Offset: 0x10CDF30 VA: 0x1810CF930
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x10CF7B0 Offset: 0x10CDDB0 VA: 0x1810CF7B0
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x10CF690 Offset: 0x10CDC90 VA: 0x1810CF690
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x10D2550 Offset: 0x10D0B50 VA: 0x1810D2550
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x10D2540 Offset: 0x10D0B40 VA: 0x1810D2540
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

}

