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

	// RVA: 0x789A50 Offset: 0x788050 VA: 0x180789A50
	private void Start() { }

	// RVA: 0x7896B0 Offset: 0x787CB0 VA: 0x1807896B0
	public void OnDestroy() { }

	// RVA: 0x789270 Offset: 0x787870 VA: 0x180789270
	public void Begin() { }

	// RVA: 0x789610 Offset: 0x787C10 VA: 0x180789610
	public float GetProgress() { }

	// RVA: 0x789CF0 Offset: 0x7882F0 VA: 0x180789CF0
	public void Update() { }

	// RVA: 0x789710 Offset: 0x787D10 VA: 0x180789710
	public void SetTwistAmount(int index, Vector3 twistAmountToUse) { }

	// RVA: 0x7892B0 Offset: 0x7878B0 VA: 0x1807892B0
	public void Explode() { }

	// RVA: 0x78A0C0 Offset: 0x7886C0 VA: 0x18078A0C0
	public void .ctor() { }

}

