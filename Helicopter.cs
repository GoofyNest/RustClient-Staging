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

	// RVA: 0x1BFA480 Offset: 0x1BF8A80 VA: 0x181BFA480
	public static void ResetToPool(Helicopter instance) { }

	// RVA: 0x1BFA350 Offset: 0x1BF8950 VA: 0x181BFA350
	public void ResetToPool() { }

	// RVA: 0x1BF9EF0 Offset: 0x1BF84F0 VA: 0x181BF9EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF8830 Offset: 0x1BF6E30 VA: 0x181BF8830
	public void CopyTo(Helicopter instance) { }

	// RVA: 0x1BF8980 Offset: 0x1BF6F80 VA: 0x181BF8980
	public Helicopter Copy() { }

	// RVA: 0x1BF9640 Offset: 0x1BF7C40 VA: 0x181BF9640
	public static Helicopter Deserialize(Stream stream) { }

	// RVA: 0x1BF8EA0 Offset: 0x1BF74A0 VA: 0x181BF8EA0
	public static Helicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF8F20 Offset: 0x1BF7520 VA: 0x181BF8F20
	public static Helicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF9300 Offset: 0x1BF7900 VA: 0x181BF9300
	public static Helicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1BFA0A0 Offset: 0x1BF86A0 VA: 0x181BFA0A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFB2F0 Offset: 0x1BF98F0 VA: 0x181BFB2F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFB310 Offset: 0x1BF9910 VA: 0x181BFB310 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Helicopter previous) { }

	// RVA: 0x1BFA330 Offset: 0x1BF8930 VA: 0x181BFA330 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF98F0 Offset: 0x1BF7EF0 VA: 0x181BF98F0
	public static Helicopter Deserialize(byte[] buffer, Helicopter instance, bool isDelta = False) { }

	// RVA: 0x1BF9C50 Offset: 0x1BF8250 VA: 0x181BF9C50
	public static Helicopter Deserialize(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF8B30 Offset: 0x1BF7130 VA: 0x181BF8B30
	public static Helicopter DeserializeLengthDelimited(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF8FB0 Offset: 0x1BF75B0 VA: 0x181BF8FB0
	public static Helicopter DeserializeLength(Stream stream, int length, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BFA5B0 Offset: 0x1BF8BB0 VA: 0x181BFA5B0
	public static void SerializeDelta(Stream stream, Helicopter instance, Helicopter previous) { }

	// RVA: 0x1BFAE50 Offset: 0x1BF9450 VA: 0x181BFAE50
	public static void Serialize(Stream stream, Helicopter instance) { }

	// RVA: 0x1BFB2E0 Offset: 0x1BF98E0 VA: 0x181BFB2E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFB2F0 Offset: 0x1BF98F0 VA: 0x181BFB2F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFAD40 Offset: 0x1BF9340 VA: 0x181BFAD40
	public static byte[] SerializeToBytes(Helicopter instance) { }

	// RVA: 0x1BFAC90 Offset: 0x1BF9290 VA: 0x181BFAC90
	public static void SerializeLengthDelimited(Stream stream, Helicopter instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

