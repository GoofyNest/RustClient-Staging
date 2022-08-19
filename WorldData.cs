public class WorldData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6507
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint size; // 0x14
	public List<MapData> maps; // 0x18
	public List<PrefabData> prefabs; // 0x20
	public List<PathData> paths; // 0x28

	// Methods

	// RVA: 0x1E559D0 Offset: 0x1E53FD0 VA: 0x181E559D0
	public static void ResetToPool(WorldData instance) { }

	// RVA: 0x1E55E00 Offset: 0x1E54400 VA: 0x181E55E00
	public void ResetToPool() { }

	// RVA: 0x1E55910 Offset: 0x1E53F10 VA: 0x181E55910 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E547A0 Offset: 0x1E52DA0 VA: 0x181E547A0
	public void CopyTo(WorldData instance) { }

	// RVA: 0x1E54AA0 Offset: 0x1E530A0 VA: 0x181E54AA0
	public WorldData Copy() { }

	// RVA: 0x1E55770 Offset: 0x1E53D70 VA: 0x181E55770
	public static WorldData Deserialize(Stream stream) { }

	// RVA: 0x1E54EE0 Offset: 0x1E534E0 VA: 0x181E54EE0
	public static WorldData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E54F60 Offset: 0x1E53560 VA: 0x181E54F60
	public static WorldData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E557F0 Offset: 0x1E53DF0 VA: 0x181E557F0
	public static WorldData Deserialize(byte[] buffer) { }

	// RVA: 0x1E55990 Offset: 0x1E53F90 VA: 0x181E55990
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E56F90 Offset: 0x1E55590 VA: 0x181E56F90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E56FB0 Offset: 0x1E555B0 VA: 0x181E56FB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldData previous) { }

	// RVA: 0x1E559B0 Offset: 0x1E53FB0 VA: 0x181E559B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E55670 Offset: 0x1E53C70 VA: 0x181E55670
	public static WorldData Deserialize(byte[] buffer, WorldData instance, bool isDelta = False) { }

	// RVA: 0x1E55390 Offset: 0x1E53990 VA: 0x181E55390
	public static WorldData Deserialize(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E54B20 Offset: 0x1E53120 VA: 0x181E54B20
	public static WorldData DeserializeLengthDelimited(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E54FF0 Offset: 0x1E535F0 VA: 0x181E54FF0
	public static WorldData DeserializeLength(Stream stream, int length, WorldData instance, bool isDelta) { }

	// RVA: 0x1E56230 Offset: 0x1E54830 VA: 0x181E56230
	public static void SerializeDelta(Stream stream, WorldData instance, WorldData previous) { }

	// RVA: 0x1E569F0 Offset: 0x1E54FF0 VA: 0x181E569F0
	public static void Serialize(Stream stream, WorldData instance) { }

	// RVA: 0x1E56F80 Offset: 0x1E55580 VA: 0x181E56F80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E56F90 Offset: 0x1E55590 VA: 0x181E56F90
	public void ToProto(Stream stream) { }

	// RVA: 0x1E568E0 Offset: 0x1E54EE0 VA: 0x181E568E0
	public static byte[] SerializeToBytes(WorldData instance) { }

	// RVA: 0x1E567F0 Offset: 0x1E54DF0 VA: 0x181E567F0
	public static void SerializeLengthDelimited(Stream stream, WorldData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

