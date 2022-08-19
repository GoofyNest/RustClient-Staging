public class MemoryBank : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int slotCount; // 0x18
	public List<int> slots; // 0x20

	// Methods

	// RVA: 0x1F45460 Offset: 0x1F43A60 VA: 0x181F45460
	public static void ResetToPool(MemoryBank instance) { }

	// RVA: 0x1F45360 Offset: 0x1F43960 VA: 0x181F45360
	public void ResetToPool() { }

	// RVA: 0x1F451B0 Offset: 0x1F437B0 VA: 0x181F451B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F43FC0 Offset: 0x1F425C0 VA: 0x181F43FC0
	public void CopyTo(MemoryBank instance) { }

	// RVA: 0x1F440E0 Offset: 0x1F426E0 VA: 0x181F440E0
	public MemoryBank Copy() { }

	// RVA: 0x1F44B80 Offset: 0x1F43180 VA: 0x181F44B80
	public static MemoryBank Deserialize(Stream stream) { }

	// RVA: 0x1F44550 Offset: 0x1F42B50 VA: 0x181F44550
	public static MemoryBank DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F445D0 Offset: 0x1F42BD0 VA: 0x181F445D0
	public static MemoryBank DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F44DC0 Offset: 0x1F433C0 VA: 0x181F44DC0
	public static MemoryBank Deserialize(byte[] buffer) { }

	// RVA: 0x1F45320 Offset: 0x1F43920 VA: 0x181F45320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F45AE0 Offset: 0x1F440E0 VA: 0x181F45AE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F45B00 Offset: 0x1F44100 VA: 0x181F45B00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MemoryBank previous) { }

	// RVA: 0x1F45340 Offset: 0x1F43940 VA: 0x181F45340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F450B0 Offset: 0x1F436B0 VA: 0x181F450B0
	public static MemoryBank Deserialize(byte[] buffer, MemoryBank instance, bool isDelta = False) { }

	// RVA: 0x1F44950 Offset: 0x1F42F50 VA: 0x181F44950
	public static MemoryBank Deserialize(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44250 Offset: 0x1F42850 VA: 0x181F44250
	public static MemoryBank DeserializeLengthDelimited(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44660 Offset: 0x1F42C60 VA: 0x181F44660
	public static MemoryBank DeserializeLength(Stream stream, int length, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F45560 Offset: 0x1F43B60 VA: 0x181F45560
	public static void SerializeDelta(Stream stream, MemoryBank instance, MemoryBank previous) { }

	// RVA: 0x1F45920 Offset: 0x1F43F20 VA: 0x181F45920
	public static void Serialize(Stream stream, MemoryBank instance) { }

	// RVA: 0x1F45AD0 Offset: 0x1F440D0 VA: 0x181F45AD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F45AE0 Offset: 0x1F440E0 VA: 0x181F45AE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F45810 Offset: 0x1F43E10 VA: 0x181F45810
	public static byte[] SerializeToBytes(MemoryBank instance) { }

	// RVA: 0x1F45760 Offset: 0x1F43D60 VA: 0x181F45760
	public static void SerializeLengthDelimited(Stream stream, MemoryBank instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

