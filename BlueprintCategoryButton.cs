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

	// RVA: 0x514BD0 Offset: 0x5131D0 VA: 0x180514BD0
	private void OnEnable() { }

	// RVA: 0x514B20 Offset: 0x513120 VA: 0x180514B20
	private void OnDisable() { }

	// RVA: 0x514FC0 Offset: 0x5135C0 VA: 0x180514FC0
	private void Update() { }

	// RVA: 0x514C50 Offset: 0x513250 VA: 0x180514C50 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x514EC0 Offset: 0x5134C0 VA: 0x180514EC0
	private void UpdateValue() { }

	// RVA: 0x5150F0 Offset: 0x5136F0 VA: 0x1805150F0
	public void ValueChanged(bool b) { }

	// RVA: 0x514C60 Offset: 0x513260 VA: 0x180514C60 Slot: 5
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x514E40 Offset: 0x513440 VA: 0x180514E40 Slot: 6
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x5149F0 Offset: 0x512FF0 VA: 0x1805149F0
	public void DoBounceAnim() { }

	// RVA: 0x515480 Offset: 0x513A80 VA: 0x180515480
	public void .ctor() { }

}

