public class SellOrderEntry : MonoBehaviour, IInventoryChanged // TypeDefIndex: 8734
{	// Fields
	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private ItemDefinition merchandiseInfo; // 0x28
	private ItemDefinition currencyInfo; // 0x30
	public GameObject buyButton; // 0x38
	public GameObject cantaffordNotification; // 0x40
	public GameObject outOfStockNotification; // 0x48
	private IVendingMachineInterface vendingPanel; // 0x50
	public UIIntegerEntry intEntry; // 0x58
	public Action<SellOrderEntry, int> onAmountChanged; // 0x60
	public VendingMachine.SellOrder sellOrder; // 0x68
	private bool dirty; // 0x70
	private int minMultiplier; // 0x74
	private bool merchIsBP; // 0x78
	private bool currencyIsBP; // 0x79
	private int merchandiseSellSize; // 0x7C
	private int currencyAmountPerItem; // 0x80
	private int index; // 0x84
	private int numInStock; // 0x88
	private float itemCondition; // 0x8C
	private float itemConditionMax; // 0x90
	private int itemInstanceInt; // 0x94

	// Methods

	// RVA: 0x58AD10 Offset: 0x589310 VA: 0x18058AD10
	public void OnEnable() { }

	// RVA: 0x58AC10 Offset: 0x589210 VA: 0x18058AC10
	public void OnDisable() { }

	// RVA: 0x58AEB0 Offset: 0x5894B0 VA: 0x18058AEB0
	public void Setup(VendingMachine.SellOrder so, int newIndex, IVendingMachineInterface panel, int minMultiplier = 1) { }

	// RVA: 0x58ADE0 Offset: 0x5893E0 VA: 0x18058ADE0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x58B790 Offset: 0x589D90 VA: 0x18058B790
	public void Update() { }

	// RVA: 0x58A3C0 Offset: 0x5889C0 VA: 0x18058A3C0
	public void AmountTextChanged() { }

	// RVA: 0x58ADF0 Offset: 0x5893F0 VA: 0x18058ADF0
	public void SetAmount(int newAmount) { }

	// RVA: 0x58AA00 Offset: 0x589000 VA: 0x18058AA00
	public int GetDesiredTransactionCount() { }

	// RVA: 0x58A6A0 Offset: 0x588CA0 VA: 0x18058A6A0
	public int CurrencyAvailable() { }

	// RVA: 0x58ABE0 Offset: 0x5891E0 VA: 0x18058ABE0
	public int MaxTransactionsAffordable() { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	public int MaxTransactionsAvailable() { }

	// RVA: 0x58AAA0 Offset: 0x5890A0 VA: 0x18058AAA0
	public int GetMaxTransactionCount() { }

	// RVA: 0x58B080 Offset: 0x589680 VA: 0x18058B080
	public void UpdateIcons() { }

	// RVA: 0x58B590 Offset: 0x589B90 VA: 0x18058B590
	public void UpdateNotifications() { }

	// RVA: 0x58A660 Offset: 0x588C60 VA: 0x18058A660
	public bool CanAfford() { }

	// RVA: 0x58A580 Offset: 0x588B80 VA: 0x18058A580
	public void BuyClick() { }

	// RVA: 0x58B7D0 Offset: 0x589DD0 VA: 0x18058B7D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x58B040 Offset: 0x589640 VA: 0x18058B040
	private bool <CurrencyAvailable>b__30_0(Item x) { }

}

private sealed class SellOrderEntry.<>c // TypeDefIndex: 8735
{	// Fields
	public static readonly SellOrderEntry.<>c <>9; // 0x0
	public static Func<Item, bool> <>9__30_1; // 0x8
	public static Func<Item, int> <>9__30_2; // 0x10

	// Methods

	// RVA: 0x5A4BD0 Offset: 0x5A31D0 VA: 0x1805A4BD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A43B0 Offset: 0x5A29B0 VA: 0x1805A43B0
	internal bool <CurrencyAvailable>b__30_1(Item x) { }

	// RVA: 0x56EB50 Offset: 0x56D150 VA: 0x18056EB50
	internal int <CurrencyAvailable>b__30_2(Item x) { }

}

