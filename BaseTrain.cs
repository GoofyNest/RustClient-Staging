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

	// RVA: 0x1F69C20 Offset: 0x1F68220 VA: 0x181F69C20
	public static void ResetToPool(BaseTrain instance) { }

	// RVA: 0x1F69D10 Offset: 0x1F68310 VA: 0x181F69D10
	public void ResetToPool() { }

	// RVA: 0x1F69710 Offset: 0x1F67D10 VA: 0x181F69710 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F67CB0 Offset: 0x1F662B0 VA: 0x181F67CB0
	public void CopyTo(BaseTrain instance) { }

	// RVA: 0x1F67D00 Offset: 0x1F66300 VA: 0x181F67D00
	public BaseTrain Copy() { }

	// RVA: 0x1F68B90 Offset: 0x1F67190 VA: 0x181F68B90
	public static BaseTrain Deserialize(Stream stream) { }

	// RVA: 0x1F681E0 Offset: 0x1F667E0 VA: 0x181F681E0
	public static BaseTrain DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F68260 Offset: 0x1F66860 VA: 0x181F68260
	public static BaseTrain DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F68710 Offset: 0x1F66D10 VA: 0x181F68710
	public static BaseTrain Deserialize(byte[] buffer) { }

	// RVA: 0x1F69890 Offset: 0x1F67E90 VA: 0x181F69890
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6A580 Offset: 0x1F68B80 VA: 0x181F6A580 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6A5A0 Offset: 0x1F68BA0 VA: 0x181F6A5A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseTrain previous) { }

	// RVA: 0x1F69C00 Offset: 0x1F68200 VA: 0x181F69C00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F68F40 Offset: 0x1F67540 VA: 0x181F68F40
	public static BaseTrain Deserialize(byte[] buffer, BaseTrain instance, bool isDelta = False) { }

	// RVA: 0x1F693A0 Offset: 0x1F679A0 VA: 0x181F693A0
	public static BaseTrain Deserialize(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F67DA0 Offset: 0x1F663A0 VA: 0x181F67DA0
	public static BaseTrain DeserializeLengthDelimited(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F682F0 Offset: 0x1F668F0 VA: 0x181F682F0
	public static BaseTrain DeserializeLength(Stream stream, int length, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F69E00 Offset: 0x1F68400 VA: 0x181F69E00
	public static void SerializeDelta(Stream stream, BaseTrain instance, BaseTrain previous) { }

	// RVA: 0x1F6A370 Offset: 0x1F68970 VA: 0x181F6A370
	public static void Serialize(Stream stream, BaseTrain instance) { }

	// RVA: 0x1F6A570 Offset: 0x1F68B70 VA: 0x181F6A570
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6A580 Offset: 0x1F68B80 VA: 0x181F6A580
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6A260 Offset: 0x1F68860 VA: 0x181F6A260
	public static byte[] SerializeToBytes(BaseTrain instance) { }

	// RVA: 0x1F6A1B0 Offset: 0x1F687B0 VA: 0x181F6A1B0
	public static void SerializeLengthDelimited(Stream stream, BaseTrain instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

