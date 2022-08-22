public class WorldMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6498
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public WorldMessage.MessageType status; // 0x14
	public List<PrefabData> prefabs; // 0x18
	public List<PathData> paths; // 0x20

	// Methods

	// RVA: 0x1E5A010 Offset: 0x1E58610 VA: 0x181E5A010
	public static void ResetToPool(WorldMessage instance) { }

	// RVA: 0x1E5A320 Offset: 0x1E58920 VA: 0x181E5A320
	public void ResetToPool() { }

	// RVA: 0x1E59F50 Offset: 0x1E58550 VA: 0x181E59F50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E58C50 Offset: 0x1E57250 VA: 0x181E58C50
	public void CopyTo(WorldMessage instance) { }

	// RVA: 0x1E58E70 Offset: 0x1E57470 VA: 0x181E58E70
	public WorldMessage Copy() { }

	// RVA: 0x1E59CD0 Offset: 0x1E582D0 VA: 0x181E59CD0
	public static WorldMessage Deserialize(Stream stream) { }

	// RVA: 0x1E58EF0 Offset: 0x1E574F0 VA: 0x181E58EF0
	public static WorldMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E592A0 Offset: 0x1E578A0 VA: 0x181E592A0
	public static WorldMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E599A0 Offset: 0x1E57FA0 VA: 0x181E599A0
	public static WorldMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E59FD0 Offset: 0x1E585D0 VA: 0x181E59FD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5B0B0 Offset: 0x1E596B0 VA: 0x181E5B0B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5B0D0 Offset: 0x1E596D0 VA: 0x181E5B0D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldMessage previous) { }

	// RVA: 0x1E59FF0 Offset: 0x1E585F0 VA: 0x181E59FF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E598A0 Offset: 0x1E57EA0 VA: 0x181E598A0
	public static WorldMessage Deserialize(byte[] buffer, WorldMessage instance, bool isDelta = False) { }

	// RVA: 0x1E59650 Offset: 0x1E57C50 VA: 0x181E59650
	public static WorldMessage Deserialize(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E58F70 Offset: 0x1E57570 VA: 0x181E58F70
	public static WorldMessage DeserializeLengthDelimited(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E59330 Offset: 0x1E57930 VA: 0x181E59330
	public static WorldMessage DeserializeLength(Stream stream, int length, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E5A630 Offset: 0x1E58C30 VA: 0x181E5A630
	public static void SerializeDelta(Stream stream, WorldMessage instance, WorldMessage previous) { }

	// RVA: 0x1E5AC70 Offset: 0x1E59270 VA: 0x181E5AC70
	public static void Serialize(Stream stream, WorldMessage instance) { }

	// RVA: 0x1E5B0A0 Offset: 0x1E596A0 VA: 0x181E5B0A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5B0B0 Offset: 0x1E596B0 VA: 0x181E5B0B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5AB60 Offset: 0x1E59160 VA: 0x181E5AB60
	public static byte[] SerializeToBytes(WorldMessage instance) { }

	// RVA: 0x1E5AA70 Offset: 0x1E59070 VA: 0x181E5AA70
	public static void SerializeLengthDelimited(Stream stream, WorldMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public enum WorldMessage.MessageType // TypeDefIndex: 6499
{	// Fields
	public int value__; // 0x0
	public const WorldMessage.MessageType Request = 1;
	public const WorldMessage.MessageType Receive = 2;
	public const WorldMessage.MessageType Done = 3;

}

