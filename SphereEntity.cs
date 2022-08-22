public class SphereEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float radius; // 0x14

	// Methods

	// RVA: 0x1DB8670 Offset: 0x1DB6C70 VA: 0x181DB8670
	public static void ResetToPool(SphereEntity instance) { }

	// RVA: 0x1DB85F0 Offset: 0x1DB6BF0 VA: 0x181DB85F0
	public void ResetToPool() { }

	// RVA: 0x1DB84C0 Offset: 0x1DB6AC0 VA: 0x181DB84C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(SphereEntity instance) { }

	// RVA: 0x1DB7B30 Offset: 0x1DB6130 VA: 0x181DB7B30
	public SphereEntity Copy() { }

	// RVA: 0x1DB8440 Offset: 0x1DB6A40 VA: 0x181DB8440
	public static SphereEntity Deserialize(Stream stream) { }

	// RVA: 0x1DB7BA0 Offset: 0x1DB61A0 VA: 0x181DB7BA0
	public static SphereEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB8040 Offset: 0x1DB6640 VA: 0x181DB8040
	public static SphereEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB81D0 Offset: 0x1DB67D0 VA: 0x181DB81D0
	public static SphereEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DB85B0 Offset: 0x1DB6BB0 VA: 0x181DB85B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB8AC0 Offset: 0x1DB70C0 VA: 0x181DB8AC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB8AE0 Offset: 0x1DB70E0 VA: 0x181DB8AE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SphereEntity previous) { }

	// RVA: 0x1DB85D0 Offset: 0x1DB6BD0 VA: 0x181DB85D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB80D0 Offset: 0x1DB66D0 VA: 0x181DB80D0
	public static SphereEntity Deserialize(byte[] buffer, SphereEntity instance, bool isDelta = False) { }

	// RVA: 0x1DB82F0 Offset: 0x1DB68F0 VA: 0x181DB82F0
	public static SphereEntity Deserialize(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7C20 Offset: 0x1DB6220 VA: 0x181DB7C20
	public static SphereEntity DeserializeLengthDelimited(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB7E40 Offset: 0x1DB6440 VA: 0x181DB7E40
	public static SphereEntity DeserializeLength(Stream stream, int length, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB86F0 Offset: 0x1DB6CF0 VA: 0x181DB86F0
	public static void SerializeDelta(Stream stream, SphereEntity instance, SphereEntity previous) { }

	// RVA: 0x1DB89D0 Offset: 0x1DB6FD0 VA: 0x181DB89D0
	public static void Serialize(Stream stream, SphereEntity instance) { }

	// RVA: 0x1DB8AB0 Offset: 0x1DB70B0 VA: 0x181DB8AB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB8AC0 Offset: 0x1DB70C0 VA: 0x181DB8AC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB88C0 Offset: 0x1DB6EC0 VA: 0x181DB88C0
	public static byte[] SerializeToBytes(SphereEntity instance) { }

	// RVA: 0x1DB8810 Offset: 0x1DB6E10 VA: 0x181DB8810
	public static void SerializeLengthDelimited(Stream stream, SphereEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class SphereEntity : BaseEntity // TypeDefIndex: 9609
{	// Fields
	public float currentRadius; // 0x168
	public float lerpRadius; // 0x16C
	public float lerpSpeed; // 0x170

	// Methods

	// RVA: 0xA7F750 Offset: 0xA7DD50 VA: 0x180A7F750 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7F7C0 Offset: 0xA7DDC0 VA: 0x180A7F7C0
	protected void UpdateScale() { }

	// RVA: 0xA7F840 Offset: 0xA7DE40 VA: 0x180A7F840
	protected void Update() { }

	// RVA: 0xA7F9D0 Offset: 0xA7DFD0 VA: 0x180A7F9D0
	public void .ctor() { }

}

