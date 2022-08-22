public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6336
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint population; // 0x14

	// Methods

	// RVA: 0x1DB6B70 Offset: 0x1DB5170 VA: 0x181DB6B70
	public static void ResetToPool(Spawnable instance) { }

	// RVA: 0x1DB6BF0 Offset: 0x1DB51F0 VA: 0x181DB6BF0
	public void ResetToPool() { }

	// RVA: 0x1DB6A40 Offset: 0x1DB5040 VA: 0x181DB6A40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(Spawnable instance) { }

	// RVA: 0x1DB60C0 Offset: 0x1DB46C0 VA: 0x181DB60C0
	public Spawnable Copy() { }

	// RVA: 0x1DB6660 Offset: 0x1DB4C60 VA: 0x181DB6660
	public static Spawnable Deserialize(Stream stream) { }

	// RVA: 0x1DB6130 Offset: 0x1DB4730 VA: 0x181DB6130
	public static Spawnable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB65D0 Offset: 0x1DB4BD0 VA: 0x181DB65D0
	public static Spawnable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB6920 Offset: 0x1DB4F20 VA: 0x181DB6920
	public static Spawnable Deserialize(byte[] buffer) { }

	// RVA: 0x1DB6B30 Offset: 0x1DB5130 VA: 0x181DB6B30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB70C0 Offset: 0x1DB56C0 VA: 0x181DB70C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB7190 Offset: 0x1DB5790 VA: 0x181DB7190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spawnable previous) { }

	// RVA: 0x1DB6B50 Offset: 0x1DB5150 VA: 0x181DB6B50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB66E0 Offset: 0x1DB4CE0 VA: 0x181DB66E0
	public static Spawnable Deserialize(byte[] buffer, Spawnable instance, bool isDelta = False) { }

	// RVA: 0x1DB67E0 Offset: 0x1DB4DE0 VA: 0x181DB67E0
	public static Spawnable Deserialize(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB61B0 Offset: 0x1DB47B0 VA: 0x181DB61B0
	public static Spawnable DeserializeLengthDelimited(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB63D0 Offset: 0x1DB49D0 VA: 0x181DB63D0
	public static Spawnable DeserializeLength(Stream stream, int length, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB6C70 Offset: 0x1DB5270 VA: 0x181DB6C70
	public static void SerializeDelta(Stream stream, Spawnable instance, Spawnable previous) { }

	// RVA: 0x1DB6FE0 Offset: 0x1DB55E0 VA: 0x181DB6FE0
	public static void Serialize(Stream stream, Spawnable instance) { }

	// RVA: 0x1DB70B0 Offset: 0x1DB56B0 VA: 0x181DB70B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB70C0 Offset: 0x1DB56C0 VA: 0x181DB70C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB6E30 Offset: 0x1DB5430 VA: 0x181DB6E30
	public static byte[] SerializeToBytes(Spawnable instance) { }

	// RVA: 0x1DB6D80 Offset: 0x1DB5380 VA: 0x181DB6D80
	public static void SerializeLengthDelimited(Stream stream, Spawnable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0xA7DF40 Offset: 0xA7C540 VA: 0x180A7DF40
	protected void OnValidate() { }

	// RVA: 0xA7DF60 Offset: 0xA7C560 VA: 0x180A7DF60
	public void .ctor() { }

}

