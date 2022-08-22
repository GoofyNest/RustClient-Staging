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
	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_isCulled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E280 Offset: 0x78C880 VA: 0x18078E280
	private void set_isCulled(bool value) { }

	// RVA: 0xAE0EA0 Offset: 0xADF4A0 VA: 0x180AE0EA0
	public bool get_particlesAreInstantiated() { }

	// RVA: 0xAE0F00 Offset: 0xADF500 VA: 0x180AE0F00
	public int get_particlesCurrentCount() { }

	// RVA: 0xAE0F90 Offset: 0xADF590 VA: 0x180AE0F90
	public int get_particlesMaxCount() { }

	// RVA: 0xAE0C80 Offset: 0xADF280 VA: 0x180AE0C80
	public Camera get_mainCamera() { }

	// RVA: 0xAE0760 Offset: 0xADED60 VA: 0x180AE0760
	private void Start() { }

	// RVA: 0xADFCA0 Offset: 0xADE2A0 VA: 0x180ADFCA0
	private void InstantiateParticleSystem() { }

	// RVA: 0xADFF90 Offset: 0xADE590 VA: 0x180ADFF90
	private void OnEnable() { }

	// RVA: 0xADFFA0 Offset: 0xADE5A0 VA: 0x180ADFFA0
	private void SetActiveAndPlay() { }

	// RVA: 0xADFF00 Offset: 0xADE500 VA: 0x180ADFF00
	private void OnDisable() { }

	// RVA: 0xADFE40 Offset: 0xADE440 VA: 0x180ADFE40
	private void OnDestroy() { }

	// RVA: 0xAE0BA0 Offset: 0xADF1A0 VA: 0x180AE0BA0
	private void Update() { }

	// RVA: 0xAE0050 Offset: 0xADE650 VA: 0x180AE0050
	private void SetParticleProperties() { }

	// RVA: 0xAE0820 Offset: 0xADEE20 VA: 0x180AE0820
	private void UpdateCulling() { }

	// RVA: 0xAE0C40 Offset: 0xADF240 VA: 0x180AE0C40
	public void .ctor() { }

	// RVA: 0xAE0BD0 Offset: 0xADF1D0 VA: 0x180AE0BD0
	private static void .cctor() { }

}

public enum VolumetricDustParticles.Direction // TypeDefIndex: 11557
{	// Fields
	public int value__; // 0x0
	public const VolumetricDustParticles.Direction Beam = 0;
	public const VolumetricDustParticles.Direction Random = 1;

}

