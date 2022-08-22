public class InputMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6276
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int buttons; // 0x14
	public Vector3 aimAngles; // 0x18
	public Vector3 mouseDelta; // 0x24

	// Methods

	// RVA: 0x201D260 Offset: 0x201B860 VA: 0x18201D260
	public static void ResetToPool(InputMessage instance) { }

	// RVA: 0x201D1C0 Offset: 0x201B7C0 VA: 0x18201D1C0
	public void ResetToPool() { }

	// RVA: 0x201CF60 Offset: 0x201B560 VA: 0x18201CF60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201BFC0 Offset: 0x201A5C0 VA: 0x18201BFC0
	public void CopyTo(InputMessage instance) { }

	// RVA: 0x201C000 Offset: 0x201A600 VA: 0x18201C000
	public InputMessage Copy() { }

	// RVA: 0x201C690 Offset: 0x201AC90 VA: 0x18201C690
	public static InputMessage Deserialize(Stream stream) { }

	// RVA: 0x201C320 Offset: 0x201A920 VA: 0x18201C320
	public static InputMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201C3A0 Offset: 0x201A9A0 VA: 0x18201C3A0
	public static InputMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201C890 Offset: 0x201AE90 VA: 0x18201C890
	public static InputMessage Deserialize(byte[] buffer) { }

	// RVA: 0x201CFE0 Offset: 0x201B5E0 VA: 0x18201CFE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201DB30 Offset: 0x201C130 VA: 0x18201DB30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201DB50 Offset: 0x201C150 VA: 0x18201DB50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InputMessage previous) { }

	// RVA: 0x201D1A0 Offset: 0x201B7A0 VA: 0x18201D1A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201CCE0 Offset: 0x201B2E0 VA: 0x18201CCE0
	public static InputMessage Deserialize(byte[] buffer, InputMessage instance, bool isDelta = False) { }

	// RVA: 0x201CB20 Offset: 0x201B120 VA: 0x18201CB20
	public static InputMessage Deserialize(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201C090 Offset: 0x201A690 VA: 0x18201C090
	public static InputMessage DeserializeLengthDelimited(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x201C430 Offset: 0x201AA30 VA: 0x18201C430
	public static InputMessage DeserializeLength(Stream stream, int length, InputMessage instance, bool isDelta) { }

	// RVA: 0x201D300 Offset: 0x201B900 VA: 0x18201D300
	public static void SerializeDelta(Stream stream, InputMessage instance, InputMessage previous) { }

	// RVA: 0x201D8C0 Offset: 0x201BEC0 VA: 0x18201D8C0
	public static void Serialize(Stream stream, InputMessage instance) { }

	// RVA: 0x201DB20 Offset: 0x201C120 VA: 0x18201DB20
	public byte[] ToProtoBytes() { }

	// RVA: 0x201DB30 Offset: 0x201C130 VA: 0x18201DB30
	public void ToProto(Stream stream) { }

	// RVA: 0x201D7B0 Offset: 0x201BDB0 VA: 0x18201D7B0
	public static byte[] SerializeToBytes(InputMessage instance) { }

	// RVA: 0x201D700 Offset: 0x201BD00 VA: 0x18201D700
	public static void SerializeLengthDelimited(Stream stream, InputMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

