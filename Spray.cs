public class Spray : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6430
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong sprayedBy; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1DBE280 Offset: 0x1DBC880 VA: 0x181DBE280
	public static void ResetToPool(Spray instance) { }

	// RVA: 0x1DBE1F0 Offset: 0x1DBC7F0 VA: 0x181DBE1F0
	public void ResetToPool() { }

	// RVA: 0x1DBDF50 Offset: 0x1DBC550 VA: 0x181DBDF50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBD120 Offset: 0x1DBB720 VA: 0x181DBD120
	public void CopyTo(Spray instance) { }

	// RVA: 0x1DBD150 Offset: 0x1DBB750 VA: 0x181DBD150
	public Spray Copy() { }

	// RVA: 0x1DBDB20 Offset: 0x1DBC120 VA: 0x181DBDB20
	public static Spray Deserialize(Stream stream) { }

	// RVA: 0x1DBD410 Offset: 0x1DBBA10 VA: 0x181DBD410
	public static Spray DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBD6C0 Offset: 0x1DBBCC0 VA: 0x181DBD6C0
	public static Spray DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBDCE0 Offset: 0x1DBC2E0 VA: 0x181DBDCE0
	public static Spray Deserialize(byte[] buffer) { }

	// RVA: 0x1DBE050 Offset: 0x1DBC650 VA: 0x181DBE050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBE740 Offset: 0x1DBCD40 VA: 0x181DBE740 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBE760 Offset: 0x1DBCD60 VA: 0x181DBE760 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spray previous) { }

	// RVA: 0x1DBE1D0 Offset: 0x1DBC7D0 VA: 0x181DBE1D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBD8D0 Offset: 0x1DBBED0 VA: 0x181DBD8D0
	public static Spray Deserialize(byte[] buffer, Spray instance, bool isDelta = False) { }

	// RVA: 0x1DBD750 Offset: 0x1DBBD50 VA: 0x181DBD750
	public static Spray Deserialize(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBD1C0 Offset: 0x1DBB7C0 VA: 0x181DBD1C0
	public static Spray DeserializeLengthDelimited(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBD490 Offset: 0x1DBBA90 VA: 0x181DBD490
	public static Spray DeserializeLength(Stream stream, int length, Spray instance, bool isDelta) { }

	// RVA: 0x1DBE310 Offset: 0x1DBC910 VA: 0x181DBE310
	public static void SerializeDelta(Stream stream, Spray instance, Spray previous) { }

	// RVA: 0x1DBE630 Offset: 0x1DBCC30 VA: 0x181DBE630
	public static void Serialize(Stream stream, Spray instance) { }

	// RVA: 0x1DBE730 Offset: 0x1DBCD30 VA: 0x181DBE730
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBE740 Offset: 0x1DBCD40 VA: 0x181DBE740
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBE520 Offset: 0x1DBCB20 VA: 0x181DBE520
	public static byte[] SerializeToBytes(Spray instance) { }

	// RVA: 0x1DBE470 Offset: 0x1DBCA70 VA: 0x181DBE470
	public static void SerializeLengthDelimited(Stream stream, Spray instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

