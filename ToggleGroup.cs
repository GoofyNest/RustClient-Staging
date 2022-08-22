public class ToggleGroup : UIBehaviour // TypeDefIndex: 5018
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_AllowSwitchOff; // 0x18
	private List<Toggle> m_Toggles; // 0x20

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_allowSwitchOff() { }

	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x22481F0 Offset: 0x22467F0 VA: 0x1822481F0
	protected void .ctor() { }

	// RVA: 0x2248030 Offset: 0x2246630 VA: 0x182248030 Slot: 6
	protected override void Start() { }

	// RVA: 0x22480C0 Offset: 0x22466C0 VA: 0x1822480C0
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x2247C50 Offset: 0x2246250 VA: 0x182247C50
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x2248050 Offset: 0x2246650 VA: 0x182248050
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x2247E90 Offset: 0x2246490 VA: 0x182247E90
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x2247BA0 Offset: 0x22461A0 VA: 0x182247BA0
	public void EnsureValidState() { }

	// RVA: 0x2247A70 Offset: 0x2246070 VA: 0x182247A70
	public bool AnyTogglesOn() { }

	// RVA: 0x2247970 Offset: 0x2245F70 VA: 0x182247970
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x2247F00 Offset: 0x2246500 VA: 0x182247F00
	public void SetAllTogglesOff(bool sendCallback = True) { }

}

private sealed class ToggleGroup.<>c // TypeDefIndex: 5019
{	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__12_0; // 0x8
	public static Func<Toggle, bool> <>9__13_0; // 0x10

	// Methods

	// RVA: 0x2248AD0 Offset: 0x22470D0 VA: 0x182248AD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1980 Offset: 0x4CFF80 VA: 0x1804D1980
	internal bool <AnyTogglesOn>b__12_0(Toggle x) { }

	// RVA: 0x4D1980 Offset: 0x4CFF80 VA: 0x1804D1980
	internal bool <ActiveToggles>b__13_0(Toggle x) { }

}

