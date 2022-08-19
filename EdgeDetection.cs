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

	// RVA: 0x21DF710 Offset: 0x21DDD10 VA: 0x1821DF710 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DFA90 Offset: 0x21DE090 VA: 0x1821DFA90
	private void Start() { }

	// RVA: 0x21DF9E0 Offset: 0x21DDFE0 VA: 0x1821DF9E0
	private void SetCameraFlag() { }

	// RVA: 0x21DF790 Offset: 0x21DDD90 VA: 0x1821DF790
	private void OnEnable() { }

	[ImageEffectOpaque] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21DF7A0 Offset: 0x21DDDA0 VA: 0x1821DF7A0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DFAA0 Offset: 0x21DE0A0 VA: 0x1821DFAA0
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

