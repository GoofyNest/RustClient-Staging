public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 314
{	// Fields
	private TimeSpan baseUtcOffset; // 0x10
	private string daylightDisplayName; // 0x18
	private string displayName; // 0x20
	private string id; // 0x28
	private static TimeZoneInfo local; // 0x0
	private List<KeyValuePair<DateTime, TimeType>> transitions; // 0x30
	private static bool readlinkNotFound; // 0x8
	private string standardDisplayName; // 0x38
	private bool supportsDaylightSavingTime; // 0x40
	private static TimeZoneInfo utc; // 0x10
	private static string timeZoneDirectory; // 0x18
	private TimeZoneInfo.AdjustmentRule[] adjustmentRules; // 0x48
	private static RegistryKey timeZoneKey; // 0x20
	private static RegistryKey localZoneKey; // 0x28
	private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; // 0x30

	// Properties
	public TimeSpan BaseUtcOffset { get; }
	public string DisplayName { get; }
	public string Id { get; }
	public static TimeZoneInfo Local { get; }
	public bool SupportsDaylightSavingTime { get; }
	public static TimeZoneInfo Utc { get; }
	private static string TimeZoneDirectory { get; }
	private static bool IsWindows { get; }
	private static RegistryKey TimeZoneKey { get; }
	private static RegistryKey LocalZoneKey { get; }

	// Methods

	// RVA: 0x1618C70 Offset: 0x1617270 VA: 0x181618C70
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x1610C50 Offset: 0x160F250 VA: 0x181610C50
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	// RVA: 0x16114E0 Offset: 0x160FAE0 VA: 0x1816114E0
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x1612DA0 Offset: 0x16113A0 VA: 0x181612DA0
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x1613FC0 Offset: 0x16125C0 VA: 0x181613FC0
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1613EA0 Offset: 0x16124A0 VA: 0x181613EA0
	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1613D50 Offset: 0x1612350 VA: 0x181613D50
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x16153D0 Offset: 0x16139D0 VA: 0x1816153D0
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x16106C0 Offset: 0x160ECC0 VA: 0x1816106C0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x1617B30 Offset: 0x1616130 VA: 0x181617B30
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x1617FF0 Offset: 0x16165F0 VA: 0x181617FF0
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x1614200 Offset: 0x1612800 VA: 0x181614200
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x1614400 Offset: 0x1612A00 VA: 0x181614400
	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	// RVA: 0x16131A0 Offset: 0x16117A0 VA: 0x1816131A0
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x1615050 Offset: 0x1613650 VA: 0x181615050
	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_DisplayName() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Id() { }

	// RVA: 0x1619E30 Offset: 0x1618430 VA: 0x181619E30
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x161A2A0 Offset: 0x16188A0 VA: 0x18161A2A0
	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	// RVA: 0x161A0E0 Offset: 0x16186E0 VA: 0x18161A0E0
	private static string readlink(string path) { }

	// RVA: 0x16186C0 Offset: 0x1616CC0 VA: 0x1816186C0
	private static bool TryGetNameFromPath(string path, out string name) { }

	// RVA: 0x16127F0 Offset: 0x1610DF0 VA: 0x1816127F0
	private static TimeZoneInfo CreateLocal() { }

	// RVA: 0x16130E0 Offset: 0x16116E0 VA: 0x1816130E0
	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	// RVA: 0x1614610 Offset: 0x1612C10 VA: 0x181614610
	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x161A050 Offset: 0x1618650 VA: 0x18161A050
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x1619EE0 Offset: 0x16184E0 VA: 0x181619EE0
	private static string get_TimeZoneDirectory() { }

	// RVA: 0x1619CE0 Offset: 0x16182E0 VA: 0x181619CE0
	private static bool get_IsWindows() { }

	// RVA: 0x1617D30 Offset: 0x1616330 VA: 0x181617D30
	private static string TrimSpecial(string str) { }

	// RVA: 0x1619F40 Offset: 0x1618540 VA: 0x181619F40
	private static RegistryKey get_TimeZoneKey() { }

	// RVA: 0x1619D20 Offset: 0x1618320 VA: 0x181619D20
	private static RegistryKey get_LocalZoneKey() { }

	// RVA: 0x1617E60 Offset: 0x1616460 VA: 0x181617E60
	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	// RVA: 0x1610450 Offset: 0x160EA50 VA: 0x181610450
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1610090 Offset: 0x160E690 VA: 0x181610090
	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	// RVA: 0x1610010 Offset: 0x160E610 VA: 0x181610010
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1610210 Offset: 0x160E810 VA: 0x181610210
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1610440 Offset: 0x160EA40 VA: 0x181610440
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x1610250 Offset: 0x160E850 VA: 0x181610250
	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x1613CE0 Offset: 0x16122E0 VA: 0x181613CE0
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x16114B0 Offset: 0x160FAB0 VA: 0x1816114B0
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x1611480 Offset: 0x160FA80 VA: 0x181611480
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x16113C0 Offset: 0x160F9C0 VA: 0x1816113C0
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1612ED0 Offset: 0x16114D0 VA: 0x181612ED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1612F60 Offset: 0x1611560 VA: 0x181612F60 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x1613450 Offset: 0x1611A50 VA: 0x181613450
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x1612FB0 Offset: 0x16115B0 VA: 0x181612FB0
	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	// RVA: 0x1613660 Offset: 0x1611C60 VA: 0x181613660
	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	// RVA: 0x1616510 Offset: 0x1614B10 VA: 0x181616510
	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	// RVA: 0x1613A90 Offset: 0x1612090 VA: 0x181613A90
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x16140E0 Offset: 0x16126E0 VA: 0x1816140E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1617870 Offset: 0x1615E70 VA: 0x181617870 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1615300 Offset: 0x1613900 VA: 0x181615300
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x16159F0 Offset: 0x1613FF0 VA: 0x1816159F0
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1615910 Offset: 0x1613F10 VA: 0x181615910
	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	// RVA: 0x1615660 Offset: 0x1613C60 VA: 0x181615660
	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	// RVA: 0x1615A10 Offset: 0x1614010 VA: 0x181615A10
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1615D30 Offset: 0x1614330 VA: 0x181615D30
	public bool IsAmbiguousTime(DateTime dateTime) { }

	// RVA: 0x1616130 Offset: 0x1614730 VA: 0x181616130
	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	// RVA: 0x1615F50 Offset: 0x1614550 VA: 0x181615F50
	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	// RVA: 0x16161F0 Offset: 0x16147F0 VA: 0x1816161F0
	public bool IsInvalidTime(DateTime dateTime) { }

	// RVA: 0x16177E0 Offset: 0x1615DE0 VA: 0x1816177E0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1618EC0 Offset: 0x16174C0 VA: 0x181618EC0
	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x16193C0 Offset: 0x16179C0 VA: 0x1816193C0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1619700 Offset: 0x1617D00 VA: 0x181619700
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1613B20 Offset: 0x1612120 VA: 0x181613B20
	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	// RVA: 0x16189C0 Offset: 0x1616FC0 VA: 0x1816189C0
	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	// RVA: 0x16179A0 Offset: 0x1615FA0 VA: 0x1816179A0
	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	// RVA: 0x1618D80 Offset: 0x1617380 VA: 0x181618D80
	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	// RVA: 0x160FE30 Offset: 0x160E430 VA: 0x18160FE30
	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	// RVA: 0x1618CA0 Offset: 0x16172A0 VA: 0x181618CA0
	private static bool ValidTZFile(byte[] buffer, int length) { }

	// RVA: 0x16177B0 Offset: 0x1615DB0 VA: 0x1816177B0
	private static int SwapInt32(int i) { }

	// RVA: 0x1617710 Offset: 0x1615D10 VA: 0x181617710
	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	// RVA: 0x16168B0 Offset: 0x1614EB0 VA: 0x1816168B0
	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	// RVA: 0x1616360 Offset: 0x1614960 VA: 0x181616360
	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	// RVA: 0x1617300 Offset: 0x1615900 VA: 0x181617300
	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	// RVA: 0x1617500 Offset: 0x1615B00 VA: 0x181617500
	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	// RVA: 0x1612D50 Offset: 0x1611350 VA: 0x181612D50
	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	// RVA: 0x16145D0 Offset: 0x1612BD0 VA: 0x1816145D0
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16159F0 Offset: 0x1613FF0 VA: 0x1816159F0
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16155F0 Offset: 0x1613BF0 VA: 0x1816155F0
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1619CB0 Offset: 0x16182B0 VA: 0x181619CB0
	internal void .ctor() { }

}

