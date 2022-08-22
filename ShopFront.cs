public class ShopFront : StorageContainer // TypeDefIndex: 8637
{	// Fields
	public float maxUseAngle; // 0x3D0
	public BasePlayer vendorPlayer; // 0x3D8
	public BasePlayer customerPlayer; // 0x3E0
	public GameObjectRef transactionCompleteEffect; // 0x3E8

	// Properties
	private float AngleDotProduct { get; }

	// Methods

	// RVA: 0x596090 Offset: 0x594690 VA: 0x180596090 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x596B00 Offset: 0x595100 VA: 0x180596B00
	private float get_AngleDotProduct() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool TradeLocked() { }

	// RVA: 0x595B70 Offset: 0x594170 VA: 0x180595B70
	public bool IsTradingPlayer(BasePlayer player) { }

	// RVA: 0x595A90 Offset: 0x594090 VA: 0x180595A90
	public bool IsPlayerCustomer(BasePlayer player) { }

	// RVA: 0x595B00 Offset: 0x594100 VA: 0x180595B00
	public bool IsPlayerVendor(BasePlayer player) { }

	// RVA: 0x596800 Offset: 0x594E00 VA: 0x180596800
	public bool PlayerInVendorPos(BasePlayer player) { }

	// RVA: 0x596630 Offset: 0x594C30 VA: 0x180596630
	public bool PlayerInCustomerPos(BasePlayer player) { }

	// RVA: 0x595CA0 Offset: 0x5942A0 VA: 0x180595CA0
	public bool LootEligable(BasePlayer player) { }

	// RVA: 0x5959F0 Offset: 0x593FF0 VA: 0x1805959F0 Slot: 151
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x5969E0 Offset: 0x594FE0 VA: 0x1805969E0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x595850 Offset: 0x593E50 VA: 0x180595850
	public void CLIENT_ReceivePlayers(BaseEntity.RPCMessage msg) { }

	// RVA: 0x596AA0 Offset: 0x5950A0 VA: 0x180596AA0
	public void .ctor() { }

}

public static class ShopFront.ShopFrontFlags // TypeDefIndex: 8638
{	// Fields
	public const BaseEntity.Flags VendorAccepted = 128;
	public const BaseEntity.Flags CustomerAccepted = 256;
	public const BaseEntity.Flags Exchanging = 512;

}

