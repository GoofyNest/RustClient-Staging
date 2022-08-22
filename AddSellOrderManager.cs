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

	// RVA: 0xA9E790 Offset: 0xA9CD90 VA: 0x180A9E790
	public void ItemSelectionMade(ItemDefinition info, bool asBP) { }

	// RVA: 0xA9ED20 Offset: 0xA9D320 VA: 0x180A9ED20
	public void Search(string search) { }

	// RVA: 0xA9E5F0 Offset: 0xA9CBF0 VA: 0x180A9E5F0
	private bool IsValidSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA9EA90 Offset: 0xA9D090 VA: 0x180A9EA90
	private float ScoreSearchResult(string search, ItemDefinition target) { }

	// RVA: 0xA9E980 Offset: 0xA9CF80 VA: 0x180A9E980
	public void OnSellSearchChanged() { }

	// RVA: 0xA9E8F0 Offset: 0xA9CEF0 VA: 0x180A9E8F0
	public void OnCurrencySearchChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnSellSearchComplete() { }

	// RVA: 0xA9E030 Offset: 0xA9C630 VA: 0x180A9E030
	public void AddSellOrder() { }

	// RVA: 0xA9EA10 Offset: 0xA9D010 VA: 0x180A9EA10
	public void ResetSellOrderObjects() { }

	// RVA: 0xA9E8E0 Offset: 0xA9CEE0 VA: 0x180A9E8E0
	public void OnAmountTextChanged() { }

	// RVA: 0xA9E2C0 Offset: 0xA9C8C0 VA: 0x180A9E2C0
	public void ClampAmountValues() { }

	// RVA: 0xA9E460 Offset: 0xA9CA60 VA: 0x180A9E460
	public int ClampedAmountValue(string amount, ItemDefinition itemDef, bool limitToStackable = True) { }

	// RVA: 0xA9E5C0 Offset: 0xA9CBC0 VA: 0x180A9E5C0
	public int GetIntAmount(string text) { }

	// RVA: 0xA9E540 Offset: 0xA9CB40 VA: 0x180A9E540
	public void CurrencyPlusMinus(int delta) { }

	// RVA: 0xA9F0B0 Offset: 0xA9D6B0 VA: 0x180A9F0B0
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

	// RVA: 0xAABC60 Offset: 0xAAA260 VA: 0x180AABC60
	internal bool <Search>b__0(ItemDefinition x) { }

	// RVA: 0xAABE10 Offset: 0xAAA410 VA: 0x180AABE10
	internal float <Search>b__1(ItemDefinition y) { }

}

