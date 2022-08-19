public class WorldMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6498
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public WorldMessage.MessageType status; // 0x14
	public List<PrefabData> prefabs; // 0x18
	public List<PathData> paths; // 0x20

	// Methods

	// RVA: 0x1E596F0 Offset: 0x1E57CF0 VA: 0x181E596F0
	public static void ResetToPool(WorldMessage instance) { }

	// RVA: 0x1E59A00 Offset: 0x1E58000 VA: 0x181E59A00
	public void ResetToPool() { }

	// RVA: 0x1E59630 Offset: 0x1E57C30 VA: 0x181E59630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E58330 Offset: 0x1E56930 VA: 0x181E58330
	public void CopyTo(WorldMessage instance) { }

	// RVA: 0x1E58550 Offset: 0x1E56B50 VA: 0x181E58550
	public WorldMessage Copy() { }

	// RVA: 0x1E593B0 Offset: 0x1E579B0 VA: 0x181E593B0
	public static WorldMessage Deserialize(Stream stream) { }

	// RVA: 0x1E585D0 Offset: 0x1E56BD0 VA: 0x181E585D0
	public static WorldMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E58980 Offset: 0x1E56F80 VA: 0x181E58980
	public static WorldMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E59080 Offset: 0x1E57680 VA: 0x181E59080
	public static WorldMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E596B0 Offset: 0x1E57CB0 VA: 0x181E596B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5A790 Offset: 0x1E58D90 VA: 0x181E5A790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5A7B0 Offset: 0x1E58DB0 VA: 0x181E5A7B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldMessage previous) { }

	// RVA: 0x1E596D0 Offset: 0x1E57CD0 VA: 0x181E596D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E58F80 Offset: 0x1E57580 VA: 0x181E58F80
	public static WorldMessage Deserialize(byte[] buffer, WorldMessage instance, bool isDelta = False) { }

	// RVA: 0x1E58D30 Offset: 0x1E57330 VA: 0x181E58D30
	public static WorldMessage Deserialize(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58650 Offset: 0x1E56C50 VA: 0x181E58650
	public static WorldMessage DeserializeLengthDelimited(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58A10 Offset: 0x1E57010 VA: 0x181E58A10
	public static WorldMessage DeserializeLength(Stream stream, int length, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E59D10 Offset: 0x1E58310 VA: 0x181E59D10
	public static void SerializeDelta(Stream stream, WorldMessage instance, WorldMessage previous) { }

	// RVA: 0x1E5A350 Offset: 0x1E58950 VA: 0x181E5A350
	public static void Serialize(Stream stream, WorldMessage instance) { }

	// RVA: 0x1E5A780 Offset: 0x1E58D80 VA: 0x181E5A780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5A790 Offset: 0x1E58D90 VA: 0x181E5A790
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5A240 Offset: 0x1E58840 VA: 0x181E5A240
	public static byte[] SerializeToBytes(WorldMessage instance) { }

	// RVA: 0x1E5A150 Offset: 0x1E58750 VA: 0x181E5A150
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

