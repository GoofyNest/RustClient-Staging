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

	// RVA: 0x1F52170 Offset: 0x1F50770 VA: 0x181F52170
	public static void ResetToPool(Missions instance) { }

	// RVA: 0x1F52370 Offset: 0x1F50970 VA: 0x181F52370
	public void ResetToPool() { }

	// RVA: 0x1F51DE0 Offset: 0x1F503E0 VA: 0x181F51DE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F50400 Offset: 0x1F4EA00 VA: 0x181F50400
	public void CopyTo(Missions instance) { }

	// RVA: 0x1F505B0 Offset: 0x1F4EBB0 VA: 0x181F505B0
	public Missions Copy() { }

	// RVA: 0x1F51AD0 Offset: 0x1F500D0 VA: 0x181F51AD0
	public static Missions Deserialize(Stream stream) { }

	// RVA: 0x1F50B90 Offset: 0x1F4F190 VA: 0x181F50B90
	public static Missions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F50FC0 Offset: 0x1F4F5C0 VA: 0x181F50FC0
	public static Missions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F51720 Offset: 0x1F4FD20 VA: 0x181F51720
	public static Missions Deserialize(byte[] buffer) { }

	// RVA: 0x1F51E60 Offset: 0x1F50460 VA: 0x181F51E60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F52D30 Offset: 0x1F51330 VA: 0x181F52D30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F52D50 Offset: 0x1F51350 VA: 0x181F52D50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Missions previous) { }

	// RVA: 0x1F52150 Offset: 0x1F50750 VA: 0x181F52150 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F51050 Offset: 0x1F4F650 VA: 0x181F51050
	public static Missions Deserialize(byte[] buffer, Missions instance, bool isDelta = False) { }

	// RVA: 0x1F51420 Offset: 0x1F4FA20 VA: 0x181F51420
	public static Missions Deserialize(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F507B0 Offset: 0x1F4EDB0 VA: 0x181F507B0
	public static Missions DeserializeLengthDelimited(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F50C10 Offset: 0x1F4F210 VA: 0x181F50C10
	public static Missions DeserializeLength(Stream stream, int length, Missions instance, bool isDelta) { }

	// RVA: 0x1F52570 Offset: 0x1F50B70 VA: 0x181F52570
	public static void SerializeDelta(Stream stream, Missions instance, Missions previous) { }

	// RVA: 0x1F52A80 Offset: 0x1F51080 VA: 0x181F52A80
	public static void Serialize(Stream stream, Missions instance) { }

	// RVA: 0x1F52D20 Offset: 0x1F51320 VA: 0x181F52D20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F52D30 Offset: 0x1F51330 VA: 0x181F52D30
	public void ToProto(Stream stream) { }

	// RVA: 0x1F52970 Offset: 0x1F50F70 VA: 0x181F52970
	public static byte[] SerializeToBytes(Missions instance) { }

	// RVA: 0x1F528C0 Offset: 0x1F50EC0 VA: 0x181F528C0
	public static void SerializeLengthDelimited(Stream stream, Missions instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

