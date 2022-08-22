public class BaseCombat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6294
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1FFC8F0 Offset: 0x1FFAEF0 VA: 0x181FFC8F0
	public static void ResetToPool(BaseCombat instance) { }

	// RVA: 0x1FFC870 Offset: 0x1FFAE70 VA: 0x181FFC870
	public void ResetToPool() { }

	// RVA: 0x1FFC5D0 Offset: 0x1FFABD0 VA: 0x181FFC5D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(BaseCombat instance) { }

	// RVA: 0x1FFB7D0 Offset: 0x1FF9DD0 VA: 0x181FFB7D0
	public BaseCombat Copy() { }

	// RVA: 0x1FFBF50 Offset: 0x1FFA550 VA: 0x181FFBF50
	public static BaseCombat Deserialize(Stream stream) { }

	// RVA: 0x1FFB840 Offset: 0x1FF9E40 VA: 0x181FFB840
	public static BaseCombat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFBD40 Offset: 0x1FFA340 VA: 0x181FFBD40
	public static BaseCombat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFC360 Offset: 0x1FFA960 VA: 0x181FFC360
	public static BaseCombat Deserialize(byte[] buffer) { }

	// RVA: 0x1FFC6D0 Offset: 0x1FFACD0 VA: 0x181FFC6D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFCDC0 Offset: 0x1FFB3C0 VA: 0x181FFCDC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFCDE0 Offset: 0x1FFB3E0 VA: 0x181FFCDE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseCombat previous) { }

	// RVA: 0x1FFC850 Offset: 0x1FFAE50 VA: 0x181FFC850 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFC110 Offset: 0x1FFA710 VA: 0x181FFC110
	public static BaseCombat Deserialize(byte[] buffer, BaseCombat instance, bool isDelta = False) { }

	// RVA: 0x1FFBDD0 Offset: 0x1FFA3D0 VA: 0x181FFBDD0
	public static BaseCombat Deserialize(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFB8C0 Offset: 0x1FF9EC0 VA: 0x181FFB8C0
	public static BaseCombat DeserializeLengthDelimited(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFBB10 Offset: 0x1FFA110 VA: 0x181FFBB10
	public static BaseCombat DeserializeLength(Stream stream, int length, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFC970 Offset: 0x1FFAF70 VA: 0x181FFC970
	public static void SerializeDelta(Stream stream, BaseCombat instance, BaseCombat previous) { }

	// RVA: 0x1FFCCB0 Offset: 0x1FFB2B0 VA: 0x181FFCCB0
	public static void Serialize(Stream stream, BaseCombat instance) { }

	// RVA: 0x1FFCDB0 Offset: 0x1FFB3B0 VA: 0x181FFCDB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFCDC0 Offset: 0x1FFB3C0 VA: 0x181FFCDC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFCBA0 Offset: 0x1FFB1A0 VA: 0x181FFCBA0
	public static byte[] SerializeToBytes(BaseCombat instance) { }

	// RVA: 0x1FFCAF0 Offset: 0x1FFB0F0 VA: 0x181FFCAF0
	public static void SerializeLengthDelimited(Stream stream, BaseCombat instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

