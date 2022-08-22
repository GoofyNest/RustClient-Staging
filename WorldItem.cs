public class WorldItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6304
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1E57CD0 Offset: 0x1E562D0 VA: 0x181E57CD0
	public static void ResetToPool(WorldItem instance) { }

	// RVA: 0x1E57D70 Offset: 0x1E56370 VA: 0x181E57D70
	public void ResetToPool() { }

	// RVA: 0x1E57B70 Offset: 0x1E56170 VA: 0x181E57B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E570D0 Offset: 0x1E556D0 VA: 0x181E570D0
	public void CopyTo(WorldItem instance) { }

	// RVA: 0x1E57140 Offset: 0x1E55740 VA: 0x181E57140
	public WorldItem Copy() { }

	// RVA: 0x1E57770 Offset: 0x1E55D70 VA: 0x181E57770
	public static WorldItem Deserialize(Stream stream) { }

	// RVA: 0x1E57210 Offset: 0x1E55810 VA: 0x181E57210
	public static WorldItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E574D0 Offset: 0x1E55AD0 VA: 0x181E574D0
	public static WorldItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E57A50 Offset: 0x1E56050 VA: 0x181E57A50
	public static WorldItem Deserialize(byte[] buffer) { }

	// RVA: 0x1E57C90 Offset: 0x1E56290 VA: 0x181E57C90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E583F0 Offset: 0x1E569F0 VA: 0x181E583F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E58410 Offset: 0x1E56A10 VA: 0x181E58410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldItem previous) { }

	// RVA: 0x1E57CB0 Offset: 0x1E562B0 VA: 0x181E57CB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E57950 Offset: 0x1E55F50 VA: 0x181E57950
	public static WorldItem Deserialize(byte[] buffer, WorldItem instance, bool isDelta = False) { }

	// RVA: 0x1E577F0 Offset: 0x1E55DF0 VA: 0x181E577F0
	public static WorldItem Deserialize(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57290 Offset: 0x1E55890 VA: 0x181E57290
	public static WorldItem DeserializeLengthDelimited(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57560 Offset: 0x1E55B60 VA: 0x181E57560
	public static WorldItem DeserializeLength(Stream stream, int length, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57E10 Offset: 0x1E56410 VA: 0x181E57E10
	public static void SerializeDelta(Stream stream, WorldItem instance, WorldItem previous) { }

	// RVA: 0x1E58200 Offset: 0x1E56800 VA: 0x181E58200
	public static void Serialize(Stream stream, WorldItem instance) { }

	// RVA: 0x1E583E0 Offset: 0x1E569E0 VA: 0x181E583E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E583F0 Offset: 0x1E569F0 VA: 0x181E583F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E580F0 Offset: 0x1E566F0 VA: 0x181E580F0
	public static byte[] SerializeToBytes(WorldItem instance) { }

	// RVA: 0x1E58000 Offset: 0x1E56600 VA: 0x181E58000
	public static void SerializeLengthDelimited(Stream stream, WorldItem instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class WorldItem : BaseEntity // TypeDefIndex: 8667
{	// Fields
	[HeaderAttribute] // RVA: 0xB8FD0 Offset: 0xB83D0 VA: 0x1800B8FD0
	public bool allowPickup; // 0x168
	public Item item; // 0x170

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x9009A0 Offset: 0x8FEFA0 VA: 0x1809009A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8FFFC0 Offset: 0x8FE5C0 VA: 0x1808FFFC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x901590 Offset: 0x8FFB90 VA: 0x180901590
	public void UpdateItem(BaseEntity.RPCMessage packet) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x901280 Offset: 0x8FF880 VA: 0x180901280
	public void PickupSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9004A0 Offset: 0x8FEAA0 VA: 0x1809004A0 Slot: 131
	public virtual Vector3 IdealMenuPosition(BasePlayer playerUser) { }

	// RVA: 0x900130 Offset: 0x8FE730 VA: 0x180900130 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x900320 Offset: 0x8FE920 VA: 0x180900320 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x900100 Offset: 0x8FE700 VA: 0x180900100 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x900120 Offset: 0x8FE720 VA: 0x180900120 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x900650 Offset: 0x8FEC50 VA: 0x180900650
	public void InitializeItem(Item in_item) { }

	// RVA: 0x901380 Offset: 0x8FF980 VA: 0x180901380
	public void RemoveItem() { }

	// RVA: 0x900030 Offset: 0x8FE630 VA: 0x180900030
	public void DestroyItem() { }

	// RVA: 0x9008F0 Offset: 0x8FEEF0 VA: 0x1809008F0 Slot: 132
	protected virtual void OnItemDirty(Item in_item) { }

	// RVA: 0x900770 Offset: 0x8FED70 VA: 0x180900770 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9016C0 Offset: 0x8FFCC0 VA: 0x1809016C0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x901430 Offset: 0x8FFA30 VA: 0x180901430 Slot: 3
	public override string ToString() { }

	// RVA: 0x901660 Offset: 0x8FFC60 VA: 0x180901660
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x901550 Offset: 0x8FFB50 VA: 0x180901550
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

