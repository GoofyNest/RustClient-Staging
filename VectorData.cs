public struct VectorData : IProto // TypeDefIndex: 6290
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8

	// Methods

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1EFA270 Offset: 0x1EF8870 VA: 0x181EFA270
	public static VectorData op_Implicit(Vector3 v) { }

	// RVA: 0x1EFA2F0 Offset: 0x1EF88F0 VA: 0x181EFA2F0
	public static VectorData op_Implicit(Quaternion q) { }

	// RVA: 0x1EFA2A0 Offset: 0x1EF88A0 VA: 0x181EFA2A0
	public static Vector3 op_Implicit(VectorData v) { }

	// RVA: 0x1EFA350 Offset: 0x1EF8950 VA: 0x181EFA350
	public static Quaternion op_Implicit(VectorData v) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(VectorData instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(VectorData instance) { }

	// RVA: 0xFB3E0 Offset: 0xFA7E0 VA: 0x1800FB3E0
	public VectorData Copy() { }

	// RVA: 0x1EF9BA0 Offset: 0x1EF81A0 VA: 0x181EF9BA0
	public static VectorData Deserialize(Stream stream) { }

	// RVA: 0x1EF96A0 Offset: 0x1EF7CA0 VA: 0x181EF96A0
	public static VectorData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF96D0 Offset: 0x1EF7CD0 VA: 0x181EF96D0
	public static VectorData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF9AA0 Offset: 0x1EF80A0 VA: 0x181EF9AA0
	public static VectorData Deserialize(byte[] buffer) { }

	// RVA: 0x232110 Offset: 0x231510 VA: 0x180232110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2321A0 Offset: 0x2315A0 VA: 0x1802321A0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x2321D0 Offset: 0x2315D0 VA: 0x1802321D0
	public void WriteToStreamDelta(Stream stream, VectorData previous) { }

	// RVA: 0x232140 Offset: 0x231540 VA: 0x180232140 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF9970 Offset: 0x1EF7F70 VA: 0x181EF9970
	public static VectorData Deserialize(byte[] buffer, ref VectorData instance, bool isDelta = False) { }

	// RVA: 0x1EF9BD0 Offset: 0x1EF81D0 VA: 0x181EF9BD0
	public static VectorData Deserialize(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF9400 Offset: 0x1EF7A00 VA: 0x181EF9400
	public static VectorData DeserializeLengthDelimited(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF9700 Offset: 0x1EF7D00 VA: 0x181EF9700
	public static VectorData DeserializeLength(Stream stream, int length, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF9D80 Offset: 0x1EF8380 VA: 0x181EF9D80
	public static void SerializeDelta(Stream stream, VectorData instance, VectorData previous) { }

	// RVA: 0x1EFA150 Offset: 0x1EF8750 VA: 0x181EFA150
	public static void Serialize(Stream stream, VectorData instance) { }

	// RVA: 0x232170 Offset: 0x231570 VA: 0x180232170
	public byte[] ToProtoBytes() { }

	// RVA: 0x2321A0 Offset: 0x2315A0 VA: 0x1802321A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFA030 Offset: 0x1EF8630 VA: 0x181EFA030
	public static byte[] SerializeToBytes(VectorData instance) { }

	// RVA: 0x1EF9F70 Offset: 0x1EF8570 VA: 0x181EF9F70
	public static void SerializeLengthDelimited(Stream stream, VectorData instance) { }

}

