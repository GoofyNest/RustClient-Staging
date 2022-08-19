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

	// RVA: 0x20A6110 Offset: 0x20A4710 VA: 0x1820A6110
	public static void ResetToPool(CargoPlane instance) { }

	// RVA: 0x20A6040 Offset: 0x20A4640 VA: 0x1820A6040
	public void ResetToPool() { }

	// RVA: 0x20A5930 Offset: 0x20A3F30 VA: 0x1820A5930 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A41D0 Offset: 0x20A27D0 VA: 0x1820A41D0
	public void CopyTo(CargoPlane instance) { }

	// RVA: 0x20A4230 Offset: 0x20A2830 VA: 0x1820A4230
	public CargoPlane Copy() { }

	// RVA: 0x20A4FD0 Offset: 0x20A35D0 VA: 0x1820A4FD0
	public static CargoPlane Deserialize(Stream stream) { }

	// RVA: 0x20A42E0 Offset: 0x20A28E0 VA: 0x1820A42E0
	public static CargoPlane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A46B0 Offset: 0x20A2CB0 VA: 0x1820A46B0
	public static CargoPlane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A5280 Offset: 0x20A3880 VA: 0x1820A5280
	public static CargoPlane Deserialize(byte[] buffer) { }

	// RVA: 0x20A5A90 Offset: 0x20A4090 VA: 0x1820A5A90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A6D10 Offset: 0x20A5310 VA: 0x1820A6D10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A6D30 Offset: 0x20A5330 VA: 0x1820A6D30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CargoPlane previous) { }

	// RVA: 0x20A5D10 Offset: 0x20A4310 VA: 0x1820A5D10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A55E0 Offset: 0x20A3BE0 VA: 0x1820A55E0
	public static CargoPlane Deserialize(byte[] buffer, CargoPlane instance, bool isDelta = False) { }

	// RVA: 0x20A4D50 Offset: 0x20A3350 VA: 0x1820A4D50
	public static CargoPlane Deserialize(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A4360 Offset: 0x20A2960 VA: 0x1820A4360
	public static CargoPlane DeserializeLengthDelimited(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A4A20 Offset: 0x20A3020 VA: 0x1820A4A20
	public static CargoPlane DeserializeLength(Stream stream, int length, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A61E0 Offset: 0x20A47E0 VA: 0x1820A61E0
	public static void SerializeDelta(Stream stream, CargoPlane instance, CargoPlane previous) { }

	// RVA: 0x20A6990 Offset: 0x20A4F90 VA: 0x1820A6990
	public static void Serialize(Stream stream, CargoPlane instance) { }

	// RVA: 0x20A6D00 Offset: 0x20A5300 VA: 0x1820A6D00
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A6D10 Offset: 0x20A5310 VA: 0x1820A6D10
	public void ToProto(Stream stream) { }

	// RVA: 0x20A6880 Offset: 0x20A4E80 VA: 0x1820A6880
	public static byte[] SerializeToBytes(CargoPlane instance) { }

	// RVA: 0x20A67D0 Offset: 0x20A4DD0 VA: 0x1820A67D0
	public static void SerializeLengthDelimited(Stream stream, CargoPlane instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

