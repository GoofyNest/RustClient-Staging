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

	// RVA: 0x1F4C1B0 Offset: 0x1F4A7B0 VA: 0x181F4C1B0
	public static void ResetToPool(MissionInstance instance) { }

	// RVA: 0x1F4C1A0 Offset: 0x1F4A7A0 VA: 0x181F4C1A0
	public void ResetToPool() { }

	// RVA: 0x1F4C0E0 Offset: 0x1F4A6E0 VA: 0x181F4C0E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4A610 Offset: 0x1F48C10 VA: 0x181F4A610
	public void CopyTo(MissionInstance instance) { }

	// RVA: 0x1F4AAD0 Offset: 0x1F490D0 VA: 0x181F4AAD0
	public MissionInstance Copy() { }

	// RVA: 0x1F4B8D0 Offset: 0x1F49ED0 VA: 0x181F4B8D0
	public static MissionInstance Deserialize(Stream stream) { }

	// RVA: 0x1F4AB50 Offset: 0x1F49150 VA: 0x181F4AB50
	public static MissionInstance DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4B220 Offset: 0x1F49820 VA: 0x181F4B220
	public static MissionInstance DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4BA50 Offset: 0x1F4A050 VA: 0x181F4BA50
	public static MissionInstance Deserialize(byte[] buffer) { }

	// RVA: 0x1F4C160 Offset: 0x1F4A760 VA: 0x181F4C160
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4D770 Offset: 0x1F4BD70 VA: 0x181F4D770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4D790 Offset: 0x1F4BD90 VA: 0x181F4D790 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionInstance previous) { }

	// RVA: 0x1F4C180 Offset: 0x1F4A780 VA: 0x181F4C180 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4B950 Offset: 0x1F49F50 VA: 0x181F4B950
	public static MissionInstance Deserialize(byte[] buffer, MissionInstance instance, bool isDelta = False) { }

	// RVA: 0x1F4BB70 Offset: 0x1F4A170 VA: 0x181F4BB70
	public static MissionInstance Deserialize(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4ABD0 Offset: 0x1F491D0 VA: 0x181F4ABD0
	public static MissionInstance DeserializeLengthDelimited(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4B2B0 Offset: 0x1F498B0 VA: 0x181F4B2B0
	public static MissionInstance DeserializeLength(Stream stream, int length, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4C6A0 Offset: 0x1F4ACA0 VA: 0x181F4C6A0
	public static void SerializeDelta(Stream stream, MissionInstance instance, MissionInstance previous) { }

	// RVA: 0x1F4D0E0 Offset: 0x1F4B6E0 VA: 0x181F4D0E0
	public static void Serialize(Stream stream, MissionInstance instance) { }

	// RVA: 0x1F4D760 Offset: 0x1F4BD60 VA: 0x181F4D760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4D770 Offset: 0x1F4BD70 VA: 0x181F4D770
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4CFD0 Offset: 0x1F4B5D0 VA: 0x181F4CFD0
	public static byte[] SerializeToBytes(MissionInstance instance) { }

	// RVA: 0x1F4CF20 Offset: 0x1F4B520 VA: 0x181F4CF20
	public static void SerializeLengthDelimited(Stream stream, MissionInstance instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

