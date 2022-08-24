public class FrankensteinTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemIds; // 0x18


	public static void ResetToPool(FrankensteinTable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(FrankensteinTable instance) { }

	public FrankensteinTable Copy() { }

	public static FrankensteinTable Deserialize(Stream stream) { }

	public static FrankensteinTable DeserializeLengthDelimited(Stream stream) { }

	public static FrankensteinTable DeserializeLength(Stream stream, int length) { }

	public static FrankensteinTable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, FrankensteinTable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static FrankensteinTable Deserialize(byte[] buffer, FrankensteinTable instance, bool isDelta = False) { }

	public static FrankensteinTable Deserialize(Stream stream, FrankensteinTable instance, bool isDelta) { }

	public static FrankensteinTable DeserializeLengthDelimited(Stream stream, FrankensteinTable instance, bool isDelta) { }

	public static FrankensteinTable DeserializeLength(Stream stream, int length, FrankensteinTable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, FrankensteinTable instance, FrankensteinTable previous) { }

	public static void Serialize(Stream stream, FrankensteinTable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(FrankensteinTable instance) { }

	public static void SerializeLengthDelimited(Stream stream, FrankensteinTable instance) { }

	public void .ctor() { }

}

public class FrankensteinTable : StorageContainer // TypeDefIndex: 8392
{	private Option __menuOption_MenuSleepFrankenstein; // 0x3D0
	private Option __menuOption_MenuWakeFrankenstein; // 0x428
	public GameObjectRef FrankensteinPrefab; // 0x480
	public Transform SpawnLocation; // 0x488
	public ItemDefinition WeaponItem; // 0x490
	public List<ItemDefinition> HeadItems; // 0x498
	public List<ItemDefinition> TorsoItems; // 0x4A0
	public List<ItemDefinition> LegItems; // 0x4A8
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<ItemDefinition> ItemsToUse; // 0x4B0
	public FrankensteinTableVisuals TableVisuals; // 0x4B8
	[HeaderAttribute] // RVA: 0xDFD90 Offset: 0xDF190 VA: 0x1800DFD90
	public float TableDownDuration; // 0x4C0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsHeadItem(ItemDefinition itemDef) { }

	public bool IsTorsoItem(ItemDefinition itemDef) { }

	public bool IsLegsItem(ItemDefinition itemDef) { }

	public void Create() { }

	[BaseEntity.Menu] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	[BaseEntity.Menu.Description] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	[BaseEntity.Menu.Icon] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	public void MenuWakeFrankenstein(BasePlayer ply) { }

	public bool CanWake(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
	[BaseEntity.Menu.Description] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
	[BaseEntity.Menu.Icon] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
	public void MenuSleepFrankenstein(BasePlayer ply) { }

	public bool CanSleep(BasePlayer player) { }

	public bool HasValidItems(ItemContainer container) { }

	public List<ItemDefinition> GetValidItems(ItemContainer container) { }

	public bool HasAllValidItems(List<ItemDefinition> items) { }

	private void CheckItem(ItemDefinition item, List<ItemDefinition> itemList, List<ItemDefinition> validItems, ref bool set) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void CL_WakeFrankenstein(BaseEntity.RPCMessage msg) { }

	public void RefreshVisuals() { }

	public void .ctor() { }

}

