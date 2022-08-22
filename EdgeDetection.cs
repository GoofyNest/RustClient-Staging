public class EdgeDetection : PostEffectsBase // TypeDefIndex: 8186
{	// Fields
	public EdgeDetection.EdgeDetectMode mode; // 0x28
	public float sensitivityDepth; // 0x2C
	public float sensitivityNormals; // 0x30
	public float lumThreshold; // 0x34
	public float edgeExp; // 0x38
	public float sampleDist; // 0x3C
	public float edgesOnly; // 0x40
	public Color edgesOnlyBgColor; // 0x44
	public Shader edgeDetectShader; // 0x58
	private Material edgeDetectMaterial; // 0x60
	private EdgeDetection.EdgeDetectMode oldMode; // 0x68

	// Methods

	// RVA: 0x21E0030 Offset: 0x21DE630 VA: 0x1821E0030 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E03B0 Offset: 0x21DE9B0 VA: 0x1821E03B0
	private void Start() { }

	// RVA: 0x21E0300 Offset: 0x21DE900 VA: 0x1821E0300
	private void SetCameraFlag() { }

	// RVA: 0x21E00B0 Offset: 0x21DE6B0 VA: 0x1821E00B0
	private void OnEnable() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21E00C0 Offset: 0x21DE6C0 VA: 0x1821E00C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E03C0 Offset: 0x21DE9C0 VA: 0x1821E03C0
	public void .ctor() { }

}

public enum EdgeDetection.EdgeDetectMode // TypeDefIndex: 8187
{	// Fields
	public int value__; // 0x0
	public const EdgeDetection.EdgeDetectMode TriangleDepthNormals = 0;
	public const EdgeDetection.EdgeDetectMode RobertsCrossDepthNormals = 1;
	public const EdgeDetection.EdgeDetectMode SobelDepth = 2;
	public const EdgeDetection.EdgeDetectMode SobelDepthThin = 3;
	public const EdgeDetection.EdgeDetectMode TriangleLuminance = 4;

}

