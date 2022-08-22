public class ZiplineArrivalPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5BFF0 Offset: 0x1E5A5F0 VA: 0x181E5BFF0
	public static void ResetToPool(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5C0D0 Offset: 0x1E5A6D0 VA: 0x181E5C0D0
	public void ResetToPool() { }

	// RVA: 0x1E5BE60 Offset: 0x1E5A460 VA: 0x181E5BE60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5B0F0 Offset: 0x1E596F0 VA: 0x181E5B0F0
	public void CopyTo(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5B250 Offset: 0x1E59850 VA: 0x181E5B250
	public ZiplineArrivalPoint Copy() { }

	// RVA: 0x1E5BCE0 Offset: 0x1E5A2E0 VA: 0x181E5BCE0
	public static ZiplineArrivalPoint Deserialize(Stream stream) { }

	// RVA: 0x1E5B690 Offset: 0x1E59C90 VA: 0x181E5B690
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5B980 Offset: 0x1E59F80 VA: 0x181E5B980
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5BBC0 Offset: 0x1E5A1C0 VA: 0x181E5BBC0
	public static ZiplineArrivalPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1E5BFB0 Offset: 0x1E5A5B0 VA: 0x181E5BFB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5C890 Offset: 0x1E5AE90 VA: 0x181E5C890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5C8B0 Offset: 0x1E5AEB0 VA: 0x181E5C8B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5BFD0 Offset: 0x1E5A5D0 VA: 0x181E5BFD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5BD60 Offset: 0x1E5A360 VA: 0x181E5BD60
	public static ZiplineArrivalPoint Deserialize(byte[] buffer, ZiplineArrivalPoint instance, bool isDelta = False) { }

	// RVA: 0x1E5BA10 Offset: 0x1E5A010 VA: 0x181E5BA10
	public static ZiplineArrivalPoint Deserialize(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5B410 Offset: 0x1E59A10 VA: 0x181E5B410
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5B710 Offset: 0x1E59D10 VA: 0x181E5B710
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E5C1B0 Offset: 0x1E5A7B0 VA: 0x181E5C1B0
	public static void SerializeDelta(Stream stream, ZiplineArrivalPoint instance, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E5C630 Offset: 0x1E5AC30 VA: 0x181E5C630
	public static void Serialize(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5C880 Offset: 0x1E5AE80 VA: 0x181E5C880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5C890 Offset: 0x1E5AE90 VA: 0x181E5C890
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5C520 Offset: 0x1E5AB20 VA: 0x181E5C520
	public static byte[] SerializeToBytes(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E5C430 Offset: 0x1E5AA30 VA: 0x181E5C430
	public static void SerializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ZiplineArrivalPoint : BaseEntity // TypeDefIndex: 8669
{	// Fields
	public LineRenderer Line; // 0x168
	private Vector3[] linePositions; // 0x170

	// Methods

	// RVA: 0x1A78800 Offset: 0x1A76E00 VA: 0x181A78800 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A789A0 Offset: 0x1A76FA0 VA: 0x181A789A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A789D0 Offset: 0x1A76FD0 VA: 0x181A789D0
	private void UpdateLineRenderer() { }

	// RVA: 0x1A78B60 Offset: 0x1A77160 VA: 0x181A78B60
	public void .ctor() { }

}

