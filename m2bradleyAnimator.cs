public class m2bradleyAnimator : MonoBehaviour // TypeDefIndex: 9594
{	public Animator m2Animator; // 0x18
	public Material treadLeftMaterial; // 0x20
	public Material treadRightMaterial; // 0x28
	private Rigidbody mainRigidbody; // 0x30
	[HeaderAttribute] // RVA: 0x78700 Offset: 0x77B00 VA: 0x180078700
	public Transform turret; // 0x38
	public Transform mainCannon; // 0x40
	public Transform coaxGun; // 0x48
	public Transform rocketsPitch; // 0x50
	public Transform spotLightYaw; // 0x58
	public Transform spotLightPitch; // 0x60
	public Transform sideMG; // 0x68
	public Transform[] sideguns; // 0x70
	[HeaderAttribute] // RVA: 0x78840 Offset: 0x77C40 VA: 0x180078840
	public Transform[] ShocksBones; // 0x78
	public Transform[] ShockTraceLineBegin; // 0x80
	public Vector3[] vecShocksOffsetPosition; // 0x88
	[HeaderAttribute] // RVA: 0x78950 Offset: 0x77D50 VA: 0x180078950
	public Transform targetTurret; // 0x90
	public Transform targetSpotLight; // 0x98
	public Transform[] targetSideguns; // 0xA0
	private Vector3 vecTurret; // 0xA8
	private Vector3 vecMainCannon; // 0xB4
	private Vector3 vecCoaxGun; // 0xC0
	private Vector3 vecRocketsPitch; // 0xCC
	private Vector3 vecSpotLightBase; // 0xD8
	private Vector3 vecSpotLight; // 0xE4
	private float sideMGPitchValue; // 0xF0
	[HeaderAttribute] // RVA: 0x79F70 Offset: 0x79370 VA: 0x180079F70
	public GameObject muzzleflashCannon; // 0xF8
	public GameObject muzzleflashCoaxGun; // 0x100
	public GameObject muzzleflashSideMG; // 0x108
	public GameObject[] muzzleflashRockets; // 0x110
	public GameObject spotLightHaloSawnpoint; // 0x118
	public GameObject[] muzzleflashSideguns; // 0x120
	[HeaderAttribute] // RVA: 0x7A0B0 Offset: 0x794B0 VA: 0x18007A0B0
	public GameObjectRef machineGunMuzzleFlashFX; // 0x128
	public GameObjectRef mainCannonFireFX; // 0x130
	public GameObjectRef rocketLaunchFX; // 0x138
	[HeaderAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public bool rocketsOpen; // 0x140
	public Vector3[] vecSideGunRotation; // 0x148
	public float treadConstant; // 0x150
	public float wheelSpinConstant; // 0x154
	[HeaderAttribute] // RVA: 0x7A460 Offset: 0x79860 VA: 0x18007A460
	public float sidegunsTurnSpeed; // 0x158
	public float turretTurnSpeed; // 0x15C
	public float cannonPitchSpeed; // 0x160
	public float rocketPitchSpeed; // 0x164
	public float spotLightTurnSpeed; // 0x168
	public float machineGunSpeed; // 0x16C
	private float wheelAngle; // 0x170


	private void Start() { }

	private void Update() { }

	private void AnimateWheelsTreads() { }

	private void AdjustShocksHeight() { }

	private void TrackTurret() { }

	private void TrackSpotLight() { }

	private void TrackSideGuns() { }

	public void CalculateYawPitchOffset(Transform objectTransform, Vector3 vecStart, Vector3 vecEnd, out float yaw, out float pitch) { }

	public float NormalizeYaw(float flYaw) { }

	public void .ctor() { }

}

