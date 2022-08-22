public class SprayLine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6431
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18
	public Vector3 colour; // 0x20
	public float width; // 0x2C
	public uint editingPlayer; // 0x30

	// Methods

	// RVA: 0x1DBB610 Offset: 0x1DB9C10 VA: 0x181DBB610
	public static void ResetToPool(SprayLine instance) { }

	// RVA: 0x1DBB810 Offset: 0x1DB9E10 VA: 0x181DBB810
	public void ResetToPool() { }

	// RVA: 0x1DBB310 Offset: 0x1DB9910 VA: 0x181DBB310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9DC0 Offset: 0x1DB83C0 VA: 0x181DB9DC0
	public void CopyTo(SprayLine instance) { }

	// RVA: 0x1DB9F10 Offset: 0x1DB8510 VA: 0x181DB9F10
	public SprayLine Copy() { }

	// RVA: 0x1DBAB10 Offset: 0x1DB9110 VA: 0x181DBAB10
	public static SprayLine Deserialize(Stream stream) { }

	// RVA: 0x1DBA0B0 Offset: 0x1DB86B0 VA: 0x181DBA0B0
	public static SprayLine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBA760 Offset: 0x1DB8D60 VA: 0x181DBA760
	public static SprayLine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBAD90 Offset: 0x1DB9390 VA: 0x181DBAD90
	public static SprayLine Deserialize(byte[] buffer) { }

	// RVA: 0x1DBB390 Offset: 0x1DB9990 VA: 0x181DBB390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBC340 Offset: 0x1DBA940 VA: 0x181DBC340 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBC360 Offset: 0x1DBA960 VA: 0x181DBC360 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayLine previous) { }

	// RVA: 0x1DBB5F0 Offset: 0x1DB9BF0 VA: 0x181DBB5F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBA7F0 Offset: 0x1DB8DF0 VA: 0x181DBA7F0
	public static SprayLine Deserialize(byte[] buffer, SprayLine instance, bool isDelta = False) { }

	// RVA: 0x1DBB0A0 Offset: 0x1DB96A0 VA: 0x181DBB0A0
	public static SprayLine Deserialize(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DBA130 Offset: 0x1DB8730 VA: 0x181DBA130
	public static SprayLine DeserializeLengthDelimited(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DBA460 Offset: 0x1DB8A60 VA: 0x181DBA460
	public static SprayLine DeserializeLength(Stream stream, int length, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DBBA10 Offset: 0x1DBA010 VA: 0x181DBBA10
	public static void SerializeDelta(Stream stream, SprayLine instance, SprayLine previous) { }

	// RVA: 0x1DBC020 Offset: 0x1DBA620 VA: 0x181DBC020
	public static void Serialize(Stream stream, SprayLine instance) { }

	// RVA: 0x1DBC330 Offset: 0x1DBA930 VA: 0x181DBC330
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBC340 Offset: 0x1DBA940 VA: 0x181DBC340
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBBF10 Offset: 0x1DBA510 VA: 0x181DBBF10
	public static byte[] SerializeToBytes(SprayLine instance) { }

	// RVA: 0x1DBBE60 Offset: 0x1DBA460 VA: 0x181DBBE60
	public static void SerializeLengthDelimited(Stream stream, SprayLine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

