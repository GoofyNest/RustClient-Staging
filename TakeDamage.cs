public class TakeDamage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6480
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float amount; // 0x14
	public Vector3 direction; // 0x18
	public int type; // 0x24

	// Methods

	// RVA: 0x1DC67B0 Offset: 0x1DC4DB0 VA: 0x181DC67B0
	public static void ResetToPool(TakeDamage instance) { }

	// RVA: 0x1DC6710 Offset: 0x1DC4D10 VA: 0x181DC6710
	public void ResetToPool() { }

	// RVA: 0x1DC6400 Offset: 0x1DC4A00 VA: 0x181DC6400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC5450 Offset: 0x1DC3A50 VA: 0x181DC5450
	public void CopyTo(TakeDamage instance) { }

	// RVA: 0x1DC5480 Offset: 0x1DC3A80 VA: 0x181DC5480
	public TakeDamage Copy() { }

	// RVA: 0x1DC6200 Offset: 0x1DC4800 VA: 0x181DC6200
	public static TakeDamage Deserialize(Stream stream) { }

	// RVA: 0x1DC5790 Offset: 0x1DC3D90 VA: 0x181DC5790
	public static TakeDamage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC5810 Offset: 0x1DC3E10 VA: 0x181DC5810
	public static TakeDamage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC5CE0 Offset: 0x1DC42E0 VA: 0x181DC5CE0
	public static TakeDamage Deserialize(byte[] buffer) { }

	// RVA: 0x1DC6520 Offset: 0x1DC4B20 VA: 0x181DC6520
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC6EF0 Offset: 0x1DC54F0 VA: 0x181DC6EF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC6F10 Offset: 0x1DC5510 VA: 0x181DC6F10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TakeDamage previous) { }

	// RVA: 0x1DC66F0 Offset: 0x1DC4CF0 VA: 0x181DC66F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC5F80 Offset: 0x1DC4580 VA: 0x181DC5F80
	public static TakeDamage Deserialize(byte[] buffer, TakeDamage instance, bool isDelta = False) { }

	// RVA: 0x1DC5B10 Offset: 0x1DC4110 VA: 0x181DC5B10
	public static TakeDamage Deserialize(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC5500 Offset: 0x1DC3B00 VA: 0x181DC5500
	public static TakeDamage DeserializeLengthDelimited(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC58A0 Offset: 0x1DC3EA0 VA: 0x181DC58A0
	public static TakeDamage DeserializeLength(Stream stream, int length, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC6850 Offset: 0x1DC4E50 VA: 0x181DC6850
	public static void SerializeDelta(Stream stream, TakeDamage instance, TakeDamage previous) { }

	// RVA: 0x1DC6D10 Offset: 0x1DC5310 VA: 0x181DC6D10
	public static void Serialize(Stream stream, TakeDamage instance) { }

	// RVA: 0x1DC6EE0 Offset: 0x1DC54E0 VA: 0x181DC6EE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC6EF0 Offset: 0x1DC54F0 VA: 0x181DC6EF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC6C00 Offset: 0x1DC5200 VA: 0x181DC6C00
	public static byte[] SerializeToBytes(TakeDamage instance) { }

	// RVA: 0x1DC6B50 Offset: 0x1DC5150 VA: 0x181DC6B50
	public static void SerializeLengthDelimited(Stream stream, TakeDamage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

