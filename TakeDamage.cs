public class TakeDamage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6480
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float amount; // 0x14
	public Vector3 direction; // 0x18
	public int type; // 0x24

	// Methods

	// RVA: 0x1DC6FA0 Offset: 0x1DC55A0 VA: 0x181DC6FA0
	public static void ResetToPool(TakeDamage instance) { }

	// RVA: 0x1DC6F00 Offset: 0x1DC5500 VA: 0x181DC6F00
	public void ResetToPool() { }

	// RVA: 0x1DC6BF0 Offset: 0x1DC51F0 VA: 0x181DC6BF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC5C40 Offset: 0x1DC4240 VA: 0x181DC5C40
	public void CopyTo(TakeDamage instance) { }

	// RVA: 0x1DC5C70 Offset: 0x1DC4270 VA: 0x181DC5C70
	public TakeDamage Copy() { }

	// RVA: 0x1DC69F0 Offset: 0x1DC4FF0 VA: 0x181DC69F0
	public static TakeDamage Deserialize(Stream stream) { }

	// RVA: 0x1DC5F80 Offset: 0x1DC4580 VA: 0x181DC5F80
	public static TakeDamage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC6000 Offset: 0x1DC4600 VA: 0x181DC6000
	public static TakeDamage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC64D0 Offset: 0x1DC4AD0 VA: 0x181DC64D0
	public static TakeDamage Deserialize(byte[] buffer) { }

	// RVA: 0x1DC6D10 Offset: 0x1DC5310 VA: 0x181DC6D10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC76E0 Offset: 0x1DC5CE0 VA: 0x181DC76E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC7700 Offset: 0x1DC5D00 VA: 0x181DC7700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TakeDamage previous) { }

	// RVA: 0x1DC6EE0 Offset: 0x1DC54E0 VA: 0x181DC6EE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC6770 Offset: 0x1DC4D70 VA: 0x181DC6770
	public static TakeDamage Deserialize(byte[] buffer, TakeDamage instance, bool isDelta = False) { }

	// RVA: 0x1DC6300 Offset: 0x1DC4900 VA: 0x181DC6300
	public static TakeDamage Deserialize(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC5CF0 Offset: 0x1DC42F0 VA: 0x181DC5CF0
	public static TakeDamage DeserializeLengthDelimited(Stream stream, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC6090 Offset: 0x1DC4690 VA: 0x181DC6090
	public static TakeDamage DeserializeLength(Stream stream, int length, TakeDamage instance, bool isDelta) { }

	// RVA: 0x1DC7040 Offset: 0x1DC5640 VA: 0x181DC7040
	public static void SerializeDelta(Stream stream, TakeDamage instance, TakeDamage previous) { }

	// RVA: 0x1DC7500 Offset: 0x1DC5B00 VA: 0x181DC7500
	public static void Serialize(Stream stream, TakeDamage instance) { }

	// RVA: 0x1DC76D0 Offset: 0x1DC5CD0 VA: 0x181DC76D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC76E0 Offset: 0x1DC5CE0 VA: 0x181DC76E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC73F0 Offset: 0x1DC59F0 VA: 0x181DC73F0
	public static byte[] SerializeToBytes(TakeDamage instance) { }

	// RVA: 0x1DC7340 Offset: 0x1DC5940 VA: 0x181DC7340
	public static void SerializeLengthDelimited(Stream stream, TakeDamage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

