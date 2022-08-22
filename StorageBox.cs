public class StorageBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6311
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1DC1740 Offset: 0x1DBFD40 VA: 0x181DC1740
	public static void ResetToPool(StorageBox instance) { }

	// RVA: 0x1DC17E0 Offset: 0x1DBFDE0 VA: 0x181DC17E0
	public void ResetToPool() { }

	// RVA: 0x1DC15E0 Offset: 0x1DBFBE0 VA: 0x181DC15E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC0B40 Offset: 0x1DBF140 VA: 0x181DC0B40
	public void CopyTo(StorageBox instance) { }

	// RVA: 0x1DC0BB0 Offset: 0x1DBF1B0 VA: 0x181DC0BB0
	public StorageBox Copy() { }

	// RVA: 0x1DC1460 Offset: 0x1DBFA60 VA: 0x181DC1460
	public static StorageBox Deserialize(Stream stream) { }

	// RVA: 0x1DC0C80 Offset: 0x1DBF280 VA: 0x181DC0C80
	public static StorageBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC0F40 Offset: 0x1DBF540 VA: 0x181DC0F40
	public static StorageBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC11E0 Offset: 0x1DBF7E0 VA: 0x181DC11E0
	public static StorageBox Deserialize(byte[] buffer) { }

	// RVA: 0x1DC1700 Offset: 0x1DBFD00 VA: 0x181DC1700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC1D70 Offset: 0x1DC0370 VA: 0x181DC1D70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC1D90 Offset: 0x1DC0390 VA: 0x181DC1D90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StorageBox previous) { }

	// RVA: 0x1DC1720 Offset: 0x1DBFD20 VA: 0x181DC1720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC14E0 Offset: 0x1DBFAE0 VA: 0x181DC14E0
	public static StorageBox Deserialize(byte[] buffer, StorageBox instance, bool isDelta = False) { }

	// RVA: 0x1DC1300 Offset: 0x1DBF900 VA: 0x181DC1300
	public static StorageBox Deserialize(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0D00 Offset: 0x1DBF300 VA: 0x181DC0D00
	public static StorageBox DeserializeLengthDelimited(Stream stream, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC0FD0 Offset: 0x1DBF5D0 VA: 0x181DC0FD0
	public static StorageBox DeserializeLength(Stream stream, int length, StorageBox instance, bool isDelta) { }

	// RVA: 0x1DC1880 Offset: 0x1DBFE80 VA: 0x181DC1880
	public static void SerializeDelta(Stream stream, StorageBox instance, StorageBox previous) { }

	// RVA: 0x1DC1BE0 Offset: 0x1DC01E0 VA: 0x181DC1BE0
	public static void Serialize(Stream stream, StorageBox instance) { }

	// RVA: 0x1DC1D60 Offset: 0x1DC0360 VA: 0x181DC1D60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC1D70 Offset: 0x1DC0370 VA: 0x181DC1D70
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC1AD0 Offset: 0x1DC00D0 VA: 0x181DC1AD0
	public static byte[] SerializeToBytes(StorageBox instance) { }

	// RVA: 0x1DC1A20 Offset: 0x1DC0020 VA: 0x181DC1A20
	public static void SerializeLengthDelimited(Stream stream, StorageBox instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

