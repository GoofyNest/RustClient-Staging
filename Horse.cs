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

	// RVA: 0x1BFCB40 Offset: 0x1BFB140 VA: 0x181BFCB40
	public static void ResetToPool(Horse instance) { }

	// RVA: 0x1BFCC00 Offset: 0x1BFB200 VA: 0x181BFCC00
	public void ResetToPool() { }

	// RVA: 0x1BFC750 Offset: 0x1BFAD50 VA: 0x181BFC750 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB230 Offset: 0x1BF9830 VA: 0x181BFB230
	public void CopyTo(Horse instance) { }

	// RVA: 0x1BFB270 Offset: 0x1BF9870 VA: 0x181BFB270
	public Horse Copy() { }

	// RVA: 0x1BFBE70 Offset: 0x1BFA470 VA: 0x181BFBE70
	public static Horse Deserialize(Stream stream) { }

	// RVA: 0x1BFB300 Offset: 0x1BF9900 VA: 0x181BFB300
	public static Horse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFBA40 Offset: 0x1BFA040 VA: 0x181BFBA40
	public static Horse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFBAD0 Offset: 0x1BFA0D0 VA: 0x181BFBAD0
	public static Horse Deserialize(byte[] buffer) { }

	// RVA: 0x1BFC890 Offset: 0x1BFAE90 VA: 0x181BFC890
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFD300 Offset: 0x1BFB900 VA: 0x181BFD300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFD320 Offset: 0x1BFB920 VA: 0x181BFD320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Horse previous) { }

	// RVA: 0x1BFCB20 Offset: 0x1BFB120 VA: 0x181BFCB20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFC140 Offset: 0x1BFA740 VA: 0x181BFC140
	public static Horse Deserialize(byte[] buffer, Horse instance, bool isDelta = False) { }

	// RVA: 0x1BFC4C0 Offset: 0x1BFAAC0 VA: 0x181BFC4C0
	public static Horse Deserialize(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFB380 Offset: 0x1BF9980 VA: 0x181BFB380
	public static Horse DeserializeLengthDelimited(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFB6F0 Offset: 0x1BF9CF0 VA: 0x181BFB6F0
	public static Horse DeserializeLength(Stream stream, int length, Horse instance, bool isDelta) { }

	// RVA: 0x1BFCCC0 Offset: 0x1BFB2C0 VA: 0x181BFCCC0
	public static void SerializeDelta(Stream stream, Horse instance, Horse previous) { }

	// RVA: 0x1BFD160 Offset: 0x1BFB760 VA: 0x181BFD160
	public static void Serialize(Stream stream, Horse instance) { }

	// RVA: 0x1BFD2F0 Offset: 0x1BFB8F0 VA: 0x181BFD2F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFD300 Offset: 0x1BFB900 VA: 0x181BFD300
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFD050 Offset: 0x1BFB650 VA: 0x181BFD050
	public static byte[] SerializeToBytes(Horse instance) { }

	// RVA: 0x1BFCFA0 Offset: 0x1BFB5A0 VA: 0x181BFCFA0
	public static void SerializeLengthDelimited(Stream stream, Horse instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Horse : BaseAnimalNPC // TypeDefIndex: 8927
{	// Fields
	[ServerVar] // RVA: 0xB4270 Offset: 0xB3670 VA: 0x1800B4270
	public static float Population; // 0x2B11168

	// Properties
	public override float RealisticMass { get; }
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x742870 Offset: 0x740E70 VA: 0x180742870 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x50E1B0 Offset: 0x50C7B0 VA: 0x18050E1B0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x742840 Offset: 0x740E40 VA: 0x180742840 Slot: 122
	public override string Categorize() { }

	// RVA: 0x50E190 Offset: 0x50C790 VA: 0x18050E190
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

