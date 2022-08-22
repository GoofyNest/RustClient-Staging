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

	// RVA: 0x13C0160 Offset: 0x13BE760 VA: 0x1813C0160
	private static GAState get_Instance() { }

	// RVA: 0x13C0960 Offset: 0x13BEF60 VA: 0x1813C0960
	private static string get_UserId() { }

	// RVA: 0x13C13E0 Offset: 0x13BF9E0 VA: 0x1813C13E0
	public static void set_UserId(string value) { }

	// RVA: 0x13C0000 Offset: 0x13BE600 VA: 0x1813C0000
	public static string get_Identifier() { }

	// RVA: 0x13C0FA0 Offset: 0x13BF5A0 VA: 0x1813C0FA0
	private static void set_Identifier(string value) { }

	// RVA: 0x13C00B0 Offset: 0x13BE6B0 VA: 0x1813C00B0
	public static bool get_Initialized() { }

	// RVA: 0x13C1060 Offset: 0x13BF660 VA: 0x1813C1060
	private static void set_Initialized(bool value) { }

	// RVA: 0x13C0800 Offset: 0x13BEE00 VA: 0x1813C0800
	public static long get_SessionStart() { }

	// RVA: 0x13C1280 Offset: 0x13BF880 VA: 0x1813C1280
	private static void set_SessionStart(long value) { }

	// RVA: 0x13C0750 Offset: 0x13BED50 VA: 0x1813C0750
	public static int get_SessionNum() { }

	// RVA: 0x13C11D0 Offset: 0x13BF7D0 VA: 0x1813C11D0
	private static void set_SessionNum(int value) { }

	// RVA: 0x13C08B0 Offset: 0x13BEEB0 VA: 0x1813C08B0
	public static int get_TransactionNum() { }

	// RVA: 0x13C1330 Offset: 0x13BF930 VA: 0x1813C1330
	private static void set_TransactionNum(int value) { }

	// RVA: 0x13C06A0 Offset: 0x13BECA0 VA: 0x1813C06A0
	public static string get_SessionId() { }

	// RVA: 0x13C1110 Offset: 0x13BF710 VA: 0x1813C1110
	private static void set_SessionId(string value) { }

	// RVA: 0x13BFBD0 Offset: 0x13BE1D0 VA: 0x1813BFBD0
	public static string get_CurrentCustomDimension01() { }

	// RVA: 0x13C0AE0 Offset: 0x13BF0E0 VA: 0x1813C0AE0
	private static void set_CurrentCustomDimension01(string value) { }

	// RVA: 0x13BFC80 Offset: 0x13BE280 VA: 0x1813BFC80
	public static string get_CurrentCustomDimension02() { }

	// RVA: 0x13C0BA0 Offset: 0x13BF1A0 VA: 0x1813C0BA0
	private static void set_CurrentCustomDimension02(string value) { }

	// RVA: 0x13BFD30 Offset: 0x13BE330 VA: 0x1813BFD30
	public static string get_CurrentCustomDimension03() { }

	// RVA: 0x13C0C60 Offset: 0x13BF260 VA: 0x1813C0C60
	private static void set_CurrentCustomDimension03(string value) { }

	// RVA: 0x13BFEA0 Offset: 0x13BE4A0 VA: 0x1813BFEA0
	public static string get_GameKey() { }

	// RVA: 0x13C0E20 Offset: 0x13BF420 VA: 0x1813C0E20
	private static void set_GameKey(string value) { }

	// RVA: 0x13BFF50 Offset: 0x13BE550 VA: 0x1813BFF50
	public static string get_GameSecret() { }

	// RVA: 0x13C0EE0 Offset: 0x13BF4E0 VA: 0x1813C0EE0
	private static void set_GameSecret(string value) { }

	// RVA: 0x13BF910 Offset: 0x13BDF10 VA: 0x1813BF910
	public static string[] get_AvailableCustomDimensions01() { }

	// RVA: 0x13BF9C0 Offset: 0x13BDFC0 VA: 0x1813BF9C0
	public static string[] get_AvailableCustomDimensions02() { }

	// RVA: 0x13BFA70 Offset: 0x13BE070 VA: 0x1813BFA70
	public static string[] get_AvailableCustomDimensions03() { }

	// RVA: 0x13BFB20 Offset: 0x13BE120 VA: 0x1813BFB20
	public static string get_Build() { }

	// RVA: 0x13C0A10 Offset: 0x13BF010 VA: 0x1813C0A10
	public static void set_Build(string value) { }

	// RVA: 0x13C0220 Offset: 0x13BE820 VA: 0x1813C0220
	public static bool get_IsEventSubmissionEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13BFE90 Offset: 0x13BE490 VA: 0x1813BFE90
	private bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13C0E10 Offset: 0x13BF410 VA: 0x1813C0E10
	private void set_Enabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	private string get_FacebookId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_FacebookId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	private string get_Gender() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73C90 Offset: 0xC72290 VA: 0x180C73C90
	private void set_Gender(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	private int get_BirthYear() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_BirthYear(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	private void set_SdkConfigCached(JSONNode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	private bool get_InitAuthorized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	private void set_InitAuthorized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	private long get_ClientServerTimeOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13C0AD0 Offset: 0x13BF0D0 VA: 0x1813C0AD0
	private void set_ClientServerTimeOffset(long value) { }

	// RVA: 0x13BFDE0 Offset: 0x13BE3E0 VA: 0x1813BFDE0
	private string get_DefaultUserId() { }

	// RVA: 0x13C0D20 Offset: 0x13BF320 VA: 0x1813C0D20
	private void set_DefaultUserId(string value) { }

	// RVA: 0x13C02D0 Offset: 0x13BE8D0 VA: 0x1813C02D0
	private static JSONNode get_SdkConfig() { }

	// RVA: 0x13BF5C0 Offset: 0x13BDBC0 VA: 0x1813BF5C0
	private void .ctor() { }

	// RVA: 0x13BA7A0 Offset: 0x13B8DA0 VA: 0x1813BA7A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13BC1E0 Offset: 0x13BA7E0 VA: 0x1813BC1E0
	public static bool IsEnabled() { }

	// RVA: 0x13BCF70 Offset: 0x13BB570 VA: 0x1813BCF70
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13BD060 Offset: 0x13BB660 VA: 0x1813BD060
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13BD150 Offset: 0x13BB750 VA: 0x1813BD150
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13BBE20 Offset: 0x13BA420 VA: 0x1813BBE20
	public static void IncrementSessionNum() { }

	// RVA: 0x13BBE80 Offset: 0x13BA480 VA: 0x1813BBE80
	public static void IncrementTransactionNum() { }

	// RVA: 0x13BB970 Offset: 0x13B9F70 VA: 0x1813BB970
	public static bool HasAvailableCustomDimensions01(string dimension1) { }

	// RVA: 0x13BBB00 Offset: 0x13BA100 VA: 0x1813BBB00
	public static bool HasAvailableCustomDimensions02(string dimension2) { }

	// RVA: 0x13BBC90 Offset: 0x13BA290 VA: 0x1813BBC90
	public static bool HasAvailableCustomDimensions03(string dimension3) { }

	// RVA: 0x13BD240 Offset: 0x13BB840 VA: 0x1813BD240
	public static void SetKeys(string gameKey, string gameSecret) { }

	// RVA: 0x13BBEE0 Offset: 0x13BA4E0 VA: 0x1813BBEE0
	public static void InternalInitialize() { }

	// RVA: 0x13B9130 Offset: 0x13B7730 VA: 0x1813B9130
	public static void EndSessionAndStopQueue(bool endThread) { }

	// RVA: 0x13BA970 Offset: 0x13B8F70 VA: 0x1813BA970
	public static JSONObject GetEventAnnotations() { }

	// RVA: 0x13BB660 Offset: 0x13B9C60 VA: 0x1813BB660
	public static JSONObject GetInitAnnotations() { }

	// RVA: 0x13BA870 Offset: 0x13B8E70 VA: 0x1813BA870
	public static long GetClientTsAdjusted() { }

	// RVA: 0x13BCF20 Offset: 0x13BB520 VA: 0x1813BCF20
	public static bool SessionIsStarted() { }

	// RVA: 0x13BE080 Offset: 0x13BC680 VA: 0x1813BE080
	public static JSONObject ValidateAndCleanCustomFields(IDictionary<string, object> fields) { }

	// RVA: 0x13B8F00 Offset: 0x13B7500 VA: 0x1813B8F00
	private static void CacheIdentifier() { }

	// RVA: 0x13B9320 Offset: 0x13B7920 VA: 0x1813B9320
	private static void EnsurePersistedStates() { }

	// RVA: 0x13BD3F0 Offset: 0x13BB9F0 VA: 0x1813BD3F0
	private static void StartNewSession() { }

	// RVA: 0x13BD510 Offset: 0x13BBB10 VA: 0x1813BD510
	public static void StartNewSession(EGAHTTPApiResponse initResponse, JSONObject initResponseDict) { }

	// RVA: 0x13BF340 Offset: 0x13BD940 VA: 0x1813BF340
	private static void ValidateAndFixCurrentDimensions() { }

	// RVA: 0x13B90D0 Offset: 0x13B76D0 VA: 0x1813B90D0
	private static long CalculateServerTimeOffset(long serverTs) { }

	// RVA: 0x13BC290 Offset: 0x13BA890 VA: 0x1813BC290
	private static void PopulateConfigurations(JSONNode sdkConfig) { }

	// RVA: 0x13BF560 Offset: 0x13BDB60 VA: 0x1813BF560
	private static void .cctor() { }

}

