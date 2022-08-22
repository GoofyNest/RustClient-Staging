public class SprayList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6432
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18

	// Methods

	// RVA: 0x1DBCC60 Offset: 0x1DBB260 VA: 0x181DBCC60
	public static void ResetToPool(SprayList instance) { }

	// RVA: 0x1DBCAB0 Offset: 0x1DBB0B0 VA: 0x181DBCAB0
	public void ResetToPool() { }

	// RVA: 0x1DBC830 Offset: 0x1DBAE30 VA: 0x181DBC830 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBBB90 Offset: 0x1DBA190 VA: 0x181DBBB90
	public void CopyTo(SprayList instance) { }

	// RVA: 0x1DBBCC0 Offset: 0x1DBA2C0 VA: 0x181DBBCC0
	public SprayList Copy() { }

	// RVA: 0x1DBC7B0 Offset: 0x1DBADB0 VA: 0x181DBC7B0
	public static SprayList Deserialize(Stream stream) { }

	// RVA: 0x1DBC0A0 Offset: 0x1DBA6A0 VA: 0x181DBC0A0
	public static SprayList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBC120 Offset: 0x1DBA720 VA: 0x181DBC120
	public static SprayList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBC690 Offset: 0x1DBAC90 VA: 0x181DBC690
	public static SprayList Deserialize(byte[] buffer) { }

	// RVA: 0x1DBCA70 Offset: 0x1DBB070 VA: 0x181DBCA70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBD3A0 Offset: 0x1DBB9A0 VA: 0x181DBD3A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBD3C0 Offset: 0x1DBB9C0 VA: 0x181DBD3C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayList previous) { }

	// RVA: 0x1DBCA90 Offset: 0x1DBB090 VA: 0x181DBCA90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBC400 Offset: 0x1DBAA00 VA: 0x181DBC400
	public static SprayList Deserialize(byte[] buffer, SprayList instance, bool isDelta = False) { }

	// RVA: 0x1DBC500 Offset: 0x1DBAB00 VA: 0x181DBC500
	public static SprayList Deserialize(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBBE30 Offset: 0x1DBA430 VA: 0x181DBBE30
	public static SprayList DeserializeLengthDelimited(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBC1B0 Offset: 0x1DBA7B0 VA: 0x181DBC1B0
	public static SprayList DeserializeLength(Stream stream, int length, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBCE10 Offset: 0x1DBB410 VA: 0x181DBCE10
	public static void SerializeDelta(Stream stream, SprayList instance, SprayList previous) { }

	// RVA: 0x1DBD1B0 Offset: 0x1DBB7B0 VA: 0x181DBD1B0
	public static void Serialize(Stream stream, SprayList instance) { }

	// RVA: 0x1DBD390 Offset: 0x1DBB990 VA: 0x181DBD390
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBD3A0 Offset: 0x1DBB9A0 VA: 0x181DBD3A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBD0A0 Offset: 0x1DBB6A0 VA: 0x181DBD0A0
	public static byte[] SerializeToBytes(SprayList instance) { }

	// RVA: 0x1DBCFF0 Offset: 0x1DBB5F0 VA: 0x181DBCFF0
	public static void SerializeLengthDelimited(Stream stream, SprayList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

