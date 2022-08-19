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

	// RVA: 0x1F43300 Offset: 0x1F41900 VA: 0x181F43300
	public static void ResetToPool(MarketTerminal instance) { }

	// RVA: 0x1F43520 Offset: 0x1F41B20 VA: 0x181F43520
	public void ResetToPool() { }

	// RVA: 0x1F43240 Offset: 0x1F41840 VA: 0x181F43240 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F41C50 Offset: 0x1F40250 VA: 0x181F41C50
	public void CopyTo(MarketTerminal instance) { }

	// RVA: 0x1F41E10 Offset: 0x1F40410 VA: 0x181F41E10
	public MarketTerminal Copy() { }

	// RVA: 0x1F42F20 Offset: 0x1F41520 VA: 0x181F42F20
	public static MarketTerminal Deserialize(Stream stream) { }

	// RVA: 0x1F41E90 Offset: 0x1F40490 VA: 0x181F41E90
	public static MarketTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F42300 Offset: 0x1F40900 VA: 0x181F42300
	public static MarketTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F42850 Offset: 0x1F40E50 VA: 0x181F42850
	public static MarketTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1F432C0 Offset: 0x1F418C0 VA: 0x181F432C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F43F80 Offset: 0x1F42580 VA: 0x181F43F80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F43FA0 Offset: 0x1F425A0 VA: 0x181F43FA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal previous) { }

	// RVA: 0x1F432E0 Offset: 0x1F418E0 VA: 0x181F432E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F42750 Offset: 0x1F40D50 VA: 0x181F42750
	public static MarketTerminal Deserialize(byte[] buffer, MarketTerminal instance, bool isDelta = False) { }

	// RVA: 0x1F42C10 Offset: 0x1F41210 VA: 0x181F42C10
	public static MarketTerminal Deserialize(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F41F10 Offset: 0x1F40510 VA: 0x181F41F10
	public static MarketTerminal DeserializeLengthDelimited(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F42390 Offset: 0x1F40990 VA: 0x181F42390
	public static MarketTerminal DeserializeLength(Stream stream, int length, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F43740 Offset: 0x1F41D40 VA: 0x181F43740
	public static void SerializeDelta(Stream stream, MarketTerminal instance, MarketTerminal previous) { }

	// RVA: 0x1F43C80 Offset: 0x1F42280 VA: 0x181F43C80
	public static void Serialize(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1F43F70 Offset: 0x1F42570 VA: 0x181F43F70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F43F80 Offset: 0x1F42580 VA: 0x181F43F80
	public void ToProto(Stream stream) { }

	// RVA: 0x1F43B70 Offset: 0x1F42170 VA: 0x181F43B70
	public static byte[] SerializeToBytes(MarketTerminal instance) { }

	// RVA: 0x1F43AC0 Offset: 0x1F420C0 VA: 0x181F43AC0
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

	// RVA: 0x1F57470 Offset: 0x1F55A70 VA: 0x181F57470
	public static void ResetToPool(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F57510 Offset: 0x1F55B10 VA: 0x181F57510
	public void ResetToPool() { }

	// RVA: 0x1F57210 Offset: 0x1F55810 VA: 0x181F57210 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F56250 Offset: 0x1F54850 VA: 0x181F56250
	public void CopyTo(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F56280 Offset: 0x1F54880 VA: 0x181F56280
	public MarketTerminal.PendingOrder Copy() { }

	// RVA: 0x1F57010 Offset: 0x1F55610 VA: 0x181F57010
	public static MarketTerminal.PendingOrder Deserialize(Stream stream) { }

	// RVA: 0x1F56300 Offset: 0x1F54900 VA: 0x181F56300
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F56880 Offset: 0x1F54E80 VA: 0x181F56880
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F56AD0 Offset: 0x1F550D0 VA: 0x181F56AD0
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1F57290 Offset: 0x1F55890 VA: 0x181F57290
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F57AA0 Offset: 0x1F560A0 VA: 0x181F57AA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F57AC0 Offset: 0x1F560C0 VA: 0x181F57AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F57450 Offset: 0x1F55A50 VA: 0x181F57450 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F56D80 Offset: 0x1F55380 VA: 0x181F56D80
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer, MarketTerminal.PendingOrder instance, bool isDelta = False) { }

	// RVA: 0x1F56910 Offset: 0x1F54F10 VA: 0x181F56910
	public static MarketTerminal.PendingOrder Deserialize(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56380 Offset: 0x1F54980 VA: 0x181F56380
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F56610 Offset: 0x1F54C10 VA: 0x181F56610
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F575B0 Offset: 0x1F55BB0 VA: 0x181F575B0
	public static void SerializeDelta(Stream stream, MarketTerminal.PendingOrder instance, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F57960 Offset: 0x1F55F60 VA: 0x181F57960
	public static void Serialize(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F57A90 Offset: 0x1F56090 VA: 0x181F57A90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F57AA0 Offset: 0x1F560A0 VA: 0x181F57AA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F57850 Offset: 0x1F55E50 VA: 0x181F57850
	public static byte[] SerializeToBytes(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F577A0 Offset: 0x1F55DA0 VA: 0x181F577A0
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
	[HeaderAttribute] // RVA: 0xED380 Offset: 0xEC780 VA: 0x1800ED380
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x958610 Offset: 0x956C10 VA: 0x180958610
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x958830 Offset: 0x956E30 VA: 0x180958830
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x9583B0 Offset: 0x9569B0 VA: 0x1809583B0
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
	[BaseEntity.Menu.Description] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
	[BaseEntity.Menu.Icon] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
	[BaseEntity.Menu.ShowIf] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
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

