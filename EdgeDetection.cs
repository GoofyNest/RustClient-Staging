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

	// RVA: 0x21DF550 Offset: 0x21DDB50 VA: 0x1821DF550 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DF8D0 Offset: 0x21DDED0 VA: 0x1821DF8D0
	private void Start() { }

	// RVA: 0x21DF820 Offset: 0x21DDE20 VA: 0x1821DF820
	private void SetCameraFlag() { }

	// RVA: 0x21DF5D0 Offset: 0x21DDBD0 VA: 0x1821DF5D0
	private void OnEnable() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21DF5E0 Offset: 0x21DDBE0 VA: 0x1821DF5E0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DF8E0 Offset: 0x21DDEE0 VA: 0x1821DF8E0
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

