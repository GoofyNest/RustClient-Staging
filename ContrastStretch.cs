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

	// RVA: 0x21D9F50 Offset: 0x21D8550 VA: 0x1821D9F50
	protected Material get_materialLum() { }

	// RVA: 0x21DA010 Offset: 0x21D8610 VA: 0x1821DA010
	protected Material get_materialReduce() { }

	// RVA: 0x21D9DD0 Offset: 0x21D83D0 VA: 0x1821D9DD0
	protected Material get_materialAdapt() { }

	// RVA: 0x21D9E90 Offset: 0x21D8490 VA: 0x1821D9E90
	protected Material get_materialApply() { }

	// RVA: 0x21D9CD0 Offset: 0x21D82D0 VA: 0x1821D9CD0
	private void Start() { }

	// RVA: 0x21D9860 Offset: 0x21D7E60 VA: 0x1821D9860
	private void OnEnable() { }

	// RVA: 0x21D95F0 Offset: 0x21D7BF0 VA: 0x1821D95F0
	private void OnDisable() { }

	// RVA: 0x21D99C0 Offset: 0x21D7FC0 VA: 0x1821D99C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9390 Offset: 0x21D7990 VA: 0x1821D9390
	private void CalculateAdaptation(Texture curTexture) { }

	// RVA: 0x21D9D60 Offset: 0x21D8360 VA: 0x1821D9D60
	public void .ctor() { }

}

