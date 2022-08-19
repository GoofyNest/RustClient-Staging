public class MapNoteList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MapNote> notes; // 0x18

	// Methods

	// RVA: 0x1F400B0 Offset: 0x1F3E6B0 VA: 0x181F400B0
	public static void ResetToPool(MapNoteList instance) { }

	// RVA: 0x1F40260 Offset: 0x1F3E860 VA: 0x181F40260
	public void ResetToPool() { }

	// RVA: 0x1F3FE30 Offset: 0x1F3E430 VA: 0x181F3FE30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3EFA0 Offset: 0x1F3D5A0 VA: 0x181F3EFA0
	public void CopyTo(MapNoteList instance) { }

	// RVA: 0x1F3F130 Offset: 0x1F3D730 VA: 0x181F3F130
	public MapNoteList Copy() { }

	// RVA: 0x1F3FDB0 Offset: 0x1F3E3B0 VA: 0x181F3FDB0
	public static MapNoteList Deserialize(Stream stream) { }

	// RVA: 0x1F3F320 Offset: 0x1F3D920 VA: 0x181F3F320
	public static MapNoteList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3F670 Offset: 0x1F3DC70 VA: 0x181F3F670
	public static MapNoteList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3F9A0 Offset: 0x1F3DFA0 VA: 0x181F3F9A0
	public static MapNoteList Deserialize(byte[] buffer) { }

	// RVA: 0x1F40070 Offset: 0x1F3E670 VA: 0x181F40070
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F409A0 Offset: 0x1F3EFA0 VA: 0x181F409A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F409C0 Offset: 0x1F3EFC0 VA: 0x181F409C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNoteList previous) { }

	// RVA: 0x1F40090 Offset: 0x1F3E690 VA: 0x181F40090 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3FCB0 Offset: 0x1F3E2B0 VA: 0x181F3FCB0
	public static MapNoteList Deserialize(byte[] buffer, MapNoteList instance, bool isDelta = False) { }

	// RVA: 0x1F3FAC0 Offset: 0x1F3E0C0 VA: 0x181F3FAC0
	public static MapNoteList Deserialize(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3F3A0 Offset: 0x1F3D9A0 VA: 0x181F3F3A0
	public static MapNoteList DeserializeLengthDelimited(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3F700 Offset: 0x1F3DD00 VA: 0x181F3F700
	public static MapNoteList DeserializeLength(Stream stream, int length, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F40410 Offset: 0x1F3EA10 VA: 0x181F40410
	public static void SerializeDelta(Stream stream, MapNoteList instance, MapNoteList previous) { }

	// RVA: 0x1F407B0 Offset: 0x1F3EDB0 VA: 0x181F407B0
	public static void Serialize(Stream stream, MapNoteList instance) { }

	// RVA: 0x1F40990 Offset: 0x1F3EF90 VA: 0x181F40990
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F409A0 Offset: 0x1F3EFA0 VA: 0x181F409A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F406A0 Offset: 0x1F3ECA0 VA: 0x181F406A0
	public static byte[] SerializeToBytes(MapNoteList instance) { }

	// RVA: 0x1F405F0 Offset: 0x1F3EBF0 VA: 0x181F405F0
	public static void SerializeLengthDelimited(Stream stream, MapNoteList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

