public class ShopKeeper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6381
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingRef; // 0x14

	// Methods

	// RVA: 0x1E09570 Offset: 0x1E07B70 VA: 0x181E09570
	public static void ResetToPool(ShopKeeper instance) { }

	// RVA: 0x1E095F0 Offset: 0x1E07BF0 VA: 0x181E095F0
	public void ResetToPool() { }

	// RVA: 0x1E09440 Offset: 0x1E07A40 VA: 0x181E09440 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(ShopKeeper instance) { }

	// RVA: 0x1E08AC0 Offset: 0x1E070C0 VA: 0x181E08AC0
	public ShopKeeper Copy() { }

	// RVA: 0x1E093C0 Offset: 0x1E079C0 VA: 0x181E093C0
	public static ShopKeeper Deserialize(Stream stream) { }

	// RVA: 0x1E08D50 Offset: 0x1E07350 VA: 0x181E08D50
	public static ShopKeeper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E08DD0 Offset: 0x1E073D0 VA: 0x181E08DD0
	public static ShopKeeper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E091A0 Offset: 0x1E077A0 VA: 0x181E091A0
	public static ShopKeeper Deserialize(byte[] buffer) { }

	// RVA: 0x1E09530 Offset: 0x1E07B30 VA: 0x181E09530
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E09AC0 Offset: 0x1E080C0 VA: 0x181E09AC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E09B90 Offset: 0x1E08190 VA: 0x181E09B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ShopKeeper previous) { }

	// RVA: 0x1E09550 Offset: 0x1E07B50 VA: 0x181E09550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E092C0 Offset: 0x1E078C0 VA: 0x181E092C0
	public static ShopKeeper Deserialize(byte[] buffer, ShopKeeper instance, bool isDelta = False) { }

	// RVA: 0x1E09060 Offset: 0x1E07660 VA: 0x181E09060
	public static ShopKeeper Deserialize(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E08B30 Offset: 0x1E07130 VA: 0x181E08B30
	public static ShopKeeper DeserializeLengthDelimited(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E08E60 Offset: 0x1E07460 VA: 0x181E08E60
	public static ShopKeeper DeserializeLength(Stream stream, int length, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E09670 Offset: 0x1E07C70 VA: 0x181E09670
	public static void SerializeDelta(Stream stream, ShopKeeper instance, ShopKeeper previous) { }

	// RVA: 0x1E099E0 Offset: 0x1E07FE0 VA: 0x181E099E0
	public static void Serialize(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1E09AB0 Offset: 0x1E080B0 VA: 0x181E09AB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E09AC0 Offset: 0x1E080C0 VA: 0x181E09AC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E09830 Offset: 0x1E07E30 VA: 0x181E09830
	public static byte[] SerializeToBytes(ShopKeeper instance) { }

	// RVA: 0x1E09780 Offset: 0x1E07D80 VA: 0x181E09780
	public static void SerializeLengthDelimited(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

