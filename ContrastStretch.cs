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

	// RVA: 0x21DA110 Offset: 0x21D8710 VA: 0x1821DA110
	protected Material get_materialLum() { }

	// RVA: 0x21DA1D0 Offset: 0x21D87D0 VA: 0x1821DA1D0
	protected Material get_materialReduce() { }

	// RVA: 0x21D9F90 Offset: 0x21D8590 VA: 0x1821D9F90
	protected Material get_materialAdapt() { }

	// RVA: 0x21DA050 Offset: 0x21D8650 VA: 0x1821DA050
	protected Material get_materialApply() { }

	// RVA: 0x21D9E90 Offset: 0x21D8490 VA: 0x1821D9E90
	private void Start() { }

	// RVA: 0x21D9A20 Offset: 0x21D8020 VA: 0x1821D9A20
	private void OnEnable() { }

	// RVA: 0x21D97B0 Offset: 0x21D7DB0 VA: 0x1821D97B0
	private void OnDisable() { }

	// RVA: 0x21D9B80 Offset: 0x21D8180 VA: 0x1821D9B80
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21D9550 Offset: 0x21D7B50 VA: 0x1821D9550
	private void CalculateAdaptation(Texture curTexture) { }

	// RVA: 0x21D9F20 Offset: 0x21D8520 VA: 0x1821D9F20
	public void .ctor() { }

}

