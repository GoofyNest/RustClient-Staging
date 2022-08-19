public class Whitelist : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6308
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> users; // 0x18

	// Methods

	// RVA: 0x1E54070 Offset: 0x1E52670 VA: 0x181E54070
	public static void ResetToPool(Whitelist instance) { }

	// RVA: 0x1E54150 Offset: 0x1E52750 VA: 0x181E54150
	public void ResetToPool() { }

	// RVA: 0x1E53EE0 Offset: 0x1E524E0 VA: 0x181E53EE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E531F0 Offset: 0x1E517F0 VA: 0x181E531F0
	public void CopyTo(Whitelist instance) { }

	// RVA: 0x1E53310 Offset: 0x1E51910 VA: 0x181E53310
	public Whitelist Copy() { }

	// RVA: 0x1E53D40 Offset: 0x1E52340 VA: 0x181E53D40
	public static Whitelist Deserialize(Stream stream) { }

	// RVA: 0x1E53470 Offset: 0x1E51A70 VA: 0x181E53470
	public static Whitelist DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E53780 Offset: 0x1E51D80 VA: 0x181E53780
	public static Whitelist DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E53DC0 Offset: 0x1E523C0 VA: 0x181E53DC0
	public static Whitelist Deserialize(byte[] buffer) { }

	// RVA: 0x1E54030 Offset: 0x1E52630 VA: 0x181E54030
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E54760 Offset: 0x1E52D60 VA: 0x181E54760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E54780 Offset: 0x1E52D80 VA: 0x181E54780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Whitelist previous) { }

	// RVA: 0x1E54050 Offset: 0x1E52650 VA: 0x181E54050 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E53C40 Offset: 0x1E52240 VA: 0x181E53C40
	public static Whitelist Deserialize(byte[] buffer, Whitelist instance, bool isDelta = False) { }

	// RVA: 0x1E53A80 Offset: 0x1E52080 VA: 0x181E53A80
	public static Whitelist Deserialize(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E534F0 Offset: 0x1E51AF0 VA: 0x181E534F0
	public static Whitelist DeserializeLengthDelimited(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E53810 Offset: 0x1E51E10 VA: 0x181E53810
	public static Whitelist DeserializeLength(Stream stream, int length, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E54230 Offset: 0x1E52830 VA: 0x181E54230
	public static void SerializeDelta(Stream stream, Whitelist instance, Whitelist previous) { }

	// RVA: 0x1E545C0 Offset: 0x1E52BC0 VA: 0x181E545C0
	public static void Serialize(Stream stream, Whitelist instance) { }

	// RVA: 0x1E54750 Offset: 0x1E52D50 VA: 0x181E54750
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E54760 Offset: 0x1E52D60 VA: 0x181E54760
	public void ToProto(Stream stream) { }

	// RVA: 0x1E544B0 Offset: 0x1E52AB0 VA: 0x181E544B0
	public static byte[] SerializeToBytes(Whitelist instance) { }

	// RVA: 0x1E543C0 Offset: 0x1E529C0 VA: 0x181E543C0
	public static void SerializeLengthDelimited(Stream stream, Whitelist instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

