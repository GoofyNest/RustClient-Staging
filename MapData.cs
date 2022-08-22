public class MapData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F2B890 Offset: 0x1F29E90 VA: 0x181F2B890
	public static void ResetToPool(MapData instance) { }

	// RVA: 0x1F2B7E0 Offset: 0x1F29DE0 VA: 0x181F2B7E0
	public void ResetToPool() { }

	// RVA: 0x1F2B670 Offset: 0x1F29C70 VA: 0x181F2B670 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2AAB0 Offset: 0x1F290B0 VA: 0x181F2AAB0
	public void CopyTo(MapData instance) { }

	// RVA: 0x1F2AB60 Offset: 0x1F29160 VA: 0x181F2AB60
	public MapData Copy() { }

	// RVA: 0x1F2B340 Offset: 0x1F29940 VA: 0x181F2B340
	public static MapData Deserialize(Stream stream) { }

	// RVA: 0x1F2AEE0 Offset: 0x1F294E0 VA: 0x181F2AEE0
	public static MapData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2AF60 Offset: 0x1F29560 VA: 0x181F2AF60
	public static MapData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2B550 Offset: 0x1F29B50 VA: 0x181F2B550
	public static MapData Deserialize(byte[] buffer) { }

	// RVA: 0x1F2B7A0 Offset: 0x1F29DA0 VA: 0x181F2B7A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2BED0 Offset: 0x1F2A4D0 VA: 0x181F2BED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2BEF0 Offset: 0x1F2A4F0 VA: 0x181F2BEF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapData previous) { }

	// RVA: 0x1F2B7C0 Offset: 0x1F29DC0 VA: 0x181F2B7C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2B240 Offset: 0x1F29840 VA: 0x181F2B240
	public static MapData Deserialize(byte[] buffer, MapData instance, bool isDelta = False) { }

	// RVA: 0x1F2B3C0 Offset: 0x1F299C0 VA: 0x181F2B3C0
	public static MapData Deserialize(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2AC70 Offset: 0x1F29270 VA: 0x181F2AC70
	public static MapData DeserializeLengthDelimited(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F2AFF0 Offset: 0x1F295F0 VA: 0x181F2AFF0
	public static MapData DeserializeLength(Stream stream, int length, MapData instance, bool isDelta) { }

	// RVA: 0x1F2B940 Offset: 0x1F29F40 VA: 0x181F2B940
	public static void SerializeDelta(Stream stream, MapData instance, MapData previous) { }

	// RVA: 0x1F2BCF0 Offset: 0x1F2A2F0 VA: 0x181F2BCF0
	public static void Serialize(Stream stream, MapData instance) { }

	// RVA: 0x1F2BEC0 Offset: 0x1F2A4C0 VA: 0x181F2BEC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2BED0 Offset: 0x1F2A4D0 VA: 0x181F2BED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2BBE0 Offset: 0x1F2A1E0 VA: 0x181F2BBE0
	public static byte[] SerializeToBytes(MapData instance) { }

	// RVA: 0x1F2BB30 Offset: 0x1F2A130 VA: 0x181F2BB30
	public static void SerializeLengthDelimited(Stream stream, MapData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

