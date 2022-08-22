public class MarketTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6396
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong customerSteamId; // 0x18
	public uint marketplaceId; // 0x20
	public List<MarketTerminal.PendingOrder> orders; // 0x28
	public string customerName; // 0x30
	public TimeUntil timeUntilExpiry; // 0x38

	// Methods

	// RVA: 0x1F43C20 Offset: 0x1F42220 VA: 0x181F43C20
	public static void ResetToPool(MarketTerminal instance) { }

	// RVA: 0x1F43E40 Offset: 0x1F42440 VA: 0x181F43E40
	public void ResetToPool() { }

	// RVA: 0x1F43B60 Offset: 0x1F42160 VA: 0x181F43B60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F42570 Offset: 0x1F40B70 VA: 0x181F42570
	public void CopyTo(MarketTerminal instance) { }

	// RVA: 0x1F42730 Offset: 0x1F40D30 VA: 0x181F42730
	public MarketTerminal Copy() { }

	// RVA: 0x1F43840 Offset: 0x1F41E40 VA: 0x181F43840
	public static MarketTerminal Deserialize(Stream stream) { }

	// RVA: 0x1F427B0 Offset: 0x1F40DB0 VA: 0x181F427B0
	public static MarketTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F42C20 Offset: 0x1F41220 VA: 0x181F42C20
	public static MarketTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F43170 Offset: 0x1F41770 VA: 0x181F43170
	public static MarketTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1F43BE0 Offset: 0x1F421E0 VA: 0x181F43BE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F448A0 Offset: 0x1F42EA0 VA: 0x181F448A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F448C0 Offset: 0x1F42EC0 VA: 0x181F448C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal previous) { }

	// RVA: 0x1F43C00 Offset: 0x1F42200 VA: 0x181F43C00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F43070 Offset: 0x1F41670 VA: 0x181F43070
	public static MarketTerminal Deserialize(byte[] buffer, MarketTerminal instance, bool isDelta = False) { }

	// RVA: 0x1F43530 Offset: 0x1F41B30 VA: 0x181F43530
	public static MarketTerminal Deserialize(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F42830 Offset: 0x1F40E30 VA: 0x181F42830
	public static MarketTerminal DeserializeLengthDelimited(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F42CB0 Offset: 0x1F412B0 VA: 0x181F42CB0
	public static MarketTerminal DeserializeLength(Stream stream, int length, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F44060 Offset: 0x1F42660 VA: 0x181F44060
	public static void SerializeDelta(Stream stream, MarketTerminal instance, MarketTerminal previous) { }

	// RVA: 0x1F445A0 Offset: 0x1F42BA0 VA: 0x181F445A0
	public static void Serialize(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1F44890 Offset: 0x1F42E90 VA: 0x181F44890
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F448A0 Offset: 0x1F42EA0 VA: 0x181F448A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F44490 Offset: 0x1F42A90 VA: 0x181F44490
	public static byte[] SerializeToBytes(MarketTerminal instance) { }

	// RVA: 0x1F443E0 Offset: 0x1F429E0 VA: 0x181F443E0
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class MarketTerminal.PendingOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6397
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingMachineId; // 0x14
	public uint droneId; // 0x18
	public TimeUntil timeUntilExpiry; // 0x1C

	// Methods

	// RVA: 0x1F57D90 Offset: 0x1F56390 VA: 0x181F57D90
	public static void ResetToPool(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F57E30 Offset: 0x1F56430 VA: 0x181F57E30
	public void ResetToPool() { }

	// RVA: 0x1F57B30 Offset: 0x1F56130 VA: 0x181F57B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F56B70 Offset: 0x1F55170 VA: 0x181F56B70
	public void CopyTo(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F56BA0 Offset: 0x1F551A0 VA: 0x181F56BA0
	public MarketTerminal.PendingOrder Copy() { }

	// RVA: 0x1F57930 Offset: 0x1F55F30 VA: 0x181F57930
	public static MarketTerminal.PendingOrder Deserialize(Stream stream) { }

	// RVA: 0x1F56C20 Offset: 0x1F55220 VA: 0x181F56C20
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F571A0 Offset: 0x1F557A0 VA: 0x181F571A0
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F573F0 Offset: 0x1F559F0 VA: 0x181F573F0
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1F57BB0 Offset: 0x1F561B0 VA: 0x181F57BB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F583C0 Offset: 0x1F569C0 VA: 0x181F583C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F583E0 Offset: 0x1F569E0 VA: 0x181F583E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F57D70 Offset: 0x1F56370 VA: 0x181F57D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F576A0 Offset: 0x1F55CA0 VA: 0x181F576A0
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer, MarketTerminal.PendingOrder instance, bool isDelta = False) { }

	// RVA: 0x1F57230 Offset: 0x1F55830 VA: 0x181F57230
	public static MarketTerminal.PendingOrder Deserialize(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56CA0 Offset: 0x1F552A0 VA: 0x181F56CA0
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56F30 Offset: 0x1F55530 VA: 0x181F56F30
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F57ED0 Offset: 0x1F564D0 VA: 0x181F57ED0
	public static void SerializeDelta(Stream stream, MarketTerminal.PendingOrder instance, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F58280 Offset: 0x1F56880 VA: 0x181F58280
	public static void Serialize(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F583B0 Offset: 0x1F569B0 VA: 0x181F583B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F583C0 Offset: 0x1F569C0 VA: 0x181F583C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F58170 Offset: 0x1F56770 VA: 0x181F58170
	public static byte[] SerializeToBytes(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F580C0 Offset: 0x1F566C0 VA: 0x181F580C0
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class MarketTerminal : StorageContainer // TypeDefIndex: 8409
{	// Fields
	private Option __menuOption_Menu_RequestOpenMarket; // 0x3D0
	private ulong _currentlyDisplayedUserId; // 0x428
	public const BaseEntity.Flags Flag_HasItems = 128;
	public const BaseEntity.Flags Flag_InventoryFull = 256;
	[HeaderAttribute] // RVA: 0xED3D0 Offset: 0xEC7D0 VA: 0x1800ED3D0
	public GameObjectRef menuPrefab; // 0x430
	public ulong lockToCustomerDuration; // 0x438
	public ulong orderTimeout; // 0x440
	public ItemDefinition deliveryFeeCurrency; // 0x448
	public int deliveryFeeAmount; // 0x450
	public DeliveryDroneConfig config; // 0x458
	public RustText userLabel; // 0x460
	private ulong _customerSteamId; // 0x468
	private string _customerName; // 0x470
	private TimeUntil _timeUntilCustomerExpiry; // 0x478
	private EntityRef<Marketplace> _marketplace; // 0x480
	public List<MarketTerminal.PendingOrder> pendingOrders; // 0x490

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x958FA0 Offset: 0x9575A0 VA: 0x180958FA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x95A6F0 Offset: 0x958CF0 VA: 0x18095A6F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x959890 Offset: 0x957E90 VA: 0x180959890 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x958C20 Offset: 0x957220 VA: 0x180958C20
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x958E40 Offset: 0x957440 VA: 0x180958E40
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9589C0 Offset: 0x956FC0 VA: 0x1809589C0
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.Description] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.Icon] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	// RVA: 0x959850 Offset: 0x957E50 VA: 0x180959850
	public void Menu_RequestOpenMarket(BasePlayer player) { }

	// RVA: 0x959840 Offset: 0x957E40 VA: 0x180959840
	public bool Menu_RequestOpenMarket_ShowIf(BasePlayer player) { }

	// RVA: 0x95A5A0 Offset: 0x958BA0 VA: 0x18095A5A0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x95A400 Offset: 0x958A00 VA: 0x18095A400 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x958760 Offset: 0x956D60 VA: 0x180958760
	public bool CanPlayerAffordOrderAndDeliveryFee(BasePlayer player, VendingMachine.SellOrder sellOrder, int numberOfTransactions) { }

	// RVA: 0x9592B0 Offset: 0x9578B0 VA: 0x1809592B0
	public bool HasPendingOrderFor(uint vendingMachineId) { }

	// RVA: 0x958900 Offset: 0x956F00 VA: 0x180958900
	public bool CanPlayerInteract(BasePlayer player) { }

	// RVA: 0x9593E0 Offset: 0x9579E0 VA: 0x1809593E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x95A680 Offset: 0x958C80 VA: 0x18095A680
	public void .ctor() { }

}

private sealed class MarketTerminal.<>c // TypeDefIndex: 8410
{	// Fields
	public static readonly MarketTerminal.<>c <>9; // 0x0
	public static Func<Item, int> <>9__27_0; // 0x8
	public static Func<MarketTerminal.PendingOrder, uint> <>9__28_0; // 0x10

	// Methods

	// RVA: 0x9710B0 Offset: 0x96F6B0 VA: 0x1809710B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EB50 Offset: 0x56D150 VA: 0x18056EB50
	internal int <CanPlayerAffordOrderAndDeliveryFee>b__27_0(Item i) { }

	// RVA: 0x970F70 Offset: 0x96F570 VA: 0x180970F70
	internal uint <HasPendingOrderFor>b__28_0(MarketTerminal.PendingOrder o) { }

}

