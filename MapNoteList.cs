public class MapNoteList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MapNote> notes; // 0x18

	// Methods

	// RVA: 0x1F3FEF0 Offset: 0x1F3E4F0 VA: 0x181F3FEF0
	public static void ResetToPool(MapNoteList instance) { }

	// RVA: 0x1F400A0 Offset: 0x1F3E6A0 VA: 0x181F400A0
	public void ResetToPool() { }

	// RVA: 0x1F3FC70 Offset: 0x1F3E270 VA: 0x181F3FC70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3EDE0 Offset: 0x1F3D3E0 VA: 0x181F3EDE0
	public void CopyTo(MapNoteList instance) { }

	// RVA: 0x1F3EF70 Offset: 0x1F3D570 VA: 0x181F3EF70
	public MapNoteList Copy() { }

	// RVA: 0x1F3FBF0 Offset: 0x1F3E1F0 VA: 0x181F3FBF0
	public static MapNoteList Deserialize(Stream stream) { }

	// RVA: 0x1F3F160 Offset: 0x1F3D760 VA: 0x181F3F160
	public static MapNoteList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3F4B0 Offset: 0x1F3DAB0 VA: 0x181F3F4B0
	public static MapNoteList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3F7E0 Offset: 0x1F3DDE0 VA: 0x181F3F7E0
	public static MapNoteList Deserialize(byte[] buffer) { }

	// RVA: 0x1F3FEB0 Offset: 0x1F3E4B0 VA: 0x181F3FEB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F407E0 Offset: 0x1F3EDE0 VA: 0x181F407E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F40800 Offset: 0x1F3EE00 VA: 0x181F40800 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNoteList previous) { }

	// RVA: 0x1F3FED0 Offset: 0x1F3E4D0 VA: 0x181F3FED0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3FAF0 Offset: 0x1F3E0F0 VA: 0x181F3FAF0
	public static MapNoteList Deserialize(byte[] buffer, MapNoteList instance, bool isDelta = False) { }

	// RVA: 0x1F3F900 Offset: 0x1F3DF00 VA: 0x181F3F900
	public static MapNoteList Deserialize(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3F1E0 Offset: 0x1F3D7E0 VA: 0x181F3F1E0
	public static MapNoteList DeserializeLengthDelimited(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3F540 Offset: 0x1F3DB40 VA: 0x181F3F540
	public static MapNoteList DeserializeLength(Stream stream, int length, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F40250 Offset: 0x1F3E850 VA: 0x181F40250
	public static void SerializeDelta(Stream stream, MapNoteList instance, MapNoteList previous) { }

	// RVA: 0x1F405F0 Offset: 0x1F3EBF0 VA: 0x181F405F0
	public static void Serialize(Stream stream, MapNoteList instance) { }

	// RVA: 0x1F407D0 Offset: 0x1F3EDD0 VA: 0x181F407D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F407E0 Offset: 0x1F3EDE0 VA: 0x181F407E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F404E0 Offset: 0x1F3EAE0 VA: 0x181F404E0
	public static byte[] SerializeToBytes(MapNoteList instance) { }

	// RVA: 0x1F40430 Offset: 0x1F3EA30 VA: 0x181F40430
	public static void SerializeLengthDelimited(Stream stream, MapNoteList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

