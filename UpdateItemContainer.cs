public class UpdateItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6477
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1EF7130 Offset: 0x1EF5730 VA: 0x181EF7130
	public static void ResetToPool(UpdateItemContainer instance) { }

	// RVA: 0x1EF6F70 Offset: 0x1EF5570 VA: 0x181EF6F70
	public void ResetToPool() { }

	// RVA: 0x1EF6EB0 Offset: 0x1EF54B0 VA: 0x181EF6EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF5E10 Offset: 0x1EF4410 VA: 0x181EF5E10
	public void CopyTo(UpdateItemContainer instance) { }

	// RVA: 0x1EF5F40 Offset: 0x1EF4540 VA: 0x181EF5F40
	public UpdateItemContainer Copy() { }

	// RVA: 0x1EF68F0 Offset: 0x1EF4EF0 VA: 0x181EF68F0
	public static UpdateItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1EF6370 Offset: 0x1EF4970 VA: 0x181EF6370
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF63F0 Offset: 0x1EF49F0 VA: 0x181EF63F0
	public static UpdateItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF6C00 Offset: 0x1EF5200 VA: 0x181EF6C00
	public static UpdateItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1EF6F30 Offset: 0x1EF5530 VA: 0x181EF6F30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF7920 Offset: 0x1EF5F20 VA: 0x181EF7920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF7940 Offset: 0x1EF5F40 VA: 0x181EF7940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItemContainer previous) { }

	// RVA: 0x1EF6F50 Offset: 0x1EF5550 VA: 0x181EF6F50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF6B00 Offset: 0x1EF5100 VA: 0x181EF6B00
	public static UpdateItemContainer Deserialize(byte[] buffer, UpdateItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1EF6710 Offset: 0x1EF4D10 VA: 0x181EF6710
	public static UpdateItemContainer Deserialize(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF60C0 Offset: 0x1EF46C0 VA: 0x181EF60C0
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF6480 Offset: 0x1EF4A80 VA: 0x181EF6480
	public static UpdateItemContainer DeserializeLength(Stream stream, int length, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF72F0 Offset: 0x1EF58F0 VA: 0x181EF72F0
	public static void SerializeDelta(Stream stream, UpdateItemContainer instance, UpdateItemContainer previous) { }

	// RVA: 0x1EF76F0 Offset: 0x1EF5CF0 VA: 0x181EF76F0
	public static void Serialize(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1EF7910 Offset: 0x1EF5F10 VA: 0x181EF7910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF7920 Offset: 0x1EF5F20 VA: 0x181EF7920
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF75E0 Offset: 0x1EF5BE0 VA: 0x181EF75E0
	public static byte[] SerializeToBytes(UpdateItemContainer instance) { }

	// RVA: 0x1EF7530 Offset: 0x1EF5B30 VA: 0x181EF7530
	public static void SerializeLengthDelimited(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

