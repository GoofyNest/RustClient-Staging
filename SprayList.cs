public class SprayList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6432
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18

	// Methods

	// RVA: 0x1DBD450 Offset: 0x1DBBA50 VA: 0x181DBD450
	public static void ResetToPool(SprayList instance) { }

	// RVA: 0x1DBD2A0 Offset: 0x1DBB8A0 VA: 0x181DBD2A0
	public void ResetToPool() { }

	// RVA: 0x1DBD020 Offset: 0x1DBB620 VA: 0x181DBD020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBC380 Offset: 0x1DBA980 VA: 0x181DBC380
	public void CopyTo(SprayList instance) { }

	// RVA: 0x1DBC4B0 Offset: 0x1DBAAB0 VA: 0x181DBC4B0
	public SprayList Copy() { }

	// RVA: 0x1DBCFA0 Offset: 0x1DBB5A0 VA: 0x181DBCFA0
	public static SprayList Deserialize(Stream stream) { }

	// RVA: 0x1DBC890 Offset: 0x1DBAE90 VA: 0x181DBC890
	public static SprayList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBC910 Offset: 0x1DBAF10 VA: 0x181DBC910
	public static SprayList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBCE80 Offset: 0x1DBB480 VA: 0x181DBCE80
	public static SprayList Deserialize(byte[] buffer) { }

	// RVA: 0x1DBD260 Offset: 0x1DBB860 VA: 0x181DBD260
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBDB90 Offset: 0x1DBC190 VA: 0x181DBDB90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBDBB0 Offset: 0x1DBC1B0 VA: 0x181DBDBB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayList previous) { }

	// RVA: 0x1DBD280 Offset: 0x1DBB880 VA: 0x181DBD280 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBCBF0 Offset: 0x1DBB1F0 VA: 0x181DBCBF0
	public static SprayList Deserialize(byte[] buffer, SprayList instance, bool isDelta = False) { }

	// RVA: 0x1DBCCF0 Offset: 0x1DBB2F0 VA: 0x181DBCCF0
	public static SprayList Deserialize(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBC620 Offset: 0x1DBAC20 VA: 0x181DBC620
	public static SprayList DeserializeLengthDelimited(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBC9A0 Offset: 0x1DBAFA0 VA: 0x181DBC9A0
	public static SprayList DeserializeLength(Stream stream, int length, SprayList instance, bool isDelta) { }

	// RVA: 0x1DBD600 Offset: 0x1DBBC00 VA: 0x181DBD600
	public static void SerializeDelta(Stream stream, SprayList instance, SprayList previous) { }

	// RVA: 0x1DBD9A0 Offset: 0x1DBBFA0 VA: 0x181DBD9A0
	public static void Serialize(Stream stream, SprayList instance) { }

	// RVA: 0x1DBDB80 Offset: 0x1DBC180 VA: 0x181DBDB80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBDB90 Offset: 0x1DBC190 VA: 0x181DBDB90
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBD890 Offset: 0x1DBBE90 VA: 0x181DBD890
	public static byte[] SerializeToBytes(SprayList instance) { }

	// RVA: 0x1DBD7E0 Offset: 0x1DBBDE0 VA: 0x181DBD7E0
	public static void SerializeLengthDelimited(Stream stream, SprayList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

