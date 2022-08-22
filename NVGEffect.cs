public class NVGEffect : PostEffectsBase, IImageEffect // TypeDefIndex: 8678
{	// Fields
	public NVGEffect.ColorCorrectionParams ColorCorrection1; // 0x28
	public NVGEffect.ColorCorrectionParams ColorCorrection2; // 0x48
	public NVGEffect.NoiseAndGrainParams NoiseAndGrain; // 0x68
	private Texture2D rgbChannelTex1; // 0xA0
	private Texture2D rgbChannelTex2; // 0xA8
	private bool updateTexturesOnStartup; // 0xB0
	public Texture2D NoiseTexture; // 0xB8
	private static float NOISE_TILE_AMOUNT; // 0x0
	public Shader Shader; // 0xC0
	private Material material; // 0xC8

	// Methods

	// RVA: 0x7E4A40 Offset: 0x7E3040 VA: 0x1807E4A40
	private void Awake() { }

	// RVA: 0x7E4CD0 Offset: 0x7E32D0 VA: 0x1807E4CD0
	private void OnDestroy() { }

	// RVA: 0x7E5840 Offset: 0x7E3E40 VA: 0x1807E5840
	private void UpdateColorCorrectionTexture(NVGEffect.ColorCorrectionParams param, ref Texture2D tex) { }

	// RVA: 0x7E5BB0 Offset: 0x7E41B0 VA: 0x1807E5BB0
	public void UpdateTextures() { }

	// RVA: 0x7E4A50 Offset: 0x7E3050 VA: 0x1807E4A50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x7E4C40 Offset: 0x7E3240 VA: 0x1807E4C40 Slot: 5
	public bool IsActive() { }

	// RVA: 0x7E4E80 Offset: 0x7E3480 VA: 0x1807E4E80 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7E5C70 Offset: 0x7E4270 VA: 0x1807E5C70
	public void .ctor() { }

	// RVA: 0x7E5C30 Offset: 0x7E4230 VA: 0x1807E5C30
	private static void .cctor() { }

}

public struct NVGEffect.ColorCorrectionParams // TypeDefIndex: 8679
{	// Fields
	public float saturation; // 0x0
	public AnimationCurve redChannel; // 0x8
	public AnimationCurve greenChannel; // 0x10
	public AnimationCurve blueChannel; // 0x18

}

public struct NVGEffect.NoiseAndGrainParams // TypeDefIndex: 8680
{	// Fields
	public float intensityMultiplier; // 0x0
	public float generalIntensity; // 0x4
	public float blackIntensity; // 0x8
	public float whiteIntensity; // 0xC
	public float midGrey; // 0x10
	public bool monochrome; // 0x14
	public Vector3 intensities; // 0x18
	public Vector3 tiling; // 0x24
	public float monochromeTiling; // 0x30
	public FilterMode filterMode; // 0x34

}

