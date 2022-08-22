public class DudExplosive : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fuseTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E6F310 Offset: 0x1E6D910 VA: 0x181E6F310
	public static void ResetToPool(DudExplosive instance) { }

	// RVA: 0x1E6F390 Offset: 0x1E6D990 VA: 0x181E6F390
	public void ResetToPool() { }

	// RVA: 0x1E6F1E0 Offset: 0x1E6D7E0 VA: 0x181E6F1E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(DudExplosive instance) { }

	// RVA: 0x1E6E850 Offset: 0x1E6CE50 VA: 0x181E6E850
	public DudExplosive Copy() { }

	// RVA: 0x1E6EEF0 Offset: 0x1E6D4F0 VA: 0x181E6EEF0
	public static DudExplosive Deserialize(Stream stream) { }

	// RVA: 0x1E6EAE0 Offset: 0x1E6D0E0 VA: 0x181E6EAE0
	public static DudExplosive DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6EB60 Offset: 0x1E6D160 VA: 0x181E6EB60
	public static DudExplosive DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6EF70 Offset: 0x1E6D570 VA: 0x181E6EF70
	public static DudExplosive Deserialize(byte[] buffer) { }

	// RVA: 0x1E6F2D0 Offset: 0x1E6D8D0 VA: 0x181E6F2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6F7E0 Offset: 0x1E6DDE0 VA: 0x181E6F7E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6F800 Offset: 0x1E6DE00 VA: 0x181E6F800 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DudExplosive previous) { }

	// RVA: 0x1E6F2F0 Offset: 0x1E6D8F0 VA: 0x181E6F2F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6EDF0 Offset: 0x1E6D3F0 VA: 0x181E6EDF0
	public static DudExplosive Deserialize(byte[] buffer, DudExplosive instance, bool isDelta = False) { }

	// RVA: 0x1E6F090 Offset: 0x1E6D690 VA: 0x181E6F090
	public static DudExplosive Deserialize(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6E8C0 Offset: 0x1E6CEC0 VA: 0x181E6E8C0
	public static DudExplosive DeserializeLengthDelimited(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6EBF0 Offset: 0x1E6D1F0 VA: 0x181E6EBF0
	public static DudExplosive DeserializeLength(Stream stream, int length, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6F410 Offset: 0x1E6DA10 VA: 0x181E6F410
	public static void SerializeDelta(Stream stream, DudExplosive instance, DudExplosive previous) { }

	// RVA: 0x1E6F6F0 Offset: 0x1E6DCF0 VA: 0x181E6F6F0
	public static void Serialize(Stream stream, DudExplosive instance) { }

	// RVA: 0x1E6F7D0 Offset: 0x1E6DDD0 VA: 0x181E6F7D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6F7E0 Offset: 0x1E6DDE0 VA: 0x181E6F7E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6F5E0 Offset: 0x1E6DBE0 VA: 0x181E6F5E0
	public static byte[] SerializeToBytes(DudExplosive instance) { }

	// RVA: 0x1E6F530 Offset: 0x1E6DB30 VA: 0x181E6F530
	public static void SerializeLengthDelimited(Stream stream, DudExplosive instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

