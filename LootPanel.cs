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

	// RVA: 0x50B2D0 Offset: 0x5098D0 VA: 0x18050B2D0
	public ItemContainer get_Container_00() { }

	// RVA: 0x50B510 Offset: 0x509B10 VA: 0x18050B510
	public ItemContainer get_Container_01() { }

	// RVA: 0x50B750 Offset: 0x509D50 VA: 0x18050B750
	public ItemContainer get_Container_02() { }

	// RVA: 0x50B990 Offset: 0x509F90 VA: 0x18050B990
	public ItemContainer get_Container_03() { }

	// RVA: -1 Offset: -1
	public T GetContainerEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1890 Offset: 0x5CFE90 VA: 0x1805D1890
	|-LootPanel.GetContainerEntity<Locker>
	|-LootPanel.GetContainerEntity<ReclaimTerminal>
	|-LootPanel.GetContainerEntity<RepairBench>
	|-LootPanel.GetContainerEntity<object>
	*/

	// RVA: 0x50AE40 Offset: 0x509440 VA: 0x18050AE40
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x50ADA0 Offset: 0x5093A0 VA: 0x18050ADA0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x50B150 Offset: 0x509750 VA: 0x18050B150 Slot: 5
	public virtual void Update() { }

	// RVA: 0x50B000 Offset: 0x509600 VA: 0x18050B000 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x50BBD0 Offset: 0x50A1D0 VA: 0x18050BBD0
	public string get_lootingEntityName() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

