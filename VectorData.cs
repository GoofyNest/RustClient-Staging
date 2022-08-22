public struct VectorData : IProto // TypeDefIndex: 6290
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8

	// Methods

	// RVA: 0xFB500 Offset: 0xFA900 VA: 0x1800FB500
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1EF9A50 Offset: 0x1EF8050 VA: 0x181EF9A50
	public static VectorData op_Implicit(Vector3 v) { }

	// RVA: 0x1EF9AD0 Offset: 0x1EF80D0 VA: 0x181EF9AD0
	public static VectorData op_Implicit(Quaternion q) { }

	// RVA: 0x1EF9A80 Offset: 0x1EF8080 VA: 0x181EF9A80
	public static Vector3 op_Implicit(VectorData v) { }

	// RVA: 0x1EF9B30 Offset: 0x1EF8130 VA: 0x181EF9B30
	public static Quaternion op_Implicit(VectorData v) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(VectorData instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(VectorData instance) { }

	// RVA: 0xFB3E0 Offset: 0xFA7E0 VA: 0x1800FB3E0
	public VectorData Copy() { }

	// RVA: 0x1EF9380 Offset: 0x1EF7980 VA: 0x181EF9380
	public static VectorData Deserialize(Stream stream) { }

	// RVA: 0x1EF8E80 Offset: 0x1EF7480 VA: 0x181EF8E80
	public static VectorData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF8EB0 Offset: 0x1EF74B0 VA: 0x181EF8EB0
	public static VectorData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF9280 Offset: 0x1EF7880 VA: 0x181EF9280
	public static VectorData Deserialize(byte[] buffer) { }

	// RVA: 0x232110 Offset: 0x231510 VA: 0x180232110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2321A0 Offset: 0x2315A0 VA: 0x1802321A0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x2321D0 Offset: 0x2315D0 VA: 0x1802321D0
	public void WriteToStreamDelta(Stream stream, VectorData previous) { }

	// RVA: 0x232140 Offset: 0x231540 VA: 0x180232140 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF9150 Offset: 0x1EF7750 VA: 0x181EF9150
	public static VectorData Deserialize(byte[] buffer, ref VectorData instance, bool isDelta = False) { }

	// RVA: 0x1EF93B0 Offset: 0x1EF79B0 VA: 0x181EF93B0
	public static VectorData Deserialize(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF8BE0 Offset: 0x1EF71E0 VA: 0x181EF8BE0
	public static VectorData DeserializeLengthDelimited(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF8EE0 Offset: 0x1EF74E0 VA: 0x181EF8EE0
	public static VectorData DeserializeLength(Stream stream, int length, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF9560 Offset: 0x1EF7B60 VA: 0x181EF9560
	public static void SerializeDelta(Stream stream, VectorData instance, VectorData previous) { }

	// RVA: 0x1EF9930 Offset: 0x1EF7F30 VA: 0x181EF9930
	public static void Serialize(Stream stream, VectorData instance) { }

	// RVA: 0x232170 Offset: 0x231570 VA: 0x180232170
	public byte[] ToProtoBytes() { }

	// RVA: 0x2321A0 Offset: 0x2315A0 VA: 0x1802321A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF9810 Offset: 0x1EF7E10 VA: 0x181EF9810
	public static byte[] SerializeToBytes(VectorData instance) { }

	// RVA: 0x1EF9750 Offset: 0x1EF7D50 VA: 0x181EF9750
	public static void SerializeLengthDelimited(Stream stream, VectorData instance) { }

}

