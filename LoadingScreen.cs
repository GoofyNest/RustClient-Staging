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

	// RVA: 0x4FAAE0 Offset: 0x4F90E0 VA: 0x1804FAAE0
	public static bool get_isOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FAAA0 Offset: 0x4F90A0 VA: 0x1804FAAA0
	public static bool get_WantsSkip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FAC90 Offset: 0x4F9290 VA: 0x1804FAC90
	private static void set_WantsSkip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FAC40 Offset: 0x4F9240 VA: 0x1804FAC40
	private static void set_Text(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4FAA60 Offset: 0x4F9060 VA: 0x1804FAA60
	public static string get_Text() { }

	// RVA: 0x4F85D0 Offset: 0x4F6BD0 VA: 0x1804F85D0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4F9570 Offset: 0x4F7B70 VA: 0x1804F9570 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x4F9660 Offset: 0x4F7C60 VA: 0x1804F9660
	public void OnDisable() { }

	// RVA: 0x4F9950 Offset: 0x4F7F50 VA: 0x1804F9950
	public static void Show(bool hideCancel = False) { }

	// RVA: 0x4F9000 Offset: 0x4F7600 VA: 0x1804F9000
	public static void Hide() { }

	// RVA: 0x4F9670 Offset: 0x4F7C70 VA: 0x1804F9670
	public static void ShowPerformanceWarning() { }

	// RVA: 0x4F8C80 Offset: 0x4F7280 VA: 0x1804F8C80
	public static void HidePerformanceWarning() { }

	// RVA: 0x4F97C0 Offset: 0x4F7DC0 VA: 0x1804F97C0
	public static void ShowSkip() { }

	// RVA: 0x4F8E70 Offset: 0x4F7470 VA: 0x1804F8E70
	public static void HideSkip() { }

	// RVA: 0x4FA5C0 Offset: 0x4F8BC0 VA: 0x1804FA5C0
	public static void Update(string strType) { }

	// RVA: 0x4FA820 Offset: 0x4F8E20 VA: 0x1804FA820
	public static void Update(string strType, string strSubtitle) { }

	// RVA: 0x4F9EF0 Offset: 0x4F84F0 VA: 0x1804F9EF0
	public void UpdateFromServer(string strTitle, string strSubtitle) { }

	// RVA: 0x4F8880 Offset: 0x4F6E80 VA: 0x1804F8880
	public void CancelLoading() { }

	// RVA: 0x4F9DB0 Offset: 0x4F83B0 VA: 0x1804F9DB0
	public void SkipLoading() { }

	// RVA: 0x4F8DD0 Offset: 0x4F73D0 VA: 0x1804F8DD0
	private void HidePingWarning() { }

	// RVA: 0x4F9FB0 Offset: 0x4F85B0 VA: 0x1804F9FB0
	private void UpdatePingWarning() { }

	// RVA: 0x4FA2F0 Offset: 0x4F88F0 VA: 0x1804FA2F0
	public void UpdateServerInfo(Nullable<ServerInfo> server, Dictionary<string, string> serverRules) { }

	// RVA: 0x4F93F0 Offset: 0x4F79F0 VA: 0x1804F93F0
	private void LoadBackgroundImage() { }

	// RVA: 0x4F8BC0 Offset: 0x4F71C0 VA: 0x1804F8BC0
	private void FreeBackgroundImage() { }

	// RVA: 0x4F8930 Offset: 0x4F6F30 VA: 0x1804F8930
	private void ChooseBackgroundImage() { }

	// RVA: 0x4FA9E0 Offset: 0x4F8FE0 VA: 0x1804FA9E0
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0x98130 Offset: 0x97530 VA: 0x180098130
	[CompilerGeneratedAttribute] // RVA: 0x98130 Offset: 0x97530 VA: 0x180098130
	// RVA: 0x4F9DF0 Offset: 0x4F83F0 VA: 0x1804F9DF0
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

