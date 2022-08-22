public class StorageBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6311
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1DC0C90 Offset: 0x1DBF290 VA: 0x181DC0C90
	public static void ResetToPool(StorageBox instance) { }

	// RVA: 0x1DC0D30 Offset: 0x1DBF330 VA: 0x181DC0D30
	public void ResetToPool() { }

	// RVA: 0x1DC0B30 Offset: 0x1DBF130 VA: 0x181DC0B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0090 Offset: 0x1DBE690 VA: 0x181DC0090
	public void CopyTo(StorageBox instance) { }

	// RVA: 0x1DC0100 Offset: 0x1DBE700 VA: 0x181DC0100
	public StorageBox Copy() { }

	// RVA: 0x1DC09B0 Offset: 0x1DBEFB0 VA: 0x181DC09B0
	public static StorageBox Deserialize(Stream stream) { }

	// RVA: 0x1DC01D0 Offset: 0x1DBE7D0 VA: 0x181DC01D0
	public static StorageBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC0490 Offset: 0x1DBEA90 VA: 0x181DC0490
	public static StorageBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC0730 Offset: 0x1DBED30 VA: 0x181DC0730
	public static StorageBox Deserialize(byte[] buffer) { }

	// RVA: 0x1DC0C50 Offset: 0x1DBF250 VA: 0x181DC0C50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC12C0 Offset: 0x1DBF8C0 VA: 0x181DC12C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC12E0 Offset: 0x1DBF8E0 VA: 0x181DC12E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StorageBox previous) { }

	// RVA: 0x1DC0C70 Offset: 0x1DBF270 VA: 0x181DC0C70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC0A30 Offset: 0x1DBF030 VA: 0x181DC0A30
	public static StorageBox Deserialize(byte[] buffer, StorageBox instance, bool isDelta = False) { }

	// RVA: 0x1DC0850 Offset: 0x1DBEE50 VA: 0x181DC0850
	public static StorageBox Deserialize(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0250 Offset: 0x1DBE850 VA: 0x181DC0250
	public static StorageBox DeserializeLengthDelimited(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0520 Offset: 0x1DBEB20 VA: 0x181DC0520
	public static StorageBox DeserializeLength(Stream stream, int length, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0DD0 Offset: 0x1DBF3D0 VA: 0x181DC0DD0
	public static void SerializeDelta(Stream stream, StorageBox instance, StorageBox previous) { }

	// RVA: 0x1DC1130 Offset: 0x1DBF730 VA: 0x181DC1130
	public static void Serialize(Stream stream, StorageBox instance) { }

	// RVA: 0x1DC12B0 Offset: 0x1DBF8B0 VA: 0x181DC12B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC12C0 Offset: 0x1DBF8C0 VA: 0x181DC12C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC1020 Offset: 0x1DBF620 VA: 0x181DC1020
	public static byte[] SerializeToBytes(StorageBox instance) { }

	// RVA: 0x1DC0F70 Offset: 0x1DBF570 VA: 0x181DC0F70
	public static void SerializeLengthDelimited(Stream stream, StorageBox instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

