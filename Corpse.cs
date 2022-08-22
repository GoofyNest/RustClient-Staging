public class Corpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6299
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint parentID; // 0x14

	// Methods

	// RVA: 0x20B39B0 Offset: 0x20B1FB0 VA: 0x1820B39B0
	public static void ResetToPool(Corpse instance) { }

	// RVA: 0x20B3930 Offset: 0x20B1F30 VA: 0x1820B3930
	public void ResetToPool() { }

	// RVA: 0x20B3800 Offset: 0x20B1E00 VA: 0x1820B3800 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(Corpse instance) { }

	// RVA: 0x20B2E80 Offset: 0x20B1480 VA: 0x1820B2E80
	public Corpse Copy() { }

	// RVA: 0x20B3680 Offset: 0x20B1C80 VA: 0x1820B3680
	public static Corpse Deserialize(Stream stream) { }

	// RVA: 0x20B3110 Offset: 0x20B1710 VA: 0x1820B3110
	public static Corpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B3190 Offset: 0x20B1790 VA: 0x1820B3190
	public static Corpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B3420 Offset: 0x20B1A20 VA: 0x1820B3420
	public static Corpse Deserialize(byte[] buffer) { }

	// RVA: 0x20B38F0 Offset: 0x20B1EF0 VA: 0x1820B38F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B3E80 Offset: 0x20B2480 VA: 0x1820B3E80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B3F50 Offset: 0x20B2550 VA: 0x1820B3F50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Corpse previous) { }

	// RVA: 0x20B3910 Offset: 0x20B1F10 VA: 0x1820B3910 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B3700 Offset: 0x20B1D00 VA: 0x1820B3700
	public static Corpse Deserialize(byte[] buffer, Corpse instance, bool isDelta = False) { }

	// RVA: 0x20B3540 Offset: 0x20B1B40 VA: 0x1820B3540
	public static Corpse Deserialize(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B2EF0 Offset: 0x20B14F0 VA: 0x1820B2EF0
	public static Corpse DeserializeLengthDelimited(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3220 Offset: 0x20B1820 VA: 0x1820B3220
	public static Corpse DeserializeLength(Stream stream, int length, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3A30 Offset: 0x20B2030 VA: 0x1820B3A30
	public static void SerializeDelta(Stream stream, Corpse instance, Corpse previous) { }

	// RVA: 0x20B3DA0 Offset: 0x20B23A0 VA: 0x1820B3DA0
	public static void Serialize(Stream stream, Corpse instance) { }

	// RVA: 0x20B3E70 Offset: 0x20B2470 VA: 0x1820B3E70
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B3E80 Offset: 0x20B2480 VA: 0x1820B3E80
	public void ToProto(Stream stream) { }

	// RVA: 0x20B3BF0 Offset: 0x20B21F0 VA: 0x1820B3BF0
	public static byte[] SerializeToBytes(Corpse instance) { }

	// RVA: 0x20B3B40 Offset: 0x20B2140 VA: 0x1820B3B40
	public static void SerializeLengthDelimited(Stream stream, Corpse instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

