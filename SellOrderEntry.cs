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

	// RVA: 0x58AD80 Offset: 0x589380 VA: 0x18058AD80
	public void OnEnable() { }

	// RVA: 0x58AC80 Offset: 0x589280 VA: 0x18058AC80
	public void OnDisable() { }

	// RVA: 0x58AF20 Offset: 0x589520 VA: 0x18058AF20
	public void Setup(VendingMachine.SellOrder so, int newIndex, IVendingMachineInterface panel, int minMultiplier = 1) { }

	// RVA: 0x58AE50 Offset: 0x589450 VA: 0x18058AE50 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x58B800 Offset: 0x589E00 VA: 0x18058B800
	public void Update() { }

	// RVA: 0x58A430 Offset: 0x588A30 VA: 0x18058A430
	public void AmountTextChanged() { }

	// RVA: 0x58AE60 Offset: 0x589460 VA: 0x18058AE60
	public void SetAmount(int newAmount) { }

	// RVA: 0x58AA70 Offset: 0x589070 VA: 0x18058AA70
	public int GetDesiredTransactionCount() { }

	// RVA: 0x58A710 Offset: 0x588D10 VA: 0x18058A710
	public int CurrencyAvailable() { }

	// RVA: 0x58AC50 Offset: 0x589250 VA: 0x18058AC50
	public int MaxTransactionsAffordable() { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public int MaxTransactionsAvailable() { }

	// RVA: 0x58AB10 Offset: 0x589110 VA: 0x18058AB10
	public int GetMaxTransactionCount() { }

	// RVA: 0x58B0F0 Offset: 0x5896F0 VA: 0x18058B0F0
	public void UpdateIcons() { }

	// RVA: 0x58B600 Offset: 0x589C00 VA: 0x18058B600
	public void UpdateNotifications() { }

	// RVA: 0x58A6D0 Offset: 0x588CD0 VA: 0x18058A6D0
	public bool CanAfford() { }

	// RVA: 0x58A5F0 Offset: 0x588BF0 VA: 0x18058A5F0
	public void BuyClick() { }

	// RVA: 0x58B840 Offset: 0x589E40 VA: 0x18058B840
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x58B0B0 Offset: 0x5896B0 VA: 0x18058B0B0
	private bool <CurrencyAvailable>b__30_0(Item x) { }

}

private sealed class SellOrderEntry.<>c // TypeDefIndex: 8735
{	// Fields
	public static readonly SellOrderEntry.<>c <>9; // 0x0
	public static Func<Item, bool> <>9__30_1; // 0x8
	public static Func<Item, int> <>9__30_2; // 0x10

	// Methods

	// RVA: 0x5A4C40 Offset: 0x5A3240 VA: 0x1805A4C40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4420 Offset: 0x5A2A20 VA: 0x1805A4420
	internal bool <CurrencyAvailable>b__30_1(Item x) { }

	// RVA: 0x56EBC0 Offset: 0x56D1C0 VA: 0x18056EBC0
	internal int <CurrencyAvailable>b__30_2(Item x) { }

}

