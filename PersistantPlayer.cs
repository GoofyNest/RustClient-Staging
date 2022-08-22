public class PersistantPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6455
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> unlockedItems; // 0x18
	public int protocolVersion; // 0x20

	// Methods

	// RVA: 0x1EA6500 Offset: 0x1EA4B00 VA: 0x181EA6500
	public static void ResetToPool(PersistantPlayer instance) { }

	// RVA: 0x1EA6410 Offset: 0x1EA4A10 VA: 0x181EA6410
	public void ResetToPool() { }

	// RVA: 0x1EA6260 Offset: 0x1EA4860 VA: 0x181EA6260 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA5490 Offset: 0x1EA3A90 VA: 0x181EA5490
	public void CopyTo(PersistantPlayer instance) { }

	// RVA: 0x1EA55B0 Offset: 0x1EA3BB0 VA: 0x181EA55B0
	public PersistantPlayer Copy() { }

	// RVA: 0x1EA5FC0 Offset: 0x1EA45C0 VA: 0x181EA5FC0
	public static PersistantPlayer Deserialize(Stream stream) { }

	// RVA: 0x1EA5720 Offset: 0x1EA3D20 VA: 0x181EA5720
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA5D30 Offset: 0x1EA4330 VA: 0x181EA5D30
	public static PersistantPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA6040 Offset: 0x1EA4640 VA: 0x181EA6040
	public static PersistantPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1EA63D0 Offset: 0x1EA49D0 VA: 0x181EA63D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA6B40 Offset: 0x1EA5140 VA: 0x181EA6B40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA6B60 Offset: 0x1EA5160 VA: 0x181EA6B60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PersistantPlayer previous) { }

	// RVA: 0x1EA63F0 Offset: 0x1EA49F0 VA: 0x181EA63F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA6160 Offset: 0x1EA4760 VA: 0x181EA6160
	public static PersistantPlayer Deserialize(byte[] buffer, PersistantPlayer instance, bool isDelta = False) { }

	// RVA: 0x1EA5DC0 Offset: 0x1EA43C0 VA: 0x181EA5DC0
	public static PersistantPlayer Deserialize(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA57A0 Offset: 0x1EA3DA0 VA: 0x181EA57A0
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA5A70 Offset: 0x1EA4070 VA: 0x181EA5A70
	public static PersistantPlayer DeserializeLength(Stream stream, int length, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA65F0 Offset: 0x1EA4BF0 VA: 0x181EA65F0
	public static void SerializeDelta(Stream stream, PersistantPlayer instance, PersistantPlayer previous) { }

	// RVA: 0x1EA6980 Offset: 0x1EA4F80 VA: 0x181EA6980
	public static void Serialize(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1EA6B30 Offset: 0x1EA5130 VA: 0x181EA6B30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA6B40 Offset: 0x1EA5140 VA: 0x181EA6B40
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA6870 Offset: 0x1EA4E70 VA: 0x181EA6870
	public static byte[] SerializeToBytes(PersistantPlayer instance) { }

	// RVA: 0x1EA67C0 Offset: 0x1EA4DC0 VA: 0x181EA67C0
	public static void SerializeLengthDelimited(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

