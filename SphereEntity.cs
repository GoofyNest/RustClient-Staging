public class SphereEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float radius; // 0x14

	// Methods

	// RVA: 0x1DB7BC0 Offset: 0x1DB61C0 VA: 0x181DB7BC0
	public static void ResetToPool(SphereEntity instance) { }

	// RVA: 0x1DB7B40 Offset: 0x1DB6140 VA: 0x181DB7B40
	public void ResetToPool() { }

	// RVA: 0x1DB7A10 Offset: 0x1DB6010 VA: 0x181DB7A10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(SphereEntity instance) { }

	// RVA: 0x1DB7080 Offset: 0x1DB5680 VA: 0x181DB7080
	public SphereEntity Copy() { }

	// RVA: 0x1DB7990 Offset: 0x1DB5F90 VA: 0x181DB7990
	public static SphereEntity Deserialize(Stream stream) { }

	// RVA: 0x1DB70F0 Offset: 0x1DB56F0 VA: 0x181DB70F0
	public static SphereEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB7590 Offset: 0x1DB5B90 VA: 0x181DB7590
	public static SphereEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB7720 Offset: 0x1DB5D20 VA: 0x181DB7720
	public static SphereEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DB7B00 Offset: 0x1DB6100 VA: 0x181DB7B00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB8010 Offset: 0x1DB6610 VA: 0x181DB8010 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB8030 Offset: 0x1DB6630 VA: 0x181DB8030 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SphereEntity previous) { }

	// RVA: 0x1DB7B20 Offset: 0x1DB6120 VA: 0x181DB7B20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB7620 Offset: 0x1DB5C20 VA: 0x181DB7620
	public static SphereEntity Deserialize(byte[] buffer, SphereEntity instance, bool isDelta = False) { }

	// RVA: 0x1DB7840 Offset: 0x1DB5E40 VA: 0x181DB7840
	public static SphereEntity Deserialize(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7170 Offset: 0x1DB5770 VA: 0x181DB7170
	public static SphereEntity DeserializeLengthDelimited(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7390 Offset: 0x1DB5990 VA: 0x181DB7390
	public static SphereEntity DeserializeLength(Stream stream, int length, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7C40 Offset: 0x1DB6240 VA: 0x181DB7C40
	public static void SerializeDelta(Stream stream, SphereEntity instance, SphereEntity previous) { }

	// RVA: 0x1DB7F20 Offset: 0x1DB6520 VA: 0x181DB7F20
	public static void Serialize(Stream stream, SphereEntity instance) { }

	// RVA: 0x1DB8000 Offset: 0x1DB6600 VA: 0x181DB8000
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB8010 Offset: 0x1DB6610 VA: 0x181DB8010
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB7E10 Offset: 0x1DB6410 VA: 0x181DB7E10
	public static byte[] SerializeToBytes(SphereEntity instance) { }

	// RVA: 0x1DB7D60 Offset: 0x1DB6360 VA: 0x181DB7D60
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

