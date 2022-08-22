public class TakeDamage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6480
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float amount; // 0x14
	public Vector3 direction; // 0x18
	public int type; // 0x24

	// Methods

	// RVA: 0x1DC64F0 Offset: 0x1DC4AF0 VA: 0x181DC64F0
	public static void ResetToPool(TakeDamage instance) { }

	// RVA: 0x1DC6450 Offset: 0x1DC4A50 VA: 0x181DC6450
	public void ResetToPool() { }

	// RVA: 0x1DC6140 Offset: 0x1DC4740 VA: 0x181DC6140 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC5190 Offset: 0x1DC3790 VA: 0x181DC5190
	public void CopyTo(TakeDamage instance) { }

	// RVA: 0x1DC51C0 Offset: 0x1DC37C0 VA: 0x181DC51C0
	public TakeDamage Copy() { }

	// RVA: 0x1DC5F40 Offset: 0x1DC4540 VA: 0x181DC5F40
	public static TakeDamage Deserialize(Stream stream) { }

	// RVA: 0x1DC54D0 Offset: 0x1DC3AD0 VA: 0x181DC54D0
	public static TakeDamage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC5550 Offset: 0x1DC3B50 VA: 0x181DC5550
	public static TakeDamage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC5A20 Offset: 0x1DC4020 VA: 0x181DC5A20
	public static TakeDamage Deserialize(byte[] buffer) { }

	// RVA: 0x1DC6260 Offset: 0x1DC4860 VA: 0x181DC6260
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC6C30 Offset: 0x1DC5230 VA: 0x181DC6C30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC6C50 Offset: 0x1DC5250 VA: 0x181DC6C50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TakeDamage previous) { }

	// RVA: 0x1DC6430 Offset: 0x1DC4A30 VA: 0x181DC6430 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC5CC0 Offset: 0x1DC42C0 VA: 0x181DC5CC0
	public static TakeDamage Deserialize(byte[] buffer, TakeDamage instance, bool isDelta = False) { }

	// RVA: 0x1DC5850 Offset: 0x1DC3E50 VA: 0x181DC5850
	public static TakeDamage Deserialize(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC5240 Offset: 0x1DC3840 VA: 0x181DC5240
	public static TakeDamage DeserializeLengthDelimited(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC55E0 Offset: 0x1DC3BE0 VA: 0x181DC55E0
	public static TakeDamage DeserializeLength(Stream stream, int length, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC6590 Offset: 0x1DC4B90 VA: 0x181DC6590
	public static void SerializeDelta(Stream stream, TakeDamage instance, TakeDamage previous) { }

	// RVA: 0x1DC6A50 Offset: 0x1DC5050 VA: 0x181DC6A50
	public static void Serialize(Stream stream, TakeDamage instance) { }

	// RVA: 0x1DC6C20 Offset: 0x1DC5220 VA: 0x181DC6C20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC6C30 Offset: 0x1DC5230 VA: 0x181DC6C30
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC6940 Offset: 0x1DC4F40 VA: 0x181DC6940
	public static byte[] SerializeToBytes(TakeDamage instance) { }

	// RVA: 0x1DC6890 Offset: 0x1DC4E90 VA: 0x181DC6890
	public static void SerializeLengthDelimited(Stream stream, TakeDamage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

