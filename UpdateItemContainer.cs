public class UpdateItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6477
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1EF7950 Offset: 0x1EF5F50 VA: 0x181EF7950
	public static void ResetToPool(UpdateItemContainer instance) { }

	// RVA: 0x1EF7790 Offset: 0x1EF5D90 VA: 0x181EF7790
	public void ResetToPool() { }

	// RVA: 0x1EF76D0 Offset: 0x1EF5CD0 VA: 0x181EF76D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF6630 Offset: 0x1EF4C30 VA: 0x181EF6630
	public void CopyTo(UpdateItemContainer instance) { }

	// RVA: 0x1EF6760 Offset: 0x1EF4D60 VA: 0x181EF6760
	public UpdateItemContainer Copy() { }

	// RVA: 0x1EF7110 Offset: 0x1EF5710 VA: 0x181EF7110
	public static UpdateItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1EF6B90 Offset: 0x1EF5190 VA: 0x181EF6B90
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF6C10 Offset: 0x1EF5210 VA: 0x181EF6C10
	public static UpdateItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF7420 Offset: 0x1EF5A20 VA: 0x181EF7420
	public static UpdateItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1EF7750 Offset: 0x1EF5D50 VA: 0x181EF7750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF8140 Offset: 0x1EF6740 VA: 0x181EF8140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF8160 Offset: 0x1EF6760 VA: 0x181EF8160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItemContainer previous) { }

	// RVA: 0x1EF7770 Offset: 0x1EF5D70 VA: 0x181EF7770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF7320 Offset: 0x1EF5920 VA: 0x181EF7320
	public static UpdateItemContainer Deserialize(byte[] buffer, UpdateItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1EF6F30 Offset: 0x1EF5530 VA: 0x181EF6F30
	public static UpdateItemContainer Deserialize(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF68E0 Offset: 0x1EF4EE0 VA: 0x181EF68E0
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF6CA0 Offset: 0x1EF52A0 VA: 0x181EF6CA0
	public static UpdateItemContainer DeserializeLength(Stream stream, int length, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF7B10 Offset: 0x1EF6110 VA: 0x181EF7B10
	public static void SerializeDelta(Stream stream, UpdateItemContainer instance, UpdateItemContainer previous) { }

	// RVA: 0x1EF7F10 Offset: 0x1EF6510 VA: 0x181EF7F10
	public static void Serialize(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1EF8130 Offset: 0x1EF6730 VA: 0x181EF8130
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF8140 Offset: 0x1EF6740 VA: 0x181EF8140
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF7E00 Offset: 0x1EF6400 VA: 0x181EF7E00
	public static byte[] SerializeToBytes(UpdateItemContainer instance) { }

	// RVA: 0x1EF7D50 Offset: 0x1EF6350 VA: 0x181EF7D50
	public static void SerializeLengthDelimited(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

