public class MapNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6460
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteType; // 0x14
	public Vector3 worldPosition; // 0x18

	// Methods

	// RVA: 0x1F413C0 Offset: 0x1F3F9C0 VA: 0x181F413C0
	public static void ResetToPool(MapNote instance) { }

	// RVA: 0x1F41330 Offset: 0x1F3F930 VA: 0x181F41330
	public void ResetToPool() { }

	// RVA: 0x1F41270 Offset: 0x1F3F870 VA: 0x181F41270 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFD180 Offset: 0x1BFB780 VA: 0x181BFD180
	public void CopyTo(MapNote instance) { }

	// RVA: 0x1F40820 Offset: 0x1F3EE20 VA: 0x181F40820
	public MapNote Copy() { }

	// RVA: 0x1F40FD0 Offset: 0x1F3F5D0 VA: 0x181F40FD0
	public static MapNote Deserialize(Stream stream) { }

	// RVA: 0x1F40B00 Offset: 0x1F3F100 VA: 0x181F40B00
	public static MapNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F40DB0 Offset: 0x1F3F3B0 VA: 0x181F40DB0
	public static MapNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F41150 Offset: 0x1F3F750 VA: 0x181F41150
	public static MapNote Deserialize(byte[] buffer) { }

	// RVA: 0x1F412F0 Offset: 0x1F3F8F0 VA: 0x181F412F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F41A50 Offset: 0x1F40050 VA: 0x181F41A50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F41A70 Offset: 0x1F40070 VA: 0x181F41A70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNote previous) { }

	// RVA: 0x1F41310 Offset: 0x1F3F910 VA: 0x181F41310 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F41050 Offset: 0x1F3F650 VA: 0x181F41050
	public static MapNote Deserialize(byte[] buffer, MapNote instance, bool isDelta = False) { }

	// RVA: 0x1F40E40 Offset: 0x1F3F440 VA: 0x181F40E40
	public static MapNote Deserialize(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F408A0 Offset: 0x1F3EEA0 VA: 0x181F408A0
	public static MapNote DeserializeLengthDelimited(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F40B80 Offset: 0x1F3F180 VA: 0x181F40B80
	public static MapNote DeserializeLength(Stream stream, int length, MapNote instance, bool isDelta) { }

	// RVA: 0x1F41450 Offset: 0x1F3FA50 VA: 0x181F41450
	public static void SerializeDelta(Stream stream, MapNote instance, MapNote previous) { }

	// RVA: 0x1F418A0 Offset: 0x1F3FEA0 VA: 0x181F418A0
	public static void Serialize(Stream stream, MapNote instance) { }

	// RVA: 0x1F41A40 Offset: 0x1F40040 VA: 0x181F41A40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F41A50 Offset: 0x1F40050 VA: 0x181F41A50
	public void ToProto(Stream stream) { }

	// RVA: 0x1F41790 Offset: 0x1F3FD90 VA: 0x181F41790
	public static byte[] SerializeToBytes(MapNote instance) { }

	// RVA: 0x1F416E0 Offset: 0x1F3FCE0 VA: 0x181F416E0
	public static void SerializeLengthDelimited(Stream stream, MapNote instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

