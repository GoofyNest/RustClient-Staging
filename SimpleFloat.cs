public class SimpleFloat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6351
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1E0CB70 Offset: 0x1E0B170 VA: 0x181E0CB70
	public static void ResetToPool(SimpleFloat instance) { }

	// RVA: 0x1E0CAF0 Offset: 0x1E0B0F0 VA: 0x181E0CAF0
	public void ResetToPool() { }

	// RVA: 0x1E0C9C0 Offset: 0x1E0AFC0 VA: 0x181E0C9C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(SimpleFloat instance) { }

	// RVA: 0x1E0C030 Offset: 0x1E0A630 VA: 0x181E0C030
	public SimpleFloat Copy() { }

	// RVA: 0x1E0C5D0 Offset: 0x1E0ABD0 VA: 0x181E0C5D0
	public static SimpleFloat Deserialize(Stream stream) { }

	// RVA: 0x1E0C0A0 Offset: 0x1E0A6A0 VA: 0x181E0C0A0
	public static SimpleFloat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0C540 Offset: 0x1E0AB40 VA: 0x181E0C540
	public static SimpleFloat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0C750 Offset: 0x1E0AD50 VA: 0x181E0C750
	public static SimpleFloat Deserialize(byte[] buffer) { }

	// RVA: 0x1E0CAB0 Offset: 0x1E0B0B0 VA: 0x181E0CAB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0CFC0 Offset: 0x1E0B5C0 VA: 0x181E0CFC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0CFE0 Offset: 0x1E0B5E0 VA: 0x181E0CFE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleFloat previous) { }

	// RVA: 0x1E0CAD0 Offset: 0x1E0B0D0 VA: 0x181E0CAD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0C650 Offset: 0x1E0AC50 VA: 0x181E0C650
	public static SimpleFloat Deserialize(byte[] buffer, SimpleFloat instance, bool isDelta = False) { }

	// RVA: 0x1E0C870 Offset: 0x1E0AE70 VA: 0x181E0C870
	public static SimpleFloat Deserialize(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0C120 Offset: 0x1E0A720 VA: 0x181E0C120
	public static SimpleFloat DeserializeLengthDelimited(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0C340 Offset: 0x1E0A940 VA: 0x181E0C340
	public static SimpleFloat DeserializeLength(Stream stream, int length, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0CBF0 Offset: 0x1E0B1F0 VA: 0x181E0CBF0
	public static void SerializeDelta(Stream stream, SimpleFloat instance, SimpleFloat previous) { }

	// RVA: 0x1E0CED0 Offset: 0x1E0B4D0 VA: 0x181E0CED0
	public static void Serialize(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1E0CFB0 Offset: 0x1E0B5B0 VA: 0x181E0CFB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0CFC0 Offset: 0x1E0B5C0 VA: 0x181E0CFC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0CDC0 Offset: 0x1E0B3C0 VA: 0x181E0CDC0
	public static byte[] SerializeToBytes(SimpleFloat instance) { }

	// RVA: 0x1E0CD10 Offset: 0x1E0B310 VA: 0x181E0CD10
	public static void SerializeLengthDelimited(Stream stream, SimpleFloat instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

