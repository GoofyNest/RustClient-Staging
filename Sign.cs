public class Sign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6319
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageid; // 0x14
	public List<uint> imageIds; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1E0AD70 Offset: 0x1E09370 VA: 0x181E0AD70
	public static void ResetToPool(Sign instance) { }

	// RVA: 0x1E0AC10 Offset: 0x1E09210 VA: 0x181E0AC10
	public void ResetToPool() { }

	// RVA: 0x1E0AA00 Offset: 0x1E09000 VA: 0x181E0AA00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E09A80 Offset: 0x1E08080 VA: 0x181E09A80
	public void CopyTo(Sign instance) { }

	// RVA: 0x1E09C80 Offset: 0x1E08280 VA: 0x181E09C80
	public Sign Copy() { }

	// RVA: 0x1E0A980 Offset: 0x1E08F80 VA: 0x181E0A980
	public static Sign Deserialize(Stream stream) { }

	// RVA: 0x1E09D00 Offset: 0x1E08300 VA: 0x181E09D00
	public static Sign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0A440 Offset: 0x1E08A40 VA: 0x181E0A440
	public static Sign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0A860 Offset: 0x1E08E60 VA: 0x181E0A860
	public static Sign Deserialize(byte[] buffer) { }

	// RVA: 0x1E0ABD0 Offset: 0x1E091D0 VA: 0x181E0ABD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0B510 Offset: 0x1E09B10 VA: 0x181E0B510 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0B530 Offset: 0x1E09B30 VA: 0x181E0B530 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Sign previous) { }

	// RVA: 0x1E0ABF0 Offset: 0x1E091F0 VA: 0x181E0ABF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0A4D0 Offset: 0x1E08AD0 VA: 0x181E0A4D0
	public static Sign Deserialize(byte[] buffer, Sign instance, bool isDelta = False) { }

	// RVA: 0x1E0A5D0 Offset: 0x1E08BD0 VA: 0x181E0A5D0
	public static Sign Deserialize(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E09D80 Offset: 0x1E08380 VA: 0x181E09D80
	public static Sign DeserializeLengthDelimited(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E0A0F0 Offset: 0x1E086F0 VA: 0x181E0A0F0
	public static Sign DeserializeLength(Stream stream, int length, Sign instance, bool isDelta) { }

	// RVA: 0x1E0AED0 Offset: 0x1E094D0 VA: 0x181E0AED0
	public static void SerializeDelta(Stream stream, Sign instance, Sign previous) { }

	// RVA: 0x1E0B2D0 Offset: 0x1E098D0 VA: 0x181E0B2D0
	public static void Serialize(Stream stream, Sign instance) { }

	// RVA: 0x1E0B500 Offset: 0x1E09B00 VA: 0x181E0B500
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0B510 Offset: 0x1E09B10 VA: 0x181E0B510
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0B1C0 Offset: 0x1E097C0 VA: 0x181E0B1C0
	public static byte[] SerializeToBytes(Sign instance) { }

	// RVA: 0x1E0B110 Offset: 0x1E09710 VA: 0x181E0B110
	public static void SerializeLengthDelimited(Stream stream, Sign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

