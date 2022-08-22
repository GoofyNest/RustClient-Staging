public class CargoPlane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6428
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 startPos; // 0x14
	public Vector3 endPos; // 0x20
	public float secondsToTake; // 0x2C
	public float secondsTaken; // 0x30
	public bool dropped; // 0x34
	public Vector3 dropPosition; // 0x38

	// Methods

	// RVA: 0x20A6210 Offset: 0x20A4810 VA: 0x1820A6210
	public static void ResetToPool(CargoPlane instance) { }

	// RVA: 0x20A6140 Offset: 0x20A4740 VA: 0x1820A6140
	public void ResetToPool() { }

	// RVA: 0x20A5A30 Offset: 0x20A4030 VA: 0x1820A5A30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A42D0 Offset: 0x20A28D0 VA: 0x1820A42D0
	public void CopyTo(CargoPlane instance) { }

	// RVA: 0x20A4330 Offset: 0x20A2930 VA: 0x1820A4330
	public CargoPlane Copy() { }

	// RVA: 0x20A50D0 Offset: 0x20A36D0 VA: 0x1820A50D0
	public static CargoPlane Deserialize(Stream stream) { }

	// RVA: 0x20A43E0 Offset: 0x20A29E0 VA: 0x1820A43E0
	public static CargoPlane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A47B0 Offset: 0x20A2DB0 VA: 0x1820A47B0
	public static CargoPlane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A5380 Offset: 0x20A3980 VA: 0x1820A5380
	public static CargoPlane Deserialize(byte[] buffer) { }

	// RVA: 0x20A5B90 Offset: 0x20A4190 VA: 0x1820A5B90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A6E10 Offset: 0x20A5410 VA: 0x1820A6E10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A6E30 Offset: 0x20A5430 VA: 0x1820A6E30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CargoPlane previous) { }

	// RVA: 0x20A5E10 Offset: 0x20A4410 VA: 0x1820A5E10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A56E0 Offset: 0x20A3CE0 VA: 0x1820A56E0
	public static CargoPlane Deserialize(byte[] buffer, CargoPlane instance, bool isDelta = False) { }

	// RVA: 0x20A4E50 Offset: 0x20A3450 VA: 0x1820A4E50
	public static CargoPlane Deserialize(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A4460 Offset: 0x20A2A60 VA: 0x1820A4460
	public static CargoPlane DeserializeLengthDelimited(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A4B20 Offset: 0x20A3120 VA: 0x1820A4B20
	public static CargoPlane DeserializeLength(Stream stream, int length, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A62E0 Offset: 0x20A48E0 VA: 0x1820A62E0
	public static void SerializeDelta(Stream stream, CargoPlane instance, CargoPlane previous) { }

	// RVA: 0x20A6A90 Offset: 0x20A5090 VA: 0x1820A6A90
	public static void Serialize(Stream stream, CargoPlane instance) { }

	// RVA: 0x20A6E00 Offset: 0x20A5400 VA: 0x1820A6E00
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A6E10 Offset: 0x20A5410 VA: 0x1820A6E10
	public void ToProto(Stream stream) { }

	// RVA: 0x20A6980 Offset: 0x20A4F80 VA: 0x1820A6980
	public static byte[] SerializeToBytes(CargoPlane instance) { }

	// RVA: 0x20A68D0 Offset: 0x20A4ED0 VA: 0x1820A68D0
	public static void SerializeLengthDelimited(Stream stream, CargoPlane instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CargoPlane : BaseEntity // TypeDefIndex: 9816
{	// Fields
	public GameObjectRef prefabDrop; // 0x168
	public SpawnFilter filter; // 0x170

	// Methods

	// RVA: 0x52A160 Offset: 0x528760 VA: 0x18052A160
	public void .ctor() { }

}

