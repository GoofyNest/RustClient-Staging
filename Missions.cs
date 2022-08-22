public class Missions : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6449
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MissionInstance> missions; // 0x18
	public int activeMission; // 0x20
	public int protocol; // 0x24
	public uint seed; // 0x28
	public int saveCreatedTime; // 0x2C

	// Methods

	// RVA: 0x1F51EB0 Offset: 0x1F504B0 VA: 0x181F51EB0
	public static void ResetToPool(Missions instance) { }

	// RVA: 0x1F520B0 Offset: 0x1F506B0 VA: 0x181F520B0
	public void ResetToPool() { }

	// RVA: 0x1F51B20 Offset: 0x1F50120 VA: 0x181F51B20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F50140 Offset: 0x1F4E740 VA: 0x181F50140
	public void CopyTo(Missions instance) { }

	// RVA: 0x1F502F0 Offset: 0x1F4E8F0 VA: 0x181F502F0
	public Missions Copy() { }

	// RVA: 0x1F51810 Offset: 0x1F4FE10 VA: 0x181F51810
	public static Missions Deserialize(Stream stream) { }

	// RVA: 0x1F508D0 Offset: 0x1F4EED0 VA: 0x181F508D0
	public static Missions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F50D00 Offset: 0x1F4F300 VA: 0x181F50D00
	public static Missions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F51460 Offset: 0x1F4FA60 VA: 0x181F51460
	public static Missions Deserialize(byte[] buffer) { }

	// RVA: 0x1F51BA0 Offset: 0x1F501A0 VA: 0x181F51BA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F52A70 Offset: 0x1F51070 VA: 0x181F52A70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F52A90 Offset: 0x1F51090 VA: 0x181F52A90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Missions previous) { }

	// RVA: 0x1F51E90 Offset: 0x1F50490 VA: 0x181F51E90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F50D90 Offset: 0x1F4F390 VA: 0x181F50D90
	public static Missions Deserialize(byte[] buffer, Missions instance, bool isDelta = False) { }

	// RVA: 0x1F51160 Offset: 0x1F4F760 VA: 0x181F51160
	public static Missions Deserialize(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F504F0 Offset: 0x1F4EAF0 VA: 0x181F504F0
	public static Missions DeserializeLengthDelimited(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F50950 Offset: 0x1F4EF50 VA: 0x181F50950
	public static Missions DeserializeLength(Stream stream, int length, Missions instance, bool isDelta) { }

	// RVA: 0x1F522B0 Offset: 0x1F508B0 VA: 0x181F522B0
	public static void SerializeDelta(Stream stream, Missions instance, Missions previous) { }

	// RVA: 0x1F527C0 Offset: 0x1F50DC0 VA: 0x181F527C0
	public static void Serialize(Stream stream, Missions instance) { }

	// RVA: 0x1F52A60 Offset: 0x1F51060 VA: 0x181F52A60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F52A70 Offset: 0x1F51070 VA: 0x181F52A70
	public void ToProto(Stream stream) { }

	// RVA: 0x1F526B0 Offset: 0x1F50CB0 VA: 0x181F526B0
	public static byte[] SerializeToBytes(Missions instance) { }

	// RVA: 0x1F52600 Offset: 0x1F50C00 VA: 0x181F52600
	public static void SerializeLengthDelimited(Stream stream, Missions instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

