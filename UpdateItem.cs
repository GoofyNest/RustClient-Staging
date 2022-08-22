public class UpdateItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6479
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1EF8590 Offset: 0x1EF6B90 VA: 0x181EF8590
	public static void ResetToPool(UpdateItem instance) { }

	// RVA: 0x1EF84F0 Offset: 0x1EF6AF0 VA: 0x181EF84F0
	public void ResetToPool() { }

	// RVA: 0x1EF8390 Offset: 0x1EF6990 VA: 0x181EF8390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E570D0 Offset: 0x1E556D0 VA: 0x181E570D0
	public void CopyTo(UpdateItem instance) { }

	// RVA: 0x1EF7960 Offset: 0x1EF5F60 VA: 0x181EF7960
	public UpdateItem Copy() { }

	// RVA: 0x1EF7F90 Offset: 0x1EF6590 VA: 0x181EF7F90
	public static UpdateItem Deserialize(Stream stream) { }

	// RVA: 0x1EF7C70 Offset: 0x1EF6270 VA: 0x181EF7C70
	public static UpdateItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF7F00 Offset: 0x1EF6500 VA: 0x181EF7F00
	public static UpdateItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF8010 Offset: 0x1EF6610 VA: 0x181EF8010
	public static UpdateItem Deserialize(byte[] buffer) { }

	// RVA: 0x1EF84B0 Offset: 0x1EF6AB0 VA: 0x181EF84B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF8BA0 Offset: 0x1EF71A0 VA: 0x181EF8BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF8BC0 Offset: 0x1EF71C0 VA: 0x181EF8BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItem previous) { }

	// RVA: 0x1EF84D0 Offset: 0x1EF6AD0 VA: 0x181EF84D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF8130 Offset: 0x1EF6730 VA: 0x181EF8130
	public static UpdateItem Deserialize(byte[] buffer, UpdateItem instance, bool isDelta = False) { }

	// RVA: 0x1EF8230 Offset: 0x1EF6830 VA: 0x181EF8230
	public static UpdateItem Deserialize(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF7A30 Offset: 0x1EF6030 VA: 0x181EF7A30
	public static UpdateItem DeserializeLengthDelimited(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF7CF0 Offset: 0x1EF62F0 VA: 0x181EF7CF0
	public static UpdateItem DeserializeLength(Stream stream, int length, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF8630 Offset: 0x1EF6C30 VA: 0x181EF8630
	public static void SerializeDelta(Stream stream, UpdateItem instance, UpdateItem previous) { }

	// RVA: 0x1EF89D0 Offset: 0x1EF6FD0 VA: 0x181EF89D0
	public static void Serialize(Stream stream, UpdateItem instance) { }

	// RVA: 0x1EF8B90 Offset: 0x1EF7190 VA: 0x181EF8B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF8BA0 Offset: 0x1EF71A0 VA: 0x181EF8BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF88C0 Offset: 0x1EF6EC0 VA: 0x181EF88C0
	public static byte[] SerializeToBytes(UpdateItem instance) { }

	// RVA: 0x1EF8810 Offset: 0x1EF6E10 VA: 0x181EF8810
	public static void SerializeLengthDelimited(Stream stream, UpdateItem instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

