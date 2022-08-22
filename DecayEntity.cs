public class DecayEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6335
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float decayTimer; // 0x14
	public uint buildingID; // 0x18
	public float upkeepTimer; // 0x1C

	// Methods

	// RVA: 0x20BAAE0 Offset: 0x20B90E0 VA: 0x1820BAAE0
	public static void ResetToPool(DecayEntity instance) { }

	// RVA: 0x20BAB70 Offset: 0x20B9170 VA: 0x1820BAB70
	public void ResetToPool() { }

	// RVA: 0x20BA800 Offset: 0x20B8E00 VA: 0x1820BA800 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28720 Offset: 0x1E26D20 VA: 0x181E28720
	public void CopyTo(DecayEntity instance) { }

	// RVA: 0x20B9890 Offset: 0x20B7E90 VA: 0x1820B9890
	public DecayEntity Copy() { }

	// RVA: 0x20BA1D0 Offset: 0x20B87D0 VA: 0x1820BA1D0
	public static DecayEntity Deserialize(Stream stream) { }

	// RVA: 0x20B9BA0 Offset: 0x20B81A0 VA: 0x1820B9BA0
	public static DecayEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B9E90 Offset: 0x20B8490 VA: 0x1820B9E90
	public static DecayEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B9F20 Offset: 0x20B8520 VA: 0x1820B9F20
	public static DecayEntity Deserialize(byte[] buffer) { }

	// RVA: 0x20BA910 Offset: 0x20B8F10 VA: 0x1820BA910
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BB0E0 Offset: 0x20B96E0 VA: 0x1820BB0E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BB100 Offset: 0x20B9700 VA: 0x1820BB100 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DecayEntity previous) { }

	// RVA: 0x20BAAC0 Offset: 0x20B90C0 VA: 0x1820BAAC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BA570 Offset: 0x20B8B70 VA: 0x1820BA570
	public static DecayEntity Deserialize(byte[] buffer, DecayEntity instance, bool isDelta = False) { }

	// RVA: 0x20BA3C0 Offset: 0x20B89C0 VA: 0x1820BA3C0
	public static DecayEntity Deserialize(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B9910 Offset: 0x20B7F10 VA: 0x1820B9910
	public static DecayEntity DeserializeLengthDelimited(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B9C20 Offset: 0x20B8220 VA: 0x1820B9C20
	public static DecayEntity DeserializeLength(Stream stream, int length, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20BAC00 Offset: 0x20B9200 VA: 0x1820BAC00
	public static void SerializeDelta(Stream stream, DecayEntity instance, DecayEntity previous) { }

	// RVA: 0x20BAFA0 Offset: 0x20B95A0 VA: 0x1820BAFA0
	public static void Serialize(Stream stream, DecayEntity instance) { }

	// RVA: 0x20BB0D0 Offset: 0x20B96D0 VA: 0x1820BB0D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BB0E0 Offset: 0x20B96E0 VA: 0x1820BB0E0
	public void ToProto(Stream stream) { }

	// RVA: 0x20BAE90 Offset: 0x20B9490 VA: 0x1820BAE90
	public static byte[] SerializeToBytes(DecayEntity instance) { }

	// RVA: 0x20BADE0 Offset: 0x20B93E0 VA: 0x1820BADE0
	public static void SerializeLengthDelimited(Stream stream, DecayEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class DecayEntity : BaseCombatEntity // TypeDefIndex: 9529
{	// Fields
	public GameObjectRef debrisPrefab; // 0x240
	public uint buildingID; // 0x248
	private Upkeep upkeep; // 0x250

	// Methods

	// RVA: 0x8408A0 Offset: 0x83EEA0 VA: 0x1808408A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8409A0 Offset: 0x83EFA0 VA: 0x1808409A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8400F0 Offset: 0x83E6F0 VA: 0x1808400F0
	public void AttachToBuilding(uint id) { }

	// RVA: 0x840810 Offset: 0x83EE10 VA: 0x180840810
	public BuildingManager.Building GetBuilding() { }

	// RVA: 0x840770 Offset: 0x83ED70 VA: 0x180840770 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x8401B0 Offset: 0x83E7B0 VA: 0x1808401B0
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts, float multiplier) { }

	// RVA: 0x840570 Offset: 0x83EB70 VA: 0x180840570 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x8406F0 Offset: 0x83ECF0 VA: 0x1808406F0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x840660 Offset: 0x83EC60 VA: 0x180840660 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

