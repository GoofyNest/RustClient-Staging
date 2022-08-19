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

	// RVA: 0x1F96E30 Offset: 0x1F95430 VA: 0x181F96E30
	public static void ResetToPool(PathData instance) { }

	// RVA: 0x1F96C40 Offset: 0x1F95240 VA: 0x181F96C40
	public void ResetToPool() { }

	// RVA: 0x1F96990 Offset: 0x1F94F90 VA: 0x181F96990 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F94F00 Offset: 0x1F93500 VA: 0x181F94F00
	public void CopyTo(PathData instance) { }

	// RVA: 0x1F950D0 Offset: 0x1F936D0 VA: 0x181F950D0
	public PathData Copy() { }

	// RVA: 0x1F96120 Offset: 0x1F94720 VA: 0x181F96120
	public static PathData Deserialize(Stream stream) { }

	// RVA: 0x1F95990 Offset: 0x1F93F90 VA: 0x181F95990
	public static PathData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F96090 Offset: 0x1F94690 VA: 0x181F96090
	public static PathData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F96770 Offset: 0x1F94D70 VA: 0x181F96770
	public static PathData Deserialize(byte[] buffer) { }

	// RVA: 0x1F96C00 Offset: 0x1F95200 VA: 0x181F96C00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F97DD0 Offset: 0x1F963D0 VA: 0x181F97DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F97DF0 Offset: 0x1F963F0 VA: 0x181F97DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PathData previous) { }

	// RVA: 0x1F96C20 Offset: 0x1F95220 VA: 0x181F96C20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F96890 Offset: 0x1F94E90 VA: 0x181F96890
	public static PathData Deserialize(byte[] buffer, PathData instance, bool isDelta = False) { }

	// RVA: 0x1F961A0 Offset: 0x1F947A0 VA: 0x181F961A0
	public static PathData Deserialize(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F952F0 Offset: 0x1F938F0 VA: 0x181F952F0
	public static PathData DeserializeLengthDelimited(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F95A10 Offset: 0x1F94010 VA: 0x181F95A10
	public static PathData DeserializeLength(Stream stream, int length, PathData instance, bool isDelta) { }

	// RVA: 0x1F97020 Offset: 0x1F95620 VA: 0x181F97020
	public static void SerializeDelta(Stream stream, PathData instance, PathData previous) { }

	// RVA: 0x1F978F0 Offset: 0x1F95EF0 VA: 0x181F978F0
	public static void Serialize(Stream stream, PathData instance) { }

	// RVA: 0x1F97DC0 Offset: 0x1F963C0 VA: 0x181F97DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F97DD0 Offset: 0x1F963D0 VA: 0x181F97DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F977E0 Offset: 0x1F95DE0 VA: 0x181F977E0
	public static byte[] SerializeToBytes(PathData instance) { }

	// RVA: 0x1F97730 Offset: 0x1F95D30 VA: 0x181F97730
	public static void SerializeLengthDelimited(Stream stream, PathData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

