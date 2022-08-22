public class WaterOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 9138
{	// Fields
	public PostProcessVolume postProcessVolume; // 0x18
	public WaterOverlay.EffectParams adminParams; // 0x20
	public WaterOverlay.EffectParams gogglesParams; // 0x40
	public WaterOverlay.EffectParams submarineParams; // 0x60
	public WaterOverlay.EffectParams underwaterLabParams; // 0x80
	public Material[] UnderwaterFogMaterials; // 0xA0
	private WaterOverlay.EffectParams startParams; // 0xA8
	private BlurOptimized blur; // 0xC8
	private Wiggle wiggle; // 0xD0
	private ChromaticAberration chromaticAberration; // 0xD8
	private GodRays godRays; // 0xE0

	// Methods

	// RVA: 0xC19780 Offset: 0xC17D80 VA: 0x180C19780
	protected void Awake() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	protected void OnDestroy() { }

	// RVA: 0xC199F0 Offset: 0xC17FF0 VA: 0x180C199F0
	private WaterOverlay.EffectParams GetEffectParams() { }

	// RVA: 0xC19AE0 Offset: 0xC180E0 VA: 0x180C19AE0
	private void SetEffectParams(WaterOverlay.EffectParams param) { }

	// RVA: 0xC19C30 Offset: 0xC18230 VA: 0x180C19C30
	private void SetUnderwaterFogMaterials(bool fog) { }

	// RVA: 0xC19CD0 Offset: 0xC182D0 VA: 0x180C19CD0
	private void UpdateEffectState() { }

	// RVA: 0xC1A1B0 Offset: 0xC187B0 VA: 0x180C1A1B0
	protected void Update() { }

	// RVA: 0xC1A400 Offset: 0xC18A00 VA: 0x180C1A400
	public void .ctor() { }

}

public struct WaterOverlay.EffectParams // TypeDefIndex: 9139
{	// Fields
	public float scatterCoefficient; // 0x0
	public bool blur; // 0x4
	public float blurDistance; // 0x8
	public float blurSize; // 0xC
	public int blurIterations; // 0x10
	public bool wiggle; // 0x14
	public float wiggleSpeed; // 0x18
	public bool chromaticAberration; // 0x1C
	public bool godRays; // 0x1D
	public static WaterOverlay.EffectParams DefaultAdmin; // 0x0
	public static WaterOverlay.EffectParams DefaultGoggles; // 0x20
	public static WaterOverlay.EffectParams DefaultSubmarine; // 0x40
	public static WaterOverlay.EffectParams DefaultUnderwaterLab; // 0x60

	// Methods

	// RVA: 0xC0FCB0 Offset: 0xC0E2B0 VA: 0x180C0FCB0
	private static void .cctor() { }

}

