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

	// RVA: 0x7C6650 Offset: 0x7C4C50 VA: 0x1807C6650
	private void Awake() { }

	// RVA: 0x7C68E0 Offset: 0x7C4EE0 VA: 0x1807C68E0
	private void OnDestroy() { }

	// RVA: 0x7C7450 Offset: 0x7C5A50 VA: 0x1807C7450
	private void UpdateColorCorrectionTexture(NVGEffect.ColorCorrectionParams param, ref Texture2D tex) { }

	// RVA: 0x7C77C0 Offset: 0x7C5DC0 VA: 0x1807C77C0
	public void UpdateTextures() { }

	// RVA: 0x7C6660 Offset: 0x7C4C60 VA: 0x1807C6660 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x7C6850 Offset: 0x7C4E50 VA: 0x1807C6850 Slot: 5
	public bool IsActive() { }

	// RVA: 0x7C6A90 Offset: 0x7C5090 VA: 0x1807C6A90 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7C7880 Offset: 0x7C5E80 VA: 0x1807C7880
	public void .ctor() { }

	// RVA: 0x7C7840 Offset: 0x7C5E40 VA: 0x1807C7840
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

