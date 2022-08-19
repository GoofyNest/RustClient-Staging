public class BaseTrain : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6437
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float time; // 0x14
	public float frontBogieYRot; // 0x18
	public float rearBogieYRot; // 0x1C
	public uint frontCouplingID; // 0x20
	public bool frontCouplingToFront; // 0x24
	public uint rearCouplingID; // 0x28
	public bool rearCouplingToFront; // 0x2C
	public int lootTypeIndex; // 0x30
	public float lootPercent; // 0x34

	// Methods

	// RVA: 0x1F69300 Offset: 0x1F67900 VA: 0x181F69300
	public static void ResetToPool(BaseTrain instance) { }

	// RVA: 0x1F693F0 Offset: 0x1F679F0 VA: 0x181F693F0
	public void ResetToPool() { }

	// RVA: 0x1F68DF0 Offset: 0x1F673F0 VA: 0x181F68DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F67390 Offset: 0x1F65990 VA: 0x181F67390
	public void CopyTo(BaseTrain instance) { }

	// RVA: 0x1F673E0 Offset: 0x1F659E0 VA: 0x181F673E0
	public BaseTrain Copy() { }

	// RVA: 0x1F68270 Offset: 0x1F66870 VA: 0x181F68270
	public static BaseTrain Deserialize(Stream stream) { }

	// RVA: 0x1F678C0 Offset: 0x1F65EC0 VA: 0x181F678C0
	public static BaseTrain DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F67940 Offset: 0x1F65F40 VA: 0x181F67940
	public static BaseTrain DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F67DF0 Offset: 0x1F663F0 VA: 0x181F67DF0
	public static BaseTrain Deserialize(byte[] buffer) { }

	// RVA: 0x1F68F70 Offset: 0x1F67570 VA: 0x181F68F70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F69C60 Offset: 0x1F68260 VA: 0x181F69C60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F69C80 Offset: 0x1F68280 VA: 0x181F69C80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseTrain previous) { }

	// RVA: 0x1F692E0 Offset: 0x1F678E0 VA: 0x181F692E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F68620 Offset: 0x1F66C20 VA: 0x181F68620
	public static BaseTrain Deserialize(byte[] buffer, BaseTrain instance, bool isDelta = False) { }

	// RVA: 0x1F68A80 Offset: 0x1F67080 VA: 0x181F68A80
	public static BaseTrain Deserialize(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F67480 Offset: 0x1F65A80 VA: 0x181F67480
	public static BaseTrain DeserializeLengthDelimited(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F679D0 Offset: 0x1F65FD0 VA: 0x181F679D0
	public static BaseTrain DeserializeLength(Stream stream, int length, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F694E0 Offset: 0x1F67AE0 VA: 0x181F694E0
	public static void SerializeDelta(Stream stream, BaseTrain instance, BaseTrain previous) { }

	// RVA: 0x1F69A50 Offset: 0x1F68050 VA: 0x181F69A50
	public static void Serialize(Stream stream, BaseTrain instance) { }

	// RVA: 0x1F69C50 Offset: 0x1F68250 VA: 0x181F69C50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F69C60 Offset: 0x1F68260 VA: 0x181F69C60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F69940 Offset: 0x1F67F40 VA: 0x181F69940
	public static byte[] SerializeToBytes(BaseTrain instance) { }

	// RVA: 0x1F69890 Offset: 0x1F67E90 VA: 0x181F69890
	public static void SerializeLengthDelimited(Stream stream, BaseTrain instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

