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

	// RVA: 0x98AF20 Offset: 0x989520 VA: 0x18098AF20
	private float GetDistance() { }

	// RVA: 0x98A9E0 Offset: 0x988FE0 VA: 0x18098A9E0
	protected void Awake() { }

	// RVA: 0x98B070 Offset: 0x989670 VA: 0x18098B070
	protected void OnEnable() { }

	// RVA: 0x98AFA0 Offset: 0x9895A0 VA: 0x18098AFA0
	protected void OnDisable() { }

	// RVA: 0x98B2E0 Offset: 0x9898E0 VA: 0x18098B2E0
	private void UpdateMaterialPropertyBlock() { }

	// RVA: 0x98B2C0 Offset: 0x9898C0 VA: 0x18098B2C0
	private void ToggleFlare(bool state) { }

	// RVA: 0x98AD80 Offset: 0x989380 VA: 0x18098AD80
	private void FadingToggle() { }

	// RVA: 0x98B1A0 Offset: 0x9897A0 VA: 0x18098B1A0
	public void SetFlareActive(bool lightOn) { }

	// RVA: 0x98B2B0 Offset: 0x9898B0 VA: 0x18098B2B0
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x98B110 Offset: 0x989710 VA: 0x18098B110 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x98ABF0 Offset: 0x9891F0 VA: 0x18098ABF0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x98B460 Offset: 0x989A60 VA: 0x18098B460
	public void .ctor() { }

	// RVA: 0x98B410 Offset: 0x989A10 VA: 0x18098B410
	private static void .cctor() { }

}

