public class PersistantPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6455
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> unlockedItems; // 0x18
	public int protocolVersion; // 0x20

	// Methods

	// RVA: 0x1EA66C0 Offset: 0x1EA4CC0 VA: 0x181EA66C0
	public static void ResetToPool(PersistantPlayer instance) { }

	// RVA: 0x1EA65D0 Offset: 0x1EA4BD0 VA: 0x181EA65D0
	public void ResetToPool() { }

	// RVA: 0x1EA6420 Offset: 0x1EA4A20 VA: 0x181EA6420 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA5650 Offset: 0x1EA3C50 VA: 0x181EA5650
	public void CopyTo(PersistantPlayer instance) { }

	// RVA: 0x1EA5770 Offset: 0x1EA3D70 VA: 0x181EA5770
	public PersistantPlayer Copy() { }

	// RVA: 0x1EA6180 Offset: 0x1EA4780 VA: 0x181EA6180
	public static PersistantPlayer Deserialize(Stream stream) { }

	// RVA: 0x1EA58E0 Offset: 0x1EA3EE0 VA: 0x181EA58E0
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA5EF0 Offset: 0x1EA44F0 VA: 0x181EA5EF0
	public static PersistantPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA6200 Offset: 0x1EA4800 VA: 0x181EA6200
	public static PersistantPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1EA6590 Offset: 0x1EA4B90 VA: 0x181EA6590
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA6D00 Offset: 0x1EA5300 VA: 0x181EA6D00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA6D20 Offset: 0x1EA5320 VA: 0x181EA6D20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PersistantPlayer previous) { }

	// RVA: 0x1EA65B0 Offset: 0x1EA4BB0 VA: 0x181EA65B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA6320 Offset: 0x1EA4920 VA: 0x181EA6320
	public static PersistantPlayer Deserialize(byte[] buffer, PersistantPlayer instance, bool isDelta = False) { }

	// RVA: 0x1EA5F80 Offset: 0x1EA4580 VA: 0x181EA5F80
	public static PersistantPlayer Deserialize(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA5960 Offset: 0x1EA3F60 VA: 0x181EA5960
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA5C30 Offset: 0x1EA4230 VA: 0x181EA5C30
	public static PersistantPlayer DeserializeLength(Stream stream, int length, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA67B0 Offset: 0x1EA4DB0 VA: 0x181EA67B0
	public static void SerializeDelta(Stream stream, PersistantPlayer instance, PersistantPlayer previous) { }

	// RVA: 0x1EA6B40 Offset: 0x1EA5140 VA: 0x181EA6B40
	public static void Serialize(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1EA6CF0 Offset: 0x1EA52F0 VA: 0x181EA6CF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA6D00 Offset: 0x1EA5300 VA: 0x181EA6D00
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA6A30 Offset: 0x1EA5030 VA: 0x181EA6A30
	public static byte[] SerializeToBytes(PersistantPlayer instance) { }

	// RVA: 0x1EA6980 Offset: 0x1EA4F80 VA: 0x181EA6980
	public static void SerializeLengthDelimited(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

