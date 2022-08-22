public class MapNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6460
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteType; // 0x14
	public Vector3 worldPosition; // 0x18

	// Methods

	// RVA: 0x1F41680 Offset: 0x1F3FC80 VA: 0x181F41680
	public static void ResetToPool(MapNote instance) { }

	// RVA: 0x1F415F0 Offset: 0x1F3FBF0 VA: 0x181F415F0
	public void ResetToPool() { }

	// RVA: 0x1F41530 Offset: 0x1F3FB30 VA: 0x181F41530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFD440 Offset: 0x1BFBA40 VA: 0x181BFD440
	public void CopyTo(MapNote instance) { }

	// RVA: 0x1F40AE0 Offset: 0x1F3F0E0 VA: 0x181F40AE0
	public MapNote Copy() { }

	// RVA: 0x1F41290 Offset: 0x1F3F890 VA: 0x181F41290
	public static MapNote Deserialize(Stream stream) { }

	// RVA: 0x1F40DC0 Offset: 0x1F3F3C0 VA: 0x181F40DC0
	public static MapNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F41070 Offset: 0x1F3F670 VA: 0x181F41070
	public static MapNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F41410 Offset: 0x1F3FA10 VA: 0x181F41410
	public static MapNote Deserialize(byte[] buffer) { }

	// RVA: 0x1F415B0 Offset: 0x1F3FBB0 VA: 0x181F415B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F41D10 Offset: 0x1F40310 VA: 0x181F41D10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F41D30 Offset: 0x1F40330 VA: 0x181F41D30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapNote previous) { }

	// RVA: 0x1F415D0 Offset: 0x1F3FBD0 VA: 0x181F415D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F41310 Offset: 0x1F3F910 VA: 0x181F41310
	public static MapNote Deserialize(byte[] buffer, MapNote instance, bool isDelta = False) { }

	// RVA: 0x1F41100 Offset: 0x1F3F700 VA: 0x181F41100
	public static MapNote Deserialize(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F40B60 Offset: 0x1F3F160 VA: 0x181F40B60
	public static MapNote DeserializeLengthDelimited(Stream stream, MapNote instance, bool isDelta) { }

	// RVA: 0x1F40E40 Offset: 0x1F3F440 VA: 0x181F40E40
	public static MapNote DeserializeLength(Stream stream, int length, MapNote instance, bool isDelta) { }

	// RVA: 0x1F41710 Offset: 0x1F3FD10 VA: 0x181F41710
	public static void SerializeDelta(Stream stream, MapNote instance, MapNote previous) { }

	// RVA: 0x1F41B60 Offset: 0x1F40160 VA: 0x181F41B60
	public static void Serialize(Stream stream, MapNote instance) { }

	// RVA: 0x1F41D00 Offset: 0x1F40300 VA: 0x181F41D00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F41D10 Offset: 0x1F40310 VA: 0x181F41D10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F41A50 Offset: 0x1F40050 VA: 0x181F41A50
	public static byte[] SerializeToBytes(MapNote instance) { }

	// RVA: 0x1F419A0 Offset: 0x1F3FFA0 VA: 0x181F419A0
	public static void SerializeLengthDelimited(Stream stream, MapNote instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

