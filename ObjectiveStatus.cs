public class ObjectiveStatus : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6450
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool started; // 0x12
	public bool completed; // 0x13
	public bool failed; // 0x14
	public int genericInt1; // 0x18
	public float genericFloat1; // 0x1C

	// Methods

	// RVA: 0x1F8EDD0 Offset: 0x1F8D3D0 VA: 0x181F8EDD0
	public static void ResetToPool(ObjectiveStatus instance) { }

	// RVA: 0x1F8ED20 Offset: 0x1F8D320 VA: 0x181F8ED20
	public void ResetToPool() { }

	// RVA: 0x1F8E970 Offset: 0x1F8CF70 VA: 0x181F8E970 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF9B10 Offset: 0x1EF8110 VA: 0x181EF9B10
	public void CopyTo(ObjectiveStatus instance) { }

	// RVA: 0x1F8D660 Offset: 0x1F8BC60 VA: 0x181F8D660
	public ObjectiveStatus Copy() { }

	// RVA: 0x1F8E6E0 Offset: 0x1F8CCE0 VA: 0x181F8E6E0
	public static ObjectiveStatus Deserialize(Stream stream) { }

	// RVA: 0x1F8D6E0 Offset: 0x1F8BCE0 VA: 0x181F8D6E0
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8DA80 Offset: 0x1F8C080 VA: 0x181F8DA80
	public static ObjectiveStatus DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8DE10 Offset: 0x1F8C410 VA: 0x181F8DE10
	public static ObjectiveStatus Deserialize(byte[] buffer) { }

	// RVA: 0x1F8EAB0 Offset: 0x1F8D0B0 VA: 0x181F8EAB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8F3C0 Offset: 0x1F8D9C0 VA: 0x181F8F3C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8F3E0 Offset: 0x1F8D9E0 VA: 0x181F8F3E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ObjectiveStatus previous) { }

	// RVA: 0x1F8ED00 Offset: 0x1F8D300 VA: 0x181F8ED00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8E160 Offset: 0x1F8C760 VA: 0x181F8E160
	public static ObjectiveStatus Deserialize(byte[] buffer, ObjectiveStatus instance, bool isDelta = False) { }

	// RVA: 0x1F8E490 Offset: 0x1F8CA90 VA: 0x181F8E490
	public static ObjectiveStatus Deserialize(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8D760 Offset: 0x1F8BD60 VA: 0x181F8D760
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8DB10 Offset: 0x1F8C110 VA: 0x181F8DB10
	public static ObjectiveStatus DeserializeLength(Stream stream, int length, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8EE80 Offset: 0x1F8D480 VA: 0x181F8EE80
	public static void SerializeDelta(Stream stream, ObjectiveStatus instance, ObjectiveStatus previous) { }

	// RVA: 0x1F8F240 Offset: 0x1F8D840 VA: 0x181F8F240
	public static void Serialize(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1F8F3B0 Offset: 0x1F8D9B0 VA: 0x181F8F3B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8F3C0 Offset: 0x1F8D9C0 VA: 0x181F8F3C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8F130 Offset: 0x1F8D730 VA: 0x181F8F130
	public static byte[] SerializeToBytes(ObjectiveStatus instance) { }

	// RVA: 0x1F8F080 Offset: 0x1F8D680 VA: 0x181F8F080
	public static void SerializeLengthDelimited(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

