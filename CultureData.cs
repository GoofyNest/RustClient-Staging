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

	// RVA: 0x16D8E70 Offset: 0x16D7470 VA: 0x1816D8E70
	private void .ctor(string name) { }

	// RVA: 0x16D9050 Offset: 0x16D7650 VA: 0x1816D9050
	public static CultureData get_Invariant() { }

	// RVA: 0x16D8690 Offset: 0x16D6C90 VA: 0x1816D8690
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x16D8730 Offset: 0x16D6D30 VA: 0x1816D8730
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x16D8EA0 Offset: 0x16D74A0 VA: 0x1816D8EA0
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x16D8540 Offset: 0x16D6B40 VA: 0x1816D8540
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x1368A40 Offset: 0x1367040 VA: 0x181368A40
	internal string[] get_LongTimes() { }

	// RVA: 0x16D9530 Offset: 0x16D7B30 VA: 0x1816D9530
	internal string[] get_ShortTimes() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_SAM1159() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_SPM2359() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_TimeSeparator() { }

	// RVA: 0x16D8EC0 Offset: 0x16D74C0 VA: 0x1816D8EC0
	internal int[] get_CalendarIds() { }

	// RVA: 0x16D94F0 Offset: 0x16D7AF0 VA: 0x1816D94F0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal string get_CultureName() { }

	// RVA: 0x16D9500 Offset: 0x16D7B00 VA: 0x1816D9500
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal string get_STEXTINFO() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal int get_ILANGUAGE() { }

	// RVA: 0xA4EFF0 Offset: 0xA4D5F0 VA: 0x180A4EFF0
	internal bool get_UseUserOverride() { }

	// RVA: 0x16D8500 Offset: 0x16D6B00 VA: 0x1816D8500
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x16D83B0 Offset: 0x16D69B0 VA: 0x1816D83B0
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x16D83F0 Offset: 0x16D69F0 VA: 0x1816D83F0
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x16D8CA0 Offset: 0x16D72A0 VA: 0x1816D8CA0
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x16D8C40 Offset: 0x16D7240 VA: 0x1816D8C40
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x16D8E50 Offset: 0x16D7450 VA: 0x1816D8E50
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x16D84E0 Offset: 0x16D6AE0 VA: 0x1816D84E0
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x16D83D0 Offset: 0x16D69D0 VA: 0x1816D83D0
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x16D8C80 Offset: 0x16D7280 VA: 0x1816D8C80
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x16D8520 Offset: 0x16D6B20 VA: 0x1816D8520
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D8440 Offset: 0x16D6A40 VA: 0x1816D8440
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x16D8410 Offset: 0x16D6A10 VA: 0x1816D8410
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D8C10 Offset: 0x16D7210 VA: 0x1816D8C10
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x16D8C60 Offset: 0x16D7260 VA: 0x1816D8C60
	internal string MonthDay(int calendarId) { }

	// RVA: 0x16D8460 Offset: 0x16D6A60 VA: 0x1816D8460
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x16D8840 Offset: 0x16D6E40 VA: 0x1816D8840
	private static string GetDateSeparator(string format) { }

	// RVA: 0x16D8910 Offset: 0x16D6F10 VA: 0x1816D8910
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x16D8B20 Offset: 0x16D7120 VA: 0x1816D8B20
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x16D8CC0 Offset: 0x16D72C0 VA: 0x1816D8CC0
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x16D8880 Offset: 0x16D6E80 VA: 0x1816D8880
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x16D8EB0 Offset: 0x16D74B0 VA: 0x1816D8EB0
	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }

}

