public class ColorCorrectionCurves : PostEffectsBase, IImageEffect // TypeDefIndex: 8170
{	// Fields
	public AnimationCurve redChannel; // 0x28
	public AnimationCurve greenChannel; // 0x30
	public AnimationCurve blueChannel; // 0x38
	public bool useDepthCorrection; // 0x40
	public AnimationCurve zCurve; // 0x48
	public AnimationCurve depthRedChannel; // 0x50
	public AnimationCurve depthGreenChannel; // 0x58
	public AnimationCurve depthBlueChannel; // 0x60
	private Material ccMaterial; // 0x68
	private Material ccDepthMaterial; // 0x70
	private Material selectiveCcMaterial; // 0x78
	private Texture2D rgbChannelTex; // 0x80
	private Texture2D rgbDepthChannelTex; // 0x88
	private Texture2D zCurveTex; // 0x90
	public float saturation; // 0x98
	public bool selectiveCc; // 0x9C
	public Color selectiveFromColor; // 0xA0
	public Color selectiveToColor; // 0xB0
	public ColorCorrectionCurves.ColorCorrectionMode mode; // 0xC0
	public bool updateTextures; // 0xC4
	public Shader colorCorrectionCurvesShader; // 0xC8
	public Shader simpleColorCorrectionCurvesShader; // 0xD0
	public Shader colorCorrectionSelectiveShader; // 0xD8
	private bool updateTexturesOnStartup; // 0xE0

	// Methods

	// RVA: 0x12D1220 Offset: 0x12CF820 VA: 0x1812D1220
	private void Start() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Awake() { }

	// RVA: 0x12D0BF0 Offset: 0x12CF1F0 VA: 0x1812D0BF0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12D1240 Offset: 0x12CF840 VA: 0x1812D1240
	public void UpdateParameters() { }

	// RVA: 0x12D1790 Offset: 0x12CFD90 VA: 0x1812D1790
	private void UpdateTextures() { }

	// RVA: 0x1074BB0 Offset: 0x10731B0 VA: 0x181074BB0 Slot: 5
	public bool IsActive() { }

	// RVA: 0x12D0F10 Offset: 0x12CF510 VA: 0x1812D0F10 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12D17A0 Offset: 0x12CFDA0 VA: 0x1812D17A0
	public void .ctor() { }

}

public enum ColorCorrectionCurves.ColorCorrectionMode // TypeDefIndex: 8171
{	// Fields
	public int value__; // 0x0
	public const ColorCorrectionCurves.ColorCorrectionMode Simple = 0;
	public const ColorCorrectionCurves.ColorCorrectionMode Advanced = 1;

}

