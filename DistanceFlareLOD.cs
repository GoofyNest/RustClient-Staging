public class DistanceFlareLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 11305
{	// Fields
	public bool isDynamic; // 0x18
	public float minEnabledDistance; // 0x1C
	public float maxEnabledDistance; // 0x20
	public bool toggleFade; // 0x24
	public float toggleFadeDuration; // 0x28
	private LODCell cell; // 0x30
	private Renderer flareRenderer; // 0x38
	private float flareIntensity; // 0x40
	private float fadeIntensity; // 0x44
	private Color startColor; // 0x48
	private static int emissionColorID; // 0x0
	private static MaterialPropertyBlock block; // 0x8
	private LODEnvironmentMode EnvironmentMode; // 0x58
	private float fadeStartTime; // 0x5C
	private float fadeEndTime; // 0x60
	private bool fadeToState; // 0x64
	private bool queuedState; // 0x65

	// Methods

	// RVA: 0x98AE10 Offset: 0x989410 VA: 0x18098AE10
	private float GetDistance() { }

	// RVA: 0x98A8D0 Offset: 0x988ED0 VA: 0x18098A8D0
	protected void Awake() { }

	// RVA: 0x98AF60 Offset: 0x989560 VA: 0x18098AF60
	protected void OnEnable() { }

	// RVA: 0x98AE90 Offset: 0x989490 VA: 0x18098AE90
	protected void OnDisable() { }

	// RVA: 0x98B1D0 Offset: 0x9897D0 VA: 0x18098B1D0
	private void UpdateMaterialPropertyBlock() { }

	// RVA: 0x98B1B0 Offset: 0x9897B0 VA: 0x18098B1B0
	private void ToggleFlare(bool state) { }

	// RVA: 0x98AC70 Offset: 0x989270 VA: 0x18098AC70
	private void FadingToggle() { }

	// RVA: 0x98B090 Offset: 0x989690 VA: 0x18098B090
	public void SetFlareActive(bool lightOn) { }

	// RVA: 0x98B1A0 Offset: 0x9897A0 VA: 0x18098B1A0
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x98B000 Offset: 0x989600 VA: 0x18098B000 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x98AAE0 Offset: 0x9890E0 VA: 0x18098AAE0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x98B350 Offset: 0x989950 VA: 0x18098B350
	public void .ctor() { }

	// RVA: 0x98B300 Offset: 0x989900 VA: 0x18098B300
	private static void .cctor() { }

}

