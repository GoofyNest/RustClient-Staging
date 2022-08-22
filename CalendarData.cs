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

	// RVA: 0x10D3250 Offset: 0x10D1850 VA: 0x1810D3250
	private void .ctor() { }

	// RVA: 0x10D12E0 Offset: 0x10CF8E0 VA: 0x1810D12E0
	private static void .cctor() { }

	// RVA: 0x10D2AF0 Offset: 0x10D10F0 VA: 0x1810D2AF0
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x10D0B10 Offset: 0x10CF110 VA: 0x1810D0B10
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x10D0660 Offset: 0x10CEC60 VA: 0x1810D0660
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x10D04E0 Offset: 0x10CEAE0 VA: 0x1810D04E0
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x10D03C0 Offset: 0x10CE9C0 VA: 0x1810D03C0
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x10D3280 Offset: 0x10D1880 VA: 0x1810D3280
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x10D3270 Offset: 0x10D1870 VA: 0x1810D3270
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

}

