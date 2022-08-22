public class MapData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F2ADB0 Offset: 0x1F293B0 VA: 0x181F2ADB0
	public static void ResetToPool(MapData instance) { }

	// RVA: 0x1F2AD00 Offset: 0x1F29300 VA: 0x181F2AD00
	public void ResetToPool() { }

	// RVA: 0x1F2AB90 Offset: 0x1F29190 VA: 0x181F2AB90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F29FD0 Offset: 0x1F285D0 VA: 0x181F29FD0
	public void CopyTo(MapData instance) { }

	// RVA: 0x1F2A080 Offset: 0x1F28680 VA: 0x181F2A080
	public MapData Copy() { }

	// RVA: 0x1F2A860 Offset: 0x1F28E60 VA: 0x181F2A860
	public static MapData Deserialize(Stream stream) { }

	// RVA: 0x1F2A400 Offset: 0x1F28A00 VA: 0x181F2A400
	public static MapData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2A480 Offset: 0x1F28A80 VA: 0x181F2A480
	public static MapData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2AA70 Offset: 0x1F29070 VA: 0x181F2AA70
	public static MapData Deserialize(byte[] buffer) { }

	// RVA: 0x1F2ACC0 Offset: 0x1F292C0 VA: 0x181F2ACC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2B3F0 Offset: 0x1F299F0 VA: 0x181F2B3F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2B410 Offset: 0x1F29A10 VA: 0x181F2B410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapData previous) { }

	// RVA: 0x1F2ACE0 Offset: 0x1F292E0 VA: 0x181F2ACE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2A760 Offset: 0x1F28D60 VA: 0x181F2A760
	public static MapData Deserialize(byte[] buffer, MapData instance, bool isDelta = False) { }

	// RVA: 0x1F2A8E0 Offset: 0x1F28EE0 VA: 0x181F2A8E0
	public static MapData Deserialize(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2A190 Offset: 0x1F28790 VA: 0x181F2A190
	public static MapData DeserializeLengthDelimited(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2A510 Offset: 0x1F28B10 VA: 0x181F2A510
	public static MapData DeserializeLength(Stream stream, int length, MapData instance, bool isDelta) { }

	// RVA: 0x1F2AE60 Offset: 0x1F29460 VA: 0x181F2AE60
	public static void SerializeDelta(Stream stream, MapData instance, MapData previous) { }

	// RVA: 0x1F2B210 Offset: 0x1F29810 VA: 0x181F2B210
	public static void Serialize(Stream stream, MapData instance) { }

	// RVA: 0x1F2B3E0 Offset: 0x1F299E0 VA: 0x181F2B3E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2B3F0 Offset: 0x1F299F0 VA: 0x181F2B3F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2B100 Offset: 0x1F29700 VA: 0x181F2B100
	public static byte[] SerializeToBytes(MapData instance) { }

	// RVA: 0x1F2B050 Offset: 0x1F29650 VA: 0x181F2B050
	public static void SerializeLengthDelimited(Stream stream, MapData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

