public class FirecrackerRepeater : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8755
{	// Fields
	public GameObjectRef singleExplosionEffect; // 0x18
	public Transform[] parts; // 0x20
	public float partWidth; // 0x28
	public float partLength; // 0x2C
	public Quaternion[] targetRotations; // 0x30
	public Quaternion[] initialRotations; // 0x38
	public Renderer[] renderers; // 0x40
	public Material materialSource; // 0x48
	public float explodeRepeatMin; // 0x50
	public float explodeRepeatMax; // 0x54
	public float explodeLerpSpeed; // 0x58
	public Vector3 twistAmount; // 0x5C
	public float fuseLength; // 0x68
	public float explodeStrength; // 0x6C
	public float explodeDirBlend; // 0x70
	public float duration; // 0x74
	public ParticleSystemContainer smokeParticle; // 0x78
	private float nextExplodeTime; // 0x80
	private float nextPartTime; // 0x84
	private int explodingPartIndex; // 0x88
	private Material instancedMaterial; // 0x90
	private bool lit; // 0x98
	private float startTime; // 0x9C

	// Methods

	// RVA: 0x7899A0 Offset: 0x787FA0 VA: 0x1807899A0
	private void Start() { }

	// RVA: 0x789600 Offset: 0x787C00 VA: 0x180789600
	public void OnDestroy() { }

	// RVA: 0x7891C0 Offset: 0x7877C0 VA: 0x1807891C0
	public void Begin() { }

	// RVA: 0x789560 Offset: 0x787B60 VA: 0x180789560
	public float GetProgress() { }

	// RVA: 0x789C40 Offset: 0x788240 VA: 0x180789C40
	public void Update() { }

	// RVA: 0x789660 Offset: 0x787C60 VA: 0x180789660
	public void SetTwistAmount(int index, Vector3 twistAmountToUse) { }

	// RVA: 0x789200 Offset: 0x787800 VA: 0x180789200
	public void Explode() { }

	// RVA: 0x78A010 Offset: 0x788610 VA: 0x18078A010
	public void .ctor() { }

}

