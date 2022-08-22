public class ZiplineArrivalPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5B7D0 Offset: 0x1E59DD0 VA: 0x181E5B7D0
	public static void ResetToPool(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5B8B0 Offset: 0x1E59EB0 VA: 0x181E5B8B0
	public void ResetToPool() { }

	// RVA: 0x1E5B640 Offset: 0x1E59C40 VA: 0x181E5B640 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5A8D0 Offset: 0x1E58ED0 VA: 0x181E5A8D0
	public void CopyTo(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5AA30 Offset: 0x1E59030 VA: 0x181E5AA30
	public ZiplineArrivalPoint Copy() { }

	// RVA: 0x1E5B4C0 Offset: 0x1E59AC0 VA: 0x181E5B4C0
	public static ZiplineArrivalPoint Deserialize(Stream stream) { }

	// RVA: 0x1E5AE70 Offset: 0x1E59470 VA: 0x181E5AE70
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5B160 Offset: 0x1E59760 VA: 0x181E5B160
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5B3A0 Offset: 0x1E599A0 VA: 0x181E5B3A0
	public static ZiplineArrivalPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1E5B790 Offset: 0x1E59D90 VA: 0x181E5B790
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5C070 Offset: 0x1E5A670 VA: 0x181E5C070 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5C090 Offset: 0x1E5A690 VA: 0x181E5C090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5B7B0 Offset: 0x1E59DB0 VA: 0x181E5B7B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5B540 Offset: 0x1E59B40 VA: 0x181E5B540
	public static ZiplineArrivalPoint Deserialize(byte[] buffer, ZiplineArrivalPoint instance, bool isDelta = False) { }

	// RVA: 0x1E5B1F0 Offset: 0x1E597F0 VA: 0x181E5B1F0
	public static ZiplineArrivalPoint Deserialize(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5ABF0 Offset: 0x1E591F0 VA: 0x181E5ABF0
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5AEF0 Offset: 0x1E594F0 VA: 0x181E5AEF0
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5B990 Offset: 0x1E59F90 VA: 0x181E5B990
	public static void SerializeDelta(Stream stream, ZiplineArrivalPoint instance, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5BE10 Offset: 0x1E5A410 VA: 0x181E5BE10
	public static void Serialize(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5C060 Offset: 0x1E5A660 VA: 0x181E5C060
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5C070 Offset: 0x1E5A670 VA: 0x181E5C070
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5BD00 Offset: 0x1E5A300 VA: 0x181E5BD00
	public static byte[] SerializeToBytes(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5BC10 Offset: 0x1E5A210 VA: 0x181E5BC10
	public static void SerializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ZiplineArrivalPoint : BaseEntity // TypeDefIndex: 8669
{	// Fields
	public LineRenderer Line; // 0x168
	private Vector3[] linePositions; // 0x170

	// Methods

	// RVA: 0x1A8BFF0 Offset: 0x1A8A5F0 VA: 0x181A8BFF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A8C190 Offset: 0x1A8A790 VA: 0x181A8C190 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A8C1C0 Offset: 0x1A8A7C0 VA: 0x181A8C1C0
	private void UpdateLineRenderer() { }

	// RVA: 0x1A8C350 Offset: 0x1A8A950 VA: 0x181A8C350
	public void .ctor() { }

}

