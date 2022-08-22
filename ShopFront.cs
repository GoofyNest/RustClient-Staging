public class ShopFront : StorageContainer // TypeDefIndex: 8637
{	// Fields
	public float maxUseAngle; // 0x3D0
	public BasePlayer vendorPlayer; // 0x3D8
	public BasePlayer customerPlayer; // 0x3E0
	public GameObjectRef transactionCompleteEffect; // 0x3E8

	// Properties
	private float AngleDotProduct { get; }

	// Methods

	// RVA: 0x596100 Offset: 0x594700 VA: 0x180596100 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x596B70 Offset: 0x595170 VA: 0x180596B70
	private float get_AngleDotProduct() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool TradeLocked() { }

	// RVA: 0x595BE0 Offset: 0x5941E0 VA: 0x180595BE0
	public bool IsTradingPlayer(BasePlayer player) { }

	// RVA: 0x595B00 Offset: 0x594100 VA: 0x180595B00
	public bool IsPlayerCustomer(BasePlayer player) { }

	// RVA: 0x595B70 Offset: 0x594170 VA: 0x180595B70
	public bool IsPlayerVendor(BasePlayer player) { }

	// RVA: 0x596870 Offset: 0x594E70 VA: 0x180596870
	public bool PlayerInVendorPos(BasePlayer player) { }

	// RVA: 0x5966A0 Offset: 0x594CA0 VA: 0x1805966A0
	public bool PlayerInCustomerPos(BasePlayer player) { }

	// RVA: 0x595D10 Offset: 0x594310 VA: 0x180595D10
	public bool LootEligable(BasePlayer player) { }

	// RVA: 0x595A60 Offset: 0x594060 VA: 0x180595A60 Slot: 151
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x596A50 Offset: 0x595050 VA: 0x180596A50 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5958C0 Offset: 0x593EC0 VA: 0x1805958C0
	public void CLIENT_ReceivePlayers(BaseEntity.RPCMessage msg) { }

	// RVA: 0x596B10 Offset: 0x595110 VA: 0x180596B10
	public void .ctor() { }

}

public static class ShopFront.ShopFrontFlags // TypeDefIndex: 8638
{	// Fields
	public const BaseEntity.Flags VendorAccepted = 128;
	public const BaseEntity.Flags CustomerAccepted = 256;
	public const BaseEntity.Flags Exchanging = 512;

}

