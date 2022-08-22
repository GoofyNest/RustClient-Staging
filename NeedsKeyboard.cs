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

	// RVA: 0x1070E00 Offset: 0x106F400 VA: 0x181070E00
	private static void GetBindString(NeedsKeyboard.BypassOption bypassOption, List<string> resultBinds) { }

	// RVA: 0x1070B20 Offset: 0x106F120 VA: 0x181070B20
	public static bool AnyActive(KeyCode key = 0, NeedsKeyboard.BypassOption forBypass = 0) { }

	// RVA: 0x1071160 Offset: 0x106F760 VA: 0x181071160
	public static bool get_ShouldShowUI() { }

	// RVA: 0x1070EA0 Offset: 0x106F4A0 VA: 0x181070EA0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x1071120 Offset: 0x106F720 VA: 0x181071120
	public void Update() { }

	// RVA: 0x1070950 Offset: 0x106EF50 VA: 0x181070950
	private bool AllowKeyInput(KeyCode k, NeedsKeyboard.BypassOption forBypass) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	protected virtual bool ShouldBlockInput() { }

	// RVA: 0x10708C0 Offset: 0x106EEC0 VA: 0x1810708C0
	public void .ctor() { }

}

public enum NeedsKeyboard.BypassOption // TypeDefIndex: 8013
{	// Fields
	public int value__; // 0x0
	public const NeedsKeyboard.BypassOption Voice = 1;
	public const NeedsKeyboard.BypassOption Chat = 4;
	public const NeedsKeyboard.BypassOption Gesture = 8;

}

