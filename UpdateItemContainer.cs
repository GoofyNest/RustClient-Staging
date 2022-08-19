public class UpdateItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6477
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1EF7030 Offset: 0x1EF5630 VA: 0x181EF7030
	public static void ResetToPool(UpdateItemContainer instance) { }

	// RVA: 0x1EF6E70 Offset: 0x1EF5470 VA: 0x181EF6E70
	public void ResetToPool() { }

	// RVA: 0x1EF6DB0 Offset: 0x1EF53B0 VA: 0x181EF6DB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF5D10 Offset: 0x1EF4310 VA: 0x181EF5D10
	public void CopyTo(UpdateItemContainer instance) { }

	// RVA: 0x1EF5E40 Offset: 0x1EF4440 VA: 0x181EF5E40
	public UpdateItemContainer Copy() { }

	// RVA: 0x1EF67F0 Offset: 0x1EF4DF0 VA: 0x181EF67F0
	public static UpdateItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1EF6270 Offset: 0x1EF4870 VA: 0x181EF6270
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF62F0 Offset: 0x1EF48F0 VA: 0x181EF62F0
	public static UpdateItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF6B00 Offset: 0x1EF5100 VA: 0x181EF6B00
	public static UpdateItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1EF6E30 Offset: 0x1EF5430 VA: 0x181EF6E30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF7820 Offset: 0x1EF5E20 VA: 0x181EF7820 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF7840 Offset: 0x1EF5E40 VA: 0x181EF7840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItemContainer previous) { }

	// RVA: 0x1EF6E50 Offset: 0x1EF5450 VA: 0x181EF6E50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF6A00 Offset: 0x1EF5000 VA: 0x181EF6A00
	public static UpdateItemContainer Deserialize(byte[] buffer, UpdateItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1EF6610 Offset: 0x1EF4C10 VA: 0x181EF6610
	public static UpdateItemContainer Deserialize(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF5FC0 Offset: 0x1EF45C0 VA: 0x181EF5FC0
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF6380 Offset: 0x1EF4980 VA: 0x181EF6380
	public static UpdateItemContainer DeserializeLength(Stream stream, int length, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF71F0 Offset: 0x1EF57F0 VA: 0x181EF71F0
	public static void SerializeDelta(Stream stream, UpdateItemContainer instance, UpdateItemContainer previous) { }

	// RVA: 0x1EF75F0 Offset: 0x1EF5BF0 VA: 0x181EF75F0
	public static void Serialize(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1EF7810 Offset: 0x1EF5E10 VA: 0x181EF7810
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF7820 Offset: 0x1EF5E20 VA: 0x181EF7820
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF74E0 Offset: 0x1EF5AE0 VA: 0x181EF74E0
	public static byte[] SerializeToBytes(UpdateItemContainer instance) { }

	// RVA: 0x1EF7430 Offset: 0x1EF5A30 VA: 0x181EF7430
	public static void SerializeLengthDelimited(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

