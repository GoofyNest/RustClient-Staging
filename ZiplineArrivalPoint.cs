public class ZiplineArrivalPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5B6D0 Offset: 0x1E59CD0 VA: 0x181E5B6D0
	public static void ResetToPool(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5B7B0 Offset: 0x1E59DB0 VA: 0x181E5B7B0
	public void ResetToPool() { }

	// RVA: 0x1E5B540 Offset: 0x1E59B40 VA: 0x181E5B540 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5A7D0 Offset: 0x1E58DD0 VA: 0x181E5A7D0
	public void CopyTo(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5A930 Offset: 0x1E58F30 VA: 0x181E5A930
	public ZiplineArrivalPoint Copy() { }

	// RVA: 0x1E5B3C0 Offset: 0x1E599C0 VA: 0x181E5B3C0
	public static ZiplineArrivalPoint Deserialize(Stream stream) { }

	// RVA: 0x1E5AD70 Offset: 0x1E59370 VA: 0x181E5AD70
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5B060 Offset: 0x1E59660 VA: 0x181E5B060
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5B2A0 Offset: 0x1E598A0 VA: 0x181E5B2A0
	public static ZiplineArrivalPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1E5B690 Offset: 0x1E59C90 VA: 0x181E5B690
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5BF70 Offset: 0x1E5A570 VA: 0x181E5BF70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5BF90 Offset: 0x1E5A590 VA: 0x181E5BF90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5B6B0 Offset: 0x1E59CB0 VA: 0x181E5B6B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5B440 Offset: 0x1E59A40 VA: 0x181E5B440
	public static ZiplineArrivalPoint Deserialize(byte[] buffer, ZiplineArrivalPoint instance, bool isDelta = False) { }

	// RVA: 0x1E5B0F0 Offset: 0x1E596F0 VA: 0x181E5B0F0
	public static ZiplineArrivalPoint Deserialize(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5AAF0 Offset: 0x1E590F0 VA: 0x181E5AAF0
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5ADF0 Offset: 0x1E593F0 VA: 0x181E5ADF0
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5B890 Offset: 0x1E59E90 VA: 0x181E5B890
	public static void SerializeDelta(Stream stream, ZiplineArrivalPoint instance, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5BD10 Offset: 0x1E5A310 VA: 0x181E5BD10
	public static void Serialize(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5BF60 Offset: 0x1E5A560 VA: 0x181E5BF60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5BF70 Offset: 0x1E5A570 VA: 0x181E5BF70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5BC00 Offset: 0x1E5A200 VA: 0x181E5BC00
	public static byte[] SerializeToBytes(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5BB10 Offset: 0x1E5A110 VA: 0x181E5BB10
	public static void SerializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ZiplineArrivalPoint : BaseEntity // TypeDefIndex: 8669
{	// Fields
	public LineRenderer Line; // 0x168
	private Vector3[] linePositions; // 0x170

	// Methods

	// RVA: 0x1AA20C0 Offset: 0x1AA06C0 VA: 0x181AA20C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1AA2260 Offset: 0x1AA0860 VA: 0x181AA2260 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1AA2290 Offset: 0x1AA0890 VA: 0x181AA2290
	private void UpdateLineRenderer() { }

	// RVA: 0x1AA2420 Offset: 0x1AA0A20 VA: 0x181AA2420
	public void .ctor() { }

}

