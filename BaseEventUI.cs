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

	// RVA: 0x7E7110 Offset: 0x7E5710 VA: 0x1807E7110 Slot: 4
	public virtual void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0x7E7420 Offset: 0x7E5A20 VA: 0x1807E7420 Slot: 5
	public virtual AIEventData Save() { }

	// RVA: 0x7E7210 Offset: 0x7E5810 VA: 0x1807E7210 Slot: 6
	public virtual void Load(AIEventData data) { }

	// RVA: 0x7E75B0 Offset: 0x7E5BB0 VA: 0x1807E75B0
	public void SetOutputStateContainer(int id) { }

	// RVA: 0x7E6DE0 Offset: 0x7E53E0 VA: 0x1807E6DE0
	public void ClearOutputStateContainer() { }

	// RVA: 0x7E70C0 Offset: 0x7E56C0 VA: 0x1807E70C0
	public int GetOutputStateContainer() { }

	// RVA: 0x7E73F0 Offset: 0x7E59F0 VA: 0x1807E73F0
	public float ParseFloat(string input) { }

	// RVA: 0x7E6E30 Offset: 0x7E5430 VA: 0x1807E6E30
	public void Clicked() { }

	// RVA: 0x7E7350 Offset: 0x7E5950 VA: 0x1807E7350
	public void OutputClicked(object value) { }

	// RVA: 0x7E7090 Offset: 0x7E5690 VA: 0x1807E7090
	public void DeleteClicked() { }

	// RVA: 0x7E7320 Offset: 0x7E5920 VA: 0x1807E7320
	public void MoveUpClicked() { }

	// RVA: 0x7E72F0 Offset: 0x7E58F0 VA: 0x1807E72F0
	public void MoveDownClicked() { }

	// RVA: 0x7E75F0 Offset: 0x7E5BF0 VA: 0x1807E75F0
	public void SetTriggered(bool flag) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

