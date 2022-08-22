public class Corpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6299
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint parentID; // 0x14

	// Methods

	// RVA: 0x20B36F0 Offset: 0x20B1CF0 VA: 0x1820B36F0
	public static void ResetToPool(Corpse instance) { }

	// RVA: 0x20B3670 Offset: 0x20B1C70 VA: 0x1820B3670
	public void ResetToPool() { }

	// RVA: 0x20B3540 Offset: 0x20B1B40 VA: 0x1820B3540 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(Corpse instance) { }

	// RVA: 0x20B2BC0 Offset: 0x20B11C0 VA: 0x1820B2BC0
	public Corpse Copy() { }

	// RVA: 0x20B33C0 Offset: 0x20B19C0 VA: 0x1820B33C0
	public static Corpse Deserialize(Stream stream) { }

	// RVA: 0x20B2E50 Offset: 0x20B1450 VA: 0x1820B2E50
	public static Corpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B2ED0 Offset: 0x20B14D0 VA: 0x1820B2ED0
	public static Corpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B3160 Offset: 0x20B1760 VA: 0x1820B3160
	public static Corpse Deserialize(byte[] buffer) { }

	// RVA: 0x20B3630 Offset: 0x20B1C30 VA: 0x1820B3630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B3BC0 Offset: 0x20B21C0 VA: 0x1820B3BC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B3C90 Offset: 0x20B2290 VA: 0x1820B3C90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Corpse previous) { }

	// RVA: 0x20B3650 Offset: 0x20B1C50 VA: 0x1820B3650 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B3440 Offset: 0x20B1A40 VA: 0x1820B3440
	public static Corpse Deserialize(byte[] buffer, Corpse instance, bool isDelta = False) { }

	// RVA: 0x20B3280 Offset: 0x20B1880 VA: 0x1820B3280
	public static Corpse Deserialize(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B2C30 Offset: 0x20B1230 VA: 0x1820B2C30
	public static Corpse DeserializeLengthDelimited(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B2F60 Offset: 0x20B1560 VA: 0x1820B2F60
	public static Corpse DeserializeLength(Stream stream, int length, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3770 Offset: 0x20B1D70 VA: 0x1820B3770
	public static void SerializeDelta(Stream stream, Corpse instance, Corpse previous) { }

	// RVA: 0x20B3AE0 Offset: 0x20B20E0 VA: 0x1820B3AE0
	public static void Serialize(Stream stream, Corpse instance) { }

	// RVA: 0x20B3BB0 Offset: 0x20B21B0 VA: 0x1820B3BB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B3BC0 Offset: 0x20B21C0 VA: 0x1820B3BC0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B3930 Offset: 0x20B1F30 VA: 0x1820B3930
	public static byte[] SerializeToBytes(Corpse instance) { }

	// RVA: 0x20B3880 Offset: 0x20B1E80 VA: 0x1820B3880
	public static void SerializeLengthDelimited(Stream stream, Corpse instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

