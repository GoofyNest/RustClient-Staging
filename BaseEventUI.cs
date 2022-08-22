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
	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	private void set_ID(int value) { }

	// RVA: 0x7B2B40 Offset: 0x7B1140 VA: 0x1807B2B40 Slot: 4
	public virtual void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0x7B2E50 Offset: 0x7B1450 VA: 0x1807B2E50 Slot: 5
	public virtual AIEventData Save() { }

	// RVA: 0x7B2C40 Offset: 0x7B1240 VA: 0x1807B2C40 Slot: 6
	public virtual void Load(AIEventData data) { }

	// RVA: 0x7B2FE0 Offset: 0x7B15E0 VA: 0x1807B2FE0
	public void SetOutputStateContainer(int id) { }

	// RVA: 0x7B2810 Offset: 0x7B0E10 VA: 0x1807B2810
	public void ClearOutputStateContainer() { }

	// RVA: 0x7B2AF0 Offset: 0x7B10F0 VA: 0x1807B2AF0
	public int GetOutputStateContainer() { }

	// RVA: 0x7B2E20 Offset: 0x7B1420 VA: 0x1807B2E20
	public float ParseFloat(string input) { }

	// RVA: 0x7B2860 Offset: 0x7B0E60 VA: 0x1807B2860
	public void Clicked() { }

	// RVA: 0x7B2D80 Offset: 0x7B1380 VA: 0x1807B2D80
	public void OutputClicked(object value) { }

	// RVA: 0x7B2AC0 Offset: 0x7B10C0 VA: 0x1807B2AC0
	public void DeleteClicked() { }

	// RVA: 0x7B2D50 Offset: 0x7B1350 VA: 0x1807B2D50
	public void MoveUpClicked() { }

	// RVA: 0x7B2D20 Offset: 0x7B1320 VA: 0x1807B2D20
	public void MoveDownClicked() { }

	// RVA: 0x7B3020 Offset: 0x7B1620 VA: 0x1807B3020
	public void SetTriggered(bool flag) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

