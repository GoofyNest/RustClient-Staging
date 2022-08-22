public class Sign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6319
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageid; // 0x14
	public List<uint> imageIds; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1E0B850 Offset: 0x1E09E50 VA: 0x181E0B850
	public static void ResetToPool(Sign instance) { }

	// RVA: 0x1E0B6F0 Offset: 0x1E09CF0 VA: 0x181E0B6F0
	public void ResetToPool() { }

	// RVA: 0x1E0B4E0 Offset: 0x1E09AE0 VA: 0x181E0B4E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0A560 Offset: 0x1E08B60 VA: 0x181E0A560
	public void CopyTo(Sign instance) { }

	// RVA: 0x1E0A760 Offset: 0x1E08D60 VA: 0x181E0A760
	public Sign Copy() { }

	// RVA: 0x1E0B460 Offset: 0x1E09A60 VA: 0x181E0B460
	public static Sign Deserialize(Stream stream) { }

	// RVA: 0x1E0A7E0 Offset: 0x1E08DE0 VA: 0x181E0A7E0
	public static Sign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0AF20 Offset: 0x1E09520 VA: 0x181E0AF20
	public static Sign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0B340 Offset: 0x1E09940 VA: 0x181E0B340
	public static Sign Deserialize(byte[] buffer) { }

	// RVA: 0x1E0B6B0 Offset: 0x1E09CB0 VA: 0x181E0B6B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0BFF0 Offset: 0x1E0A5F0 VA: 0x181E0BFF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0C010 Offset: 0x1E0A610 VA: 0x181E0C010 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Sign previous) { }

	// RVA: 0x1E0B6D0 Offset: 0x1E09CD0 VA: 0x181E0B6D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0AFB0 Offset: 0x1E095B0 VA: 0x181E0AFB0
	public static Sign Deserialize(byte[] buffer, Sign instance, bool isDelta = False) { }

	// RVA: 0x1E0B0B0 Offset: 0x1E096B0 VA: 0x181E0B0B0
	public static Sign Deserialize(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E0A860 Offset: 0x1E08E60 VA: 0x181E0A860
	public static Sign DeserializeLengthDelimited(Stream stream, Sign instance, bool isDelta) { }

	// RVA: 0x1E0ABD0 Offset: 0x1E091D0 VA: 0x181E0ABD0
	public static Sign DeserializeLength(Stream stream, int length, Sign instance, bool isDelta) { }

	// RVA: 0x1E0B9B0 Offset: 0x1E09FB0 VA: 0x181E0B9B0
	public static void SerializeDelta(Stream stream, Sign instance, Sign previous) { }

	// RVA: 0x1E0BDB0 Offset: 0x1E0A3B0 VA: 0x181E0BDB0
	public static void Serialize(Stream stream, Sign instance) { }

	// RVA: 0x1E0BFE0 Offset: 0x1E0A5E0 VA: 0x181E0BFE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0BFF0 Offset: 0x1E0A5F0 VA: 0x181E0BFF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0BCA0 Offset: 0x1E0A2A0 VA: 0x181E0BCA0
	public static byte[] SerializeToBytes(Sign instance) { }

	// RVA: 0x1E0BBF0 Offset: 0x1E0A1F0 VA: 0x181E0BBF0
	public static void SerializeLengthDelimited(Stream stream, Sign instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

