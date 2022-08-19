public class ShopKeeper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6381
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingRef; // 0x14

	// Methods

	// RVA: 0x1E09470 Offset: 0x1E07A70 VA: 0x181E09470
	public static void ResetToPool(ShopKeeper instance) { }

	// RVA: 0x1E094F0 Offset: 0x1E07AF0 VA: 0x181E094F0
	public void ResetToPool() { }

	// RVA: 0x1E09340 Offset: 0x1E07940 VA: 0x181E09340 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(ShopKeeper instance) { }

	// RVA: 0x1E089C0 Offset: 0x1E06FC0 VA: 0x181E089C0
	public ShopKeeper Copy() { }

	// RVA: 0x1E092C0 Offset: 0x1E078C0 VA: 0x181E092C0
	public static ShopKeeper Deserialize(Stream stream) { }

	// RVA: 0x1E08C50 Offset: 0x1E07250 VA: 0x181E08C50
	public static ShopKeeper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E08CD0 Offset: 0x1E072D0 VA: 0x181E08CD0
	public static ShopKeeper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E090A0 Offset: 0x1E076A0 VA: 0x181E090A0
	public static ShopKeeper Deserialize(byte[] buffer) { }

	// RVA: 0x1E09430 Offset: 0x1E07A30 VA: 0x181E09430
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E099C0 Offset: 0x1E07FC0 VA: 0x181E099C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E09A90 Offset: 0x1E08090 VA: 0x181E09A90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ShopKeeper previous) { }

	// RVA: 0x1E09450 Offset: 0x1E07A50 VA: 0x181E09450 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E091C0 Offset: 0x1E077C0 VA: 0x181E091C0
	public static ShopKeeper Deserialize(byte[] buffer, ShopKeeper instance, bool isDelta = False) { }

	// RVA: 0x1E08F60 Offset: 0x1E07560 VA: 0x181E08F60
	public static ShopKeeper Deserialize(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E08A30 Offset: 0x1E07030 VA: 0x181E08A30
	public static ShopKeeper DeserializeLengthDelimited(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E08D60 Offset: 0x1E07360 VA: 0x181E08D60
	public static ShopKeeper DeserializeLength(Stream stream, int length, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E09570 Offset: 0x1E07B70 VA: 0x181E09570
	public static void SerializeDelta(Stream stream, ShopKeeper instance, ShopKeeper previous) { }

	// RVA: 0x1E098E0 Offset: 0x1E07EE0 VA: 0x181E098E0
	public static void Serialize(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1E099B0 Offset: 0x1E07FB0 VA: 0x181E099B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E099C0 Offset: 0x1E07FC0 VA: 0x181E099C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E09730 Offset: 0x1E07D30 VA: 0x181E09730
	public static byte[] SerializeToBytes(ShopKeeper instance) { }

	// RVA: 0x1E09680 Offset: 0x1E07C80 VA: 0x181E09680
	public static void SerializeLengthDelimited(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

