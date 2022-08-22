public class VirtualItemIcon : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11067
{	// Fields
	public ItemDefinition itemDef; // 0x18
	public int itemAmount; // 0x20
	public bool asBlueprint; // 0x24
	public Image iconImage; // 0x28
	public Image bpUnderlay; // 0x30
	public Text amountText; // 0x38
	public Text hoverText; // 0x40
	public CanvasGroup iconContents; // 0x48
	public Tooltip ToolTip; // 0x50
	public CanvasGroup conditionObject; // 0x58
	public Image conditionFill; // 0x60
	public Image maxConditionFill; // 0x68
	public Image cornerIcon; // 0x70

	// Methods

	// RVA: 0x7FC7F0 Offset: 0x7FADF0 VA: 0x1807FC7F0
	public void SetVirtualItem(ItemDefinition info, int amount = 0, ulong skinId = 0, bool asBP = False, int dataInt = 0) { }

	// RVA: 0x7FC520 Offset: 0x7FAB20 VA: 0x1807FC520
	public void SetToolTip(ItemDefinition info, int amount, bool asBP) { }

	// RVA: 0x7FC6F0 Offset: 0x7FACF0 VA: 0x1807FC6F0
	public void SetTooltip(string itemName, int amount, bool asBP) { }

	// RVA: 0x7FCD00 Offset: 0x7FB300 VA: 0x1807FCD00
	public void UpdateAmount(int amount) { }

	// RVA: 0x7FC250 Offset: 0x7FA850 VA: 0x1807FC250
	public Sprite GetItemSkinSprite(ItemDefinition info, ulong skin) { }

	// RVA: 0x7FCFE0 Offset: 0x7FB5E0 VA: 0x1807FCFE0
	private void UpdateHoverText(int dataInt) { }

	// RVA: 0x7FD100 Offset: 0x7FB700 VA: 0x1807FD100
	public void UpdateIcon(ItemDefinition info, ulong skinId = 0) { }

	// RVA: 0x7FCDE0 Offset: 0x7FB3E0 VA: 0x1807FCDE0
	public void UpdateCondition(float itemMaxCondition, float itemConditionNormalized) { }

	// RVA: 0x7FC180 Offset: 0x7FA780 VA: 0x1807FC180
	public void DisableCondition() { }

	// RVA: 0x7FC3F0 Offset: 0x7FA9F0 VA: 0x1807FC3F0 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7FC4A0 Offset: 0x7FAAA0 VA: 0x1807FC4A0 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class VirtualItemIcon.<>c__DisplayClass17_0 // TypeDefIndex: 11068
{	// Fields
	public ulong skin; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7F0070 Offset: 0x7EE670 VA: 0x1807F0070
	internal bool <GetItemSkinSprite>b__0(ItemSkinDirectory.Skin x) { }

}

