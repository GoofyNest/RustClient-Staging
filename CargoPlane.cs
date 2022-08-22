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

	// RVA: 0x20A5F50 Offset: 0x20A4550 VA: 0x1820A5F50
	public static void ResetToPool(CargoPlane instance) { }

	// RVA: 0x20A5E80 Offset: 0x20A4480 VA: 0x1820A5E80
	public void ResetToPool() { }

	// RVA: 0x20A5770 Offset: 0x20A3D70 VA: 0x1820A5770 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A4010 Offset: 0x20A2610 VA: 0x1820A4010
	public void CopyTo(CargoPlane instance) { }

	// RVA: 0x20A4070 Offset: 0x20A2670 VA: 0x1820A4070
	public CargoPlane Copy() { }

	// RVA: 0x20A4E10 Offset: 0x20A3410 VA: 0x1820A4E10
	public static CargoPlane Deserialize(Stream stream) { }

	// RVA: 0x20A4120 Offset: 0x20A2720 VA: 0x1820A4120
	public static CargoPlane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A44F0 Offset: 0x20A2AF0 VA: 0x1820A44F0
	public static CargoPlane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A50C0 Offset: 0x20A36C0 VA: 0x1820A50C0
	public static CargoPlane Deserialize(byte[] buffer) { }

	// RVA: 0x20A58D0 Offset: 0x20A3ED0 VA: 0x1820A58D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A6B50 Offset: 0x20A5150 VA: 0x1820A6B50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A6B70 Offset: 0x20A5170 VA: 0x1820A6B70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CargoPlane previous) { }

	// RVA: 0x20A5B50 Offset: 0x20A4150 VA: 0x1820A5B50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A5420 Offset: 0x20A3A20 VA: 0x1820A5420
	public static CargoPlane Deserialize(byte[] buffer, CargoPlane instance, bool isDelta = False) { }

	// RVA: 0x20A4B90 Offset: 0x20A3190 VA: 0x1820A4B90
	public static CargoPlane Deserialize(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A41A0 Offset: 0x20A27A0 VA: 0x1820A41A0
	public static CargoPlane DeserializeLengthDelimited(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A4860 Offset: 0x20A2E60 VA: 0x1820A4860
	public static CargoPlane DeserializeLength(Stream stream, int length, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A6020 Offset: 0x20A4620 VA: 0x1820A6020
	public static void SerializeDelta(Stream stream, CargoPlane instance, CargoPlane previous) { }

	// RVA: 0x20A67D0 Offset: 0x20A4DD0 VA: 0x1820A67D0
	public static void Serialize(Stream stream, CargoPlane instance) { }

	// RVA: 0x20A6B40 Offset: 0x20A5140 VA: 0x1820A6B40
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A6B50 Offset: 0x20A5150 VA: 0x1820A6B50
	public void ToProto(Stream stream) { }

	// RVA: 0x20A66C0 Offset: 0x20A4CC0 VA: 0x1820A66C0
	public static byte[] SerializeToBytes(CargoPlane instance) { }

	// RVA: 0x20A6610 Offset: 0x20A4C10 VA: 0x1820A6610
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

