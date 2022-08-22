public class MainMenuSystem : SingletonComponent<MainMenuSystem> // TypeDefIndex: 11120
{	// Fields
	public static bool isOpen; // 0x0
	public static Action OnOpenStateChanged; // 0x8
	public RustButton SessionButton; // 0x18
	public GameObject SessionPanel; // 0x20
	public GameObject NewsStoriesAlert; // 0x28
	public GameObject ItemStoreAlert; // 0x30
	public GameObject CompanionAlert; // 0x38
	public GameObject DemoBrowser; // 0x40
	public GameObject DemoBrowserButton; // 0x48
	public GameObject SuicideButton; // 0x50
	public GameObject EndDemoButton; // 0x58
	public GameObject ReflexModeOption; // 0x60
	public GameObject ReflexLatencyMarkerOption; // 0x68

	// Properties
	private bool shouldShowSessionButton { get; }

	// Methods

	// RVA: 0x55EC20 Offset: 0x55D220 VA: 0x18055EC20 Slot: 6
	protected override void Awake() { }

	// RVA: 0x55F170 Offset: 0x55D770 VA: 0x18055F170 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x55FA80 Offset: 0x55E080 VA: 0x18055FA80
	private void Update() { }

	// RVA: 0x560270 Offset: 0x55E870 VA: 0x180560270
	private bool get_shouldShowSessionButton() { }

	// RVA: 0x55F480 Offset: 0x55DA80 VA: 0x18055F480
	private void OnEscape() { }

	// RVA: 0x55EE00 Offset: 0x55D400 VA: 0x18055EE00
	public void HideClicked() { }

	// RVA: 0x55EEA0 Offset: 0x55D4A0 VA: 0x18055EEA0
	public static void Hide() { }

	// RVA: 0x55F700 Offset: 0x55DD00 VA: 0x18055F700
	public static void Show() { }

	// RVA: 0x55F630 Offset: 0x55DC30 VA: 0x18055F630
	private void ShowDemoBrowserButton() { }

	// RVA: 0x55F290 Offset: 0x55D890 VA: 0x18055F290
	private void OnEnabledState(bool b) { }

	// RVA: 0x55F100 Offset: 0x55D700 VA: 0x18055F100
	private static void OnConnected() { }

	// RVA: 0x55F220 Offset: 0x55D820 VA: 0x18055F220
	private static void OnDisconnected() { }

	// RVA: 0x55F0B0 Offset: 0x55D6B0 VA: 0x18055F0B0
	public void OnClickedQuitDemo() { }

	// RVA: 0x560210 Offset: 0x55E810 VA: 0x180560210
	public void .ctor() { }

	// RVA: 0x5601D0 Offset: 0x55E7D0 VA: 0x1805601D0
	private static void .cctor() { }

}

private sealed class MainMenuSystem.<>c // TypeDefIndex: 11121
{	// Fields
	public static readonly MainMenuSystem.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, bool> <>9__15_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__15_1; // 0x10

	// Methods

	// RVA: 0x56FA20 Offset: 0x56E020 VA: 0x18056FA20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EB70 Offset: 0x56D170 VA: 0x18056EB70
	internal bool <Update>b__15_0(IPlayerItemDefinition x) { }

	// RVA: 0x56EC30 Offset: 0x56D230 VA: 0x18056EC30
	internal int <Update>b__15_1(IPlayerItemDefinition x) { }

}

