public class InputMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6276
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int buttons; // 0x14
	public Vector3 aimAngles; // 0x18
	public Vector3 mouseDelta; // 0x24

	// Methods

	// RVA: 0x201CA40 Offset: 0x201B040 VA: 0x18201CA40
	public static void ResetToPool(InputMessage instance) { }

	// RVA: 0x201C9A0 Offset: 0x201AFA0 VA: 0x18201C9A0
	public void ResetToPool() { }

	// RVA: 0x201C740 Offset: 0x201AD40 VA: 0x18201C740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201B7A0 Offset: 0x2019DA0 VA: 0x18201B7A0
	public void CopyTo(InputMessage instance) { }

	// RVA: 0x201B7E0 Offset: 0x2019DE0 VA: 0x18201B7E0
	public InputMessage Copy() { }

	// RVA: 0x201BE70 Offset: 0x201A470 VA: 0x18201BE70
	public static InputMessage Deserialize(Stream stream) { }

	// RVA: 0x201BB00 Offset: 0x201A100 VA: 0x18201BB00
	public static InputMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201BB80 Offset: 0x201A180 VA: 0x18201BB80
	public static InputMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201C070 Offset: 0x201A670 VA: 0x18201C070
	public static InputMessage Deserialize(byte[] buffer) { }

	// RVA: 0x201C7C0 Offset: 0x201ADC0 VA: 0x18201C7C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201D310 Offset: 0x201B910 VA: 0x18201D310 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201D330 Offset: 0x201B930 VA: 0x18201D330 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InputMessage previous) { }

	// RVA: 0x201C980 Offset: 0x201AF80 VA: 0x18201C980 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201C4C0 Offset: 0x201AAC0 VA: 0x18201C4C0
	public static InputMessage Deserialize(byte[] buffer, InputMessage instance, bool isDelta = False) { }

	// RVA: 0x201C300 Offset: 0x201A900 VA: 0x18201C300
	public static InputMessage Deserialize(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201B870 Offset: 0x2019E70 VA: 0x18201B870
	public static InputMessage DeserializeLengthDelimited(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201BC10 Offset: 0x201A210 VA: 0x18201BC10
	public static InputMessage DeserializeLength(Stream stream, int length, InputMessage instance, bool isDelta) { }

	// RVA: 0x201CAE0 Offset: 0x201B0E0 VA: 0x18201CAE0
	public static void SerializeDelta(Stream stream, InputMessage instance, InputMessage previous) { }

	// RVA: 0x201D0A0 Offset: 0x201B6A0 VA: 0x18201D0A0
	public static void Serialize(Stream stream, InputMessage instance) { }

	// RVA: 0x201D300 Offset: 0x201B900 VA: 0x18201D300
	public byte[] ToProtoBytes() { }

	// RVA: 0x201D310 Offset: 0x201B910 VA: 0x18201D310
	public void ToProto(Stream stream) { }

	// RVA: 0x201CF90 Offset: 0x201B590 VA: 0x18201CF90
	public static byte[] SerializeToBytes(InputMessage instance) { }

	// RVA: 0x201CEE0 Offset: 0x201B4E0 VA: 0x18201CEE0
	public static void SerializeLengthDelimited(Stream stream, InputMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

