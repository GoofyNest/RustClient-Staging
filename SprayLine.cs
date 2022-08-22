public class SprayLine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6431
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18
	public Vector3 colour; // 0x20
	public float width; // 0x2C
	public uint editingPlayer; // 0x30

	// Methods

	// RVA: 0x1DBAB60 Offset: 0x1DB9160 VA: 0x181DBAB60
	public static void ResetToPool(SprayLine instance) { }

	// RVA: 0x1DBAD60 Offset: 0x1DB9360 VA: 0x181DBAD60
	public void ResetToPool() { }

	// RVA: 0x1DBA860 Offset: 0x1DB8E60 VA: 0x181DBA860 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9310 Offset: 0x1DB7910 VA: 0x181DB9310
	public void CopyTo(SprayLine instance) { }

	// RVA: 0x1DB9460 Offset: 0x1DB7A60 VA: 0x181DB9460
	public SprayLine Copy() { }

	// RVA: 0x1DBA060 Offset: 0x1DB8660 VA: 0x181DBA060
	public static SprayLine Deserialize(Stream stream) { }

	// RVA: 0x1DB9600 Offset: 0x1DB7C00 VA: 0x181DB9600
	public static SprayLine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB9CB0 Offset: 0x1DB82B0 VA: 0x181DB9CB0
	public static SprayLine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBA2E0 Offset: 0x1DB88E0 VA: 0x181DBA2E0
	public static SprayLine Deserialize(byte[] buffer) { }

	// RVA: 0x1DBA8E0 Offset: 0x1DB8EE0 VA: 0x181DBA8E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBB890 Offset: 0x1DB9E90 VA: 0x181DBB890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBB8B0 Offset: 0x1DB9EB0 VA: 0x181DBB8B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayLine previous) { }

	// RVA: 0x1DBAB40 Offset: 0x1DB9140 VA: 0x181DBAB40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB9D40 Offset: 0x1DB8340 VA: 0x181DB9D40
	public static SprayLine Deserialize(byte[] buffer, SprayLine instance, bool isDelta = False) { }

	// RVA: 0x1DBA5F0 Offset: 0x1DB8BF0 VA: 0x181DBA5F0
	public static SprayLine Deserialize(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB9680 Offset: 0x1DB7C80 VA: 0x181DB9680
	public static SprayLine DeserializeLengthDelimited(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB99B0 Offset: 0x1DB7FB0 VA: 0x181DB99B0
	public static SprayLine DeserializeLength(Stream stream, int length, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DBAF60 Offset: 0x1DB9560 VA: 0x181DBAF60
	public static void SerializeDelta(Stream stream, SprayLine instance, SprayLine previous) { }

	// RVA: 0x1DBB570 Offset: 0x1DB9B70 VA: 0x181DBB570
	public static void Serialize(Stream stream, SprayLine instance) { }

	// RVA: 0x1DBB880 Offset: 0x1DB9E80 VA: 0x181DBB880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBB890 Offset: 0x1DB9E90 VA: 0x181DBB890
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBB460 Offset: 0x1DB9A60 VA: 0x181DBB460
	public static byte[] SerializeToBytes(SprayLine instance) { }

	// RVA: 0x1DBB3B0 Offset: 0x1DB99B0 VA: 0x181DBB3B0
	public static void SerializeLengthDelimited(Stream stream, SprayLine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

