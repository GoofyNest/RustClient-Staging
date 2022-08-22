public class SMAA : MonoBehaviour // TypeDefIndex: 11566
{	// Fields
	public DebugPass DebugPass; // 0x18
	public QualityPreset Quality; // 0x1C
	public EdgeDetectionMethod DetectionMethod; // 0x20
	public bool UsePredication; // 0x24
	public Preset CustomPreset; // 0x28
	public PredicationPreset CustomPredicationPreset; // 0x30
	public Shader Shader; // 0x38
	public Texture2D AreaTex; // 0x40
	public Texture2D SearchTex; // 0x48
	protected Camera m_Camera; // 0x50
	protected Preset m_LowPreset; // 0x58
	protected Preset m_MediumPreset; // 0x60
	protected Preset m_HighPreset; // 0x68
	protected Preset m_UltraPreset; // 0x70
	protected Material m_Material; // 0x78

	// Properties
	public Material Material { get; }

	// Methods

	// RVA: 0x5A5A70 Offset: 0x5A4070 VA: 0x1805A5A70
	public Material get_Material() { }

	// RVA: 0x5A5260 Offset: 0x5A3860 VA: 0x1805A5260
	private void OnEnable() { }

	// RVA: 0x5A5960 Offset: 0x5A3F60 VA: 0x1805A5960
	private void Start() { }

	// RVA: 0x5A51C0 Offset: 0x5A37C0 VA: 0x1805A51C0
	private void OnDisable() { }

	// RVA: 0x5A5370 Offset: 0x5A3970 VA: 0x1805A5370
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x5A4F00 Offset: 0x5A3500 VA: 0x1805A4F00
	private void Clear(RenderTexture rt) { }

	// RVA: 0x5A5A20 Offset: 0x5A4020 VA: 0x1805A5A20
	private RenderTexture TempRT(int width, int height) { }

	// RVA: 0x5A4F80 Offset: 0x5A3580 VA: 0x1805A4F80
	private void CreatePresets() { }

	// RVA: 0x5A5A50 Offset: 0x5A4050 VA: 0x1805A5A50
	public void .ctor() { }

}

