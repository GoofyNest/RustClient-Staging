public class ResourceExtractor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6323
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer fuelContents; // 0x18
	public ItemContainer outputContents; // 0x20

	// Methods

	// RVA: 0x1E04360 Offset: 0x1E02960 VA: 0x181E04360
	public static void ResetToPool(ResourceExtractor instance) { }

	// RVA: 0x1E04280 Offset: 0x1E02880 VA: 0x181E04280
	public void ResetToPool() { }

	// RVA: 0x1E040E0 Offset: 0x1E026E0 VA: 0x181E040E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E034F0 Offset: 0x1E01AF0 VA: 0x181E034F0
	public void CopyTo(ResourceExtractor instance) { }

	// RVA: 0x1E035B0 Offset: 0x1E01BB0 VA: 0x181E035B0
	public ResourceExtractor Copy() { }

	// RVA: 0x1E04060 Offset: 0x1E02660 VA: 0x181E04060
	public static ResourceExtractor Deserialize(Stream stream) { }

	// RVA: 0x1E03940 Offset: 0x1E01F40 VA: 0x181E03940
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E039C0 Offset: 0x1E01FC0 VA: 0x181E039C0
	public static ResourceExtractor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E03DA0 Offset: 0x1E023A0 VA: 0x181E03DA0
	public static ResourceExtractor Deserialize(byte[] buffer) { }

	// RVA: 0x1E04240 Offset: 0x1E02840 VA: 0x181E04240
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E04B20 Offset: 0x1E03120 VA: 0x181E04B20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E04B40 Offset: 0x1E03140 VA: 0x181E04B40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResourceExtractor previous) { }

	// RVA: 0x1E04260 Offset: 0x1E02860 VA: 0x181E04260 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E03CA0 Offset: 0x1E022A0 VA: 0x181E03CA0
	public static ResourceExtractor Deserialize(byte[] buffer, ResourceExtractor instance, bool isDelta = False) { }

	// RVA: 0x1E03EC0 Offset: 0x1E024C0 VA: 0x181E03EC0
	public static ResourceExtractor Deserialize(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E036C0 Offset: 0x1E01CC0 VA: 0x181E036C0
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E03A50 Offset: 0x1E02050 VA: 0x181E03A50
	public static ResourceExtractor DeserializeLength(Stream stream, int length, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E04440 Offset: 0x1E02A40 VA: 0x181E04440
	public static void SerializeDelta(Stream stream, ResourceExtractor instance, ResourceExtractor previous) { }

	// RVA: 0x1E048A0 Offset: 0x1E02EA0 VA: 0x181E048A0
	public static void Serialize(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1E04B10 Offset: 0x1E03110 VA: 0x181E04B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E04B20 Offset: 0x1E03120 VA: 0x181E04B20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E04790 Offset: 0x1E02D90 VA: 0x181E04790
	public static byte[] SerializeToBytes(ResourceExtractor instance) { }

	// RVA: 0x1E046E0 Offset: 0x1E02CE0 VA: 0x181E046E0
	public static void SerializeLengthDelimited(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

