public class Horse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6366
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int runState; // 0x14
	public int numStorageSlots; // 0x18
	public int breedIndex; // 0x1C
	public float staminaSeconds; // 0x20
	public float currentMaxStaminaSeconds; // 0x24
	public float maxSpeed; // 0x28

	// Methods

	// RVA: 0x1BFD430 Offset: 0x1BFBA30 VA: 0x181BFD430
	public static void ResetToPool(Horse instance) { }

	// RVA: 0x1BFD4F0 Offset: 0x1BFBAF0 VA: 0x181BFD4F0
	public void ResetToPool() { }

	// RVA: 0x1BFD040 Offset: 0x1BFB640 VA: 0x181BFD040 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFBB20 Offset: 0x1BFA120 VA: 0x181BFBB20
	public void CopyTo(Horse instance) { }

	// RVA: 0x1BFBB60 Offset: 0x1BFA160 VA: 0x181BFBB60
	public Horse Copy() { }

	// RVA: 0x1BFC760 Offset: 0x1BFAD60 VA: 0x181BFC760
	public static Horse Deserialize(Stream stream) { }

	// RVA: 0x1BFBBF0 Offset: 0x1BFA1F0 VA: 0x181BFBBF0
	public static Horse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFC330 Offset: 0x1BFA930 VA: 0x181BFC330
	public static Horse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFC3C0 Offset: 0x1BFA9C0 VA: 0x181BFC3C0
	public static Horse Deserialize(byte[] buffer) { }

	// RVA: 0x1BFD180 Offset: 0x1BFB780 VA: 0x181BFD180
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFDBF0 Offset: 0x1BFC1F0 VA: 0x181BFDBF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFDC10 Offset: 0x1BFC210 VA: 0x181BFDC10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Horse previous) { }

	// RVA: 0x1BFD410 Offset: 0x1BFBA10 VA: 0x181BFD410 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFCA30 Offset: 0x1BFB030 VA: 0x181BFCA30
	public static Horse Deserialize(byte[] buffer, Horse instance, bool isDelta = False) { }

	// RVA: 0x1BFCDB0 Offset: 0x1BFB3B0 VA: 0x181BFCDB0
	public static Horse Deserialize(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFBC70 Offset: 0x1BFA270 VA: 0x181BFBC70
	public static Horse DeserializeLengthDelimited(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFBFE0 Offset: 0x1BFA5E0 VA: 0x181BFBFE0
	public static Horse DeserializeLength(Stream stream, int length, Horse instance, bool isDelta) { }

	// RVA: 0x1BFD5B0 Offset: 0x1BFBBB0 VA: 0x181BFD5B0
	public static void SerializeDelta(Stream stream, Horse instance, Horse previous) { }

	// RVA: 0x1BFDA50 Offset: 0x1BFC050 VA: 0x181BFDA50
	public static void Serialize(Stream stream, Horse instance) { }

	// RVA: 0x1BFDBE0 Offset: 0x1BFC1E0 VA: 0x181BFDBE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFDBF0 Offset: 0x1BFC1F0 VA: 0x181BFDBF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFD940 Offset: 0x1BFBF40 VA: 0x181BFD940
	public static byte[] SerializeToBytes(Horse instance) { }

	// RVA: 0x1BFD890 Offset: 0x1BFBE90 VA: 0x181BFD890
	public static void SerializeLengthDelimited(Stream stream, Horse instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Horse : BaseAnimalNPC // TypeDefIndex: 8927
{	// Fields
	[ServerVar] // RVA: 0xB4310 Offset: 0xB3710 VA: 0x1800B4310
	public static float Population; // 0x1B50

	// Properties
	public override float RealisticMass { get; }
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x7428D0 Offset: 0x740ED0 VA: 0x1807428D0 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x50E140 Offset: 0x50C740 VA: 0x18050E140 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x7428A0 Offset: 0x740EA0 VA: 0x1807428A0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x50E120 Offset: 0x50C720 VA: 0x18050E120
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

