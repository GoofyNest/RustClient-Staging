public class ContrastStretch : MonoBehaviour // TypeDefIndex: 8175
{	// Fields
	public float adaptationSpeed; // 0x18
	public float limitMinimum; // 0x1C
	public float limitMaximum; // 0x20
	private RenderTexture[] adaptRenderTex; // 0x28
	private int curAdaptIndex; // 0x30
	public Shader shaderLum; // 0x38
	private Material m_materialLum; // 0x40
	public Shader shaderReduce; // 0x48
	private Material m_materialReduce; // 0x50
	public Shader shaderAdapt; // 0x58
	private Material m_materialAdapt; // 0x60
	public Shader shaderApply; // 0x68
	private Material m_materialApply; // 0x70

	// Properties
	protected Material materialLum { get; }
	protected Material materialReduce { get; }
	protected Material materialAdapt { get; }
	protected Material materialApply { get; }

	// Methods

	// RVA: 0x21DAA30 Offset: 0x21D9030 VA: 0x1821DAA30
	protected Material get_materialLum() { }

	// RVA: 0x21DAAF0 Offset: 0x21D90F0 VA: 0x1821DAAF0
	protected Material get_materialReduce() { }

	// RVA: 0x21DA8B0 Offset: 0x21D8EB0 VA: 0x1821DA8B0
	protected Material get_materialAdapt() { }

	// RVA: 0x21DA970 Offset: 0x21D8F70 VA: 0x1821DA970
	protected Material get_materialApply() { }

	// RVA: 0x21DA7B0 Offset: 0x21D8DB0 VA: 0x1821DA7B0
	private void Start() { }

	// RVA: 0x21DA340 Offset: 0x21D8940 VA: 0x1821DA340
	private void OnEnable() { }

	// RVA: 0x21DA0D0 Offset: 0x21D86D0 VA: 0x1821DA0D0
	private void OnDisable() { }

	// RVA: 0x21DA4A0 Offset: 0x21D8AA0 VA: 0x1821DA4A0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9E70 Offset: 0x21D8470 VA: 0x1821D9E70
	private void CalculateAdaptation(Texture curTexture) { }

	// RVA: 0x21DA840 Offset: 0x21D8E40 VA: 0x1821DA840
	public void .ctor() { }

}

