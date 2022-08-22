public class BaseCombat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6294
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1FFD110 Offset: 0x1FFB710 VA: 0x181FFD110
	public static void ResetToPool(BaseCombat instance) { }

	// RVA: 0x1FFD090 Offset: 0x1FFB690 VA: 0x181FFD090
	public void ResetToPool() { }

	// RVA: 0x1FFCDF0 Offset: 0x1FFB3F0 VA: 0x181FFCDF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(BaseCombat instance) { }

	// RVA: 0x1FFBFF0 Offset: 0x1FFA5F0 VA: 0x181FFBFF0
	public BaseCombat Copy() { }

	// RVA: 0x1FFC770 Offset: 0x1FFAD70 VA: 0x181FFC770
	public static BaseCombat Deserialize(Stream stream) { }

	// RVA: 0x1FFC060 Offset: 0x1FFA660 VA: 0x181FFC060
	public static BaseCombat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFC560 Offset: 0x1FFAB60 VA: 0x181FFC560
	public static BaseCombat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFCB80 Offset: 0x1FFB180 VA: 0x181FFCB80
	public static BaseCombat Deserialize(byte[] buffer) { }

	// RVA: 0x1FFCEF0 Offset: 0x1FFB4F0 VA: 0x181FFCEF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFD5E0 Offset: 0x1FFBBE0 VA: 0x181FFD5E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFD600 Offset: 0x1FFBC00 VA: 0x181FFD600 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseCombat previous) { }

	// RVA: 0x1FFD070 Offset: 0x1FFB670 VA: 0x181FFD070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFC930 Offset: 0x1FFAF30 VA: 0x181FFC930
	public static BaseCombat Deserialize(byte[] buffer, BaseCombat instance, bool isDelta = False) { }

	// RVA: 0x1FFC5F0 Offset: 0x1FFABF0 VA: 0x181FFC5F0
	public static BaseCombat Deserialize(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFC0E0 Offset: 0x1FFA6E0 VA: 0x181FFC0E0
	public static BaseCombat DeserializeLengthDelimited(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFC330 Offset: 0x1FFA930 VA: 0x181FFC330
	public static BaseCombat DeserializeLength(Stream stream, int length, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FFD190 Offset: 0x1FFB790 VA: 0x181FFD190
	public static void SerializeDelta(Stream stream, BaseCombat instance, BaseCombat previous) { }

	// RVA: 0x1FFD4D0 Offset: 0x1FFBAD0 VA: 0x181FFD4D0
	public static void Serialize(Stream stream, BaseCombat instance) { }

	// RVA: 0x1FFD5D0 Offset: 0x1FFBBD0 VA: 0x181FFD5D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFD5E0 Offset: 0x1FFBBE0 VA: 0x181FFD5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFD3C0 Offset: 0x1FFB9C0 VA: 0x181FFD3C0
	public static byte[] SerializeToBytes(BaseCombat instance) { }

	// RVA: 0x1FFD310 Offset: 0x1FFB910 VA: 0x181FFD310
	public static void SerializeLengthDelimited(Stream stream, BaseCombat instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

