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

	// RVA: 0x20B8900 Offset: 0x20B6F00 VA: 0x1820B8900
	public static void ResetToPool(CreateBuilding instance) { }

	// RVA: 0x20B8A00 Offset: 0x20B7000 VA: 0x1820B8A00
	public void ResetToPool() { }

	// RVA: 0x20B80D0 Offset: 0x20B66D0 VA: 0x1820B80D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B6210 Offset: 0x20B4810 VA: 0x1820B6210
	public void CopyTo(CreateBuilding instance) { }

	// RVA: 0x20B6280 Offset: 0x20B4880 VA: 0x1820B6280
	public CreateBuilding Copy() { }

	// RVA: 0x20B79A0 Offset: 0x20B5FA0 VA: 0x1820B79A0
	public static CreateBuilding Deserialize(Stream stream) { }

	// RVA: 0x20B6710 Offset: 0x20B4D10 VA: 0x1820B6710
	public static CreateBuilding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B6B30 Offset: 0x20B5130 VA: 0x1820B6B30
	public static CreateBuilding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B7CD0 Offset: 0x20B62D0 VA: 0x1820B7CD0
	public static CreateBuilding Deserialize(byte[] buffer) { }

	// RVA: 0x20B8250 Offset: 0x20B6850 VA: 0x1820B8250
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B9850 Offset: 0x20B7E50 VA: 0x1820B9850 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B9870 Offset: 0x20B7E70 VA: 0x1820B9870 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CreateBuilding previous) { }

	// RVA: 0x20B8550 Offset: 0x20B6B50 VA: 0x1820B8550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B75D0 Offset: 0x20B5BD0 VA: 0x1820B75D0
	public static CreateBuilding Deserialize(byte[] buffer, CreateBuilding instance, bool isDelta = False) { }

	// RVA: 0x20B72D0 Offset: 0x20B58D0 VA: 0x1820B72D0
	public static CreateBuilding Deserialize(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6340 Offset: 0x20B4940 VA: 0x1820B6340
	public static CreateBuilding DeserializeLengthDelimited(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6F20 Offset: 0x20B5520 VA: 0x1820B6F20
	public static CreateBuilding DeserializeLength(Stream stream, int length, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B8B00 Offset: 0x20B7100 VA: 0x1820B8B00
	public static void SerializeDelta(Stream stream, CreateBuilding instance, CreateBuilding previous) { }

	// RVA: 0x20B93F0 Offset: 0x20B79F0 VA: 0x1820B93F0
	public static void Serialize(Stream stream, CreateBuilding instance) { }

	// RVA: 0x20B9840 Offset: 0x20B7E40 VA: 0x1820B9840
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B9850 Offset: 0x20B7E50 VA: 0x1820B9850
	public void ToProto(Stream stream) { }

	// RVA: 0x20B92E0 Offset: 0x20B78E0 VA: 0x1820B92E0
	public static byte[] SerializeToBytes(CreateBuilding instance) { }

	// RVA: 0x20B9230 Offset: 0x20B7830 VA: 0x1820B9230
	public static void SerializeLengthDelimited(Stream stream, CreateBuilding instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

