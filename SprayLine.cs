public class SprayLine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6431
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18
	public Vector3 colour; // 0x20
	public float width; // 0x2C
	public uint editingPlayer; // 0x30

	// Methods

	// RVA: 0x1DBAD20 Offset: 0x1DB9320 VA: 0x181DBAD20
	public static void ResetToPool(SprayLine instance) { }

	// RVA: 0x1DBAF20 Offset: 0x1DB9520 VA: 0x181DBAF20
	public void ResetToPool() { }

	// RVA: 0x1DBAA20 Offset: 0x1DB9020 VA: 0x181DBAA20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB94D0 Offset: 0x1DB7AD0 VA: 0x181DB94D0
	public void CopyTo(SprayLine instance) { }

	// RVA: 0x1DB9620 Offset: 0x1DB7C20 VA: 0x181DB9620
	public SprayLine Copy() { }

	// RVA: 0x1DBA220 Offset: 0x1DB8820 VA: 0x181DBA220
	public static SprayLine Deserialize(Stream stream) { }

	// RVA: 0x1DB97C0 Offset: 0x1DB7DC0 VA: 0x181DB97C0
	public static SprayLine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB9E70 Offset: 0x1DB8470 VA: 0x181DB9E70
	public static SprayLine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBA4A0 Offset: 0x1DB8AA0 VA: 0x181DBA4A0
	public static SprayLine Deserialize(byte[] buffer) { }

	// RVA: 0x1DBAAA0 Offset: 0x1DB90A0 VA: 0x181DBAAA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBBA50 Offset: 0x1DBA050 VA: 0x181DBBA50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBBA70 Offset: 0x1DBA070 VA: 0x181DBBA70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayLine previous) { }

	// RVA: 0x1DBAD00 Offset: 0x1DB9300 VA: 0x181DBAD00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB9F00 Offset: 0x1DB8500 VA: 0x181DB9F00
	public static SprayLine Deserialize(byte[] buffer, SprayLine instance, bool isDelta = False) { }

	// RVA: 0x1DBA7B0 Offset: 0x1DB8DB0 VA: 0x181DBA7B0
	public static SprayLine Deserialize(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB9840 Offset: 0x1DB7E40 VA: 0x181DB9840
	public static SprayLine DeserializeLengthDelimited(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB9B70 Offset: 0x1DB8170 VA: 0x181DB9B70
	public static SprayLine DeserializeLength(Stream stream, int length, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DBB120 Offset: 0x1DB9720 VA: 0x181DBB120
	public static void SerializeDelta(Stream stream, SprayLine instance, SprayLine previous) { }

	// RVA: 0x1DBB730 Offset: 0x1DB9D30 VA: 0x181DBB730
	public static void Serialize(Stream stream, SprayLine instance) { }

	// RVA: 0x1DBBA40 Offset: 0x1DBA040 VA: 0x181DBBA40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBBA50 Offset: 0x1DBA050 VA: 0x181DBBA50
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBB620 Offset: 0x1DB9C20 VA: 0x181DBB620
	public static byte[] SerializeToBytes(SprayLine instance) { }

	// RVA: 0x1DBB570 Offset: 0x1DB9B70 VA: 0x181DBB570
	public static void SerializeLengthDelimited(Stream stream, SprayLine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

