public struct VectorData : IProto // TypeDefIndex: 6290
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8

	// Methods

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1EF9790 Offset: 0x1EF7D90 VA: 0x181EF9790
	public static VectorData op_Implicit(Vector3 v) { }

	// RVA: 0x1EF9810 Offset: 0x1EF7E10 VA: 0x181EF9810
	public static VectorData op_Implicit(Quaternion q) { }

	// RVA: 0x1EF97C0 Offset: 0x1EF7DC0 VA: 0x181EF97C0
	public static Vector3 op_Implicit(VectorData v) { }

	// RVA: 0x1EF9870 Offset: 0x1EF7E70 VA: 0x181EF9870
	public static Quaternion op_Implicit(VectorData v) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(VectorData instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(VectorData instance) { }

	// RVA: 0xFB3E0 Offset: 0xFA7E0 VA: 0x1800FB3E0
	public VectorData Copy() { }

	// RVA: 0x1EF90C0 Offset: 0x1EF76C0 VA: 0x181EF90C0
	public static VectorData Deserialize(Stream stream) { }

	// RVA: 0x1EF8BC0 Offset: 0x1EF71C0 VA: 0x181EF8BC0
	public static VectorData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF8BF0 Offset: 0x1EF71F0 VA: 0x181EF8BF0
	public static VectorData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF8FC0 Offset: 0x1EF75C0 VA: 0x181EF8FC0
	public static VectorData Deserialize(byte[] buffer) { }

	// RVA: 0x232110 Offset: 0x231510 VA: 0x180232110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2321A0 Offset: 0x2315A0 VA: 0x1802321A0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x2321D0 Offset: 0x2315D0 VA: 0x1802321D0
	public void WriteToStreamDelta(Stream stream, VectorData previous) { }

	// RVA: 0x232140 Offset: 0x231540 VA: 0x180232140 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF8E90 Offset: 0x1EF7490 VA: 0x181EF8E90
	public static VectorData Deserialize(byte[] buffer, ref VectorData instance, bool isDelta = False) { }

	// RVA: 0x1EF90F0 Offset: 0x1EF76F0 VA: 0x181EF90F0
	public static VectorData Deserialize(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF8920 Offset: 0x1EF6F20 VA: 0x181EF8920
	public static VectorData DeserializeLengthDelimited(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF8C20 Offset: 0x1EF7220 VA: 0x181EF8C20
	public static VectorData DeserializeLength(Stream stream, int length, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF92A0 Offset: 0x1EF78A0 VA: 0x181EF92A0
	public static void SerializeDelta(Stream stream, VectorData instance, VectorData previous) { }

	// RVA: 0x1EF9670 Offset: 0x1EF7C70 VA: 0x181EF9670
	public static void Serialize(Stream stream, VectorData instance) { }

	// RVA: 0x232170 Offset: 0x231570 VA: 0x180232170
	public byte[] ToProtoBytes() { }

	// RVA: 0x2321A0 Offset: 0x2315A0 VA: 0x1802321A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF9550 Offset: 0x1EF7B50 VA: 0x181EF9550
	public static byte[] SerializeToBytes(VectorData instance) { }

	// RVA: 0x1EF9490 Offset: 0x1EF7A90 VA: 0x181EF9490
	public static void SerializeLengthDelimited(Stream stream, VectorData instance) { }

}

