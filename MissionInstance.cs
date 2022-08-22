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

	// RVA: 0x1F4C470 Offset: 0x1F4AA70 VA: 0x181F4C470
	public static void ResetToPool(MissionInstance instance) { }

	// RVA: 0x1F4C460 Offset: 0x1F4AA60 VA: 0x181F4C460
	public void ResetToPool() { }

	// RVA: 0x1F4C3A0 Offset: 0x1F4A9A0 VA: 0x181F4C3A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4A8D0 Offset: 0x1F48ED0 VA: 0x181F4A8D0
	public void CopyTo(MissionInstance instance) { }

	// RVA: 0x1F4AD90 Offset: 0x1F49390 VA: 0x181F4AD90
	public MissionInstance Copy() { }

	// RVA: 0x1F4BB90 Offset: 0x1F4A190 VA: 0x181F4BB90
	public static MissionInstance Deserialize(Stream stream) { }

	// RVA: 0x1F4AE10 Offset: 0x1F49410 VA: 0x181F4AE10
	public static MissionInstance DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4B4E0 Offset: 0x1F49AE0 VA: 0x181F4B4E0
	public static MissionInstance DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4BD10 Offset: 0x1F4A310 VA: 0x181F4BD10
	public static MissionInstance Deserialize(byte[] buffer) { }

	// RVA: 0x1F4C420 Offset: 0x1F4AA20 VA: 0x181F4C420
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4DA30 Offset: 0x1F4C030 VA: 0x181F4DA30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4DA50 Offset: 0x1F4C050 VA: 0x181F4DA50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionInstance previous) { }

	// RVA: 0x1F4C440 Offset: 0x1F4AA40 VA: 0x181F4C440 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4BC10 Offset: 0x1F4A210 VA: 0x181F4BC10
	public static MissionInstance Deserialize(byte[] buffer, MissionInstance instance, bool isDelta = False) { }

	// RVA: 0x1F4BE30 Offset: 0x1F4A430 VA: 0x181F4BE30
	public static MissionInstance Deserialize(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4AE90 Offset: 0x1F49490 VA: 0x181F4AE90
	public static MissionInstance DeserializeLengthDelimited(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4B570 Offset: 0x1F49B70 VA: 0x181F4B570
	public static MissionInstance DeserializeLength(Stream stream, int length, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F4C960 Offset: 0x1F4AF60 VA: 0x181F4C960
	public static void SerializeDelta(Stream stream, MissionInstance instance, MissionInstance previous) { }

	// RVA: 0x1F4D3A0 Offset: 0x1F4B9A0 VA: 0x181F4D3A0
	public static void Serialize(Stream stream, MissionInstance instance) { }

	// RVA: 0x1F4DA20 Offset: 0x1F4C020 VA: 0x181F4DA20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4DA30 Offset: 0x1F4C030 VA: 0x181F4DA30
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4D290 Offset: 0x1F4B890 VA: 0x181F4D290
	public static byte[] SerializeToBytes(MissionInstance instance) { }

	// RVA: 0x1F4D1E0 Offset: 0x1F4B7E0 VA: 0x181F4D1E0
	public static void SerializeLengthDelimited(Stream stream, MissionInstance instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

