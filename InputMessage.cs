public class InputMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6276
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int buttons; // 0x14
	public Vector3 aimAngles; // 0x18
	public Vector3 mouseDelta; // 0x24

	// Methods

	// RVA: 0x201C940 Offset: 0x201AF40 VA: 0x18201C940
	public static void ResetToPool(InputMessage instance) { }

	// RVA: 0x201C8A0 Offset: 0x201AEA0 VA: 0x18201C8A0
	public void ResetToPool() { }

	// RVA: 0x201C640 Offset: 0x201AC40 VA: 0x18201C640 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201B6A0 Offset: 0x2019CA0 VA: 0x18201B6A0
	public void CopyTo(InputMessage instance) { }

	// RVA: 0x201B6E0 Offset: 0x2019CE0 VA: 0x18201B6E0
	public InputMessage Copy() { }

	// RVA: 0x201BD70 Offset: 0x201A370 VA: 0x18201BD70
	public static InputMessage Deserialize(Stream stream) { }

	// RVA: 0x201BA00 Offset: 0x201A000 VA: 0x18201BA00
	public static InputMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201BA80 Offset: 0x201A080 VA: 0x18201BA80
	public static InputMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201BF70 Offset: 0x201A570 VA: 0x18201BF70
	public static InputMessage Deserialize(byte[] buffer) { }

	// RVA: 0x201C6C0 Offset: 0x201ACC0 VA: 0x18201C6C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201D210 Offset: 0x201B810 VA: 0x18201D210 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201D230 Offset: 0x201B830 VA: 0x18201D230 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InputMessage previous) { }

	// RVA: 0x201C880 Offset: 0x201AE80 VA: 0x18201C880 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201C3C0 Offset: 0x201A9C0 VA: 0x18201C3C0
	public static InputMessage Deserialize(byte[] buffer, InputMessage instance, bool isDelta = False) { }

	// RVA: 0x201C200 Offset: 0x201A800 VA: 0x18201C200
	public static InputMessage Deserialize(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201B770 Offset: 0x2019D70 VA: 0x18201B770
	public static InputMessage DeserializeLengthDelimited(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201BB10 Offset: 0x201A110 VA: 0x18201BB10
	public static InputMessage DeserializeLength(Stream stream, int length, InputMessage instance, bool isDelta) { }

	// RVA: 0x201C9E0 Offset: 0x201AFE0 VA: 0x18201C9E0
	public static void SerializeDelta(Stream stream, InputMessage instance, InputMessage previous) { }

	// RVA: 0x201CFA0 Offset: 0x201B5A0 VA: 0x18201CFA0
	public static void Serialize(Stream stream, InputMessage instance) { }

	// RVA: 0x201D200 Offset: 0x201B800 VA: 0x18201D200
	public byte[] ToProtoBytes() { }

	// RVA: 0x201D210 Offset: 0x201B810 VA: 0x18201D210
	public void ToProto(Stream stream) { }

	// RVA: 0x201CE90 Offset: 0x201B490 VA: 0x18201CE90
	public static byte[] SerializeToBytes(InputMessage instance) { }

	// RVA: 0x201CDE0 Offset: 0x201B3E0 VA: 0x18201CDE0
	public static void SerializeLengthDelimited(Stream stream, InputMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

