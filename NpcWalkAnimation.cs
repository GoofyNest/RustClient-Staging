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

	// RVA: 0x9D5590 Offset: 0x9D3B90 VA: 0x1809D5590
	public void Start() { }

	// RVA: 0x9D53A0 Offset: 0x9D39A0 VA: 0x1809D53A0
	private void OnEnable() { }

	// RVA: 0x9D5320 Offset: 0x9D3920 VA: 0x1809D5320
	private void OnDisable() { }

	// RVA: 0x9D4ED0 Offset: 0x9D34D0 VA: 0x1809D4ED0
	public Quaternion GetRotation() { }

	// RVA: 0x9D5420 Offset: 0x9D3A20 VA: 0x1809D5420
	private void QueuedGroundAlign() { }

	// RVA: 0x9D57B0 Offset: 0x9D3DB0 VA: 0x1809D57B0
	private void Update() { }

	// RVA: 0x9D4F90 Offset: 0x9D3590 VA: 0x1809D4F90
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x9D50C0 Offset: 0x9D36C0 VA: 0x1809D50C0
	public void LateUpdate() { }

	// RVA: 0x9D69C0 Offset: 0x9D4FC0 VA: 0x1809D69C0
	public void .ctor() { }

	// RVA: 0x9D68B0 Offset: 0x9D4EB0 VA: 0x1809D68B0
	private static void .cctor() { }

}

public class NpcWalkAnimation.NPCWalkWorkQueue : PersistentObjectWorkQueue<NpcWalkAnimation> // TypeDefIndex: 9119
{	// Methods

	// RVA: 0x9D0DD0 Offset: 0x9CF3D0 VA: 0x1809D0DD0 Slot: 5
	protected override void RunJob(NpcWalkAnimation entity) { }

	// RVA: 0x9D0E10 Offset: 0x9CF410 VA: 0x1809D0E10 Slot: 4
	protected override bool ShouldAdd(NpcWalkAnimation entity) { }

	// RVA: 0x9D0EB0 Offset: 0x9CF4B0 VA: 0x1809D0EB0
	public void .ctor() { }

}

