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
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_isCulled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	private void set_isCulled(bool value) { }

	// RVA: 0xAE0BE0 Offset: 0xADF1E0 VA: 0x180AE0BE0
	public bool get_particlesAreInstantiated() { }

	// RVA: 0xAE0C40 Offset: 0xADF240 VA: 0x180AE0C40
	public int get_particlesCurrentCount() { }

	// RVA: 0xAE0CD0 Offset: 0xADF2D0 VA: 0x180AE0CD0
	public int get_particlesMaxCount() { }

	// RVA: 0xAE09C0 Offset: 0xADEFC0 VA: 0x180AE09C0
	public Camera get_mainCamera() { }

	// RVA: 0xAE04A0 Offset: 0xADEAA0 VA: 0x180AE04A0
	private void Start() { }

	// RVA: 0xADF9E0 Offset: 0xADDFE0 VA: 0x180ADF9E0
	private void InstantiateParticleSystem() { }

	// RVA: 0xADFCD0 Offset: 0xADE2D0 VA: 0x180ADFCD0
	private void OnEnable() { }

	// RVA: 0xADFCE0 Offset: 0xADE2E0 VA: 0x180ADFCE0
	private void SetActiveAndPlay() { }

	// RVA: 0xADFC40 Offset: 0xADE240 VA: 0x180ADFC40
	private void OnDisable() { }

	// RVA: 0xADFB80 Offset: 0xADE180 VA: 0x180ADFB80
	private void OnDestroy() { }

	// RVA: 0xAE08E0 Offset: 0xADEEE0 VA: 0x180AE08E0
	private void Update() { }

	// RVA: 0xADFD90 Offset: 0xADE390 VA: 0x180ADFD90
	private void SetParticleProperties() { }

	// RVA: 0xAE0560 Offset: 0xADEB60 VA: 0x180AE0560
	private void UpdateCulling() { }

	// RVA: 0xAE0980 Offset: 0xADEF80 VA: 0x180AE0980
	public void .ctor() { }

	// RVA: 0xAE0910 Offset: 0xADEF10 VA: 0x180AE0910
	private static void .cctor() { }

}

public enum VolumetricDustParticles.Direction // TypeDefIndex: 11557
{	// Fields
	public int value__; // 0x0
	public const VolumetricDustParticles.Direction Beam = 0;
	public const VolumetricDustParticles.Direction Random = 1;

}

