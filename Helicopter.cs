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

	// RVA: 0x1BFAC70 Offset: 0x1BF9270 VA: 0x181BFAC70
	public static void ResetToPool(Helicopter instance) { }

	// RVA: 0x1BFAB40 Offset: 0x1BF9140 VA: 0x181BFAB40
	public void ResetToPool() { }

	// RVA: 0x1BFA6E0 Offset: 0x1BF8CE0 VA: 0x181BFA6E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9020 Offset: 0x1BF7620 VA: 0x181BF9020
	public void CopyTo(Helicopter instance) { }

	// RVA: 0x1BF9170 Offset: 0x1BF7770 VA: 0x181BF9170
	public Helicopter Copy() { }

	// RVA: 0x1BF9E30 Offset: 0x1BF8430 VA: 0x181BF9E30
	public static Helicopter Deserialize(Stream stream) { }

	// RVA: 0x1BF9690 Offset: 0x1BF7C90 VA: 0x181BF9690
	public static Helicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF9710 Offset: 0x1BF7D10 VA: 0x181BF9710
	public static Helicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF9AF0 Offset: 0x1BF80F0 VA: 0x181BF9AF0
	public static Helicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1BFA890 Offset: 0x1BF8E90 VA: 0x181BFA890
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFBAE0 Offset: 0x1BFA0E0 VA: 0x181BFBAE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFBB00 Offset: 0x1BFA100 VA: 0x181BFBB00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Helicopter previous) { }

	// RVA: 0x1BFAB20 Offset: 0x1BF9120 VA: 0x181BFAB20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFA0E0 Offset: 0x1BF86E0 VA: 0x181BFA0E0
	public static Helicopter Deserialize(byte[] buffer, Helicopter instance, bool isDelta = False) { }

	// RVA: 0x1BFA440 Offset: 0x1BF8A40 VA: 0x181BFA440
	public static Helicopter Deserialize(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF9320 Offset: 0x1BF7920 VA: 0x181BF9320
	public static Helicopter DeserializeLengthDelimited(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF97A0 Offset: 0x1BF7DA0 VA: 0x181BF97A0
	public static Helicopter DeserializeLength(Stream stream, int length, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BFADA0 Offset: 0x1BF93A0 VA: 0x181BFADA0
	public static void SerializeDelta(Stream stream, Helicopter instance, Helicopter previous) { }

	// RVA: 0x1BFB640 Offset: 0x1BF9C40 VA: 0x181BFB640
	public static void Serialize(Stream stream, Helicopter instance) { }

	// RVA: 0x1BFBAD0 Offset: 0x1BFA0D0 VA: 0x181BFBAD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFBAE0 Offset: 0x1BFA0E0 VA: 0x181BFBAE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFB530 Offset: 0x1BF9B30 VA: 0x181BFB530
	public static byte[] SerializeToBytes(Helicopter instance) { }

	// RVA: 0x1BFB480 Offset: 0x1BF9A80 VA: 0x181BFB480
	public static void SerializeLengthDelimited(Stream stream, Helicopter instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

