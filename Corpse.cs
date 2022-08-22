public class Corpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6299
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint parentID; // 0x14

	// Methods

	// RVA: 0x20B41D0 Offset: 0x20B27D0 VA: 0x1820B41D0
	public static void ResetToPool(Corpse instance) { }

	// RVA: 0x20B4150 Offset: 0x20B2750 VA: 0x1820B4150
	public void ResetToPool() { }

	// RVA: 0x20B4020 Offset: 0x20B2620 VA: 0x1820B4020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(Corpse instance) { }

	// RVA: 0x20B36A0 Offset: 0x20B1CA0 VA: 0x1820B36A0
	public Corpse Copy() { }

	// RVA: 0x20B3EA0 Offset: 0x20B24A0 VA: 0x1820B3EA0
	public static Corpse Deserialize(Stream stream) { }

	// RVA: 0x20B3930 Offset: 0x20B1F30 VA: 0x1820B3930
	public static Corpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B39B0 Offset: 0x20B1FB0 VA: 0x1820B39B0
	public static Corpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B3C40 Offset: 0x20B2240 VA: 0x1820B3C40
	public static Corpse Deserialize(byte[] buffer) { }

	// RVA: 0x20B4110 Offset: 0x20B2710 VA: 0x1820B4110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B46A0 Offset: 0x20B2CA0 VA: 0x1820B46A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B4770 Offset: 0x20B2D70 VA: 0x1820B4770 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Corpse previous) { }

	// RVA: 0x20B4130 Offset: 0x20B2730 VA: 0x1820B4130 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B3F20 Offset: 0x20B2520 VA: 0x1820B3F20
	public static Corpse Deserialize(byte[] buffer, Corpse instance, bool isDelta = False) { }

	// RVA: 0x20B3D60 Offset: 0x20B2360 VA: 0x1820B3D60
	public static Corpse Deserialize(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3710 Offset: 0x20B1D10 VA: 0x1820B3710
	public static Corpse DeserializeLengthDelimited(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20B3A40 Offset: 0x20B2040 VA: 0x1820B3A40
	public static Corpse DeserializeLength(Stream stream, int length, Corpse instance, bool isDelta) { }

	// RVA: 0x20B4250 Offset: 0x20B2850 VA: 0x1820B4250
	public static void SerializeDelta(Stream stream, Corpse instance, Corpse previous) { }

	// RVA: 0x20B45C0 Offset: 0x20B2BC0 VA: 0x1820B45C0
	public static void Serialize(Stream stream, Corpse instance) { }

	// RVA: 0x20B4690 Offset: 0x20B2C90 VA: 0x1820B4690
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B46A0 Offset: 0x20B2CA0 VA: 0x1820B46A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B4410 Offset: 0x20B2A10 VA: 0x1820B4410
	public static byte[] SerializeToBytes(Corpse instance) { }

	// RVA: 0x20B4360 Offset: 0x20B2960 VA: 0x1820B4360
	public static void SerializeLengthDelimited(Stream stream, Corpse instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

