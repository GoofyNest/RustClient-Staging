public class Submarine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float throttle; // 0x14
	public float upDown; // 0x18
	public float rudder; // 0x1C
	public uint fuelStorageID; // 0x20
	public float fuelAmount; // 0x24
	public uint torpedoStorageID; // 0x28
	public float oxygen; // 0x2C
	public uint itemStorageID; // 0x30

	// Methods

	// RVA: 0x1DC4850 Offset: 0x1DC2E50 VA: 0x181DC4850
	public static void ResetToPool(Submarine instance) { }

	// RVA: 0x1DC4930 Offset: 0x1DC2F30 VA: 0x181DC4930
	public void ResetToPool() { }

	// RVA: 0x1DC4390 Offset: 0x1DC2990 VA: 0x181DC4390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC2AB0 Offset: 0x1DC10B0 VA: 0x181DC2AB0
	public void CopyTo(Submarine instance) { }

	// RVA: 0x1DC2B00 Offset: 0x1DC1100 VA: 0x181DC2B00
	public Submarine Copy() { }

	// RVA: 0x1DC3C00 Offset: 0x1DC2200 VA: 0x181DC3C00
	public static Submarine Deserialize(Stream stream) { }

	// RVA: 0x1DC2FA0 Offset: 0x1DC15A0 VA: 0x181DC2FA0
	public static Submarine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC3020 Offset: 0x1DC1620 VA: 0x181DC3020
	public static Submarine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC37C0 Offset: 0x1DC1DC0 VA: 0x181DC37C0
	public static Submarine Deserialize(byte[] buffer) { }

	// RVA: 0x1DC4500 Offset: 0x1DC2B00 VA: 0x181DC4500
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC5150 Offset: 0x1DC3750 VA: 0x181DC5150 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC5170 Offset: 0x1DC3770 VA: 0x181DC5170 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

	// RVA: 0x1DC4830 Offset: 0x1DC2E30 VA: 0x181DC4830 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC3F70 Offset: 0x1DC2570 VA: 0x181DC3F70
	public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

	// RVA: 0x1DC3490 Offset: 0x1DC1A90 VA: 0x181DC3490
	public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC2BA0 Offset: 0x1DC11A0 VA: 0x181DC2BA0
	public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC30B0 Offset: 0x1DC16B0 VA: 0x181DC30B0
	public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC4A10 Offset: 0x1DC3010 VA: 0x181DC4A10
	public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

	// RVA: 0x1DC4F60 Offset: 0x1DC3560 VA: 0x181DC4F60
	public static void Serialize(Stream stream, Submarine instance) { }

	// RVA: 0x1DC5140 Offset: 0x1DC3740 VA: 0x181DC5140
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC5150 Offset: 0x1DC3750 VA: 0x181DC5150
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC4E50 Offset: 0x1DC3450 VA: 0x181DC4E50
	public static byte[] SerializeToBytes(Submarine instance) { }

	// RVA: 0x1DC4DA0 Offset: 0x1DC33A0 VA: 0x181DC4DA0
	public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

