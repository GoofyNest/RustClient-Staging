public class GenericSpawner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GenericSpawner.SpawnedEnt> ents; // 0x18

	// Methods

	// RVA: 0x1D5F5E0 Offset: 0x1D5DBE0 VA: 0x181D5F5E0
	public static void ResetToPool(GenericSpawner instance) { }

	// RVA: 0x1D5F430 Offset: 0x1D5DA30 VA: 0x181D5F430
	public void ResetToPool() { }

	// RVA: 0x1D5F1B0 Offset: 0x1D5D7B0 VA: 0x181D5F1B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5E320 Offset: 0x1D5C920 VA: 0x181D5E320
	public void CopyTo(GenericSpawner instance) { }

	// RVA: 0x1D5E4B0 Offset: 0x1D5CAB0 VA: 0x181D5E4B0
	public GenericSpawner Copy() { }

	// RVA: 0x1D5F030 Offset: 0x1D5D630 VA: 0x181D5F030
	public static GenericSpawner Deserialize(Stream stream) { }

	// RVA: 0x1D5E970 Offset: 0x1D5CF70 VA: 0x181D5E970
	public static GenericSpawner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5E9F0 Offset: 0x1D5CFF0 VA: 0x181D5E9F0
	public static GenericSpawner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5ED20 Offset: 0x1D5D320 VA: 0x181D5ED20
	public static GenericSpawner Deserialize(byte[] buffer) { }

	// RVA: 0x1D5F3F0 Offset: 0x1D5D9F0 VA: 0x181D5F3F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5FD20 Offset: 0x1D5E320 VA: 0x181D5FD20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5FD40 Offset: 0x1D5E340 VA: 0x181D5FD40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner previous) { }

	// RVA: 0x1D5F410 Offset: 0x1D5DA10 VA: 0x181D5F410 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5F0B0 Offset: 0x1D5D6B0 VA: 0x181D5F0B0
	public static GenericSpawner Deserialize(byte[] buffer, GenericSpawner instance, bool isDelta = False) { }

	// RVA: 0x1D5EE40 Offset: 0x1D5D440 VA: 0x181D5EE40
	public static GenericSpawner Deserialize(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5E6A0 Offset: 0x1D5CCA0 VA: 0x181D5E6A0
	public static GenericSpawner DeserializeLengthDelimited(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5EA80 Offset: 0x1D5D080 VA: 0x181D5EA80
	public static GenericSpawner DeserializeLength(Stream stream, int length, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5F790 Offset: 0x1D5DD90 VA: 0x181D5F790
	public static void SerializeDelta(Stream stream, GenericSpawner instance, GenericSpawner previous) { }

	// RVA: 0x1D5FB30 Offset: 0x1D5E130 VA: 0x181D5FB30
	public static void Serialize(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1D5FD10 Offset: 0x1D5E310 VA: 0x181D5FD10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5FD20 Offset: 0x1D5E320 VA: 0x181D5FD20
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5FA20 Offset: 0x1D5E020 VA: 0x181D5FA20
	public static byte[] SerializeToBytes(GenericSpawner instance) { }

	// RVA: 0x1D5F970 Offset: 0x1D5DF70 VA: 0x181D5F970
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

	// RVA: 0x1D69FE0 Offset: 0x1D685E0 VA: 0x181D69FE0
	public static void ResetToPool(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D69F50 Offset: 0x1D68550 VA: 0x181D69F50
	public void ResetToPool() { }

	// RVA: 0x1D69D00 Offset: 0x1D68300 VA: 0x181D69D00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68DA0 Offset: 0x1D673A0 VA: 0x181D68DA0
	public void CopyTo(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D68DD0 Offset: 0x1D673D0 VA: 0x181D68DD0
	public GenericSpawner.SpawnedEnt Copy() { }

	// RVA: 0x1D69B10 Offset: 0x1D68110 VA: 0x181D69B10
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream) { }

	// RVA: 0x1D68E50 Offset: 0x1D67450 VA: 0x181D68E50
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D69150 Offset: 0x1D67750 VA: 0x181D69150
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D69440 Offset: 0x1D67A40 VA: 0x181D69440
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer) { }

	// RVA: 0x1D69D80 Offset: 0x1D68380 VA: 0x181D69D80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D6A520 Offset: 0x1D68B20 VA: 0x181D6A520 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D6A540 Offset: 0x1D68B40 VA: 0x181D6A540 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D69F30 Offset: 0x1D68530 VA: 0x181D69F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D69890 Offset: 0x1D67E90 VA: 0x181D69890
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer, GenericSpawner.SpawnedEnt instance, bool isDelta = False) { }

	// RVA: 0x1D696E0 Offset: 0x1D67CE0 VA: 0x181D696E0
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D68ED0 Offset: 0x1D674D0 VA: 0x181D68ED0
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D691E0 Offset: 0x1D677E0 VA: 0x181D691E0
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D6A070 Offset: 0x1D68670 VA: 0x181D6A070
	public static void SerializeDelta(Stream stream, GenericSpawner.SpawnedEnt instance, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D6A3F0 Offset: 0x1D689F0 VA: 0x181D6A3F0
	public static void Serialize(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A510 Offset: 0x1D68B10 VA: 0x181D6A510
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D6A520 Offset: 0x1D68B20 VA: 0x181D6A520
	public void ToProto(Stream stream) { }

	// RVA: 0x1D6A2E0 Offset: 0x1D688E0 VA: 0x181D6A2E0
	public static byte[] SerializeToBytes(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D6A230 Offset: 0x1D68830 VA: 0x181D6A230
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

