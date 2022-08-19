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

	// RVA: 0x55EC90 Offset: 0x55D290 VA: 0x18055EC90 Slot: 6
	protected override void Awake() { }

	// RVA: 0x55F1E0 Offset: 0x55D7E0 VA: 0x18055F1E0 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x55FAF0 Offset: 0x55E0F0 VA: 0x18055FAF0
	private void Update() { }

	// RVA: 0x5602E0 Offset: 0x55E8E0 VA: 0x1805602E0
	private bool get_shouldShowSessionButton() { }

	// RVA: 0x55F4F0 Offset: 0x55DAF0 VA: 0x18055F4F0
	private void OnEscape() { }

	// RVA: 0x55EE70 Offset: 0x55D470 VA: 0x18055EE70
	public void HideClicked() { }

	// RVA: 0x55EF10 Offset: 0x55D510 VA: 0x18055EF10
	public static void Hide() { }

	// RVA: 0x55F770 Offset: 0x55DD70 VA: 0x18055F770
	public static void Show() { }

	// RVA: 0x55F6A0 Offset: 0x55DCA0 VA: 0x18055F6A0
	private void ShowDemoBrowserButton() { }

	// RVA: 0x55F300 Offset: 0x55D900 VA: 0x18055F300
	private void OnEnabledState(bool b) { }

	// RVA: 0x55F170 Offset: 0x55D770 VA: 0x18055F170
	private static void OnConnected() { }

	// RVA: 0x55F290 Offset: 0x55D890 VA: 0x18055F290
	private static void OnDisconnected() { }

	// RVA: 0x55F120 Offset: 0x55D720 VA: 0x18055F120
	public void OnClickedQuitDemo() { }

	// RVA: 0x560280 Offset: 0x55E880 VA: 0x180560280
	public void .ctor() { }

	// RVA: 0x560240 Offset: 0x55E840 VA: 0x180560240
	private static void .cctor() { }

}

private sealed class MainMenuSystem.<>c // TypeDefIndex: 11121
{	// Fields
	public static readonly MainMenuSystem.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, bool> <>9__15_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__15_1; // 0x10

	// Methods

	// RVA: 0x56FA90 Offset: 0x56E090 VA: 0x18056FA90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EBE0 Offset: 0x56D1E0 VA: 0x18056EBE0
	internal bool <Update>b__15_0(IPlayerItemDefinition x) { }

	// RVA: 0x56ECA0 Offset: 0x56D2A0 VA: 0x18056ECA0
	internal int <Update>b__15_1(IPlayerItemDefinition x) { }

}

