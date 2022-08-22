public class LootPanel : MonoBehaviour // TypeDefIndex: 11026
{	public Text Title; // 0x18
	public bool hideInvalidIcons; // 0x20
	[TooltipAttribute] // RVA: 0x90120 Offset: 0x8F520 VA: 0x180090120
	public CanvasGroup canvasGroup; // 0x28
	private ItemIcon[] allIcons; // 0x30

	public ItemContainer Container_00 { get; }
	public ItemContainer Container_01 { get; }
	public ItemContainer Container_02 { get; }
	public ItemContainer Container_03 { get; }
	public string lootingEntityName { get; }


	public ItemContainer get_Container_00() { }

	public ItemContainer get_Container_01() { }

	public ItemContainer get_Container_02() { }

	public ItemContainer get_Container_03() { }

	public T GetContainerEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1890 Offset: 0x5CFE90 VA: 0x1805D1890
	|-LootPanel.GetContainerEntity<Locker>
	|-LootPanel.GetContainerEntity<ReclaimTerminal>
	|-LootPanel.GetContainerEntity<RepairBench>
	|-LootPanel.GetContainerEntity<object>
	*/

	public BaseEntity GetContainerEntity() { }

	protected virtual void Awake() { }

	public virtual void Update() { }

	protected virtual void OnDisable() { }

	public string get_lootingEntityName() { }

	public void .ctor() { }

}

