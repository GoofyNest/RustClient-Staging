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

	// RVA: 0x1D62F10 Offset: 0x1D61510 VA: 0x181D62F10
	public static Half3 Deserialize(Stream stream) { }

	// RVA: 0x1D62950 Offset: 0x1D60F50 VA: 0x181D62950
	public static Half3 DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D62BF0 Offset: 0x1D611F0 VA: 0x181D62BF0
	public static Half3 DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D62F40 Offset: 0x1D61540 VA: 0x181D62F40
	public static Half3 Deserialize(byte[] buffer) { }

	// RVA: 0x22E550 Offset: 0x22D950 VA: 0x18022E550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x22E5E0 Offset: 0x22D9E0 VA: 0x18022E5E0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x22E610 Offset: 0x22DA10 VA: 0x18022E610
	public void WriteToStreamDelta(Stream stream, Half3 previous) { }

	// RVA: 0x22E580 Offset: 0x22D980 VA: 0x18022E580 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D62C20 Offset: 0x1D61220 VA: 0x181D62C20
	public static Half3 Deserialize(byte[] buffer, ref Half3 instance, bool isDelta = False) { }

	// RVA: 0x1D62D50 Offset: 0x1D61350 VA: 0x181D62D50
	public static Half3 Deserialize(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D626B0 Offset: 0x1D60CB0 VA: 0x181D626B0
	public static Half3 DeserializeLengthDelimited(Stream stream, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D62980 Offset: 0x1D60F80 VA: 0x181D62980
	public static Half3 DeserializeLength(Stream stream, int length, ref Half3 instance, bool isDelta) { }

	// RVA: 0x1D63040 Offset: 0x1D61640 VA: 0x181D63040
	public static void SerializeDelta(Stream stream, Half3 instance, Half3 previous) { }

	// RVA: 0x1D63400 Offset: 0x1D61A00 VA: 0x181D63400
	public static void Serialize(Stream stream, Half3 instance) { }

	// RVA: 0x22E5B0 Offset: 0x22D9B0 VA: 0x18022E5B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x22E5E0 Offset: 0x22D9E0 VA: 0x18022E5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D632E0 Offset: 0x1D618E0 VA: 0x181D632E0
	public static byte[] SerializeToBytes(Half3 instance) { }

	// RVA: 0x1D63220 Offset: 0x1D61820 VA: 0x181D63220
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

	// RVA: 0x735320 Offset: 0x733920 VA: 0x180735320
	public static Vector3 op_Explicit(Half3 vec) { }

}

