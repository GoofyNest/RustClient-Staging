public class GenericSpawner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GenericSpawner.SpawnedEnt> ents; // 0x18

	// Methods

	// RVA: 0x1D5FED0 Offset: 0x1D5E4D0 VA: 0x181D5FED0
	public static void ResetToPool(GenericSpawner instance) { }

	// RVA: 0x1D5FD20 Offset: 0x1D5E320 VA: 0x181D5FD20
	public void ResetToPool() { }

	// RVA: 0x1D5FAA0 Offset: 0x1D5E0A0 VA: 0x181D5FAA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5EC10 Offset: 0x1D5D210 VA: 0x181D5EC10
	public void CopyTo(GenericSpawner instance) { }

	// RVA: 0x1D5EDA0 Offset: 0x1D5D3A0 VA: 0x181D5EDA0
	public GenericSpawner Copy() { }

	// RVA: 0x1D5F920 Offset: 0x1D5DF20 VA: 0x181D5F920
	public static GenericSpawner Deserialize(Stream stream) { }

	// RVA: 0x1D5F260 Offset: 0x1D5D860 VA: 0x181D5F260
	public static GenericSpawner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5F2E0 Offset: 0x1D5D8E0 VA: 0x181D5F2E0
	public static GenericSpawner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5F610 Offset: 0x1D5DC10 VA: 0x181D5F610
	public static GenericSpawner Deserialize(byte[] buffer) { }

	// RVA: 0x1D5FCE0 Offset: 0x1D5E2E0 VA: 0x181D5FCE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D60610 Offset: 0x1D5EC10 VA: 0x181D60610 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D60630 Offset: 0x1D5EC30 VA: 0x181D60630 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner previous) { }

	// RVA: 0x1D5FD00 Offset: 0x1D5E300 VA: 0x181D5FD00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5F9A0 Offset: 0x1D5DFA0 VA: 0x181D5F9A0
	public static GenericSpawner Deserialize(byte[] buffer, GenericSpawner instance, bool isDelta = False) { }

	// RVA: 0x1D5F730 Offset: 0x1D5DD30 VA: 0x181D5F730
	public static GenericSpawner Deserialize(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5EF90 Offset: 0x1D5D590 VA: 0x181D5EF90
	public static GenericSpawner DeserializeLengthDelimited(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5F370 Offset: 0x1D5D970 VA: 0x181D5F370
	public static GenericSpawner DeserializeLength(Stream stream, int length, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D60080 Offset: 0x1D5E680 VA: 0x181D60080
	public static void SerializeDelta(Stream stream, GenericSpawner instance, GenericSpawner previous) { }

	// RVA: 0x1D60420 Offset: 0x1D5EA20 VA: 0x181D60420
	public static void Serialize(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1D60600 Offset: 0x1D5EC00 VA: 0x181D60600
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D60610 Offset: 0x1D5EC10 VA: 0x181D60610
	public void ToProto(Stream stream) { }

	// RVA: 0x1D60310 Offset: 0x1D5E910 VA: 0x181D60310
	public static byte[] SerializeToBytes(GenericSpawner instance) { }

	// RVA: 0x1D60260 Offset: 0x1D5E860 VA: 0x181D60260
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1D6A8D0 Offset: 0x1D68ED0 VA: 0x181D6A8D0
	public static void ResetToPool(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A840 Offset: 0x1D68E40 VA: 0x181D6A840
	public void ResetToPool() { }

	// RVA: 0x1D6A5F0 Offset: 0x1D68BF0 VA: 0x181D6A5F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D69690 Offset: 0x1D67C90 VA: 0x181D69690
	public void CopyTo(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D696C0 Offset: 0x1D67CC0 VA: 0x181D696C0
	public GenericSpawner.SpawnedEnt Copy() { }

	// RVA: 0x1D6A400 Offset: 0x1D68A00 VA: 0x181D6A400
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream) { }

	// RVA: 0x1D69740 Offset: 0x1D67D40 VA: 0x181D69740
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D69A40 Offset: 0x1D68040 VA: 0x181D69A40
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D69D30 Offset: 0x1D68330 VA: 0x181D69D30
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer) { }

	// RVA: 0x1D6A670 Offset: 0x1D68C70 VA: 0x181D6A670
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6AE10 Offset: 0x1D69410 VA: 0x181D6AE10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6AE30 Offset: 0x1D69430 VA: 0x181D6AE30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D6A820 Offset: 0x1D68E20 VA: 0x181D6A820 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D6A180 Offset: 0x1D68780 VA: 0x181D6A180
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer, GenericSpawner.SpawnedEnt instance, bool isDelta = False) { }

	// RVA: 0x1D69FD0 Offset: 0x1D685D0 VA: 0x181D69FD0
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D697C0 Offset: 0x1D67DC0 VA: 0x181D697C0
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D69AD0 Offset: 0x1D680D0 VA: 0x181D69AD0
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D6A960 Offset: 0x1D68F60 VA: 0x181D6A960
	public static void SerializeDelta(Stream stream, GenericSpawner.SpawnedEnt instance, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D6ACE0 Offset: 0x1D692E0 VA: 0x181D6ACE0
	public static void Serialize(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6AE00 Offset: 0x1D69400 VA: 0x181D6AE00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6AE10 Offset: 0x1D69410 VA: 0x181D6AE10
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6ABD0 Offset: 0x1D691D0 VA: 0x181D6ABD0
	public static byte[] SerializeToBytes(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6AB20 Offset: 0x1D69120 VA: 0x181D6AB20
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

