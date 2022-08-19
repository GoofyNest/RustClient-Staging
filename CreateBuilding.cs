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

	// RVA: 0x20B8800 Offset: 0x20B6E00 VA: 0x1820B8800
	public static void ResetToPool(CreateBuilding instance) { }

	// RVA: 0x20B8900 Offset: 0x20B6F00 VA: 0x1820B8900
	public void ResetToPool() { }

	// RVA: 0x20B7FD0 Offset: 0x20B65D0 VA: 0x1820B7FD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B6110 Offset: 0x20B4710 VA: 0x1820B6110
	public void CopyTo(CreateBuilding instance) { }

	// RVA: 0x20B6180 Offset: 0x20B4780 VA: 0x1820B6180
	public CreateBuilding Copy() { }

	// RVA: 0x20B78A0 Offset: 0x20B5EA0 VA: 0x1820B78A0
	public static CreateBuilding Deserialize(Stream stream) { }

	// RVA: 0x20B6610 Offset: 0x20B4C10 VA: 0x1820B6610
	public static CreateBuilding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B6A30 Offset: 0x20B5030 VA: 0x1820B6A30
	public static CreateBuilding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B7BD0 Offset: 0x20B61D0 VA: 0x1820B7BD0
	public static CreateBuilding Deserialize(byte[] buffer) { }

	// RVA: 0x20B8150 Offset: 0x20B6750 VA: 0x1820B8150
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B9750 Offset: 0x20B7D50 VA: 0x1820B9750 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B9770 Offset: 0x20B7D70 VA: 0x1820B9770 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CreateBuilding previous) { }

	// RVA: 0x20B8450 Offset: 0x20B6A50 VA: 0x1820B8450 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B74D0 Offset: 0x20B5AD0 VA: 0x1820B74D0
	public static CreateBuilding Deserialize(byte[] buffer, CreateBuilding instance, bool isDelta = False) { }

	// RVA: 0x20B71D0 Offset: 0x20B57D0 VA: 0x1820B71D0
	public static CreateBuilding Deserialize(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6240 Offset: 0x20B4840 VA: 0x1820B6240
	public static CreateBuilding DeserializeLengthDelimited(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6E20 Offset: 0x20B5420 VA: 0x1820B6E20
	public static CreateBuilding DeserializeLength(Stream stream, int length, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B8A00 Offset: 0x20B7000 VA: 0x1820B8A00
	public static void SerializeDelta(Stream stream, CreateBuilding instance, CreateBuilding previous) { }

	// RVA: 0x20B92F0 Offset: 0x20B78F0 VA: 0x1820B92F0
	public static void Serialize(Stream stream, CreateBuilding instance) { }

	// RVA: 0x20B9740 Offset: 0x20B7D40 VA: 0x1820B9740
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B9750 Offset: 0x20B7D50 VA: 0x1820B9750
	public void ToProto(Stream stream) { }

	// RVA: 0x20B91E0 Offset: 0x20B77E0 VA: 0x1820B91E0
	public static byte[] SerializeToBytes(CreateBuilding instance) { }

	// RVA: 0x20B9130 Offset: 0x20B7730 VA: 0x1820B9130
	public static void SerializeLengthDelimited(Stream stream, CreateBuilding instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

