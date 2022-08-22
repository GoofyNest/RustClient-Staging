internal class GAState // TypeDefIndex: 5670
{	// Fields
	private static readonly GAState _instance; // 0x0
	private string _userId; // 0x10
	private string _identifier; // 0x18
	private bool _initialized; // 0x20
	private long _sessionStart; // 0x28
	private int _sessionNum; // 0x30
	private int _transactionNum; // 0x34
	private string _sessionId; // 0x38
	private string _currentCustomDimension01; // 0x40
	private string _currentCustomDimension02; // 0x48
	private string _currentCustomDimension03; // 0x50
	private string _gameKey; // 0x58
	private string _gameSecret; // 0x60
	private string[] _availableCustomDimensions01; // 0x68
	private string[] _availableCustomDimensions02; // 0x70
	private string[] _availableCustomDimensions03; // 0x78
	private string[] _availableResourceCurrencies; // 0x80
	private string[] _availableResourceItemTypes; // 0x88
	private string _build; // 0x90
	private bool _isEventSubmissionEnabled; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Enabled>k__BackingField; // 0x99
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <FacebookId>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Gender>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <BirthYear>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JSONNode <SdkConfigCached>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <InitAuthorized>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <ClientServerTimeOffset>k__BackingField; // 0xC8
	private string _defaultUserId; // 0xD0
	private Dictionary<string, int> progressionTries; // 0xD8
	private JSONNode sdkConfigDefault; // 0xE0
	private JSONNode sdkConfig; // 0xE8
	private JSONNode sdkConfigCached; // 0xF0
	private JSONNode configurations; // 0xF8
	private bool commandCenterIsReady; // 0x100
	private readonly List<ICommandCenterListener> commandCenterListeners; // 0x108
	private readonly object configurationsLock; // 0x110

	// Properties
	private static GAState Instance { get; }
	private static string UserId { get; set; }
	public static string Identifier { get; set; }
	public static bool Initialized { get; set; }
	public static long SessionStart { get; set; }
	public static int SessionNum { get; set; }
	public static int TransactionNum { get; set; }
	public static string SessionId { get; set; }
	public static string CurrentCustomDimension01 { get; set; }
	public static string CurrentCustomDimension02 { get; set; }
	public static string CurrentCustomDimension03 { get; set; }
	public static string GameKey { get; set; }
	public static string GameSecret { get; set; }
	public static string[] AvailableCustomDimensions01 { get; }
	public static string[] AvailableCustomDimensions02 { get; }
	public static string[] AvailableCustomDimensions03 { get; }
	public static string Build { get; set; }
	public static bool IsEventSubmissionEnabled { get; }
	private bool Enabled { get; set; }
	private string FacebookId { get; set; }
	private string Gender { get; set; }
	private int BirthYear { get; set; }
	private JSONNode SdkConfigCached { set; }
	private bool InitAuthorized { get; set; }
	private long ClientServerTimeOffset { get; set; }
	private string DefaultUserId { get; set; }
	private static JSONNode SdkConfig { get; }

	// Methods

	// RVA: 0x13BF520 Offset: 0x13BDB20 VA: 0x1813BF520
	private static GAState get_Instance() { }

	// RVA: 0x13BFD20 Offset: 0x13BE320 VA: 0x1813BFD20
	private static string get_UserId() { }

	// RVA: 0x13C07A0 Offset: 0x13BEDA0 VA: 0x1813C07A0
	public static void set_UserId(string value) { }

	// RVA: 0x13BF3C0 Offset: 0x13BD9C0 VA: 0x1813BF3C0
	public static string get_Identifier() { }

	// RVA: 0x13C0360 Offset: 0x13BE960 VA: 0x1813C0360
	private static void set_Identifier(string value) { }

	// RVA: 0x13BF470 Offset: 0x13BDA70 VA: 0x1813BF470
	public static bool get_Initialized() { }

	// RVA: 0x13C0420 Offset: 0x13BEA20 VA: 0x1813C0420
	private static void set_Initialized(bool value) { }

	// RVA: 0x13BFBC0 Offset: 0x13BE1C0 VA: 0x1813BFBC0
	public static long get_SessionStart() { }

	// RVA: 0x13C0640 Offset: 0x13BEC40 VA: 0x1813C0640
	private static void set_SessionStart(long value) { }

	// RVA: 0x13BFB10 Offset: 0x13BE110 VA: 0x1813BFB10
	public static int get_SessionNum() { }

	// RVA: 0x13C0590 Offset: 0x13BEB90 VA: 0x1813C0590
	private static void set_SessionNum(int value) { }

	// RVA: 0x13BFC70 Offset: 0x13BE270 VA: 0x1813BFC70
	public static int get_TransactionNum() { }

	// RVA: 0x13C06F0 Offset: 0x13BECF0 VA: 0x1813C06F0
	private static void set_TransactionNum(int value) { }

	// RVA: 0x13BFA60 Offset: 0x13BE060 VA: 0x1813BFA60
	public static string get_SessionId() { }

	// RVA: 0x13C04D0 Offset: 0x13BEAD0 VA: 0x1813C04D0
	private static void set_SessionId(string value) { }

	// RVA: 0x13BEF90 Offset: 0x13BD590 VA: 0x1813BEF90
	public static string get_CurrentCustomDimension01() { }

	// RVA: 0x13BFEA0 Offset: 0x13BE4A0 VA: 0x1813BFEA0
	private static void set_CurrentCustomDimension01(string value) { }

	// RVA: 0x13BF040 Offset: 0x13BD640 VA: 0x1813BF040
	public static string get_CurrentCustomDimension02() { }

	// RVA: 0x13BFF60 Offset: 0x13BE560 VA: 0x1813BFF60
	private static void set_CurrentCustomDimension02(string value) { }

	// RVA: 0x13BF0F0 Offset: 0x13BD6F0 VA: 0x1813BF0F0
	public static string get_CurrentCustomDimension03() { }

	// RVA: 0x13C0020 Offset: 0x13BE620 VA: 0x1813C0020
	private static void set_CurrentCustomDimension03(string value) { }

	// RVA: 0x13BF260 Offset: 0x13BD860 VA: 0x1813BF260
	public static string get_GameKey() { }

	// RVA: 0x13C01E0 Offset: 0x13BE7E0 VA: 0x1813C01E0
	private static void set_GameKey(string value) { }

	// RVA: 0x13BF310 Offset: 0x13BD910 VA: 0x1813BF310
	public static string get_GameSecret() { }

	// RVA: 0x13C02A0 Offset: 0x13BE8A0 VA: 0x1813C02A0
	private static void set_GameSecret(string value) { }

	// RVA: 0x13BECD0 Offset: 0x13BD2D0 VA: 0x1813BECD0
	public static string[] get_AvailableCustomDimensions01() { }

	// RVA: 0x13BED80 Offset: 0x13BD380 VA: 0x1813BED80
	public static string[] get_AvailableCustomDimensions02() { }

	// RVA: 0x13BEE30 Offset: 0x13BD430 VA: 0x1813BEE30
	public static string[] get_AvailableCustomDimensions03() { }

	// RVA: 0x13BEEE0 Offset: 0x13BD4E0 VA: 0x1813BEEE0
	public static string get_Build() { }

	// RVA: 0x13BFDD0 Offset: 0x13BE3D0 VA: 0x1813BFDD0
	public static void set_Build(string value) { }

	// RVA: 0x13BF5E0 Offset: 0x13BDBE0 VA: 0x1813BF5E0
	public static bool get_IsEventSubmissionEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13BF250 Offset: 0x13BD850 VA: 0x1813BF250
	private bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13C01D0 Offset: 0x13BE7D0 VA: 0x1813C01D0
	private void set_Enabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	private string get_FacebookId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	private void set_FacebookId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	private string get_Gender() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	private void set_Gender(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	private int get_BirthYear() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_BirthYear(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	private void set_SdkConfigCached(JSONNode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EA80 Offset: 0x56D080 VA: 0x18056EA80
	private bool get_InitAuthorized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EA90 Offset: 0x56D090 VA: 0x18056EA90
	private void set_InitAuthorized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	private long get_ClientServerTimeOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13BFE90 Offset: 0x13BE490 VA: 0x1813BFE90
	private void set_ClientServerTimeOffset(long value) { }

	// RVA: 0x13BF1A0 Offset: 0x13BD7A0 VA: 0x1813BF1A0
	private string get_DefaultUserId() { }

	// RVA: 0x13C00E0 Offset: 0x13BE6E0 VA: 0x1813C00E0
	private void set_DefaultUserId(string value) { }

	// RVA: 0x13BF690 Offset: 0x13BDC90 VA: 0x1813BF690
	private static JSONNode get_SdkConfig() { }

	// RVA: 0x13BE980 Offset: 0x13BCF80 VA: 0x1813BE980
	private void .ctor() { }

	// RVA: 0x13B9B60 Offset: 0x13B8160 VA: 0x1813B9B60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13BB5A0 Offset: 0x13B9BA0 VA: 0x1813BB5A0
	public static bool IsEnabled() { }

	// RVA: 0x13BC330 Offset: 0x13BA930 VA: 0x1813BC330
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13BC420 Offset: 0x13BAA20 VA: 0x1813BC420
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13BC510 Offset: 0x13BAB10 VA: 0x1813BC510
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13BB1E0 Offset: 0x13B97E0 VA: 0x1813BB1E0
	public static void IncrementSessionNum() { }

	// RVA: 0x13BB240 Offset: 0x13B9840 VA: 0x1813BB240
	public static void IncrementTransactionNum() { }

	// RVA: 0x13BAD30 Offset: 0x13B9330 VA: 0x1813BAD30
	public static bool HasAvailableCustomDimensions01(string dimension1) { }

	// RVA: 0x13BAEC0 Offset: 0x13B94C0 VA: 0x1813BAEC0
	public static bool HasAvailableCustomDimensions02(string dimension2) { }

	// RVA: 0x13BB050 Offset: 0x13B9650 VA: 0x1813BB050
	public static bool HasAvailableCustomDimensions03(string dimension3) { }

	// RVA: 0x13BC600 Offset: 0x13BAC00 VA: 0x1813BC600
	public static void SetKeys(string gameKey, string gameSecret) { }

	// RVA: 0x13BB2A0 Offset: 0x13B98A0 VA: 0x1813BB2A0
	public static void InternalInitialize() { }

	// RVA: 0x13B84F0 Offset: 0x13B6AF0 VA: 0x1813B84F0
	public static void EndSessionAndStopQueue(bool endThread) { }

	// RVA: 0x13B9D30 Offset: 0x13B8330 VA: 0x1813B9D30
	public static JSONObject GetEventAnnotations() { }

	// RVA: 0x13BAA20 Offset: 0x13B9020 VA: 0x1813BAA20
	public static JSONObject GetInitAnnotations() { }

	// RVA: 0x13B9C30 Offset: 0x13B8230 VA: 0x1813B9C30
	public static long GetClientTsAdjusted() { }

	// RVA: 0x13BC2E0 Offset: 0x13BA8E0 VA: 0x1813BC2E0
	public static bool SessionIsStarted() { }

	// RVA: 0x13BD440 Offset: 0x13BBA40 VA: 0x1813BD440
	public static JSONObject ValidateAndCleanCustomFields(IDictionary<string, object> fields) { }

	// RVA: 0x13B82C0 Offset: 0x13B68C0 VA: 0x1813B82C0
	private static void CacheIdentifier() { }

	// RVA: 0x13B86E0 Offset: 0x13B6CE0 VA: 0x1813B86E0
	private static void EnsurePersistedStates() { }

	// RVA: 0x13BC7B0 Offset: 0x13BADB0 VA: 0x1813BC7B0
	private static void StartNewSession() { }

	// RVA: 0x13BC8D0 Offset: 0x13BAED0 VA: 0x1813BC8D0
	public static void StartNewSession(EGAHTTPApiResponse initResponse, JSONObject initResponseDict) { }

	// RVA: 0x13BE700 Offset: 0x13BCD00 VA: 0x1813BE700
	private static void ValidateAndFixCurrentDimensions() { }

	// RVA: 0x13B8490 Offset: 0x13B6A90 VA: 0x1813B8490
	private static long CalculateServerTimeOffset(long serverTs) { }

	// RVA: 0x13BB650 Offset: 0x13B9C50 VA: 0x1813BB650
	private static void PopulateConfigurations(JSONNode sdkConfig) { }

	// RVA: 0x13BE920 Offset: 0x13BCF20 VA: 0x1813BE920
	private static void .cctor() { }

}

