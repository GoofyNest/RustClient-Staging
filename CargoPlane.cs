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

	// RVA: 0x20A6A30 Offset: 0x20A5030 VA: 0x1820A6A30
	public static void ResetToPool(CargoPlane instance) { }

	// RVA: 0x20A6960 Offset: 0x20A4F60 VA: 0x1820A6960
	public void ResetToPool() { }

	// RVA: 0x20A6250 Offset: 0x20A4850 VA: 0x1820A6250 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A4AF0 Offset: 0x20A30F0 VA: 0x1820A4AF0
	public void CopyTo(CargoPlane instance) { }

	// RVA: 0x20A4B50 Offset: 0x20A3150 VA: 0x1820A4B50
	public CargoPlane Copy() { }

	// RVA: 0x20A58F0 Offset: 0x20A3EF0 VA: 0x1820A58F0
	public static CargoPlane Deserialize(Stream stream) { }

	// RVA: 0x20A4C00 Offset: 0x20A3200 VA: 0x1820A4C00
	public static CargoPlane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A4FD0 Offset: 0x20A35D0 VA: 0x1820A4FD0
	public static CargoPlane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A5BA0 Offset: 0x20A41A0 VA: 0x1820A5BA0
	public static CargoPlane Deserialize(byte[] buffer) { }

	// RVA: 0x20A63B0 Offset: 0x20A49B0 VA: 0x1820A63B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A7630 Offset: 0x20A5C30 VA: 0x1820A7630 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A7650 Offset: 0x20A5C50 VA: 0x1820A7650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CargoPlane previous) { }

	// RVA: 0x20A6630 Offset: 0x20A4C30 VA: 0x1820A6630 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A5F00 Offset: 0x20A4500 VA: 0x1820A5F00
	public static CargoPlane Deserialize(byte[] buffer, CargoPlane instance, bool isDelta = False) { }

	// RVA: 0x20A5670 Offset: 0x20A3C70 VA: 0x1820A5670
	public static CargoPlane Deserialize(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A4C80 Offset: 0x20A3280 VA: 0x1820A4C80
	public static CargoPlane DeserializeLengthDelimited(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A5340 Offset: 0x20A3940 VA: 0x1820A5340
	public static CargoPlane DeserializeLength(Stream stream, int length, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A6B00 Offset: 0x20A5100 VA: 0x1820A6B00
	public static void SerializeDelta(Stream stream, CargoPlane instance, CargoPlane previous) { }

	// RVA: 0x20A72B0 Offset: 0x20A58B0 VA: 0x1820A72B0
	public static void Serialize(Stream stream, CargoPlane instance) { }

	// RVA: 0x20A7620 Offset: 0x20A5C20 VA: 0x1820A7620
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A7630 Offset: 0x20A5C30 VA: 0x1820A7630
	public void ToProto(Stream stream) { }

	// RVA: 0x20A71A0 Offset: 0x20A57A0 VA: 0x1820A71A0
	public static byte[] SerializeToBytes(CargoPlane instance) { }

	// RVA: 0x20A70F0 Offset: 0x20A56F0 VA: 0x1820A70F0
	public static void SerializeLengthDelimited(Stream stream, CargoPlane instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class CargoPlane : BaseEntity // TypeDefIndex: 9816
{	// Fields
	public GameObjectRef prefabDrop; // 0x168
	public SpawnFilter filter; // 0x170

	// Methods

	// RVA: 0x52A0F0 Offset: 0x5286F0 VA: 0x18052A0F0
	public void .ctor() { }

}