public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 315
{	// Fields
	private DateTime m_dateStart; // 0x10
	private DateTime m_dateEnd; // 0x18
	private TimeSpan m_daylightDelta; // 0x20
	private TimeZoneInfo.TransitionTime m_daylightTransitionStart; // 0x28
	private TimeZoneInfo.TransitionTime m_daylightTransitionEnd; // 0x40
	private TimeSpan m_baseUtcOffsetDelta; // 0x58

	// Properties
	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DateTime get_DateStart() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DateTime get_DateEnd() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x1605A90 Offset: 0x1604090 VA: 0x181605A90
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x1605A70 Offset: 0x1604070 VA: 0x181605A70
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x1604F90 Offset: 0x1603590 VA: 0x181604F90 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x1605110 Offset: 0x1603710 VA: 0x181605110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1604DD0 Offset: 0x16033D0 VA: 0x181604DD0
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x1604F20 Offset: 0x1603520 VA: 0x181604F20
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1605370 Offset: 0x1603970 VA: 0x181605370
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x1605120 Offset: 0x1603720 VA: 0x181605120 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1605200 Offset: 0x1603800 VA: 0x181605200 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1605790 Offset: 0x1603D90 VA: 0x181605790
	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 316
{	// Fields
	private DateTime m_timeOfDay; // 0x0
	private byte m_month; // 0x8
	private byte m_week; // 0x9
	private byte m_day; // 0xA
	private DayOfWeek m_dayOfWeek; // 0xC
	private bool m_isFixedDateRule; // 0x10

	// Properties
	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }

	// Methods

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public DateTime get_TimeOfDay() { }

	// RVA: 0x14B7D0 Offset: 0x14ABD0 VA: 0x18014B7D0
	public int get_Month() { }

	// RVA: 0x1AE2F0 Offset: 0x1AD6F0 VA: 0x1801AE2F0
	public int get_Week() { }

	// RVA: 0x1AE290 Offset: 0x1AD690 VA: 0x1801AE290
	public int get_Day() { }

	// RVA: 0x1AE430 Offset: 0x1AD830 VA: 0x1801AE430
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x10AB50 Offset: 0x109F50 VA: 0x18010AB50
	public bool get_IsFixedDateRule() { }

	// RVA: 0x1F61C0 Offset: 0x1F55C0 VA: 0x1801F61C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x161B760 Offset: 0x1619D60 VA: 0x18161B760
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x1F6190 Offset: 0x1F5590 VA: 0x1801F6190 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x1F6260 Offset: 0x1F5660 VA: 0x1801F6260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x161AE30 Offset: 0x1619430 VA: 0x18161AE30
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x161AED0 Offset: 0x16194D0 VA: 0x18161AED0
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x161AF80 Offset: 0x1619580 VA: 0x18161AF80
	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x161B210 Offset: 0x1619810 VA: 0x18161B210
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x1F6270 Offset: 0x1F5670 VA: 0x1801F6270 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1F6280 Offset: 0x1F5680 VA: 0x1801F6280 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F63A0 Offset: 0x1F57A0 VA: 0x1801F63A0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

internal struct TimeZoneInfo.SYSTEMTIME // TypeDefIndex: 317
{	// Fields
	internal ushort wYear; // 0x0
	internal ushort wMonth; // 0x2
	internal ushort wDayOfWeek; // 0x4
	internal ushort wDay; // 0x6
	internal ushort wHour; // 0x8
	internal ushort wMinute; // 0xA
	internal ushort wSecond; // 0xC
	internal ushort wMilliseconds; // 0xE

}

internal struct TimeZoneInfo.TIME_ZONE_INFORMATION // TypeDefIndex: 318
{	// Fields
	internal int Bias; // 0x0
	internal string StandardName; // 0x8
	internal TimeZoneInfo.SYSTEMTIME StandardDate; // 0x10
	internal int StandardBias; // 0x20
	internal string DaylightName; // 0x28
	internal TimeZoneInfo.SYSTEMTIME DaylightDate; // 0x30
	internal int DaylightBias; // 0x40

}

internal struct TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 319
{	// Fields
	internal TimeZoneInfo.TIME_ZONE_INFORMATION TZI; // 0x0
	internal string TimeZoneKeyName; // 0x48
	internal byte DynamicDaylightTimeDisabled; // 0x50

}

private sealed class TimeZoneInfo.<>c // TypeDefIndex: 320
{	// Fields
	public static readonly TimeZoneInfo.<>c <>9; // 0x0
	public static Comparison<TimeZoneInfo.AdjustmentRule> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x161BDC0 Offset: 0x161A3C0 VA: 0x18161BDC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161B790 Offset: 0x1619D90 VA: 0x18161B790
	internal int <CreateLocalUnity>b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2) { }

}

