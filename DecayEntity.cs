public class DecayEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6335
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float decayTimer; // 0x14
	public uint buildingID; // 0x18
	public float upkeepTimer; // 0x1C

	// Methods

	// RVA: 0x20BB300 Offset: 0x20B9900 VA: 0x1820BB300
	public static void ResetToPool(DecayEntity instance) { }

	// RVA: 0x20BB390 Offset: 0x20B9990 VA: 0x1820BB390
	public void ResetToPool() { }

	// RVA: 0x20BB020 Offset: 0x20B9620 VA: 0x1820BB020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28F40 Offset: 0x1E27540 VA: 0x181E28F40
	public void CopyTo(DecayEntity instance) { }

	// RVA: 0x20BA0B0 Offset: 0x20B86B0 VA: 0x1820BA0B0
	public DecayEntity Copy() { }

	// RVA: 0x20BA9F0 Offset: 0x20B8FF0 VA: 0x1820BA9F0
	public static DecayEntity Deserialize(Stream stream) { }

	// RVA: 0x20BA3C0 Offset: 0x20B89C0 VA: 0x1820BA3C0
	public static DecayEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BA6B0 Offset: 0x20B8CB0 VA: 0x1820BA6B0
	public static DecayEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BA740 Offset: 0x20B8D40 VA: 0x1820BA740
	public static DecayEntity Deserialize(byte[] buffer) { }

	// RVA: 0x20BB130 Offset: 0x20B9730 VA: 0x1820BB130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BB900 Offset: 0x20B9F00 VA: 0x1820BB900 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BB920 Offset: 0x20B9F20 VA: 0x1820BB920 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DecayEntity previous) { }

	// RVA: 0x20BB2E0 Offset: 0x20B98E0 VA: 0x1820BB2E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BAD90 Offset: 0x20B9390 VA: 0x1820BAD90
	public static DecayEntity Deserialize(byte[] buffer, DecayEntity instance, bool isDelta = False) { }

	// RVA: 0x20BABE0 Offset: 0x20B91E0 VA: 0x1820BABE0
	public static DecayEntity Deserialize(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20BA130 Offset: 0x20B8730 VA: 0x1820BA130
	public static DecayEntity DeserializeLengthDelimited(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20BA440 Offset: 0x20B8A40 VA: 0x1820BA440
	public static DecayEntity DeserializeLength(Stream stream, int length, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20BB420 Offset: 0x20B9A20 VA: 0x1820BB420
	public static void SerializeDelta(Stream stream, DecayEntity instance, DecayEntity previous) { }

	// RVA: 0x20BB7C0 Offset: 0x20B9DC0 VA: 0x1820BB7C0
	public static void Serialize(Stream stream, DecayEntity instance) { }

	// RVA: 0x20BB8F0 Offset: 0x20B9EF0 VA: 0x1820BB8F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BB900 Offset: 0x20B9F00 VA: 0x1820BB900
	public void ToProto(Stream stream) { }

	// RVA: 0x20BB6B0 Offset: 0x20B9CB0 VA: 0x1820BB6B0
	public static byte[] SerializeToBytes(DecayEntity instance) { }

	// RVA: 0x20BB600 Offset: 0x20B9C00 VA: 0x1820BB600
	public static void SerializeLengthDelimited(Stream stream, DecayEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class DecayEntity : BaseCombatEntity // TypeDefIndex: 9529
{	// Fields
	public GameObjectRef debrisPrefab; // 0x240
	public uint buildingID; // 0x248
	private Upkeep upkeep; // 0x250

	// Methods

	// RVA: 0x840DF0 Offset: 0x83F3F0 VA: 0x180840DF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x840EF0 Offset: 0x83F4F0 VA: 0x180840EF0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x840640 Offset: 0x83EC40 VA: 0x180840640
	public void AttachToBuilding(uint id) { }

	// RVA: 0x840D60 Offset: 0x83F360 VA: 0x180840D60
	public BuildingManager.Building GetBuilding() { }

	// RVA: 0x840CC0 Offset: 0x83F2C0 VA: 0x180840CC0 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x840700 Offset: 0x83ED00 VA: 0x180840700
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts, float multiplier) { }

	// RVA: 0x840AC0 Offset: 0x83F0C0 VA: 0x180840AC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x840C40 Offset: 0x83F240 VA: 0x180840C40 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x840BB0 Offset: 0x83F1B0 VA: 0x180840BB0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

