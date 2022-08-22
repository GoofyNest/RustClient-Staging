public class MemoryBank : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int slotCount; // 0x18
	public List<int> slots; // 0x20

	// Methods

	// RVA: 0x1F452A0 Offset: 0x1F438A0 VA: 0x181F452A0
	public static void ResetToPool(MemoryBank instance) { }

	// RVA: 0x1F451A0 Offset: 0x1F437A0 VA: 0x181F451A0
	public void ResetToPool() { }

	// RVA: 0x1F44FF0 Offset: 0x1F435F0 VA: 0x181F44FF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F43E00 Offset: 0x1F42400 VA: 0x181F43E00
	public void CopyTo(MemoryBank instance) { }

	// RVA: 0x1F43F20 Offset: 0x1F42520 VA: 0x181F43F20
	public MemoryBank Copy() { }

	// RVA: 0x1F449C0 Offset: 0x1F42FC0 VA: 0x181F449C0
	public static MemoryBank Deserialize(Stream stream) { }

	// RVA: 0x1F44390 Offset: 0x1F42990 VA: 0x181F44390
	public static MemoryBank DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F44410 Offset: 0x1F42A10 VA: 0x181F44410
	public static MemoryBank DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F44C00 Offset: 0x1F43200 VA: 0x181F44C00
	public static MemoryBank Deserialize(byte[] buffer) { }

	// RVA: 0x1F45160 Offset: 0x1F43760 VA: 0x181F45160
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F45920 Offset: 0x1F43F20 VA: 0x181F45920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F45940 Offset: 0x1F43F40 VA: 0x181F45940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MemoryBank previous) { }

	// RVA: 0x1F45180 Offset: 0x1F43780 VA: 0x181F45180 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F44EF0 Offset: 0x1F434F0 VA: 0x181F44EF0
	public static MemoryBank Deserialize(byte[] buffer, MemoryBank instance, bool isDelta = False) { }

	// RVA: 0x1F44790 Offset: 0x1F42D90 VA: 0x181F44790
	public static MemoryBank Deserialize(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F44090 Offset: 0x1F42690 VA: 0x181F44090
	public static MemoryBank DeserializeLengthDelimited(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F444A0 Offset: 0x1F42AA0 VA: 0x181F444A0
	public static MemoryBank DeserializeLength(Stream stream, int length, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F453A0 Offset: 0x1F439A0 VA: 0x181F453A0
	public static void SerializeDelta(Stream stream, MemoryBank instance, MemoryBank previous) { }

	// RVA: 0x1F45760 Offset: 0x1F43D60 VA: 0x181F45760
	public static void Serialize(Stream stream, MemoryBank instance) { }

	// RVA: 0x1F45910 Offset: 0x1F43F10 VA: 0x181F45910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F45920 Offset: 0x1F43F20 VA: 0x181F45920
	public void ToProto(Stream stream) { }

	// RVA: 0x1F45650 Offset: 0x1F43C50 VA: 0x181F45650
	public static byte[] SerializeToBytes(MemoryBank instance) { }

	// RVA: 0x1F455A0 Offset: 0x1F43BA0 VA: 0x181F455A0
	public static void SerializeLengthDelimited(Stream stream, MemoryBank instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

