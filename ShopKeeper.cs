public class ShopKeeper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6381
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingRef; // 0x14

	// Methods

	// RVA: 0x1E092B0 Offset: 0x1E078B0 VA: 0x181E092B0
	public static void ResetToPool(ShopKeeper instance) { }

	// RVA: 0x1E09330 Offset: 0x1E07930 VA: 0x181E09330
	public void ResetToPool() { }

	// RVA: 0x1E09180 Offset: 0x1E07780 VA: 0x181E09180 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(ShopKeeper instance) { }

	// RVA: 0x1E08800 Offset: 0x1E06E00 VA: 0x181E08800
	public ShopKeeper Copy() { }

	// RVA: 0x1E09100 Offset: 0x1E07700 VA: 0x181E09100
	public static ShopKeeper Deserialize(Stream stream) { }

	// RVA: 0x1E08A90 Offset: 0x1E07090 VA: 0x181E08A90
	public static ShopKeeper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E08B10 Offset: 0x1E07110 VA: 0x181E08B10
	public static ShopKeeper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E08EE0 Offset: 0x1E074E0 VA: 0x181E08EE0
	public static ShopKeeper Deserialize(byte[] buffer) { }

	// RVA: 0x1E09270 Offset: 0x1E07870 VA: 0x181E09270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E09800 Offset: 0x1E07E00 VA: 0x181E09800 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E098D0 Offset: 0x1E07ED0 VA: 0x181E098D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ShopKeeper previous) { }

	// RVA: 0x1E09290 Offset: 0x1E07890 VA: 0x181E09290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E09000 Offset: 0x1E07600 VA: 0x181E09000
	public static ShopKeeper Deserialize(byte[] buffer, ShopKeeper instance, bool isDelta = False) { }

	// RVA: 0x1E08DA0 Offset: 0x1E073A0 VA: 0x181E08DA0
	public static ShopKeeper Deserialize(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E08870 Offset: 0x1E06E70 VA: 0x181E08870
	public static ShopKeeper DeserializeLengthDelimited(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E08BA0 Offset: 0x1E071A0 VA: 0x181E08BA0
	public static ShopKeeper DeserializeLength(Stream stream, int length, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E093B0 Offset: 0x1E079B0 VA: 0x181E093B0
	public static void SerializeDelta(Stream stream, ShopKeeper instance, ShopKeeper previous) { }

	// RVA: 0x1E09720 Offset: 0x1E07D20 VA: 0x181E09720
	public static void Serialize(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1E097F0 Offset: 0x1E07DF0 VA: 0x181E097F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E09800 Offset: 0x1E07E00 VA: 0x181E09800
	public void ToProto(Stream stream) { }

	// RVA: 0x1E09570 Offset: 0x1E07B70 VA: 0x181E09570
	public static byte[] SerializeToBytes(ShopKeeper instance) { }

	// RVA: 0x1E094C0 Offset: 0x1E07AC0 VA: 0x181E094C0
	public static void SerializeLengthDelimited(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

