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

	// RVA: 0x9D4DE0 Offset: 0x9D33E0 VA: 0x1809D4DE0
	public void Start() { }

	// RVA: 0x9D4BF0 Offset: 0x9D31F0 VA: 0x1809D4BF0
	private void OnEnable() { }

	// RVA: 0x9D4B70 Offset: 0x9D3170 VA: 0x1809D4B70
	private void OnDisable() { }

	// RVA: 0x9D4720 Offset: 0x9D2D20 VA: 0x1809D4720
	public Quaternion GetRotation() { }

	// RVA: 0x9D4C70 Offset: 0x9D3270 VA: 0x1809D4C70
	private void QueuedGroundAlign() { }

	// RVA: 0x9D5000 Offset: 0x9D3600 VA: 0x1809D5000
	private void Update() { }

	// RVA: 0x9D47E0 Offset: 0x9D2DE0 VA: 0x1809D47E0
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x9D4910 Offset: 0x9D2F10 VA: 0x1809D4910
	public void LateUpdate() { }

	// RVA: 0x9D6210 Offset: 0x9D4810 VA: 0x1809D6210
	public void .ctor() { }

	// RVA: 0x9D6100 Offset: 0x9D4700 VA: 0x1809D6100
	private static void .cctor() { }

}

public class NpcWalkAnimation.NPCWalkWorkQueue : PersistentObjectWorkQueue<NpcWalkAnimation> // TypeDefIndex: 9119
{	// Methods

	// RVA: 0x9D0620 Offset: 0x9CEC20 VA: 0x1809D0620 Slot: 5
	protected override void RunJob(NpcWalkAnimation entity) { }

	// RVA: 0x9D0660 Offset: 0x9CEC60 VA: 0x1809D0660 Slot: 4
	protected override bool ShouldAdd(NpcWalkAnimation entity) { }

	// RVA: 0x9D0700 Offset: 0x9CED00 VA: 0x1809D0700
	public void .ctor() { }

}

