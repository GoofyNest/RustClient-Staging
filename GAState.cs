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

	// RVA: 0x13C0420 Offset: 0x13BEA20 VA: 0x1813C0420
	private static GAState get_Instance() { }

	// RVA: 0x13C0C20 Offset: 0x13BF220 VA: 0x1813C0C20
	private static string get_UserId() { }

	// RVA: 0x13C16A0 Offset: 0x13BFCA0 VA: 0x1813C16A0
	public static void set_UserId(string value) { }

	// RVA: 0x13C02C0 Offset: 0x13BE8C0 VA: 0x1813C02C0
	public static string get_Identifier() { }

	// RVA: 0x13C1260 Offset: 0x13BF860 VA: 0x1813C1260
	private static void set_Identifier(string value) { }

	// RVA: 0x13C0370 Offset: 0x13BE970 VA: 0x1813C0370
	public static bool get_Initialized() { }

	// RVA: 0x13C1320 Offset: 0x13BF920 VA: 0x1813C1320
	private static void set_Initialized(bool value) { }

	// RVA: 0x13C0AC0 Offset: 0x13BF0C0 VA: 0x1813C0AC0
	public static long get_SessionStart() { }

	// RVA: 0x13C1540 Offset: 0x13BFB40 VA: 0x1813C1540
	private static void set_SessionStart(long value) { }

	// RVA: 0x13C0A10 Offset: 0x13BF010 VA: 0x1813C0A10
	public static int get_SessionNum() { }

	// RVA: 0x13C1490 Offset: 0x13BFA90 VA: 0x1813C1490
	private static void set_SessionNum(int value) { }

	// RVA: 0x13C0B70 Offset: 0x13BF170 VA: 0x1813C0B70
	public static int get_TransactionNum() { }

	// RVA: 0x13C15F0 Offset: 0x13BFBF0 VA: 0x1813C15F0
	private static void set_TransactionNum(int value) { }

	// RVA: 0x13C0960 Offset: 0x13BEF60 VA: 0x1813C0960
	public static string get_SessionId() { }

	// RVA: 0x13C13D0 Offset: 0x13BF9D0 VA: 0x1813C13D0
	private static void set_SessionId(string value) { }

	// RVA: 0x13BFE90 Offset: 0x13BE490 VA: 0x1813BFE90
	public static string get_CurrentCustomDimension01() { }

	// RVA: 0x13C0DA0 Offset: 0x13BF3A0 VA: 0x1813C0DA0
	private static void set_CurrentCustomDimension01(string value) { }

	// RVA: 0x13BFF40 Offset: 0x13BE540 VA: 0x1813BFF40
	public static string get_CurrentCustomDimension02() { }

	// RVA: 0x13C0E60 Offset: 0x13BF460 VA: 0x1813C0E60
	private static void set_CurrentCustomDimension02(string value) { }

	// RVA: 0x13BFFF0 Offset: 0x13BE5F0 VA: 0x1813BFFF0
	public static string get_CurrentCustomDimension03() { }

	// RVA: 0x13C0F20 Offset: 0x13BF520 VA: 0x1813C0F20
	private static void set_CurrentCustomDimension03(string value) { }

	// RVA: 0x13C0160 Offset: 0x13BE760 VA: 0x1813C0160
	public static string get_GameKey() { }

	// RVA: 0x13C10E0 Offset: 0x13BF6E0 VA: 0x1813C10E0
	private static void set_GameKey(string value) { }

	// RVA: 0x13C0210 Offset: 0x13BE810 VA: 0x1813C0210
	public static string get_GameSecret() { }

	// RVA: 0x13C11A0 Offset: 0x13BF7A0 VA: 0x1813C11A0
	private static void set_GameSecret(string value) { }

	// RVA: 0x13BFBD0 Offset: 0x13BE1D0 VA: 0x1813BFBD0
	public static string[] get_AvailableCustomDimensions01() { }

	// RVA: 0x13BFC80 Offset: 0x13BE280 VA: 0x1813BFC80
	public static string[] get_AvailableCustomDimensions02() { }

	// RVA: 0x13BFD30 Offset: 0x13BE330 VA: 0x1813BFD30
	public static string[] get_AvailableCustomDimensions03() { }

	// RVA: 0x13BFDE0 Offset: 0x13BE3E0 VA: 0x1813BFDE0
	public static string get_Build() { }

	// RVA: 0x13C0CD0 Offset: 0x13BF2D0 VA: 0x1813C0CD0
	public static void set_Build(string value) { }

	// RVA: 0x13C04E0 Offset: 0x13BEAE0 VA: 0x1813C04E0
	public static bool get_IsEventSubmissionEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13C0150 Offset: 0x13BE750 VA: 0x1813C0150
	private bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13C10D0 Offset: 0x13BF6D0 VA: 0x1813C10D0
	private void set_Enabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	private string get_FacebookId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_FacebookId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	private string get_Gender() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73F50 Offset: 0xC72550 VA: 0x180C73F50
	private void set_Gender(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	private int get_BirthYear() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_BirthYear(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	private void set_SdkConfigCached(JSONNode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	private bool get_InitAuthorized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	private void set_InitAuthorized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	private long get_ClientServerTimeOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13C0D90 Offset: 0x13BF390 VA: 0x1813C0D90
	private void set_ClientServerTimeOffset(long value) { }

	// RVA: 0x13C00A0 Offset: 0x13BE6A0 VA: 0x1813C00A0
	private string get_DefaultUserId() { }

	// RVA: 0x13C0FE0 Offset: 0x13BF5E0 VA: 0x1813C0FE0
	private void set_DefaultUserId(string value) { }

	// RVA: 0x13C0590 Offset: 0x13BEB90 VA: 0x1813C0590
	private static JSONNode get_SdkConfig() { }

	// RVA: 0x13BF880 Offset: 0x13BDE80 VA: 0x1813BF880
	private void .ctor() { }

	// RVA: 0x13BAA60 Offset: 0x13B9060 VA: 0x1813BAA60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13BC4A0 Offset: 0x13BAAA0 VA: 0x1813BC4A0
	public static bool IsEnabled() { }

	// RVA: 0x13BD230 Offset: 0x13BB830 VA: 0x1813BD230
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13BD320 Offset: 0x13BB920 VA: 0x1813BD320
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13BD410 Offset: 0x13BBA10 VA: 0x1813BD410
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13BC0E0 Offset: 0x13BA6E0 VA: 0x1813BC0E0
	public static void IncrementSessionNum() { }

	// RVA: 0x13BC140 Offset: 0x13BA740 VA: 0x1813BC140
	public static void IncrementTransactionNum() { }

	// RVA: 0x13BBC30 Offset: 0x13BA230 VA: 0x1813BBC30
	public static bool HasAvailableCustomDimensions01(string dimension1) { }

	// RVA: 0x13BBDC0 Offset: 0x13BA3C0 VA: 0x1813BBDC0
	public static bool HasAvailableCustomDimensions02(string dimension2) { }

	// RVA: 0x13BBF50 Offset: 0x13BA550 VA: 0x1813BBF50
	public static bool HasAvailableCustomDimensions03(string dimension3) { }

	// RVA: 0x13BD500 Offset: 0x13BBB00 VA: 0x1813BD500
	public static void SetKeys(string gameKey, string gameSecret) { }

	// RVA: 0x13BC1A0 Offset: 0x13BA7A0 VA: 0x1813BC1A0
	public static void InternalInitialize() { }

	// RVA: 0x13B93F0 Offset: 0x13B79F0 VA: 0x1813B93F0
	public static void EndSessionAndStopQueue(bool endThread) { }

	// RVA: 0x13BAC30 Offset: 0x13B9230 VA: 0x1813BAC30
	public static JSONObject GetEventAnnotations() { }

	// RVA: 0x13BB920 Offset: 0x13B9F20 VA: 0x1813BB920
	public static JSONObject GetInitAnnotations() { }

	// RVA: 0x13BAB30 Offset: 0x13B9130 VA: 0x1813BAB30
	public static long GetClientTsAdjusted() { }

	// RVA: 0x13BD1E0 Offset: 0x13BB7E0 VA: 0x1813BD1E0
	public static bool SessionIsStarted() { }

	// RVA: 0x13BE340 Offset: 0x13BC940 VA: 0x1813BE340
	public static JSONObject ValidateAndCleanCustomFields(IDictionary<string, object> fields) { }

	// RVA: 0x13B91C0 Offset: 0x13B77C0 VA: 0x1813B91C0
	private static void CacheIdentifier() { }

	// RVA: 0x13B95E0 Offset: 0x13B7BE0 VA: 0x1813B95E0
	private static void EnsurePersistedStates() { }

	// RVA: 0x13BD6B0 Offset: 0x13BBCB0 VA: 0x1813BD6B0
	private static void StartNewSession() { }

	// RVA: 0x13BD7D0 Offset: 0x13BBDD0 VA: 0x1813BD7D0
	public static void StartNewSession(EGAHTTPApiResponse initResponse, JSONObject initResponseDict) { }

	// RVA: 0x13BF600 Offset: 0x13BDC00 VA: 0x1813BF600
	private static void ValidateAndFixCurrentDimensions() { }

	// RVA: 0x13B9390 Offset: 0x13B7990 VA: 0x1813B9390
	private static long CalculateServerTimeOffset(long serverTs) { }

	// RVA: 0x13BC550 Offset: 0x13BAB50 VA: 0x1813BC550
	private static void PopulateConfigurations(JSONNode sdkConfig) { }

	// RVA: 0x13BF820 Offset: 0x13BDE20 VA: 0x1813BF820
	private static void .cctor() { }

}

