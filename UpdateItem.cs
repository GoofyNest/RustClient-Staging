public class UpdateItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6479
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1EF82D0 Offset: 0x1EF68D0 VA: 0x181EF82D0
	public static void ResetToPool(UpdateItem instance) { }

	// RVA: 0x1EF8230 Offset: 0x1EF6830 VA: 0x181EF8230
	public void ResetToPool() { }

	// RVA: 0x1EF80D0 Offset: 0x1EF66D0 VA: 0x181EF80D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E56E10 Offset: 0x1E55410 VA: 0x181E56E10
	public void CopyTo(UpdateItem instance) { }

	// RVA: 0x1EF76A0 Offset: 0x1EF5CA0 VA: 0x181EF76A0
	public UpdateItem Copy() { }

	// RVA: 0x1EF7CD0 Offset: 0x1EF62D0 VA: 0x181EF7CD0
	public static UpdateItem Deserialize(Stream stream) { }

	// RVA: 0x1EF79B0 Offset: 0x1EF5FB0 VA: 0x181EF79B0
	public static UpdateItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF7C40 Offset: 0x1EF6240 VA: 0x181EF7C40
	public static UpdateItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF7D50 Offset: 0x1EF6350 VA: 0x181EF7D50
	public static UpdateItem Deserialize(byte[] buffer) { }

	// RVA: 0x1EF81F0 Offset: 0x1EF67F0 VA: 0x181EF81F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF88E0 Offset: 0x1EF6EE0 VA: 0x181EF88E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF8900 Offset: 0x1EF6F00 VA: 0x181EF8900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItem previous) { }

	// RVA: 0x1EF8210 Offset: 0x1EF6810 VA: 0x181EF8210 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF7E70 Offset: 0x1EF6470 VA: 0x181EF7E70
	public static UpdateItem Deserialize(byte[] buffer, UpdateItem instance, bool isDelta = False) { }

	// RVA: 0x1EF7F70 Offset: 0x1EF6570 VA: 0x181EF7F70
	public static UpdateItem Deserialize(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF7770 Offset: 0x1EF5D70 VA: 0x181EF7770
	public static UpdateItem DeserializeLengthDelimited(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF7A30 Offset: 0x1EF6030 VA: 0x181EF7A30
	public static UpdateItem DeserializeLength(Stream stream, int length, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF8370 Offset: 0x1EF6970 VA: 0x181EF8370
	public static void SerializeDelta(Stream stream, UpdateItem instance, UpdateItem previous) { }

	// RVA: 0x1EF8710 Offset: 0x1EF6D10 VA: 0x181EF8710
	public static void Serialize(Stream stream, UpdateItem instance) { }

	// RVA: 0x1EF88D0 Offset: 0x1EF6ED0 VA: 0x181EF88D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF88E0 Offset: 0x1EF6EE0 VA: 0x181EF88E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF8600 Offset: 0x1EF6C00 VA: 0x181EF8600
	public static byte[] SerializeToBytes(UpdateItem instance) { }

	// RVA: 0x1EF8550 Offset: 0x1EF6B50 VA: 0x181EF8550
	public static void SerializeLengthDelimited(Stream stream, UpdateItem instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

