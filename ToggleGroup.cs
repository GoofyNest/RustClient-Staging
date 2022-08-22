public class ToggleGroup : UIBehaviour // TypeDefIndex: 5018
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_AllowSwitchOff; // 0x18
	private List<Toggle> m_Toggles; // 0x20

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_allowSwitchOff() { }

	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x22479D0 Offset: 0x2245FD0 VA: 0x1822479D0
	protected void .ctor() { }

	// RVA: 0x2247810 Offset: 0x2245E10 VA: 0x182247810 Slot: 6
	protected override void Start() { }

	// RVA: 0x22478A0 Offset: 0x2245EA0 VA: 0x1822478A0
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x2247430 Offset: 0x2245A30 VA: 0x182247430
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x2247830 Offset: 0x2245E30 VA: 0x182247830
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x2247670 Offset: 0x2245C70 VA: 0x182247670
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x2247380 Offset: 0x2245980 VA: 0x182247380
	public void EnsureValidState() { }

	// RVA: 0x2247250 Offset: 0x2245850 VA: 0x182247250
	public bool AnyTogglesOn() { }

	// RVA: 0x2247150 Offset: 0x2245750 VA: 0x182247150
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x22476E0 Offset: 0x2245CE0 VA: 0x1822476E0
	public void SetAllTogglesOff(bool sendCallback = True) { }

}

private sealed class ToggleGroup.<>c // TypeDefIndex: 5019
{	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__12_0; // 0x8
	public static Func<Toggle, bool> <>9__13_0; // 0x10

	// Methods

	// RVA: 0x22482B0 Offset: 0x22468B0 VA: 0x1822482B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <AnyTogglesOn>b__12_0(Toggle x) { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <ActiveToggles>b__13_0(Toggle x) { }

}

