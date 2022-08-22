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

	// RVA: 0x1606250 Offset: 0x1604850 VA: 0x181606250
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x15FE230 Offset: 0x15FC830 VA: 0x1815FE230
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	// RVA: 0x15FEAC0 Offset: 0x15FD0C0 VA: 0x1815FEAC0
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x1600380 Offset: 0x15FE980 VA: 0x181600380
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x16015A0 Offset: 0x15FFBA0 VA: 0x1816015A0
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1601480 Offset: 0x15FFA80 VA: 0x181601480
	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1601330 Offset: 0x15FF930 VA: 0x181601330
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x16029B0 Offset: 0x1600FB0 VA: 0x1816029B0
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x15FDCA0 Offset: 0x15FC2A0 VA: 0x1815FDCA0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x1605110 Offset: 0x1603710 VA: 0x181605110
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x16055D0 Offset: 0x1603BD0 VA: 0x1816055D0
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x16017E0 Offset: 0x15FFDE0 VA: 0x1816017E0
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x16019E0 Offset: 0x15FFFE0 VA: 0x1816019E0
	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	// RVA: 0x1600780 Offset: 0x15FED80 VA: 0x181600780
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x1602630 Offset: 0x1600C30 VA: 0x181602630
	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_DisplayName() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Id() { }

	// RVA: 0x1607410 Offset: 0x1605A10 VA: 0x181607410
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x1607880 Offset: 0x1605E80 VA: 0x181607880
	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	// RVA: 0x16076C0 Offset: 0x1605CC0 VA: 0x1816076C0
	private static string readlink(string path) { }

	// RVA: 0x1605CA0 Offset: 0x16042A0 VA: 0x181605CA0
	private static bool TryGetNameFromPath(string path, out string name) { }

	// RVA: 0x15FFDD0 Offset: 0x15FE3D0 VA: 0x1815FFDD0
	private static TimeZoneInfo CreateLocal() { }

	// RVA: 0x16006C0 Offset: 0x15FECC0 VA: 0x1816006C0
	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	// RVA: 0x1601BF0 Offset: 0x16001F0 VA: 0x181601BF0
	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x1607630 Offset: 0x1605C30 VA: 0x181607630
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x16074C0 Offset: 0x1605AC0 VA: 0x1816074C0
	private static string get_TimeZoneDirectory() { }

	// RVA: 0x16072C0 Offset: 0x16058C0 VA: 0x1816072C0
	private static bool get_IsWindows() { }

	// RVA: 0x1605310 Offset: 0x1603910 VA: 0x181605310
	private static string TrimSpecial(string str) { }

	// RVA: 0x1607520 Offset: 0x1605B20 VA: 0x181607520
	private static RegistryKey get_TimeZoneKey() { }

	// RVA: 0x1607300 Offset: 0x1605900 VA: 0x181607300
	private static RegistryKey get_LocalZoneKey() { }

	// RVA: 0x1605440 Offset: 0x1603A40 VA: 0x181605440
	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	// RVA: 0x15FDA30 Offset: 0x15FC030 VA: 0x1815FDA30
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x15FD670 Offset: 0x15FBC70 VA: 0x1815FD670
	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	// RVA: 0x15FD5F0 Offset: 0x15FBBF0 VA: 0x1815FD5F0
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x15FD7F0 Offset: 0x15FBDF0 VA: 0x1815FD7F0
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x15FDA20 Offset: 0x15FC020 VA: 0x1815FDA20
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x15FD830 Offset: 0x15FBE30 VA: 0x1815FD830
	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x16012C0 Offset: 0x15FF8C0 VA: 0x1816012C0
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x15FEA90 Offset: 0x15FD090 VA: 0x1815FEA90
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x15FEA60 Offset: 0x15FD060 VA: 0x1815FEA60
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x15FE9A0 Offset: 0x15FCFA0 VA: 0x1815FE9A0
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x16004B0 Offset: 0x15FEAB0 VA: 0x1816004B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1600540 Offset: 0x15FEB40 VA: 0x181600540 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x1600A30 Offset: 0x15FF030 VA: 0x181600A30
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x1600590 Offset: 0x15FEB90 VA: 0x181600590
	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	// RVA: 0x1600C40 Offset: 0x15FF240 VA: 0x181600C40
	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	// RVA: 0x1603AF0 Offset: 0x16020F0 VA: 0x181603AF0
	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	// RVA: 0x1601070 Offset: 0x15FF670 VA: 0x181601070
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x16016C0 Offset: 0x15FFCC0 VA: 0x1816016C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1604E50 Offset: 0x1603450 VA: 0x181604E50 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16028E0 Offset: 0x1600EE0 VA: 0x1816028E0
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x1602FD0 Offset: 0x16015D0 VA: 0x181602FD0
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1602EF0 Offset: 0x16014F0 VA: 0x181602EF0
	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	// RVA: 0x1602C40 Offset: 0x1601240 VA: 0x181602C40
	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	// RVA: 0x1602FF0 Offset: 0x16015F0 VA: 0x181602FF0
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1603310 Offset: 0x1601910 VA: 0x181603310
	public bool IsAmbiguousTime(DateTime dateTime) { }

	// RVA: 0x1603710 Offset: 0x1601D10 VA: 0x181603710
	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	// RVA: 0x1603530 Offset: 0x1601B30 VA: 0x181603530
	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	// RVA: 0x16037D0 Offset: 0x1601DD0 VA: 0x1816037D0
	public bool IsInvalidTime(DateTime dateTime) { }

	// RVA: 0x1604DC0 Offset: 0x16033C0 VA: 0x181604DC0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16064A0 Offset: 0x1604AA0 VA: 0x1816064A0
	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x16069A0 Offset: 0x1604FA0 VA: 0x1816069A0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1606CE0 Offset: 0x16052E0 VA: 0x181606CE0
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1601100 Offset: 0x15FF700 VA: 0x181601100
	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	// RVA: 0x1605FA0 Offset: 0x16045A0 VA: 0x181605FA0
	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	// RVA: 0x1604F80 Offset: 0x1603580 VA: 0x181604F80
	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	// RVA: 0x1606360 Offset: 0x1604960 VA: 0x181606360
	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	// RVA: 0x15FD410 Offset: 0x15FBA10 VA: 0x1815FD410
	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	// RVA: 0x1606280 Offset: 0x1604880 VA: 0x181606280
	private static bool ValidTZFile(byte[] buffer, int length) { }

	// RVA: 0x1604D90 Offset: 0x1603390 VA: 0x181604D90
	private static int SwapInt32(int i) { }

	// RVA: 0x1604CF0 Offset: 0x16032F0 VA: 0x181604CF0
	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	// RVA: 0x1603E90 Offset: 0x1602490 VA: 0x181603E90
	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	// RVA: 0x1603940 Offset: 0x1601F40 VA: 0x181603940
	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	// RVA: 0x16048E0 Offset: 0x1602EE0 VA: 0x1816048E0
	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	// RVA: 0x1604AE0 Offset: 0x16030E0 VA: 0x181604AE0
	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	// RVA: 0x1600330 Offset: 0x15FE930 VA: 0x181600330
	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	// RVA: 0x1601BB0 Offset: 0x16001B0 VA: 0x181601BB0
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1602FD0 Offset: 0x16015D0 VA: 0x181602FD0
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1602BD0 Offset: 0x16011D0 VA: 0x181602BD0
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1607290 Offset: 0x1605890 VA: 0x181607290
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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public DateTime get_DateStart() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DateTime get_DateEnd() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x15F3070 Offset: 0x15F1670 VA: 0x1815F3070
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x15F3050 Offset: 0x15F1650 VA: 0x1815F3050
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x15F2570 Offset: 0x15F0B70 VA: 0x1815F2570 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x15F26F0 Offset: 0x15F0CF0 VA: 0x1815F26F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x15F23B0 Offset: 0x15F09B0 VA: 0x1815F23B0
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x15F2500 Offset: 0x15F0B00 VA: 0x1815F2500
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x15F2950 Offset: 0x15F0F50 VA: 0x1815F2950
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x15F2700 Offset: 0x15F0D00 VA: 0x1815F2700 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x15F27E0 Offset: 0x15F0DE0 VA: 0x1815F27E0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F2D70 Offset: 0x15F1370 VA: 0x1815F2D70
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

	// RVA: 0x14B5F0 Offset: 0x14A9F0 VA: 0x18014B5F0
	public int get_Month() { }

	// RVA: 0x1ADFF0 Offset: 0x1AD3F0 VA: 0x1801ADFF0
	public int get_Week() { }

	// RVA: 0x1ADF90 Offset: 0x1AD390 VA: 0x1801ADF90
	public int get_Day() { }

	// RVA: 0x1AE130 Offset: 0x1AD530 VA: 0x1801AE130
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x10AB50 Offset: 0x109F50 VA: 0x18010AB50
	public bool get_IsFixedDateRule() { }

	// RVA: 0x1F5010 Offset: 0x1F4410 VA: 0x1801F5010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1608D40 Offset: 0x1607340 VA: 0x181608D40
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x1F4FE0 Offset: 0x1F43E0 VA: 0x1801F4FE0 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x1F50B0 Offset: 0x1F44B0 VA: 0x1801F50B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1608410 Offset: 0x1606A10 VA: 0x181608410
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x16084B0 Offset: 0x1606AB0 VA: 0x1816084B0
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x1608560 Offset: 0x1606B60 VA: 0x181608560
	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x16087F0 Offset: 0x1606DF0 VA: 0x1816087F0
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x1F50C0 Offset: 0x1F44C0 VA: 0x1801F50C0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1F50D0 Offset: 0x1F44D0 VA: 0x1801F50D0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F51F0 Offset: 0x1F45F0 VA: 0x1801F51F0
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

	// RVA: 0x16093A0 Offset: 0x16079A0 VA: 0x1816093A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1608D70 Offset: 0x1607370 VA: 0x181608D70
	internal int <CreateLocalUnity>b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2) { }

}

