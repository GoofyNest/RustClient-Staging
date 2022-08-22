public class SprayList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6432
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18

	// Methods

	// RVA: 0x1DBC9A0 Offset: 0x1DBAFA0 VA: 0x181DBC9A0
	public static void ResetToPool(SprayList instance) { }

	// RVA: 0x1DBC7F0 Offset: 0x1DBADF0 VA: 0x181DBC7F0
	public void ResetToPool() { }

	// RVA: 0x1DBC570 Offset: 0x1DBAB70 VA: 0x181DBC570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBB8D0 Offset: 0x1DB9ED0 VA: 0x181DBB8D0
	public void CopyTo(SprayList instance) { }

	// RVA: 0x1DBBA00 Offset: 0x1DBA000 VA: 0x181DBBA00
	public SprayList Copy() { }

	// RVA: 0x1DBC4F0 Offset: 0x1DBAAF0 VA: 0x181DBC4F0
	public static SprayList Deserialize(Stream stream) { }

	// RVA: 0x1DBBDE0 Offset: 0x1DBA3E0 VA: 0x181DBBDE0
	public static SprayList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBBE60 Offset: 0x1DBA460 VA: 0x181DBBE60
	public static SprayList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBC3D0 Offset: 0x1DBA9D0 VA: 0x181DBC3D0
	public static SprayList Deserialize(byte[] buffer) { }

	// RVA: 0x1DBC7B0 Offset: 0x1DBADB0 VA: 0x181DBC7B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBD0E0 Offset: 0x1DBB6E0 VA: 0x181DBD0E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBD100 Offset: 0x1DBB700 VA: 0x181DBD100 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayList previous) { }

	// RVA: 0x1DBC7D0 Offset: 0x1DBADD0 VA: 0x181DBC7D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBC140 Offset: 0x1DBA740 VA: 0x181DBC140
	public static SprayList Deserialize(byte[] buffer, SprayList instance, bool isDelta = False) { }

	// RVA: 0x1DBC240 Offset: 0x1DBA840 VA: 0x181DBC240
	public static SprayList Deserialize(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBBB70 Offset: 0x1DBA170 VA: 0x181DBBB70
	public static SprayList DeserializeLengthDelimited(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBBEF0 Offset: 0x1DBA4F0 VA: 0x181DBBEF0
	public static SprayList DeserializeLength(Stream stream, int length, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBCB50 Offset: 0x1DBB150 VA: 0x181DBCB50
	public static void SerializeDelta(Stream stream, SprayList instance, SprayList previous) { }

	// RVA: 0x1DBCEF0 Offset: 0x1DBB4F0 VA: 0x181DBCEF0
	public static void Serialize(Stream stream, SprayList instance) { }

	// RVA: 0x1DBD0D0 Offset: 0x1DBB6D0 VA: 0x181DBD0D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBD0E0 Offset: 0x1DBB6E0 VA: 0x181DBD0E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBCDE0 Offset: 0x1DBB3E0 VA: 0x181DBCDE0
	public static byte[] SerializeToBytes(SprayList instance) { }

	// RVA: 0x1DBCD30 Offset: 0x1DBB330 VA: 0x181DBCD30
	public static void SerializeLengthDelimited(Stream stream, SprayList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

