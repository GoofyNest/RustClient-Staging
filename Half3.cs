public struct Half3 : IProto // TypeDefIndex: 6475
{	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Half3 instance) { }

	// RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
	public void CopyTo(Half3 instance) { }

	// RVA: 0xFB460 Offset: 0xFA860 VA: 0x1800FB460
	public Half3 Copy() { }

	// RVA: 0x1D630D0 Offset: 0x1D616D0 VA: 0x181D630D0
	public static Half3 Deserialize(Stream stream) { }

	// RVA: 0x1D62B10 Offset: 0x1D61110 VA: 0x181D62B10
	public static Half3 DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D62DB0 Offset: 0x1D613B0 VA: 0x181D62DB0
	public static Half3 DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D63100 Offset: 0x1D61700 VA: 0x181D63100
	public static Half3 Deserialize(byte[] buffer) { }

	// RVA: 0x22E5D0 Offset: 0x22D9D0 VA: 0x18022E5D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x22E660 Offset: 0x22DA60 VA: 0x18022E660 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x22E690 Offset: 0x22DA90 VA: 0x18022E690
	public void WriteToStreamDelta(Stream stream, Half3 previous) { }

	// RVA: 0x22E600 Offset: 0x22DA00 VA: 0x18022E600 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D62DE0 Offset: 0x1D613E0 VA: 0x181D62DE0
	public static Half3 Deserialize(byte[] buffer, ref Half3 instance, bool isDelta = False) { }

	// RVA: 0x1D62F10 Offset: 0x1D61510 VA: 0x181D62F10
	public static Half3 Deserialize(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D62870 Offset: 0x1D60E70 VA: 0x181D62870
	public static Half3 DeserializeLengthDelimited(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D62B40 Offset: 0x1D61140 VA: 0x181D62B40
	public static Half3 DeserializeLength(Stream stream, int length, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D63200 Offset: 0x1D61800 VA: 0x181D63200
	public static void SerializeDelta(Stream stream, Half3 instance, Half3 previous) { }

	// RVA: 0x1D635C0 Offset: 0x1D61BC0 VA: 0x181D635C0
	public static void Serialize(Stream stream, Half3 instance) { }

	// RVA: 0x22E630 Offset: 0x22DA30 VA: 0x18022E630
	public byte[] ToProtoBytes() { }

	// RVA: 0x22E660 Offset: 0x22DA60 VA: 0x18022E660
	public void ToProto(Stream stream) { }

	// RVA: 0x1D634A0 Offset: 0x1D61AA0 VA: 0x181D634A0
	public static byte[] SerializeToBytes(Half3 instance) { }

	// RVA: 0x1D633E0 Offset: 0x1D619E0 VA: 0x181D633E0
	public static void SerializeLengthDelimited(Stream stream, Half3 instance) { }

}

public struct Half3 // TypeDefIndex: 11420
{	// Fields
	public ushort x; // 0x0
	public ushort y; // 0x2
	public ushort z; // 0x4

	// Methods

	// RVA: 0xF4CF0 Offset: 0xF40F0 VA: 0x1800F4CF0
	public void .ctor(Vector3 vec) { }

	// RVA: 0x735320 Offset: 0x733920 VA: 0x180735320
	public static Vector3 op_Explicit(Half3 vec) { }

}

