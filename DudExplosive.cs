public class DudExplosive : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fuseTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E6F210 Offset: 0x1E6D810 VA: 0x181E6F210
	public static void ResetToPool(DudExplosive instance) { }

	// RVA: 0x1E6F290 Offset: 0x1E6D890 VA: 0x181E6F290
	public void ResetToPool() { }

	// RVA: 0x1E6F0E0 Offset: 0x1E6D6E0 VA: 0x181E6F0E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(DudExplosive instance) { }

	// RVA: 0x1E6E750 Offset: 0x1E6CD50 VA: 0x181E6E750
	public DudExplosive Copy() { }

	// RVA: 0x1E6EDF0 Offset: 0x1E6D3F0 VA: 0x181E6EDF0
	public static DudExplosive Deserialize(Stream stream) { }

	// RVA: 0x1E6E9E0 Offset: 0x1E6CFE0 VA: 0x181E6E9E0
	public static DudExplosive DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6EA60 Offset: 0x1E6D060 VA: 0x181E6EA60
	public static DudExplosive DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6EE70 Offset: 0x1E6D470 VA: 0x181E6EE70
	public static DudExplosive Deserialize(byte[] buffer) { }

	// RVA: 0x1E6F1D0 Offset: 0x1E6D7D0 VA: 0x181E6F1D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6F6E0 Offset: 0x1E6DCE0 VA: 0x181E6F6E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6F700 Offset: 0x1E6DD00 VA: 0x181E6F700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DudExplosive previous) { }

	// RVA: 0x1E6F1F0 Offset: 0x1E6D7F0 VA: 0x181E6F1F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6ECF0 Offset: 0x1E6D2F0 VA: 0x181E6ECF0
	public static DudExplosive Deserialize(byte[] buffer, DudExplosive instance, bool isDelta = False) { }

	// RVA: 0x1E6EF90 Offset: 0x1E6D590 VA: 0x181E6EF90
	public static DudExplosive Deserialize(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6E7C0 Offset: 0x1E6CDC0 VA: 0x181E6E7C0
	public static DudExplosive DeserializeLengthDelimited(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6EAF0 Offset: 0x1E6D0F0 VA: 0x181E6EAF0
	public static DudExplosive DeserializeLength(Stream stream, int length, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6F310 Offset: 0x1E6D910 VA: 0x181E6F310
	public static void SerializeDelta(Stream stream, DudExplosive instance, DudExplosive previous) { }

	// RVA: 0x1E6F5F0 Offset: 0x1E6DBF0 VA: 0x181E6F5F0
	public static void Serialize(Stream stream, DudExplosive instance) { }

	// RVA: 0x1E6F6D0 Offset: 0x1E6DCD0 VA: 0x181E6F6D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6F6E0 Offset: 0x1E6DCE0 VA: 0x181E6F6E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6F4E0 Offset: 0x1E6DAE0 VA: 0x181E6F4E0
	public static byte[] SerializeToBytes(DudExplosive instance) { }

	// RVA: 0x1E6F430 Offset: 0x1E6DA30 VA: 0x181E6F430
	public static void SerializeLengthDelimited(Stream stream, DudExplosive instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

