public struct VectorData : IProto // TypeDefIndex: 6290
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8

	// Methods

	// RVA: 0xFB580 Offset: 0xFA980 VA: 0x1800FB580
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1EF9950 Offset: 0x1EF7F50 VA: 0x181EF9950
	public static VectorData op_Implicit(Vector3 v) { }

	// RVA: 0x1EF99D0 Offset: 0x1EF7FD0 VA: 0x181EF99D0
	public static VectorData op_Implicit(Quaternion q) { }

	// RVA: 0x1EF9980 Offset: 0x1EF7F80 VA: 0x181EF9980
	public static Vector3 op_Implicit(VectorData v) { }

	// RVA: 0x1EF9A30 Offset: 0x1EF8030 VA: 0x181EF9A30
	public static Quaternion op_Implicit(VectorData v) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(VectorData instance) { }

	// RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
	public void CopyTo(VectorData instance) { }

	// RVA: 0xFB460 Offset: 0xFA860 VA: 0x1800FB460
	public VectorData Copy() { }

	// RVA: 0x1EF9280 Offset: 0x1EF7880 VA: 0x181EF9280
	public static VectorData Deserialize(Stream stream) { }

	// RVA: 0x1EF8D80 Offset: 0x1EF7380 VA: 0x181EF8D80
	public static VectorData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF8DB0 Offset: 0x1EF73B0 VA: 0x181EF8DB0
	public static VectorData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF9180 Offset: 0x1EF7780 VA: 0x181EF9180
	public static VectorData Deserialize(byte[] buffer) { }

	// RVA: 0x232190 Offset: 0x231590 VA: 0x180232190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x232220 Offset: 0x231620 VA: 0x180232220 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x232250 Offset: 0x231650 VA: 0x180232250
	public void WriteToStreamDelta(Stream stream, VectorData previous) { }

	// RVA: 0x2321C0 Offset: 0x2315C0 VA: 0x1802321C0 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF9050 Offset: 0x1EF7650 VA: 0x181EF9050
	public static VectorData Deserialize(byte[] buffer, ref VectorData instance, bool isDelta = False) { }

	// RVA: 0x1EF92B0 Offset: 0x1EF78B0 VA: 0x181EF92B0
	public static VectorData Deserialize(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF8AE0 Offset: 0x1EF70E0 VA: 0x181EF8AE0
	public static VectorData DeserializeLengthDelimited(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF8DE0 Offset: 0x1EF73E0 VA: 0x181EF8DE0
	public static VectorData DeserializeLength(Stream stream, int length, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF9460 Offset: 0x1EF7A60 VA: 0x181EF9460
	public static void SerializeDelta(Stream stream, VectorData instance, VectorData previous) { }

	// RVA: 0x1EF9830 Offset: 0x1EF7E30 VA: 0x181EF9830
	public static void Serialize(Stream stream, VectorData instance) { }

	// RVA: 0x2321F0 Offset: 0x2315F0 VA: 0x1802321F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x232220 Offset: 0x231620 VA: 0x180232220
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF9710 Offset: 0x1EF7D10 VA: 0x181EF9710
	public static byte[] SerializeToBytes(VectorData instance) { }

	// RVA: 0x1EF9650 Offset: 0x1EF7C50 VA: 0x181EF9650
	public static void SerializeLengthDelimited(Stream stream, VectorData instance) { }

}

