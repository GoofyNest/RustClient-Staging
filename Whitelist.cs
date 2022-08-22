public class Whitelist : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6308
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> users; // 0x18

	// Methods

	// RVA: 0x1E54170 Offset: 0x1E52770 VA: 0x181E54170
	public static void ResetToPool(Whitelist instance) { }

	// RVA: 0x1E54250 Offset: 0x1E52850 VA: 0x181E54250
	public void ResetToPool() { }

	// RVA: 0x1E53FE0 Offset: 0x1E525E0 VA: 0x181E53FE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E532F0 Offset: 0x1E518F0 VA: 0x181E532F0
	public void CopyTo(Whitelist instance) { }

	// RVA: 0x1E53410 Offset: 0x1E51A10 VA: 0x181E53410
	public Whitelist Copy() { }

	// RVA: 0x1E53E40 Offset: 0x1E52440 VA: 0x181E53E40
	public static Whitelist Deserialize(Stream stream) { }

	// RVA: 0x1E53570 Offset: 0x1E51B70 VA: 0x181E53570
	public static Whitelist DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E53880 Offset: 0x1E51E80 VA: 0x181E53880
	public static Whitelist DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E53EC0 Offset: 0x1E524C0 VA: 0x181E53EC0
	public static Whitelist Deserialize(byte[] buffer) { }

	// RVA: 0x1E54130 Offset: 0x1E52730 VA: 0x181E54130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E54860 Offset: 0x1E52E60 VA: 0x181E54860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E54880 Offset: 0x1E52E80 VA: 0x181E54880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Whitelist previous) { }

	// RVA: 0x1E54150 Offset: 0x1E52750 VA: 0x181E54150 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E53D40 Offset: 0x1E52340 VA: 0x181E53D40
	public static Whitelist Deserialize(byte[] buffer, Whitelist instance, bool isDelta = False) { }

	// RVA: 0x1E53B80 Offset: 0x1E52180 VA: 0x181E53B80
	public static Whitelist Deserialize(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E535F0 Offset: 0x1E51BF0 VA: 0x181E535F0
	public static Whitelist DeserializeLengthDelimited(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E53910 Offset: 0x1E51F10 VA: 0x181E53910
	public static Whitelist DeserializeLength(Stream stream, int length, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E54330 Offset: 0x1E52930 VA: 0x181E54330
	public static void SerializeDelta(Stream stream, Whitelist instance, Whitelist previous) { }

	// RVA: 0x1E546C0 Offset: 0x1E52CC0 VA: 0x181E546C0
	public static void Serialize(Stream stream, Whitelist instance) { }

	// RVA: 0x1E54850 Offset: 0x1E52E50 VA: 0x181E54850
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E54860 Offset: 0x1E52E60 VA: 0x181E54860
	public void ToProto(Stream stream) { }

	// RVA: 0x1E545B0 Offset: 0x1E52BB0 VA: 0x181E545B0
	public static byte[] SerializeToBytes(Whitelist instance) { }

	// RVA: 0x1E544C0 Offset: 0x1E52AC0 VA: 0x181E544C0
	public static void SerializeLengthDelimited(Stream stream, Whitelist instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

