public class SubEntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> subEntityIds; // 0x18

	// Methods

	// RVA: 0x1DC25C0 Offset: 0x1DC0BC0 VA: 0x181DC25C0
	public static void ResetToPool(SubEntityList instance) { }

	// RVA: 0x1DC24E0 Offset: 0x1DC0AE0 VA: 0x181DC24E0
	public void ResetToPool() { }

	// RVA: 0x1DC2350 Offset: 0x1DC0950 VA: 0x181DC2350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC1660 Offset: 0x1DBFC60 VA: 0x181DC1660
	public void CopyTo(SubEntityList instance) { }

	// RVA: 0x1DC1780 Offset: 0x1DBFD80 VA: 0x181DC1780
	public SubEntityList Copy() { }

	// RVA: 0x1DC21B0 Offset: 0x1DC07B0 VA: 0x181DC21B0
	public static SubEntityList Deserialize(Stream stream) { }

	// RVA: 0x1DC18E0 Offset: 0x1DBFEE0 VA: 0x181DC18E0
	public static SubEntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC1E60 Offset: 0x1DC0460 VA: 0x181DC1E60
	public static SubEntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC2230 Offset: 0x1DC0830 VA: 0x181DC2230
	public static SubEntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1DC24A0 Offset: 0x1DC0AA0 VA: 0x181DC24A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC2AF0 Offset: 0x1DC10F0 VA: 0x181DC2AF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC2B10 Offset: 0x1DC1110 VA: 0x181DC2B10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SubEntityList previous) { }

	// RVA: 0x1DC24C0 Offset: 0x1DC0AC0 VA: 0x181DC24C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC1EF0 Offset: 0x1DC04F0 VA: 0x181DC1EF0
	public static SubEntityList Deserialize(byte[] buffer, SubEntityList instance, bool isDelta = False) { }

	// RVA: 0x1DC1FF0 Offset: 0x1DC05F0 VA: 0x181DC1FF0
	public static SubEntityList Deserialize(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC1960 Offset: 0x1DBFF60 VA: 0x181DC1960
	public static SubEntityList DeserializeLengthDelimited(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC1BF0 Offset: 0x1DC01F0 VA: 0x181DC1BF0
	public static SubEntityList DeserializeLength(Stream stream, int length, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC26A0 Offset: 0x1DC0CA0 VA: 0x181DC26A0
	public static void SerializeDelta(Stream stream, SubEntityList instance, SubEntityList previous) { }

	// RVA: 0x1DC29A0 Offset: 0x1DC0FA0 VA: 0x181DC29A0
	public static void Serialize(Stream stream, SubEntityList instance) { }

	// RVA: 0x1DC2AE0 Offset: 0x1DC10E0 VA: 0x181DC2AE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC2AF0 Offset: 0x1DC10F0 VA: 0x181DC2AF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC2890 Offset: 0x1DC0E90 VA: 0x181DC2890
	public static byte[] SerializeToBytes(SubEntityList instance) { }

	// RVA: 0x1DC27E0 Offset: 0x1DC0DE0 VA: 0x181DC27E0
	public static void SerializeLengthDelimited(Stream stream, SubEntityList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

