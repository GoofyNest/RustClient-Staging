public class StabilityEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float stability; // 0x14
	public int distanceFromGround; // 0x18

	// Methods

	// RVA: 0x1DBFB60 Offset: 0x1DBE160 VA: 0x181DBFB60
	public static void ResetToPool(StabilityEntity instance) { }

	// RVA: 0x1DBFBE0 Offset: 0x1DBE1E0 VA: 0x181DBFBE0
	public void ResetToPool() { }

	// RVA: 0x1DBF8C0 Offset: 0x1DBDEC0 VA: 0x181DBF8C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(StabilityEntity instance) { }

	// RVA: 0x1DBEAC0 Offset: 0x1DBD0C0 VA: 0x181DBEAC0
	public StabilityEntity Copy() { }

	// RVA: 0x1DBF700 Offset: 0x1DBDD00 VA: 0x181DBF700
	public static StabilityEntity Deserialize(Stream stream) { }

	// RVA: 0x1DBED80 Offset: 0x1DBD380 VA: 0x181DBED80
	public static StabilityEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBEE00 Offset: 0x1DBD400 VA: 0x181DBEE00
	public static StabilityEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBF0C0 Offset: 0x1DBD6C0 VA: 0x181DBF0C0
	public static StabilityEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DBF9C0 Offset: 0x1DBDFC0 VA: 0x181DBF9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC00A0 Offset: 0x1DBE6A0 VA: 0x181DC00A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC00C0 Offset: 0x1DBE6C0 VA: 0x181DC00C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StabilityEntity previous) { }

	// RVA: 0x1DBFB40 Offset: 0x1DBE140 VA: 0x181DBFB40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBF4B0 Offset: 0x1DBDAB0 VA: 0x181DBF4B0
	public static StabilityEntity Deserialize(byte[] buffer, StabilityEntity instance, bool isDelta = False) { }

	// RVA: 0x1DBF330 Offset: 0x1DBD930 VA: 0x181DBF330
	public static StabilityEntity Deserialize(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBEB30 Offset: 0x1DBD130 VA: 0x181DBEB30
	public static StabilityEntity DeserializeLengthDelimited(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBEE90 Offset: 0x1DBD490 VA: 0x181DBEE90
	public static StabilityEntity DeserializeLength(Stream stream, int length, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBFC60 Offset: 0x1DBE260 VA: 0x181DBFC60
	public static void SerializeDelta(Stream stream, StabilityEntity instance, StabilityEntity previous) { }

	// RVA: 0x1DBFF90 Offset: 0x1DBE590 VA: 0x181DBFF90
	public static void Serialize(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1DC0090 Offset: 0x1DBE690 VA: 0x181DC0090
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC00A0 Offset: 0x1DBE6A0 VA: 0x181DC00A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBFE80 Offset: 0x1DBE480 VA: 0x181DBFE80
	public static byte[] SerializeToBytes(StabilityEntity instance) { }

	// RVA: 0x1DBFDD0 Offset: 0x1DBE3D0 VA: 0x181DBFDD0
	public static void SerializeLengthDelimited(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class StabilityEntity : DecayEntity // TypeDefIndex: 9683
{	// Fields
	public bool grounded; // 0x258
	public float cachedStability; // 0x25C
	public int cachedDistanceFromGround; // 0x260

	// Methods

	// RVA: 0xA8A310 Offset: 0xA88910 VA: 0x180A8A310 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA8A3A0 Offset: 0xA889A0 VA: 0x180A8A3A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA8A3D0 Offset: 0xA889D0 VA: 0x180A8A3D0
	public void .ctor() { }

}

