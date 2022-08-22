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

	// RVA: 0x1F8EED0 Offset: 0x1F8D4D0 VA: 0x181F8EED0
	public static void ResetToPool(ObjectiveStatus instance) { }

	// RVA: 0x1F8EE20 Offset: 0x1F8D420 VA: 0x181F8EE20
	public void ResetToPool() { }

	// RVA: 0x1F8EA70 Offset: 0x1F8D070 VA: 0x181F8EA70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF9C10 Offset: 0x1EF8210 VA: 0x181EF9C10
	public void CopyTo(ObjectiveStatus instance) { }

	// RVA: 0x1F8D760 Offset: 0x1F8BD60 VA: 0x181F8D760
	public ObjectiveStatus Copy() { }

	// RVA: 0x1F8E7E0 Offset: 0x1F8CDE0 VA: 0x181F8E7E0
	public static ObjectiveStatus Deserialize(Stream stream) { }

	// RVA: 0x1F8D7E0 Offset: 0x1F8BDE0 VA: 0x181F8D7E0
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8DB80 Offset: 0x1F8C180 VA: 0x181F8DB80
	public static ObjectiveStatus DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8DF10 Offset: 0x1F8C510 VA: 0x181F8DF10
	public static ObjectiveStatus Deserialize(byte[] buffer) { }

	// RVA: 0x1F8EBB0 Offset: 0x1F8D1B0 VA: 0x181F8EBB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8F4C0 Offset: 0x1F8DAC0 VA: 0x181F8F4C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8F4E0 Offset: 0x1F8DAE0 VA: 0x181F8F4E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ObjectiveStatus previous) { }

	// RVA: 0x1F8EE00 Offset: 0x1F8D400 VA: 0x181F8EE00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8E260 Offset: 0x1F8C860 VA: 0x181F8E260
	public static ObjectiveStatus Deserialize(byte[] buffer, ObjectiveStatus instance, bool isDelta = False) { }

	// RVA: 0x1F8E590 Offset: 0x1F8CB90 VA: 0x181F8E590
	public static ObjectiveStatus Deserialize(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8D860 Offset: 0x1F8BE60 VA: 0x181F8D860
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8DC10 Offset: 0x1F8C210 VA: 0x181F8DC10
	public static ObjectiveStatus DeserializeLength(Stream stream, int length, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8EF80 Offset: 0x1F8D580 VA: 0x181F8EF80
	public static void SerializeDelta(Stream stream, ObjectiveStatus instance, ObjectiveStatus previous) { }

	// RVA: 0x1F8F340 Offset: 0x1F8D940 VA: 0x181F8F340
	public static void Serialize(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1F8F4B0 Offset: 0x1F8DAB0 VA: 0x181F8F4B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8F4C0 Offset: 0x1F8DAC0 VA: 0x181F8F4C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8F230 Offset: 0x1F8D830 VA: 0x181F8F230
	public static byte[] SerializeToBytes(ObjectiveStatus instance) { }

	// RVA: 0x1F8F180 Offset: 0x1F8D780 VA: 0x181F8F180
	public static void SerializeLengthDelimited(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

