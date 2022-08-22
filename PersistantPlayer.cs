public class PersistantPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6455
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> unlockedItems; // 0x18
	public int protocolVersion; // 0x20

	// Methods

	// RVA: 0x1EA67C0 Offset: 0x1EA4DC0 VA: 0x181EA67C0
	public static void ResetToPool(PersistantPlayer instance) { }

	// RVA: 0x1EA66D0 Offset: 0x1EA4CD0 VA: 0x181EA66D0
	public void ResetToPool() { }

	// RVA: 0x1EA6520 Offset: 0x1EA4B20 VA: 0x181EA6520 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA5750 Offset: 0x1EA3D50 VA: 0x181EA5750
	public void CopyTo(PersistantPlayer instance) { }

	// RVA: 0x1EA5870 Offset: 0x1EA3E70 VA: 0x181EA5870
	public PersistantPlayer Copy() { }

	// RVA: 0x1EA6280 Offset: 0x1EA4880 VA: 0x181EA6280
	public static PersistantPlayer Deserialize(Stream stream) { }

	// RVA: 0x1EA59E0 Offset: 0x1EA3FE0 VA: 0x181EA59E0
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA5FF0 Offset: 0x1EA45F0 VA: 0x181EA5FF0
	public static PersistantPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA6300 Offset: 0x1EA4900 VA: 0x181EA6300
	public static PersistantPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1EA6690 Offset: 0x1EA4C90 VA: 0x181EA6690
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA6E00 Offset: 0x1EA5400 VA: 0x181EA6E00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA6E20 Offset: 0x1EA5420 VA: 0x181EA6E20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PersistantPlayer previous) { }

	// RVA: 0x1EA66B0 Offset: 0x1EA4CB0 VA: 0x181EA66B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA6420 Offset: 0x1EA4A20 VA: 0x181EA6420
	public static PersistantPlayer Deserialize(byte[] buffer, PersistantPlayer instance, bool isDelta = False) { }

	// RVA: 0x1EA6080 Offset: 0x1EA4680 VA: 0x181EA6080
	public static PersistantPlayer Deserialize(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA5A60 Offset: 0x1EA4060 VA: 0x181EA5A60
	public static PersistantPlayer DeserializeLengthDelimited(Stream stream, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA5D30 Offset: 0x1EA4330 VA: 0x181EA5D30
	public static PersistantPlayer DeserializeLength(Stream stream, int length, PersistantPlayer instance, bool isDelta) { }

	// RVA: 0x1EA68B0 Offset: 0x1EA4EB0 VA: 0x181EA68B0
	public static void SerializeDelta(Stream stream, PersistantPlayer instance, PersistantPlayer previous) { }

	// RVA: 0x1EA6C40 Offset: 0x1EA5240 VA: 0x181EA6C40
	public static void Serialize(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1EA6DF0 Offset: 0x1EA53F0 VA: 0x181EA6DF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA6E00 Offset: 0x1EA5400 VA: 0x181EA6E00
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA6B30 Offset: 0x1EA5130 VA: 0x181EA6B30
	public static byte[] SerializeToBytes(PersistantPlayer instance) { }

	// RVA: 0x1EA6A80 Offset: 0x1EA5080 VA: 0x181EA6A80
	public static void SerializeLengthDelimited(Stream stream, PersistantPlayer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

