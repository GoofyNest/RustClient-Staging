public class PuzzleReset : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6358
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool playerBlocksReset; // 0x12
	public float playerDetectionRadius; // 0x14
	public Vector3 playerDetectionOrigin; // 0x18
	public float timeBetweenResets; // 0x24
	public bool scaleWithServerPopulation; // 0x28

	// Methods

	// RVA: 0x204D7F0 Offset: 0x204BDF0 VA: 0x18204D7F0
	public static void ResetToPool(PuzzleReset instance) { }

	// RVA: 0x204D8A0 Offset: 0x204BEA0 VA: 0x18204D8A0
	public void ResetToPool() { }

	// RVA: 0x204D440 Offset: 0x204BA40 VA: 0x18204D440 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204C0F0 Offset: 0x204A6F0 VA: 0x18204C0F0
	public void CopyTo(PuzzleReset instance) { }

	// RVA: 0x204C130 Offset: 0x204A730 VA: 0x18204C130
	public PuzzleReset Copy() { }

	// RVA: 0x204CF50 Offset: 0x204B550 VA: 0x18204CF50
	public static PuzzleReset Deserialize(Stream stream) { }

	// RVA: 0x204C1C0 Offset: 0x204A7C0 VA: 0x18204C1C0
	public static PuzzleReset DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204C870 Offset: 0x204AE70 VA: 0x18204C870
	public static PuzzleReset DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204CC10 Offset: 0x204B210 VA: 0x18204CC10
	public static PuzzleReset Deserialize(byte[] buffer) { }

	// RVA: 0x204D570 Offset: 0x204BB70 VA: 0x18204D570
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204E0B0 Offset: 0x204C6B0 VA: 0x18204E0B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204E0D0 Offset: 0x204C6D0 VA: 0x18204E0D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PuzzleReset previous) { }

	// RVA: 0x204D7D0 Offset: 0x204BDD0 VA: 0x18204D7D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204C900 Offset: 0x204AF00 VA: 0x18204C900
	public static PuzzleReset Deserialize(byte[] buffer, PuzzleReset instance, bool isDelta = False) { }

	// RVA: 0x204D1E0 Offset: 0x204B7E0 VA: 0x18204D1E0
	public static PuzzleReset Deserialize(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204C240 Offset: 0x204A840 VA: 0x18204C240
	public static PuzzleReset DeserializeLengthDelimited(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204C570 Offset: 0x204AB70 VA: 0x18204C570
	public static PuzzleReset DeserializeLength(Stream stream, int length, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204D950 Offset: 0x204BF50 VA: 0x18204D950
	public static void SerializeDelta(Stream stream, PuzzleReset instance, PuzzleReset previous) { }

	// RVA: 0x204DE90 Offset: 0x204C490 VA: 0x18204DE90
	public static void Serialize(Stream stream, PuzzleReset instance) { }

	// RVA: 0x204E0A0 Offset: 0x204C6A0 VA: 0x18204E0A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x204E0B0 Offset: 0x204C6B0 VA: 0x18204E0B0
	public void ToProto(Stream stream) { }

	// RVA: 0x204DD80 Offset: 0x204C380 VA: 0x18204DD80
	public static byte[] SerializeToBytes(PuzzleReset instance) { }

	// RVA: 0x204DCD0 Offset: 0x204C2D0 VA: 0x18204DCD0
	public static void SerializeLengthDelimited(Stream stream, PuzzleReset instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PuzzleReset : FacepunchBehaviour // TypeDefIndex: 9811
{	// Fields
	public SpawnGroup[] respawnGroups; // 0x18
	public IOEntity[] resetEnts; // 0x20
	public GameObject[] resetObjects; // 0x28
	public bool playersBlockReset; // 0x30
	public bool CheckSleepingAIZForPlayers; // 0x31
	public float playerDetectionRadius; // 0x34
	public float playerHeightDetectionMinMax; // 0x38
	public Transform playerDetectionOrigin; // 0x40
	public float timeBetweenResets; // 0x48
	public bool scaleWithServerPopulation; // 0x4C
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3[] resetPositions; // 0x50

	// Methods

	// RVA: 0x69AD80 Offset: 0x699380 VA: 0x18069AD80
	public void .ctor() { }

}

