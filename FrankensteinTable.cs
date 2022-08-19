public class FrankensteinTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemIds; // 0x18

	// Methods

	// RVA: 0x1D5B110 Offset: 0x1D59710 VA: 0x181D5B110
	public static void ResetToPool(FrankensteinTable instance) { }

	// RVA: 0x1D5B1F0 Offset: 0x1D597F0 VA: 0x181D5B1F0
	public void ResetToPool() { }

	// RVA: 0x1D5AF80 Offset: 0x1D59580 VA: 0x181D5AF80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5A290 Offset: 0x1D58890 VA: 0x181D5A290
	public void CopyTo(FrankensteinTable instance) { }

	// RVA: 0x1D5A3B0 Offset: 0x1D589B0 VA: 0x181D5A3B0
	public FrankensteinTable Copy() { }

	// RVA: 0x1D5AD40 Offset: 0x1D59340 VA: 0x181D5AD40
	public static FrankensteinTable Deserialize(Stream stream) { }

	// RVA: 0x1D5A7A0 Offset: 0x1D58DA0 VA: 0x181D5A7A0
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5AA90 Offset: 0x1D59090 VA: 0x181D5AA90
	public static FrankensteinTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5AB20 Offset: 0x1D59120 VA: 0x181D5AB20
	public static FrankensteinTable Deserialize(byte[] buffer) { }

	// RVA: 0x1D5B0D0 Offset: 0x1D596D0 VA: 0x181D5B0D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5B740 Offset: 0x1D59D40 VA: 0x181D5B740 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5B760 Offset: 0x1D59D60 VA: 0x181D5B760 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FrankensteinTable previous) { }

	// RVA: 0x1D5B0F0 Offset: 0x1D596F0 VA: 0x181D5B0F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5AC40 Offset: 0x1D59240 VA: 0x181D5AC40
	public static FrankensteinTable Deserialize(byte[] buffer, FrankensteinTable instance, bool isDelta = False) { }

	// RVA: 0x1D5ADC0 Offset: 0x1D593C0 VA: 0x181D5ADC0
	public static FrankensteinTable Deserialize(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5A510 Offset: 0x1D58B10 VA: 0x181D5A510
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5A820 Offset: 0x1D58E20 VA: 0x181D5A820
	public static FrankensteinTable DeserializeLength(Stream stream, int length, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5B2D0 Offset: 0x1D598D0 VA: 0x181D5B2D0
	public static void SerializeDelta(Stream stream, FrankensteinTable instance, FrankensteinTable previous) { }

	// RVA: 0x1D5B5E0 Offset: 0x1D59BE0 VA: 0x181D5B5E0
	public static void Serialize(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x1D5B730 Offset: 0x1D59D30 VA: 0x181D5B730
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5B740 Offset: 0x1D59D40 VA: 0x181D5B740
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5B4D0 Offset: 0x1D59AD0 VA: 0x181D5B4D0
	public static byte[] SerializeToBytes(FrankensteinTable instance) { }

	// RVA: 0x1D5B420 Offset: 0x1D59A20 VA: 0x181D5B420
	public static void SerializeLengthDelimited(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class FrankensteinTable : StorageContainer // TypeDefIndex: 8392
{	// Fields
	private Option __menuOption_MenuSleepFrankenstein; // 0x3D0
	private Option __menuOption_MenuWakeFrankenstein; // 0x428
	public GameObjectRef FrankensteinPrefab; // 0x480
	public Transform SpawnLocation; // 0x488
	public ItemDefinition WeaponItem; // 0x490
	public List<ItemDefinition> HeadItems; // 0x498
	public List<ItemDefinition> TorsoItems; // 0x4A0
	public List<ItemDefinition> LegItems; // 0x4A8
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public List<ItemDefinition> ItemsToUse; // 0x4B0
	public FrankensteinTableVisuals TableVisuals; // 0x4B8
	[HeaderAttribute] // RVA: 0xDFC00 Offset: 0xDF000 VA: 0x1800DFC00
	public float TableDownDuration; // 0x4C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x753370 Offset: 0x751970 VA: 0x180753370 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x754780 Offset: 0x752D80 VA: 0x180754780 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7541D0 Offset: 0x7527D0 VA: 0x1807541D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x753DC0 Offset: 0x7523C0 VA: 0x180753DC0
	public bool IsHeadItem(ItemDefinition itemDef) { }

	// RVA: 0x753E80 Offset: 0x752480 VA: 0x180753E80
	public bool IsTorsoItem(ItemDefinition itemDef) { }

	// RVA: 0x753E20 Offset: 0x752420 VA: 0x180753E20
	public bool IsLegsItem(ItemDefinition itemDef) { }

	// RVA: 0x753330 Offset: 0x751930 VA: 0x180753330
	public void Create() { }

	[BaseEntity.Menu] // RVA: 0xDFC70 Offset: 0xDF070 VA: 0x1800DFC70
	[BaseEntity.Menu.Description] // RVA: 0xDFC70 Offset: 0xDF070 VA: 0x1800DFC70
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFC70 Offset: 0xDF070 VA: 0x1800DFC70
	[BaseEntity.Menu.Icon] // RVA: 0xDFC70 Offset: 0xDF070 VA: 0x1800DFC70
	// RVA: 0x754190 Offset: 0x752790 VA: 0x180754190
	public void MenuWakeFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool CanWake(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDFF00 Offset: 0xDF300 VA: 0x1800DFF00
	[BaseEntity.Menu.Description] // RVA: 0xDFF00 Offset: 0xDF300 VA: 0x1800DFF00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFF00 Offset: 0xDF300 VA: 0x1800DFF00
	[BaseEntity.Menu.Icon] // RVA: 0xDFF00 Offset: 0xDF300 VA: 0x1800DFF00
	// RVA: 0x754150 Offset: 0x752750 VA: 0x180754150
	public void MenuSleepFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool CanSleep(BasePlayer player) { }

	// RVA: 0x753DA0 Offset: 0x7523A0 VA: 0x180753DA0
	public bool HasValidItems(ItemContainer container) { }

	// RVA: 0x753870 Offset: 0x751E70 VA: 0x180753870
	public List<ItemDefinition> GetValidItems(ItemContainer container) { }

	// RVA: 0x753AC0 Offset: 0x7520C0 VA: 0x180753AC0
	public bool HasAllValidItems(List<ItemDefinition> items) { }

	// RVA: 0x753290 Offset: 0x751890 VA: 0x180753290
	private void CheckItem(ItemDefinition item, List<ItemDefinition> itemList, List<ItemDefinition> validItems, ref bool set) { }

	// RVA: 0x753EE0 Offset: 0x7524E0 VA: 0x180753EE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x753210 Offset: 0x751810 VA: 0x180753210
	public void CL_WakeFrankenstein(BaseEntity.RPCMessage msg) { }

	// RVA: 0x754670 Offset: 0x752C70 VA: 0x180754670
	public void RefreshVisuals() { }

	// RVA: 0x754720 Offset: 0x752D20 VA: 0x180754720
	public void .ctor() { }

}

