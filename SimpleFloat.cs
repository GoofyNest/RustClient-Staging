public class SimpleFloat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6351
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1E0C090 Offset: 0x1E0A690 VA: 0x181E0C090
	public static void ResetToPool(SimpleFloat instance) { }

	// RVA: 0x1E0C010 Offset: 0x1E0A610 VA: 0x181E0C010
	public void ResetToPool() { }

	// RVA: 0x1E0BEE0 Offset: 0x1E0A4E0 VA: 0x181E0BEE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(SimpleFloat instance) { }

	// RVA: 0x1E0B550 Offset: 0x1E09B50 VA: 0x181E0B550
	public SimpleFloat Copy() { }

	// RVA: 0x1E0BAF0 Offset: 0x1E0A0F0 VA: 0x181E0BAF0
	public static SimpleFloat Deserialize(Stream stream) { }

	// RVA: 0x1E0B5C0 Offset: 0x1E09BC0 VA: 0x181E0B5C0
	public static SimpleFloat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0BA60 Offset: 0x1E0A060 VA: 0x181E0BA60
	public static SimpleFloat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0BC70 Offset: 0x1E0A270 VA: 0x181E0BC70
	public static SimpleFloat Deserialize(byte[] buffer) { }

	// RVA: 0x1E0BFD0 Offset: 0x1E0A5D0 VA: 0x181E0BFD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0C4E0 Offset: 0x1E0AAE0 VA: 0x181E0C4E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0C500 Offset: 0x1E0AB00 VA: 0x181E0C500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleFloat previous) { }

	// RVA: 0x1E0BFF0 Offset: 0x1E0A5F0 VA: 0x181E0BFF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0BB70 Offset: 0x1E0A170 VA: 0x181E0BB70
	public static SimpleFloat Deserialize(byte[] buffer, SimpleFloat instance, bool isDelta = False) { }

	// RVA: 0x1E0BD90 Offset: 0x1E0A390 VA: 0x181E0BD90
	public static SimpleFloat Deserialize(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0B640 Offset: 0x1E09C40 VA: 0x181E0B640
	public static SimpleFloat DeserializeLengthDelimited(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0B860 Offset: 0x1E09E60 VA: 0x181E0B860
	public static SimpleFloat DeserializeLength(Stream stream, int length, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0C110 Offset: 0x1E0A710 VA: 0x181E0C110
	public static void SerializeDelta(Stream stream, SimpleFloat instance, SimpleFloat previous) { }

	// RVA: 0x1E0C3F0 Offset: 0x1E0A9F0 VA: 0x181E0C3F0
	public static void Serialize(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1E0C4D0 Offset: 0x1E0AAD0 VA: 0x181E0C4D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0C4E0 Offset: 0x1E0AAE0 VA: 0x181E0C4E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0C2E0 Offset: 0x1E0A8E0 VA: 0x181E0C2E0
	public static byte[] SerializeToBytes(SimpleFloat instance) { }

	// RVA: 0x1E0C230 Offset: 0x1E0A830 VA: 0x181E0C230
	public static void SerializeLengthDelimited(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

