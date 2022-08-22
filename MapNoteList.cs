public class MapNoteList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MapNote> notes; // 0x18

	// Methods

	// RVA: 0x1F409D0 Offset: 0x1F3EFD0 VA: 0x181F409D0
	public static void ResetToPool(MapNoteList instance) { }

	// RVA: 0x1F40B80 Offset: 0x1F3F180 VA: 0x181F40B80
	public void ResetToPool() { }

	// RVA: 0x1F40750 Offset: 0x1F3ED50 VA: 0x181F40750 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3F8C0 Offset: 0x1F3DEC0 VA: 0x181F3F8C0
	public void CopyTo(MapNoteList instance) { }

	// RVA: 0x1F3FA50 Offset: 0x1F3E050 VA: 0x181F3FA50
	public MapNoteList Copy() { }

	// RVA: 0x1F406D0 Offset: 0x1F3ECD0 VA: 0x181F406D0
	public static MapNoteList Deserialize(Stream stream) { }

	// RVA: 0x1F3FC40 Offset: 0x1F3E240 VA: 0x181F3FC40
	public static MapNoteList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3FF90 Offset: 0x1F3E590 VA: 0x181F3FF90
	public static MapNoteList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F402C0 Offset: 0x1F3E8C0 VA: 0x181F402C0
	public static MapNoteList Deserialize(byte[] buffer) { }

	// RVA: 0x1F40990 Offset: 0x1F3EF90 VA: 0x181F40990
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F412C0 Offset: 0x1F3F8C0 VA: 0x181F412C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F412E0 Offset: 0x1F3F8E0 VA: 0x181F412E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNoteList previous) { }

	// RVA: 0x1F409B0 Offset: 0x1F3EFB0 VA: 0x181F409B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F405D0 Offset: 0x1F3EBD0 VA: 0x181F405D0
	public static MapNoteList Deserialize(byte[] buffer, MapNoteList instance, bool isDelta = False) { }

	// RVA: 0x1F403E0 Offset: 0x1F3E9E0 VA: 0x181F403E0
	public static MapNoteList Deserialize(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F3FCC0 Offset: 0x1F3E2C0 VA: 0x181F3FCC0
	public static MapNoteList DeserializeLengthDelimited(Stream stream, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F40020 Offset: 0x1F3E620 VA: 0x181F40020
	public static MapNoteList DeserializeLength(Stream stream, int length, MapNoteList instance, bool isDelta) { }

	// RVA: 0x1F40D30 Offset: 0x1F3F330 VA: 0x181F40D30
	public static void SerializeDelta(Stream stream, MapNoteList instance, MapNoteList previous) { }

	// RVA: 0x1F410D0 Offset: 0x1F3F6D0 VA: 0x181F410D0
	public static void Serialize(Stream stream, MapNoteList instance) { }

	// RVA: 0x1F412B0 Offset: 0x1F3F8B0 VA: 0x181F412B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F412C0 Offset: 0x1F3F8C0 VA: 0x181F412C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F40FC0 Offset: 0x1F3F5C0 VA: 0x181F40FC0
	public static byte[] SerializeToBytes(MapNoteList instance) { }

	// RVA: 0x1F40F10 Offset: 0x1F3F510 VA: 0x181F40F10
	public static void SerializeLengthDelimited(Stream stream, MapNoteList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

