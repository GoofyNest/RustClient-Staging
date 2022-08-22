public class SubEntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> subEntityIds; // 0x18

	// Methods

	// RVA: 0x1DC2400 Offset: 0x1DC0A00 VA: 0x181DC2400
	public static void ResetToPool(SubEntityList instance) { }

	// RVA: 0x1DC2320 Offset: 0x1DC0920 VA: 0x181DC2320
	public void ResetToPool() { }

	// RVA: 0x1DC2190 Offset: 0x1DC0790 VA: 0x181DC2190 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC14A0 Offset: 0x1DBFAA0 VA: 0x181DC14A0
	public void CopyTo(SubEntityList instance) { }

	// RVA: 0x1DC15C0 Offset: 0x1DBFBC0 VA: 0x181DC15C0
	public SubEntityList Copy() { }

	// RVA: 0x1DC1FF0 Offset: 0x1DC05F0 VA: 0x181DC1FF0
	public static SubEntityList Deserialize(Stream stream) { }

	// RVA: 0x1DC1720 Offset: 0x1DBFD20 VA: 0x181DC1720
	public static SubEntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC1CA0 Offset: 0x1DC02A0 VA: 0x181DC1CA0
	public static SubEntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC2070 Offset: 0x1DC0670 VA: 0x181DC2070
	public static SubEntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1DC22E0 Offset: 0x1DC08E0 VA: 0x181DC22E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC2930 Offset: 0x1DC0F30 VA: 0x181DC2930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC2950 Offset: 0x1DC0F50 VA: 0x181DC2950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SubEntityList previous) { }

	// RVA: 0x1DC2300 Offset: 0x1DC0900 VA: 0x181DC2300 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC1D30 Offset: 0x1DC0330 VA: 0x181DC1D30
	public static SubEntityList Deserialize(byte[] buffer, SubEntityList instance, bool isDelta = False) { }

	// RVA: 0x1DC1E30 Offset: 0x1DC0430 VA: 0x181DC1E30
	public static SubEntityList Deserialize(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC17A0 Offset: 0x1DBFDA0 VA: 0x181DC17A0
	public static SubEntityList DeserializeLengthDelimited(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC1A30 Offset: 0x1DC0030 VA: 0x181DC1A30
	public static SubEntityList DeserializeLength(Stream stream, int length, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC24E0 Offset: 0x1DC0AE0 VA: 0x181DC24E0
	public static void SerializeDelta(Stream stream, SubEntityList instance, SubEntityList previous) { }

	// RVA: 0x1DC27E0 Offset: 0x1DC0DE0 VA: 0x181DC27E0
	public static void Serialize(Stream stream, SubEntityList instance) { }

	// RVA: 0x1DC2920 Offset: 0x1DC0F20 VA: 0x181DC2920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC2930 Offset: 0x1DC0F30 VA: 0x181DC2930
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC26D0 Offset: 0x1DC0CD0 VA: 0x181DC26D0
	public static byte[] SerializeToBytes(SubEntityList instance) { }

	// RVA: 0x1DC2620 Offset: 0x1DC0C20 VA: 0x181DC2620
	public static void SerializeLengthDelimited(Stream stream, SubEntityList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

