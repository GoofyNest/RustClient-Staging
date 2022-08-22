public class Helicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6329
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 tiltRot; // 0x14
	public Vector3 leftGun; // 0x20
	public Vector3 rightGun; // 0x2C
	public Vector3 spotlightVec; // 0x38
	public List<float> weakspothealths; // 0x48

	// Methods

	// RVA: 0x1BFA1C0 Offset: 0x1BF87C0 VA: 0x181BFA1C0
	public static void ResetToPool(Helicopter instance) { }

	// RVA: 0x1BFA090 Offset: 0x1BF8690 VA: 0x181BFA090
	public void ResetToPool() { }

	// RVA: 0x1BF9C30 Offset: 0x1BF8230 VA: 0x181BF9C30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF8570 Offset: 0x1BF6B70 VA: 0x181BF8570
	public void CopyTo(Helicopter instance) { }

	// RVA: 0x1BF86C0 Offset: 0x1BF6CC0 VA: 0x181BF86C0
	public Helicopter Copy() { }

	// RVA: 0x1BF9380 Offset: 0x1BF7980 VA: 0x181BF9380
	public static Helicopter Deserialize(Stream stream) { }

	// RVA: 0x1BF8BE0 Offset: 0x1BF71E0 VA: 0x181BF8BE0
	public static Helicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF8C60 Offset: 0x1BF7260 VA: 0x181BF8C60
	public static Helicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF9040 Offset: 0x1BF7640 VA: 0x181BF9040
	public static Helicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1BF9DE0 Offset: 0x1BF83E0 VA: 0x181BF9DE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFB030 Offset: 0x1BF9630 VA: 0x181BFB030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFB050 Offset: 0x1BF9650 VA: 0x181BFB050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Helicopter previous) { }

	// RVA: 0x1BFA070 Offset: 0x1BF8670 VA: 0x181BFA070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF9630 Offset: 0x1BF7C30 VA: 0x181BF9630
	public static Helicopter Deserialize(byte[] buffer, Helicopter instance, bool isDelta = False) { }

	// RVA: 0x1BF9990 Offset: 0x1BF7F90 VA: 0x181BF9990
	public static Helicopter Deserialize(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF8870 Offset: 0x1BF6E70 VA: 0x181BF8870
	public static Helicopter DeserializeLengthDelimited(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF8CF0 Offset: 0x1BF72F0 VA: 0x181BF8CF0
	public static Helicopter DeserializeLength(Stream stream, int length, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BFA2F0 Offset: 0x1BF88F0 VA: 0x181BFA2F0
	public static void SerializeDelta(Stream stream, Helicopter instance, Helicopter previous) { }

	// RVA: 0x1BFAB90 Offset: 0x1BF9190 VA: 0x181BFAB90
	public static void Serialize(Stream stream, Helicopter instance) { }

	// RVA: 0x1BFB020 Offset: 0x1BF9620 VA: 0x181BFB020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFB030 Offset: 0x1BF9630 VA: 0x181BFB030
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFAA80 Offset: 0x1BF9080 VA: 0x181BFAA80
	public static byte[] SerializeToBytes(Helicopter instance) { }

	// RVA: 0x1BFA9D0 Offset: 0x1BF8FD0 VA: 0x181BFA9D0
	public static void SerializeLengthDelimited(Stream stream, Helicopter instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

