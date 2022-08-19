public class FootstepEffects : BaseFootstepEffect // TypeDefIndex: 9349
{	// Fields
	public Transform leftFoot; // 0x30
	public Transform rightFoot; // 0x38
	public string footstepEffectName; // 0x40
	public string jumpStartEffectName; // 0x48
	public string jumpLandEffectName; // 0x50
	private bool lastWasLeft; // 0x58
	private bool lastWasStopped; // 0x59
	private BasePlayer player; // 0x60
	private bool isOnGround; // 0x68
	private Animator animator; // 0x70

	// Methods

	// RVA: 0x7511D0 Offset: 0x74F7D0 VA: 0x1807511D0
	private void OnEnable() { }

	// RVA: 0x751780 Offset: 0x74FD80 VA: 0x180751780
	private void Update() { }

	// RVA: 0x750F40 Offset: 0x74F540 VA: 0x180750F40
	private void LeftFoot(float fVolume) { }

	// RVA: 0x751320 Offset: 0x74F920 VA: 0x180751320
	private void RightFoot(float fVolume) { }

	// RVA: 0x750A90 Offset: 0x74F090 VA: 0x180750A90
	private void Footstep(Vector3 vFootPos, bool left, bool bIgnoreDistanceCheck = False) { }

	// RVA: 0x7508B0 Offset: 0x74EEB0 VA: 0x1807508B0
	private void DoLandingEffect() { }

	// RVA: 0x7506D0 Offset: 0x74ECD0 VA: 0x1807506D0
	private void DoJumpStartEffect() { }

	// RVA: 0x7515A0 Offset: 0x74FBA0 VA: 0x1807515A0
	private void SetupPlayerFootstep(BasePlayer player, GameObject effect, bool left) { }

	// RVA: 0x751920 Offset: 0x74FF20 VA: 0x180751920
	public void .ctor() { }

}

