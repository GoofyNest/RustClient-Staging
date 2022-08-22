public class SimpleUID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6350
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14

	// Methods

	// RVA: 0x1E0D0F0 Offset: 0x1E0B6F0 VA: 0x181E0D0F0
	public static void ResetToPool(SimpleUID instance) { }

	// RVA: 0x1E0D170 Offset: 0x1E0B770 VA: 0x181E0D170
	public void ResetToPool() { }

	// RVA: 0x1E0CFC0 Offset: 0x1E0B5C0 VA: 0x181E0CFC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(SimpleUID instance) { }

	// RVA: 0x1E0C640 Offset: 0x1E0AC40 VA: 0x181E0C640
	public SimpleUID Copy() { }

	// RVA: 0x1E0CBE0 Offset: 0x1E0B1E0 VA: 0x181E0CBE0
	public static SimpleUID Deserialize(Stream stream) { }

	// RVA: 0x1E0C6B0 Offset: 0x1E0ACB0 VA: 0x181E0C6B0
	public static SimpleUID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0CB50 Offset: 0x1E0B150 VA: 0x181E0CB50
	public static SimpleUID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0CEA0 Offset: 0x1E0B4A0 VA: 0x181E0CEA0
	public static SimpleUID Deserialize(byte[] buffer) { }

	// RVA: 0x1E0D0B0 Offset: 0x1E0B6B0 VA: 0x181E0D0B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0D640 Offset: 0x1E0BC40 VA: 0x181E0D640 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0D710 Offset: 0x1E0BD10 VA: 0x181E0D710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleUID previous) { }

	// RVA: 0x1E0D0D0 Offset: 0x1E0B6D0 VA: 0x181E0D0D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0CDA0 Offset: 0x1E0B3A0 VA: 0x181E0CDA0
	public static SimpleUID Deserialize(byte[] buffer, SimpleUID instance, bool isDelta = False) { }

	// RVA: 0x1E0CC60 Offset: 0x1E0B260 VA: 0x181E0CC60
	public static SimpleUID Deserialize(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0C730 Offset: 0x1E0AD30 VA: 0x181E0C730
	public static SimpleUID DeserializeLengthDelimited(Stream stream, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0C950 Offset: 0x1E0AF50 VA: 0x181E0C950
	public static SimpleUID DeserializeLength(Stream stream, int length, SimpleUID instance, bool isDelta) { }

	// RVA: 0x1E0D1F0 Offset: 0x1E0B7F0 VA: 0x181E0D1F0
	public static void SerializeDelta(Stream stream, SimpleUID instance, SimpleUID previous) { }

	// RVA: 0x1E0D560 Offset: 0x1E0BB60 VA: 0x181E0D560
	public static void Serialize(Stream stream, SimpleUID instance) { }

	// RVA: 0x1E0D630 Offset: 0x1E0BC30 VA: 0x181E0D630
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0D640 Offset: 0x1E0BC40 VA: 0x181E0D640
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0D3B0 Offset: 0x1E0B9B0 VA: 0x181E0D3B0
	public static byte[] SerializeToBytes(SimpleUID instance) { }

	// RVA: 0x1E0D300 Offset: 0x1E0B900 VA: 0x181E0D300
	public static void SerializeLengthDelimited(Stream stream, SimpleUID instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

