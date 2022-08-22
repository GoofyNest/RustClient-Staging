public class RCEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aim; // 0x14
	public float zoom; // 0x20
	public string identifier; // 0x28
	public string password; // 0x30

	// Methods

	// RVA: 0x204F740 Offset: 0x204DD40 VA: 0x18204F740
	public static void ResetToPool(RCEntity instance) { }

	// RVA: 0x204F830 Offset: 0x204DE30 VA: 0x18204F830
	public void ResetToPool() { }

	// RVA: 0x204F390 Offset: 0x204D990 VA: 0x18204F390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204E0F0 Offset: 0x204C6F0 VA: 0x18204E0F0
	public void CopyTo(RCEntity instance) { }

	// RVA: 0x204E150 Offset: 0x204C750 VA: 0x18204E150
	public RCEntity Copy() { }

	// RVA: 0x204EE10 Offset: 0x204D410 VA: 0x18204EE10
	public static RCEntity Deserialize(Stream stream) { }

	// RVA: 0x204E200 Offset: 0x204C800 VA: 0x18204E200
	public static RCEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204E850 Offset: 0x204CE50 VA: 0x18204E850
	public static RCEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204F080 Offset: 0x204D680 VA: 0x18204F080
	public static RCEntity Deserialize(byte[] buffer) { }

	// RVA: 0x204F4F0 Offset: 0x204DAF0 VA: 0x18204F4F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20500D0 Offset: 0x204E6D0 VA: 0x1820500D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20500F0 Offset: 0x204E6F0 VA: 0x1820500F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RCEntity previous) { }

	// RVA: 0x204F720 Offset: 0x204DD20 VA: 0x18204F720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204EB20 Offset: 0x204D120 VA: 0x18204EB20
	public static RCEntity Deserialize(byte[] buffer, RCEntity instance, bool isDelta = False) { }

	// RVA: 0x204E8E0 Offset: 0x204CEE0 VA: 0x18204E8E0
	public static RCEntity Deserialize(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204E280 Offset: 0x204C880 VA: 0x18204E280
	public static RCEntity DeserializeLengthDelimited(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x204E580 Offset: 0x204CB80 VA: 0x18204E580
	public static RCEntity DeserializeLength(Stream stream, int length, RCEntity instance, bool isDelta) { }

	// RVA: 0x204F920 Offset: 0x204DF20 VA: 0x18204F920
	public static void SerializeDelta(Stream stream, RCEntity instance, RCEntity previous) { }

	// RVA: 0x204FE60 Offset: 0x204E460 VA: 0x18204FE60
	public static void Serialize(Stream stream, RCEntity instance) { }

	// RVA: 0x20500C0 Offset: 0x204E6C0 VA: 0x1820500C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20500D0 Offset: 0x204E6D0 VA: 0x1820500D0
	public void ToProto(Stream stream) { }

	// RVA: 0x204FD50 Offset: 0x204E350 VA: 0x18204FD50
	public static byte[] SerializeToBytes(RCEntity instance) { }

	// RVA: 0x204FCA0 Offset: 0x204E2A0 VA: 0x18204FCA0
	public static void SerializeLengthDelimited(Stream stream, RCEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

