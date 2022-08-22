public class FrankensteinTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemIds; // 0x18

	// Methods

	// RVA: 0x1D5B210 Offset: 0x1D59810 VA: 0x181D5B210
	public static void ResetToPool(FrankensteinTable instance) { }

	// RVA: 0x1D5B2F0 Offset: 0x1D598F0 VA: 0x181D5B2F0
	public void ResetToPool() { }

	// RVA: 0x1D5B080 Offset: 0x1D59680 VA: 0x181D5B080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5A390 Offset: 0x1D58990 VA: 0x181D5A390
	public void CopyTo(FrankensteinTable instance) { }

	// RVA: 0x1D5A4B0 Offset: 0x1D58AB0 VA: 0x181D5A4B0
	public FrankensteinTable Copy() { }

	// RVA: 0x1D5AE40 Offset: 0x1D59440 VA: 0x181D5AE40
	public static FrankensteinTable Deserialize(Stream stream) { }

	// RVA: 0x1D5A8A0 Offset: 0x1D58EA0 VA: 0x181D5A8A0
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5AB90 Offset: 0x1D59190 VA: 0x181D5AB90
	public static FrankensteinTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5AC20 Offset: 0x1D59220 VA: 0x181D5AC20
	public static FrankensteinTable Deserialize(byte[] buffer) { }

	// RVA: 0x1D5B1D0 Offset: 0x1D597D0 VA: 0x181D5B1D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5B840 Offset: 0x1D59E40 VA: 0x181D5B840 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5B860 Offset: 0x1D59E60 VA: 0x181D5B860 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FrankensteinTable previous) { }

	// RVA: 0x1D5B1F0 Offset: 0x1D597F0 VA: 0x181D5B1F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5AD40 Offset: 0x1D59340 VA: 0x181D5AD40
	public static FrankensteinTable Deserialize(byte[] buffer, FrankensteinTable instance, bool isDelta = False) { }

	// RVA: 0x1D5AEC0 Offset: 0x1D594C0 VA: 0x181D5AEC0
	public static FrankensteinTable Deserialize(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5A610 Offset: 0x1D58C10 VA: 0x181D5A610
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5A920 Offset: 0x1D58F20 VA: 0x181D5A920
	public static FrankensteinTable DeserializeLength(Stream stream, int length, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D5B3D0 Offset: 0x1D599D0 VA: 0x181D5B3D0
	public static void SerializeDelta(Stream stream, FrankensteinTable instance, FrankensteinTable previous) { }

	// RVA: 0x1D5B6E0 Offset: 0x1D59CE0 VA: 0x181D5B6E0
	public static void Serialize(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x1D5B830 Offset: 0x1D59E30 VA: 0x181D5B830
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5B840 Offset: 0x1D59E40 VA: 0x181D5B840
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5B5D0 Offset: 0x1D59BD0 VA: 0x181D5B5D0
	public static byte[] SerializeToBytes(FrankensteinTable instance) { }

	// RVA: 0x1D5B520 Offset: 0x1D59B20 VA: 0x181D5B520
	public static void SerializeLengthDelimited(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x753480 Offset: 0x751A80 VA: 0x180753480 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x754890 Offset: 0x752E90 VA: 0x180754890 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7542E0 Offset: 0x7528E0 VA: 0x1807542E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x753ED0 Offset: 0x7524D0 VA: 0x180753ED0
	public bool IsHeadItem(ItemDefinition itemDef) { }

	// RVA: 0x753F90 Offset: 0x752590 VA: 0x180753F90
	public bool IsTorsoItem(ItemDefinition itemDef) { }

	// RVA: 0x753F30 Offset: 0x752530 VA: 0x180753F30
	public bool IsLegsItem(ItemDefinition itemDef) { }

	// RVA: 0x753440 Offset: 0x751A40 VA: 0x180753440
	public void Create() { }

	[BaseEntity.Menu] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	[BaseEntity.Menu.Description] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	[BaseEntity.Menu.Icon] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	// RVA: 0x7542A0 Offset: 0x7528A0 VA: 0x1807542A0
	public void MenuWakeFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool CanWake(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	[BaseEntity.Menu.Description] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	[BaseEntity.Menu.Icon] // RVA: 0xE0010 Offset: 0xDF410 VA: 0x1800E0010
	// RVA: 0x754260 Offset: 0x752860 VA: 0x180754260
	public void MenuSleepFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool CanSleep(BasePlayer player) { }

	// RVA: 0x753EB0 Offset: 0x7524B0 VA: 0x180753EB0
	public bool HasValidItems(ItemContainer container) { }

	// RVA: 0x753980 Offset: 0x751F80 VA: 0x180753980
	public List<ItemDefinition> GetValidItems(ItemContainer container) { }

	// RVA: 0x753BD0 Offset: 0x7521D0 VA: 0x180753BD0
	public bool HasAllValidItems(List<ItemDefinition> items) { }

	// RVA: 0x7533A0 Offset: 0x7519A0 VA: 0x1807533A0
	private void CheckItem(ItemDefinition item, List<ItemDefinition> itemList, List<ItemDefinition> validItems, ref bool set) { }

	// RVA: 0x753FF0 Offset: 0x7525F0 VA: 0x180753FF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x753320 Offset: 0x751920 VA: 0x180753320
	public void CL_WakeFrankenstein(BaseEntity.RPCMessage msg) { }

	// RVA: 0x754780 Offset: 0x752D80 VA: 0x180754780
	public void RefreshVisuals() { }

	// RVA: 0x754830 Offset: 0x752E30 VA: 0x180754830
	public void .ctor() { }

}

