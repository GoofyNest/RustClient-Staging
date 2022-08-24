public class LoadingScreen : SingletonComponent<LoadingScreen> // TypeDefIndex: 11122
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static bool <WantsSkip>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static string <Text>k__BackingField; // 0x8
	public CanvasRenderer panel; // 0x18
	public TextMeshProUGUI title; // 0x20
	public TextMeshProUGUI subtitle; // 0x28
	public Button skipButton; // 0x30
	public Button cancelButton; // 0x38
	public GameObject performanceWarning; // 0x40
	public AudioSource music; // 0x48
	public RectTransform serverInfo; // 0x50
	public RustText serverName; // 0x58
	public RustText serverPlayers; // 0x60
	public RustLayout serverModeSection; // 0x68
	public RustText serverMode; // 0x70
	public RustText serverMap; // 0x78
	public RustLayout serverTagsSection; // 0x80
	public ServerBrowserTagList serverTags; // 0x88
	public RawImage backgroundImage; // 0x90
	public Texture2D defaultBackground; // 0x98
	public GameObject pingWarning; // 0xA0
	public RustText pingWarningText; // 0xA8
	[TooltipAttribute] // RVA: 0x97110 Offset: 0x96510 VA: 0x180097110
	public int minPingDiffToShowWarning; // 0xB0
	[TooltipAttribute] // RVA: 0x97200 Offset: 0x96600 VA: 0x180097200
	public float pingDiffFactorToShowWarning; // 0xB4
	[TooltipAttribute] // RVA: 0x97380 Offset: 0x96780 VA: 0x180097380
	public int requiredPingSampleCount; // 0xB8
	private string _backgroundImagePath; // 0xC0
	private Texture2D _backgroundImage; // 0xC8
	private string _pingWarningTextTemplate; // 0xD0
	private int _pingSampleCount; // 0xD8
	private int _minimumPingSample; // 0xDC

	public static bool isOpen { get; }
	public static bool WantsSkip { get; set; }
	public static string Text { get; set; }


	public static bool get_isOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool get_WantsSkip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void set_WantsSkip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void set_Text(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string get_Text() { }

	protected override void Awake() { }

	protected override void OnDestroy() { }

	public void OnDisable() { }

	public static void Show(bool hideCancel = False) { }

	public static void Hide() { }

	public static void ShowPerformanceWarning() { }

	public static void HidePerformanceWarning() { }

	public static void ShowSkip() { }

	public static void HideSkip() { }

	public static void Update(string strType) { }

	public static void Update(string strType, string strSubtitle) { }

	public void UpdateFromServer(string strTitle, string strSubtitle) { }

	public void CancelLoading() { }

	public void SkipLoading() { }

	private void HidePingWarning() { }

	private void UpdatePingWarning() { }

	public void UpdateServerInfo(Nullable<ServerInfo> server, Dictionary<string, string> serverRules) { }

	private void LoadBackgroundImage() { }

	private void FreeBackgroundImage() { }

	private void ChooseBackgroundImage() { }

	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0x97A60 Offset: 0x96E60 VA: 0x180097A60
	[CompilerGeneratedAttribute] // RVA: 0x97A60 Offset: 0x96E60 VA: 0x180097A60
	private void <ChooseBackgroundImage>g__PreloadBackgroundImage|56_0(string url) { }

}

private struct LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d : IAsyncStateMachine // TypeDefIndex: 11123
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string url; // 0x28
	public LoadingScreen <>4__this; // 0x30
	private TaskAwaiter<string> <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

