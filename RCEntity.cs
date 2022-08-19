public class RCEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aim; // 0x14
	public float zoom; // 0x20
	public string identifier; // 0x28
	public string password; // 0x30

	// Methods

	// RVA: 0x204F900 Offset: 0x204DF00 VA: 0x18204F900
	public static void ResetToPool(RCEntity instance) { }

	// RVA: 0x204F9F0 Offset: 0x204DFF0 VA: 0x18204F9F0
	public void ResetToPool() { }

	// RVA: 0x204F550 Offset: 0x204DB50 VA: 0x18204F550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204E2B0 Offset: 0x204C8B0 VA: 0x18204E2B0
	public void CopyTo(RCEntity instance) { }

	// RVA: 0x204E310 Offset: 0x204C910 VA: 0x18204E310
	public RCEntity Copy() { }

	// RVA: 0x204EFD0 Offset: 0x204D5D0 VA: 0x18204EFD0
	public static RCEntity Deserialize(Stream stream) { }

	// RVA: 0x204E3C0 Offset: 0x204C9C0 VA: 0x18204E3C0
	public static RCEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204EA10 Offset: 0x204D010 VA: 0x18204EA10
	public static RCEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204F240 Offset: 0x204D840 VA: 0x18204F240
	public static RCEntity Deserialize(byte[] buffer) { }

	// RVA: 0x204F6B0 Offset: 0x204DCB0 VA: 0x18204F6B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2050290 Offset: 0x204E890 VA: 0x182050290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20502B0 Offset: 0x204E8B0 VA: 0x1820502B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RCEntity previous) { }

	// RVA: 0x204F8E0 Offset: 0x204DEE0 VA: 0x18204F8E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204ECE0 Offset: 0x204D2E0 VA: 0x18204ECE0
	public static RCEntity Deserialize(byte[] buffer, RCEntity instance, bool isDelta = False) { }

	// RVA: 0x204EAA0 Offset: 0x204D0A0 VA: 0x18204EAA0
	public static RCEntity Deserialize(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204E440 Offset: 0x204CA40 VA: 0x18204E440
	public static RCEntity DeserializeLengthDelimited(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204E740 Offset: 0x204CD40 VA: 0x18204E740
	public static RCEntity DeserializeLength(Stream stream, int length, RCEntity instance, bool isDelta) { }

	// RVA: 0x204FAE0 Offset: 0x204E0E0 VA: 0x18204FAE0
	public static void SerializeDelta(Stream stream, RCEntity instance, RCEntity previous) { }

	// RVA: 0x2050020 Offset: 0x204E620 VA: 0x182050020
	public static void Serialize(Stream stream, RCEntity instance) { }

	// RVA: 0x2050280 Offset: 0x204E880 VA: 0x182050280
	public byte[] ToProtoBytes() { }

	// RVA: 0x2050290 Offset: 0x204E890 VA: 0x182050290
	public void ToProto(Stream stream) { }

	// RVA: 0x204FF10 Offset: 0x204E510 VA: 0x18204FF10
	public static byte[] SerializeToBytes(RCEntity instance) { }

	// RVA: 0x204FE60 Offset: 0x204E460 VA: 0x18204FE60
	public static void SerializeLengthDelimited(Stream stream, RCEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

