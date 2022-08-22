public class ShopKeeper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6381
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingRef; // 0x14

	// Methods

	// RVA: 0x1E09D90 Offset: 0x1E08390 VA: 0x181E09D90
	public static void ResetToPool(ShopKeeper instance) { }

	// RVA: 0x1E09E10 Offset: 0x1E08410 VA: 0x181E09E10
	public void ResetToPool() { }

	// RVA: 0x1E09C60 Offset: 0x1E08260 VA: 0x181E09C60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(ShopKeeper instance) { }

	// RVA: 0x1E092E0 Offset: 0x1E078E0 VA: 0x181E092E0
	public ShopKeeper Copy() { }

	// RVA: 0x1E09BE0 Offset: 0x1E081E0 VA: 0x181E09BE0
	public static ShopKeeper Deserialize(Stream stream) { }

	// RVA: 0x1E09570 Offset: 0x1E07B70 VA: 0x181E09570
	public static ShopKeeper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E095F0 Offset: 0x1E07BF0 VA: 0x181E095F0
	public static ShopKeeper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E099C0 Offset: 0x1E07FC0 VA: 0x181E099C0
	public static ShopKeeper Deserialize(byte[] buffer) { }

	// RVA: 0x1E09D50 Offset: 0x1E08350 VA: 0x181E09D50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0A2E0 Offset: 0x1E088E0 VA: 0x181E0A2E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0A3B0 Offset: 0x1E089B0 VA: 0x181E0A3B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ShopKeeper previous) { }

	// RVA: 0x1E09D70 Offset: 0x1E08370 VA: 0x181E09D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E09AE0 Offset: 0x1E080E0 VA: 0x181E09AE0
	public static ShopKeeper Deserialize(byte[] buffer, ShopKeeper instance, bool isDelta = False) { }

	// RVA: 0x1E09880 Offset: 0x1E07E80 VA: 0x181E09880
	public static ShopKeeper Deserialize(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E09350 Offset: 0x1E07950 VA: 0x181E09350
	public static ShopKeeper DeserializeLengthDelimited(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E09680 Offset: 0x1E07C80 VA: 0x181E09680
	public static ShopKeeper DeserializeLength(Stream stream, int length, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E09E90 Offset: 0x1E08490 VA: 0x181E09E90
	public static void SerializeDelta(Stream stream, ShopKeeper instance, ShopKeeper previous) { }

	// RVA: 0x1E0A200 Offset: 0x1E08800 VA: 0x181E0A200
	public static void Serialize(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1E0A2D0 Offset: 0x1E088D0 VA: 0x181E0A2D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0A2E0 Offset: 0x1E088E0 VA: 0x181E0A2E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0A050 Offset: 0x1E08650 VA: 0x181E0A050
	public static byte[] SerializeToBytes(ShopKeeper instance) { }

	// RVA: 0x1E09FA0 Offset: 0x1E085A0 VA: 0x181E09FA0
	public static void SerializeLengthDelimited(Stream stream, ShopKeeper instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

