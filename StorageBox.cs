public class StorageBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6311
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1DC0F50 Offset: 0x1DBF550 VA: 0x181DC0F50
	public static void ResetToPool(StorageBox instance) { }

	// RVA: 0x1DC0FF0 Offset: 0x1DBF5F0 VA: 0x181DC0FF0
	public void ResetToPool() { }

	// RVA: 0x1DC0DF0 Offset: 0x1DBF3F0 VA: 0x181DC0DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0350 Offset: 0x1DBE950 VA: 0x181DC0350
	public void CopyTo(StorageBox instance) { }

	// RVA: 0x1DC03C0 Offset: 0x1DBE9C0 VA: 0x181DC03C0
	public StorageBox Copy() { }

	// RVA: 0x1DC0C70 Offset: 0x1DBF270 VA: 0x181DC0C70
	public static StorageBox Deserialize(Stream stream) { }

	// RVA: 0x1DC0490 Offset: 0x1DBEA90 VA: 0x181DC0490
	public static StorageBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC0750 Offset: 0x1DBED50 VA: 0x181DC0750
	public static StorageBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC09F0 Offset: 0x1DBEFF0 VA: 0x181DC09F0
	public static StorageBox Deserialize(byte[] buffer) { }

	// RVA: 0x1DC0F10 Offset: 0x1DBF510 VA: 0x181DC0F10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC1580 Offset: 0x1DBFB80 VA: 0x181DC1580 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC15A0 Offset: 0x1DBFBA0 VA: 0x181DC15A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StorageBox previous) { }

	// RVA: 0x1DC0F30 Offset: 0x1DBF530 VA: 0x181DC0F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC0CF0 Offset: 0x1DBF2F0 VA: 0x181DC0CF0
	public static StorageBox Deserialize(byte[] buffer, StorageBox instance, bool isDelta = False) { }

	// RVA: 0x1DC0B10 Offset: 0x1DBF110 VA: 0x181DC0B10
	public static StorageBox Deserialize(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0510 Offset: 0x1DBEB10 VA: 0x181DC0510
	public static StorageBox DeserializeLengthDelimited(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC07E0 Offset: 0x1DBEDE0 VA: 0x181DC07E0
	public static StorageBox DeserializeLength(Stream stream, int length, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC1090 Offset: 0x1DBF690 VA: 0x181DC1090
	public static void SerializeDelta(Stream stream, StorageBox instance, StorageBox previous) { }

	// RVA: 0x1DC13F0 Offset: 0x1DBF9F0 VA: 0x181DC13F0
	public static void Serialize(Stream stream, StorageBox instance) { }

	// RVA: 0x1DC1570 Offset: 0x1DBFB70 VA: 0x181DC1570
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC1580 Offset: 0x1DBFB80 VA: 0x181DC1580
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC12E0 Offset: 0x1DBF8E0 VA: 0x181DC12E0
	public static byte[] SerializeToBytes(StorageBox instance) { }

	// RVA: 0x1DC1230 Offset: 0x1DBF830 VA: 0x181DC1230
	public static void SerializeLengthDelimited(Stream stream, StorageBox instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

