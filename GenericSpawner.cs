public class GenericSpawner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GenericSpawner.SpawnedEnt> ents; // 0x18

	// Methods

	// RVA: 0x1D5F420 Offset: 0x1D5DA20 VA: 0x181D5F420
	public static void ResetToPool(GenericSpawner instance) { }

	// RVA: 0x1D5F270 Offset: 0x1D5D870 VA: 0x181D5F270
	public void ResetToPool() { }

	// RVA: 0x1D5EFF0 Offset: 0x1D5D5F0 VA: 0x181D5EFF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5E160 Offset: 0x1D5C760 VA: 0x181D5E160
	public void CopyTo(GenericSpawner instance) { }

	// RVA: 0x1D5E2F0 Offset: 0x1D5C8F0 VA: 0x181D5E2F0
	public GenericSpawner Copy() { }

	// RVA: 0x1D5EE70 Offset: 0x1D5D470 VA: 0x181D5EE70
	public static GenericSpawner Deserialize(Stream stream) { }

	// RVA: 0x1D5E7B0 Offset: 0x1D5CDB0 VA: 0x181D5E7B0
	public static GenericSpawner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5E830 Offset: 0x1D5CE30 VA: 0x181D5E830
	public static GenericSpawner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5EB60 Offset: 0x1D5D160 VA: 0x181D5EB60
	public static GenericSpawner Deserialize(byte[] buffer) { }

	// RVA: 0x1D5F230 Offset: 0x1D5D830 VA: 0x181D5F230
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5FB60 Offset: 0x1D5E160 VA: 0x181D5FB60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5FB80 Offset: 0x1D5E180 VA: 0x181D5FB80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner previous) { }

	// RVA: 0x1D5F250 Offset: 0x1D5D850 VA: 0x181D5F250 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5EEF0 Offset: 0x1D5D4F0 VA: 0x181D5EEF0
	public static GenericSpawner Deserialize(byte[] buffer, GenericSpawner instance, bool isDelta = False) { }

	// RVA: 0x1D5EC80 Offset: 0x1D5D280 VA: 0x181D5EC80
	public static GenericSpawner Deserialize(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5E4E0 Offset: 0x1D5CAE0 VA: 0x181D5E4E0
	public static GenericSpawner DeserializeLengthDelimited(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5E8C0 Offset: 0x1D5CEC0 VA: 0x181D5E8C0
	public static GenericSpawner DeserializeLength(Stream stream, int length, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5F5D0 Offset: 0x1D5DBD0 VA: 0x181D5F5D0
	public static void SerializeDelta(Stream stream, GenericSpawner instance, GenericSpawner previous) { }

	// RVA: 0x1D5F970 Offset: 0x1D5DF70 VA: 0x181D5F970
	public static void Serialize(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1D5FB50 Offset: 0x1D5E150 VA: 0x181D5FB50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5FB60 Offset: 0x1D5E160 VA: 0x181D5FB60
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5F860 Offset: 0x1D5DE60 VA: 0x181D5F860
	public static byte[] SerializeToBytes(GenericSpawner instance) { }

	// RVA: 0x1D5F7B0 Offset: 0x1D5DDB0 VA: 0x181D5F7B0
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class GenericSpawner.SpawnedEnt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6315
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint spawnPointIndex; // 0x18
	public bool mobile; // 0x1C

	// Methods

	// RVA: 0x1D69E20 Offset: 0x1D68420 VA: 0x181D69E20
	public static void ResetToPool(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D69D90 Offset: 0x1D68390 VA: 0x181D69D90
	public void ResetToPool() { }

	// RVA: 0x1D69B40 Offset: 0x1D68140 VA: 0x181D69B40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68BE0 Offset: 0x1D671E0 VA: 0x181D68BE0
	public void CopyTo(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D68C10 Offset: 0x1D67210 VA: 0x181D68C10
	public GenericSpawner.SpawnedEnt Copy() { }

	// RVA: 0x1D69950 Offset: 0x1D67F50 VA: 0x181D69950
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream) { }

	// RVA: 0x1D68C90 Offset: 0x1D67290 VA: 0x181D68C90
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D68F90 Offset: 0x1D67590 VA: 0x181D68F90
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D69280 Offset: 0x1D67880 VA: 0x181D69280
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer) { }

	// RVA: 0x1D69BC0 Offset: 0x1D681C0 VA: 0x181D69BC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6A360 Offset: 0x1D68960 VA: 0x181D6A360 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6A380 Offset: 0x1D68980 VA: 0x181D6A380 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D69D70 Offset: 0x1D68370 VA: 0x181D69D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D696D0 Offset: 0x1D67CD0 VA: 0x181D696D0
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer, GenericSpawner.SpawnedEnt instance, bool isDelta = False) { }

	// RVA: 0x1D69520 Offset: 0x1D67B20 VA: 0x181D69520
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D68D10 Offset: 0x1D67310 VA: 0x181D68D10
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D69020 Offset: 0x1D67620 VA: 0x181D69020
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D69EB0 Offset: 0x1D684B0 VA: 0x181D69EB0
	public static void SerializeDelta(Stream stream, GenericSpawner.SpawnedEnt instance, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D6A230 Offset: 0x1D68830 VA: 0x181D6A230
	public static void Serialize(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A350 Offset: 0x1D68950 VA: 0x181D6A350
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6A360 Offset: 0x1D68960 VA: 0x181D6A360
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6A120 Offset: 0x1D68720 VA: 0x181D6A120
	public static byte[] SerializeToBytes(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A070 Offset: 0x1D68670 VA: 0x181D6A070
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

