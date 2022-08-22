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

	// RVA: 0x1F69140 Offset: 0x1F67740 VA: 0x181F69140
	public static void ResetToPool(BaseTrain instance) { }

	// RVA: 0x1F69230 Offset: 0x1F67830 VA: 0x181F69230
	public void ResetToPool() { }

	// RVA: 0x1F68C30 Offset: 0x1F67230 VA: 0x181F68C30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F671D0 Offset: 0x1F657D0 VA: 0x181F671D0
	public void CopyTo(BaseTrain instance) { }

	// RVA: 0x1F67220 Offset: 0x1F65820 VA: 0x181F67220
	public BaseTrain Copy() { }

	// RVA: 0x1F680B0 Offset: 0x1F666B0 VA: 0x181F680B0
	public static BaseTrain Deserialize(Stream stream) { }

	// RVA: 0x1F67700 Offset: 0x1F65D00 VA: 0x181F67700
	public static BaseTrain DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F67780 Offset: 0x1F65D80 VA: 0x181F67780
	public static BaseTrain DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F67C30 Offset: 0x1F66230 VA: 0x181F67C30
	public static BaseTrain Deserialize(byte[] buffer) { }

	// RVA: 0x1F68DB0 Offset: 0x1F673B0 VA: 0x181F68DB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F69AA0 Offset: 0x1F680A0 VA: 0x181F69AA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F69AC0 Offset: 0x1F680C0 VA: 0x181F69AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseTrain previous) { }

	// RVA: 0x1F69120 Offset: 0x1F67720 VA: 0x181F69120 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F68460 Offset: 0x1F66A60 VA: 0x181F68460
	public static BaseTrain Deserialize(byte[] buffer, BaseTrain instance, bool isDelta = False) { }

	// RVA: 0x1F688C0 Offset: 0x1F66EC0 VA: 0x181F688C0
	public static BaseTrain Deserialize(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F672C0 Offset: 0x1F658C0 VA: 0x181F672C0
	public static BaseTrain DeserializeLengthDelimited(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F67810 Offset: 0x1F65E10 VA: 0x181F67810
	public static BaseTrain DeserializeLength(Stream stream, int length, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F69320 Offset: 0x1F67920 VA: 0x181F69320
	public static void SerializeDelta(Stream stream, BaseTrain instance, BaseTrain previous) { }

	// RVA: 0x1F69890 Offset: 0x1F67E90 VA: 0x181F69890
	public static void Serialize(Stream stream, BaseTrain instance) { }

	// RVA: 0x1F69A90 Offset: 0x1F68090 VA: 0x181F69A90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F69AA0 Offset: 0x1F680A0 VA: 0x181F69AA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F69780 Offset: 0x1F67D80 VA: 0x181F69780
	public static byte[] SerializeToBytes(BaseTrain instance) { }

	// RVA: 0x1F696D0 Offset: 0x1F67CD0 VA: 0x181F696D0
	public static void SerializeLengthDelimited(Stream stream, BaseTrain instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

