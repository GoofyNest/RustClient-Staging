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

	// RVA: 0x21DA210 Offset: 0x21D8810 VA: 0x1821DA210
	protected Material get_materialLum() { }

	// RVA: 0x21DA2D0 Offset: 0x21D88D0 VA: 0x1821DA2D0
	protected Material get_materialReduce() { }

	// RVA: 0x21DA090 Offset: 0x21D8690 VA: 0x1821DA090
	protected Material get_materialAdapt() { }

	// RVA: 0x21DA150 Offset: 0x21D8750 VA: 0x1821DA150
	protected Material get_materialApply() { }

	// RVA: 0x21D9F90 Offset: 0x21D8590 VA: 0x1821D9F90
	private void Start() { }

	// RVA: 0x21D9B20 Offset: 0x21D8120 VA: 0x1821D9B20
	private void OnEnable() { }

	// RVA: 0x21D98B0 Offset: 0x21D7EB0 VA: 0x1821D98B0
	private void OnDisable() { }

	// RVA: 0x21D9C80 Offset: 0x21D8280 VA: 0x1821D9C80
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9650 Offset: 0x21D7C50 VA: 0x1821D9650
	private void CalculateAdaptation(Texture curTexture) { }

	// RVA: 0x21DA020 Offset: 0x21D8620 VA: 0x1821DA020
	public void .ctor() { }

}

