public class Zipline : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> destinationPoints; // 0x18

	// Methods

	// RVA: 0x1E5F090 Offset: 0x1E5D690 VA: 0x181E5F090
	public static void ResetToPool(Zipline instance) { }

	// RVA: 0x1E5EFB0 Offset: 0x1E5D5B0 VA: 0x181E5EFB0
	public void ResetToPool() { }

	// RVA: 0x1E5EE20 Offset: 0x1E5D420 VA: 0x181E5EE20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5E0B0 Offset: 0x1E5C6B0 VA: 0x181E5E0B0
	public void CopyTo(Zipline instance) { }

	// RVA: 0x1E5E210 Offset: 0x1E5C810 VA: 0x181E5E210
	public Zipline Copy() { }

	// RVA: 0x1E5E9D0 Offset: 0x1E5CFD0 VA: 0x181E5E9D0
	public static Zipline Deserialize(Stream stream) { }

	// RVA: 0x1E5E3D0 Offset: 0x1E5C9D0 VA: 0x181E5E3D0
	public static Zipline DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5E6D0 Offset: 0x1E5CCD0 VA: 0x181E5E6D0
	public static Zipline DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5EA50 Offset: 0x1E5D050 VA: 0x181E5EA50
	public static Zipline Deserialize(byte[] buffer) { }

	// RVA: 0x1E5EF70 Offset: 0x1E5D570 VA: 0x181E5EF70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5F850 Offset: 0x1E5DE50 VA: 0x181E5F850 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5F870 Offset: 0x1E5DE70 VA: 0x181E5F870 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Zipline previous) { }

	// RVA: 0x1E5EF90 Offset: 0x1E5D590 VA: 0x181E5EF90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5ED20 Offset: 0x1E5D320 VA: 0x181E5ED20
	public static Zipline Deserialize(byte[] buffer, Zipline instance, bool isDelta = False) { }

	// RVA: 0x1E5EB70 Offset: 0x1E5D170 VA: 0x181E5EB70
	public static Zipline Deserialize(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5E450 Offset: 0x1E5CA50 VA: 0x181E5E450
	public static Zipline DeserializeLengthDelimited(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5E760 Offset: 0x1E5CD60 VA: 0x181E5E760
	public static Zipline DeserializeLength(Stream stream, int length, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5F170 Offset: 0x1E5D770 VA: 0x181E5F170
	public static void SerializeDelta(Stream stream, Zipline instance, Zipline previous) { }

	// RVA: 0x1E5F5F0 Offset: 0x1E5DBF0 VA: 0x181E5F5F0
	public static void Serialize(Stream stream, Zipline instance) { }

	// RVA: 0x1E5F840 Offset: 0x1E5DE40 VA: 0x181E5F840
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5F850 Offset: 0x1E5DE50 VA: 0x181E5F850
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5F4E0 Offset: 0x1E5DAE0 VA: 0x181E5F4E0
	public static byte[] SerializeToBytes(Zipline instance) { }

	// RVA: 0x1E5F3F0 Offset: 0x1E5D9F0 VA: 0x181E5F3F0
	public static void SerializeLengthDelimited(Stream stream, Zipline instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

