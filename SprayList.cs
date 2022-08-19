public class SprayList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6432
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18

	// Methods

	// RVA: 0x1DBCB60 Offset: 0x1DBB160 VA: 0x181DBCB60
	public static void ResetToPool(SprayList instance) { }

	// RVA: 0x1DBC9B0 Offset: 0x1DBAFB0 VA: 0x181DBC9B0
	public void ResetToPool() { }

	// RVA: 0x1DBC730 Offset: 0x1DBAD30 VA: 0x181DBC730 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBBA90 Offset: 0x1DBA090 VA: 0x181DBBA90
	public void CopyTo(SprayList instance) { }

	// RVA: 0x1DBBBC0 Offset: 0x1DBA1C0 VA: 0x181DBBBC0
	public SprayList Copy() { }

	// RVA: 0x1DBC6B0 Offset: 0x1DBACB0 VA: 0x181DBC6B0
	public static SprayList Deserialize(Stream stream) { }

	// RVA: 0x1DBBFA0 Offset: 0x1DBA5A0 VA: 0x181DBBFA0
	public static SprayList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBC020 Offset: 0x1DBA620 VA: 0x181DBC020
	public static SprayList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBC590 Offset: 0x1DBAB90 VA: 0x181DBC590
	public static SprayList Deserialize(byte[] buffer) { }

	// RVA: 0x1DBC970 Offset: 0x1DBAF70 VA: 0x181DBC970
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBD2A0 Offset: 0x1DBB8A0 VA: 0x181DBD2A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBD2C0 Offset: 0x1DBB8C0 VA: 0x181DBD2C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayList previous) { }

	// RVA: 0x1DBC990 Offset: 0x1DBAF90 VA: 0x181DBC990 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBC300 Offset: 0x1DBA900 VA: 0x181DBC300
	public static SprayList Deserialize(byte[] buffer, SprayList instance, bool isDelta = False) { }

	// RVA: 0x1DBC400 Offset: 0x1DBAA00 VA: 0x181DBC400
	public static SprayList Deserialize(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBBD30 Offset: 0x1DBA330 VA: 0x181DBBD30
	public static SprayList DeserializeLengthDelimited(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBC0B0 Offset: 0x1DBA6B0 VA: 0x181DBC0B0
	public static SprayList DeserializeLength(Stream stream, int length, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBCD10 Offset: 0x1DBB310 VA: 0x181DBCD10
	public static void SerializeDelta(Stream stream, SprayList instance, SprayList previous) { }

	// RVA: 0x1DBD0B0 Offset: 0x1DBB6B0 VA: 0x181DBD0B0
	public static void Serialize(Stream stream, SprayList instance) { }

	// RVA: 0x1DBD290 Offset: 0x1DBB890 VA: 0x181DBD290
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBD2A0 Offset: 0x1DBB8A0 VA: 0x181DBD2A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBCFA0 Offset: 0x1DBB5A0 VA: 0x181DBCFA0
	public static byte[] SerializeToBytes(SprayList instance) { }

	// RVA: 0x1DBCEF0 Offset: 0x1DBB4F0 VA: 0x181DBCEF0
	public static void SerializeLengthDelimited(Stream stream, SprayList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

