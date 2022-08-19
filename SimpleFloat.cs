public class SimpleFloat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6351
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1E0C250 Offset: 0x1E0A850 VA: 0x181E0C250
	public static void ResetToPool(SimpleFloat instance) { }

	// RVA: 0x1E0C1D0 Offset: 0x1E0A7D0 VA: 0x181E0C1D0
	public void ResetToPool() { }

	// RVA: 0x1E0C0A0 Offset: 0x1E0A6A0 VA: 0x181E0C0A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(SimpleFloat instance) { }

	// RVA: 0x1E0B710 Offset: 0x1E09D10 VA: 0x181E0B710
	public SimpleFloat Copy() { }

	// RVA: 0x1E0BCB0 Offset: 0x1E0A2B0 VA: 0x181E0BCB0
	public static SimpleFloat Deserialize(Stream stream) { }

	// RVA: 0x1E0B780 Offset: 0x1E09D80 VA: 0x181E0B780
	public static SimpleFloat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0BC20 Offset: 0x1E0A220 VA: 0x181E0BC20
	public static SimpleFloat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0BE30 Offset: 0x1E0A430 VA: 0x181E0BE30
	public static SimpleFloat Deserialize(byte[] buffer) { }

	// RVA: 0x1E0C190 Offset: 0x1E0A790 VA: 0x181E0C190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0C6A0 Offset: 0x1E0ACA0 VA: 0x181E0C6A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0C6C0 Offset: 0x1E0ACC0 VA: 0x181E0C6C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleFloat previous) { }

	// RVA: 0x1E0C1B0 Offset: 0x1E0A7B0 VA: 0x181E0C1B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0BD30 Offset: 0x1E0A330 VA: 0x181E0BD30
	public static SimpleFloat Deserialize(byte[] buffer, SimpleFloat instance, bool isDelta = False) { }

	// RVA: 0x1E0BF50 Offset: 0x1E0A550 VA: 0x181E0BF50
	public static SimpleFloat Deserialize(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0B800 Offset: 0x1E09E00 VA: 0x181E0B800
	public static SimpleFloat DeserializeLengthDelimited(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0BA20 Offset: 0x1E0A020 VA: 0x181E0BA20
	public static SimpleFloat DeserializeLength(Stream stream, int length, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0C2D0 Offset: 0x1E0A8D0 VA: 0x181E0C2D0
	public static void SerializeDelta(Stream stream, SimpleFloat instance, SimpleFloat previous) { }

	// RVA: 0x1E0C5B0 Offset: 0x1E0ABB0 VA: 0x181E0C5B0
	public static void Serialize(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1E0C690 Offset: 0x1E0AC90 VA: 0x181E0C690
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0C6A0 Offset: 0x1E0ACA0 VA: 0x181E0C6A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0C4A0 Offset: 0x1E0AAA0 VA: 0x181E0C4A0
	public static byte[] SerializeToBytes(SimpleFloat instance) { }

	// RVA: 0x1E0C3F0 Offset: 0x1E0A9F0 VA: 0x181E0C3F0
	public static void SerializeLengthDelimited(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

