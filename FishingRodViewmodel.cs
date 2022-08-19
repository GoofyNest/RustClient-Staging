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

	// RVA: 0x78D5A0 Offset: 0x78BBA0 VA: 0x18078D5A0
	private void Start() { }

	// RVA: 0x78D5D0 Offset: 0x78BBD0 VA: 0x18078D5D0
	public void UpdateState(bool pullingLeft, bool pullingRight, bool pullingBack, float strainAmount, Animator forAnimator) { }

	// RVA: 0x78D3F0 Offset: 0x78B9F0 VA: 0x18078D3F0
	public void SetFish(int id) { }

	// RVA: 0x78D5B0 Offset: 0x78BBB0 VA: 0x18078D5B0
	public void ToggleCatchRoot(bool state) { }

	// RVA: 0x78DAE0 Offset: 0x78C0E0 VA: 0x18078DAE0
	public void .ctor() { }

	// RVA: 0x78DA70 Offset: 0x78C070 VA: 0x18078DA70
	private static void .cctor() { }

}

public struct FishingRodViewmodel.FishViewmodel // TypeDefIndex: 11438
{	// Fields
	public ItemDefinition Item; // 0x0
	public GameObject Root; // 0x8

}

