public class MemoryBank : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int slotCount; // 0x18
	public List<int> slots; // 0x20

	// Methods

	// RVA: 0x1F45D80 Offset: 0x1F44380 VA: 0x181F45D80
	public static void ResetToPool(MemoryBank instance) { }

	// RVA: 0x1F45C80 Offset: 0x1F44280 VA: 0x181F45C80
	public void ResetToPool() { }

	// RVA: 0x1F45AD0 Offset: 0x1F440D0 VA: 0x181F45AD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F448E0 Offset: 0x1F42EE0 VA: 0x181F448E0
	public void CopyTo(MemoryBank instance) { }

	// RVA: 0x1F44A00 Offset: 0x1F43000 VA: 0x181F44A00
	public MemoryBank Copy() { }

	// RVA: 0x1F454A0 Offset: 0x1F43AA0 VA: 0x181F454A0
	public static MemoryBank Deserialize(Stream stream) { }

	// RVA: 0x1F44E70 Offset: 0x1F43470 VA: 0x181F44E70
	public static MemoryBank DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F44EF0 Offset: 0x1F434F0 VA: 0x181F44EF0
	public static MemoryBank DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F456E0 Offset: 0x1F43CE0 VA: 0x181F456E0
	public static MemoryBank Deserialize(byte[] buffer) { }

	// RVA: 0x1F45C40 Offset: 0x1F44240 VA: 0x181F45C40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F46400 Offset: 0x1F44A00 VA: 0x181F46400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F46420 Offset: 0x1F44A20 VA: 0x181F46420 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MemoryBank previous) { }

	// RVA: 0x1F45C60 Offset: 0x1F44260 VA: 0x181F45C60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F459D0 Offset: 0x1F43FD0 VA: 0x181F459D0
	public static MemoryBank Deserialize(byte[] buffer, MemoryBank instance, bool isDelta = False) { }

	// RVA: 0x1F45270 Offset: 0x1F43870 VA: 0x181F45270
	public static MemoryBank Deserialize(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44B70 Offset: 0x1F43170 VA: 0x181F44B70
	public static MemoryBank DeserializeLengthDelimited(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44F80 Offset: 0x1F43580 VA: 0x181F44F80
	public static MemoryBank DeserializeLength(Stream stream, int length, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F45E80 Offset: 0x1F44480 VA: 0x181F45E80
	public static void SerializeDelta(Stream stream, MemoryBank instance, MemoryBank previous) { }

	// RVA: 0x1F46240 Offset: 0x1F44840 VA: 0x181F46240
	public static void Serialize(Stream stream, MemoryBank instance) { }

	// RVA: 0x1F463F0 Offset: 0x1F449F0 VA: 0x181F463F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F46400 Offset: 0x1F44A00 VA: 0x181F46400
	public void ToProto(Stream stream) { }

	// RVA: 0x1F46130 Offset: 0x1F44730 VA: 0x181F46130
	public static byte[] SerializeToBytes(MemoryBank instance) { }

	// RVA: 0x1F46080 Offset: 0x1F44680 VA: 0x181F46080
	public static void SerializeLengthDelimited(Stream stream, MemoryBank instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

