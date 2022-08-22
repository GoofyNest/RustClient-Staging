public class CreateBuilding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6482
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entity; // 0x14
	public uint socket; // 0x18
	public bool onterrain; // 0x1C
	public Vector3 position; // 0x20
	public Vector3 normal; // 0x2C
	public Ray ray; // 0x38
	public uint blockID; // 0x50
	public Vector3 rotation; // 0x54

	// Methods

	// RVA: 0x20B8640 Offset: 0x20B6C40 VA: 0x1820B8640
	public static void ResetToPool(CreateBuilding instance) { }

	// RVA: 0x20B8740 Offset: 0x20B6D40 VA: 0x1820B8740
	public void ResetToPool() { }

	// RVA: 0x20B7E10 Offset: 0x20B6410 VA: 0x1820B7E10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B5F50 Offset: 0x20B4550 VA: 0x1820B5F50
	public void CopyTo(CreateBuilding instance) { }

	// RVA: 0x20B5FC0 Offset: 0x20B45C0 VA: 0x1820B5FC0
	public CreateBuilding Copy() { }

	// RVA: 0x20B76E0 Offset: 0x20B5CE0 VA: 0x1820B76E0
	public static CreateBuilding Deserialize(Stream stream) { }

	// RVA: 0x20B6450 Offset: 0x20B4A50 VA: 0x1820B6450
	public static CreateBuilding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B6870 Offset: 0x20B4E70 VA: 0x1820B6870
	public static CreateBuilding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B7A10 Offset: 0x20B6010 VA: 0x1820B7A10
	public static CreateBuilding Deserialize(byte[] buffer) { }

	// RVA: 0x20B7F90 Offset: 0x20B6590 VA: 0x1820B7F90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B9590 Offset: 0x20B7B90 VA: 0x1820B9590 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B95B0 Offset: 0x20B7BB0 VA: 0x1820B95B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CreateBuilding previous) { }

	// RVA: 0x20B8290 Offset: 0x20B6890 VA: 0x1820B8290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B7310 Offset: 0x20B5910 VA: 0x1820B7310
	public static CreateBuilding Deserialize(byte[] buffer, CreateBuilding instance, bool isDelta = False) { }

	// RVA: 0x20B7010 Offset: 0x20B5610 VA: 0x1820B7010
	public static CreateBuilding Deserialize(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6080 Offset: 0x20B4680 VA: 0x1820B6080
	public static CreateBuilding DeserializeLengthDelimited(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6C60 Offset: 0x20B5260 VA: 0x1820B6C60
	public static CreateBuilding DeserializeLength(Stream stream, int length, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B8840 Offset: 0x20B6E40 VA: 0x1820B8840
	public static void SerializeDelta(Stream stream, CreateBuilding instance, CreateBuilding previous) { }

	// RVA: 0x20B9130 Offset: 0x20B7730 VA: 0x1820B9130
	public static void Serialize(Stream stream, CreateBuilding instance) { }

	// RVA: 0x20B9580 Offset: 0x20B7B80 VA: 0x1820B9580
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B9590 Offset: 0x20B7B90 VA: 0x1820B9590
	public void ToProto(Stream stream) { }

	// RVA: 0x20B9020 Offset: 0x20B7620 VA: 0x1820B9020
	public static byte[] SerializeToBytes(CreateBuilding instance) { }

	// RVA: 0x20B8F70 Offset: 0x20B7570 VA: 0x1820B8F70
	public static void SerializeLengthDelimited(Stream stream, CreateBuilding instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

