public class WorldMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6498
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public WorldMessage.MessageType status; // 0x14
	public List<PrefabData> prefabs; // 0x18
	public List<PathData> paths; // 0x20

	// Methods

	// RVA: 0x1E597F0 Offset: 0x1E57DF0 VA: 0x181E597F0
	public static void ResetToPool(WorldMessage instance) { }

	// RVA: 0x1E59B00 Offset: 0x1E58100 VA: 0x181E59B00
	public void ResetToPool() { }

	// RVA: 0x1E59730 Offset: 0x1E57D30 VA: 0x181E59730 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E58430 Offset: 0x1E56A30 VA: 0x181E58430
	public void CopyTo(WorldMessage instance) { }

	// RVA: 0x1E58650 Offset: 0x1E56C50 VA: 0x181E58650
	public WorldMessage Copy() { }

	// RVA: 0x1E594B0 Offset: 0x1E57AB0 VA: 0x181E594B0
	public static WorldMessage Deserialize(Stream stream) { }

	// RVA: 0x1E586D0 Offset: 0x1E56CD0 VA: 0x181E586D0
	public static WorldMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E58A80 Offset: 0x1E57080 VA: 0x181E58A80
	public static WorldMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E59180 Offset: 0x1E57780 VA: 0x181E59180
	public static WorldMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E597B0 Offset: 0x1E57DB0 VA: 0x181E597B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5A890 Offset: 0x1E58E90 VA: 0x181E5A890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5A8B0 Offset: 0x1E58EB0 VA: 0x181E5A8B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldMessage previous) { }

	// RVA: 0x1E597D0 Offset: 0x1E57DD0 VA: 0x181E597D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E59080 Offset: 0x1E57680 VA: 0x181E59080
	public static WorldMessage Deserialize(byte[] buffer, WorldMessage instance, bool isDelta = False) { }

	// RVA: 0x1E58E30 Offset: 0x1E57430 VA: 0x181E58E30
	public static WorldMessage Deserialize(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58750 Offset: 0x1E56D50 VA: 0x181E58750
	public static WorldMessage DeserializeLengthDelimited(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58B10 Offset: 0x1E57110 VA: 0x181E58B10
	public static WorldMessage DeserializeLength(Stream stream, int length, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E59E10 Offset: 0x1E58410 VA: 0x181E59E10
	public static void SerializeDelta(Stream stream, WorldMessage instance, WorldMessage previous) { }

	// RVA: 0x1E5A450 Offset: 0x1E58A50 VA: 0x181E5A450
	public static void Serialize(Stream stream, WorldMessage instance) { }

	// RVA: 0x1E5A880 Offset: 0x1E58E80 VA: 0x181E5A880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5A890 Offset: 0x1E58E90 VA: 0x181E5A890
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5A340 Offset: 0x1E58940 VA: 0x181E5A340
	public static byte[] SerializeToBytes(WorldMessage instance) { }

	// RVA: 0x1E5A250 Offset: 0x1E58850 VA: 0x181E5A250
	public static void SerializeLengthDelimited(Stream stream, WorldMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public enum WorldMessage.MessageType // TypeDefIndex: 6499
{	// Fields
	public int value__; // 0x0
	public const WorldMessage.MessageType Request = 1;
	public const WorldMessage.MessageType Receive = 2;
	public const WorldMessage.MessageType Done = 3;

}

