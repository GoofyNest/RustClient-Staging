public class UpdateItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6479
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1EF8490 Offset: 0x1EF6A90 VA: 0x181EF8490
	public static void ResetToPool(UpdateItem instance) { }

	// RVA: 0x1EF83F0 Offset: 0x1EF69F0 VA: 0x181EF83F0
	public void ResetToPool() { }

	// RVA: 0x1EF8290 Offset: 0x1EF6890 VA: 0x181EF8290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E56FD0 Offset: 0x1E555D0 VA: 0x181E56FD0
	public void CopyTo(UpdateItem instance) { }

	// RVA: 0x1EF7860 Offset: 0x1EF5E60 VA: 0x181EF7860
	public UpdateItem Copy() { }

	// RVA: 0x1EF7E90 Offset: 0x1EF6490 VA: 0x181EF7E90
	public static UpdateItem Deserialize(Stream stream) { }

	// RVA: 0x1EF7B70 Offset: 0x1EF6170 VA: 0x181EF7B70
	public static UpdateItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF7E00 Offset: 0x1EF6400 VA: 0x181EF7E00
	public static UpdateItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF7F10 Offset: 0x1EF6510 VA: 0x181EF7F10
	public static UpdateItem Deserialize(byte[] buffer) { }

	// RVA: 0x1EF83B0 Offset: 0x1EF69B0 VA: 0x181EF83B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF8AA0 Offset: 0x1EF70A0 VA: 0x181EF8AA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF8AC0 Offset: 0x1EF70C0 VA: 0x181EF8AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItem previous) { }

	// RVA: 0x1EF83D0 Offset: 0x1EF69D0 VA: 0x181EF83D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF8030 Offset: 0x1EF6630 VA: 0x181EF8030
	public static UpdateItem Deserialize(byte[] buffer, UpdateItem instance, bool isDelta = False) { }

	// RVA: 0x1EF8130 Offset: 0x1EF6730 VA: 0x181EF8130
	public static UpdateItem Deserialize(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF7930 Offset: 0x1EF5F30 VA: 0x181EF7930
	public static UpdateItem DeserializeLengthDelimited(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF7BF0 Offset: 0x1EF61F0 VA: 0x181EF7BF0
	public static UpdateItem DeserializeLength(Stream stream, int length, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF8530 Offset: 0x1EF6B30 VA: 0x181EF8530
	public static void SerializeDelta(Stream stream, UpdateItem instance, UpdateItem previous) { }

	// RVA: 0x1EF88D0 Offset: 0x1EF6ED0 VA: 0x181EF88D0
	public static void Serialize(Stream stream, UpdateItem instance) { }

	// RVA: 0x1EF8A90 Offset: 0x1EF7090 VA: 0x181EF8A90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF8AA0 Offset: 0x1EF70A0 VA: 0x181EF8AA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF87C0 Offset: 0x1EF6DC0 VA: 0x181EF87C0
	public static byte[] SerializeToBytes(UpdateItem instance) { }

	// RVA: 0x1EF8710 Offset: 0x1EF6D10 VA: 0x181EF8710
	public static void SerializeLengthDelimited(Stream stream, UpdateItem instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

