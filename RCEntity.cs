public class RCEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aim; // 0x14
	public float zoom; // 0x20
	public string identifier; // 0x28
	public string password; // 0x30

	// Methods

	// RVA: 0x2050220 Offset: 0x204E820 VA: 0x182050220
	public static void ResetToPool(RCEntity instance) { }

	// RVA: 0x2050310 Offset: 0x204E910 VA: 0x182050310
	public void ResetToPool() { }

	// RVA: 0x204FE70 Offset: 0x204E470 VA: 0x18204FE70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204EBD0 Offset: 0x204D1D0 VA: 0x18204EBD0
	public void CopyTo(RCEntity instance) { }

	// RVA: 0x204EC30 Offset: 0x204D230 VA: 0x18204EC30
	public RCEntity Copy() { }

	// RVA: 0x204F8F0 Offset: 0x204DEF0 VA: 0x18204F8F0
	public static RCEntity Deserialize(Stream stream) { }

	// RVA: 0x204ECE0 Offset: 0x204D2E0 VA: 0x18204ECE0
	public static RCEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204F330 Offset: 0x204D930 VA: 0x18204F330
	public static RCEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204FB60 Offset: 0x204E160 VA: 0x18204FB60
	public static RCEntity Deserialize(byte[] buffer) { }

	// RVA: 0x204FFD0 Offset: 0x204E5D0 VA: 0x18204FFD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2050BB0 Offset: 0x204F1B0 VA: 0x182050BB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2050BD0 Offset: 0x204F1D0 VA: 0x182050BD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RCEntity previous) { }

	// RVA: 0x2050200 Offset: 0x204E800 VA: 0x182050200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204F600 Offset: 0x204DC00 VA: 0x18204F600
	public static RCEntity Deserialize(byte[] buffer, RCEntity instance, bool isDelta = False) { }

	// RVA: 0x204F3C0 Offset: 0x204D9C0 VA: 0x18204F3C0
	public static RCEntity Deserialize(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204ED60 Offset: 0x204D360 VA: 0x18204ED60
	public static RCEntity DeserializeLengthDelimited(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204F060 Offset: 0x204D660 VA: 0x18204F060
	public static RCEntity DeserializeLength(Stream stream, int length, RCEntity instance, bool isDelta) { }

	// RVA: 0x2050400 Offset: 0x204EA00 VA: 0x182050400
	public static void SerializeDelta(Stream stream, RCEntity instance, RCEntity previous) { }

	// RVA: 0x2050940 Offset: 0x204EF40 VA: 0x182050940
	public static void Serialize(Stream stream, RCEntity instance) { }

	// RVA: 0x2050BA0 Offset: 0x204F1A0 VA: 0x182050BA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2050BB0 Offset: 0x204F1B0 VA: 0x182050BB0
	public void ToProto(Stream stream) { }

	// RVA: 0x2050830 Offset: 0x204EE30 VA: 0x182050830
	public static byte[] SerializeToBytes(RCEntity instance) { }

	// RVA: 0x2050780 Offset: 0x204ED80 VA: 0x182050780
	public static void SerializeLengthDelimited(Stream stream, RCEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

