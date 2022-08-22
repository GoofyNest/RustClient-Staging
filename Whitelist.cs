public class Whitelist : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6308
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> users; // 0x18

	// Methods

	// RVA: 0x1E54990 Offset: 0x1E52F90 VA: 0x181E54990
	public static void ResetToPool(Whitelist instance) { }

	// RVA: 0x1E54A70 Offset: 0x1E53070 VA: 0x181E54A70
	public void ResetToPool() { }

	// RVA: 0x1E54800 Offset: 0x1E52E00 VA: 0x181E54800 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E53B10 Offset: 0x1E52110 VA: 0x181E53B10
	public void CopyTo(Whitelist instance) { }

	// RVA: 0x1E53C30 Offset: 0x1E52230 VA: 0x181E53C30
	public Whitelist Copy() { }

	// RVA: 0x1E54660 Offset: 0x1E52C60 VA: 0x181E54660
	public static Whitelist Deserialize(Stream stream) { }

	// RVA: 0x1E53D90 Offset: 0x1E52390 VA: 0x181E53D90
	public static Whitelist DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E540A0 Offset: 0x1E526A0 VA: 0x181E540A0
	public static Whitelist DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E546E0 Offset: 0x1E52CE0 VA: 0x181E546E0
	public static Whitelist Deserialize(byte[] buffer) { }

	// RVA: 0x1E54950 Offset: 0x1E52F50 VA: 0x181E54950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E55080 Offset: 0x1E53680 VA: 0x181E55080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E550A0 Offset: 0x1E536A0 VA: 0x181E550A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Whitelist previous) { }

	// RVA: 0x1E54970 Offset: 0x1E52F70 VA: 0x181E54970 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E54560 Offset: 0x1E52B60 VA: 0x181E54560
	public static Whitelist Deserialize(byte[] buffer, Whitelist instance, bool isDelta = False) { }

	// RVA: 0x1E543A0 Offset: 0x1E529A0 VA: 0x181E543A0
	public static Whitelist Deserialize(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E53E10 Offset: 0x1E52410 VA: 0x181E53E10
	public static Whitelist DeserializeLengthDelimited(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E54130 Offset: 0x1E52730 VA: 0x181E54130
	public static Whitelist DeserializeLength(Stream stream, int length, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E54B50 Offset: 0x1E53150 VA: 0x181E54B50
	public static void SerializeDelta(Stream stream, Whitelist instance, Whitelist previous) { }

	// RVA: 0x1E54EE0 Offset: 0x1E534E0 VA: 0x181E54EE0
	public static void Serialize(Stream stream, Whitelist instance) { }

	// RVA: 0x1E55070 Offset: 0x1E53670 VA: 0x181E55070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E55080 Offset: 0x1E53680 VA: 0x181E55080
	public void ToProto(Stream stream) { }

	// RVA: 0x1E54DD0 Offset: 0x1E533D0 VA: 0x181E54DD0
	public static byte[] SerializeToBytes(Whitelist instance) { }

	// RVA: 0x1E54CE0 Offset: 0x1E532E0 VA: 0x181E54CE0
	public static void SerializeLengthDelimited(Stream stream, Whitelist instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

