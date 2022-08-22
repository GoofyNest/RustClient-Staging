public class DudExplosive : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fuseTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E6FB30 Offset: 0x1E6E130 VA: 0x181E6FB30
	public static void ResetToPool(DudExplosive instance) { }

	// RVA: 0x1E6FBB0 Offset: 0x1E6E1B0 VA: 0x181E6FBB0
	public void ResetToPool() { }

	// RVA: 0x1E6FA00 Offset: 0x1E6E000 VA: 0x181E6FA00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(DudExplosive instance) { }

	// RVA: 0x1E6F070 Offset: 0x1E6D670 VA: 0x181E6F070
	public DudExplosive Copy() { }

	// RVA: 0x1E6F710 Offset: 0x1E6DD10 VA: 0x181E6F710
	public static DudExplosive Deserialize(Stream stream) { }

	// RVA: 0x1E6F300 Offset: 0x1E6D900 VA: 0x181E6F300
	public static DudExplosive DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6F380 Offset: 0x1E6D980 VA: 0x181E6F380
	public static DudExplosive DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6F790 Offset: 0x1E6DD90 VA: 0x181E6F790
	public static DudExplosive Deserialize(byte[] buffer) { }

	// RVA: 0x1E6FAF0 Offset: 0x1E6E0F0 VA: 0x181E6FAF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E70000 Offset: 0x1E6E600 VA: 0x181E70000 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E70020 Offset: 0x1E6E620 VA: 0x181E70020 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DudExplosive previous) { }

	// RVA: 0x1E6FB10 Offset: 0x1E6E110 VA: 0x181E6FB10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6F610 Offset: 0x1E6DC10 VA: 0x181E6F610
	public static DudExplosive Deserialize(byte[] buffer, DudExplosive instance, bool isDelta = False) { }

	// RVA: 0x1E6F8B0 Offset: 0x1E6DEB0 VA: 0x181E6F8B0
	public static DudExplosive Deserialize(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6F0E0 Offset: 0x1E6D6E0 VA: 0x181E6F0E0
	public static DudExplosive DeserializeLengthDelimited(Stream stream, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6F410 Offset: 0x1E6DA10 VA: 0x181E6F410
	public static DudExplosive DeserializeLength(Stream stream, int length, DudExplosive instance, bool isDelta) { }

	// RVA: 0x1E6FC30 Offset: 0x1E6E230 VA: 0x181E6FC30
	public static void SerializeDelta(Stream stream, DudExplosive instance, DudExplosive previous) { }

	// RVA: 0x1E6FF10 Offset: 0x1E6E510 VA: 0x181E6FF10
	public static void Serialize(Stream stream, DudExplosive instance) { }

	// RVA: 0x1E6FFF0 Offset: 0x1E6E5F0 VA: 0x181E6FFF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E70000 Offset: 0x1E6E600 VA: 0x181E70000
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6FE00 Offset: 0x1E6E400 VA: 0x181E6FE00
	public static byte[] SerializeToBytes(DudExplosive instance) { }

	// RVA: 0x1E6FD50 Offset: 0x1E6E350 VA: 0x181E6FD50
	public static void SerializeLengthDelimited(Stream stream, DudExplosive instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

