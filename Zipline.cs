public class Zipline : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> destinationPoints; // 0x18

	// Methods

	// RVA: 0x1E5E870 Offset: 0x1E5CE70 VA: 0x181E5E870
	public static void ResetToPool(Zipline instance) { }

	// RVA: 0x1E5E790 Offset: 0x1E5CD90 VA: 0x181E5E790
	public void ResetToPool() { }

	// RVA: 0x1E5E600 Offset: 0x1E5CC00 VA: 0x181E5E600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5D890 Offset: 0x1E5BE90 VA: 0x181E5D890
	public void CopyTo(Zipline instance) { }

	// RVA: 0x1E5D9F0 Offset: 0x1E5BFF0 VA: 0x181E5D9F0
	public Zipline Copy() { }

	// RVA: 0x1E5E1B0 Offset: 0x1E5C7B0 VA: 0x181E5E1B0
	public static Zipline Deserialize(Stream stream) { }

	// RVA: 0x1E5DBB0 Offset: 0x1E5C1B0 VA: 0x181E5DBB0
	public static Zipline DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5DEB0 Offset: 0x1E5C4B0 VA: 0x181E5DEB0
	public static Zipline DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5E230 Offset: 0x1E5C830 VA: 0x181E5E230
	public static Zipline Deserialize(byte[] buffer) { }

	// RVA: 0x1E5E750 Offset: 0x1E5CD50 VA: 0x181E5E750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5F030 Offset: 0x1E5D630 VA: 0x181E5F030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5F050 Offset: 0x1E5D650 VA: 0x181E5F050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Zipline previous) { }

	// RVA: 0x1E5E770 Offset: 0x1E5CD70 VA: 0x181E5E770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5E500 Offset: 0x1E5CB00 VA: 0x181E5E500
	public static Zipline Deserialize(byte[] buffer, Zipline instance, bool isDelta = False) { }

	// RVA: 0x1E5E350 Offset: 0x1E5C950 VA: 0x181E5E350
	public static Zipline Deserialize(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5DC30 Offset: 0x1E5C230 VA: 0x181E5DC30
	public static Zipline DeserializeLengthDelimited(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5DF40 Offset: 0x1E5C540 VA: 0x181E5DF40
	public static Zipline DeserializeLength(Stream stream, int length, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5E950 Offset: 0x1E5CF50 VA: 0x181E5E950
	public static void SerializeDelta(Stream stream, Zipline instance, Zipline previous) { }

	// RVA: 0x1E5EDD0 Offset: 0x1E5D3D0 VA: 0x181E5EDD0
	public static void Serialize(Stream stream, Zipline instance) { }

	// RVA: 0x1E5F020 Offset: 0x1E5D620 VA: 0x181E5F020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5F030 Offset: 0x1E5D630 VA: 0x181E5F030
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5ECC0 Offset: 0x1E5D2C0 VA: 0x181E5ECC0
	public static byte[] SerializeToBytes(Zipline instance) { }

	// RVA: 0x1E5EBD0 Offset: 0x1E5D1D0 VA: 0x181E5EBD0
	public static void SerializeLengthDelimited(Stream stream, Zipline instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

