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

	// RVA: 0x1D631D0 Offset: 0x1D617D0 VA: 0x181D631D0
	public static Half3 Deserialize(Stream stream) { }

	// RVA: 0x1D62C10 Offset: 0x1D61210 VA: 0x181D62C10
	public static Half3 DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D62EB0 Offset: 0x1D614B0 VA: 0x181D62EB0
	public static Half3 DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D63200 Offset: 0x1D61800 VA: 0x181D63200
	public static Half3 Deserialize(byte[] buffer) { }

	// RVA: 0x22E550 Offset: 0x22D950 VA: 0x18022E550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x22E5E0 Offset: 0x22D9E0 VA: 0x18022E5E0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x22E610 Offset: 0x22DA10 VA: 0x18022E610
	public void WriteToStreamDelta(Stream stream, Half3 previous) { }

	// RVA: 0x22E580 Offset: 0x22D980 VA: 0x18022E580 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D62EE0 Offset: 0x1D614E0 VA: 0x181D62EE0
	public static Half3 Deserialize(byte[] buffer, ref Half3 instance, bool isDelta = False) { }

	// RVA: 0x1D63010 Offset: 0x1D61610 VA: 0x181D63010
	public static Half3 Deserialize(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D62970 Offset: 0x1D60F70 VA: 0x181D62970
	public static Half3 DeserializeLengthDelimited(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D62C40 Offset: 0x1D61240 VA: 0x181D62C40
	public static Half3 DeserializeLength(Stream stream, int length, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D63300 Offset: 0x1D61900 VA: 0x181D63300
	public static void SerializeDelta(Stream stream, Half3 instance, Half3 previous) { }

	// RVA: 0x1D636C0 Offset: 0x1D61CC0 VA: 0x181D636C0
	public static void Serialize(Stream stream, Half3 instance) { }

	// RVA: 0x22E5B0 Offset: 0x22D9B0 VA: 0x18022E5B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x22E5E0 Offset: 0x22D9E0 VA: 0x18022E5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D635A0 Offset: 0x1D61BA0 VA: 0x181D635A0
	public static byte[] SerializeToBytes(Half3 instance) { }

	// RVA: 0x1D634E0 Offset: 0x1D61AE0 VA: 0x181D634E0
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

	// RVA: 0x735430 Offset: 0x733A30 VA: 0x180735430
	public static Vector3 op_Explicit(Half3 vec) { }

}

