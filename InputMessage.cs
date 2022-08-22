public class InputMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6276
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int buttons; // 0x14
	public Vector3 aimAngles; // 0x18
	public Vector3 mouseDelta; // 0x24

	// Methods

	// RVA: 0x201C780 Offset: 0x201AD80 VA: 0x18201C780
	public static void ResetToPool(InputMessage instance) { }

	// RVA: 0x201C6E0 Offset: 0x201ACE0 VA: 0x18201C6E0
	public void ResetToPool() { }

	// RVA: 0x201C480 Offset: 0x201AA80 VA: 0x18201C480 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201B4E0 Offset: 0x2019AE0 VA: 0x18201B4E0
	public void CopyTo(InputMessage instance) { }

	// RVA: 0x201B520 Offset: 0x2019B20 VA: 0x18201B520
	public InputMessage Copy() { }

	// RVA: 0x201BBB0 Offset: 0x201A1B0 VA: 0x18201BBB0
	public static InputMessage Deserialize(Stream stream) { }

	// RVA: 0x201B840 Offset: 0x2019E40 VA: 0x18201B840
	public static InputMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201B8C0 Offset: 0x2019EC0 VA: 0x18201B8C0
	public static InputMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201BDB0 Offset: 0x201A3B0 VA: 0x18201BDB0
	public static InputMessage Deserialize(byte[] buffer) { }

	// RVA: 0x201C500 Offset: 0x201AB00 VA: 0x18201C500
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201D050 Offset: 0x201B650 VA: 0x18201D050 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201D070 Offset: 0x201B670 VA: 0x18201D070 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InputMessage previous) { }

	// RVA: 0x201C6C0 Offset: 0x201ACC0 VA: 0x18201C6C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201C200 Offset: 0x201A800 VA: 0x18201C200
	public static InputMessage Deserialize(byte[] buffer, InputMessage instance, bool isDelta = False) { }

	// RVA: 0x201C040 Offset: 0x201A640 VA: 0x18201C040
	public static InputMessage Deserialize(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201B5B0 Offset: 0x2019BB0 VA: 0x18201B5B0
	public static InputMessage DeserializeLengthDelimited(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201B950 Offset: 0x2019F50 VA: 0x18201B950
	public static InputMessage DeserializeLength(Stream stream, int length, InputMessage instance, bool isDelta) { }

	// RVA: 0x201C820 Offset: 0x201AE20 VA: 0x18201C820
	public static void SerializeDelta(Stream stream, InputMessage instance, InputMessage previous) { }

	// RVA: 0x201CDE0 Offset: 0x201B3E0 VA: 0x18201CDE0
	public static void Serialize(Stream stream, InputMessage instance) { }

	// RVA: 0x201D040 Offset: 0x201B640 VA: 0x18201D040
	public byte[] ToProtoBytes() { }

	// RVA: 0x201D050 Offset: 0x201B650 VA: 0x18201D050
	public void ToProto(Stream stream) { }

	// RVA: 0x201CCD0 Offset: 0x201B2D0 VA: 0x18201CCD0
	public static byte[] SerializeToBytes(InputMessage instance) { }

	// RVA: 0x201CC20 Offset: 0x201B220 VA: 0x18201CC20
	public static void SerializeLengthDelimited(Stream stream, InputMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

