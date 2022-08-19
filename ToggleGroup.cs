public class ToggleGroup : UIBehaviour // TypeDefIndex: 5018
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_AllowSwitchOff; // 0x18
	private List<Toggle> m_Toggles; // 0x20

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_allowSwitchOff() { }

	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x22478D0 Offset: 0x2245ED0 VA: 0x1822478D0
	protected void .ctor() { }

	// RVA: 0x2247710 Offset: 0x2245D10 VA: 0x182247710 Slot: 6
	protected override void Start() { }

	// RVA: 0x22477A0 Offset: 0x2245DA0 VA: 0x1822477A0
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x2247330 Offset: 0x2245930 VA: 0x182247330
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x2247730 Offset: 0x2245D30 VA: 0x182247730
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x2247570 Offset: 0x2245B70 VA: 0x182247570
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x2247280 Offset: 0x2245880 VA: 0x182247280
	public void EnsureValidState() { }

	// RVA: 0x2247150 Offset: 0x2245750 VA: 0x182247150
	public bool AnyTogglesOn() { }

	// RVA: 0x2247050 Offset: 0x2245650 VA: 0x182247050
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x22475E0 Offset: 0x2245BE0 VA: 0x1822475E0
	public void SetAllTogglesOff(bool sendCallback = True) { }

}

private sealed class ToggleGroup.<>c // TypeDefIndex: 5019
{	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__12_0; // 0x8
	public static Func<Toggle, bool> <>9__13_0; // 0x10

	// Methods

	// RVA: 0x22481B0 Offset: 0x22467B0 VA: 0x1822481B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <AnyTogglesOn>b__12_0(Toggle x) { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <ActiveToggles>b__13_0(Toggle x) { }

}

