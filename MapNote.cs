public class MapNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6460
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteType; // 0x14
	public Vector3 worldPosition; // 0x18

	// Methods

	// RVA: 0x1F41580 Offset: 0x1F3FB80 VA: 0x181F41580
	public static void ResetToPool(MapNote instance) { }

	// RVA: 0x1F414F0 Offset: 0x1F3FAF0 VA: 0x181F414F0
	public void ResetToPool() { }

	// RVA: 0x1F41430 Offset: 0x1F3FA30 VA: 0x181F41430 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFD340 Offset: 0x1BFB940 VA: 0x181BFD340
	public void CopyTo(MapNote instance) { }

	// RVA: 0x1F409E0 Offset: 0x1F3EFE0 VA: 0x181F409E0
	public MapNote Copy() { }

	// RVA: 0x1F41190 Offset: 0x1F3F790 VA: 0x181F41190
	public static MapNote Deserialize(Stream stream) { }

	// RVA: 0x1F40CC0 Offset: 0x1F3F2C0 VA: 0x181F40CC0
	public static MapNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F40F70 Offset: 0x1F3F570 VA: 0x181F40F70
	public static MapNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F41310 Offset: 0x1F3F910 VA: 0x181F41310
	public static MapNote Deserialize(byte[] buffer) { }

	// RVA: 0x1F414B0 Offset: 0x1F3FAB0 VA: 0x181F414B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F41C10 Offset: 0x1F40210 VA: 0x181F41C10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F41C30 Offset: 0x1F40230 VA: 0x181F41C30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNote previous) { }

	// RVA: 0x1F414D0 Offset: 0x1F3FAD0 VA: 0x181F414D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F41210 Offset: 0x1F3F810 VA: 0x181F41210
	public static MapNote Deserialize(byte[] buffer, MapNote instance, bool isDelta = False) { }

	// RVA: 0x1F41000 Offset: 0x1F3F600 VA: 0x181F41000
	public static MapNote Deserialize(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F40A60 Offset: 0x1F3F060 VA: 0x181F40A60
	public static MapNote DeserializeLengthDelimited(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F40D40 Offset: 0x1F3F340 VA: 0x181F40D40
	public static MapNote DeserializeLength(Stream stream, int length, MapNote instance, bool isDelta) { }

	// RVA: 0x1F41610 Offset: 0x1F3FC10 VA: 0x181F41610
	public static void SerializeDelta(Stream stream, MapNote instance, MapNote previous) { }

	// RVA: 0x1F41A60 Offset: 0x1F40060 VA: 0x181F41A60
	public static void Serialize(Stream stream, MapNote instance) { }

	// RVA: 0x1F41C00 Offset: 0x1F40200 VA: 0x181F41C00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F41C10 Offset: 0x1F40210 VA: 0x181F41C10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F41950 Offset: 0x1F3FF50 VA: 0x181F41950
	public static byte[] SerializeToBytes(MapNote instance) { }

	// RVA: 0x1F418A0 Offset: 0x1F3FEA0 VA: 0x181F418A0
	public static void SerializeLengthDelimited(Stream stream, MapNote instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

