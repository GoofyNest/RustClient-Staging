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

	// RVA: 0x1070B40 Offset: 0x106F140 VA: 0x181070B40
	private static void GetBindString(NeedsKeyboard.BypassOption bypassOption, List<string> resultBinds) { }

	// RVA: 0x1070860 Offset: 0x106EE60 VA: 0x181070860
	public static bool AnyActive(KeyCode key = 0, NeedsKeyboard.BypassOption forBypass = 0) { }

	// RVA: 0x1070EA0 Offset: 0x106F4A0 VA: 0x181070EA0
	public static bool get_ShouldShowUI() { }

	// RVA: 0x1070BE0 Offset: 0x106F1E0 VA: 0x181070BE0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x1070E60 Offset: 0x106F460 VA: 0x181070E60
	public void Update() { }

	// RVA: 0x1070690 Offset: 0x106EC90 VA: 0x181070690
	private bool AllowKeyInput(KeyCode k, NeedsKeyboard.BypassOption forBypass) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	protected virtual bool ShouldBlockInput() { }

	// RVA: 0x1070600 Offset: 0x106EC00 VA: 0x181070600
	public void .ctor() { }

}

public enum NeedsKeyboard.BypassOption // TypeDefIndex: 8013
{	// Fields
	public int value__; // 0x0
	public const NeedsKeyboard.BypassOption Voice = 1;
	public const NeedsKeyboard.BypassOption Chat = 4;
	public const NeedsKeyboard.BypassOption Gesture = 8;

}

