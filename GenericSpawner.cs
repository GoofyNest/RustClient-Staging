public class GenericSpawner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GenericSpawner.SpawnedEnt> ents; // 0x18

	// Methods

	// RVA: 0x1D5F6E0 Offset: 0x1D5DCE0 VA: 0x181D5F6E0
	public static void ResetToPool(GenericSpawner instance) { }

	// RVA: 0x1D5F530 Offset: 0x1D5DB30 VA: 0x181D5F530
	public void ResetToPool() { }

	// RVA: 0x1D5F2B0 Offset: 0x1D5D8B0 VA: 0x181D5F2B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5E420 Offset: 0x1D5CA20 VA: 0x181D5E420
	public void CopyTo(GenericSpawner instance) { }

	// RVA: 0x1D5E5B0 Offset: 0x1D5CBB0 VA: 0x181D5E5B0
	public GenericSpawner Copy() { }

	// RVA: 0x1D5F130 Offset: 0x1D5D730 VA: 0x181D5F130
	public static GenericSpawner Deserialize(Stream stream) { }

	// RVA: 0x1D5EA70 Offset: 0x1D5D070 VA: 0x181D5EA70
	public static GenericSpawner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5EAF0 Offset: 0x1D5D0F0 VA: 0x181D5EAF0
	public static GenericSpawner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5EE20 Offset: 0x1D5D420 VA: 0x181D5EE20
	public static GenericSpawner Deserialize(byte[] buffer) { }

	// RVA: 0x1D5F4F0 Offset: 0x1D5DAF0 VA: 0x181D5F4F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5FE20 Offset: 0x1D5E420 VA: 0x181D5FE20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5FE40 Offset: 0x1D5E440 VA: 0x181D5FE40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner previous) { }

	// RVA: 0x1D5F510 Offset: 0x1D5DB10 VA: 0x181D5F510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5F1B0 Offset: 0x1D5D7B0 VA: 0x181D5F1B0
	public static GenericSpawner Deserialize(byte[] buffer, GenericSpawner instance, bool isDelta = False) { }

	// RVA: 0x1D5EF40 Offset: 0x1D5D540 VA: 0x181D5EF40
	public static GenericSpawner Deserialize(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5E7A0 Offset: 0x1D5CDA0 VA: 0x181D5E7A0
	public static GenericSpawner DeserializeLengthDelimited(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5EB80 Offset: 0x1D5D180 VA: 0x181D5EB80
	public static GenericSpawner DeserializeLength(Stream stream, int length, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5F890 Offset: 0x1D5DE90 VA: 0x181D5F890
	public static void SerializeDelta(Stream stream, GenericSpawner instance, GenericSpawner previous) { }

	// RVA: 0x1D5FC30 Offset: 0x1D5E230 VA: 0x181D5FC30
	public static void Serialize(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1D5FE10 Offset: 0x1D5E410 VA: 0x181D5FE10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5FE20 Offset: 0x1D5E420 VA: 0x181D5FE20
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5FB20 Offset: 0x1D5E120 VA: 0x181D5FB20
	public static byte[] SerializeToBytes(GenericSpawner instance) { }

	// RVA: 0x1D5FA70 Offset: 0x1D5E070 VA: 0x181D5FA70
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1D6A0E0 Offset: 0x1D686E0 VA: 0x181D6A0E0
	public static void ResetToPool(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A050 Offset: 0x1D68650 VA: 0x181D6A050
	public void ResetToPool() { }

	// RVA: 0x1D69E00 Offset: 0x1D68400 VA: 0x181D69E00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68EA0 Offset: 0x1D674A0 VA: 0x181D68EA0
	public void CopyTo(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D68ED0 Offset: 0x1D674D0 VA: 0x181D68ED0
	public GenericSpawner.SpawnedEnt Copy() { }

	// RVA: 0x1D69C10 Offset: 0x1D68210 VA: 0x181D69C10
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream) { }

	// RVA: 0x1D68F50 Offset: 0x1D67550 VA: 0x181D68F50
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D69250 Offset: 0x1D67850 VA: 0x181D69250
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D69540 Offset: 0x1D67B40 VA: 0x181D69540
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer) { }

	// RVA: 0x1D69E80 Offset: 0x1D68480 VA: 0x181D69E80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6A620 Offset: 0x1D68C20 VA: 0x181D6A620 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6A640 Offset: 0x1D68C40 VA: 0x181D6A640 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D6A030 Offset: 0x1D68630 VA: 0x181D6A030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D69990 Offset: 0x1D67F90 VA: 0x181D69990
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer, GenericSpawner.SpawnedEnt instance, bool isDelta = False) { }

	// RVA: 0x1D697E0 Offset: 0x1D67DE0 VA: 0x181D697E0
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D68FD0 Offset: 0x1D675D0 VA: 0x181D68FD0
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D692E0 Offset: 0x1D678E0 VA: 0x181D692E0
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D6A170 Offset: 0x1D68770 VA: 0x181D6A170
	public static void SerializeDelta(Stream stream, GenericSpawner.SpawnedEnt instance, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D6A4F0 Offset: 0x1D68AF0 VA: 0x181D6A4F0
	public static void Serialize(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A610 Offset: 0x1D68C10 VA: 0x181D6A610
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6A620 Offset: 0x1D68C20 VA: 0x181D6A620
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6A3E0 Offset: 0x1D689E0 VA: 0x181D6A3E0
	public static byte[] SerializeToBytes(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A330 Offset: 0x1D68930 VA: 0x181D6A330
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

