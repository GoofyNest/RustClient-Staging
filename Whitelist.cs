public class Whitelist : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6308
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> users; // 0x18

	// Methods

	// RVA: 0x1E53EB0 Offset: 0x1E524B0 VA: 0x181E53EB0
	public static void ResetToPool(Whitelist instance) { }

	// RVA: 0x1E53F90 Offset: 0x1E52590 VA: 0x181E53F90
	public void ResetToPool() { }

	// RVA: 0x1E53D20 Offset: 0x1E52320 VA: 0x181E53D20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E53030 Offset: 0x1E51630 VA: 0x181E53030
	public void CopyTo(Whitelist instance) { }

	// RVA: 0x1E53150 Offset: 0x1E51750 VA: 0x181E53150
	public Whitelist Copy() { }

	// RVA: 0x1E53B80 Offset: 0x1E52180 VA: 0x181E53B80
	public static Whitelist Deserialize(Stream stream) { }

	// RVA: 0x1E532B0 Offset: 0x1E518B0 VA: 0x181E532B0
	public static Whitelist DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E535C0 Offset: 0x1E51BC0 VA: 0x181E535C0
	public static Whitelist DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E53C00 Offset: 0x1E52200 VA: 0x181E53C00
	public static Whitelist Deserialize(byte[] buffer) { }

	// RVA: 0x1E53E70 Offset: 0x1E52470 VA: 0x181E53E70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E545A0 Offset: 0x1E52BA0 VA: 0x181E545A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E545C0 Offset: 0x1E52BC0 VA: 0x181E545C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Whitelist previous) { }

	// RVA: 0x1E53E90 Offset: 0x1E52490 VA: 0x181E53E90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E53A80 Offset: 0x1E52080 VA: 0x181E53A80
	public static Whitelist Deserialize(byte[] buffer, Whitelist instance, bool isDelta = False) { }

	// RVA: 0x1E538C0 Offset: 0x1E51EC0 VA: 0x181E538C0
	public static Whitelist Deserialize(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E53330 Offset: 0x1E51930 VA: 0x181E53330
	public static Whitelist DeserializeLengthDelimited(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E53650 Offset: 0x1E51C50 VA: 0x181E53650
	public static Whitelist DeserializeLength(Stream stream, int length, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E54070 Offset: 0x1E52670 VA: 0x181E54070
	public static void SerializeDelta(Stream stream, Whitelist instance, Whitelist previous) { }

	// RVA: 0x1E54400 Offset: 0x1E52A00 VA: 0x181E54400
	public static void Serialize(Stream stream, Whitelist instance) { }

	// RVA: 0x1E54590 Offset: 0x1E52B90 VA: 0x181E54590
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E545A0 Offset: 0x1E52BA0 VA: 0x181E545A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E542F0 Offset: 0x1E528F0 VA: 0x181E542F0
	public static byte[] SerializeToBytes(Whitelist instance) { }

	// RVA: 0x1E54200 Offset: 0x1E52800 VA: 0x181E54200
	public static void SerializeLengthDelimited(Stream stream, Whitelist instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

