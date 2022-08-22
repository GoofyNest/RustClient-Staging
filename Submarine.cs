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

	// RVA: 0x1DC4B10 Offset: 0x1DC3110 VA: 0x181DC4B10
	public static void ResetToPool(Submarine instance) { }

	// RVA: 0x1DC4BF0 Offset: 0x1DC31F0 VA: 0x181DC4BF0
	public void ResetToPool() { }

	// RVA: 0x1DC4650 Offset: 0x1DC2C50 VA: 0x181DC4650 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC2D70 Offset: 0x1DC1370 VA: 0x181DC2D70
	public void CopyTo(Submarine instance) { }

	// RVA: 0x1DC2DC0 Offset: 0x1DC13C0 VA: 0x181DC2DC0
	public Submarine Copy() { }

	// RVA: 0x1DC3EC0 Offset: 0x1DC24C0 VA: 0x181DC3EC0
	public static Submarine Deserialize(Stream stream) { }

	// RVA: 0x1DC3260 Offset: 0x1DC1860 VA: 0x181DC3260
	public static Submarine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC32E0 Offset: 0x1DC18E0 VA: 0x181DC32E0
	public static Submarine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC3A80 Offset: 0x1DC2080 VA: 0x181DC3A80
	public static Submarine Deserialize(byte[] buffer) { }

	// RVA: 0x1DC47C0 Offset: 0x1DC2DC0 VA: 0x181DC47C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC5410 Offset: 0x1DC3A10 VA: 0x181DC5410 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC5430 Offset: 0x1DC3A30 VA: 0x181DC5430 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

	// RVA: 0x1DC4AF0 Offset: 0x1DC30F0 VA: 0x181DC4AF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC4230 Offset: 0x1DC2830 VA: 0x181DC4230
	public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

	// RVA: 0x1DC3750 Offset: 0x1DC1D50 VA: 0x181DC3750
	public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC2E60 Offset: 0x1DC1460 VA: 0x181DC2E60
	public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC3370 Offset: 0x1DC1970 VA: 0x181DC3370
	public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC4CD0 Offset: 0x1DC32D0 VA: 0x181DC4CD0
	public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

	// RVA: 0x1DC5220 Offset: 0x1DC3820 VA: 0x181DC5220
	public static void Serialize(Stream stream, Submarine instance) { }

	// RVA: 0x1DC5400 Offset: 0x1DC3A00 VA: 0x181DC5400
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC5410 Offset: 0x1DC3A10 VA: 0x181DC5410
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC5110 Offset: 0x1DC3710 VA: 0x181DC5110
	public static byte[] SerializeToBytes(Submarine instance) { }

	// RVA: 0x1DC5060 Offset: 0x1DC3660 VA: 0x181DC5060
	public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

