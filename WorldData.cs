public class WorldData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6507
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint size; // 0x14
	public List<MapData> maps; // 0x18
	public List<PrefabData> prefabs; // 0x20
	public List<PathData> paths; // 0x28

	// Methods

	// RVA: 0x1E562F0 Offset: 0x1E548F0 VA: 0x181E562F0
	public static void ResetToPool(WorldData instance) { }

	// RVA: 0x1E56720 Offset: 0x1E54D20 VA: 0x181E56720
	public void ResetToPool() { }

	// RVA: 0x1E56230 Offset: 0x1E54830 VA: 0x181E56230 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E550C0 Offset: 0x1E536C0 VA: 0x181E550C0
	public void CopyTo(WorldData instance) { }

	// RVA: 0x1E553C0 Offset: 0x1E539C0 VA: 0x181E553C0
	public WorldData Copy() { }

	// RVA: 0x1E56090 Offset: 0x1E54690 VA: 0x181E56090
	public static WorldData Deserialize(Stream stream) { }

	// RVA: 0x1E55800 Offset: 0x1E53E00 VA: 0x181E55800
	public static WorldData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E55880 Offset: 0x1E53E80 VA: 0x181E55880
	public static WorldData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E56110 Offset: 0x1E54710 VA: 0x181E56110
	public static WorldData Deserialize(byte[] buffer) { }

	// RVA: 0x1E562B0 Offset: 0x1E548B0 VA: 0x181E562B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E578B0 Offset: 0x1E55EB0 VA: 0x181E578B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E578D0 Offset: 0x1E55ED0 VA: 0x181E578D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldData previous) { }

	// RVA: 0x1E562D0 Offset: 0x1E548D0 VA: 0x181E562D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E55F90 Offset: 0x1E54590 VA: 0x181E55F90
	public static WorldData Deserialize(byte[] buffer, WorldData instance, bool isDelta = False) { }

	// RVA: 0x1E55CB0 Offset: 0x1E542B0 VA: 0x181E55CB0
	public static WorldData Deserialize(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E55440 Offset: 0x1E53A40 VA: 0x181E55440
	public static WorldData DeserializeLengthDelimited(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E55910 Offset: 0x1E53F10 VA: 0x181E55910
	public static WorldData DeserializeLength(Stream stream, int length, WorldData instance, bool isDelta) { }

	// RVA: 0x1E56B50 Offset: 0x1E55150 VA: 0x181E56B50
	public static void SerializeDelta(Stream stream, WorldData instance, WorldData previous) { }

	// RVA: 0x1E57310 Offset: 0x1E55910 VA: 0x181E57310
	public static void Serialize(Stream stream, WorldData instance) { }

	// RVA: 0x1E578A0 Offset: 0x1E55EA0 VA: 0x181E578A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E578B0 Offset: 0x1E55EB0 VA: 0x181E578B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E57200 Offset: 0x1E55800 VA: 0x181E57200
	public static byte[] SerializeToBytes(WorldData instance) { }

	// RVA: 0x1E57110 Offset: 0x1E55710 VA: 0x181E57110
	public static void SerializeLengthDelimited(Stream stream, WorldData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

