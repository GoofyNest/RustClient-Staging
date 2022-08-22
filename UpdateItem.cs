public class UpdateItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6479
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1EF8DB0 Offset: 0x1EF73B0 VA: 0x181EF8DB0
	public static void ResetToPool(UpdateItem instance) { }

	// RVA: 0x1EF8D10 Offset: 0x1EF7310 VA: 0x181EF8D10
	public void ResetToPool() { }

	// RVA: 0x1EF8BB0 Offset: 0x1EF71B0 VA: 0x181EF8BB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E578F0 Offset: 0x1E55EF0 VA: 0x181E578F0
	public void CopyTo(UpdateItem instance) { }

	// RVA: 0x1EF8180 Offset: 0x1EF6780 VA: 0x181EF8180
	public UpdateItem Copy() { }

	// RVA: 0x1EF87B0 Offset: 0x1EF6DB0 VA: 0x181EF87B0
	public static UpdateItem Deserialize(Stream stream) { }

	// RVA: 0x1EF8490 Offset: 0x1EF6A90 VA: 0x181EF8490
	public static UpdateItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF8720 Offset: 0x1EF6D20 VA: 0x181EF8720
	public static UpdateItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF8830 Offset: 0x1EF6E30 VA: 0x181EF8830
	public static UpdateItem Deserialize(byte[] buffer) { }

	// RVA: 0x1EF8CD0 Offset: 0x1EF72D0 VA: 0x181EF8CD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF93C0 Offset: 0x1EF79C0 VA: 0x181EF93C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF93E0 Offset: 0x1EF79E0 VA: 0x181EF93E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItem previous) { }

	// RVA: 0x1EF8CF0 Offset: 0x1EF72F0 VA: 0x181EF8CF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF8950 Offset: 0x1EF6F50 VA: 0x181EF8950
	public static UpdateItem Deserialize(byte[] buffer, UpdateItem instance, bool isDelta = False) { }

	// RVA: 0x1EF8A50 Offset: 0x1EF7050 VA: 0x181EF8A50
	public static UpdateItem Deserialize(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF8250 Offset: 0x1EF6850 VA: 0x181EF8250
	public static UpdateItem DeserializeLengthDelimited(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF8510 Offset: 0x1EF6B10 VA: 0x181EF8510
	public static UpdateItem DeserializeLength(Stream stream, int length, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF8E50 Offset: 0x1EF7450 VA: 0x181EF8E50
	public static void SerializeDelta(Stream stream, UpdateItem instance, UpdateItem previous) { }

	// RVA: 0x1EF91F0 Offset: 0x1EF77F0 VA: 0x181EF91F0
	public static void Serialize(Stream stream, UpdateItem instance) { }

	// RVA: 0x1EF93B0 Offset: 0x1EF79B0 VA: 0x181EF93B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF93C0 Offset: 0x1EF79C0 VA: 0x181EF93C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF90E0 Offset: 0x1EF76E0 VA: 0x181EF90E0
	public static byte[] SerializeToBytes(UpdateItem instance) { }

	// RVA: 0x1EF9030 Offset: 0x1EF7630 VA: 0x181EF9030
	public static void SerializeLengthDelimited(Stream stream, UpdateItem instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

