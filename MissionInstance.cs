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

	// RVA: 0x1F4C370 Offset: 0x1F4A970 VA: 0x181F4C370
	public static void ResetToPool(MissionInstance instance) { }

	// RVA: 0x1F4C360 Offset: 0x1F4A960 VA: 0x181F4C360
	public void ResetToPool() { }

	// RVA: 0x1F4C2A0 Offset: 0x1F4A8A0 VA: 0x181F4C2A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4A7D0 Offset: 0x1F48DD0 VA: 0x181F4A7D0
	public void CopyTo(MissionInstance instance) { }

	// RVA: 0x1F4AC90 Offset: 0x1F49290 VA: 0x181F4AC90
	public MissionInstance Copy() { }

	// RVA: 0x1F4BA90 Offset: 0x1F4A090 VA: 0x181F4BA90
	public static MissionInstance Deserialize(Stream stream) { }

	// RVA: 0x1F4AD10 Offset: 0x1F49310 VA: 0x181F4AD10
	public static MissionInstance DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4B3E0 Offset: 0x1F499E0 VA: 0x181F4B3E0
	public static MissionInstance DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4BC10 Offset: 0x1F4A210 VA: 0x181F4BC10
	public static MissionInstance Deserialize(byte[] buffer) { }

	// RVA: 0x1F4C320 Offset: 0x1F4A920 VA: 0x181F4C320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4D930 Offset: 0x1F4BF30 VA: 0x181F4D930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4D950 Offset: 0x1F4BF50 VA: 0x181F4D950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionInstance previous) { }

	// RVA: 0x1F4C340 Offset: 0x1F4A940 VA: 0x181F4C340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4A110 VA: 0x181F4BB10
	public static MissionInstance Deserialize(byte[] buffer, MissionInstance instance, bool isDelta = False) { }

	// RVA: 0x1F4BD30 Offset: 0x1F4A330 VA: 0x181F4BD30
	public static MissionInstance Deserialize(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4AD90 Offset: 0x1F49390 VA: 0x181F4AD90
	public static MissionInstance DeserializeLengthDelimited(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4B470 Offset: 0x1F49A70 VA: 0x181F4B470
	public static MissionInstance DeserializeLength(Stream stream, int length, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4C860 Offset: 0x1F4AE60 VA: 0x181F4C860
	public static void SerializeDelta(Stream stream, MissionInstance instance, MissionInstance previous) { }

	// RVA: 0x1F4D2A0 Offset: 0x1F4B8A0 VA: 0x181F4D2A0
	public static void Serialize(Stream stream, MissionInstance instance) { }

	// RVA: 0x1F4D920 Offset: 0x1F4BF20 VA: 0x181F4D920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4D930 Offset: 0x1F4BF30 VA: 0x181F4D930
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4D190 Offset: 0x1F4B790 VA: 0x181F4D190
	public static byte[] SerializeToBytes(MissionInstance instance) { }

	// RVA: 0x1F4D0E0 Offset: 0x1F4B6E0 VA: 0x181F4D0E0
	public static void SerializeLengthDelimited(Stream stream, MissionInstance instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

