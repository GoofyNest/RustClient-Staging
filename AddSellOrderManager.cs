public class AddSellOrderManager : MonoBehaviour // TypeDefIndex: 8726
{	// Fields
	public VirtualItemIcon sellItemIcon; // 0x18
	public VirtualItemIcon currencyItemIcon; // 0x20
	public GameObject itemSearchParent; // 0x28
	public ItemSearchEntry itemSearchEntryPrefab; // 0x30
	public InputField sellItemInput; // 0x38
	public InputField sellItemAmount; // 0x40
	public InputField currencyItemInput; // 0x48
	public InputField currencyItemAmount; // 0x50
	public VendingPanelAdmin adminPanel; // 0x58

	// Methods

	// RVA: 0xA9E000 Offset: 0xA9C600 VA: 0x180A9E000
	public void ItemSelectionMade(ItemDefinition info, bool asBP) { }

	// RVA: 0xA9E590 Offset: 0xA9CB90 VA: 0x180A9E590
	public void Search(string search) { }

	// RVA: 0xA9DE60 Offset: 0xA9C460 VA: 0x180A9DE60
	private bool IsValidSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA9E300 Offset: 0xA9C900 VA: 0x180A9E300
	private float ScoreSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA9E1F0 Offset: 0xA9C7F0 VA: 0x180A9E1F0
	public void OnSellSearchChanged() { }

	// RVA: 0xA9E160 Offset: 0xA9C760 VA: 0x180A9E160
	public void OnCurrencySearchChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnSellSearchComplete() { }

	// RVA: 0xA9D8A0 Offset: 0xA9BEA0 VA: 0x180A9D8A0
	public void AddSellOrder() { }

	// RVA: 0xA9E280 Offset: 0xA9C880 VA: 0x180A9E280
	public void ResetSellOrderObjects() { }

	// RVA: 0xA9E150 Offset: 0xA9C750 VA: 0x180A9E150
	public void OnAmountTextChanged() { }

	// RVA: 0xA9DB30 Offset: 0xA9C130 VA: 0x180A9DB30
	public void ClampAmountValues() { }

	// RVA: 0xA9DCD0 Offset: 0xA9C2D0 VA: 0x180A9DCD0
	public int ClampedAmountValue(string amount, ItemDefinition itemDef, bool limitToStackable = True) { }

	// RVA: 0xA9DE30 Offset: 0xA9C430 VA: 0x180A9DE30
	public int GetIntAmount(string text) { }

	// RVA: 0xA9DDB0 Offset: 0xA9C3B0 VA: 0x180A9DDB0
	public void CurrencyPlusMinus(int delta) { }

	// RVA: 0xA9E920 Offset: 0xA9CF20 VA: 0x180A9E920
	public void SellItemPlusMinus(int delta) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class AddSellOrderManager.<>c__DisplayClass10_0 // TypeDefIndex: 8727
{	// Fields
	public AddSellOrderManager <>4__this; // 0x10
	public string search; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xAAB4D0 Offset: 0xAA9AD0 VA: 0x180AAB4D0
	internal bool <Search>b__0(ItemDefinition x) { }

	// RVA: 0xAAB680 Offset: 0xAA9C80 VA: 0x180AAB680
	internal float <Search>b__1(ItemDefinition y) { }

}

