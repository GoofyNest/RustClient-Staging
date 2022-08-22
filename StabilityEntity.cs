public class StabilityEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float stability; // 0x14
	public int distanceFromGround; // 0x18

	// Methods

	// RVA: 0x1DBFC60 Offset: 0x1DBE260 VA: 0x181DBFC60
	public static void ResetToPool(StabilityEntity instance) { }

	// RVA: 0x1DBFCE0 Offset: 0x1DBE2E0 VA: 0x181DBFCE0
	public void ResetToPool() { }

	// RVA: 0x1DBF9C0 Offset: 0x1DBDFC0 VA: 0x181DBF9C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(StabilityEntity instance) { }

	// RVA: 0x1DBEBC0 Offset: 0x1DBD1C0 VA: 0x181DBEBC0
	public StabilityEntity Copy() { }

	// RVA: 0x1DBF800 Offset: 0x1DBDE00 VA: 0x181DBF800
	public static StabilityEntity Deserialize(Stream stream) { }

	// RVA: 0x1DBEE80 Offset: 0x1DBD480 VA: 0x181DBEE80
	public static StabilityEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBEF00 Offset: 0x1DBD500 VA: 0x181DBEF00
	public static StabilityEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBF1C0 Offset: 0x1DBD7C0 VA: 0x181DBF1C0
	public static StabilityEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DBFAC0 Offset: 0x1DBE0C0 VA: 0x181DBFAC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC01A0 Offset: 0x1DBE7A0 VA: 0x181DC01A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC01C0 Offset: 0x1DBE7C0 VA: 0x181DC01C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StabilityEntity previous) { }

	// RVA: 0x1DBFC40 Offset: 0x1DBE240 VA: 0x181DBFC40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBF5B0 Offset: 0x1DBDBB0 VA: 0x181DBF5B0
	public static StabilityEntity Deserialize(byte[] buffer, StabilityEntity instance, bool isDelta = False) { }

	// RVA: 0x1DBF430 Offset: 0x1DBDA30 VA: 0x181DBF430
	public static StabilityEntity Deserialize(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBEC30 Offset: 0x1DBD230 VA: 0x181DBEC30
	public static StabilityEntity DeserializeLengthDelimited(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBEF90 Offset: 0x1DBD590 VA: 0x181DBEF90
	public static StabilityEntity DeserializeLength(Stream stream, int length, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBFD60 Offset: 0x1DBE360 VA: 0x181DBFD60
	public static void SerializeDelta(Stream stream, StabilityEntity instance, StabilityEntity previous) { }

	// RVA: 0x1DC0090 Offset: 0x1DBE690 VA: 0x181DC0090
	public static void Serialize(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1DC0190 Offset: 0x1DBE790 VA: 0x181DC0190
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC01A0 Offset: 0x1DBE7A0 VA: 0x181DC01A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBFF80 Offset: 0x1DBE580 VA: 0x181DBFF80
	public static byte[] SerializeToBytes(StabilityEntity instance) { }

	// RVA: 0x1DBFED0 Offset: 0x1DBE4D0 VA: 0x181DBFED0
	public static void SerializeLengthDelimited(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class StabilityEntity : DecayEntity // TypeDefIndex: 9683
{	// Fields
	public bool grounded; // 0x258
	public float cachedStability; // 0x25C
	public int cachedDistanceFromGround; // 0x260

	// Methods

	// RVA: 0xA8A5D0 Offset: 0xA88BD0 VA: 0x180A8A5D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA8A660 Offset: 0xA88C60 VA: 0x180A8A660 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA8A690 Offset: 0xA88C90 VA: 0x180A8A690
	public void .ctor() { }

}

