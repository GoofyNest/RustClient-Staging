public class BaseEventUI : MonoBehaviour // TypeDefIndex: 10789
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public AIEventType EventType; // 0x18
	public RustText TextEventType; // 0x20
	public RustText TextOutput; // 0x28
	public RustButton ToggleInvert; // 0x30
	public Dropdown DropdownInputMemorySlot; // 0x38
	public Dropdown DropdownOutputMemorySlot; // 0x40
	public RustInput InputFloatValue; // 0x48
	public RustInput InputFloatValue2; // 0x50
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public BaseStateUI Output; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID>k__BackingField; // 0x60
	private BaseStateUI stateUI; // 0x68
	private Color outputColor; // 0x70

	// Properties
	public int ID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	private void set_ID(int value) { }

	// RVA: 0x7E7220 Offset: 0x7E5820 VA: 0x1807E7220 Slot: 4
	public virtual void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0x7E7530 Offset: 0x7E5B30 VA: 0x1807E7530 Slot: 5
	public virtual AIEventData Save() { }

	// RVA: 0x7E7320 Offset: 0x7E5920 VA: 0x1807E7320 Slot: 6
	public virtual void Load(AIEventData data) { }

	// RVA: 0x7E76C0 Offset: 0x7E5CC0 VA: 0x1807E76C0
	public void SetOutputStateContainer(int id) { }

	// RVA: 0x7E6EF0 Offset: 0x7E54F0 VA: 0x1807E6EF0
	public void ClearOutputStateContainer() { }

	// RVA: 0x7E71D0 Offset: 0x7E57D0 VA: 0x1807E71D0
	public int GetOutputStateContainer() { }

	// RVA: 0x7E7500 Offset: 0x7E5B00 VA: 0x1807E7500
	public float ParseFloat(string input) { }

	// RVA: 0x7E6F40 Offset: 0x7E5540 VA: 0x1807E6F40
	public void Clicked() { }

	// RVA: 0x7E7460 Offset: 0x7E5A60 VA: 0x1807E7460
	public void OutputClicked(object value) { }

	// RVA: 0x7E71A0 Offset: 0x7E57A0 VA: 0x1807E71A0
	public void DeleteClicked() { }

	// RVA: 0x7E7430 Offset: 0x7E5A30 VA: 0x1807E7430
	public void MoveUpClicked() { }

	// RVA: 0x7E7400 Offset: 0x7E5A00 VA: 0x1807E7400
	public void MoveDownClicked() { }

	// RVA: 0x7E7700 Offset: 0x7E5D00 VA: 0x1807E7700
	public void SetTriggered(bool flag) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

