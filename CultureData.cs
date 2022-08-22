internal class CultureData // TypeDefIndex: 734
{	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal int ILANGUAGE { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x16D6D20 Offset: 0x16D5320 VA: 0x1816D6D20
	private void .ctor(string name) { }

	// RVA: 0x16D6F00 Offset: 0x16D5500 VA: 0x1816D6F00
	public static CultureData get_Invariant() { }

	// RVA: 0x16D6540 Offset: 0x16D4B40 VA: 0x1816D6540
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x16D65E0 Offset: 0x16D4BE0 VA: 0x1816D65E0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x16D6D50 Offset: 0x16D5350 VA: 0x1816D6D50
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x16D63F0 Offset: 0x16D49F0 VA: 0x1816D63F0
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x1367E00 Offset: 0x1366400 VA: 0x181367E00
	internal string[] get_LongTimes() { }

	// RVA: 0x16D73E0 Offset: 0x16D59E0 VA: 0x1816D73E0
	internal string[] get_ShortTimes() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal string get_SAM1159() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_SPM2359() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_TimeSeparator() { }

	// RVA: 0x16D6D70 Offset: 0x16D5370 VA: 0x1816D6D70
	internal int[] get_CalendarIds() { }

	// RVA: 0x16D73A0 Offset: 0x16D59A0 VA: 0x1816D73A0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal string get_CultureName() { }

	// RVA: 0x16D73B0 Offset: 0x16D59B0 VA: 0x1816D73B0
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal string get_STEXTINFO() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal int get_ILANGUAGE() { }

	// RVA: 0xA4F780 Offset: 0xA4DD80 VA: 0x180A4F780
	internal bool get_UseUserOverride() { }

	// RVA: 0x16D63B0 Offset: 0x16D49B0 VA: 0x1816D63B0
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x16D6260 Offset: 0x16D4860 VA: 0x1816D6260
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x16D62A0 Offset: 0x16D48A0 VA: 0x1816D62A0
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x16D6B50 Offset: 0x16D5150 VA: 0x1816D6B50
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x16D6AF0 Offset: 0x16D50F0 VA: 0x1816D6AF0
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x16D6D00 Offset: 0x16D5300 VA: 0x1816D6D00
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x16D6390 Offset: 0x16D4990 VA: 0x1816D6390
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x16D6280 Offset: 0x16D4880 VA: 0x1816D6280
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x16D6B30 Offset: 0x16D5130 VA: 0x1816D6B30
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x16D63D0 Offset: 0x16D49D0 VA: 0x1816D63D0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D62F0 Offset: 0x16D48F0 VA: 0x1816D62F0
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x16D62C0 Offset: 0x16D48C0 VA: 0x1816D62C0
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D6AC0 Offset: 0x16D50C0 VA: 0x1816D6AC0
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x16D6B10 Offset: 0x16D5110 VA: 0x1816D6B10
	internal string MonthDay(int calendarId) { }

	// RVA: 0x16D6310 Offset: 0x16D4910 VA: 0x1816D6310
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x16D66F0 Offset: 0x16D4CF0 VA: 0x1816D66F0
	private static string GetDateSeparator(string format) { }

	// RVA: 0x16D67C0 Offset: 0x16D4DC0 VA: 0x1816D67C0
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x16D69D0 Offset: 0x16D4FD0 VA: 0x1816D69D0
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x16D6B70 Offset: 0x16D5170 VA: 0x1816D6B70
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x16D6730 Offset: 0x16D4D30 VA: 0x1816D6730
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x16D6D60 Offset: 0x16D5360 VA: 0x1816D6D60
	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }

}

