public class m2bradleyAnimator : MonoBehaviour // TypeDefIndex: 9594
{	// Fields
	public Animator m2Animator; // 0x18
	public Material treadLeftMaterial; // 0x20
	public Material treadRightMaterial; // 0x28
	private Rigidbody mainRigidbody; // 0x30
	[HeaderAttribute] // RVA: 0x78650 Offset: 0x77A50 VA: 0x180078650
	public Transform turret; // 0x38
	public Transform mainCannon; // 0x40
	public Transform coaxGun; // 0x48
	public Transform rocketsPitch; // 0x50
	public Transform spotLightYaw; // 0x58
	public Transform spotLightPitch; // 0x60
	public Transform sideMG; // 0x68
	public Transform[] sideguns; // 0x70
	[HeaderAttribute] // RVA: 0x78790 Offset: 0x77B90 VA: 0x180078790
	public Transform[] ShocksBones; // 0x78
	public Transform[] ShockTraceLineBegin; // 0x80
	public Vector3[] vecShocksOffsetPosition; // 0x88
	[HeaderAttribute] // RVA: 0x788B0 Offset: 0x77CB0 VA: 0x1800788B0
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
	[HeaderAttribute] // RVA: 0x79EA0 Offset: 0x792A0 VA: 0x180079EA0
	public GameObject muzzleflashCannon; // 0xF8
	public GameObject muzzleflashCoaxGun; // 0x100
	public GameObject muzzleflashSideMG; // 0x108
	public GameObject[] muzzleflashRockets; // 0x110
	public GameObject spotLightHaloSawnpoint; // 0x118
	public GameObject[] muzzleflashSideguns; // 0x120
	[HeaderAttribute] // RVA: 0x79FE0 Offset: 0x793E0 VA: 0x180079FE0
	public GameObjectRef machineGunMuzzleFlashFX; // 0x128
	public GameObjectRef mainCannonFireFX; // 0x130
	public GameObjectRef rocketLaunchFX; // 0x138
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	public bool rocketsOpen; // 0x140
	public Vector3[] vecSideGunRotation; // 0x148
	public float treadConstant; // 0x150
	public float wheelSpinConstant; // 0x154
	[HeaderAttribute] // RVA: 0x7A320 Offset: 0x79720 VA: 0x18007A320
	public float sidegunsTurnSpeed; // 0x158
	public float turretTurnSpeed; // 0x15C
	public float cannonPitchSpeed; // 0x160
	public float rocketPitchSpeed; // 0x164
	public float spotLightTurnSpeed; // 0x168
	public float machineGunSpeed; // 0x16C
	private float wheelAngle; // 0x170

	// Methods

	// RVA: 0x1A91B50 Offset: 0x1A90150 VA: 0x181A91B50
	private void Start() { }

	// RVA: 0x1A92D80 Offset: 0x1A91380 VA: 0x181A92D80
	private void Update() { }

	// RVA: 0x1A91520 Offset: 0x1A8FB20 VA: 0x181A91520
	private void AnimateWheelsTreads() { }

	// RVA: 0x1A90F90 Offset: 0x1A8F590 VA: 0x181A90F90
	private void AdjustShocksHeight() { }

	// RVA: 0x1A92720 Offset: 0x1A90D20 VA: 0x181A92720
	private void TrackTurret() { }

	// RVA: 0x1A92300 Offset: 0x1A90900 VA: 0x181A92300
	private void TrackSpotLight() { }

	// RVA: 0x1A91C50 Offset: 0x1A90250 VA: 0x181A91C50
	private void TrackSideGuns() { }

	// RVA: 0x1A91880 Offset: 0x1A8FE80 VA: 0x181A91880
	public void CalculateYawPitchOffset(Transform objectTransform, Vector3 vecStart, Vector3 vecEnd, out float yaw, out float pitch) { }

	// RVA: 0x1A91B20 Offset: 0x1A90120 VA: 0x181A91B20
	public float NormalizeYaw(float flYaw) { }

	// RVA: 0x1A92E10 Offset: 0x1A91410 VA: 0x181A92E10
	public void .ctor() { }

}

