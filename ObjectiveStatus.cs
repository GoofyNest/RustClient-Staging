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

	// RVA: 0x1F8EC10 Offset: 0x1F8D210 VA: 0x181F8EC10
	public static void ResetToPool(ObjectiveStatus instance) { }

	// RVA: 0x1F8EB60 Offset: 0x1F8D160 VA: 0x181F8EB60
	public void ResetToPool() { }

	// RVA: 0x1F8E7B0 Offset: 0x1F8CDB0 VA: 0x181F8E7B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF9950 Offset: 0x1EF7F50 VA: 0x181EF9950
	public void CopyTo(ObjectiveStatus instance) { }

	// RVA: 0x1F8D4A0 Offset: 0x1F8BAA0 VA: 0x181F8D4A0
	public ObjectiveStatus Copy() { }

	// RVA: 0x1F8E520 Offset: 0x1F8CB20 VA: 0x181F8E520
	public static ObjectiveStatus Deserialize(Stream stream) { }

	// RVA: 0x1F8D520 Offset: 0x1F8BB20 VA: 0x181F8D520
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8D8C0 Offset: 0x1F8BEC0 VA: 0x181F8D8C0
	public static ObjectiveStatus DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8DC50 Offset: 0x1F8C250 VA: 0x181F8DC50
	public static ObjectiveStatus Deserialize(byte[] buffer) { }

	// RVA: 0x1F8E8F0 Offset: 0x1F8CEF0 VA: 0x181F8E8F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8F200 Offset: 0x1F8D800 VA: 0x181F8F200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8F220 Offset: 0x1F8D820 VA: 0x181F8F220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ObjectiveStatus previous) { }

	// RVA: 0x1F8EB40 Offset: 0x1F8D140 VA: 0x181F8EB40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8DFA0 Offset: 0x1F8C5A0 VA: 0x181F8DFA0
	public static ObjectiveStatus Deserialize(byte[] buffer, ObjectiveStatus instance, bool isDelta = False) { }

	// RVA: 0x1F8E2D0 Offset: 0x1F8C8D0 VA: 0x181F8E2D0
	public static ObjectiveStatus Deserialize(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8D5A0 Offset: 0x1F8BBA0 VA: 0x181F8D5A0
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8D950 Offset: 0x1F8BF50 VA: 0x181F8D950
	public static ObjectiveStatus DeserializeLength(Stream stream, int length, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8ECC0 Offset: 0x1F8D2C0 VA: 0x181F8ECC0
	public static void SerializeDelta(Stream stream, ObjectiveStatus instance, ObjectiveStatus previous) { }

	// RVA: 0x1F8F080 Offset: 0x1F8D680 VA: 0x181F8F080
	public static void Serialize(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1F8F1F0 Offset: 0x1F8D7F0 VA: 0x181F8F1F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8F200 Offset: 0x1F8D800 VA: 0x181F8F200
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8EF70 Offset: 0x1F8D570 VA: 0x181F8EF70
	public static byte[] SerializeToBytes(ObjectiveStatus instance) { }

	// RVA: 0x1F8EEC0 Offset: 0x1F8D4C0 VA: 0x181F8EEC0
	public static void SerializeLengthDelimited(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

