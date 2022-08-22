public class LootPanel : MonoBehaviour // TypeDefIndex: 11026
{	// Fields
	public Text Title; // 0x18
	public bool hideInvalidIcons; // 0x20
	[TooltipAttribute] // RVA: 0x90120 Offset: 0x8F520 VA: 0x180090120
	public CanvasGroup canvasGroup; // 0x28
	private ItemIcon[] allIcons; // 0x30

	// Properties
	public ItemContainer Container_00 { get; }
	public ItemContainer Container_01 { get; }
	public ItemContainer Container_02 { get; }
	public ItemContainer Container_03 { get; }
	public string lootingEntityName { get; }

	// Methods

	// RVA: 0x50B340 Offset: 0x509940 VA: 0x18050B340
	public ItemContainer get_Container_00() { }

	// RVA: 0x50B580 Offset: 0x509B80 VA: 0x18050B580
	public ItemContainer get_Container_01() { }

	// RVA: 0x50B7C0 Offset: 0x509DC0 VA: 0x18050B7C0
	public ItemContainer get_Container_02() { }

	// RVA: 0x50BA00 Offset: 0x50A000 VA: 0x18050BA00
	public ItemContainer get_Container_03() { }

	// RVA: -1 Offset: -1
	public T GetContainerEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1900 Offset: 0x5CFF00 VA: 0x1805D1900
	|-LootPanel.GetContainerEntity<Locker>
	|-LootPanel.GetContainerEntity<ReclaimTerminal>
	|-LootPanel.GetContainerEntity<RepairBench>
	|-LootPanel.GetContainerEntity<object>
	*/

	// RVA: 0x50AEB0 Offset: 0x5094B0 VA: 0x18050AEB0
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x50AE10 Offset: 0x509410 VA: 0x18050AE10 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x50B1C0 Offset: 0x5097C0 VA: 0x18050B1C0 Slot: 5
	public virtual void Update() { }

	// RVA: 0x50B070 Offset: 0x509670 VA: 0x18050B070 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x50BC40 Offset: 0x50A240 VA: 0x18050BC40
	public string get_lootingEntityName() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

