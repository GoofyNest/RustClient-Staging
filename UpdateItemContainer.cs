public class UpdateItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6477
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1EF6E70 Offset: 0x1EF5470 VA: 0x181EF6E70
	public static void ResetToPool(UpdateItemContainer instance) { }

	// RVA: 0x1EF6CB0 Offset: 0x1EF52B0 VA: 0x181EF6CB0
	public void ResetToPool() { }

	// RVA: 0x1EF6BF0 Offset: 0x1EF51F0 VA: 0x181EF6BF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF5B50 Offset: 0x1EF4150 VA: 0x181EF5B50
	public void CopyTo(UpdateItemContainer instance) { }

	// RVA: 0x1EF5C80 Offset: 0x1EF4280 VA: 0x181EF5C80
	public UpdateItemContainer Copy() { }

	// RVA: 0x1EF6630 Offset: 0x1EF4C30 VA: 0x181EF6630
	public static UpdateItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1EF60B0 Offset: 0x1EF46B0 VA: 0x181EF60B0
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF6130 Offset: 0x1EF4730 VA: 0x181EF6130
	public static UpdateItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF6940 Offset: 0x1EF4F40 VA: 0x181EF6940
	public static UpdateItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1EF6C70 Offset: 0x1EF5270 VA: 0x181EF6C70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF7660 Offset: 0x1EF5C60 VA: 0x181EF7660 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF7680 Offset: 0x1EF5C80 VA: 0x181EF7680 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItemContainer previous) { }

	// RVA: 0x1EF6C90 Offset: 0x1EF5290 VA: 0x181EF6C90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF6840 Offset: 0x1EF4E40 VA: 0x181EF6840
	public static UpdateItemContainer Deserialize(byte[] buffer, UpdateItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1EF6450 Offset: 0x1EF4A50 VA: 0x181EF6450
	public static UpdateItemContainer Deserialize(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF5E00 Offset: 0x1EF4400 VA: 0x181EF5E00
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF61C0 Offset: 0x1EF47C0 VA: 0x181EF61C0
	public static UpdateItemContainer DeserializeLength(Stream stream, int length, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF7030 Offset: 0x1EF5630 VA: 0x181EF7030
	public static void SerializeDelta(Stream stream, UpdateItemContainer instance, UpdateItemContainer previous) { }

	// RVA: 0x1EF7430 Offset: 0x1EF5A30 VA: 0x181EF7430
	public static void Serialize(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1EF7650 Offset: 0x1EF5C50 VA: 0x181EF7650
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF7660 Offset: 0x1EF5C60 VA: 0x181EF7660
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF7320 Offset: 0x1EF5920 VA: 0x181EF7320
	public static byte[] SerializeToBytes(UpdateItemContainer instance) { }

	// RVA: 0x1EF7270 Offset: 0x1EF5870 VA: 0x181EF7270
	public static void SerializeLengthDelimited(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

