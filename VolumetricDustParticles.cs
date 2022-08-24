public class VolumetricDustParticles : MonoBehaviour // TypeDefIndex: 11560
{	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float alpha; // 0x18
	[RangeAttribute] // RVA: 0xC21B0 Offset: 0xC15B0 VA: 0x1800C21B0
	public float size; // 0x1C
	public VolumetricDustParticles.Direction direction; // 0x20
	public float speed; // 0x24
	public float density; // 0x28
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float spawnMaxDistance; // 0x2C
	public bool cullingEnabled; // 0x30
	public float cullingMaxDistance; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <isCulled>k__BackingField; // 0x38
	public static bool isFeatureSupported; // 0x0
	private ParticleSystem m_Particles; // 0x40
	private ParticleSystemRenderer m_Renderer; // 0x48
	private static bool ms_NoMainCameraLogged; // 0x1
	private static Camera ms_MainCamera; // 0x8
	private VolumetricLightBeam m_Master; // 0x50

	public bool isCulled { get; set; }
	public bool particlesAreInstantiated { get; }
	public int particlesCurrentCount { get; }
	public int particlesMaxCount { get; }
	public Camera mainCamera { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_isCulled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_isCulled(bool value) { }

	public bool get_particlesAreInstantiated() { }

	public int get_particlesCurrentCount() { }

	public int get_particlesMaxCount() { }

	public Camera get_mainCamera() { }

	private void Start() { }

	private void InstantiateParticleSystem() { }

	private void OnEnable() { }

	private void SetActiveAndPlay() { }

	private void OnDisable() { }

	private void OnDestroy() { }

	private void Update() { }

	private void SetParticleProperties() { }

	private void UpdateCulling() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum VolumetricDustParticles.Direction // TypeDefIndex: 11561
{	public int value__; // 0x0
	public const VolumetricDustParticles.Direction Beam = 0;
	public const VolumetricDustParticles.Direction Random = 1;

}

