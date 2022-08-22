public class SubEntityList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6395
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> subEntityIds; // 0x18

	// Methods

	// RVA: 0x1DC2EB0 Offset: 0x1DC14B0 VA: 0x181DC2EB0
	public static void ResetToPool(SubEntityList instance) { }

	// RVA: 0x1DC2DD0 Offset: 0x1DC13D0 VA: 0x181DC2DD0
	public void ResetToPool() { }

	// RVA: 0x1DC2C40 Offset: 0x1DC1240 VA: 0x181DC2C40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC1F50 Offset: 0x1DC0550 VA: 0x181DC1F50
	public void CopyTo(SubEntityList instance) { }

	// RVA: 0x1DC2070 Offset: 0x1DC0670 VA: 0x181DC2070
	public SubEntityList Copy() { }

	// RVA: 0x1DC2AA0 Offset: 0x1DC10A0 VA: 0x181DC2AA0
	public static SubEntityList Deserialize(Stream stream) { }

	// RVA: 0x1DC21D0 Offset: 0x1DC07D0 VA: 0x181DC21D0
	public static SubEntityList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC2750 Offset: 0x1DC0D50 VA: 0x181DC2750
	public static SubEntityList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC2B20 Offset: 0x1DC1120 VA: 0x181DC2B20
	public static SubEntityList Deserialize(byte[] buffer) { }

	// RVA: 0x1DC2D90 Offset: 0x1DC1390 VA: 0x181DC2D90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC33E0 Offset: 0x1DC19E0 VA: 0x181DC33E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC3400 Offset: 0x1DC1A00 VA: 0x181DC3400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SubEntityList previous) { }

	// RVA: 0x1DC2DB0 Offset: 0x1DC13B0 VA: 0x181DC2DB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC27E0 Offset: 0x1DC0DE0 VA: 0x181DC27E0
	public static SubEntityList Deserialize(byte[] buffer, SubEntityList instance, bool isDelta = False) { }

	// RVA: 0x1DC28E0 Offset: 0x1DC0EE0 VA: 0x181DC28E0
	public static SubEntityList Deserialize(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC2250 Offset: 0x1DC0850 VA: 0x181DC2250
	public static SubEntityList DeserializeLengthDelimited(Stream stream, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC24E0 Offset: 0x1DC0AE0 VA: 0x181DC24E0
	public static SubEntityList DeserializeLength(Stream stream, int length, SubEntityList instance, bool isDelta) { }

	// RVA: 0x1DC2F90 Offset: 0x1DC1590 VA: 0x181DC2F90
	public static void SerializeDelta(Stream stream, SubEntityList instance, SubEntityList previous) { }

	// RVA: 0x1DC3290 Offset: 0x1DC1890 VA: 0x181DC3290
	public static void Serialize(Stream stream, SubEntityList instance) { }

	// RVA: 0x1DC33D0 Offset: 0x1DC19D0 VA: 0x181DC33D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC33E0 Offset: 0x1DC19E0 VA: 0x181DC33E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC3180 Offset: 0x1DC1780 VA: 0x181DC3180
	public static byte[] SerializeToBytes(SubEntityList instance) { }

	// RVA: 0x1DC30D0 Offset: 0x1DC16D0 VA: 0x181DC30D0
	public static void SerializeLengthDelimited(Stream stream, SubEntityList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

