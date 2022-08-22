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

	// RVA: 0x98B420 Offset: 0x989A20 VA: 0x18098B420
	private float GetDistance() { }

	// RVA: 0x98AEE0 Offset: 0x9894E0 VA: 0x18098AEE0
	protected void Awake() { }

	// RVA: 0x98B570 Offset: 0x989B70 VA: 0x18098B570
	protected void OnEnable() { }

	// RVA: 0x98B4A0 Offset: 0x989AA0 VA: 0x18098B4A0
	protected void OnDisable() { }

	// RVA: 0x98B7E0 Offset: 0x989DE0 VA: 0x18098B7E0
	private void UpdateMaterialPropertyBlock() { }

	// RVA: 0x98B7C0 Offset: 0x989DC0 VA: 0x18098B7C0
	private void ToggleFlare(bool state) { }

	// RVA: 0x98B280 Offset: 0x989880 VA: 0x18098B280
	private void FadingToggle() { }

	// RVA: 0x98B6A0 Offset: 0x989CA0 VA: 0x18098B6A0
	public void SetFlareActive(bool lightOn) { }

	// RVA: 0x98B7B0 Offset: 0x989DB0 VA: 0x18098B7B0
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x98B610 Offset: 0x989C10 VA: 0x18098B610 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x98B0F0 Offset: 0x9896F0 VA: 0x18098B0F0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x98B960 Offset: 0x989F60 VA: 0x18098B960
	public void .ctor() { }

	// RVA: 0x98B910 Offset: 0x989F10 VA: 0x18098B910
	private static void .cctor() { }

}

