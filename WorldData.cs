public class WorldData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6507
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint size; // 0x14
	public List<MapData> maps; // 0x18
	public List<PrefabData> prefabs; // 0x20
	public List<PathData> paths; // 0x28

	// Methods

	// RVA: 0x1E55810 Offset: 0x1E53E10 VA: 0x181E55810
	public static void ResetToPool(WorldData instance) { }

	// RVA: 0x1E55C40 Offset: 0x1E54240 VA: 0x181E55C40
	public void ResetToPool() { }

	// RVA: 0x1E55750 Offset: 0x1E53D50 VA: 0x181E55750 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E545E0 Offset: 0x1E52BE0 VA: 0x181E545E0
	public void CopyTo(WorldData instance) { }

	// RVA: 0x1E548E0 Offset: 0x1E52EE0 VA: 0x181E548E0
	public WorldData Copy() { }

	// RVA: 0x1E555B0 Offset: 0x1E53BB0 VA: 0x181E555B0
	public static WorldData Deserialize(Stream stream) { }

	// RVA: 0x1E54D20 Offset: 0x1E53320 VA: 0x181E54D20
	public static WorldData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E54DA0 Offset: 0x1E533A0 VA: 0x181E54DA0
	public static WorldData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E55630 Offset: 0x1E53C30 VA: 0x181E55630
	public static WorldData Deserialize(byte[] buffer) { }

	// RVA: 0x1E557D0 Offset: 0x1E53DD0 VA: 0x181E557D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E56DD0 Offset: 0x1E553D0 VA: 0x181E56DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E56DF0 Offset: 0x1E553F0 VA: 0x181E56DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldData previous) { }

	// RVA: 0x1E557F0 Offset: 0x1E53DF0 VA: 0x181E557F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E554B0 Offset: 0x1E53AB0 VA: 0x181E554B0
	public static WorldData Deserialize(byte[] buffer, WorldData instance, bool isDelta = False) { }

	// RVA: 0x1E551D0 Offset: 0x1E537D0 VA: 0x181E551D0
	public static WorldData Deserialize(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E54960 Offset: 0x1E52F60 VA: 0x181E54960
	public static WorldData DeserializeLengthDelimited(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E54E30 Offset: 0x1E53430 VA: 0x181E54E30
	public static WorldData DeserializeLength(Stream stream, int length, WorldData instance, bool isDelta) { }

	// RVA: 0x1E56070 Offset: 0x1E54670 VA: 0x181E56070
	public static void SerializeDelta(Stream stream, WorldData instance, WorldData previous) { }

	// RVA: 0x1E56830 Offset: 0x1E54E30 VA: 0x181E56830
	public static void Serialize(Stream stream, WorldData instance) { }

	// RVA: 0x1E56DC0 Offset: 0x1E553C0 VA: 0x181E56DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E56DD0 Offset: 0x1E553D0 VA: 0x181E56DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E56720 Offset: 0x1E54D20 VA: 0x181E56720
	public static byte[] SerializeToBytes(WorldData instance) { }

	// RVA: 0x1E56630 Offset: 0x1E54C30 VA: 0x181E56630
	public static void SerializeLengthDelimited(Stream stream, WorldData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

