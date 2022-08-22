public class FrankensteinTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemIds; // 0x18

	// Methods

	// RVA: 0x1D5BA00 Offset: 0x1D5A000 VA: 0x181D5BA00
	public static void ResetToPool(FrankensteinTable instance) { }

	// RVA: 0x1D5BAE0 Offset: 0x1D5A0E0 VA: 0x181D5BAE0
	public void ResetToPool() { }

	// RVA: 0x1D5B870 Offset: 0x1D59E70 VA: 0x181D5B870 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5AB80 Offset: 0x1D59180 VA: 0x181D5AB80
	public void CopyTo(FrankensteinTable instance) { }

	// RVA: 0x1D5ACA0 Offset: 0x1D592A0 VA: 0x181D5ACA0
	public FrankensteinTable Copy() { }

	// RVA: 0x1D5B630 Offset: 0x1D59C30 VA: 0x181D5B630
	public static FrankensteinTable Deserialize(Stream stream) { }

	// RVA: 0x1D5B090 Offset: 0x1D59690 VA: 0x181D5B090
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5B380 Offset: 0x1D59980 VA: 0x181D5B380
	public static FrankensteinTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5B410 Offset: 0x1D59A10 VA: 0x181D5B410
	public static FrankensteinTable Deserialize(byte[] buffer) { }

	// RVA: 0x1D5B9C0 Offset: 0x1D59FC0 VA: 0x181D5B9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5C030 Offset: 0x1D5A630 VA: 0x181D5C030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5C050 Offset: 0x1D5A650 VA: 0x181D5C050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FrankensteinTable previous) { }

	// RVA: 0x1D5B9E0 Offset: 0x1D59FE0 VA: 0x181D5B9E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5B530 Offset: 0x1D59B30 VA: 0x181D5B530
	public static FrankensteinTable Deserialize(byte[] buffer, FrankensteinTable instance, bool isDelta = False) { }

	// RVA: 0x1D5B6B0 Offset: 0x1D59CB0 VA: 0x181D5B6B0
	public static FrankensteinTable Deserialize(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5AE00 Offset: 0x1D59400 VA: 0x181D5AE00
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5B110 Offset: 0x1D59710 VA: 0x181D5B110
	public static FrankensteinTable DeserializeLength(Stream stream, int length, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5BBC0 Offset: 0x1D5A1C0 VA: 0x181D5BBC0
	public static void SerializeDelta(Stream stream, FrankensteinTable instance, FrankensteinTable previous) { }

	// RVA: 0x1D5BED0 Offset: 0x1D5A4D0 VA: 0x181D5BED0
	public static void Serialize(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x1D5C020 Offset: 0x1D5A620 VA: 0x181D5C020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5C030 Offset: 0x1D5A630 VA: 0x181D5C030
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5BDC0 Offset: 0x1D5A3C0 VA: 0x181D5BDC0
	public static byte[] SerializeToBytes(FrankensteinTable instance) { }

	// RVA: 0x1D5BD10 Offset: 0x1D5A310 VA: 0x181D5BD10
	public static void SerializeLengthDelimited(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public List<ItemDefinition> ItemsToUse; // 0x4B0
	public FrankensteinTableVisuals TableVisuals; // 0x4B8
	[HeaderAttribute] // RVA: 0xDFC80 Offset: 0xDF080 VA: 0x1800DFC80
	public float TableDownDuration; // 0x4C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7533D0 Offset: 0x7519D0 VA: 0x1807533D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7547E0 Offset: 0x752DE0 VA: 0x1807547E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x754230 Offset: 0x752830 VA: 0x180754230 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x753E20 Offset: 0x752420 VA: 0x180753E20
	public bool IsHeadItem(ItemDefinition itemDef) { }

	// RVA: 0x753EE0 Offset: 0x7524E0 VA: 0x180753EE0
	public bool IsTorsoItem(ItemDefinition itemDef) { }

	// RVA: 0x753E80 Offset: 0x752480 VA: 0x180753E80
	public bool IsLegsItem(ItemDefinition itemDef) { }

	// RVA: 0x753390 Offset: 0x751990 VA: 0x180753390
	public void Create() { }

	[BaseEntity.Menu] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	[BaseEntity.Menu.Description] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	[BaseEntity.Menu.Icon] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	// RVA: 0x7541F0 Offset: 0x7527F0 VA: 0x1807541F0
	public void MenuWakeFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool CanWake(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	[BaseEntity.Menu.Description] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	[BaseEntity.Menu.Icon] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	// RVA: 0x7541B0 Offset: 0x7527B0 VA: 0x1807541B0
	public void MenuSleepFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool CanSleep(BasePlayer player) { }

	// RVA: 0x753E00 Offset: 0x752400 VA: 0x180753E00
	public bool HasValidItems(ItemContainer container) { }

	// RVA: 0x7538D0 Offset: 0x751ED0 VA: 0x1807538D0
	public List<ItemDefinition> GetValidItems(ItemContainer container) { }

	// RVA: 0x753B20 Offset: 0x752120 VA: 0x180753B20
	public bool HasAllValidItems(List<ItemDefinition> items) { }

	// RVA: 0x7532F0 Offset: 0x7518F0 VA: 0x1807532F0
	private void CheckItem(ItemDefinition item, List<ItemDefinition> itemList, List<ItemDefinition> validItems, ref bool set) { }

	// RVA: 0x753F40 Offset: 0x752540 VA: 0x180753F40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x753270 Offset: 0x751870 VA: 0x180753270
	public void CL_WakeFrankenstein(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7546D0 Offset: 0x752CD0 VA: 0x1807546D0
	public void RefreshVisuals() { }

	// RVA: 0x754780 Offset: 0x752D80 VA: 0x180754780
	public void .ctor() { }

}

