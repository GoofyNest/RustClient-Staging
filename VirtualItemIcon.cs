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

	// RVA: 0x7FC6E0 Offset: 0x7FACE0 VA: 0x1807FC6E0
	public void SetVirtualItem(ItemDefinition info, int amount = 0, ulong skinId = 0, bool asBP = False, int dataInt = 0) { }

	// RVA: 0x7FC410 Offset: 0x7FAA10 VA: 0x1807FC410
	public void SetToolTip(ItemDefinition info, int amount, bool asBP) { }

	// RVA: 0x7FC5E0 Offset: 0x7FABE0 VA: 0x1807FC5E0
	public void SetTooltip(string itemName, int amount, bool asBP) { }

	// RVA: 0x7FCBF0 Offset: 0x7FB1F0 VA: 0x1807FCBF0
	public void UpdateAmount(int amount) { }

	// RVA: 0x7FC140 Offset: 0x7FA740 VA: 0x1807FC140
	public Sprite GetItemSkinSprite(ItemDefinition info, ulong skin) { }

	// RVA: 0x7FCED0 Offset: 0x7FB4D0 VA: 0x1807FCED0
	private void UpdateHoverText(int dataInt) { }

	// RVA: 0x7FCFF0 Offset: 0x7FB5F0 VA: 0x1807FCFF0
	public void UpdateIcon(ItemDefinition info, ulong skinId = 0) { }

	// RVA: 0x7FCCD0 Offset: 0x7FB2D0 VA: 0x1807FCCD0
	public void UpdateCondition(float itemMaxCondition, float itemConditionNormalized) { }

	// RVA: 0x7FC070 Offset: 0x7FA670 VA: 0x1807FC070
	public void DisableCondition() { }

	// RVA: 0x7FC2E0 Offset: 0x7FA8E0 VA: 0x1807FC2E0 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7FC390 Offset: 0x7FA990 VA: 0x1807FC390 Slot: 5
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

	// RVA: 0x7EFF60 Offset: 0x7EE560 VA: 0x1807EFF60
	internal bool <GetItemSkinSprite>b__0(ItemSkinDirectory.Skin x) { }

}

