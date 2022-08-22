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

	// RVA: 0x1F52990 Offset: 0x1F50F90 VA: 0x181F52990
	public static void ResetToPool(Missions instance) { }

	// RVA: 0x1F52B90 Offset: 0x1F51190 VA: 0x181F52B90
	public void ResetToPool() { }

	// RVA: 0x1F52600 Offset: 0x1F50C00 VA: 0x181F52600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F50C20 Offset: 0x1F4F220 VA: 0x181F50C20
	public void CopyTo(Missions instance) { }

	// RVA: 0x1F50DD0 Offset: 0x1F4F3D0 VA: 0x181F50DD0
	public Missions Copy() { }

	// RVA: 0x1F522F0 Offset: 0x1F508F0 VA: 0x181F522F0
	public static Missions Deserialize(Stream stream) { }

	// RVA: 0x1F513B0 Offset: 0x1F4F9B0 VA: 0x181F513B0
	public static Missions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F517E0 Offset: 0x1F4FDE0 VA: 0x181F517E0
	public static Missions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F51F40 Offset: 0x1F50540 VA: 0x181F51F40
	public static Missions Deserialize(byte[] buffer) { }

	// RVA: 0x1F52680 Offset: 0x1F50C80 VA: 0x181F52680
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F53550 Offset: 0x1F51B50 VA: 0x181F53550 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F53570 Offset: 0x1F51B70 VA: 0x181F53570 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Missions previous) { }

	// RVA: 0x1F52970 Offset: 0x1F50F70 VA: 0x181F52970 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F51870 Offset: 0x1F4FE70 VA: 0x181F51870
	public static Missions Deserialize(byte[] buffer, Missions instance, bool isDelta = False) { }

	// RVA: 0x1F51C40 Offset: 0x1F50240 VA: 0x181F51C40
	public static Missions Deserialize(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F50FD0 Offset: 0x1F4F5D0 VA: 0x181F50FD0
	public static Missions DeserializeLengthDelimited(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F51430 Offset: 0x1F4FA30 VA: 0x181F51430
	public static Missions DeserializeLength(Stream stream, int length, Missions instance, bool isDelta) { }

	// RVA: 0x1F52D90 Offset: 0x1F51390 VA: 0x181F52D90
	public static void SerializeDelta(Stream stream, Missions instance, Missions previous) { }

	// RVA: 0x1F532A0 Offset: 0x1F518A0 VA: 0x181F532A0
	public static void Serialize(Stream stream, Missions instance) { }

	// RVA: 0x1F53540 Offset: 0x1F51B40 VA: 0x181F53540
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F53550 Offset: 0x1F51B50 VA: 0x181F53550
	public void ToProto(Stream stream) { }

	// RVA: 0x1F53190 Offset: 0x1F51790 VA: 0x181F53190
	public static byte[] SerializeToBytes(Missions instance) { }

	// RVA: 0x1F530E0 Offset: 0x1F516E0 VA: 0x181F530E0
	public static void SerializeLengthDelimited(Stream stream, Missions instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

