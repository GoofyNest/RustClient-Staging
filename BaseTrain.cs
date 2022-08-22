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

	// RVA: 0x1F69400 Offset: 0x1F67A00 VA: 0x181F69400
	public static void ResetToPool(BaseTrain instance) { }

	// RVA: 0x1F694F0 Offset: 0x1F67AF0 VA: 0x181F694F0
	public void ResetToPool() { }

	// RVA: 0x1F68EF0 Offset: 0x1F674F0 VA: 0x181F68EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F67490 Offset: 0x1F65A90 VA: 0x181F67490
	public void CopyTo(BaseTrain instance) { }

	// RVA: 0x1F674E0 Offset: 0x1F65AE0 VA: 0x181F674E0
	public BaseTrain Copy() { }

	// RVA: 0x1F68370 Offset: 0x1F66970 VA: 0x181F68370
	public static BaseTrain Deserialize(Stream stream) { }

	// RVA: 0x1F679C0 Offset: 0x1F65FC0 VA: 0x181F679C0
	public static BaseTrain DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F67A40 Offset: 0x1F66040 VA: 0x181F67A40
	public static BaseTrain DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F67EF0 Offset: 0x1F664F0 VA: 0x181F67EF0
	public static BaseTrain Deserialize(byte[] buffer) { }

	// RVA: 0x1F69070 Offset: 0x1F67670 VA: 0x181F69070
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F69D60 Offset: 0x1F68360 VA: 0x181F69D60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F69D80 Offset: 0x1F68380 VA: 0x181F69D80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseTrain previous) { }

	// RVA: 0x1F693E0 Offset: 0x1F679E0 VA: 0x181F693E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F68720 Offset: 0x1F66D20 VA: 0x181F68720
	public static BaseTrain Deserialize(byte[] buffer, BaseTrain instance, bool isDelta = False) { }

	// RVA: 0x1F68B80 Offset: 0x1F67180 VA: 0x181F68B80
	public static BaseTrain Deserialize(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F67580 Offset: 0x1F65B80 VA: 0x181F67580
	public static BaseTrain DeserializeLengthDelimited(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F67AD0 Offset: 0x1F660D0 VA: 0x181F67AD0
	public static BaseTrain DeserializeLength(Stream stream, int length, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F695E0 Offset: 0x1F67BE0 VA: 0x181F695E0
	public static void SerializeDelta(Stream stream, BaseTrain instance, BaseTrain previous) { }

	// RVA: 0x1F69B50 Offset: 0x1F68150 VA: 0x181F69B50
	public static void Serialize(Stream stream, BaseTrain instance) { }

	// RVA: 0x1F69D50 Offset: 0x1F68350 VA: 0x181F69D50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F69D60 Offset: 0x1F68360 VA: 0x181F69D60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F69A40 Offset: 0x1F68040 VA: 0x181F69A40
	public static byte[] SerializeToBytes(BaseTrain instance) { }

	// RVA: 0x1F69990 Offset: 0x1F67F90 VA: 0x181F69990
	public static void SerializeLengthDelimited(Stream stream, BaseTrain instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

