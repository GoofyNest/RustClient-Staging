public class WorldData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6507
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint size; // 0x14
	public List<MapData> maps; // 0x18
	public List<PrefabData> prefabs; // 0x20
	public List<PathData> paths; // 0x28

	// Methods

	// RVA: 0x1E55AD0 Offset: 0x1E540D0 VA: 0x181E55AD0
	public static void ResetToPool(WorldData instance) { }

	// RVA: 0x1E55F00 Offset: 0x1E54500 VA: 0x181E55F00
	public void ResetToPool() { }

	// RVA: 0x1E55A10 Offset: 0x1E54010 VA: 0x181E55A10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E548A0 Offset: 0x1E52EA0 VA: 0x181E548A0
	public void CopyTo(WorldData instance) { }

	// RVA: 0x1E54BA0 Offset: 0x1E531A0 VA: 0x181E54BA0
	public WorldData Copy() { }

	// RVA: 0x1E55870 Offset: 0x1E53E70 VA: 0x181E55870
	public static WorldData Deserialize(Stream stream) { }

	// RVA: 0x1E54FE0 Offset: 0x1E535E0 VA: 0x181E54FE0
	public static WorldData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E55060 Offset: 0x1E53660 VA: 0x181E55060
	public static WorldData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E558F0 Offset: 0x1E53EF0 VA: 0x181E558F0
	public static WorldData Deserialize(byte[] buffer) { }

	// RVA: 0x1E55A90 Offset: 0x1E54090 VA: 0x181E55A90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E57090 Offset: 0x1E55690 VA: 0x181E57090 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E570B0 Offset: 0x1E556B0 VA: 0x181E570B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldData previous) { }

	// RVA: 0x1E55AB0 Offset: 0x1E540B0 VA: 0x181E55AB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E55770 Offset: 0x1E53D70 VA: 0x181E55770
	public static WorldData Deserialize(byte[] buffer, WorldData instance, bool isDelta = False) { }

	// RVA: 0x1E55490 Offset: 0x1E53A90 VA: 0x181E55490
	public static WorldData Deserialize(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E54C20 Offset: 0x1E53220 VA: 0x181E54C20
	public static WorldData DeserializeLengthDelimited(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E550F0 Offset: 0x1E536F0 VA: 0x181E550F0
	public static WorldData DeserializeLength(Stream stream, int length, WorldData instance, bool isDelta) { }

	// RVA: 0x1E56330 Offset: 0x1E54930 VA: 0x181E56330
	public static void SerializeDelta(Stream stream, WorldData instance, WorldData previous) { }

	// RVA: 0x1E56AF0 Offset: 0x1E550F0 VA: 0x181E56AF0
	public static void Serialize(Stream stream, WorldData instance) { }

	// RVA: 0x1E57080 Offset: 0x1E55680 VA: 0x181E57080
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E57090 Offset: 0x1E55690 VA: 0x181E57090
	public void ToProto(Stream stream) { }

	// RVA: 0x1E569E0 Offset: 0x1E54FE0 VA: 0x181E569E0
	public static byte[] SerializeToBytes(WorldData instance) { }

	// RVA: 0x1E568F0 Offset: 0x1E54EF0 VA: 0x181E568F0
	public static void SerializeLengthDelimited(Stream stream, WorldData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

