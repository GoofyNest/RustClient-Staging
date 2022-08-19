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

	// RVA: 0x204D9B0 Offset: 0x204BFB0 VA: 0x18204D9B0
	public static void ResetToPool(PuzzleReset instance) { }

	// RVA: 0x204DA60 Offset: 0x204C060 VA: 0x18204DA60
	public void ResetToPool() { }

	// RVA: 0x204D600 Offset: 0x204BC00 VA: 0x18204D600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204C2B0 Offset: 0x204A8B0 VA: 0x18204C2B0
	public void CopyTo(PuzzleReset instance) { }

	// RVA: 0x204C2F0 Offset: 0x204A8F0 VA: 0x18204C2F0
	public PuzzleReset Copy() { }

	// RVA: 0x204D110 Offset: 0x204B710 VA: 0x18204D110
	public static PuzzleReset Deserialize(Stream stream) { }

	// RVA: 0x204C380 Offset: 0x204A980 VA: 0x18204C380
	public static PuzzleReset DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204CA30 Offset: 0x204B030 VA: 0x18204CA30
	public static PuzzleReset DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204CDD0 Offset: 0x204B3D0 VA: 0x18204CDD0
	public static PuzzleReset Deserialize(byte[] buffer) { }

	// RVA: 0x204D730 Offset: 0x204BD30 VA: 0x18204D730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204E270 Offset: 0x204C870 VA: 0x18204E270 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204E290 Offset: 0x204C890 VA: 0x18204E290 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PuzzleReset previous) { }

	// RVA: 0x204D990 Offset: 0x204BF90 VA: 0x18204D990 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204CAC0 Offset: 0x204B0C0 VA: 0x18204CAC0
	public static PuzzleReset Deserialize(byte[] buffer, PuzzleReset instance, bool isDelta = False) { }

	// RVA: 0x204D3A0 Offset: 0x204B9A0 VA: 0x18204D3A0
	public static PuzzleReset Deserialize(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204C400 Offset: 0x204AA00 VA: 0x18204C400
	public static PuzzleReset DeserializeLengthDelimited(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204C730 Offset: 0x204AD30 VA: 0x18204C730
	public static PuzzleReset DeserializeLength(Stream stream, int length, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x204DB10 Offset: 0x204C110 VA: 0x18204DB10
	public static void SerializeDelta(Stream stream, PuzzleReset instance, PuzzleReset previous) { }

	// RVA: 0x204E050 Offset: 0x204C650 VA: 0x18204E050
	public static void Serialize(Stream stream, PuzzleReset instance) { }

	// RVA: 0x204E260 Offset: 0x204C860 VA: 0x18204E260
	public byte[] ToProtoBytes() { }

	// RVA: 0x204E270 Offset: 0x204C870 VA: 0x18204E270
	public void ToProto(Stream stream) { }

	// RVA: 0x204DF40 Offset: 0x204C540 VA: 0x18204DF40
	public static byte[] SerializeToBytes(PuzzleReset instance) { }

	// RVA: 0x204DE90 Offset: 0x204C490 VA: 0x18204DE90
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
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Vector3[] resetPositions; // 0x50

	// Methods

	// RVA: 0x69AD80 Offset: 0x699380 VA: 0x18069AD80
	public void .ctor() { }

}

