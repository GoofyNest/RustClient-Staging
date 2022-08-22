public class MissionInstance : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6453
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint providerID; // 0x14
	public uint missionID; // 0x18
	public uint missionStatus; // 0x1C
	public float completionScale; // 0x20
	public float startTime; // 0x24
	public float endTime; // 0x28
	public Vector3 missionLocation; // 0x2C
	public List<ObjectiveStatus> objectiveStatuses; // 0x38
	public List<MissionPoint> missionPoints; // 0x40
	public List<uint> createdEntities; // 0x48
	public List<MissionReward> rewards; // 0x50

	// Methods

	// RVA: 0x1F4CC90 Offset: 0x1F4B290 VA: 0x181F4CC90
	public static void ResetToPool(MissionInstance instance) { }

	// RVA: 0x1F4CC80 Offset: 0x1F4B280 VA: 0x181F4CC80
	public void ResetToPool() { }

	// RVA: 0x1F4CBC0 Offset: 0x1F4B1C0 VA: 0x181F4CBC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4B0F0 Offset: 0x1F496F0 VA: 0x181F4B0F0
	public void CopyTo(MissionInstance instance) { }

	// RVA: 0x1F4B5B0 Offset: 0x1F49BB0 VA: 0x181F4B5B0
	public MissionInstance Copy() { }

	// RVA: 0x1F4C3B0 Offset: 0x1F4A9B0 VA: 0x181F4C3B0
	public static MissionInstance Deserialize(Stream stream) { }

	// RVA: 0x1F4B630 Offset: 0x1F49C30 VA: 0x181F4B630
	public static MissionInstance DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4BD00 Offset: 0x1F4A300 VA: 0x181F4BD00
	public static MissionInstance DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4C530 Offset: 0x1F4AB30 VA: 0x181F4C530
	public static MissionInstance Deserialize(byte[] buffer) { }

	// RVA: 0x1F4CC40 Offset: 0x1F4B240 VA: 0x181F4CC40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4E250 Offset: 0x1F4C850 VA: 0x181F4E250 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4E270 Offset: 0x1F4C870 VA: 0x181F4E270 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionInstance previous) { }

	// RVA: 0x1F4CC60 Offset: 0x1F4B260 VA: 0x181F4CC60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4C430 Offset: 0x1F4AA30 VA: 0x181F4C430
	public static MissionInstance Deserialize(byte[] buffer, MissionInstance instance, bool isDelta = False) { }

	// RVA: 0x1F4C650 Offset: 0x1F4AC50 VA: 0x181F4C650
	public static MissionInstance Deserialize(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4B6B0 Offset: 0x1F49CB0 VA: 0x181F4B6B0
	public static MissionInstance DeserializeLengthDelimited(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4BD90 Offset: 0x1F4A390 VA: 0x181F4BD90
	public static MissionInstance DeserializeLength(Stream stream, int length, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4D180 Offset: 0x1F4B780 VA: 0x181F4D180
	public static void SerializeDelta(Stream stream, MissionInstance instance, MissionInstance previous) { }

	// RVA: 0x1F4DBC0 Offset: 0x1F4C1C0 VA: 0x181F4DBC0
	public static void Serialize(Stream stream, MissionInstance instance) { }

	// RVA: 0x1F4E240 Offset: 0x1F4C840 VA: 0x181F4E240
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4E250 Offset: 0x1F4C850 VA: 0x181F4E250
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4DAB0 Offset: 0x1F4C0B0 VA: 0x181F4DAB0
	public static byte[] SerializeToBytes(MissionInstance instance) { }

	// RVA: 0x1F4DA00 Offset: 0x1F4C000 VA: 0x181F4DA00
	public static void SerializeLengthDelimited(Stream stream, MissionInstance instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

