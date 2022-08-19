public class MapData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F2AF70 Offset: 0x1F29570 VA: 0x181F2AF70
	public static void ResetToPool(MapData instance) { }

	// RVA: 0x1F2AEC0 Offset: 0x1F294C0 VA: 0x181F2AEC0
	public void ResetToPool() { }

	// RVA: 0x1F2AD50 Offset: 0x1F29350 VA: 0x181F2AD50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2A190 Offset: 0x1F28790 VA: 0x181F2A190
	public void CopyTo(MapData instance) { }

	// RVA: 0x1F2A240 Offset: 0x1F28840 VA: 0x181F2A240
	public MapData Copy() { }

	// RVA: 0x1F2AA20 Offset: 0x1F29020 VA: 0x181F2AA20
	public static MapData Deserialize(Stream stream) { }

	// RVA: 0x1F2A5C0 Offset: 0x1F28BC0 VA: 0x181F2A5C0
	public static MapData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2A640 Offset: 0x1F28C40 VA: 0x181F2A640
	public static MapData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2AC30 Offset: 0x1F29230 VA: 0x181F2AC30
	public static MapData Deserialize(byte[] buffer) { }

	// RVA: 0x1F2AE80 Offset: 0x1F29480 VA: 0x181F2AE80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2B5B0 Offset: 0x1F29BB0 VA: 0x181F2B5B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2B5D0 Offset: 0x1F29BD0 VA: 0x181F2B5D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapData previous) { }

	// RVA: 0x1F2AEA0 Offset: 0x1F294A0 VA: 0x181F2AEA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2A920 Offset: 0x1F28F20 VA: 0x181F2A920
	public static MapData Deserialize(byte[] buffer, MapData instance, bool isDelta = False) { }

	// RVA: 0x1F2AAA0 Offset: 0x1F290A0 VA: 0x181F2AAA0
	public static MapData Deserialize(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2A350 Offset: 0x1F28950 VA: 0x181F2A350
	public static MapData DeserializeLengthDelimited(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2A6D0 Offset: 0x1F28CD0 VA: 0x181F2A6D0
	public static MapData DeserializeLength(Stream stream, int length, MapData instance, bool isDelta) { }

	// RVA: 0x1F2B020 Offset: 0x1F29620 VA: 0x181F2B020
	public static void SerializeDelta(Stream stream, MapData instance, MapData previous) { }

	// RVA: 0x1F2B3D0 Offset: 0x1F299D0 VA: 0x181F2B3D0
	public static void Serialize(Stream stream, MapData instance) { }

	// RVA: 0x1F2B5A0 Offset: 0x1F29BA0 VA: 0x181F2B5A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2B5B0 Offset: 0x1F29BB0 VA: 0x181F2B5B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2B2C0 Offset: 0x1F298C0 VA: 0x181F2B2C0
	public static byte[] SerializeToBytes(MapData instance) { }

	// RVA: 0x1F2B210 Offset: 0x1F29810 VA: 0x181F2B210
	public static void SerializeLengthDelimited(Stream stream, MapData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

