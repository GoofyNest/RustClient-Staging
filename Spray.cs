public class Spray : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6430
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong sprayedBy; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1DBED30 Offset: 0x1DBD330 VA: 0x181DBED30
	public static void ResetToPool(Spray instance) { }

	// RVA: 0x1DBECA0 Offset: 0x1DBD2A0 VA: 0x181DBECA0
	public void ResetToPool() { }

	// RVA: 0x1DBEA00 Offset: 0x1DBD000 VA: 0x181DBEA00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBDBD0 Offset: 0x1DBC1D0 VA: 0x181DBDBD0
	public void CopyTo(Spray instance) { }

	// RVA: 0x1DBDC00 Offset: 0x1DBC200 VA: 0x181DBDC00
	public Spray Copy() { }

	// RVA: 0x1DBE5D0 Offset: 0x1DBCBD0 VA: 0x181DBE5D0
	public static Spray Deserialize(Stream stream) { }

	// RVA: 0x1DBDEC0 Offset: 0x1DBC4C0 VA: 0x181DBDEC0
	public static Spray DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBE170 Offset: 0x1DBC770 VA: 0x181DBE170
	public static Spray DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBE790 Offset: 0x1DBCD90 VA: 0x181DBE790
	public static Spray Deserialize(byte[] buffer) { }

	// RVA: 0x1DBEB00 Offset: 0x1DBD100 VA: 0x181DBEB00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBF1F0 Offset: 0x1DBD7F0 VA: 0x181DBF1F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBF210 Offset: 0x1DBD810 VA: 0x181DBF210 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spray previous) { }

	// RVA: 0x1DBEC80 Offset: 0x1DBD280 VA: 0x181DBEC80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBE380 Offset: 0x1DBC980 VA: 0x181DBE380
	public static Spray Deserialize(byte[] buffer, Spray instance, bool isDelta = False) { }

	// RVA: 0x1DBE200 Offset: 0x1DBC800 VA: 0x181DBE200
	public static Spray Deserialize(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBDC70 Offset: 0x1DBC270 VA: 0x181DBDC70
	public static Spray DeserializeLengthDelimited(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DBDF40 Offset: 0x1DBC540 VA: 0x181DBDF40
	public static Spray DeserializeLength(Stream stream, int length, Spray instance, bool isDelta) { }

	// RVA: 0x1DBEDC0 Offset: 0x1DBD3C0 VA: 0x181DBEDC0
	public static void SerializeDelta(Stream stream, Spray instance, Spray previous) { }

	// RVA: 0x1DBF0E0 Offset: 0x1DBD6E0 VA: 0x181DBF0E0
	public static void Serialize(Stream stream, Spray instance) { }

	// RVA: 0x1DBF1E0 Offset: 0x1DBD7E0 VA: 0x181DBF1E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBF1F0 Offset: 0x1DBD7F0 VA: 0x181DBF1F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBEFD0 Offset: 0x1DBD5D0 VA: 0x181DBEFD0
	public static byte[] SerializeToBytes(Spray instance) { }

	// RVA: 0x1DBEF20 Offset: 0x1DBD520 VA: 0x181DBEF20
	public static void SerializeLengthDelimited(Stream stream, Spray instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

