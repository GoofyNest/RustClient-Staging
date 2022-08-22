public class PersistantPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6455
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> unlockedItems; // 0x18
	public int protocolVersion; // 0x20

	// Methods

	// RVA: 0x1EA6FE0 Offset: 0x1EA55E0 VA: 0x181EA6FE0
	public static void ResetToPool(PersistantPlayer instance) { }

	// RVA: 0x1EA6EF0 Offset: 0x1EA54F0 VA: 0x181EA6EF0
	public void ResetToPool() { }

	// RVA: 0x1EA6D40 Offset: 0x1EA5340 VA: 0x181EA6D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA5F70 Offset: 0x1EA4570 VA: 0x181EA5F70
	public void CopyTo(PersistantPlayer instance) { }

	// RVA: 0x1EA6090 Offset: 0x1EA4690 VA: 0x181EA6090
	public PersistantPlayer Copy() { }

	// RVA: 0x1EA6AA0 Offset: 0x1EA50A0 VA: 0x181EA6AA0
	public static PersistantPlayer Deserialize(Stream stream) { }

	// RVA: 0x1EA6200 Offset: 0x1EA4800 VA: 0x181EA6200
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA6810 Offset: 0x1EA4E10 VA: 0x181EA6810
	public static PersistantPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA6B20 Offset: 0x1EA5120 VA: 0x181EA6B20
	public static PersistantPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1EA6EB0 Offset: 0x1EA54B0 VA: 0x181EA6EB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA7620 Offset: 0x1EA5C20 VA: 0x181EA7620 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA7640 Offset: 0x1EA5C40 VA: 0x181EA7640 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PersistantPlayer previous) { }

	// RVA: 0x1EA6ED0 Offset: 0x1EA54D0 VA: 0x181EA6ED0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA6C40 Offset: 0x1EA5240 VA: 0x181EA6C40
	public static PersistantPlayer Deserialize(byte[] buffer, PersistantPlayer instance, bool isDelta = False) { }

	// RVA: 0x1EA68A0 Offset: 0x1EA4EA0 VA: 0x181EA68A0
	public static PersistantPlayer Deserialize(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA6280 Offset: 0x1EA4880 VA: 0x181EA6280
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA6550 Offset: 0x1EA4B50 VA: 0x181EA6550
	public static PersistantPlayer DeserializeLength(Stream stream, int length, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA70D0 Offset: 0x1EA56D0 VA: 0x181EA70D0
	public static void SerializeDelta(Stream stream, PersistantPlayer instance, PersistantPlayer previous) { }

	// RVA: 0x1EA7460 Offset: 0x1EA5A60 VA: 0x181EA7460
	public static void Serialize(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1EA7610 Offset: 0x1EA5C10 VA: 0x181EA7610
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA7620 Offset: 0x1EA5C20 VA: 0x181EA7620
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA7350 Offset: 0x1EA5950 VA: 0x181EA7350
	public static byte[] SerializeToBytes(PersistantPlayer instance) { }

	// RVA: 0x1EA72A0 Offset: 0x1EA58A0 VA: 0x181EA72A0
	public static void SerializeLengthDelimited(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

