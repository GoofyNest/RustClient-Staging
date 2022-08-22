public class NVGCamera : FacepunchBehaviour, IClothingChanged // TypeDefIndex: 8676
{	// Fields
	public static NVGCamera instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public GameObject lights; // 0x20
	private bool initalized; // 0x28

	// Methods

	// RVA: 0x7E3FC0 Offset: 0x7E25C0 VA: 0x1807E3FC0
	public void Awake() { }

	// RVA: 0x7E4A20 Offset: 0x7E3020 VA: 0x1807E4A20
	public void Start() { }

	// RVA: 0x7E45C0 Offset: 0x7E2BC0 VA: 0x1807E45C0
	private void OnEnable() { }

	// RVA: 0x7E4510 Offset: 0x7E2B10 VA: 0x1807E4510
	private void OnDisable() { }

	// RVA: 0x7E42A0 Offset: 0x7E28A0 VA: 0x1807E42A0 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x7E41A0 Offset: 0x7E27A0 VA: 0x1807E41A0
	public static bool IsEffectOn() { }

	// RVA: 0x7E4750 Offset: 0x7E2D50 VA: 0x1807E4750
	public static void SetEffectsOn(bool wantsOn, bool fadeOut = True) { }

	// RVA: 0x7E4640 Offset: 0x7E2C40 VA: 0x1807E4640
	public void OnThink() { }

	// RVA: 0x7E4090 Offset: 0x7E2690 VA: 0x1807E4090
	public void FadeOut() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

