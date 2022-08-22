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

	// RVA: 0x16D9130 Offset: 0x16D7730 VA: 0x1816D9130
	private void .ctor(string name) { }

	// RVA: 0x16D9310 Offset: 0x16D7910 VA: 0x1816D9310
	public static CultureData get_Invariant() { }

	// RVA: 0x16D8950 Offset: 0x16D6F50 VA: 0x1816D8950
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x16D89F0 Offset: 0x16D6FF0 VA: 0x1816D89F0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x16D9160 Offset: 0x16D7760 VA: 0x1816D9160
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x16D8800 Offset: 0x16D6E00 VA: 0x1816D8800
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x1368D00 Offset: 0x1367300 VA: 0x181368D00
	internal string[] get_LongTimes() { }

	// RVA: 0x16D97F0 Offset: 0x16D7DF0 VA: 0x1816D97F0
	internal string[] get_ShortTimes() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_SAM1159() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_SPM2359() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_TimeSeparator() { }

	// RVA: 0x16D9180 Offset: 0x16D7780 VA: 0x1816D9180
	internal int[] get_CalendarIds() { }

	// RVA: 0x16D97B0 Offset: 0x16D7DB0 VA: 0x1816D97B0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal string get_CultureName() { }

	// RVA: 0x16D97C0 Offset: 0x16D7DC0 VA: 0x1816D97C0
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal string get_STEXTINFO() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal int get_ILANGUAGE() { }

	// RVA: 0xA4F2B0 Offset: 0xA4D8B0 VA: 0x180A4F2B0
	internal bool get_UseUserOverride() { }

	// RVA: 0x16D87C0 Offset: 0x16D6DC0 VA: 0x1816D87C0
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x16D8670 Offset: 0x16D6C70 VA: 0x1816D8670
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x16D86B0 Offset: 0x16D6CB0 VA: 0x1816D86B0
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x16D8F60 Offset: 0x16D7560 VA: 0x1816D8F60
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x16D8F00 Offset: 0x16D7500 VA: 0x1816D8F00
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x16D9110 Offset: 0x16D7710 VA: 0x1816D9110
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x16D87A0 Offset: 0x16D6DA0 VA: 0x1816D87A0
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x16D8690 Offset: 0x16D6C90 VA: 0x1816D8690
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x16D8F40 Offset: 0x16D7540 VA: 0x1816D8F40
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x16D87E0 Offset: 0x16D6DE0 VA: 0x1816D87E0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D8700 Offset: 0x16D6D00 VA: 0x1816D8700
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x16D86D0 Offset: 0x16D6CD0 VA: 0x1816D86D0
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D8ED0 Offset: 0x16D74D0 VA: 0x1816D8ED0
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x16D8F20 Offset: 0x16D7520 VA: 0x1816D8F20
	internal string MonthDay(int calendarId) { }

	// RVA: 0x16D8720 Offset: 0x16D6D20 VA: 0x1816D8720
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x16D8B00 Offset: 0x16D7100 VA: 0x1816D8B00
	private static string GetDateSeparator(string format) { }

	// RVA: 0x16D8BD0 Offset: 0x16D71D0 VA: 0x1816D8BD0
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x16D8DE0 Offset: 0x16D73E0 VA: 0x1816D8DE0
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x16D8F80 Offset: 0x16D7580 VA: 0x1816D8F80
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x16D8B40 Offset: 0x16D7140 VA: 0x1816D8B40
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x16D9170 Offset: 0x16D7770 VA: 0x1816D9170
	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }

}

