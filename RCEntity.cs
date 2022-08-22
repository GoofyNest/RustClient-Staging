public class RCEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aim; // 0x14
	public float zoom; // 0x20
	public string identifier; // 0x28
	public string password; // 0x30

	// Methods

	// RVA: 0x204FA00 Offset: 0x204E000 VA: 0x18204FA00
	public static void ResetToPool(RCEntity instance) { }

	// RVA: 0x204FAF0 Offset: 0x204E0F0 VA: 0x18204FAF0
	public void ResetToPool() { }

	// RVA: 0x204F650 Offset: 0x204DC50 VA: 0x18204F650 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204E3B0 Offset: 0x204C9B0 VA: 0x18204E3B0
	public void CopyTo(RCEntity instance) { }

	// RVA: 0x204E410 Offset: 0x204CA10 VA: 0x18204E410
	public RCEntity Copy() { }

	// RVA: 0x204F0D0 Offset: 0x204D6D0 VA: 0x18204F0D0
	public static RCEntity Deserialize(Stream stream) { }

	// RVA: 0x204E4C0 Offset: 0x204CAC0 VA: 0x18204E4C0
	public static RCEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204EB10 Offset: 0x204D110 VA: 0x18204EB10
	public static RCEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204F340 Offset: 0x204D940 VA: 0x18204F340
	public static RCEntity Deserialize(byte[] buffer) { }

	// RVA: 0x204F7B0 Offset: 0x204DDB0 VA: 0x18204F7B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2050390 Offset: 0x204E990 VA: 0x182050390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20503B0 Offset: 0x204E9B0 VA: 0x1820503B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RCEntity previous) { }

	// RVA: 0x204F9E0 Offset: 0x204DFE0 VA: 0x18204F9E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204EDE0 Offset: 0x204D3E0 VA: 0x18204EDE0
	public static RCEntity Deserialize(byte[] buffer, RCEntity instance, bool isDelta = False) { }

	// RVA: 0x204EBA0 Offset: 0x204D1A0 VA: 0x18204EBA0
	public static RCEntity Deserialize(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204E540 Offset: 0x204CB40 VA: 0x18204E540
	public static RCEntity DeserializeLengthDelimited(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204E840 Offset: 0x204CE40 VA: 0x18204E840
	public static RCEntity DeserializeLength(Stream stream, int length, RCEntity instance, bool isDelta) { }

	// RVA: 0x204FBE0 Offset: 0x204E1E0 VA: 0x18204FBE0
	public static void SerializeDelta(Stream stream, RCEntity instance, RCEntity previous) { }

	// RVA: 0x2050120 Offset: 0x204E720 VA: 0x182050120
	public static void Serialize(Stream stream, RCEntity instance) { }

	// RVA: 0x2050380 Offset: 0x204E980 VA: 0x182050380
	public byte[] ToProtoBytes() { }

	// RVA: 0x2050390 Offset: 0x204E990 VA: 0x182050390
	public void ToProto(Stream stream) { }

	// RVA: 0x2050010 Offset: 0x204E610 VA: 0x182050010
	public static byte[] SerializeToBytes(RCEntity instance) { }

	// RVA: 0x204FF60 Offset: 0x204E560 VA: 0x18204FF60
	public static void SerializeLengthDelimited(Stream stream, RCEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

