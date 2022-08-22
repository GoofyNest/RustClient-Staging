public class NVGCamera : FacepunchBehaviour, IClothingChanged // TypeDefIndex: 8676
{	// Fields
	public static NVGCamera instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public GameObject lights; // 0x20
	private bool initalized; // 0x28

	// Methods

	// RVA: 0x7C5BD0 Offset: 0x7C41D0 VA: 0x1807C5BD0
	public void Awake() { }

	// RVA: 0x7C6630 Offset: 0x7C4C30 VA: 0x1807C6630
	public void Start() { }

	// RVA: 0x7C61D0 Offset: 0x7C47D0 VA: 0x1807C61D0
	private void OnEnable() { }

	// RVA: 0x7C6120 Offset: 0x7C4720 VA: 0x1807C6120
	private void OnDisable() { }

	// RVA: 0x7C5EB0 Offset: 0x7C44B0 VA: 0x1807C5EB0 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x7C5DB0 Offset: 0x7C43B0 VA: 0x1807C5DB0
	public static bool IsEffectOn() { }

	// RVA: 0x7C6360 Offset: 0x7C4960 VA: 0x1807C6360
	public static void SetEffectsOn(bool wantsOn, bool fadeOut = True) { }

	// RVA: 0x7C6250 Offset: 0x7C4850 VA: 0x1807C6250
	public void OnThink() { }

	// RVA: 0x7C5CA0 Offset: 0x7C42A0 VA: 0x1807C5CA0
	public void FadeOut() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

