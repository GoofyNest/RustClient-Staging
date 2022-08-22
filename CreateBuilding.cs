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

	// RVA: 0x20B9120 Offset: 0x20B7720 VA: 0x1820B9120
	public static void ResetToPool(CreateBuilding instance) { }

	// RVA: 0x20B9220 Offset: 0x20B7820 VA: 0x1820B9220
	public void ResetToPool() { }

	// RVA: 0x20B88F0 Offset: 0x20B6EF0 VA: 0x1820B88F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B6A30 Offset: 0x20B5030 VA: 0x1820B6A30
	public void CopyTo(CreateBuilding instance) { }

	// RVA: 0x20B6AA0 Offset: 0x20B50A0 VA: 0x1820B6AA0
	public CreateBuilding Copy() { }

	// RVA: 0x20B81C0 Offset: 0x20B67C0 VA: 0x1820B81C0
	public static CreateBuilding Deserialize(Stream stream) { }

	// RVA: 0x20B6F30 Offset: 0x20B5530 VA: 0x1820B6F30
	public static CreateBuilding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B7350 Offset: 0x20B5950 VA: 0x1820B7350
	public static CreateBuilding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B84F0 Offset: 0x20B6AF0 VA: 0x1820B84F0
	public static CreateBuilding Deserialize(byte[] buffer) { }

	// RVA: 0x20B8A70 Offset: 0x20B7070 VA: 0x1820B8A70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BA070 Offset: 0x20B8670 VA: 0x1820BA070 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BA090 Offset: 0x20B8690 VA: 0x1820BA090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CreateBuilding previous) { }

	// RVA: 0x20B8D70 Offset: 0x20B7370 VA: 0x1820B8D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B7DF0 Offset: 0x20B63F0 VA: 0x1820B7DF0
	public static CreateBuilding Deserialize(byte[] buffer, CreateBuilding instance, bool isDelta = False) { }

	// RVA: 0x20B7AF0 Offset: 0x20B60F0 VA: 0x1820B7AF0
	public static CreateBuilding Deserialize(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B6B60 Offset: 0x20B5160 VA: 0x1820B6B60
	public static CreateBuilding DeserializeLengthDelimited(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B7740 Offset: 0x20B5D40 VA: 0x1820B7740
	public static CreateBuilding DeserializeLength(Stream stream, int length, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B9320 Offset: 0x20B7920 VA: 0x1820B9320
	public static void SerializeDelta(Stream stream, CreateBuilding instance, CreateBuilding previous) { }

	// RVA: 0x20B9C10 Offset: 0x20B8210 VA: 0x1820B9C10
	public static void Serialize(Stream stream, CreateBuilding instance) { }

	// RVA: 0x20BA060 Offset: 0x20B8660 VA: 0x1820BA060
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BA070 Offset: 0x20B8670 VA: 0x1820BA070
	public void ToProto(Stream stream) { }

	// RVA: 0x20B9B00 Offset: 0x20B8100 VA: 0x1820B9B00
	public static byte[] SerializeToBytes(CreateBuilding instance) { }

	// RVA: 0x20B9A50 Offset: 0x20B8050 VA: 0x1820B9A50
	public static void SerializeLengthDelimited(Stream stream, CreateBuilding instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

