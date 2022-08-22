public class StabilityEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float stability; // 0x14
	public int distanceFromGround; // 0x18

	// Methods

	// RVA: 0x1DC0450 Offset: 0x1DBEA50 VA: 0x181DC0450
	public static void ResetToPool(StabilityEntity instance) { }

	// RVA: 0x1DC04D0 Offset: 0x1DBEAD0 VA: 0x181DC04D0
	public void ResetToPool() { }

	// RVA: 0x1DC01B0 Offset: 0x1DBE7B0 VA: 0x181DC01B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(StabilityEntity instance) { }

	// RVA: 0x1DBF3B0 Offset: 0x1DBD9B0 VA: 0x181DBF3B0
	public StabilityEntity Copy() { }

	// RVA: 0x1DBFFF0 Offset: 0x1DBE5F0 VA: 0x181DBFFF0
	public static StabilityEntity Deserialize(Stream stream) { }

	// RVA: 0x1DBF670 Offset: 0x1DBDC70 VA: 0x181DBF670
	public static StabilityEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBF6F0 Offset: 0x1DBDCF0 VA: 0x181DBF6F0
	public static StabilityEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBF9B0 Offset: 0x1DBDFB0 VA: 0x181DBF9B0
	public static StabilityEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DC02B0 Offset: 0x1DBE8B0 VA: 0x181DC02B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC0990 Offset: 0x1DBEF90 VA: 0x181DC0990 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC09B0 Offset: 0x1DBEFB0 VA: 0x181DC09B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StabilityEntity previous) { }

	// RVA: 0x1DC0430 Offset: 0x1DBEA30 VA: 0x181DC0430 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBFDA0 Offset: 0x1DBE3A0 VA: 0x181DBFDA0
	public static StabilityEntity Deserialize(byte[] buffer, StabilityEntity instance, bool isDelta = False) { }

	// RVA: 0x1DBFC20 Offset: 0x1DBE220 VA: 0x181DBFC20
	public static StabilityEntity Deserialize(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBF420 Offset: 0x1DBDA20 VA: 0x181DBF420
	public static StabilityEntity DeserializeLengthDelimited(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBF780 Offset: 0x1DBDD80 VA: 0x181DBF780
	public static StabilityEntity DeserializeLength(Stream stream, int length, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DC0550 Offset: 0x1DBEB50 VA: 0x181DC0550
	public static void SerializeDelta(Stream stream, StabilityEntity instance, StabilityEntity previous) { }

	// RVA: 0x1DC0880 Offset: 0x1DBEE80 VA: 0x181DC0880
	public static void Serialize(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1DC0980 Offset: 0x1DBEF80 VA: 0x181DC0980
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC0990 Offset: 0x1DBEF90 VA: 0x181DC0990
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC0770 Offset: 0x1DBED70 VA: 0x181DC0770
	public static byte[] SerializeToBytes(StabilityEntity instance) { }

	// RVA: 0x1DC06C0 Offset: 0x1DBECC0 VA: 0x181DC06C0
	public static void SerializeLengthDelimited(Stream stream, StabilityEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class StabilityEntity : DecayEntity // TypeDefIndex: 9683
{	// Fields
	public bool grounded; // 0x258
	public float cachedStability; // 0x25C
	public int cachedDistanceFromGround; // 0x260

	// Methods

	// RVA: 0xA8AAA0 Offset: 0xA890A0 VA: 0x180A8AAA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA8AB30 Offset: 0xA89130 VA: 0x180A8AB30 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA8AB60 Offset: 0xA89160 VA: 0x180A8AB60
	public void .ctor() { }

}

