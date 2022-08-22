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

	// RVA: 0x12CAD70 Offset: 0x12C9370 VA: 0x1812CAD70
	private void Start() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Awake() { }

	// RVA: 0x12CA740 Offset: 0x12C8D40 VA: 0x1812CA740 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12CAD90 Offset: 0x12C9390 VA: 0x1812CAD90
	public void UpdateParameters() { }

	// RVA: 0x12CB2E0 Offset: 0x12C98E0 VA: 0x1812CB2E0
	private void UpdateTextures() { }

	// RVA: 0x1074140 Offset: 0x1072740 VA: 0x181074140 Slot: 5
	public bool IsActive() { }

	// RVA: 0x12CAA60 Offset: 0x12C9060 VA: 0x1812CAA60 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CB2F0 Offset: 0x12C98F0 VA: 0x1812CB2F0
	public void .ctor() { }

}

public enum ColorCorrectionCurves.ColorCorrectionMode // TypeDefIndex: 8171
{	// Fields
	public int value__; // 0x0
	public const ColorCorrectionCurves.ColorCorrectionMode Simple = 0;
	public const ColorCorrectionCurves.ColorCorrectionMode Advanced = 1;

}

