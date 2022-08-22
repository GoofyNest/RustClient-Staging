public class ZiplineArrivalPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5B510 Offset: 0x1E59B10 VA: 0x181E5B510
	public static void ResetToPool(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5B5F0 Offset: 0x1E59BF0 VA: 0x181E5B5F0
	public void ResetToPool() { }

	// RVA: 0x1E5B380 Offset: 0x1E59980 VA: 0x181E5B380 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5A610 Offset: 0x1E58C10 VA: 0x181E5A610
	public void CopyTo(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5A770 Offset: 0x1E58D70 VA: 0x181E5A770
	public ZiplineArrivalPoint Copy() { }

	// RVA: 0x1E5B200 Offset: 0x1E59800 VA: 0x181E5B200
	public static ZiplineArrivalPoint Deserialize(Stream stream) { }

	// RVA: 0x1E5ABB0 Offset: 0x1E591B0 VA: 0x181E5ABB0
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5AEA0 Offset: 0x1E594A0 VA: 0x181E5AEA0
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5B0E0 Offset: 0x1E596E0 VA: 0x181E5B0E0
	public static ZiplineArrivalPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1E5B4D0 Offset: 0x1E59AD0 VA: 0x181E5B4D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5BDB0 Offset: 0x1E5A3B0 VA: 0x181E5BDB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5BDD0 Offset: 0x1E5A3D0 VA: 0x181E5BDD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5B4F0 Offset: 0x1E59AF0 VA: 0x181E5B4F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5B280 Offset: 0x1E59880 VA: 0x181E5B280
	public static ZiplineArrivalPoint Deserialize(byte[] buffer, ZiplineArrivalPoint instance, bool isDelta = False) { }

	// RVA: 0x1E5AF30 Offset: 0x1E59530 VA: 0x181E5AF30
	public static ZiplineArrivalPoint Deserialize(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5A930 Offset: 0x1E58F30 VA: 0x181E5A930
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5AC30 Offset: 0x1E59230 VA: 0x181E5AC30
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5B6D0 Offset: 0x1E59CD0 VA: 0x181E5B6D0
	public static void SerializeDelta(Stream stream, ZiplineArrivalPoint instance, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5BB50 Offset: 0x1E5A150 VA: 0x181E5BB50
	public static void Serialize(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5BDA0 Offset: 0x1E5A3A0 VA: 0x181E5BDA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5BDB0 Offset: 0x1E5A3B0 VA: 0x181E5BDB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5BA40 Offset: 0x1E5A040 VA: 0x181E5BA40
	public static byte[] SerializeToBytes(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5B950 Offset: 0x1E59F50 VA: 0x181E5B950
	public static void SerializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ZiplineArrivalPoint : BaseEntity // TypeDefIndex: 8669
{	// Fields
	public LineRenderer Line; // 0x168
	private Vector3[] linePositions; // 0x170

	// Methods

	// RVA: 0x1A8BD30 Offset: 0x1A8A330 VA: 0x181A8BD30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A8BED0 Offset: 0x1A8A4D0 VA: 0x181A8BED0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A8BF00 Offset: 0x1A8A500 VA: 0x181A8BF00
	private void UpdateLineRenderer() { }

	// RVA: 0x1A8C090 Offset: 0x1A8A690 VA: 0x181A8C090
	public void .ctor() { }

}

