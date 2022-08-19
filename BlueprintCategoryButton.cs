public class BlueprintCategoryButton : MonoBehaviour, IInventoryChanged, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 10984
{	// Fields
	public TextMeshProUGUI amountLabel; // 0x18
	public ItemCategory Category; // 0x20
	public bool AlwaysShow; // 0x24
	public bool ShowItemCount; // 0x25
	public GameObject BackgroundHighlight; // 0x28
	public SoundDefinition clickSound; // 0x30
	public SoundDefinition hoverSound; // 0x38
	private bool needsRefresh; // 0x40
	private int CurrentAmount; // 0x44
	private bool Selected; // 0x48

	// Methods

	// RVA: 0x514C40 Offset: 0x513240 VA: 0x180514C40
	private void OnEnable() { }

	// RVA: 0x514B90 Offset: 0x513190 VA: 0x180514B90
	private void OnDisable() { }

	// RVA: 0x515030 Offset: 0x513630 VA: 0x180515030
	private void Update() { }

	// RVA: 0x514CC0 Offset: 0x5132C0 VA: 0x180514CC0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x514F30 Offset: 0x513530 VA: 0x180514F30
	private void UpdateValue() { }

	// RVA: 0x515160 Offset: 0x513760 VA: 0x180515160
	public void ValueChanged(bool b) { }

	// RVA: 0x514CD0 Offset: 0x5132D0 VA: 0x180514CD0 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x514EB0 Offset: 0x5134B0 VA: 0x180514EB0 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x514A60 Offset: 0x513060 VA: 0x180514A60
	public void DoBounceAnim() { }

	// RVA: 0x5154F0 Offset: 0x513AF0 VA: 0x1805154F0
	public void .ctor() { }

}

