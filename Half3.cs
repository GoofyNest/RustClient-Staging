public struct Half3 : IProto // TypeDefIndex: 6475
{	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Half3 instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(Half3 instance) { }

	// RVA: 0xFB3E0 Offset: 0xFA7E0 VA: 0x1800FB3E0
	public Half3 Copy() { }

	// RVA: 0x1D639C0 Offset: 0x1D61FC0 VA: 0x181D639C0
	public static Half3 Deserialize(Stream stream) { }

	// RVA: 0x1D63400 Offset: 0x1D61A00 VA: 0x181D63400
	public static Half3 DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D636A0 Offset: 0x1D61CA0 VA: 0x181D636A0
	public static Half3 DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D639F0 Offset: 0x1D61FF0 VA: 0x181D639F0
	public static Half3 Deserialize(byte[] buffer) { }

	// RVA: 0x22E550 Offset: 0x22D950 VA: 0x18022E550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x22E5E0 Offset: 0x22D9E0 VA: 0x18022E5E0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x22E610 Offset: 0x22DA10 VA: 0x18022E610
	public void WriteToStreamDelta(Stream stream, Half3 previous) { }

	// RVA: 0x22E580 Offset: 0x22D980 VA: 0x18022E580 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D636D0 Offset: 0x1D61CD0 VA: 0x181D636D0
	public static Half3 Deserialize(byte[] buffer, ref Half3 instance, bool isDelta = False) { }

	// RVA: 0x1D63800 Offset: 0x1D61E00 VA: 0x181D63800
	public static Half3 Deserialize(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D63160 Offset: 0x1D61760 VA: 0x181D63160
	public static Half3 DeserializeLengthDelimited(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D63430 Offset: 0x1D61A30 VA: 0x181D63430
	public static Half3 DeserializeLength(Stream stream, int length, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D63AF0 Offset: 0x1D620F0 VA: 0x181D63AF0
	public static void SerializeDelta(Stream stream, Half3 instance, Half3 previous) { }

	// RVA: 0x1D63EB0 Offset: 0x1D624B0 VA: 0x181D63EB0
	public static void Serialize(Stream stream, Half3 instance) { }

	// RVA: 0x22E5B0 Offset: 0x22D9B0 VA: 0x18022E5B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x22E5E0 Offset: 0x22D9E0 VA: 0x18022E5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D63D90 Offset: 0x1D62390 VA: 0x181D63D90
	public static byte[] SerializeToBytes(Half3 instance) { }

	// RVA: 0x1D63CD0 Offset: 0x1D622D0 VA: 0x181D63CD0
	public static void SerializeLengthDelimited(Stream stream, Half3 instance) { }

}

public struct Half3 // TypeDefIndex: 11420
{	// Fields
	public ushort x; // 0x0
	public ushort y; // 0x2
	public ushort z; // 0x4

	// Methods

	// RVA: 0xF4C70 Offset: 0xF4070 VA: 0x1800F4C70
	public void .ctor(Vector3 vec) { }

	// RVA: 0x735380 Offset: 0x733980 VA: 0x180735380
	public static Vector3 op_Explicit(Half3 vec) { }

}

