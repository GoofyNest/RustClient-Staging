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

	// RVA: 0x751230 Offset: 0x74F830 VA: 0x180751230
	private void OnEnable() { }

	// RVA: 0x7517E0 Offset: 0x74FDE0 VA: 0x1807517E0
	private void Update() { }

	// RVA: 0x750FA0 Offset: 0x74F5A0 VA: 0x180750FA0
	private void LeftFoot(float fVolume) { }

	// RVA: 0x751380 Offset: 0x74F980 VA: 0x180751380
	private void RightFoot(float fVolume) { }

	// RVA: 0x750AF0 Offset: 0x74F0F0 VA: 0x180750AF0
	private void Footstep(Vector3 vFootPos, bool left, bool bIgnoreDistanceCheck = False) { }

	// RVA: 0x750910 Offset: 0x74EF10 VA: 0x180750910
	private void DoLandingEffect() { }

	// RVA: 0x750730 Offset: 0x74ED30 VA: 0x180750730
	private void DoJumpStartEffect() { }

	// RVA: 0x751600 Offset: 0x74FC00 VA: 0x180751600
	private void SetupPlayerFootstep(BasePlayer player, GameObject effect, bool left) { }

	// RVA: 0x751980 Offset: 0x74FF80 VA: 0x180751980
	public void .ctor() { }

}

