public class VolumetricDustParticles : MonoBehaviour // TypeDefIndex: 11556
{	// Fields
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float alpha; // 0x18
	[RangeAttribute] // RVA: 0xC35B0 Offset: 0xC29B0 VA: 0x1800C35B0
	public float size; // 0x1C
	public VolumetricDustParticles.Direction direction; // 0x20
	public float speed; // 0x24
	public float density; // 0x28
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float spawnMaxDistance; // 0x2C
	public bool cullingEnabled; // 0x30
	public float cullingMaxDistance; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isCulled>k__BackingField; // 0x38
	public static bool isFeatureSupported; // 0x0
	private ParticleSystem m_Particles; // 0x40
	private ParticleSystemRenderer m_Renderer; // 0x48
	private static bool ms_NoMainCameraLogged; // 0x1
	private static Camera ms_MainCamera; // 0x8
	private VolumetricLightBeam m_Master; // 0x50

	// Properties
	public bool isCulled { get; set; }
	public bool particlesAreInstantiated { get; }
	public int particlesCurrentCount { get; }
	public int particlesMaxCount { get; }
	public Camera mainCamera { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_isCulled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E190 Offset: 0x78C790 VA: 0x18078E190
	private void set_isCulled(bool value) { }

	// RVA: 0xAE1370 Offset: 0xADF970 VA: 0x180AE1370
	public bool get_particlesAreInstantiated() { }

	// RVA: 0xAE13D0 Offset: 0xADF9D0 VA: 0x180AE13D0
	public int get_particlesCurrentCount() { }

	// RVA: 0xAE1460 Offset: 0xADFA60 VA: 0x180AE1460
	public int get_particlesMaxCount() { }

	// RVA: 0xAE1150 Offset: 0xADF750 VA: 0x180AE1150
	public Camera get_mainCamera() { }

	// RVA: 0xAE0C30 Offset: 0xADF230 VA: 0x180AE0C30
	private void Start() { }

	// RVA: 0xAE0170 Offset: 0xADE770 VA: 0x180AE0170
	private void InstantiateParticleSystem() { }

	// RVA: 0xAE0460 Offset: 0xADEA60 VA: 0x180AE0460
	private void OnEnable() { }

	// RVA: 0xAE0470 Offset: 0xADEA70 VA: 0x180AE0470
	private void SetActiveAndPlay() { }

	// RVA: 0xAE03D0 Offset: 0xADE9D0 VA: 0x180AE03D0
	private void OnDisable() { }

	// RVA: 0xAE0310 Offset: 0xADE910 VA: 0x180AE0310
	private void OnDestroy() { }

	// RVA: 0xAE1070 Offset: 0xADF670 VA: 0x180AE1070
	private void Update() { }

	// RVA: 0xAE0520 Offset: 0xADEB20 VA: 0x180AE0520
	private void SetParticleProperties() { }

	// RVA: 0xAE0CF0 Offset: 0xADF2F0 VA: 0x180AE0CF0
	private void UpdateCulling() { }

	// RVA: 0xAE1110 Offset: 0xADF710 VA: 0x180AE1110
	public void .ctor() { }

	// RVA: 0xAE10A0 Offset: 0xADF6A0 VA: 0x180AE10A0
	private static void .cctor() { }

}

public enum VolumetricDustParticles.Direction // TypeDefIndex: 11557
{	// Fields
	public int value__; // 0x0
	public const VolumetricDustParticles.Direction Beam = 0;
	public const VolumetricDustParticles.Direction Random = 1;

}

