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

	// RVA: 0x1F96C70 Offset: 0x1F95270 VA: 0x181F96C70
	public static void ResetToPool(PathData instance) { }

	// RVA: 0x1F96A80 Offset: 0x1F95080 VA: 0x181F96A80
	public void ResetToPool() { }

	// RVA: 0x1F967D0 Offset: 0x1F94DD0 VA: 0x181F967D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F94D40 Offset: 0x1F93340 VA: 0x181F94D40
	public void CopyTo(PathData instance) { }

	// RVA: 0x1F94F10 Offset: 0x1F93510 VA: 0x181F94F10
	public PathData Copy() { }

	// RVA: 0x1F95F60 Offset: 0x1F94560 VA: 0x181F95F60
	public static PathData Deserialize(Stream stream) { }

	// RVA: 0x1F957D0 Offset: 0x1F93DD0 VA: 0x181F957D0
	public static PathData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F95ED0 Offset: 0x1F944D0 VA: 0x181F95ED0
	public static PathData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F965B0 Offset: 0x1F94BB0 VA: 0x181F965B0
	public static PathData Deserialize(byte[] buffer) { }

	// RVA: 0x1F96A40 Offset: 0x1F95040 VA: 0x181F96A40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F97C10 Offset: 0x1F96210 VA: 0x181F97C10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F97C30 Offset: 0x1F96230 VA: 0x181F97C30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PathData previous) { }

	// RVA: 0x1F96A60 Offset: 0x1F95060 VA: 0x181F96A60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F966D0 Offset: 0x1F94CD0 VA: 0x181F966D0
	public static PathData Deserialize(byte[] buffer, PathData instance, bool isDelta = False) { }

	// RVA: 0x1F95FE0 Offset: 0x1F945E0 VA: 0x181F95FE0
	public static PathData Deserialize(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F95130 Offset: 0x1F93730 VA: 0x181F95130
	public static PathData DeserializeLengthDelimited(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F95850 Offset: 0x1F93E50 VA: 0x181F95850
	public static PathData DeserializeLength(Stream stream, int length, PathData instance, bool isDelta) { }

	// RVA: 0x1F96E60 Offset: 0x1F95460 VA: 0x181F96E60
	public static void SerializeDelta(Stream stream, PathData instance, PathData previous) { }

	// RVA: 0x1F97730 Offset: 0x1F95D30 VA: 0x181F97730
	public static void Serialize(Stream stream, PathData instance) { }

	// RVA: 0x1F97C00 Offset: 0x1F96200 VA: 0x181F97C00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F97C10 Offset: 0x1F96210 VA: 0x181F97C10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F97620 Offset: 0x1F95C20 VA: 0x181F97620
	public static byte[] SerializeToBytes(PathData instance) { }

	// RVA: 0x1F97570 Offset: 0x1F95B70 VA: 0x181F97570
	public static void SerializeLengthDelimited(Stream stream, PathData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

