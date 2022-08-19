public class ResourceExtractor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6323
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer fuelContents; // 0x18
	public ItemContainer outputContents; // 0x20

	// Methods

	// RVA: 0x1E04260 Offset: 0x1E02860 VA: 0x181E04260
	public static void ResetToPool(ResourceExtractor instance) { }

	// RVA: 0x1E04180 Offset: 0x1E02780 VA: 0x181E04180
	public void ResetToPool() { }

	// RVA: 0x1E03FE0 Offset: 0x1E025E0 VA: 0x181E03FE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E033F0 Offset: 0x1E019F0 VA: 0x181E033F0
	public void CopyTo(ResourceExtractor instance) { }

	// RVA: 0x1E034B0 Offset: 0x1E01AB0 VA: 0x181E034B0
	public ResourceExtractor Copy() { }

	// RVA: 0x1E03F60 Offset: 0x1E02560 VA: 0x181E03F60
	public static ResourceExtractor Deserialize(Stream stream) { }

	// RVA: 0x1E03840 Offset: 0x1E01E40 VA: 0x181E03840
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E038C0 Offset: 0x1E01EC0 VA: 0x181E038C0
	public static ResourceExtractor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E03CA0 Offset: 0x1E022A0 VA: 0x181E03CA0
	public static ResourceExtractor Deserialize(byte[] buffer) { }

	// RVA: 0x1E04140 Offset: 0x1E02740 VA: 0x181E04140
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E04A20 Offset: 0x1E03020 VA: 0x181E04A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E04A40 Offset: 0x1E03040 VA: 0x181E04A40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResourceExtractor previous) { }

	// RVA: 0x1E04160 Offset: 0x1E02760 VA: 0x181E04160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E03BA0 Offset: 0x1E021A0 VA: 0x181E03BA0
	public static ResourceExtractor Deserialize(byte[] buffer, ResourceExtractor instance, bool isDelta = False) { }

	// RVA: 0x1E03DC0 Offset: 0x1E023C0 VA: 0x181E03DC0
	public static ResourceExtractor Deserialize(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E035C0 Offset: 0x1E01BC0 VA: 0x181E035C0
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E03950 Offset: 0x1E01F50 VA: 0x181E03950
	public static ResourceExtractor DeserializeLength(Stream stream, int length, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1E04340 Offset: 0x1E02940 VA: 0x181E04340
	public static void SerializeDelta(Stream stream, ResourceExtractor instance, ResourceExtractor previous) { }

	// RVA: 0x1E047A0 Offset: 0x1E02DA0 VA: 0x181E047A0
	public static void Serialize(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1E04A10 Offset: 0x1E03010 VA: 0x181E04A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E04A20 Offset: 0x1E03020 VA: 0x181E04A20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E04690 Offset: 0x1E02C90 VA: 0x181E04690
	public static byte[] SerializeToBytes(ResourceExtractor instance) { }

	// RVA: 0x1E045E0 Offset: 0x1E02BE0 VA: 0x181E045E0
	public static void SerializeLengthDelimited(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

