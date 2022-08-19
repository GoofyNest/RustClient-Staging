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

	// RVA: 0x1BFA380 Offset: 0x1BF8980 VA: 0x181BFA380
	public static void ResetToPool(Helicopter instance) { }

	// RVA: 0x1BFA250 Offset: 0x1BF8850 VA: 0x181BFA250
	public void ResetToPool() { }

	// RVA: 0x1BF9DF0 Offset: 0x1BF83F0 VA: 0x181BF9DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF8730 Offset: 0x1BF6D30 VA: 0x181BF8730
	public void CopyTo(Helicopter instance) { }

	// RVA: 0x1BF8880 Offset: 0x1BF6E80 VA: 0x181BF8880
	public Helicopter Copy() { }

	// RVA: 0x1BF9540 Offset: 0x1BF7B40 VA: 0x181BF9540
	public static Helicopter Deserialize(Stream stream) { }

	// RVA: 0x1BF8DA0 Offset: 0x1BF73A0 VA: 0x181BF8DA0
	public static Helicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF8E20 Offset: 0x1BF7420 VA: 0x181BF8E20
	public static Helicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF9200 Offset: 0x1BF7800 VA: 0x181BF9200
	public static Helicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1BF9FA0 Offset: 0x1BF85A0 VA: 0x181BF9FA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFB1F0 Offset: 0x1BF97F0 VA: 0x181BFB1F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFB210 Offset: 0x1BF9810 VA: 0x181BFB210 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Helicopter previous) { }

	// RVA: 0x1BFA230 Offset: 0x1BF8830 VA: 0x181BFA230 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF97F0 Offset: 0x1BF7DF0 VA: 0x181BF97F0
	public static Helicopter Deserialize(byte[] buffer, Helicopter instance, bool isDelta = False) { }

	// RVA: 0x1BF9B50 Offset: 0x1BF8150 VA: 0x181BF9B50
	public static Helicopter Deserialize(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF8A30 Offset: 0x1BF7030 VA: 0x181BF8A30
	public static Helicopter DeserializeLengthDelimited(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF8EB0 Offset: 0x1BF74B0 VA: 0x181BF8EB0
	public static Helicopter DeserializeLength(Stream stream, int length, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BFA4B0 Offset: 0x1BF8AB0 VA: 0x181BFA4B0
	public static void SerializeDelta(Stream stream, Helicopter instance, Helicopter previous) { }

	// RVA: 0x1BFAD50 Offset: 0x1BF9350 VA: 0x181BFAD50
	public static void Serialize(Stream stream, Helicopter instance) { }

	// RVA: 0x1BFB1E0 Offset: 0x1BF97E0 VA: 0x181BFB1E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFB1F0 Offset: 0x1BF97F0 VA: 0x181BFB1F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFAC40 Offset: 0x1BF9240 VA: 0x181BFAC40
	public static byte[] SerializeToBytes(Helicopter instance) { }

	// RVA: 0x1BFAB90 Offset: 0x1BF9190 VA: 0x181BFAB90
	public static void SerializeLengthDelimited(Stream stream, Helicopter instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

