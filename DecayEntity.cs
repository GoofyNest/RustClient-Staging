public class DecayEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6335
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float decayTimer; // 0x14
	public uint buildingID; // 0x18
	public float upkeepTimer; // 0x1C

	// Methods

	// RVA: 0x20BA9E0 Offset: 0x20B8FE0 VA: 0x1820BA9E0
	public static void ResetToPool(DecayEntity instance) { }

	// RVA: 0x20BAA70 Offset: 0x20B9070 VA: 0x1820BAA70
	public void ResetToPool() { }

	// RVA: 0x20BA700 Offset: 0x20B8D00 VA: 0x1820BA700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28620 Offset: 0x1E26C20 VA: 0x181E28620
	public void CopyTo(DecayEntity instance) { }

	// RVA: 0x20B9790 Offset: 0x20B7D90 VA: 0x1820B9790
	public DecayEntity Copy() { }

	// RVA: 0x20BA0D0 Offset: 0x20B86D0 VA: 0x1820BA0D0
	public static DecayEntity Deserialize(Stream stream) { }

	// RVA: 0x20B9AA0 Offset: 0x20B80A0 VA: 0x1820B9AA0
	public static DecayEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B9D90 Offset: 0x20B8390 VA: 0x1820B9D90
	public static DecayEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B9E20 Offset: 0x20B8420 VA: 0x1820B9E20
	public static DecayEntity Deserialize(byte[] buffer) { }

	// RVA: 0x20BA810 Offset: 0x20B8E10 VA: 0x1820BA810
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BAFE0 Offset: 0x20B95E0 VA: 0x1820BAFE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BB000 Offset: 0x20B9600 VA: 0x1820BB000 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DecayEntity previous) { }

	// RVA: 0x20BA9C0 Offset: 0x20B8FC0 VA: 0x1820BA9C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BA470 Offset: 0x20B8A70 VA: 0x1820BA470
	public static DecayEntity Deserialize(byte[] buffer, DecayEntity instance, bool isDelta = False) { }

	// RVA: 0x20BA2C0 Offset: 0x20B88C0 VA: 0x1820BA2C0
	public static DecayEntity Deserialize(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B9810 Offset: 0x20B7E10 VA: 0x1820B9810
	public static DecayEntity DeserializeLengthDelimited(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B9B20 Offset: 0x20B8120 VA: 0x1820B9B20
	public static DecayEntity DeserializeLength(Stream stream, int length, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20BAB00 Offset: 0x20B9100 VA: 0x1820BAB00
	public static void SerializeDelta(Stream stream, DecayEntity instance, DecayEntity previous) { }

	// RVA: 0x20BAEA0 Offset: 0x20B94A0 VA: 0x1820BAEA0
	public static void Serialize(Stream stream, DecayEntity instance) { }

	// RVA: 0x20BAFD0 Offset: 0x20B95D0 VA: 0x1820BAFD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BAFE0 Offset: 0x20B95E0 VA: 0x1820BAFE0
	public void ToProto(Stream stream) { }

	// RVA: 0x20BAD90 Offset: 0x20B9390 VA: 0x1820BAD90
	public static byte[] SerializeToBytes(DecayEntity instance) { }

	// RVA: 0x20BACE0 Offset: 0x20B92E0 VA: 0x1820BACE0
	public static void SerializeLengthDelimited(Stream stream, DecayEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class DecayEntity : BaseCombatEntity // TypeDefIndex: 9529
{	// Fields
	public GameObjectRef debrisPrefab; // 0x240
	public uint buildingID; // 0x248
	private Upkeep upkeep; // 0x250

	// Methods

	// RVA: 0x840790 Offset: 0x83ED90 VA: 0x180840790 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x840890 Offset: 0x83EE90 VA: 0x180840890 Slot: 27
	public override void ResetState() { }

	// RVA: 0x83FFE0 Offset: 0x83E5E0 VA: 0x18083FFE0
	public void AttachToBuilding(uint id) { }

	// RVA: 0x840700 Offset: 0x83ED00 VA: 0x180840700
	public BuildingManager.Building GetBuilding() { }

	// RVA: 0x840660 Offset: 0x83EC60 VA: 0x180840660 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x8400A0 Offset: 0x83E6A0 VA: 0x1808400A0
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts, float multiplier) { }

	// RVA: 0x840460 Offset: 0x83EA60 VA: 0x180840460 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x8405E0 Offset: 0x83EBE0 VA: 0x1808405E0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x840550 Offset: 0x83EB50 VA: 0x180840550 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

