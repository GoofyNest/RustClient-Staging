public class MemoryBank : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int slotCount; // 0x18
	public List<int> slots; // 0x20

	// Methods

	// RVA: 0x1F45560 Offset: 0x1F43B60 VA: 0x181F45560
	public static void ResetToPool(MemoryBank instance) { }

	// RVA: 0x1F45460 Offset: 0x1F43A60 VA: 0x181F45460
	public void ResetToPool() { }

	// RVA: 0x1F452B0 Offset: 0x1F438B0 VA: 0x181F452B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F440C0 Offset: 0x1F426C0 VA: 0x181F440C0
	public void CopyTo(MemoryBank instance) { }

	// RVA: 0x1F441E0 Offset: 0x1F427E0 VA: 0x181F441E0
	public MemoryBank Copy() { }

	// RVA: 0x1F44C80 Offset: 0x1F43280 VA: 0x181F44C80
	public static MemoryBank Deserialize(Stream stream) { }

	// RVA: 0x1F44650 Offset: 0x1F42C50 VA: 0x181F44650
	public static MemoryBank DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F446D0 Offset: 0x1F42CD0 VA: 0x181F446D0
	public static MemoryBank DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F44EC0 Offset: 0x1F434C0 VA: 0x181F44EC0
	public static MemoryBank Deserialize(byte[] buffer) { }

	// RVA: 0x1F45420 Offset: 0x1F43A20 VA: 0x181F45420
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F45BE0 Offset: 0x1F441E0 VA: 0x181F45BE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F45C00 Offset: 0x1F44200 VA: 0x181F45C00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MemoryBank previous) { }

	// RVA: 0x1F45440 Offset: 0x1F43A40 VA: 0x181F45440 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F451B0 Offset: 0x1F437B0 VA: 0x181F451B0
	public static MemoryBank Deserialize(byte[] buffer, MemoryBank instance, bool isDelta = False) { }

	// RVA: 0x1F44A50 Offset: 0x1F43050 VA: 0x181F44A50
	public static MemoryBank Deserialize(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44350 Offset: 0x1F42950 VA: 0x181F44350
	public static MemoryBank DeserializeLengthDelimited(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44760 Offset: 0x1F42D60 VA: 0x181F44760
	public static MemoryBank DeserializeLength(Stream stream, int length, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F45660 Offset: 0x1F43C60 VA: 0x181F45660
	public static void SerializeDelta(Stream stream, MemoryBank instance, MemoryBank previous) { }

	// RVA: 0x1F45A20 Offset: 0x1F44020 VA: 0x181F45A20
	public static void Serialize(Stream stream, MemoryBank instance) { }

	// RVA: 0x1F45BD0 Offset: 0x1F441D0 VA: 0x181F45BD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F45BE0 Offset: 0x1F441E0 VA: 0x181F45BE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F45910 Offset: 0x1F43F10 VA: 0x181F45910
	public static byte[] SerializeToBytes(MemoryBank instance) { }

	// RVA: 0x1F45860 Offset: 0x1F43E60 VA: 0x181F45860
	public static void SerializeLengthDelimited(Stream stream, MemoryBank instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

