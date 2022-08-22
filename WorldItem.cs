public class WorldItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6304
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1E584F0 Offset: 0x1E56AF0 VA: 0x181E584F0
	public static void ResetToPool(WorldItem instance) { }

	// RVA: 0x1E58590 Offset: 0x1E56B90 VA: 0x181E58590
	public void ResetToPool() { }

	// RVA: 0x1E58390 Offset: 0x1E56990 VA: 0x181E58390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E578F0 Offset: 0x1E55EF0 VA: 0x181E578F0
	public void CopyTo(WorldItem instance) { }

	// RVA: 0x1E57960 Offset: 0x1E55F60 VA: 0x181E57960
	public WorldItem Copy() { }

	// RVA: 0x1E57F90 Offset: 0x1E56590 VA: 0x181E57F90
	public static WorldItem Deserialize(Stream stream) { }

	// RVA: 0x1E57A30 Offset: 0x1E56030 VA: 0x181E57A30
	public static WorldItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E57CF0 Offset: 0x1E562F0 VA: 0x181E57CF0
	public static WorldItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E58270 Offset: 0x1E56870 VA: 0x181E58270
	public static WorldItem Deserialize(byte[] buffer) { }

	// RVA: 0x1E584B0 Offset: 0x1E56AB0 VA: 0x181E584B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E58C10 Offset: 0x1E57210 VA: 0x181E58C10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E58C30 Offset: 0x1E57230 VA: 0x181E58C30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldItem previous) { }

	// RVA: 0x1E584D0 Offset: 0x1E56AD0 VA: 0x181E584D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E58170 Offset: 0x1E56770 VA: 0x181E58170
	public static WorldItem Deserialize(byte[] buffer, WorldItem instance, bool isDelta = False) { }

	// RVA: 0x1E58010 Offset: 0x1E56610 VA: 0x181E58010
	public static WorldItem Deserialize(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57AB0 Offset: 0x1E560B0 VA: 0x181E57AB0
	public static WorldItem DeserializeLengthDelimited(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E57D80 Offset: 0x1E56380 VA: 0x181E57D80
	public static WorldItem DeserializeLength(Stream stream, int length, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E58630 Offset: 0x1E56C30 VA: 0x181E58630
	public static void SerializeDelta(Stream stream, WorldItem instance, WorldItem previous) { }

	// RVA: 0x1E58A20 Offset: 0x1E57020 VA: 0x181E58A20
	public static void Serialize(Stream stream, WorldItem instance) { }

	// RVA: 0x1E58C00 Offset: 0x1E57200 VA: 0x181E58C00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E58C10 Offset: 0x1E57210 VA: 0x181E58C10
	public void ToProto(Stream stream) { }

	// RVA: 0x1E58910 Offset: 0x1E56F10 VA: 0x181E58910
	public static byte[] SerializeToBytes(WorldItem instance) { }

	// RVA: 0x1E58820 Offset: 0x1E56E20 VA: 0x181E58820
	public static void SerializeLengthDelimited(Stream stream, WorldItem instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x900EB0 Offset: 0x8FF4B0 VA: 0x180900EB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9004D0 Offset: 0x8FEAD0 VA: 0x1809004D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x901AA0 Offset: 0x9000A0 VA: 0x180901AA0
	public void UpdateItem(BaseEntity.RPCMessage packet) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x901790 Offset: 0x8FFD90 VA: 0x180901790
	public void PickupSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9009B0 Offset: 0x8FEFB0 VA: 0x1809009B0 Slot: 131
	public virtual Vector3 IdealMenuPosition(BasePlayer playerUser) { }

	// RVA: 0x900640 Offset: 0x8FEC40 VA: 0x180900640 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x900830 Offset: 0x8FEE30 VA: 0x180900830 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x900610 Offset: 0x8FEC10 VA: 0x180900610 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x900630 Offset: 0x8FEC30 VA: 0x180900630 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x900B60 Offset: 0x8FF160 VA: 0x180900B60
	public void InitializeItem(Item in_item) { }

	// RVA: 0x901890 Offset: 0x8FFE90 VA: 0x180901890
	public void RemoveItem() { }

	// RVA: 0x900540 Offset: 0x8FEB40 VA: 0x180900540
	public void DestroyItem() { }

	// RVA: 0x900E00 Offset: 0x8FF400 VA: 0x180900E00 Slot: 132
	protected virtual void OnItemDirty(Item in_item) { }

	// RVA: 0x900C80 Offset: 0x8FF280 VA: 0x180900C80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x901BD0 Offset: 0x9001D0 VA: 0x180901BD0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x901940 Offset: 0x8FFF40 VA: 0x180901940 Slot: 3
	public override string ToString() { }

	// RVA: 0x901B70 Offset: 0x900170 VA: 0x180901B70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x901A60 Offset: 0x900060 VA: 0x180901A60
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

