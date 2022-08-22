public class SimpleFloat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6351
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1E0C350 Offset: 0x1E0A950 VA: 0x181E0C350
	public static void ResetToPool(SimpleFloat instance) { }

	// RVA: 0x1E0C2D0 Offset: 0x1E0A8D0 VA: 0x181E0C2D0
	public void ResetToPool() { }

	// RVA: 0x1E0C1A0 Offset: 0x1E0A7A0 VA: 0x181E0C1A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(SimpleFloat instance) { }

	// RVA: 0x1E0B810 Offset: 0x1E09E10 VA: 0x181E0B810
	public SimpleFloat Copy() { }

	// RVA: 0x1E0BDB0 Offset: 0x1E0A3B0 VA: 0x181E0BDB0
	public static SimpleFloat Deserialize(Stream stream) { }

	// RVA: 0x1E0B880 Offset: 0x1E09E80 VA: 0x181E0B880
	public static SimpleFloat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0BD20 Offset: 0x1E0A320 VA: 0x181E0BD20
	public static SimpleFloat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0BF30 Offset: 0x1E0A530 VA: 0x181E0BF30
	public static SimpleFloat Deserialize(byte[] buffer) { }

	// RVA: 0x1E0C290 Offset: 0x1E0A890 VA: 0x181E0C290
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0C7A0 Offset: 0x1E0ADA0 VA: 0x181E0C7A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0C7C0 Offset: 0x1E0ADC0 VA: 0x181E0C7C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleFloat previous) { }

	// RVA: 0x1E0C2B0 Offset: 0x1E0A8B0 VA: 0x181E0C2B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0BE30 Offset: 0x1E0A430 VA: 0x181E0BE30
	public static SimpleFloat Deserialize(byte[] buffer, SimpleFloat instance, bool isDelta = False) { }

	// RVA: 0x1E0C050 Offset: 0x1E0A650 VA: 0x181E0C050
	public static SimpleFloat Deserialize(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0B900 Offset: 0x1E09F00 VA: 0x181E0B900
	public static SimpleFloat DeserializeLengthDelimited(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0BB20 Offset: 0x1E0A120 VA: 0x181E0BB20
	public static SimpleFloat DeserializeLength(Stream stream, int length, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E0C3D0 Offset: 0x1E0A9D0 VA: 0x181E0C3D0
	public static void SerializeDelta(Stream stream, SimpleFloat instance, SimpleFloat previous) { }

	// RVA: 0x1E0C6B0 Offset: 0x1E0ACB0 VA: 0x181E0C6B0
	public static void Serialize(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1E0C790 Offset: 0x1E0AD90 VA: 0x181E0C790
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0C7A0 Offset: 0x1E0ADA0 VA: 0x181E0C7A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0C5A0 Offset: 0x1E0ABA0 VA: 0x181E0C5A0
	public static byte[] SerializeToBytes(SimpleFloat instance) { }

	// RVA: 0x1E0C4F0 Offset: 0x1E0AAF0 VA: 0x181E0C4F0
	public static void SerializeLengthDelimited(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

