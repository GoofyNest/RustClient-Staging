public class DudExplosive : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fuseTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E6F050 Offset: 0x1E6D650 VA: 0x181E6F050
	public static void ResetToPool(DudExplosive instance) { }

	// RVA: 0x1E6F0D0 Offset: 0x1E6D6D0 VA: 0x181E6F0D0
	public void ResetToPool() { }

	// RVA: 0x1E6EF20 Offset: 0x1E6D520 VA: 0x181E6EF20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(DudExplosive instance) { }

	// RVA: 0x1E6E590 Offset: 0x1E6CB90 VA: 0x181E6E590
	public DudExplosive Copy() { }

	// RVA: 0x1E6EC30 Offset: 0x1E6D230 VA: 0x181E6EC30
	public static DudExplosive Deserialize(Stream stream) { }

	// RVA: 0x1E6E820 Offset: 0x1E6CE20 VA: 0x181E6E820
	public static DudExplosive DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6E8A0 Offset: 0x1E6CEA0 VA: 0x181E6E8A0
	public static DudExplosive DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6ECB0 Offset: 0x1E6D2B0 VA: 0x181E6ECB0
	public static DudExplosive Deserialize(byte[] buffer) { }

	// RVA: 0x1E6F010 Offset: 0x1E6D610 VA: 0x181E6F010
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6F520 Offset: 0x1E6DB20 VA: 0x181E6F520 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6F540 Offset: 0x1E6DB40 VA: 0x181E6F540 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DudExplosive previous) { }

	// RVA: 0x1E6F030 Offset: 0x1E6D630 VA: 0x181E6F030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6EB30 Offset: 0x1E6D130 VA: 0x181E6EB30
	public static DudExplosive Deserialize(byte[] buffer, DudExplosive instance, bool isDelta = False) { }

	// RVA: 0x1E6EDD0 Offset: 0x1E6D3D0 VA: 0x181E6EDD0
	public static DudExplosive Deserialize(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6E600 Offset: 0x1E6CC00 VA: 0x181E6E600
	public static DudExplosive DeserializeLengthDelimited(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6E930 Offset: 0x1E6CF30 VA: 0x181E6E930
	public static DudExplosive DeserializeLength(Stream stream, int length, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6F150 Offset: 0x1E6D750 VA: 0x181E6F150
	public static void SerializeDelta(Stream stream, DudExplosive instance, DudExplosive previous) { }

	// RVA: 0x1E6F430 Offset: 0x1E6DA30 VA: 0x181E6F430
	public static void Serialize(Stream stream, DudExplosive instance) { }

	// RVA: 0x1E6F510 Offset: 0x1E6DB10 VA: 0x181E6F510
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6F520 Offset: 0x1E6DB20 VA: 0x181E6F520
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6F320 Offset: 0x1E6D920 VA: 0x181E6F320
	public static byte[] SerializeToBytes(DudExplosive instance) { }

	// RVA: 0x1E6F270 Offset: 0x1E6D870 VA: 0x181E6F270
	public static void SerializeLengthDelimited(Stream stream, DudExplosive instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

