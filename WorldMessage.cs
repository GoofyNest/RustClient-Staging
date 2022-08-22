public class WorldMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6498
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public WorldMessage.MessageType status; // 0x14
	public List<PrefabData> prefabs; // 0x18
	public List<PathData> paths; // 0x20

	// Methods

	// RVA: 0x1E59530 Offset: 0x1E57B30 VA: 0x181E59530
	public static void ResetToPool(WorldMessage instance) { }

	// RVA: 0x1E59840 Offset: 0x1E57E40 VA: 0x181E59840
	public void ResetToPool() { }

	// RVA: 0x1E59470 Offset: 0x1E57A70 VA: 0x181E59470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E58170 Offset: 0x1E56770 VA: 0x181E58170
	public void CopyTo(WorldMessage instance) { }

	// RVA: 0x1E58390 Offset: 0x1E56990 VA: 0x181E58390
	public WorldMessage Copy() { }

	// RVA: 0x1E591F0 Offset: 0x1E577F0 VA: 0x181E591F0
	public static WorldMessage Deserialize(Stream stream) { }

	// RVA: 0x1E58410 Offset: 0x1E56A10 VA: 0x181E58410
	public static WorldMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E587C0 Offset: 0x1E56DC0 VA: 0x181E587C0
	public static WorldMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E58EC0 Offset: 0x1E574C0 VA: 0x181E58EC0
	public static WorldMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E594F0 Offset: 0x1E57AF0 VA: 0x181E594F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5A5D0 Offset: 0x1E58BD0 VA: 0x181E5A5D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5A5F0 Offset: 0x1E58BF0 VA: 0x181E5A5F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldMessage previous) { }

	// RVA: 0x1E59510 Offset: 0x1E57B10 VA: 0x181E59510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E58DC0 Offset: 0x1E573C0 VA: 0x181E58DC0
	public static WorldMessage Deserialize(byte[] buffer, WorldMessage instance, bool isDelta = False) { }

	// RVA: 0x1E58B70 Offset: 0x1E57170 VA: 0x181E58B70
	public static WorldMessage Deserialize(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58490 Offset: 0x1E56A90 VA: 0x181E58490
	public static WorldMessage DeserializeLengthDelimited(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58850 Offset: 0x1E56E50 VA: 0x181E58850
	public static WorldMessage DeserializeLength(Stream stream, int length, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E59B50 Offset: 0x1E58150 VA: 0x181E59B50
	public static void SerializeDelta(Stream stream, WorldMessage instance, WorldMessage previous) { }

	// RVA: 0x1E5A190 Offset: 0x1E58790 VA: 0x181E5A190
	public static void Serialize(Stream stream, WorldMessage instance) { }

	// RVA: 0x1E5A5C0 Offset: 0x1E58BC0 VA: 0x181E5A5C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5A5D0 Offset: 0x1E58BD0 VA: 0x181E5A5D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5A080 Offset: 0x1E58680 VA: 0x181E5A080
	public static byte[] SerializeToBytes(WorldMessage instance) { }

	// RVA: 0x1E59F90 Offset: 0x1E58590 VA: 0x181E59F90
	public static void SerializeLengthDelimited(Stream stream, WorldMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public enum WorldMessage.MessageType // TypeDefIndex: 6499
{	// Fields
	public int value__; // 0x0
	public const WorldMessage.MessageType Request = 1;
	public const WorldMessage.MessageType Receive = 2;
	public const WorldMessage.MessageType Done = 3;

}

