public class WorldItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6304
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1E57BD0 Offset: 0x1E561D0 VA: 0x181E57BD0
	public static void ResetToPool(WorldItem instance) { }

	// RVA: 0x1E57C70 Offset: 0x1E56270 VA: 0x181E57C70
	public void ResetToPool() { }

	// RVA: 0x1E57A70 Offset: 0x1E56070 VA: 0x181E57A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E56FD0 Offset: 0x1E555D0 VA: 0x181E56FD0
	public void CopyTo(WorldItem instance) { }

	// RVA: 0x1E57040 Offset: 0x1E55640 VA: 0x181E57040
	public WorldItem Copy() { }

	// RVA: 0x1E57670 Offset: 0x1E55C70 VA: 0x181E57670
	public static WorldItem Deserialize(Stream stream) { }

	// RVA: 0x1E57110 Offset: 0x1E55710 VA: 0x181E57110
	public static WorldItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E573D0 Offset: 0x1E559D0 VA: 0x181E573D0
	public static WorldItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E57950 Offset: 0x1E55F50 VA: 0x181E57950
	public static WorldItem Deserialize(byte[] buffer) { }

	// RVA: 0x1E57B90 Offset: 0x1E56190 VA: 0x181E57B90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E582F0 Offset: 0x1E568F0 VA: 0x181E582F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E58310 Offset: 0x1E56910 VA: 0x181E58310 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldItem previous) { }

	// RVA: 0x1E57BB0 Offset: 0x1E561B0 VA: 0x181E57BB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E57850 Offset: 0x1E55E50 VA: 0x181E57850
	public static WorldItem Deserialize(byte[] buffer, WorldItem instance, bool isDelta = False) { }

	// RVA: 0x1E576F0 Offset: 0x1E55CF0 VA: 0x181E576F0
	public static WorldItem Deserialize(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57190 Offset: 0x1E55790 VA: 0x181E57190
	public static WorldItem DeserializeLengthDelimited(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57460 Offset: 0x1E55A60 VA: 0x181E57460
	public static WorldItem DeserializeLength(Stream stream, int length, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57D10 Offset: 0x1E56310 VA: 0x181E57D10
	public static void SerializeDelta(Stream stream, WorldItem instance, WorldItem previous) { }

	// RVA: 0x1E58100 Offset: 0x1E56700 VA: 0x181E58100
	public static void Serialize(Stream stream, WorldItem instance) { }

	// RVA: 0x1E582E0 Offset: 0x1E568E0 VA: 0x181E582E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E582F0 Offset: 0x1E568F0 VA: 0x181E582F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E57FF0 Offset: 0x1E565F0 VA: 0x181E57FF0
	public static byte[] SerializeToBytes(WorldItem instance) { }

	// RVA: 0x1E57F00 Offset: 0x1E56500 VA: 0x181E57F00
	public static void SerializeLengthDelimited(Stream stream, WorldItem instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class WorldItem : BaseEntity // TypeDefIndex: 8667
{	// Fields
	[HeaderAttribute] // RVA: 0xB8F30 Offset: 0xB8330 VA: 0x1800B8F30
	public bool allowPickup; // 0x168
	public Item item; // 0x170

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x900890 Offset: 0x8FEE90 VA: 0x180900890 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8FFEB0 Offset: 0x8FE4B0 VA: 0x1808FFEB0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x901480 Offset: 0x8FFA80 VA: 0x180901480
	public void UpdateItem(BaseEntity.RPCMessage packet) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x901170 Offset: 0x8FF770 VA: 0x180901170
	public void PickupSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x900390 Offset: 0x8FE990 VA: 0x180900390 Slot: 131
	public virtual Vector3 IdealMenuPosition(BasePlayer playerUser) { }

	// RVA: 0x900020 Offset: 0x8FE620 VA: 0x180900020 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x900210 Offset: 0x8FE810 VA: 0x180900210 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x8FFFF0 Offset: 0x8FE5F0 VA: 0x1808FFFF0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x900010 Offset: 0x8FE610 VA: 0x180900010 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x900540 Offset: 0x8FEB40 VA: 0x180900540
	public void InitializeItem(Item in_item) { }

	// RVA: 0x901270 Offset: 0x8FF870 VA: 0x180901270
	public void RemoveItem() { }

	// RVA: 0x8FFF20 Offset: 0x8FE520 VA: 0x1808FFF20
	public void DestroyItem() { }

	// RVA: 0x9007E0 Offset: 0x8FEDE0 VA: 0x1809007E0 Slot: 132
	protected virtual void OnItemDirty(Item in_item) { }

	// RVA: 0x900660 Offset: 0x8FEC60 VA: 0x180900660 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9015B0 Offset: 0x8FFBB0 VA: 0x1809015B0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x901320 Offset: 0x8FF920 VA: 0x180901320 Slot: 3
	public override string ToString() { }

	// RVA: 0x901550 Offset: 0x8FFB50 VA: 0x180901550
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x901440 Offset: 0x8FFA40 VA: 0x180901440
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

