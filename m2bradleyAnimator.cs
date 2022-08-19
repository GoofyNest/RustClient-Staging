public class m2bradleyAnimator : MonoBehaviour // TypeDefIndex: 9594
{	// Fields
	public Animator m2Animator; // 0x18
	public Material treadLeftMaterial; // 0x20
	public Material treadRightMaterial; // 0x28
	private Rigidbody mainRigidbody; // 0x30
	[HeaderAttribute] // RVA: 0x78530 Offset: 0x77930 VA: 0x180078530
	public Transform turret; // 0x38
	public Transform mainCannon; // 0x40
	public Transform coaxGun; // 0x48
	public Transform rocketsPitch; // 0x50
	public Transform spotLightYaw; // 0x58
	public Transform spotLightPitch; // 0x60
	public Transform sideMG; // 0x68
	public Transform[] sideguns; // 0x70
	[HeaderAttribute] // RVA: 0x786C0 Offset: 0x77AC0 VA: 0x1800786C0
	public Transform[] ShocksBones; // 0x78
	public Transform[] ShockTraceLineBegin; // 0x80
	public Vector3[] vecShocksOffsetPosition; // 0x88
	[HeaderAttribute] // RVA: 0x787E0 Offset: 0x77BE0 VA: 0x1800787E0
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
	[HeaderAttribute] // RVA: 0x79BB0 Offset: 0x78FB0 VA: 0x180079BB0
	public GameObject muzzleflashCannon; // 0xF8
	public GameObject muzzleflashCoaxGun; // 0x100
	public GameObject muzzleflashSideMG; // 0x108
	public GameObject[] muzzleflashRockets; // 0x110
	public GameObject spotLightHaloSawnpoint; // 0x118
	public GameObject[] muzzleflashSideguns; // 0x120
	[HeaderAttribute] // RVA: 0x79EE0 Offset: 0x792E0 VA: 0x180079EE0
	public GameObjectRef machineGunMuzzleFlashFX; // 0x128
	public GameObjectRef mainCannonFireFX; // 0x130
	public GameObjectRef rocketLaunchFX; // 0x138
	[HeaderAttribute] // RVA: 0x71E00 Offset: 0x71200 VA: 0x180071E00
	public bool rocketsOpen; // 0x140
	public Vector3[] vecSideGunRotation; // 0x148
	public float treadConstant; // 0x150
	public float wheelSpinConstant; // 0x154
	[HeaderAttribute] // RVA: 0x7A260 Offset: 0x79660 VA: 0x18007A260
	public float sidegunsTurnSpeed; // 0x158
	public float turretTurnSpeed; // 0x15C
	public float cannonPitchSpeed; // 0x160
	public float rocketPitchSpeed; // 0x164
	public float spotLightTurnSpeed; // 0x168
	public float machineGunSpeed; // 0x16C
	private float wheelAngle; // 0x170

	// Methods

	// RVA: 0x1AA7C20 Offset: 0x1AA6220 VA: 0x181AA7C20
	private void Start() { }

	// RVA: 0x1AA8E50 Offset: 0x1AA7450 VA: 0x181AA8E50
	private void Update() { }

	// RVA: 0x1AA75F0 Offset: 0x1AA5BF0 VA: 0x181AA75F0
	private void AnimateWheelsTreads() { }

	// RVA: 0x1AA7060 Offset: 0x1AA5660 VA: 0x181AA7060
	private void AdjustShocksHeight() { }

	// RVA: 0x1AA87F0 Offset: 0x1AA6DF0 VA: 0x181AA87F0
	private void TrackTurret() { }

	// RVA: 0x1AA83D0 Offset: 0x1AA69D0 VA: 0x181AA83D0
	private void TrackSpotLight() { }

	// RVA: 0x1AA7D20 Offset: 0x1AA6320 VA: 0x181AA7D20
	private void TrackSideGuns() { }

	// RVA: 0x1AA7950 Offset: 0x1AA5F50 VA: 0x181AA7950
	public void CalculateYawPitchOffset(Transform objectTransform, Vector3 vecStart, Vector3 vecEnd, out float yaw, out float pitch) { }

	// RVA: 0x1AA7BF0 Offset: 0x1AA61F0 VA: 0x181AA7BF0
	public float NormalizeYaw(float flYaw) { }

	// RVA: 0x1AA8EE0 Offset: 0x1AA74E0 VA: 0x181AA8EE0
	public void .ctor() { }

}

