public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6336
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint population; // 0x14

	// Methods

	// RVA: 0x1DB68B0 Offset: 0x1DB4EB0 VA: 0x181DB68B0
	public static void ResetToPool(Spawnable instance) { }

	// RVA: 0x1DB6930 Offset: 0x1DB4F30 VA: 0x181DB6930
	public void ResetToPool() { }

	// RVA: 0x1DB6780 Offset: 0x1DB4D80 VA: 0x181DB6780 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(Spawnable instance) { }

	// RVA: 0x1DB5E00 Offset: 0x1DB4400 VA: 0x181DB5E00
	public Spawnable Copy() { }

	// RVA: 0x1DB63A0 Offset: 0x1DB49A0 VA: 0x181DB63A0
	public static Spawnable Deserialize(Stream stream) { }

	// RVA: 0x1DB5E70 Offset: 0x1DB4470 VA: 0x181DB5E70
	public static Spawnable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB6310 Offset: 0x1DB4910 VA: 0x181DB6310
	public static Spawnable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB6660 Offset: 0x1DB4C60 VA: 0x181DB6660
	public static Spawnable Deserialize(byte[] buffer) { }

	// RVA: 0x1DB6870 Offset: 0x1DB4E70 VA: 0x181DB6870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB6E00 Offset: 0x1DB5400 VA: 0x181DB6E00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB6ED0 Offset: 0x1DB54D0 VA: 0x181DB6ED0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spawnable previous) { }

	// RVA: 0x1DB6890 Offset: 0x1DB4E90 VA: 0x181DB6890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB6420 Offset: 0x1DB4A20 VA: 0x181DB6420
	public static Spawnable Deserialize(byte[] buffer, Spawnable instance, bool isDelta = False) { }

	// RVA: 0x1DB6520 Offset: 0x1DB4B20 VA: 0x181DB6520
	public static Spawnable Deserialize(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB5EF0 Offset: 0x1DB44F0 VA: 0x181DB5EF0
	public static Spawnable DeserializeLengthDelimited(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB6110 Offset: 0x1DB4710 VA: 0x181DB6110
	public static Spawnable DeserializeLength(Stream stream, int length, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB69B0 Offset: 0x1DB4FB0 VA: 0x181DB69B0
	public static void SerializeDelta(Stream stream, Spawnable instance, Spawnable previous) { }

	// RVA: 0x1DB6D20 Offset: 0x1DB5320 VA: 0x181DB6D20
	public static void Serialize(Stream stream, Spawnable instance) { }

	// RVA: 0x1DB6DF0 Offset: 0x1DB53F0 VA: 0x181DB6DF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB6E00 Offset: 0x1DB5400 VA: 0x181DB6E00
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB6B70 Offset: 0x1DB5170 VA: 0x181DB6B70
	public static byte[] SerializeToBytes(Spawnable instance) { }

	// RVA: 0x1DB6AC0 Offset: 0x1DB50C0 VA: 0x181DB6AC0
	public static void SerializeLengthDelimited(Stream stream, Spawnable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80
	protected void OnValidate() { }

	// RVA: 0xA7DCA0 Offset: 0xA7C2A0 VA: 0x180A7DCA0
	public void .ctor() { }

}

