public class NeedsKeyboard : ListComponent<NeedsKeyboard> // TypeDefIndex: 8012
{	// Fields
	public UnityEvent onNoKeysDown; // 0x18
	public bool ShowEscapeUI; // 0x20
	public NeedsKeyboard.BypassOption AllowedBinds; // 0x24
	private List<string> binds; // 0x28
	private bool watchForNoKeys; // 0x30

	// Properties
	public static bool ShouldShowUI { get; }

	// Methods

	// RVA: 0x1071870 Offset: 0x106FE70 VA: 0x181071870
	private static void GetBindString(NeedsKeyboard.BypassOption bypassOption, List<string> resultBinds) { }

	// RVA: 0x1071590 Offset: 0x106FB90 VA: 0x181071590
	public static bool AnyActive(KeyCode key = 0, NeedsKeyboard.BypassOption forBypass = 0) { }

	// RVA: 0x1071BD0 Offset: 0x10701D0 VA: 0x181071BD0
	public static bool get_ShouldShowUI() { }

	// RVA: 0x1071910 Offset: 0x106FF10 VA: 0x181071910 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x1071B90 Offset: 0x1070190 VA: 0x181071B90
	public void Update() { }

	// RVA: 0x10713C0 Offset: 0x106F9C0 VA: 0x1810713C0
	private bool AllowKeyInput(KeyCode k, NeedsKeyboard.BypassOption forBypass) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	protected virtual bool ShouldBlockInput() { }

	// RVA: 0x1071330 Offset: 0x106F930 VA: 0x181071330
	public void .ctor() { }

}

public enum NeedsKeyboard.BypassOption // TypeDefIndex: 8013
{	// Fields
	public int value__; // 0x0
	public const NeedsKeyboard.BypassOption Voice = 1;
	public const NeedsKeyboard.BypassOption Chat = 4;
	public const NeedsKeyboard.BypassOption Gesture = 8;

}

