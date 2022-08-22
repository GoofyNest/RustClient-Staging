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

	// RVA: 0xA9E2C0 Offset: 0xA9C8C0 VA: 0x180A9E2C0
	public void ItemSelectionMade(ItemDefinition info, bool asBP) { }

	// RVA: 0xA9E850 Offset: 0xA9CE50 VA: 0x180A9E850
	public void Search(string search) { }

	// RVA: 0xA9E120 Offset: 0xA9C720 VA: 0x180A9E120
	private bool IsValidSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA9E5C0 Offset: 0xA9CBC0 VA: 0x180A9E5C0
	private float ScoreSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA9E4B0 Offset: 0xA9CAB0 VA: 0x180A9E4B0
	public void OnSellSearchChanged() { }

	// RVA: 0xA9E420 Offset: 0xA9CA20 VA: 0x180A9E420
	public void OnCurrencySearchChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnSellSearchComplete() { }

	// RVA: 0xA9DB60 Offset: 0xA9C160 VA: 0x180A9DB60
	public void AddSellOrder() { }

	// RVA: 0xA9E540 Offset: 0xA9CB40 VA: 0x180A9E540
	public void ResetSellOrderObjects() { }

	// RVA: 0xA9E410 Offset: 0xA9CA10 VA: 0x180A9E410
	public void OnAmountTextChanged() { }

	// RVA: 0xA9DDF0 Offset: 0xA9C3F0 VA: 0x180A9DDF0
	public void ClampAmountValues() { }

	// RVA: 0xA9DF90 Offset: 0xA9C590 VA: 0x180A9DF90
	public int ClampedAmountValue(string amount, ItemDefinition itemDef, bool limitToStackable = True) { }

	// RVA: 0xA9E0F0 Offset: 0xA9C6F0 VA: 0x180A9E0F0
	public int GetIntAmount(string text) { }

	// RVA: 0xA9E070 Offset: 0xA9C670 VA: 0x180A9E070
	public void CurrencyPlusMinus(int delta) { }

	// RVA: 0xA9EBE0 Offset: 0xA9D1E0 VA: 0x180A9EBE0
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

	// RVA: 0xAAB790 Offset: 0xAA9D90 VA: 0x180AAB790
	internal bool <Search>b__0(ItemDefinition x) { }

	// RVA: 0xAAB940 Offset: 0xAA9F40 VA: 0x180AAB940
	internal float <Search>b__1(ItemDefinition y) { }

}

