public class SprayLine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6431
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18
	public Vector3 colour; // 0x20
	public float width; // 0x2C
	public uint editingPlayer; // 0x30

	// Methods

	// RVA: 0x1DBAE20 Offset: 0x1DB9420 VA: 0x181DBAE20
	public static void ResetToPool(SprayLine instance) { }

	// RVA: 0x1DBB020 Offset: 0x1DB9620 VA: 0x181DBB020
	public void ResetToPool() { }

	// RVA: 0x1DBAB20 Offset: 0x1DB9120 VA: 0x181DBAB20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB95D0 Offset: 0x1DB7BD0 VA: 0x181DB95D0
	public void CopyTo(SprayLine instance) { }

	// RVA: 0x1DB9720 Offset: 0x1DB7D20 VA: 0x181DB9720
	public SprayLine Copy() { }

	// RVA: 0x1DBA320 Offset: 0x1DB8920 VA: 0x181DBA320
	public static SprayLine Deserialize(Stream stream) { }

	// RVA: 0x1DB98C0 Offset: 0x1DB7EC0 VA: 0x181DB98C0
	public static SprayLine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB9F70 Offset: 0x1DB8570 VA: 0x181DB9F70
	public static SprayLine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBA5A0 Offset: 0x1DB8BA0 VA: 0x181DBA5A0
	public static SprayLine Deserialize(byte[] buffer) { }

	// RVA: 0x1DBABA0 Offset: 0x1DB91A0 VA: 0x181DBABA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBBB50 Offset: 0x1DBA150 VA: 0x181DBBB50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBBB70 Offset: 0x1DBA170 VA: 0x181DBBB70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayLine previous) { }

	// RVA: 0x1DBAE00 Offset: 0x1DB9400 VA: 0x181DBAE00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBA000 Offset: 0x1DB8600 VA: 0x181DBA000
	public static SprayLine Deserialize(byte[] buffer, SprayLine instance, bool isDelta = False) { }

	// RVA: 0x1DBA8B0 Offset: 0x1DB8EB0 VA: 0x181DBA8B0
	public static SprayLine Deserialize(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB9940 Offset: 0x1DB7F40 VA: 0x181DB9940
	public static SprayLine DeserializeLengthDelimited(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB9C70 Offset: 0x1DB8270 VA: 0x181DB9C70
	public static SprayLine DeserializeLength(Stream stream, int length, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DBB220 Offset: 0x1DB9820 VA: 0x181DBB220
	public static void SerializeDelta(Stream stream, SprayLine instance, SprayLine previous) { }

	// RVA: 0x1DBB830 Offset: 0x1DB9E30 VA: 0x181DBB830
	public static void Serialize(Stream stream, SprayLine instance) { }

	// RVA: 0x1DBBB40 Offset: 0x1DBA140 VA: 0x181DBBB40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBBB50 Offset: 0x1DBA150 VA: 0x181DBBB50
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBB720 Offset: 0x1DB9D20 VA: 0x181DBB720
	public static byte[] SerializeToBytes(SprayLine instance) { }

	// RVA: 0x1DBB670 Offset: 0x1DB9C70 VA: 0x181DBB670
	public static void SerializeLengthDelimited(Stream stream, SprayLine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

