public class ResourceExtractor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6323
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer fuelContents; // 0x18
	public ItemContainer outputContents; // 0x20

	// Methods

	// RVA: 0x1E04B80 Offset: 0x1E03180 VA: 0x181E04B80
	public static void ResetToPool(ResourceExtractor instance) { }

	// RVA: 0x1E04AA0 Offset: 0x1E030A0 VA: 0x181E04AA0
	public void ResetToPool() { }

	// RVA: 0x1E04900 Offset: 0x1E02F00 VA: 0x181E04900 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E03D10 Offset: 0x1E02310 VA: 0x181E03D10
	public void CopyTo(ResourceExtractor instance) { }

	// RVA: 0x1E03DD0 Offset: 0x1E023D0 VA: 0x181E03DD0
	public ResourceExtractor Copy() { }

	// RVA: 0x1E04880 Offset: 0x1E02E80 VA: 0x181E04880
	public static ResourceExtractor Deserialize(Stream stream) { }

	// RVA: 0x1E04160 Offset: 0x1E02760 VA: 0x181E04160
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E041E0 Offset: 0x1E027E0 VA: 0x181E041E0
	public static ResourceExtractor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E045C0 Offset: 0x1E02BC0 VA: 0x181E045C0
	public static ResourceExtractor Deserialize(byte[] buffer) { }

	// RVA: 0x1E04A60 Offset: 0x1E03060 VA: 0x181E04A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E05340 Offset: 0x1E03940 VA: 0x181E05340 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E05360 Offset: 0x1E03960 VA: 0x181E05360 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResourceExtractor previous) { }

	// RVA: 0x1E04A80 Offset: 0x1E03080 VA: 0x181E04A80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E044C0 Offset: 0x1E02AC0 VA: 0x181E044C0
	public static ResourceExtractor Deserialize(byte[] buffer, ResourceExtractor instance, bool isDelta = False) { }

	// RVA: 0x1E046E0 Offset: 0x1E02CE0 VA: 0x181E046E0
	public static ResourceExtractor Deserialize(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E03EE0 Offset: 0x1E024E0 VA: 0x181E03EE0
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E04270 Offset: 0x1E02870 VA: 0x181E04270
	public static ResourceExtractor DeserializeLength(Stream stream, int length, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E04C60 Offset: 0x1E03260 VA: 0x181E04C60
	public static void SerializeDelta(Stream stream, ResourceExtractor instance, ResourceExtractor previous) { }

	// RVA: 0x1E050C0 Offset: 0x1E036C0 VA: 0x181E050C0
	public static void Serialize(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1E05330 Offset: 0x1E03930 VA: 0x181E05330
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E05340 Offset: 0x1E03940 VA: 0x181E05340
	public void ToProto(Stream stream) { }

	// RVA: 0x1E04FB0 Offset: 0x1E035B0 VA: 0x181E04FB0
	public static byte[] SerializeToBytes(ResourceExtractor instance) { }

	// RVA: 0x1E04F00 Offset: 0x1E03500 VA: 0x181E04F00
	public static void SerializeLengthDelimited(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

