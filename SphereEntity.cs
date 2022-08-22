public class SphereEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float radius; // 0x14

	// Methods

	// RVA: 0x1DB7E80 Offset: 0x1DB6480 VA: 0x181DB7E80
	public static void ResetToPool(SphereEntity instance) { }

	// RVA: 0x1DB7E00 Offset: 0x1DB6400 VA: 0x181DB7E00
	public void ResetToPool() { }

	// RVA: 0x1DB7CD0 Offset: 0x1DB62D0 VA: 0x181DB7CD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(SphereEntity instance) { }

	// RVA: 0x1DB7340 Offset: 0x1DB5940 VA: 0x181DB7340
	public SphereEntity Copy() { }

	// RVA: 0x1DB7C50 Offset: 0x1DB6250 VA: 0x181DB7C50
	public static SphereEntity Deserialize(Stream stream) { }

	// RVA: 0x1DB73B0 Offset: 0x1DB59B0 VA: 0x181DB73B0
	public static SphereEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB7850 Offset: 0x1DB5E50 VA: 0x181DB7850
	public static SphereEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB79E0 Offset: 0x1DB5FE0 VA: 0x181DB79E0
	public static SphereEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DB7DC0 Offset: 0x1DB63C0 VA: 0x181DB7DC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB82D0 Offset: 0x1DB68D0 VA: 0x181DB82D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB82F0 Offset: 0x1DB68F0 VA: 0x181DB82F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SphereEntity previous) { }

	// RVA: 0x1DB7DE0 Offset: 0x1DB63E0 VA: 0x181DB7DE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB78E0 Offset: 0x1DB5EE0 VA: 0x181DB78E0
	public static SphereEntity Deserialize(byte[] buffer, SphereEntity instance, bool isDelta = False) { }

	// RVA: 0x1DB7B00 Offset: 0x1DB6100 VA: 0x181DB7B00
	public static SphereEntity Deserialize(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7430 Offset: 0x1DB5A30 VA: 0x181DB7430
	public static SphereEntity DeserializeLengthDelimited(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7650 Offset: 0x1DB5C50 VA: 0x181DB7650
	public static SphereEntity DeserializeLength(Stream stream, int length, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7F00 Offset: 0x1DB6500 VA: 0x181DB7F00
	public static void SerializeDelta(Stream stream, SphereEntity instance, SphereEntity previous) { }

	// RVA: 0x1DB81E0 Offset: 0x1DB67E0 VA: 0x181DB81E0
	public static void Serialize(Stream stream, SphereEntity instance) { }

	// RVA: 0x1DB82C0 Offset: 0x1DB68C0 VA: 0x181DB82C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB82D0 Offset: 0x1DB68D0 VA: 0x181DB82D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB80D0 Offset: 0x1DB66D0 VA: 0x181DB80D0
	public static byte[] SerializeToBytes(SphereEntity instance) { }

	// RVA: 0x1DB8020 Offset: 0x1DB6620 VA: 0x181DB8020
	public static void SerializeLengthDelimited(Stream stream, SphereEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class SphereEntity : BaseEntity // TypeDefIndex: 9609
{	// Fields
	public float currentRadius; // 0x168
	public float lerpRadius; // 0x16C
	public float lerpSpeed; // 0x170

	// Methods

	// RVA: 0xA7F280 Offset: 0xA7D880 VA: 0x180A7F280 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7F2F0 Offset: 0xA7D8F0 VA: 0x180A7F2F0
	protected void UpdateScale() { }

	// RVA: 0xA7F370 Offset: 0xA7D970 VA: 0x180A7F370
	protected void Update() { }

	// RVA: 0xA7F500 Offset: 0xA7DB00 VA: 0x180A7F500
	public void .ctor() { }

}

