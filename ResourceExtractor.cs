public class ResourceExtractor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6323
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer fuelContents; // 0x18
	public ItemContainer outputContents; // 0x20

	// Methods

	// RVA: 0x1E040A0 Offset: 0x1E026A0 VA: 0x181E040A0
	public static void ResetToPool(ResourceExtractor instance) { }

	// RVA: 0x1E03FC0 Offset: 0x1E025C0 VA: 0x181E03FC0
	public void ResetToPool() { }

	// RVA: 0x1E03E20 Offset: 0x1E02420 VA: 0x181E03E20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E03230 Offset: 0x1E01830 VA: 0x181E03230
	public void CopyTo(ResourceExtractor instance) { }

	// RVA: 0x1E032F0 Offset: 0x1E018F0 VA: 0x181E032F0
	public ResourceExtractor Copy() { }

	// RVA: 0x1E03DA0 Offset: 0x1E023A0 VA: 0x181E03DA0
	public static ResourceExtractor Deserialize(Stream stream) { }

	// RVA: 0x1E03680 Offset: 0x1E01C80 VA: 0x181E03680
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E03700 Offset: 0x1E01D00 VA: 0x181E03700
	public static ResourceExtractor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E03AE0 Offset: 0x1E020E0 VA: 0x181E03AE0
	public static ResourceExtractor Deserialize(byte[] buffer) { }

	// RVA: 0x1E03F80 Offset: 0x1E02580 VA: 0x181E03F80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E04860 Offset: 0x1E02E60 VA: 0x181E04860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E04880 Offset: 0x1E02E80 VA: 0x181E04880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResourceExtractor previous) { }

	// RVA: 0x1E03FA0 Offset: 0x1E025A0 VA: 0x181E03FA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E039E0 Offset: 0x1E01FE0 VA: 0x181E039E0
	public static ResourceExtractor Deserialize(byte[] buffer, ResourceExtractor instance, bool isDelta = False) { }

	// RVA: 0x1E03C00 Offset: 0x1E02200 VA: 0x181E03C00
	public static ResourceExtractor Deserialize(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E03400 Offset: 0x1E01A00 VA: 0x181E03400
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E03790 Offset: 0x1E01D90 VA: 0x181E03790
	public static ResourceExtractor DeserializeLength(Stream stream, int length, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E04180 Offset: 0x1E02780 VA: 0x181E04180
	public static void SerializeDelta(Stream stream, ResourceExtractor instance, ResourceExtractor previous) { }

	// RVA: 0x1E045E0 Offset: 0x1E02BE0 VA: 0x181E045E0
	public static void Serialize(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1E04850 Offset: 0x1E02E50 VA: 0x181E04850
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E04860 Offset: 0x1E02E60 VA: 0x181E04860
	public void ToProto(Stream stream) { }

	// RVA: 0x1E044D0 Offset: 0x1E02AD0 VA: 0x181E044D0
	public static byte[] SerializeToBytes(ResourceExtractor instance) { }

	// RVA: 0x1E04420 Offset: 0x1E02A20 VA: 0x181E04420
	public static void SerializeLengthDelimited(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

