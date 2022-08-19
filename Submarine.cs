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

	// RVA: 0x1DC4A10 Offset: 0x1DC3010 VA: 0x181DC4A10
	public static void ResetToPool(Submarine instance) { }

	// RVA: 0x1DC4AF0 Offset: 0x1DC30F0 VA: 0x181DC4AF0
	public void ResetToPool() { }

	// RVA: 0x1DC4550 Offset: 0x1DC2B50 VA: 0x181DC4550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC2C70 Offset: 0x1DC1270 VA: 0x181DC2C70
	public void CopyTo(Submarine instance) { }

	// RVA: 0x1DC2CC0 Offset: 0x1DC12C0 VA: 0x181DC2CC0
	public Submarine Copy() { }

	// RVA: 0x1DC3DC0 Offset: 0x1DC23C0 VA: 0x181DC3DC0
	public static Submarine Deserialize(Stream stream) { }

	// RVA: 0x1DC3160 Offset: 0x1DC1760 VA: 0x181DC3160
	public static Submarine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC31E0 Offset: 0x1DC17E0 VA: 0x181DC31E0
	public static Submarine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC3980 Offset: 0x1DC1F80 VA: 0x181DC3980
	public static Submarine Deserialize(byte[] buffer) { }

	// RVA: 0x1DC46C0 Offset: 0x1DC2CC0 VA: 0x181DC46C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC5310 Offset: 0x1DC3910 VA: 0x181DC5310 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC5330 Offset: 0x1DC3930 VA: 0x181DC5330 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

	// RVA: 0x1DC49F0 Offset: 0x1DC2FF0 VA: 0x181DC49F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC4130 Offset: 0x1DC2730 VA: 0x181DC4130
	public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

	// RVA: 0x1DC3650 Offset: 0x1DC1C50 VA: 0x181DC3650
	public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC2D60 Offset: 0x1DC1360 VA: 0x181DC2D60
	public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC3270 Offset: 0x1DC1870 VA: 0x181DC3270
	public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC4BD0 Offset: 0x1DC31D0 VA: 0x181DC4BD0
	public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

	// RVA: 0x1DC5120 Offset: 0x1DC3720 VA: 0x181DC5120
	public static void Serialize(Stream stream, Submarine instance) { }

	// RVA: 0x1DC5300 Offset: 0x1DC3900 VA: 0x181DC5300
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC5310 Offset: 0x1DC3910 VA: 0x181DC5310
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC5010 Offset: 0x1DC3610 VA: 0x181DC5010
	public static byte[] SerializeToBytes(Submarine instance) { }

	// RVA: 0x1DC4F60 Offset: 0x1DC3560 VA: 0x181DC4F60
	public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

