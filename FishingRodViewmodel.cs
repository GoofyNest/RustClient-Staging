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

	// RVA: 0x78D5C0 Offset: 0x78BBC0 VA: 0x18078D5C0
	private void Start() { }

	// RVA: 0x78D5F0 Offset: 0x78BBF0 VA: 0x18078D5F0
	public void UpdateState(bool pullingLeft, bool pullingRight, bool pullingBack, float strainAmount, Animator forAnimator) { }

	// RVA: 0x78D410 Offset: 0x78BA10 VA: 0x18078D410
	public void SetFish(int id) { }

	// RVA: 0x78D5D0 Offset: 0x78BBD0 VA: 0x18078D5D0
	public void ToggleCatchRoot(bool state) { }

	// RVA: 0x78DB00 Offset: 0x78C100 VA: 0x18078DB00
	public void .ctor() { }

	// RVA: 0x78DA90 Offset: 0x78C090 VA: 0x18078DA90
	private static void .cctor() { }

}

public struct FishingRodViewmodel.FishViewmodel // TypeDefIndex: 11438
{	// Fields
	public ItemDefinition Item; // 0x0
	public GameObject Root; // 0x8

}

