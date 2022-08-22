public class FishingRodViewmodel : MonoBehaviour // TypeDefIndex: 11437
{	// Fields
	public Transform PitchTransform; // 0x18
	public Transform YawTransform; // 0x20
	public float YawLerpSpeed; // 0x28
	public float PitchLerpSpeed; // 0x2C
	public Transform LineRendererStartPos; // 0x30
	public ParticleSystem[] StrainParticles; // 0x38
	public bool ApplyTransformRotation; // 0x40
	public GameObject CatchRoot; // 0x48
	public Transform CatchLinePoint; // 0x50
	public FishingRodViewmodel.FishViewmodel[] FishViewmodels; // 0x58
	public float ShakeMaxScale; // 0x60
	private static int InputStateX_Param; // 0x0
	private static int InputStateY_Param; // 0x4
	private Vector2 lerpedInputState; // 0x64

	// Methods

	// RVA: 0x78D6B0 Offset: 0x78BCB0 VA: 0x18078D6B0
	private void Start() { }

	// RVA: 0x78D6E0 Offset: 0x78BCE0 VA: 0x18078D6E0
	public void UpdateState(bool pullingLeft, bool pullingRight, bool pullingBack, float strainAmount, Animator forAnimator) { }

	// RVA: 0x78D500 Offset: 0x78BB00 VA: 0x18078D500
	public void SetFish(int id) { }

	// RVA: 0x78D6C0 Offset: 0x78BCC0 VA: 0x18078D6C0
	public void ToggleCatchRoot(bool state) { }

	// RVA: 0x78DBF0 Offset: 0x78C1F0 VA: 0x18078DBF0
	public void .ctor() { }

	// RVA: 0x78DB80 Offset: 0x78C180 VA: 0x18078DB80
	private static void .cctor() { }

}

public struct FishingRodViewmodel.FishViewmodel // TypeDefIndex: 11438
{	// Fields
	public ItemDefinition Item; // 0x0
	public GameObject Root; // 0x8

}

