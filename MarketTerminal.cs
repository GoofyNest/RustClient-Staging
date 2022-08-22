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

	// RVA: 0x1F43400 Offset: 0x1F41A00 VA: 0x181F43400
	public static void ResetToPool(MarketTerminal instance) { }

	// RVA: 0x1F43620 Offset: 0x1F41C20 VA: 0x181F43620
	public void ResetToPool() { }

	// RVA: 0x1F43340 Offset: 0x1F41940 VA: 0x181F43340 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F41D50 Offset: 0x1F40350 VA: 0x181F41D50
	public void CopyTo(MarketTerminal instance) { }

	// RVA: 0x1F41F10 Offset: 0x1F40510 VA: 0x181F41F10
	public MarketTerminal Copy() { }

	// RVA: 0x1F43020 Offset: 0x1F41620 VA: 0x181F43020
	public static MarketTerminal Deserialize(Stream stream) { }

	// RVA: 0x1F41F90 Offset: 0x1F40590 VA: 0x181F41F90
	public static MarketTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F42400 Offset: 0x1F40A00 VA: 0x181F42400
	public static MarketTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F42950 Offset: 0x1F40F50 VA: 0x181F42950
	public static MarketTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1F433C0 Offset: 0x1F419C0 VA: 0x181F433C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F44080 Offset: 0x1F42680 VA: 0x181F44080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F440A0 Offset: 0x1F426A0 VA: 0x181F440A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal previous) { }

	// RVA: 0x1F433E0 Offset: 0x1F419E0 VA: 0x181F433E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F42850 Offset: 0x1F40E50 VA: 0x181F42850
	public static MarketTerminal Deserialize(byte[] buffer, MarketTerminal instance, bool isDelta = False) { }

	// RVA: 0x1F42D10 Offset: 0x1F41310 VA: 0x181F42D10
	public static MarketTerminal Deserialize(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F42010 Offset: 0x1F40610 VA: 0x181F42010
	public static MarketTerminal DeserializeLengthDelimited(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F42490 Offset: 0x1F40A90 VA: 0x181F42490
	public static MarketTerminal DeserializeLength(Stream stream, int length, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F43840 Offset: 0x1F41E40 VA: 0x181F43840
	public static void SerializeDelta(Stream stream, MarketTerminal instance, MarketTerminal previous) { }

	// RVA: 0x1F43D80 Offset: 0x1F42380 VA: 0x181F43D80
	public static void Serialize(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1F44070 Offset: 0x1F42670 VA: 0x181F44070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F44080 Offset: 0x1F42680 VA: 0x181F44080
	public void ToProto(Stream stream) { }

	// RVA: 0x1F43C70 Offset: 0x1F42270 VA: 0x181F43C70
	public static byte[] SerializeToBytes(MarketTerminal instance) { }

	// RVA: 0x1F43BC0 Offset: 0x1F421C0 VA: 0x181F43BC0
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1F57570 Offset: 0x1F55B70 VA: 0x181F57570
	public static void ResetToPool(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F57610 Offset: 0x1F55C10 VA: 0x181F57610
	public void ResetToPool() { }

	// RVA: 0x1F57310 Offset: 0x1F55910 VA: 0x181F57310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F56350 Offset: 0x1F54950 VA: 0x181F56350
	public void CopyTo(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F56380 Offset: 0x1F54980 VA: 0x181F56380
	public MarketTerminal.PendingOrder Copy() { }

	// RVA: 0x1F57110 Offset: 0x1F55710 VA: 0x181F57110
	public static MarketTerminal.PendingOrder Deserialize(Stream stream) { }

	// RVA: 0x1F56400 Offset: 0x1F54A00 VA: 0x181F56400
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F56980 Offset: 0x1F54F80 VA: 0x181F56980
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F56BD0 Offset: 0x1F551D0 VA: 0x181F56BD0
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1F57390 Offset: 0x1F55990 VA: 0x181F57390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F57BA0 Offset: 0x1F561A0 VA: 0x181F57BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F57BC0 Offset: 0x1F561C0 VA: 0x181F57BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F57550 Offset: 0x1F55B50 VA: 0x181F57550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F56E80 Offset: 0x1F55480 VA: 0x181F56E80
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer, MarketTerminal.PendingOrder instance, bool isDelta = False) { }

	// RVA: 0x1F56A10 Offset: 0x1F55010 VA: 0x181F56A10
	public static MarketTerminal.PendingOrder Deserialize(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56480 Offset: 0x1F54A80 VA: 0x181F56480
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56710 Offset: 0x1F54D10 VA: 0x181F56710
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F576B0 Offset: 0x1F55CB0 VA: 0x181F576B0
	public static void SerializeDelta(Stream stream, MarketTerminal.PendingOrder instance, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F57A60 Offset: 0x1F56060 VA: 0x181F57A60
	public static void Serialize(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F57B90 Offset: 0x1F56190 VA: 0x181F57B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F57BA0 Offset: 0x1F561A0 VA: 0x181F57BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F57950 Offset: 0x1F55F50 VA: 0x181F57950
	public static byte[] SerializeToBytes(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F578A0 Offset: 0x1F55EA0 VA: 0x181F578A0
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x958AA0 Offset: 0x9570A0 VA: 0x180958AA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x95A1F0 Offset: 0x9587F0 VA: 0x18095A1F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x959390 Offset: 0x957990 VA: 0x180959390 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x958720 Offset: 0x956D20 VA: 0x180958720
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x958940 Offset: 0x956F40 VA: 0x180958940
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9584C0 Offset: 0x956AC0 VA: 0x1809584C0
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.Description] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.Icon] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	// RVA: 0x959350 Offset: 0x957950 VA: 0x180959350
	public void Menu_RequestOpenMarket(BasePlayer player) { }

	// RVA: 0x959340 Offset: 0x957940 VA: 0x180959340
	public bool Menu_RequestOpenMarket_ShowIf(BasePlayer player) { }

	// RVA: 0x95A0A0 Offset: 0x9586A0 VA: 0x18095A0A0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x959F00 Offset: 0x958500 VA: 0x180959F00 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x958260 Offset: 0x956860 VA: 0x180958260
	public bool CanPlayerAffordOrderAndDeliveryFee(BasePlayer player, VendingMachine.SellOrder sellOrder, int numberOfTransactions) { }

	// RVA: 0x958DB0 Offset: 0x9573B0 VA: 0x180958DB0
	public bool HasPendingOrderFor(uint vendingMachineId) { }

	// RVA: 0x958400 Offset: 0x956A00 VA: 0x180958400
	public bool CanPlayerInteract(BasePlayer player) { }

	// RVA: 0x958EE0 Offset: 0x9574E0 VA: 0x180958EE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x95A180 Offset: 0x958780 VA: 0x18095A180
	public void .ctor() { }

}

private sealed class MarketTerminal.<>c // TypeDefIndex: 8410
{	// Fields
	public static readonly MarketTerminal.<>c <>9; // 0x0
	public static Func<Item, int> <>9__27_0; // 0x8
	public static Func<MarketTerminal.PendingOrder, uint> <>9__28_0; // 0x10

	// Methods

	// RVA: 0x970BB0 Offset: 0x96F1B0 VA: 0x180970BB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EBC0 Offset: 0x56D1C0 VA: 0x18056EBC0
	internal int <CanPlayerAffordOrderAndDeliveryFee>b__27_0(Item i) { }

	// RVA: 0x970A70 Offset: 0x96F070 VA: 0x180970A70
	internal uint <HasPendingOrderFor>b__28_0(MarketTerminal.PendingOrder o) { }

}

