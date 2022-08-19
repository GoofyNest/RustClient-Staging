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

	// RVA: 0x5A5AE0 Offset: 0x5A40E0 VA: 0x1805A5AE0
	public Material get_Material() { }

	// RVA: 0x5A52D0 Offset: 0x5A38D0 VA: 0x1805A52D0
	private void OnEnable() { }

	// RVA: 0x5A59D0 Offset: 0x5A3FD0 VA: 0x1805A59D0
	private void Start() { }

	// RVA: 0x5A5230 Offset: 0x5A3830 VA: 0x1805A5230
	private void OnDisable() { }

	// RVA: 0x5A53E0 Offset: 0x5A39E0 VA: 0x1805A53E0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x5A4F70 Offset: 0x5A3570 VA: 0x1805A4F70
	private void Clear(RenderTexture rt) { }

	// RVA: 0x5A5A90 Offset: 0x5A4090 VA: 0x1805A5A90
	private RenderTexture TempRT(int width, int height) { }

	// RVA: 0x5A4FF0 Offset: 0x5A35F0 VA: 0x1805A4FF0
	private void CreatePresets() { }

	// RVA: 0x5A5AC0 Offset: 0x5A40C0 VA: 0x1805A5AC0
	public void .ctor() { }

}

