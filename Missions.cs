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

	// RVA: 0x1F52070 Offset: 0x1F50670 VA: 0x181F52070
	public static void ResetToPool(Missions instance) { }

	// RVA: 0x1F52270 Offset: 0x1F50870 VA: 0x181F52270
	public void ResetToPool() { }

	// RVA: 0x1F51CE0 Offset: 0x1F502E0 VA: 0x181F51CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F50300 Offset: 0x1F4E900 VA: 0x181F50300
	public void CopyTo(Missions instance) { }

	// RVA: 0x1F504B0 Offset: 0x1F4EAB0 VA: 0x181F504B0
	public Missions Copy() { }

	// RVA: 0x1F519D0 Offset: 0x1F4FFD0 VA: 0x181F519D0
	public static Missions Deserialize(Stream stream) { }

	// RVA: 0x1F50A90 Offset: 0x1F4F090 VA: 0x181F50A90
	public static Missions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F50EC0 Offset: 0x1F4F4C0 VA: 0x181F50EC0
	public static Missions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F51620 Offset: 0x1F4FC20 VA: 0x181F51620
	public static Missions Deserialize(byte[] buffer) { }

	// RVA: 0x1F51D60 Offset: 0x1F50360 VA: 0x181F51D60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F52C30 Offset: 0x1F51230 VA: 0x181F52C30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F52C50 Offset: 0x1F51250 VA: 0x181F52C50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Missions previous) { }

	// RVA: 0x1F52050 Offset: 0x1F50650 VA: 0x181F52050 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F50F50 Offset: 0x1F4F550 VA: 0x181F50F50
	public static Missions Deserialize(byte[] buffer, Missions instance, bool isDelta = False) { }

	// RVA: 0x1F51320 Offset: 0x1F4F920 VA: 0x181F51320
	public static Missions Deserialize(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F506B0 Offset: 0x1F4ECB0 VA: 0x181F506B0
	public static Missions DeserializeLengthDelimited(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F50B10 Offset: 0x1F4F110 VA: 0x181F50B10
	public static Missions DeserializeLength(Stream stream, int length, Missions instance, bool isDelta) { }

	// RVA: 0x1F52470 Offset: 0x1F50A70 VA: 0x181F52470
	public static void SerializeDelta(Stream stream, Missions instance, Missions previous) { }

	// RVA: 0x1F52980 Offset: 0x1F50F80 VA: 0x181F52980
	public static void Serialize(Stream stream, Missions instance) { }

	// RVA: 0x1F52C20 Offset: 0x1F51220 VA: 0x181F52C20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F52C30 Offset: 0x1F51230 VA: 0x181F52C30
	public void ToProto(Stream stream) { }

	// RVA: 0x1F52870 Offset: 0x1F50E70 VA: 0x181F52870
	public static byte[] SerializeToBytes(Missions instance) { }

	// RVA: 0x1F527C0 Offset: 0x1F50DC0 VA: 0x181F527C0
	public static void SerializeLengthDelimited(Stream stream, Missions instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

