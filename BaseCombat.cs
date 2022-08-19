public class BaseCombat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6294
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1FFC7F0 Offset: 0x1FFADF0 VA: 0x181FFC7F0
	public static void ResetToPool(BaseCombat instance) { }

	// RVA: 0x1FFC770 Offset: 0x1FFAD70 VA: 0x181FFC770
	public void ResetToPool() { }

	// RVA: 0x1FFC4D0 Offset: 0x1FFAAD0 VA: 0x181FFC4D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(BaseCombat instance) { }

	// RVA: 0x1FFB6D0 Offset: 0x1FF9CD0 VA: 0x181FFB6D0
	public BaseCombat Copy() { }

	// RVA: 0x1FFBE50 Offset: 0x1FFA450 VA: 0x181FFBE50
	public static BaseCombat Deserialize(Stream stream) { }

	// RVA: 0x1FFB740 Offset: 0x1FF9D40 VA: 0x181FFB740
	public static BaseCombat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFBC40 Offset: 0x1FFA240 VA: 0x181FFBC40
	public static BaseCombat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFC260 Offset: 0x1FFA860 VA: 0x181FFC260
	public static BaseCombat Deserialize(byte[] buffer) { }

	// RVA: 0x1FFC5D0 Offset: 0x1FFABD0 VA: 0x181FFC5D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFCCC0 Offset: 0x1FFB2C0 VA: 0x181FFCCC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFCCE0 Offset: 0x1FFB2E0 VA: 0x181FFCCE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseCombat previous) { }

	// RVA: 0x1FFC750 Offset: 0x1FFAD50 VA: 0x181FFC750 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFC010 Offset: 0x1FFA610 VA: 0x181FFC010
	public static BaseCombat Deserialize(byte[] buffer, BaseCombat instance, bool isDelta = False) { }

	// RVA: 0x1FFBCD0 Offset: 0x1FFA2D0 VA: 0x181FFBCD0
	public static BaseCombat Deserialize(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFB7C0 Offset: 0x1FF9DC0 VA: 0x181FFB7C0
	public static BaseCombat DeserializeLengthDelimited(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFBA10 Offset: 0x1FFA010 VA: 0x181FFBA10
	public static BaseCombat DeserializeLength(Stream stream, int length, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFC870 Offset: 0x1FFAE70 VA: 0x181FFC870
	public static void SerializeDelta(Stream stream, BaseCombat instance, BaseCombat previous) { }

	// RVA: 0x1FFCBB0 Offset: 0x1FFB1B0 VA: 0x181FFCBB0
	public static void Serialize(Stream stream, BaseCombat instance) { }

	// RVA: 0x1FFCCB0 Offset: 0x1FFB2B0 VA: 0x181FFCCB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFCCC0 Offset: 0x1FFB2C0 VA: 0x181FFCCC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFCAA0 Offset: 0x1FFB0A0 VA: 0x181FFCAA0
	public static byte[] SerializeToBytes(BaseCombat instance) { }

	// RVA: 0x1FFC9F0 Offset: 0x1FFAFF0 VA: 0x181FFC9F0
	public static void SerializeLengthDelimited(Stream stream, BaseCombat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

