public class BaseCombat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6294
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1FFC630 Offset: 0x1FFAC30 VA: 0x181FFC630
	public static void ResetToPool(BaseCombat instance) { }

	// RVA: 0x1FFC5B0 Offset: 0x1FFABB0 VA: 0x181FFC5B0
	public void ResetToPool() { }

	// RVA: 0x1FFC310 Offset: 0x1FFA910 VA: 0x181FFC310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(BaseCombat instance) { }

	// RVA: 0x1FFB510 Offset: 0x1FF9B10 VA: 0x181FFB510
	public BaseCombat Copy() { }

	// RVA: 0x1FFBC90 Offset: 0x1FFA290 VA: 0x181FFBC90
	public static BaseCombat Deserialize(Stream stream) { }

	// RVA: 0x1FFB580 Offset: 0x1FF9B80 VA: 0x181FFB580
	public static BaseCombat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFBA80 Offset: 0x1FFA080 VA: 0x181FFBA80
	public static BaseCombat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFC0A0 Offset: 0x1FFA6A0 VA: 0x181FFC0A0
	public static BaseCombat Deserialize(byte[] buffer) { }

	// RVA: 0x1FFC410 Offset: 0x1FFAA10 VA: 0x181FFC410
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFCB00 Offset: 0x1FFB100 VA: 0x181FFCB00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFCB20 Offset: 0x1FFB120 VA: 0x181FFCB20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseCombat previous) { }

	// RVA: 0x1FFC590 Offset: 0x1FFAB90 VA: 0x181FFC590 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFBE50 Offset: 0x1FFA450 VA: 0x181FFBE50
	public static BaseCombat Deserialize(byte[] buffer, BaseCombat instance, bool isDelta = False) { }

	// RVA: 0x1FFBB10 Offset: 0x1FFA110 VA: 0x181FFBB10
	public static BaseCombat Deserialize(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFB600 Offset: 0x1FF9C00 VA: 0x181FFB600
	public static BaseCombat DeserializeLengthDelimited(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFB850 Offset: 0x1FF9E50 VA: 0x181FFB850
	public static BaseCombat DeserializeLength(Stream stream, int length, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFC6B0 Offset: 0x1FFACB0 VA: 0x181FFC6B0
	public static void SerializeDelta(Stream stream, BaseCombat instance, BaseCombat previous) { }

	// RVA: 0x1FFC9F0 Offset: 0x1FFAFF0 VA: 0x181FFC9F0
	public static void Serialize(Stream stream, BaseCombat instance) { }

	// RVA: 0x1FFCAF0 Offset: 0x1FFB0F0 VA: 0x181FFCAF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFCB00 Offset: 0x1FFB100 VA: 0x181FFCB00
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFC8E0 Offset: 0x1FFAEE0 VA: 0x181FFC8E0
	public static byte[] SerializeToBytes(BaseCombat instance) { }

	// RVA: 0x1FFC830 Offset: 0x1FFAE30 VA: 0x181FFC830
	public static void SerializeLengthDelimited(Stream stream, BaseCombat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

