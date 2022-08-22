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

	// RVA: 0x1F43140 Offset: 0x1F41740 VA: 0x181F43140
	public static void ResetToPool(MarketTerminal instance) { }

	// RVA: 0x1F43360 Offset: 0x1F41960 VA: 0x181F43360
	public void ResetToPool() { }

	// RVA: 0x1F43080 Offset: 0x1F41680 VA: 0x181F43080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F41A90 Offset: 0x1F40090 VA: 0x181F41A90
	public void CopyTo(MarketTerminal instance) { }

	// RVA: 0x1F41C50 Offset: 0x1F40250 VA: 0x181F41C50
	public MarketTerminal Copy() { }

	// RVA: 0x1F42D60 Offset: 0x1F41360 VA: 0x181F42D60
	public static MarketTerminal Deserialize(Stream stream) { }

	// RVA: 0x1F41CD0 Offset: 0x1F402D0 VA: 0x181F41CD0
	public static MarketTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F42140 Offset: 0x1F40740 VA: 0x181F42140
	public static MarketTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F42690 Offset: 0x1F40C90 VA: 0x181F42690
	public static MarketTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1F43100 Offset: 0x1F41700 VA: 0x181F43100
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F43DC0 Offset: 0x1F423C0 VA: 0x181F43DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F43DE0 Offset: 0x1F423E0 VA: 0x181F43DE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal previous) { }

	// RVA: 0x1F43120 Offset: 0x1F41720 VA: 0x181F43120 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F42590 Offset: 0x1F40B90 VA: 0x181F42590
	public static MarketTerminal Deserialize(byte[] buffer, MarketTerminal instance, bool isDelta = False) { }

	// RVA: 0x1F42A50 Offset: 0x1F41050 VA: 0x181F42A50
	public static MarketTerminal Deserialize(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F41D50 Offset: 0x1F40350 VA: 0x181F41D50
	public static MarketTerminal DeserializeLengthDelimited(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F421D0 Offset: 0x1F407D0 VA: 0x181F421D0
	public static MarketTerminal DeserializeLength(Stream stream, int length, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F43580 Offset: 0x1F41B80 VA: 0x181F43580
	public static void SerializeDelta(Stream stream, MarketTerminal instance, MarketTerminal previous) { }

	// RVA: 0x1F43AC0 Offset: 0x1F420C0 VA: 0x181F43AC0
	public static void Serialize(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1F43DB0 Offset: 0x1F423B0 VA: 0x181F43DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F43DC0 Offset: 0x1F423C0 VA: 0x181F43DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F439B0 Offset: 0x1F41FB0 VA: 0x181F439B0
	public static byte[] SerializeToBytes(MarketTerminal instance) { }

	// RVA: 0x1F43900 Offset: 0x1F41F00 VA: 0x181F43900
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F572B0 Offset: 0x1F558B0 VA: 0x181F572B0
	public static void ResetToPool(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F57350 Offset: 0x1F55950 VA: 0x181F57350
	public void ResetToPool() { }

	// RVA: 0x1F57050 Offset: 0x1F55650 VA: 0x181F57050 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F56090 Offset: 0x1F54690 VA: 0x181F56090
	public void CopyTo(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F560C0 Offset: 0x1F546C0 VA: 0x181F560C0
	public MarketTerminal.PendingOrder Copy() { }

	// RVA: 0x1F56E50 Offset: 0x1F55450 VA: 0x181F56E50
	public static MarketTerminal.PendingOrder Deserialize(Stream stream) { }

	// RVA: 0x1F56140 Offset: 0x1F54740 VA: 0x181F56140
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F566C0 Offset: 0x1F54CC0 VA: 0x181F566C0
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F56910 Offset: 0x1F54F10 VA: 0x181F56910
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1F570D0 Offset: 0x1F556D0 VA: 0x181F570D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F578E0 Offset: 0x1F55EE0 VA: 0x181F578E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F57900 Offset: 0x1F55F00 VA: 0x181F57900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F57290 Offset: 0x1F55890 VA: 0x181F57290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F56BC0 Offset: 0x1F551C0 VA: 0x181F56BC0
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer, MarketTerminal.PendingOrder instance, bool isDelta = False) { }

	// RVA: 0x1F56750 Offset: 0x1F54D50 VA: 0x181F56750
	public static MarketTerminal.PendingOrder Deserialize(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F561C0 Offset: 0x1F547C0 VA: 0x181F561C0
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56450 Offset: 0x1F54A50 VA: 0x181F56450
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F573F0 Offset: 0x1F559F0 VA: 0x181F573F0
	public static void SerializeDelta(Stream stream, MarketTerminal.PendingOrder instance, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F577A0 Offset: 0x1F55DA0 VA: 0x181F577A0
	public static void Serialize(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F578D0 Offset: 0x1F55ED0 VA: 0x181F578D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F578E0 Offset: 0x1F55EE0 VA: 0x181F578E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F57690 Offset: 0x1F55C90 VA: 0x181F57690
	public static byte[] SerializeToBytes(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F575E0 Offset: 0x1F55BE0 VA: 0x181F575E0
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x958990 Offset: 0x956F90 VA: 0x180958990 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x95A0E0 Offset: 0x9586E0 VA: 0x18095A0E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x959280 Offset: 0x957880 VA: 0x180959280 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x958610 Offset: 0x956C10 VA: 0x180958610
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x958830 Offset: 0x956E30 VA: 0x180958830
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9583B0 Offset: 0x9569B0 VA: 0x1809583B0
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.Description] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.Icon] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xED6E0 Offset: 0xECAE0 VA: 0x1800ED6E0
	// RVA: 0x959240 Offset: 0x957840 VA: 0x180959240
	public void Menu_RequestOpenMarket(BasePlayer player) { }

	// RVA: 0x959230 Offset: 0x957830 VA: 0x180959230
	public bool Menu_RequestOpenMarket_ShowIf(BasePlayer player) { }

	// RVA: 0x959F90 Offset: 0x958590 VA: 0x180959F90 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x959DF0 Offset: 0x9583F0 VA: 0x180959DF0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x958150 Offset: 0x956750 VA: 0x180958150
	public bool CanPlayerAffordOrderAndDeliveryFee(BasePlayer player, VendingMachine.SellOrder sellOrder, int numberOfTransactions) { }

	// RVA: 0x958CA0 Offset: 0x9572A0 VA: 0x180958CA0
	public bool HasPendingOrderFor(uint vendingMachineId) { }

	// RVA: 0x9582F0 Offset: 0x9568F0 VA: 0x1809582F0
	public bool CanPlayerInteract(BasePlayer player) { }

	// RVA: 0x958DD0 Offset: 0x9573D0 VA: 0x180958DD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x95A070 Offset: 0x958670 VA: 0x18095A070
	public void .ctor() { }

}

private sealed class MarketTerminal.<>c // TypeDefIndex: 8410
{	// Fields
	public static readonly MarketTerminal.<>c <>9; // 0x0
	public static Func<Item, int> <>9__27_0; // 0x8
	public static Func<MarketTerminal.PendingOrder, uint> <>9__28_0; // 0x10

	// Methods

	// RVA: 0x970AA0 Offset: 0x96F0A0 VA: 0x180970AA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EBC0 Offset: 0x56D1C0 VA: 0x18056EBC0
	internal int <CanPlayerAffordOrderAndDeliveryFee>b__27_0(Item i) { }

	// RVA: 0x970960 Offset: 0x96EF60 VA: 0x180970960
	internal uint <HasPendingOrderFor>b__28_0(MarketTerminal.PendingOrder o) { }

}

