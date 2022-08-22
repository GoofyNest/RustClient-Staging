public class NpcWalkAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9118
{	// Fields
	public Vector3 HipFudge; // 0x18
	public BaseNpc Npc; // 0x28
	public Animator Animator; // 0x30
	public Transform HipBone; // 0x38
	public Transform LookBone; // 0x40
	public bool UpdateWalkSpeed; // 0x48
	public bool UpdateFacingDirection; // 0x49
	public bool UpdateGroundNormal; // 0x4A
	public Transform alignmentRoot; // 0x50
	public bool LaggyAss; // 0x58
	public bool LookAtTarget; // 0x59
	public float MaxLaggyAssRotation; // 0x5C
	public float MaxWalkAnimSpeed; // 0x60
	public bool UseDirectionBlending; // 0x64
	public bool useTurnPosing; // 0x65
	public float turnPoseScale; // 0x68
	public float laggyAssLerpScale; // 0x6C
	public bool skeletonChainInverted; // 0x70
	private static int ParamWalkSpeed; // 0x0
	private static int ParamWalkSpeedAverage; // 0x4
	private static int ParamWalkDirX; // 0x8
	private static int ParamWalkDirZ; // 0xC
	private static int ParamTurnPose; // 0x10
	private AverageVelocity AverageVelocity; // 0x78
	private Vector3 oldPosition; // 0x80
	private Quaternion hipForward; // 0x8C
	private Quaternion baseHipRotation; // 0x9C
	private Quaternion baseLookRotation; // 0xAC
	[ClientVar] // RVA: 0xD11B0 Offset: 0xD05B0 VA: 0x1800D11B0
	[HelpAttribute] // RVA: 0xD11B0 Offset: 0xD05B0 VA: 0x1800D11B0
	public static float framebudgetms; // 0x14
	public static NpcWalkAnimation.NPCWalkWorkQueue WorkQueue; // 0x18
	private Vector3 targetUp; // 0xBC
	private Vector3 targetOffset; // 0xC8
	private Vector3 lastForward; // 0xD4
	private bool lastGroundAlignHit; // 0xE0
	private RaycastHit lastGroundAlignInfo; // 0xE4
	private float avgTurnDifference; // 0x110

	// Methods

	// RVA: 0x9D50A0 Offset: 0x9D36A0 VA: 0x1809D50A0
	public void Start() { }

	// RVA: 0x9D4EB0 Offset: 0x9D34B0 VA: 0x1809D4EB0
	private void OnEnable() { }

	// RVA: 0x9D4E30 Offset: 0x9D3430 VA: 0x1809D4E30
	private void OnDisable() { }

	// RVA: 0x9D49E0 Offset: 0x9D2FE0 VA: 0x1809D49E0
	public Quaternion GetRotation() { }

	// RVA: 0x9D4F30 Offset: 0x9D3530 VA: 0x1809D4F30
	private void QueuedGroundAlign() { }

	// RVA: 0x9D52C0 Offset: 0x9D38C0 VA: 0x1809D52C0
	private void Update() { }

	// RVA: 0x9D4AA0 Offset: 0x9D30A0 VA: 0x1809D4AA0
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x9D4BD0 Offset: 0x9D31D0 VA: 0x1809D4BD0
	public void LateUpdate() { }

	// RVA: 0x9D64D0 Offset: 0x9D4AD0 VA: 0x1809D64D0
	public void .ctor() { }

	// RVA: 0x9D63C0 Offset: 0x9D49C0 VA: 0x1809D63C0
	private static void .cctor() { }

}

public class NpcWalkAnimation.NPCWalkWorkQueue : PersistentObjectWorkQueue<NpcWalkAnimation> // TypeDefIndex: 9119
{	// Methods

	// RVA: 0x9D08E0 Offset: 0x9CEEE0 VA: 0x1809D08E0 Slot: 5
	protected override void RunJob(NpcWalkAnimation entity) { }

	// RVA: 0x9D0920 Offset: 0x9CEF20 VA: 0x1809D0920 Slot: 4
	protected override bool ShouldAdd(NpcWalkAnimation entity) { }

	// RVA: 0x9D09C0 Offset: 0x9CEFC0 VA: 0x1809D09C0
	public void .ctor() { }

}

