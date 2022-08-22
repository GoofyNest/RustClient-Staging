public class StabilityEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float stability; // 0x14
	public int distanceFromGround; // 0x18

	// Methods

	// RVA: 0x1DBF9A0 Offset: 0x1DBDFA0 VA: 0x181DBF9A0
	public static void ResetToPool(StabilityEntity instance) { }

	// RVA: 0x1DBFA20 Offset: 0x1DBE020 VA: 0x181DBFA20
	public void ResetToPool() { }

	// RVA: 0x1DBF700 Offset: 0x1DBDD00 VA: 0x181DBF700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(StabilityEntity instance) { }

	// RVA: 0x1DBE900 Offset: 0x1DBCF00 VA: 0x181DBE900
	public StabilityEntity Copy() { }

	// RVA: 0x1DBF540 Offset: 0x1DBDB40 VA: 0x181DBF540
	public static StabilityEntity Deserialize(Stream stream) { }

	// RVA: 0x1DBEBC0 Offset: 0x1DBD1C0 VA: 0x181DBEBC0
	public static StabilityEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBEC40 Offset: 0x1DBD240 VA: 0x181DBEC40
	public static StabilityEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBEF00 Offset: 0x1DBD500 VA: 0x181DBEF00
	public static StabilityEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DBF800 Offset: 0x1DBDE00 VA: 0x181DBF800
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBFEE0 Offset: 0x1DBE4E0 VA: 0x181DBFEE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBFF00 Offset: 0x1DBE500 VA: 0x181DBFF00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StabilityEntity previous) { }

	// RVA: 0x1DBF980 Offset: 0x1DBDF80 VA: 0x181DBF980 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBF2F0 Offset: 0x1DBD8F0 VA: 0x181DBF2F0
	public static StabilityEntity Deserialize(byte[] buffer, StabilityEntity instance, bool isDelta = False) { }

	// RVA: 0x1DBF170 Offset: 0x1DBD770 VA: 0x181DBF170
	public static StabilityEntity Deserialize(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBE970 Offset: 0x1DBCF70 VA: 0x181DBE970
	public static StabilityEntity DeserializeLengthDelimited(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBECD0 Offset: 0x1DBD2D0 VA: 0x181DBECD0
	public static StabilityEntity DeserializeLength(Stream stream, int length, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBFAA0 Offset: 0x1DBE0A0 VA: 0x181DBFAA0
	public static void SerializeDelta(Stream stream, StabilityEntity instance, StabilityEntity previous) { }

	// RVA: 0x1DBFDD0 Offset: 0x1DBE3D0 VA: 0x181DBFDD0
	public static void Serialize(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1DBFED0 Offset: 0x1DBE4D0 VA: 0x181DBFED0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBFEE0 Offset: 0x1DBE4E0 VA: 0x181DBFEE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBFCC0 Offset: 0x1DBE2C0 VA: 0x181DBFCC0
	public static byte[] SerializeToBytes(StabilityEntity instance) { }

	// RVA: 0x1DBFC10 Offset: 0x1DBE210 VA: 0x181DBFC10
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

