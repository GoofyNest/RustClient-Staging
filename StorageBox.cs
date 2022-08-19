public class StorageBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6311
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1DC0E50 Offset: 0x1DBF450 VA: 0x181DC0E50
	public static void ResetToPool(StorageBox instance) { }

	// RVA: 0x1DC0EF0 Offset: 0x1DBF4F0 VA: 0x181DC0EF0
	public void ResetToPool() { }

	// RVA: 0x1DC0CF0 Offset: 0x1DBF2F0 VA: 0x181DC0CF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0250 Offset: 0x1DBE850 VA: 0x181DC0250
	public void CopyTo(StorageBox instance) { }

	// RVA: 0x1DC02C0 Offset: 0x1DBE8C0 VA: 0x181DC02C0
	public StorageBox Copy() { }

	// RVA: 0x1DC0B70 Offset: 0x1DBF170 VA: 0x181DC0B70
	public static StorageBox Deserialize(Stream stream) { }

	// RVA: 0x1DC0390 Offset: 0x1DBE990 VA: 0x181DC0390
	public static StorageBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC0650 Offset: 0x1DBEC50 VA: 0x181DC0650
	public static StorageBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC08F0 Offset: 0x1DBEEF0 VA: 0x181DC08F0
	public static StorageBox Deserialize(byte[] buffer) { }

	// RVA: 0x1DC0E10 Offset: 0x1DBF410 VA: 0x181DC0E10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC1480 Offset: 0x1DBFA80 VA: 0x181DC1480 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC14A0 Offset: 0x1DBFAA0 VA: 0x181DC14A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StorageBox previous) { }

	// RVA: 0x1DC0E30 Offset: 0x1DBF430 VA: 0x181DC0E30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC0BF0 Offset: 0x1DBF1F0 VA: 0x181DC0BF0
	public static StorageBox Deserialize(byte[] buffer, StorageBox instance, bool isDelta = False) { }

	// RVA: 0x1DC0A10 Offset: 0x1DBF010 VA: 0x181DC0A10
	public static StorageBox Deserialize(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0410 Offset: 0x1DBEA10 VA: 0x181DC0410
	public static StorageBox DeserializeLengthDelimited(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC06E0 Offset: 0x1DBECE0 VA: 0x181DC06E0
	public static StorageBox DeserializeLength(Stream stream, int length, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0F90 Offset: 0x1DBF590 VA: 0x181DC0F90
	public static void SerializeDelta(Stream stream, StorageBox instance, StorageBox previous) { }

	// RVA: 0x1DC12F0 Offset: 0x1DBF8F0 VA: 0x181DC12F0
	public static void Serialize(Stream stream, StorageBox instance) { }

	// RVA: 0x1DC1470 Offset: 0x1DBFA70 VA: 0x181DC1470
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC1480 Offset: 0x1DBFA80 VA: 0x181DC1480
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC11E0 Offset: 0x1DBF7E0 VA: 0x181DC11E0
	public static byte[] SerializeToBytes(StorageBox instance) { }

	// RVA: 0x1DC1130 Offset: 0x1DBF730 VA: 0x181DC1130
	public static void SerializeLengthDelimited(Stream stream, StorageBox instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

