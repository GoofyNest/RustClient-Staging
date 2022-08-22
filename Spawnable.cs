public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6336
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint population; // 0x14

	// Methods

	// RVA: 0x1DB7360 Offset: 0x1DB5960 VA: 0x181DB7360
	public static void ResetToPool(Spawnable instance) { }

	// RVA: 0x1DB73E0 Offset: 0x1DB59E0 VA: 0x181DB73E0
	public void ResetToPool() { }

	// RVA: 0x1DB7230 Offset: 0x1DB5830 VA: 0x181DB7230 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(Spawnable instance) { }

	// RVA: 0x1DB68B0 Offset: 0x1DB4EB0 VA: 0x181DB68B0
	public Spawnable Copy() { }

	// RVA: 0x1DB6E50 Offset: 0x1DB5450 VA: 0x181DB6E50
	public static Spawnable Deserialize(Stream stream) { }

	// RVA: 0x1DB6920 Offset: 0x1DB4F20 VA: 0x181DB6920
	public static Spawnable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB6DC0 Offset: 0x1DB53C0 VA: 0x181DB6DC0
	public static Spawnable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB7110 Offset: 0x1DB5710 VA: 0x181DB7110
	public static Spawnable Deserialize(byte[] buffer) { }

	// RVA: 0x1DB7320 Offset: 0x1DB5920 VA: 0x181DB7320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB78B0 Offset: 0x1DB5EB0 VA: 0x181DB78B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB7980 Offset: 0x1DB5F80 VA: 0x181DB7980 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spawnable previous) { }

	// RVA: 0x1DB7340 Offset: 0x1DB5940 VA: 0x181DB7340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB6ED0 Offset: 0x1DB54D0 VA: 0x181DB6ED0
	public static Spawnable Deserialize(byte[] buffer, Spawnable instance, bool isDelta = False) { }

	// RVA: 0x1DB6FD0 Offset: 0x1DB55D0 VA: 0x181DB6FD0
	public static Spawnable Deserialize(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB69A0 Offset: 0x1DB4FA0 VA: 0x181DB69A0
	public static Spawnable DeserializeLengthDelimited(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB6BC0 Offset: 0x1DB51C0 VA: 0x181DB6BC0
	public static Spawnable DeserializeLength(Stream stream, int length, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB7460 Offset: 0x1DB5A60 VA: 0x181DB7460
	public static void SerializeDelta(Stream stream, Spawnable instance, Spawnable previous) { }

	// RVA: 0x1DB77D0 Offset: 0x1DB5DD0 VA: 0x181DB77D0
	public static void Serialize(Stream stream, Spawnable instance) { }

	// RVA: 0x1DB78A0 Offset: 0x1DB5EA0 VA: 0x181DB78A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB78B0 Offset: 0x1DB5EB0 VA: 0x181DB78B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB7620 Offset: 0x1DB5C20 VA: 0x181DB7620
	public static byte[] SerializeToBytes(Spawnable instance) { }

	// RVA: 0x1DB7570 Offset: 0x1DB5B70 VA: 0x181DB7570
	public static void SerializeLengthDelimited(Stream stream, Spawnable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Spawnable : MonoBehaviour, IServerComponent // TypeDefIndex: 9996
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public SpawnPopulation Population; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool ForceSpawnOnly; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string ForceSpawnInfoMessage; // 0x28

	// Methods

	// RVA: 0xA7E410 Offset: 0xA7CA10 VA: 0x180A7E410
	protected void OnValidate() { }

	// RVA: 0xA7E430 Offset: 0xA7CA30 VA: 0x180A7E430
	public void .ctor() { }

}

