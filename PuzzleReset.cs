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

	// RVA: 0x204DAB0 Offset: 0x204C0B0 VA: 0x18204DAB0
	public static void ResetToPool(PuzzleReset instance) { }

	// RVA: 0x204DB60 Offset: 0x204C160 VA: 0x18204DB60
	public void ResetToPool() { }

	// RVA: 0x204D700 Offset: 0x204BD00 VA: 0x18204D700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204C3B0 Offset: 0x204A9B0 VA: 0x18204C3B0
	public void CopyTo(PuzzleReset instance) { }

	// RVA: 0x204C3F0 Offset: 0x204A9F0 VA: 0x18204C3F0
	public PuzzleReset Copy() { }

	// RVA: 0x204D210 Offset: 0x204B810 VA: 0x18204D210
	public static PuzzleReset Deserialize(Stream stream) { }

	// RVA: 0x204C480 Offset: 0x204AA80 VA: 0x18204C480
	public static PuzzleReset DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204CB30 Offset: 0x204B130 VA: 0x18204CB30
	public static PuzzleReset DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204CED0 Offset: 0x204B4D0 VA: 0x18204CED0
	public static PuzzleReset Deserialize(byte[] buffer) { }

	// RVA: 0x204D830 Offset: 0x204BE30 VA: 0x18204D830
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204E370 Offset: 0x204C970 VA: 0x18204E370 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204E390 Offset: 0x204C990 VA: 0x18204E390 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PuzzleReset previous) { }

	// RVA: 0x204DA90 Offset: 0x204C090 VA: 0x18204DA90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204CBC0 Offset: 0x204B1C0 VA: 0x18204CBC0
	public static PuzzleReset Deserialize(byte[] buffer, PuzzleReset instance, bool isDelta = False) { }

	// RVA: 0x204D4A0 Offset: 0x204BAA0 VA: 0x18204D4A0
	public static PuzzleReset Deserialize(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204C500 Offset: 0x204AB00 VA: 0x18204C500
	public static PuzzleReset DeserializeLengthDelimited(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204C830 Offset: 0x204AE30 VA: 0x18204C830
	public static PuzzleReset DeserializeLength(Stream stream, int length, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204DC10 Offset: 0x204C210 VA: 0x18204DC10
	public static void SerializeDelta(Stream stream, PuzzleReset instance, PuzzleReset previous) { }

	// RVA: 0x204E150 Offset: 0x204C750 VA: 0x18204E150
	public static void Serialize(Stream stream, PuzzleReset instance) { }

	// RVA: 0x204E360 Offset: 0x204C960 VA: 0x18204E360
	public byte[] ToProtoBytes() { }

	// RVA: 0x204E370 Offset: 0x204C970 VA: 0x18204E370
	public void ToProto(Stream stream) { }

	// RVA: 0x204E040 Offset: 0x204C640 VA: 0x18204E040
	public static byte[] SerializeToBytes(PuzzleReset instance) { }

	// RVA: 0x204DF90 Offset: 0x204C590 VA: 0x18204DF90
	public static void SerializeLengthDelimited(Stream stream, PuzzleReset instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x69AE90 Offset: 0x699490 VA: 0x18069AE90
	public void .ctor() { }

}

