public class Spray : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6430
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong sprayedBy; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1DBE440 Offset: 0x1DBCA40 VA: 0x181DBE440
	public static void ResetToPool(Spray instance) { }

	// RVA: 0x1DBE3B0 Offset: 0x1DBC9B0 VA: 0x181DBE3B0
	public void ResetToPool() { }

	// RVA: 0x1DBE110 Offset: 0x1DBC710 VA: 0x181DBE110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBD2E0 Offset: 0x1DBB8E0 VA: 0x181DBD2E0
	public void CopyTo(Spray instance) { }

	// RVA: 0x1DBD310 Offset: 0x1DBB910 VA: 0x181DBD310
	public Spray Copy() { }

	// RVA: 0x1DBDCE0 Offset: 0x1DBC2E0 VA: 0x181DBDCE0
	public static Spray Deserialize(Stream stream) { }

	// RVA: 0x1DBD5D0 Offset: 0x1DBBBD0 VA: 0x181DBD5D0
	public static Spray DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBD880 Offset: 0x1DBBE80 VA: 0x181DBD880
	public static Spray DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBDEA0 Offset: 0x1DBC4A0 VA: 0x181DBDEA0
	public static Spray Deserialize(byte[] buffer) { }

	// RVA: 0x1DBE210 Offset: 0x1DBC810 VA: 0x181DBE210
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBE900 Offset: 0x1DBCF00 VA: 0x181DBE900 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBE920 Offset: 0x1DBCF20 VA: 0x181DBE920 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spray previous) { }

	// RVA: 0x1DBE390 Offset: 0x1DBC990 VA: 0x181DBE390 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBDA90 Offset: 0x1DBC090 VA: 0x181DBDA90
	public static Spray Deserialize(byte[] buffer, Spray instance, bool isDelta = False) { }

	// RVA: 0x1DBD910 Offset: 0x1DBBF10 VA: 0x181DBD910
	public static Spray Deserialize(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBD380 Offset: 0x1DBB980 VA: 0x181DBD380
	public static Spray DeserializeLengthDelimited(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBD650 Offset: 0x1DBBC50 VA: 0x181DBD650
	public static Spray DeserializeLength(Stream stream, int length, Spray instance, bool isDelta) { }

	// RVA: 0x1DBE4D0 Offset: 0x1DBCAD0 VA: 0x181DBE4D0
	public static void SerializeDelta(Stream stream, Spray instance, Spray previous) { }

	// RVA: 0x1DBE7F0 Offset: 0x1DBCDF0 VA: 0x181DBE7F0
	public static void Serialize(Stream stream, Spray instance) { }

	// RVA: 0x1DBE8F0 Offset: 0x1DBCEF0 VA: 0x181DBE8F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBE900 Offset: 0x1DBCF00 VA: 0x181DBE900
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBE6E0 Offset: 0x1DBCCE0 VA: 0x181DBE6E0
	public static byte[] SerializeToBytes(Spray instance) { }

	// RVA: 0x1DBE630 Offset: 0x1DBCC30 VA: 0x181DBE630
	public static void SerializeLengthDelimited(Stream stream, Spray instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

