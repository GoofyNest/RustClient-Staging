public class Zipline : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> destinationPoints; // 0x18

	// Methods

	// RVA: 0x1E5E770 Offset: 0x1E5CD70 VA: 0x181E5E770
	public static void ResetToPool(Zipline instance) { }

	// RVA: 0x1E5E690 Offset: 0x1E5CC90 VA: 0x181E5E690
	public void ResetToPool() { }

	// RVA: 0x1E5E500 Offset: 0x1E5CB00 VA: 0x181E5E500 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5D790 Offset: 0x1E5BD90 VA: 0x181E5D790
	public void CopyTo(Zipline instance) { }

	// RVA: 0x1E5D8F0 Offset: 0x1E5BEF0 VA: 0x181E5D8F0
	public Zipline Copy() { }

	// RVA: 0x1E5E0B0 Offset: 0x1E5C6B0 VA: 0x181E5E0B0
	public static Zipline Deserialize(Stream stream) { }

	// RVA: 0x1E5DAB0 Offset: 0x1E5C0B0 VA: 0x181E5DAB0
	public static Zipline DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5DDB0 Offset: 0x1E5C3B0 VA: 0x181E5DDB0
	public static Zipline DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5E130 Offset: 0x1E5C730 VA: 0x181E5E130
	public static Zipline Deserialize(byte[] buffer) { }

	// RVA: 0x1E5E650 Offset: 0x1E5CC50 VA: 0x181E5E650
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5EF30 Offset: 0x1E5D530 VA: 0x181E5EF30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5EF50 Offset: 0x1E5D550 VA: 0x181E5EF50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Zipline previous) { }

	// RVA: 0x1E5E670 Offset: 0x1E5CC70 VA: 0x181E5E670 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5E400 Offset: 0x1E5CA00 VA: 0x181E5E400
	public static Zipline Deserialize(byte[] buffer, Zipline instance, bool isDelta = False) { }

	// RVA: 0x1E5E250 Offset: 0x1E5C850 VA: 0x181E5E250
	public static Zipline Deserialize(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5DB30 Offset: 0x1E5C130 VA: 0x181E5DB30
	public static Zipline DeserializeLengthDelimited(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5DE40 Offset: 0x1E5C440 VA: 0x181E5DE40
	public static Zipline DeserializeLength(Stream stream, int length, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5E850 Offset: 0x1E5CE50 VA: 0x181E5E850
	public static void SerializeDelta(Stream stream, Zipline instance, Zipline previous) { }

	// RVA: 0x1E5ECD0 Offset: 0x1E5D2D0 VA: 0x181E5ECD0
	public static void Serialize(Stream stream, Zipline instance) { }

	// RVA: 0x1E5EF20 Offset: 0x1E5D520 VA: 0x181E5EF20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5EF30 Offset: 0x1E5D530 VA: 0x181E5EF30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5EBC0 Offset: 0x1E5D1C0 VA: 0x181E5EBC0
	public static byte[] SerializeToBytes(Zipline instance) { }

	// RVA: 0x1E5EAD0 Offset: 0x1E5D0D0 VA: 0x181E5EAD0
	public static void SerializeLengthDelimited(Stream stream, Zipline instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

