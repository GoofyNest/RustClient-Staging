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

	// RVA: 0x10D27E0 Offset: 0x10D0DE0 VA: 0x1810D27E0
	private void .ctor() { }

	// RVA: 0x10D0870 Offset: 0x10CEE70 VA: 0x1810D0870
	private static void .cctor() { }

	// RVA: 0x10D2080 Offset: 0x10D0680 VA: 0x1810D2080
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x10D00A0 Offset: 0x10CE6A0 VA: 0x1810D00A0
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x10CFBF0 Offset: 0x10CE1F0 VA: 0x1810CFBF0
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x10CFA70 Offset: 0x10CE070 VA: 0x1810CFA70
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x10CF950 Offset: 0x10CDF50 VA: 0x1810CF950
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x10D2810 Offset: 0x10D0E10 VA: 0x1810D2810
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x10D2800 Offset: 0x10D0E00 VA: 0x1810D2800
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

}

