public class NVGCamera : FacepunchBehaviour, IClothingChanged // TypeDefIndex: 8676
{	// Fields
	public static NVGCamera instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public GameObject lights; // 0x20
	private bool initalized; // 0x28

	// Methods

	// RVA: 0x7C5AC0 Offset: 0x7C40C0 VA: 0x1807C5AC0
	public void Awake() { }

	// RVA: 0x7C6520 Offset: 0x7C4B20 VA: 0x1807C6520
	public void Start() { }

	// RVA: 0x7C60C0 Offset: 0x7C46C0 VA: 0x1807C60C0
	private void OnEnable() { }

	// RVA: 0x7C6010 Offset: 0x7C4610 VA: 0x1807C6010
	private void OnDisable() { }

	// RVA: 0x7C5DA0 Offset: 0x7C43A0 VA: 0x1807C5DA0 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x7C5CA0 Offset: 0x7C42A0 VA: 0x1807C5CA0
	public static bool IsEffectOn() { }

	// RVA: 0x7C6250 Offset: 0x7C4850 VA: 0x1807C6250
	public static void SetEffectsOn(bool wantsOn, bool fadeOut = True) { }

	// RVA: 0x7C6140 Offset: 0x7C4740 VA: 0x1807C6140
	public void OnThink() { }

	// RVA: 0x7C5B90 Offset: 0x7C4190 VA: 0x1807C5B90
	public void FadeOut() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

