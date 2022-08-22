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

	// RVA: 0x204E2D0 Offset: 0x204C8D0 VA: 0x18204E2D0
	public static void ResetToPool(PuzzleReset instance) { }

	// RVA: 0x204E380 Offset: 0x204C980 VA: 0x18204E380
	public void ResetToPool() { }

	// RVA: 0x204DF20 Offset: 0x204C520 VA: 0x18204DF20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204CBD0 Offset: 0x204B1D0 VA: 0x18204CBD0
	public void CopyTo(PuzzleReset instance) { }

	// RVA: 0x204CC10 Offset: 0x204B210 VA: 0x18204CC10
	public PuzzleReset Copy() { }

	// RVA: 0x204DA30 Offset: 0x204C030 VA: 0x18204DA30
	public static PuzzleReset Deserialize(Stream stream) { }

	// RVA: 0x204CCA0 Offset: 0x204B2A0 VA: 0x18204CCA0
	public static PuzzleReset DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204D350 Offset: 0x204B950 VA: 0x18204D350
	public static PuzzleReset DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204D6F0 Offset: 0x204BCF0 VA: 0x18204D6F0
	public static PuzzleReset Deserialize(byte[] buffer) { }

	// RVA: 0x204E050 Offset: 0x204C650 VA: 0x18204E050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204EB90 Offset: 0x204D190 VA: 0x18204EB90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204EBB0 Offset: 0x204D1B0 VA: 0x18204EBB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PuzzleReset previous) { }

	// RVA: 0x204E2B0 Offset: 0x204C8B0 VA: 0x18204E2B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204D3E0 Offset: 0x204B9E0 VA: 0x18204D3E0
	public static PuzzleReset Deserialize(byte[] buffer, PuzzleReset instance, bool isDelta = False) { }

	// RVA: 0x204DCC0 Offset: 0x204C2C0 VA: 0x18204DCC0
	public static PuzzleReset Deserialize(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204CD20 Offset: 0x204B320 VA: 0x18204CD20
	public static PuzzleReset DeserializeLengthDelimited(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204D050 Offset: 0x204B650 VA: 0x18204D050
	public static PuzzleReset DeserializeLength(Stream stream, int length, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204E430 Offset: 0x204CA30 VA: 0x18204E430
	public static void SerializeDelta(Stream stream, PuzzleReset instance, PuzzleReset previous) { }

	// RVA: 0x204E970 Offset: 0x204CF70 VA: 0x18204E970
	public static void Serialize(Stream stream, PuzzleReset instance) { }

	// RVA: 0x204EB80 Offset: 0x204D180 VA: 0x18204EB80
	public byte[] ToProtoBytes() { }

	// RVA: 0x204EB90 Offset: 0x204D190 VA: 0x18204EB90
	public void ToProto(Stream stream) { }

	// RVA: 0x204E860 Offset: 0x204CE60 VA: 0x18204E860
	public static byte[] SerializeToBytes(PuzzleReset instance) { }

	// RVA: 0x204E7B0 Offset: 0x204CDB0 VA: 0x18204E7B0
	public static void SerializeLengthDelimited(Stream stream, PuzzleReset instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x69AE20 Offset: 0x699420 VA: 0x18069AE20
	public void .ctor() { }

}

