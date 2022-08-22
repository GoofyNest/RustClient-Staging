public class Spray : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6430
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong sprayedBy; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1DBE540 Offset: 0x1DBCB40 VA: 0x181DBE540
	public static void ResetToPool(Spray instance) { }

	// RVA: 0x1DBE4B0 Offset: 0x1DBCAB0 VA: 0x181DBE4B0
	public void ResetToPool() { }

	// RVA: 0x1DBE210 Offset: 0x1DBC810 VA: 0x181DBE210 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBD3E0 Offset: 0x1DBB9E0 VA: 0x181DBD3E0
	public void CopyTo(Spray instance) { }

	// RVA: 0x1DBD410 Offset: 0x1DBBA10 VA: 0x181DBD410
	public Spray Copy() { }

	// RVA: 0x1DBDDE0 Offset: 0x1DBC3E0 VA: 0x181DBDDE0
	public static Spray Deserialize(Stream stream) { }

	// RVA: 0x1DBD6D0 Offset: 0x1DBBCD0 VA: 0x181DBD6D0
	public static Spray DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBD980 Offset: 0x1DBBF80 VA: 0x181DBD980
	public static Spray DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBDFA0 Offset: 0x1DBC5A0 VA: 0x181DBDFA0
	public static Spray Deserialize(byte[] buffer) { }

	// RVA: 0x1DBE310 Offset: 0x1DBC910 VA: 0x181DBE310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBEA00 Offset: 0x1DBD000 VA: 0x181DBEA00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBEA20 Offset: 0x1DBD020 VA: 0x181DBEA20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spray previous) { }

	// RVA: 0x1DBE490 Offset: 0x1DBCA90 VA: 0x181DBE490 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBDB90 Offset: 0x1DBC190 VA: 0x181DBDB90
	public static Spray Deserialize(byte[] buffer, Spray instance, bool isDelta = False) { }

	// RVA: 0x1DBDA10 Offset: 0x1DBC010 VA: 0x181DBDA10
	public static Spray Deserialize(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBD480 Offset: 0x1DBBA80 VA: 0x181DBD480
	public static Spray DeserializeLengthDelimited(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBD750 Offset: 0x1DBBD50 VA: 0x181DBD750
	public static Spray DeserializeLength(Stream stream, int length, Spray instance, bool isDelta) { }

	// RVA: 0x1DBE5D0 Offset: 0x1DBCBD0 VA: 0x181DBE5D0
	public static void SerializeDelta(Stream stream, Spray instance, Spray previous) { }

	// RVA: 0x1DBE8F0 Offset: 0x1DBCEF0 VA: 0x181DBE8F0
	public static void Serialize(Stream stream, Spray instance) { }

	// RVA: 0x1DBE9F0 Offset: 0x1DBCFF0 VA: 0x181DBE9F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBEA00 Offset: 0x1DBD000 VA: 0x181DBEA00
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBE7E0 Offset: 0x1DBCDE0 VA: 0x181DBE7E0
	public static byte[] SerializeToBytes(Spray instance) { }

	// RVA: 0x1DBE730 Offset: 0x1DBCD30 VA: 0x181DBE730
	public static void SerializeLengthDelimited(Stream stream, Spray instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

