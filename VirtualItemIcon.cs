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

	// RVA: 0x7FCD80 Offset: 0x7FB380 VA: 0x1807FCD80
	public void SetVirtualItem(ItemDefinition info, int amount = 0, ulong skinId = 0, bool asBP = False, int dataInt = 0) { }

	// RVA: 0x7FCAB0 Offset: 0x7FB0B0 VA: 0x1807FCAB0
	public void SetToolTip(ItemDefinition info, int amount, bool asBP) { }

	// RVA: 0x7FCC80 Offset: 0x7FB280 VA: 0x1807FCC80
	public void SetTooltip(string itemName, int amount, bool asBP) { }

	// RVA: 0x7FD290 Offset: 0x7FB890 VA: 0x1807FD290
	public void UpdateAmount(int amount) { }

	// RVA: 0x7FC7E0 Offset: 0x7FADE0 VA: 0x1807FC7E0
	public Sprite GetItemSkinSprite(ItemDefinition info, ulong skin) { }

	// RVA: 0x7FD570 Offset: 0x7FBB70 VA: 0x1807FD570
	private void UpdateHoverText(int dataInt) { }

	// RVA: 0x7FD690 Offset: 0x7FBC90 VA: 0x1807FD690
	public void UpdateIcon(ItemDefinition info, ulong skinId = 0) { }

	// RVA: 0x7FD370 Offset: 0x7FB970 VA: 0x1807FD370
	public void UpdateCondition(float itemMaxCondition, float itemConditionNormalized) { }

	// RVA: 0x7FC710 Offset: 0x7FAD10 VA: 0x1807FC710
	public void DisableCondition() { }

	// RVA: 0x7FC980 Offset: 0x7FAF80 VA: 0x1807FC980 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7FCA30 Offset: 0x7FB030 VA: 0x1807FCA30 Slot: 5
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

	// RVA: 0x7F0600 Offset: 0x7EEC00 VA: 0x1807F0600
	internal bool <GetItemSkinSprite>b__0(ItemSkinDirectory.Skin x) { }

}

