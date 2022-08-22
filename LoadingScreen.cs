public class LoadingScreen : SingletonComponent<LoadingScreen> // TypeDefIndex: 11118
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <WantsSkip>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[TooltipAttribute] // RVA: 0x978C0 Offset: 0x96CC0 VA: 0x1800978C0
	public int minPingDiffToShowWarning; // 0xB0
	[TooltipAttribute] // RVA: 0x97940 Offset: 0x96D40 VA: 0x180097940
	public float pingDiffFactorToShowWarning; // 0xB4
	[TooltipAttribute] // RVA: 0x97C00 Offset: 0x97000 VA: 0x180097C00
	public int requiredPingSampleCount; // 0xB8
	private string _backgroundImagePath; // 0xC0
	private Texture2D _backgroundImage; // 0xC8
	private string _pingWarningTextTemplate; // 0xD0
	private int _pingSampleCount; // 0xD8
	private int _minimumPingSample; // 0xDC

	// Properties
	public static bool isOpen { get; }
	public static bool WantsSkip { get; set; }
	public static string Text { get; set; }

	// Methods

	// RVA: 0x4FAA70 Offset: 0x4F9070 VA: 0x1804FAA70
	public static bool get_isOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FAA30 Offset: 0x4F9030 VA: 0x1804FAA30
	public static bool get_WantsSkip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FAC20 Offset: 0x4F9220 VA: 0x1804FAC20
	private static void set_WantsSkip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FABD0 Offset: 0x4F91D0 VA: 0x1804FABD0
	private static void set_Text(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FA9F0 Offset: 0x4F8FF0 VA: 0x1804FA9F0
	public static string get_Text() { }

	// RVA: 0x4F8560 Offset: 0x4F6B60 VA: 0x1804F8560 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4F9500 Offset: 0x4F7B00 VA: 0x1804F9500 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x4F95F0 Offset: 0x4F7BF0 VA: 0x1804F95F0
	public void OnDisable() { }

	// RVA: 0x4F98E0 Offset: 0x4F7EE0 VA: 0x1804F98E0
	public static void Show(bool hideCancel = False) { }

	// RVA: 0x4F8F90 Offset: 0x4F7590 VA: 0x1804F8F90
	public static void Hide() { }

	// RVA: 0x4F9600 Offset: 0x4F7C00 VA: 0x1804F9600
	public static void ShowPerformanceWarning() { }

	// RVA: 0x4F8C10 Offset: 0x4F7210 VA: 0x1804F8C10
	public static void HidePerformanceWarning() { }

	// RVA: 0x4F9750 Offset: 0x4F7D50 VA: 0x1804F9750
	public static void ShowSkip() { }

	// RVA: 0x4F8E00 Offset: 0x4F7400 VA: 0x1804F8E00
	public static void HideSkip() { }

	// RVA: 0x4FA550 Offset: 0x4F8B50 VA: 0x1804FA550
	public static void Update(string strType) { }

	// RVA: 0x4FA7B0 Offset: 0x4F8DB0 VA: 0x1804FA7B0
	public static void Update(string strType, string strSubtitle) { }

	// RVA: 0x4F9E80 Offset: 0x4F8480 VA: 0x1804F9E80
	public void UpdateFromServer(string strTitle, string strSubtitle) { }

	// RVA: 0x4F8810 Offset: 0x4F6E10 VA: 0x1804F8810
	public void CancelLoading() { }

	// RVA: 0x4F9D40 Offset: 0x4F8340 VA: 0x1804F9D40
	public void SkipLoading() { }

	// RVA: 0x4F8D60 Offset: 0x4F7360 VA: 0x1804F8D60
	private void HidePingWarning() { }

	// RVA: 0x4F9F40 Offset: 0x4F8540 VA: 0x1804F9F40
	private void UpdatePingWarning() { }

	// RVA: 0x4FA280 Offset: 0x4F8880 VA: 0x1804FA280
	public void UpdateServerInfo(Nullable<ServerInfo> server, Dictionary<string, string> serverRules) { }

	// RVA: 0x4F9380 Offset: 0x4F7980 VA: 0x1804F9380
	private void LoadBackgroundImage() { }

	// RVA: 0x4F8B50 Offset: 0x4F7150 VA: 0x1804F8B50
	private void FreeBackgroundImage() { }

	// RVA: 0x4F88C0 Offset: 0x4F6EC0 VA: 0x1804F88C0
	private void ChooseBackgroundImage() { }

	// RVA: 0x4FA970 Offset: 0x4F8F70 VA: 0x1804FA970
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0x98130 Offset: 0x97530 VA: 0x180098130
	[CompilerGeneratedAttribute] // RVA: 0x98130 Offset: 0x97530 VA: 0x180098130
	// RVA: 0x4F9D80 Offset: 0x4F8380 VA: 0x1804F9D80
	private void <ChooseBackgroundImage>g__PreloadBackgroundImage|56_0(string url) { }

}

private struct LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d : IAsyncStateMachine // TypeDefIndex: 11119
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string url; // 0x28
	public LoadingScreen <>4__this; // 0x30
	private TaskAwaiter<string> <>u__1; // 0x38

	// Methods

	// RVA: 0xF2800 Offset: 0xF1C00 VA: 0x1800F2800 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

