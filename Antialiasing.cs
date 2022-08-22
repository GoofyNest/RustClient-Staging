public class Antialiasing : PostEffectsBase // TypeDefIndex: 8150
{	// Fields
	public AAMode mode; // 0x28
	public bool showGeneratedNormals; // 0x2C
	public float offsetScale; // 0x30
	public float blurRadius; // 0x34
	public float edgeThresholdMin; // 0x38
	public float edgeThreshold; // 0x3C
	public float edgeSharpness; // 0x40
	public bool dlaaSharp; // 0x44
	public Shader ssaaShader; // 0x48
	private Material ssaa; // 0x50
	public Shader dlaaShader; // 0x58
	private Material dlaa; // 0x60
	public Shader nfaaShader; // 0x68
	private Material nfaa; // 0x70
	public Shader shaderFXAAPreset2; // 0x78
	private Material materialFXAAPreset2; // 0x80
	public Shader shaderFXAAPreset3; // 0x88
	private Material materialFXAAPreset3; // 0x90
	public Shader shaderFXAAII; // 0x98
	private Material materialFXAAII; // 0xA0
	public Shader shaderFXAAIII; // 0xA8
	private Material materialFXAAIII; // 0xB0

	// Methods

	// RVA: 0x12C9970 Offset: 0x12C7F70 VA: 0x1812C9970
	public Material CurrentAAMaterial() { }

	// RVA: 0x12C97F0 Offset: 0x12C7DF0 VA: 0x1812C97F0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C99E0 Offset: 0x12C7FE0 VA: 0x1812C99E0
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12C9ED0 Offset: 0x12C84D0 VA: 0x1812C9ED0
	public void .ctor() { }

}

