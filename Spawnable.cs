public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6336
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint population; // 0x14

	// Methods

	// RVA: 0x1DB6A70 Offset: 0x1DB5070 VA: 0x181DB6A70
	public static void ResetToPool(Spawnable instance) { }

	// RVA: 0x1DB6AF0 Offset: 0x1DB50F0 VA: 0x181DB6AF0
	public void ResetToPool() { }

	// RVA: 0x1DB6940 Offset: 0x1DB4F40 VA: 0x181DB6940 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(Spawnable instance) { }

	// RVA: 0x1DB5FC0 Offset: 0x1DB45C0 VA: 0x181DB5FC0
	public Spawnable Copy() { }

	// RVA: 0x1DB6560 Offset: 0x1DB4B60 VA: 0x181DB6560
	public static Spawnable Deserialize(Stream stream) { }

	// RVA: 0x1DB6030 Offset: 0x1DB4630 VA: 0x181DB6030
	public static Spawnable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB64D0 Offset: 0x1DB4AD0 VA: 0x181DB64D0
	public static Spawnable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB6820 Offset: 0x1DB4E20 VA: 0x181DB6820
	public static Spawnable Deserialize(byte[] buffer) { }

	// RVA: 0x1DB6A30 Offset: 0x1DB5030 VA: 0x181DB6A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB6FC0 Offset: 0x1DB55C0 VA: 0x181DB6FC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB7090 Offset: 0x1DB5690 VA: 0x181DB7090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spawnable previous) { }

	// RVA: 0x1DB6A50 Offset: 0x1DB5050 VA: 0x181DB6A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB65E0 Offset: 0x1DB4BE0 VA: 0x181DB65E0
	public static Spawnable Deserialize(byte[] buffer, Spawnable instance, bool isDelta = False) { }

	// RVA: 0x1DB66E0 Offset: 0x1DB4CE0 VA: 0x181DB66E0
	public static Spawnable Deserialize(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB60B0 Offset: 0x1DB46B0 VA: 0x181DB60B0
	public static Spawnable DeserializeLengthDelimited(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB62D0 Offset: 0x1DB48D0 VA: 0x181DB62D0
	public static Spawnable DeserializeLength(Stream stream, int length, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB6B70 Offset: 0x1DB5170 VA: 0x181DB6B70
	public static void SerializeDelta(Stream stream, Spawnable instance, Spawnable previous) { }

	// RVA: 0x1DB6EE0 Offset: 0x1DB54E0 VA: 0x181DB6EE0
	public static void Serialize(Stream stream, Spawnable instance) { }

	// RVA: 0x1DB6FB0 Offset: 0x1DB55B0 VA: 0x181DB6FB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB6FC0 Offset: 0x1DB55C0 VA: 0x181DB6FC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB6D30 Offset: 0x1DB5330 VA: 0x181DB6D30
	public static byte[] SerializeToBytes(Spawnable instance) { }

	// RVA: 0x1DB6C80 Offset: 0x1DB5280 VA: 0x181DB6C80
	public static void SerializeLengthDelimited(Stream stream, Spawnable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Spawnable : MonoBehaviour, IServerComponent // TypeDefIndex: 9996
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public SpawnPopulation Population; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool ForceSpawnOnly; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string ForceSpawnInfoMessage; // 0x28

	// Methods

	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80
	protected void OnValidate() { }

	// RVA: 0xA7DCA0 Offset: 0xA7C2A0 VA: 0x180A7DCA0
	public void .ctor() { }

}

