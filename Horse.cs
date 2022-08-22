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

	// RVA: 0x1BFCC40 Offset: 0x1BFB240 VA: 0x181BFCC40
	public static void ResetToPool(Horse instance) { }

	// RVA: 0x1BFCD00 Offset: 0x1BFB300 VA: 0x181BFCD00
	public void ResetToPool() { }

	// RVA: 0x1BFC850 Offset: 0x1BFAE50 VA: 0x181BFC850 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB330 Offset: 0x1BF9930 VA: 0x181BFB330
	public void CopyTo(Horse instance) { }

	// RVA: 0x1BFB370 Offset: 0x1BF9970 VA: 0x181BFB370
	public Horse Copy() { }

	// RVA: 0x1BFBF70 Offset: 0x1BFA570 VA: 0x181BFBF70
	public static Horse Deserialize(Stream stream) { }

	// RVA: 0x1BFB400 Offset: 0x1BF9A00 VA: 0x181BFB400
	public static Horse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFBB40 Offset: 0x1BFA140 VA: 0x181BFBB40
	public static Horse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFBBD0 Offset: 0x1BFA1D0 VA: 0x181BFBBD0
	public static Horse Deserialize(byte[] buffer) { }

	// RVA: 0x1BFC990 Offset: 0x1BFAF90 VA: 0x181BFC990
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFD400 Offset: 0x1BFBA00 VA: 0x181BFD400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFD420 Offset: 0x1BFBA20 VA: 0x181BFD420 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Horse previous) { }

	// RVA: 0x1BFCC20 Offset: 0x1BFB220 VA: 0x181BFCC20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFC240 Offset: 0x1BFA840 VA: 0x181BFC240
	public static Horse Deserialize(byte[] buffer, Horse instance, bool isDelta = False) { }

	// RVA: 0x1BFC5C0 Offset: 0x1BFABC0 VA: 0x181BFC5C0
	public static Horse Deserialize(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFB480 Offset: 0x1BF9A80 VA: 0x181BFB480
	public static Horse DeserializeLengthDelimited(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFB7F0 Offset: 0x1BF9DF0 VA: 0x181BFB7F0
	public static Horse DeserializeLength(Stream stream, int length, Horse instance, bool isDelta) { }

	// RVA: 0x1BFCDC0 Offset: 0x1BFB3C0 VA: 0x181BFCDC0
	public static void SerializeDelta(Stream stream, Horse instance, Horse previous) { }

	// RVA: 0x1BFD260 Offset: 0x1BFB860 VA: 0x181BFD260
	public static void Serialize(Stream stream, Horse instance) { }

	// RVA: 0x1BFD3F0 Offset: 0x1BFB9F0 VA: 0x181BFD3F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFD400 Offset: 0x1BFBA00 VA: 0x181BFD400
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFD150 Offset: 0x1BFB750 VA: 0x181BFD150
	public static byte[] SerializeToBytes(Horse instance) { }

	// RVA: 0x1BFD0A0 Offset: 0x1BFB6A0 VA: 0x181BFD0A0
	public static void SerializeLengthDelimited(Stream stream, Horse instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class Horse : BaseAnimalNPC // TypeDefIndex: 8927
{	// Fields
	[ServerVar] // RVA: 0xB4310 Offset: 0xB3710 VA: 0x1800B4310
	public static float Population; // 0x2B111C8

	// Properties
	public override float RealisticMass { get; }
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x742980 Offset: 0x740F80 VA: 0x180742980 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x50E1B0 Offset: 0x50C7B0 VA: 0x18050E1B0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x742950 Offset: 0x740F50 VA: 0x180742950 Slot: 122
	public override string Categorize() { }

	// RVA: 0x50E190 Offset: 0x50C790 VA: 0x18050E190
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

