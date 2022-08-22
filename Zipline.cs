public class Zipline : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> destinationPoints; // 0x18

	// Methods

	// RVA: 0x1E5E5B0 Offset: 0x1E5CBB0 VA: 0x181E5E5B0
	public static void ResetToPool(Zipline instance) { }

	// RVA: 0x1E5E4D0 Offset: 0x1E5CAD0 VA: 0x181E5E4D0
	public void ResetToPool() { }

	// RVA: 0x1E5E340 Offset: 0x1E5C940 VA: 0x181E5E340 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5D5D0 Offset: 0x1E5BBD0 VA: 0x181E5D5D0
	public void CopyTo(Zipline instance) { }

	// RVA: 0x1E5D730 Offset: 0x1E5BD30 VA: 0x181E5D730
	public Zipline Copy() { }

	// RVA: 0x1E5DEF0 Offset: 0x1E5C4F0 VA: 0x181E5DEF0
	public static Zipline Deserialize(Stream stream) { }

	// RVA: 0x1E5D8F0 Offset: 0x1E5BEF0 VA: 0x181E5D8F0
	public static Zipline DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5DBF0 Offset: 0x1E5C1F0 VA: 0x181E5DBF0
	public static Zipline DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5DF70 Offset: 0x1E5C570 VA: 0x181E5DF70
	public static Zipline Deserialize(byte[] buffer) { }

	// RVA: 0x1E5E490 Offset: 0x1E5CA90 VA: 0x181E5E490
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5ED70 Offset: 0x1E5D370 VA: 0x181E5ED70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5ED90 Offset: 0x1E5D390 VA: 0x181E5ED90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Zipline previous) { }

	// RVA: 0x1E5E4B0 Offset: 0x1E5CAB0 VA: 0x181E5E4B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5E240 Offset: 0x1E5C840 VA: 0x181E5E240
	public static Zipline Deserialize(byte[] buffer, Zipline instance, bool isDelta = False) { }

	// RVA: 0x1E5E090 Offset: 0x1E5C690 VA: 0x181E5E090
	public static Zipline Deserialize(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5D970 Offset: 0x1E5BF70 VA: 0x181E5D970
	public static Zipline DeserializeLengthDelimited(Stream stream, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5DC80 Offset: 0x1E5C280 VA: 0x181E5DC80
	public static Zipline DeserializeLength(Stream stream, int length, Zipline instance, bool isDelta) { }

	// RVA: 0x1E5E690 Offset: 0x1E5CC90 VA: 0x181E5E690
	public static void SerializeDelta(Stream stream, Zipline instance, Zipline previous) { }

	// RVA: 0x1E5EB10 Offset: 0x1E5D110 VA: 0x181E5EB10
	public static void Serialize(Stream stream, Zipline instance) { }

	// RVA: 0x1E5ED60 Offset: 0x1E5D360 VA: 0x181E5ED60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5ED70 Offset: 0x1E5D370 VA: 0x181E5ED70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5EA00 Offset: 0x1E5D000 VA: 0x181E5EA00
	public static byte[] SerializeToBytes(Zipline instance) { }

	// RVA: 0x1E5E910 Offset: 0x1E5CF10 VA: 0x181E5E910
	public static void SerializeLengthDelimited(Stream stream, Zipline instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

