public class SimpleUID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6350
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14

	// Methods

	// RVA: 0x1E0D2B0 Offset: 0x1E0B8B0 VA: 0x181E0D2B0
	public static void ResetToPool(SimpleUID instance) { }

	// RVA: 0x1E0D330 Offset: 0x1E0B930 VA: 0x181E0D330
	public void ResetToPool() { }

	// RVA: 0x1E0D180 Offset: 0x1E0B780 VA: 0x181E0D180 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(SimpleUID instance) { }

	// RVA: 0x1E0C800 Offset: 0x1E0AE00 VA: 0x181E0C800
	public SimpleUID Copy() { }

	// RVA: 0x1E0CDA0 Offset: 0x1E0B3A0 VA: 0x181E0CDA0
	public static SimpleUID Deserialize(Stream stream) { }

	// RVA: 0x1E0C870 Offset: 0x1E0AE70 VA: 0x181E0C870
	public static SimpleUID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0CD10 Offset: 0x1E0B310 VA: 0x181E0CD10
	public static SimpleUID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0D060 Offset: 0x1E0B660 VA: 0x181E0D060
	public static SimpleUID Deserialize(byte[] buffer) { }

	// RVA: 0x1E0D270 Offset: 0x1E0B870 VA: 0x181E0D270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0D800 Offset: 0x1E0BE00 VA: 0x181E0D800 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0D8D0 Offset: 0x1E0BED0 VA: 0x181E0D8D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleUID previous) { }

	// RVA: 0x1E0D290 Offset: 0x1E0B890 VA: 0x181E0D290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0CF60 Offset: 0x1E0B560 VA: 0x181E0CF60
	public static SimpleUID Deserialize(byte[] buffer, SimpleUID instance, bool isDelta = False) { }

	// RVA: 0x1E0CE20 Offset: 0x1E0B420 VA: 0x181E0CE20
	public static SimpleUID Deserialize(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0C8F0 Offset: 0x1E0AEF0 VA: 0x181E0C8F0
	public static SimpleUID DeserializeLengthDelimited(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0CB10 Offset: 0x1E0B110 VA: 0x181E0CB10
	public static SimpleUID DeserializeLength(Stream stream, int length, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0D3B0 Offset: 0x1E0B9B0 VA: 0x181E0D3B0
	public static void SerializeDelta(Stream stream, SimpleUID instance, SimpleUID previous) { }

	// RVA: 0x1E0D720 Offset: 0x1E0BD20 VA: 0x181E0D720
	public static void Serialize(Stream stream, SimpleUID instance) { }

	// RVA: 0x1E0D7F0 Offset: 0x1E0BDF0 VA: 0x181E0D7F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0D800 Offset: 0x1E0BE00 VA: 0x181E0D800
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0D570 Offset: 0x1E0BB70 VA: 0x181E0D570
	public static byte[] SerializeToBytes(SimpleUID instance) { }

	// RVA: 0x1E0D4C0 Offset: 0x1E0BAC0 VA: 0x181E0D4C0
	public static void SerializeLengthDelimited(Stream stream, SimpleUID instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

