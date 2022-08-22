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

	// RVA: 0x1F97750 Offset: 0x1F95D50 VA: 0x181F97750
	public static void ResetToPool(PathData instance) { }

	// RVA: 0x1F97560 Offset: 0x1F95B60 VA: 0x181F97560
	public void ResetToPool() { }

	// RVA: 0x1F972B0 Offset: 0x1F958B0 VA: 0x181F972B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F95820 Offset: 0x1F93E20 VA: 0x181F95820
	public void CopyTo(PathData instance) { }

	// RVA: 0x1F959F0 Offset: 0x1F93FF0 VA: 0x181F959F0
	public PathData Copy() { }

	// RVA: 0x1F96A40 Offset: 0x1F95040 VA: 0x181F96A40
	public static PathData Deserialize(Stream stream) { }

	// RVA: 0x1F962B0 Offset: 0x1F948B0 VA: 0x181F962B0
	public static PathData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F969B0 Offset: 0x1F94FB0 VA: 0x181F969B0
	public static PathData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F97090 Offset: 0x1F95690 VA: 0x181F97090
	public static PathData Deserialize(byte[] buffer) { }

	// RVA: 0x1F97520 Offset: 0x1F95B20 VA: 0x181F97520
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F986F0 Offset: 0x1F96CF0 VA: 0x181F986F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F98710 Offset: 0x1F96D10 VA: 0x181F98710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PathData previous) { }

	// RVA: 0x1F97540 Offset: 0x1F95B40 VA: 0x181F97540 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F971B0 Offset: 0x1F957B0 VA: 0x181F971B0
	public static PathData Deserialize(byte[] buffer, PathData instance, bool isDelta = False) { }

	// RVA: 0x1F96AC0 Offset: 0x1F950C0 VA: 0x181F96AC0
	public static PathData Deserialize(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F95C10 Offset: 0x1F94210 VA: 0x181F95C10
	public static PathData DeserializeLengthDelimited(Stream stream, PathData instance, bool isDelta) { }

	// RVA: 0x1F96330 Offset: 0x1F94930 VA: 0x181F96330
	public static PathData DeserializeLength(Stream stream, int length, PathData instance, bool isDelta) { }

	// RVA: 0x1F97940 Offset: 0x1F95F40 VA: 0x181F97940
	public static void SerializeDelta(Stream stream, PathData instance, PathData previous) { }

	// RVA: 0x1F98210 Offset: 0x1F96810 VA: 0x181F98210
	public static void Serialize(Stream stream, PathData instance) { }

	// RVA: 0x1F986E0 Offset: 0x1F96CE0 VA: 0x181F986E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F986F0 Offset: 0x1F96CF0 VA: 0x181F986F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F98100 Offset: 0x1F96700 VA: 0x181F98100
	public static byte[] SerializeToBytes(PathData instance) { }

	// RVA: 0x1F98050 Offset: 0x1F96650 VA: 0x181F98050
	public static void SerializeLengthDelimited(Stream stream, PathData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

