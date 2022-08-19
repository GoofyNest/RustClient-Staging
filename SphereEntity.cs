public class SphereEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float radius; // 0x14

	// Methods

	// RVA: 0x1DB7D80 Offset: 0x1DB6380 VA: 0x181DB7D80
	public static void ResetToPool(SphereEntity instance) { }

	// RVA: 0x1DB7D00 Offset: 0x1DB6300 VA: 0x181DB7D00
	public void ResetToPool() { }

	// RVA: 0x1DB7BD0 Offset: 0x1DB61D0 VA: 0x181DB7BD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(SphereEntity instance) { }

	// RVA: 0x1DB7240 Offset: 0x1DB5840 VA: 0x181DB7240
	public SphereEntity Copy() { }

	// RVA: 0x1DB7B50 Offset: 0x1DB6150 VA: 0x181DB7B50
	public static SphereEntity Deserialize(Stream stream) { }

	// RVA: 0x1DB72B0 Offset: 0x1DB58B0 VA: 0x181DB72B0
	public static SphereEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB7750 Offset: 0x1DB5D50 VA: 0x181DB7750
	public static SphereEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB78E0 Offset: 0x1DB5EE0 VA: 0x181DB78E0
	public static SphereEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DB7CC0 Offset: 0x1DB62C0 VA: 0x181DB7CC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB81D0 Offset: 0x1DB67D0 VA: 0x181DB81D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB81F0 Offset: 0x1DB67F0 VA: 0x181DB81F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SphereEntity previous) { }

	// RVA: 0x1DB7CE0 Offset: 0x1DB62E0 VA: 0x181DB7CE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB77E0 Offset: 0x1DB5DE0 VA: 0x181DB77E0
	public static SphereEntity Deserialize(byte[] buffer, SphereEntity instance, bool isDelta = False) { }

	// RVA: 0x1DB7A00 Offset: 0x1DB6000 VA: 0x181DB7A00
	public static SphereEntity Deserialize(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7330 Offset: 0x1DB5930 VA: 0x181DB7330
	public static SphereEntity DeserializeLengthDelimited(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7550 Offset: 0x1DB5B50 VA: 0x181DB7550
	public static SphereEntity DeserializeLength(Stream stream, int length, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7E00 Offset: 0x1DB6400 VA: 0x181DB7E00
	public static void SerializeDelta(Stream stream, SphereEntity instance, SphereEntity previous) { }

	// RVA: 0x1DB80E0 Offset: 0x1DB66E0 VA: 0x181DB80E0
	public static void Serialize(Stream stream, SphereEntity instance) { }

	// RVA: 0x1DB81C0 Offset: 0x1DB67C0 VA: 0x181DB81C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB81D0 Offset: 0x1DB67D0 VA: 0x181DB81D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB7FD0 Offset: 0x1DB65D0 VA: 0x181DB7FD0
	public static byte[] SerializeToBytes(SphereEntity instance) { }

	// RVA: 0x1DB7F20 Offset: 0x1DB6520 VA: 0x181DB7F20
	public static void SerializeLengthDelimited(Stream stream, SphereEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class SphereEntity : BaseEntity // TypeDefIndex: 9609
{	// Fields
	public float currentRadius; // 0x168
	public float lerpRadius; // 0x16C
	public float lerpSpeed; // 0x170

	// Methods

	// RVA: 0xA7EFC0 Offset: 0xA7D5C0 VA: 0x180A7EFC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7F030 Offset: 0xA7D630 VA: 0x180A7F030
	protected void UpdateScale() { }

	// RVA: 0xA7F0B0 Offset: 0xA7D6B0 VA: 0x180A7F0B0
	protected void Update() { }

	// RVA: 0xA7F240 Offset: 0xA7D840 VA: 0x180A7F240
	public void .ctor() { }

}

