public class TakeDamage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6480
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float amount; // 0x14
	public Vector3 direction; // 0x18
	public int type; // 0x24

	// Methods

	// RVA: 0x1DC66B0 Offset: 0x1DC4CB0 VA: 0x181DC66B0
	public static void ResetToPool(TakeDamage instance) { }

	// RVA: 0x1DC6610 Offset: 0x1DC4C10 VA: 0x181DC6610
	public void ResetToPool() { }

	// RVA: 0x1DC6300 Offset: 0x1DC4900 VA: 0x181DC6300 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC5350 Offset: 0x1DC3950 VA: 0x181DC5350
	public void CopyTo(TakeDamage instance) { }

	// RVA: 0x1DC5380 Offset: 0x1DC3980 VA: 0x181DC5380
	public TakeDamage Copy() { }

	// RVA: 0x1DC6100 Offset: 0x1DC4700 VA: 0x181DC6100
	public static TakeDamage Deserialize(Stream stream) { }

	// RVA: 0x1DC5690 Offset: 0x1DC3C90 VA: 0x181DC5690
	public static TakeDamage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC5710 Offset: 0x1DC3D10 VA: 0x181DC5710
	public static TakeDamage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC5BE0 Offset: 0x1DC41E0 VA: 0x181DC5BE0
	public static TakeDamage Deserialize(byte[] buffer) { }

	// RVA: 0x1DC6420 Offset: 0x1DC4A20 VA: 0x181DC6420
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC6DF0 Offset: 0x1DC53F0 VA: 0x181DC6DF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC6E10 Offset: 0x1DC5410 VA: 0x181DC6E10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TakeDamage previous) { }

	// RVA: 0x1DC65F0 Offset: 0x1DC4BF0 VA: 0x181DC65F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC5E80 Offset: 0x1DC4480 VA: 0x181DC5E80
	public static TakeDamage Deserialize(byte[] buffer, TakeDamage instance, bool isDelta = False) { }

	// RVA: 0x1DC5A10 Offset: 0x1DC4010 VA: 0x181DC5A10
	public static TakeDamage Deserialize(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC5400 Offset: 0x1DC3A00 VA: 0x181DC5400
	public static TakeDamage DeserializeLengthDelimited(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC57A0 Offset: 0x1DC3DA0 VA: 0x181DC57A0
	public static TakeDamage DeserializeLength(Stream stream, int length, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC6750 Offset: 0x1DC4D50 VA: 0x181DC6750
	public static void SerializeDelta(Stream stream, TakeDamage instance, TakeDamage previous) { }

	// RVA: 0x1DC6C10 Offset: 0x1DC5210 VA: 0x181DC6C10
	public static void Serialize(Stream stream, TakeDamage instance) { }

	// RVA: 0x1DC6DE0 Offset: 0x1DC53E0 VA: 0x181DC6DE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC6DF0 Offset: 0x1DC53F0 VA: 0x181DC6DF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC6B00 Offset: 0x1DC5100 VA: 0x181DC6B00
	public static byte[] SerializeToBytes(TakeDamage instance) { }

	// RVA: 0x1DC6A50 Offset: 0x1DC5050 VA: 0x181DC6A50
	public static void SerializeLengthDelimited(Stream stream, TakeDamage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

