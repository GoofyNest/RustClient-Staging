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

	// RVA: 0x1618F30 Offset: 0x1617530 VA: 0x181618F30
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x1610F10 Offset: 0x160F510 VA: 0x181610F10
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	// RVA: 0x16117A0 Offset: 0x160FDA0 VA: 0x1816117A0
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x1613060 Offset: 0x1611660 VA: 0x181613060
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x1614280 Offset: 0x1612880 VA: 0x181614280
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1614160 Offset: 0x1612760 VA: 0x181614160
	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1614010 Offset: 0x1612610 VA: 0x181614010
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x1615690 Offset: 0x1613C90 VA: 0x181615690
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x1610980 Offset: 0x160EF80 VA: 0x181610980
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x1617DF0 Offset: 0x16163F0 VA: 0x181617DF0
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x16182B0 Offset: 0x16168B0 VA: 0x1816182B0
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x16144C0 Offset: 0x1612AC0 VA: 0x1816144C0
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x16146C0 Offset: 0x1612CC0 VA: 0x1816146C0
	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	// RVA: 0x1613460 Offset: 0x1611A60 VA: 0x181613460
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x1615310 Offset: 0x1613910 VA: 0x181615310
	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_DisplayName() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Id() { }

	// RVA: 0x161A0F0 Offset: 0x16186F0 VA: 0x18161A0F0
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x161A560 Offset: 0x1618B60 VA: 0x18161A560
	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	// RVA: 0x161A3A0 Offset: 0x16189A0 VA: 0x18161A3A0
	private static string readlink(string path) { }

	// RVA: 0x1618980 Offset: 0x1616F80 VA: 0x181618980
	private static bool TryGetNameFromPath(string path, out string name) { }

	// RVA: 0x1612AB0 Offset: 0x16110B0 VA: 0x181612AB0
	private static TimeZoneInfo CreateLocal() { }

	// RVA: 0x16133A0 Offset: 0x16119A0 VA: 0x1816133A0
	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	// RVA: 0x16148D0 Offset: 0x1612ED0 VA: 0x1816148D0
	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x161A310 Offset: 0x1618910 VA: 0x18161A310
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x161A1A0 Offset: 0x16187A0 VA: 0x18161A1A0
	private static string get_TimeZoneDirectory() { }

	// RVA: 0x1619FA0 Offset: 0x16185A0 VA: 0x181619FA0
	private static bool get_IsWindows() { }

	// RVA: 0x1617FF0 Offset: 0x16165F0 VA: 0x181617FF0
	private static string TrimSpecial(string str) { }

	// RVA: 0x161A200 Offset: 0x1618800 VA: 0x18161A200
	private static RegistryKey get_TimeZoneKey() { }

	// RVA: 0x1619FE0 Offset: 0x16185E0 VA: 0x181619FE0
	private static RegistryKey get_LocalZoneKey() { }

	// RVA: 0x1618120 Offset: 0x1616720 VA: 0x181618120
	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	// RVA: 0x1610710 Offset: 0x160ED10 VA: 0x181610710
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x1610350 Offset: 0x160E950 VA: 0x181610350
	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	// RVA: 0x16102D0 Offset: 0x160E8D0 VA: 0x1816102D0
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x16104D0 Offset: 0x160EAD0 VA: 0x1816104D0
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1610700 Offset: 0x160ED00 VA: 0x181610700
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x1610510 Offset: 0x160EB10 VA: 0x181610510
	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x1613FA0 Offset: 0x16125A0 VA: 0x181613FA0
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1611770 Offset: 0x160FD70 VA: 0x181611770
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x1611740 Offset: 0x160FD40 VA: 0x181611740
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x1611680 Offset: 0x160FC80 VA: 0x181611680
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1613190 Offset: 0x1611790 VA: 0x181613190 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1613220 Offset: 0x1611820 VA: 0x181613220 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x1613710 Offset: 0x1611D10 VA: 0x181613710
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x1613270 Offset: 0x1611870 VA: 0x181613270
	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	// RVA: 0x1613920 Offset: 0x1611F20 VA: 0x181613920
	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	// RVA: 0x16167D0 Offset: 0x1614DD0 VA: 0x1816167D0
	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	// RVA: 0x1613D50 Offset: 0x1612350 VA: 0x181613D50
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x16143A0 Offset: 0x16129A0 VA: 0x1816143A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1617B30 Offset: 0x1616130 VA: 0x181617B30 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16155C0 Offset: 0x1613BC0 VA: 0x1816155C0
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x1615CB0 Offset: 0x16142B0 VA: 0x181615CB0
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1615BD0 Offset: 0x16141D0 VA: 0x181615BD0
	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	// RVA: 0x1615920 Offset: 0x1613F20 VA: 0x181615920
	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	// RVA: 0x1615CD0 Offset: 0x16142D0 VA: 0x181615CD0
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1615FF0 Offset: 0x16145F0 VA: 0x181615FF0
	public bool IsAmbiguousTime(DateTime dateTime) { }

	// RVA: 0x16163F0 Offset: 0x16149F0 VA: 0x1816163F0
	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	// RVA: 0x1616210 Offset: 0x1614810 VA: 0x181616210
	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	// RVA: 0x16164B0 Offset: 0x1614AB0 VA: 0x1816164B0
	public bool IsInvalidTime(DateTime dateTime) { }

	// RVA: 0x1617AA0 Offset: 0x16160A0 VA: 0x181617AA0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1619180 Offset: 0x1617780 VA: 0x181619180
	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1619680 Offset: 0x1617C80 VA: 0x181619680
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16199C0 Offset: 0x1617FC0 VA: 0x1816199C0
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1613DE0 Offset: 0x16123E0 VA: 0x181613DE0
	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	// RVA: 0x1618C80 Offset: 0x1617280 VA: 0x181618C80
	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	// RVA: 0x1617C60 Offset: 0x1616260 VA: 0x181617C60
	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	// RVA: 0x1619040 Offset: 0x1617640 VA: 0x181619040
	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	// RVA: 0x16100F0 Offset: 0x160E6F0 VA: 0x1816100F0
	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	// RVA: 0x1618F60 Offset: 0x1617560 VA: 0x181618F60
	private static bool ValidTZFile(byte[] buffer, int length) { }

	// RVA: 0x1617A70 Offset: 0x1616070 VA: 0x181617A70
	private static int SwapInt32(int i) { }

	// RVA: 0x16179D0 Offset: 0x1615FD0 VA: 0x1816179D0
	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	// RVA: 0x1616B70 Offset: 0x1615170 VA: 0x181616B70
	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	// RVA: 0x1616620 Offset: 0x1614C20 VA: 0x181616620
	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	// RVA: 0x16175C0 Offset: 0x1615BC0 VA: 0x1816175C0
	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	// RVA: 0x16177C0 Offset: 0x1615DC0 VA: 0x1816177C0
	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	// RVA: 0x1613010 Offset: 0x1611610 VA: 0x181613010
	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	// RVA: 0x1614890 Offset: 0x1612E90 VA: 0x181614890
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1615CB0 Offset: 0x16142B0 VA: 0x181615CB0
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16158B0 Offset: 0x1613EB0 VA: 0x1816158B0
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1619F70 Offset: 0x1618570 VA: 0x181619F70
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

	// RVA: 0x1605D50 Offset: 0x1604350 VA: 0x181605D50
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x1605D30 Offset: 0x1604330 VA: 0x181605D30
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x1605250 Offset: 0x1603850 VA: 0x181605250 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x16053D0 Offset: 0x16039D0 VA: 0x1816053D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1605090 Offset: 0x1603690 VA: 0x181605090
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x16051E0 Offset: 0x16037E0 VA: 0x1816051E0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1605630 Offset: 0x1603C30 VA: 0x181605630
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x16053E0 Offset: 0x16039E0 VA: 0x1816053E0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16054C0 Offset: 0x1603AC0 VA: 0x1816054C0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1605A50 Offset: 0x1604050 VA: 0x181605A50
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

	// RVA: 0x161BA20 Offset: 0x161A020 VA: 0x18161BA20
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x1F6190 Offset: 0x1F5590 VA: 0x1801F6190 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x1F6260 Offset: 0x1F5660 VA: 0x1801F6260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x161B0F0 Offset: 0x16196F0 VA: 0x18161B0F0
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x161B190 Offset: 0x1619790 VA: 0x18161B190
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x161B240 Offset: 0x1619840 VA: 0x18161B240
	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x161B4D0 Offset: 0x1619AD0 VA: 0x18161B4D0
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

	// RVA: 0x161C080 Offset: 0x161A680 VA: 0x18161C080
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x161BA50 Offset: 0x161A050 VA: 0x18161BA50
	internal int <CreateLocalUnity>b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2) { }

}

