public class Corpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6299
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint parentID; // 0x14

	// Methods

	// RVA: 0x20B38B0 Offset: 0x20B1EB0 VA: 0x1820B38B0
	public static void ResetToPool(Corpse instance) { }

	// RVA: 0x20B3830 Offset: 0x20B1E30 VA: 0x1820B3830
	public void ResetToPool() { }

	// RVA: 0x20B3700 Offset: 0x20B1D00 VA: 0x1820B3700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(Corpse instance) { }

	// RVA: 0x20B2D80 Offset: 0x20B1380 VA: 0x1820B2D80
	public Corpse Copy() { }

	// RVA: 0x20B3580 Offset: 0x20B1B80 VA: 0x1820B3580
	public static Corpse Deserialize(Stream stream) { }

	// RVA: 0x20B3010 Offset: 0x20B1610 VA: 0x1820B3010
	public static Corpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B3090 Offset: 0x20B1690 VA: 0x1820B3090
	public static Corpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B3320 Offset: 0x20B1920 VA: 0x1820B3320
	public static Corpse Deserialize(byte[] buffer) { }

	// RVA: 0x20B37F0 Offset: 0x20B1DF0 VA: 0x1820B37F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B3D80 Offset: 0x20B2380 VA: 0x1820B3D80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B3E50 Offset: 0x20B2450 VA: 0x1820B3E50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Corpse previous) { }

	// RVA: 0x20B3810 Offset: 0x20B1E10 VA: 0x1820B3810 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B3600 Offset: 0x20B1C00 VA: 0x1820B3600
	public static Corpse Deserialize(byte[] buffer, Corpse instance, bool isDelta = False) { }

	// RVA: 0x20B3440 Offset: 0x20B1A40 VA: 0x1820B3440
	public static Corpse Deserialize(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B2DF0 Offset: 0x20B13F0 VA: 0x1820B2DF0
	public static Corpse DeserializeLengthDelimited(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3120 Offset: 0x20B1720 VA: 0x1820B3120
	public static Corpse DeserializeLength(Stream stream, int length, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3930 Offset: 0x20B1F30 VA: 0x1820B3930
	public static void SerializeDelta(Stream stream, Corpse instance, Corpse previous) { }

	// RVA: 0x20B3CA0 Offset: 0x20B22A0 VA: 0x1820B3CA0
	public static void Serialize(Stream stream, Corpse instance) { }

	// RVA: 0x20B3D70 Offset: 0x20B2370 VA: 0x1820B3D70
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B3D80 Offset: 0x20B2380 VA: 0x1820B3D80
	public void ToProto(Stream stream) { }

	// RVA: 0x20B3AF0 Offset: 0x20B20F0 VA: 0x1820B3AF0
	public static byte[] SerializeToBytes(Corpse instance) { }

	// RVA: 0x20B3A40 Offset: 0x20B2040 VA: 0x1820B3A40
	public static void SerializeLengthDelimited(Stream stream, Corpse instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

