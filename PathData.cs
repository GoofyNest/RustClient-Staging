public class PathData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6510
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public bool spline; // 0x20
	public bool start; // 0x21
	public bool end; // 0x22
	public float width; // 0x24
	public float innerPadding; // 0x28
	public float outerPadding; // 0x2C
	public float innerFade; // 0x30
	public float outerFade; // 0x34
	public float randomScale; // 0x38
	public float meshOffset; // 0x3C
	public float terrainOffset; // 0x40
	public int splat; // 0x44
	public int topology; // 0x48
	public List<VectorData> nodes; // 0x50
	public int hierarchy; // 0x58

	// Methods

	// RVA: 0x1F96F30 Offset: 0x1F95530 VA: 0x181F96F30
	public static void ResetToPool(PathData instance) { }

	// RVA: 0x1F96D40 Offset: 0x1F95340 VA: 0x181F96D40
	public void ResetToPool() { }

	// RVA: 0x1F96A90 Offset: 0x1F95090 VA: 0x181F96A90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F95000 Offset: 0x1F93600 VA: 0x181F95000
	public void CopyTo(PathData instance) { }

	// RVA: 0x1F951D0 Offset: 0x1F937D0 VA: 0x181F951D0
	public PathData Copy() { }

	// RVA: 0x1F96220 Offset: 0x1F94820 VA: 0x181F96220
	public static PathData Deserialize(Stream stream) { }

	// RVA: 0x1F95A90 Offset: 0x1F94090 VA: 0x181F95A90
	public static PathData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F96190 Offset: 0x1F94790 VA: 0x181F96190
	public static PathData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F96870 Offset: 0x1F94E70 VA: 0x181F96870
	public static PathData Deserialize(byte[] buffer) { }

	// RVA: 0x1F96D00 Offset: 0x1F95300 VA: 0x181F96D00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F97ED0 Offset: 0x1F964D0 VA: 0x181F97ED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F97EF0 Offset: 0x1F964F0 VA: 0x181F97EF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PathData previous) { }

	// RVA: 0x1F96D20 Offset: 0x1F95320 VA: 0x181F96D20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F96990 Offset: 0x1F94F90 VA: 0x181F96990
	public static PathData Deserialize(byte[] buffer, PathData instance, bool isDelta = False) { }

	// RVA: 0x1F962A0 Offset: 0x1F948A0 VA: 0x181F962A0
	public static PathData Deserialize(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F953F0 Offset: 0x1F939F0 VA: 0x181F953F0
	public static PathData DeserializeLengthDelimited(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F95B10 Offset: 0x1F94110 VA: 0x181F95B10
	public static PathData DeserializeLength(Stream stream, int length, PathData instance, bool isDelta) { }

	// RVA: 0x1F97120 Offset: 0x1F95720 VA: 0x181F97120
	public static void SerializeDelta(Stream stream, PathData instance, PathData previous) { }

	// RVA: 0x1F979F0 Offset: 0x1F95FF0 VA: 0x181F979F0
	public static void Serialize(Stream stream, PathData instance) { }

	// RVA: 0x1F97EC0 Offset: 0x1F964C0 VA: 0x181F97EC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F97ED0 Offset: 0x1F964D0 VA: 0x181F97ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F978E0 Offset: 0x1F95EE0 VA: 0x181F978E0
	public static byte[] SerializeToBytes(PathData instance) { }

	// RVA: 0x1F97830 Offset: 0x1F95E30 VA: 0x181F97830
	public static void SerializeLengthDelimited(Stream stream, PathData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

