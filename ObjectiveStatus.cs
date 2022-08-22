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

	// RVA: 0x1F8F6F0 Offset: 0x1F8DCF0 VA: 0x181F8F6F0
	public static void ResetToPool(ObjectiveStatus instance) { }

	// RVA: 0x1F8F640 Offset: 0x1F8DC40 VA: 0x181F8F640
	public void ResetToPool() { }

	// RVA: 0x1F8F290 Offset: 0x1F8D890 VA: 0x181F8F290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFA430 Offset: 0x1EF8A30 VA: 0x181EFA430
	public void CopyTo(ObjectiveStatus instance) { }

	// RVA: 0x1F8DF80 Offset: 0x1F8C580 VA: 0x181F8DF80
	public ObjectiveStatus Copy() { }

	// RVA: 0x1F8F000 Offset: 0x1F8D600 VA: 0x181F8F000
	public static ObjectiveStatus Deserialize(Stream stream) { }

	// RVA: 0x1F8E000 Offset: 0x1F8C600 VA: 0x181F8E000
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8E3A0 Offset: 0x1F8C9A0 VA: 0x181F8E3A0
	public static ObjectiveStatus DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8E730 Offset: 0x1F8CD30 VA: 0x181F8E730
	public static ObjectiveStatus Deserialize(byte[] buffer) { }

	// RVA: 0x1F8F3D0 Offset: 0x1F8D9D0 VA: 0x181F8F3D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8FCE0 Offset: 0x1F8E2E0 VA: 0x181F8FCE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8FD00 Offset: 0x1F8E300 VA: 0x181F8FD00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ObjectiveStatus previous) { }

	// RVA: 0x1F8F620 Offset: 0x1F8DC20 VA: 0x181F8F620 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8EA80 Offset: 0x1F8D080 VA: 0x181F8EA80
	public static ObjectiveStatus Deserialize(byte[] buffer, ObjectiveStatus instance, bool isDelta = False) { }

	// RVA: 0x1F8EDB0 Offset: 0x1F8D3B0 VA: 0x181F8EDB0
	public static ObjectiveStatus Deserialize(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8E080 Offset: 0x1F8C680 VA: 0x181F8E080
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8E430 Offset: 0x1F8CA30 VA: 0x181F8E430
	public static ObjectiveStatus DeserializeLength(Stream stream, int length, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F8F7A0 Offset: 0x1F8DDA0 VA: 0x181F8F7A0
	public static void SerializeDelta(Stream stream, ObjectiveStatus instance, ObjectiveStatus previous) { }

	// RVA: 0x1F8FB60 Offset: 0x1F8E160 VA: 0x181F8FB60
	public static void Serialize(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1F8FCD0 Offset: 0x1F8E2D0 VA: 0x181F8FCD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8FCE0 Offset: 0x1F8E2E0 VA: 0x181F8FCE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8FA50 Offset: 0x1F8E050 VA: 0x181F8FA50
	public static byte[] SerializeToBytes(ObjectiveStatus instance) { }

	// RVA: 0x1F8F9A0 Offset: 0x1F8DFA0 VA: 0x181F8F9A0
	public static void SerializeLengthDelimited(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

