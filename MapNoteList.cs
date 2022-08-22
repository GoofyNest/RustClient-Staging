public class MapNoteList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MapNote> notes; // 0x18

	// Methods

	// RVA: 0x1F401B0 Offset: 0x1F3E7B0 VA: 0x181F401B0
	public static void ResetToPool(MapNoteList instance) { }

	// RVA: 0x1F40360 Offset: 0x1F3E960 VA: 0x181F40360
	public void ResetToPool() { }

	// RVA: 0x1F3FF30 Offset: 0x1F3E530 VA: 0x181F3FF30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3F0A0 Offset: 0x1F3D6A0 VA: 0x181F3F0A0
	public void CopyTo(MapNoteList instance) { }

	// RVA: 0x1F3F230 Offset: 0x1F3D830 VA: 0x181F3F230
	public MapNoteList Copy() { }

	// RVA: 0x1F3FEB0 Offset: 0x1F3E4B0 VA: 0x181F3FEB0
	public static MapNoteList Deserialize(Stream stream) { }

	// RVA: 0x1F3F420 Offset: 0x1F3DA20 VA: 0x181F3F420
	public static MapNoteList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3F770 Offset: 0x1F3DD70 VA: 0x181F3F770
	public static MapNoteList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3FAA0 Offset: 0x1F3E0A0 VA: 0x181F3FAA0
	public static MapNoteList Deserialize(byte[] buffer) { }

	// RVA: 0x1F40170 Offset: 0x1F3E770 VA: 0x181F40170
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F40AA0 Offset: 0x1F3F0A0 VA: 0x181F40AA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F40AC0 Offset: 0x1F3F0C0 VA: 0x181F40AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNoteList previous) { }

	// RVA: 0x1F40190 Offset: 0x1F3E790 VA: 0x181F40190 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3FDB0 Offset: 0x1F3E3B0 VA: 0x181F3FDB0
	public static MapNoteList Deserialize(byte[] buffer, MapNoteList instance, bool isDelta = False) { }

	// RVA: 0x1F3FBC0 Offset: 0x1F3E1C0 VA: 0x181F3FBC0
	public static MapNoteList Deserialize(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3F4A0 Offset: 0x1F3DAA0 VA: 0x181F3F4A0
	public static MapNoteList DeserializeLengthDelimited(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3F800 Offset: 0x1F3DE00 VA: 0x181F3F800
	public static MapNoteList DeserializeLength(Stream stream, int length, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F40510 Offset: 0x1F3EB10 VA: 0x181F40510
	public static void SerializeDelta(Stream stream, MapNoteList instance, MapNoteList previous) { }

	// RVA: 0x1F408B0 Offset: 0x1F3EEB0 VA: 0x181F408B0
	public static void Serialize(Stream stream, MapNoteList instance) { }

	// RVA: 0x1F40A90 Offset: 0x1F3F090 VA: 0x181F40A90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F40AA0 Offset: 0x1F3F0A0 VA: 0x181F40AA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F407A0 Offset: 0x1F3EDA0 VA: 0x181F407A0
	public static byte[] SerializeToBytes(MapNoteList instance) { }

	// RVA: 0x1F406F0 Offset: 0x1F3ECF0 VA: 0x181F406F0
	public static void SerializeLengthDelimited(Stream stream, MapNoteList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

