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

	// RVA: 0x1BFC980 Offset: 0x1BFAF80 VA: 0x181BFC980
	public static void ResetToPool(Horse instance) { }

	// RVA: 0x1BFCA40 Offset: 0x1BFB040 VA: 0x181BFCA40
	public void ResetToPool() { }

	// RVA: 0x1BFC590 Offset: 0x1BFAB90 VA: 0x181BFC590 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB070 Offset: 0x1BF9670 VA: 0x181BFB070
	public void CopyTo(Horse instance) { }

	// RVA: 0x1BFB0B0 Offset: 0x1BF96B0 VA: 0x181BFB0B0
	public Horse Copy() { }

	// RVA: 0x1BFBCB0 Offset: 0x1BFA2B0 VA: 0x181BFBCB0
	public static Horse Deserialize(Stream stream) { }

	// RVA: 0x1BFB140 Offset: 0x1BF9740 VA: 0x181BFB140
	public static Horse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFB880 Offset: 0x1BF9E80 VA: 0x181BFB880
	public static Horse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFB910 Offset: 0x1BF9F10 VA: 0x181BFB910
	public static Horse Deserialize(byte[] buffer) { }

	// RVA: 0x1BFC6D0 Offset: 0x1BFACD0 VA: 0x181BFC6D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFD140 Offset: 0x1BFB740 VA: 0x181BFD140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFD160 Offset: 0x1BFB760 VA: 0x181BFD160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Horse previous) { }

	// RVA: 0x1BFC960 Offset: 0x1BFAF60 VA: 0x181BFC960 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFBF80 Offset: 0x1BFA580 VA: 0x181BFBF80
	public static Horse Deserialize(byte[] buffer, Horse instance, bool isDelta = False) { }

	// RVA: 0x1BFC300 Offset: 0x1BFA900 VA: 0x181BFC300
	public static Horse Deserialize(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFB1C0 Offset: 0x1BF97C0 VA: 0x181BFB1C0
	public static Horse DeserializeLengthDelimited(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BFB530 Offset: 0x1BF9B30 VA: 0x181BFB530
	public static Horse DeserializeLength(Stream stream, int length, Horse instance, bool isDelta) { }

	// RVA: 0x1BFCB00 Offset: 0x1BFB100 VA: 0x181BFCB00
	public static void SerializeDelta(Stream stream, Horse instance, Horse previous) { }

	// RVA: 0x1BFCFA0 Offset: 0x1BFB5A0 VA: 0x181BFCFA0
	public static void Serialize(Stream stream, Horse instance) { }

	// RVA: 0x1BFD130 Offset: 0x1BFB730 VA: 0x181BFD130
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFD140 Offset: 0x1BFB740 VA: 0x181BFD140
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFCE90 Offset: 0x1BFB490 VA: 0x181BFCE90
	public static byte[] SerializeToBytes(Horse instance) { }

	// RVA: 0x1BFCDE0 Offset: 0x1BFB3E0 VA: 0x181BFCDE0
	public static void SerializeLengthDelimited(Stream stream, Horse instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Horse : BaseAnimalNPC // TypeDefIndex: 8927
{	// Fields
	[ServerVar] // RVA: 0xB4310 Offset: 0xB3710 VA: 0x1800B4310
	public static float Population; // 0x2B10188

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

