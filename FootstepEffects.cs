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

	// RVA: 0x7512E0 Offset: 0x74F8E0 VA: 0x1807512E0
	private void OnEnable() { }

	// RVA: 0x751890 Offset: 0x74FE90 VA: 0x180751890
	private void Update() { }

	// RVA: 0x751050 Offset: 0x74F650 VA: 0x180751050
	private void LeftFoot(float fVolume) { }

	// RVA: 0x751430 Offset: 0x74FA30 VA: 0x180751430
	private void RightFoot(float fVolume) { }

	// RVA: 0x750BA0 Offset: 0x74F1A0 VA: 0x180750BA0
	private void Footstep(Vector3 vFootPos, bool left, bool bIgnoreDistanceCheck = False) { }

	// RVA: 0x7509C0 Offset: 0x74EFC0 VA: 0x1807509C0
	private void DoLandingEffect() { }

	// RVA: 0x7507E0 Offset: 0x74EDE0 VA: 0x1807507E0
	private void DoJumpStartEffect() { }

	// RVA: 0x7516B0 Offset: 0x74FCB0 VA: 0x1807516B0
	private void SetupPlayerFootstep(BasePlayer player, GameObject effect, bool left) { }

	// RVA: 0x751A30 Offset: 0x750030 VA: 0x180751A30
	public void .ctor() { }

}

