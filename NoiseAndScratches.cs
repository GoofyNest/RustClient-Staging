public class NoiseAndScratches : MonoBehaviour // TypeDefIndex: 8195
{	// Fields
	public bool monochrome; // 0x18
	private bool rgbFallback; // 0x19
	public float grainIntensityMin; // 0x1C
	public float grainIntensityMax; // 0x20
	public float grainSize; // 0x24
	public float scratchIntensityMin; // 0x28
	public float scratchIntensityMax; // 0x2C
	public float scratchFPS; // 0x30
	public float scratchJitter; // 0x34
	public Texture grainTexture; // 0x38
	public Texture scratchTexture; // 0x40
	public Shader shaderRGB; // 0x48
	public Shader shaderYUV; // 0x50
	private Material m_MaterialRGB; // 0x58
	private Material m_MaterialYUV; // 0x60
	private float scratchTimeLeft; // 0x68
	private float scratchX; // 0x6C
	private float scratchY; // 0x70

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21E31E0 Offset: 0x21E17E0 VA: 0x1821E31E0
	protected void Start() { }

	// RVA: 0x21E3340 Offset: 0x21E1940 VA: 0x1821E3340
	protected Material get_material() { }

	// RVA: 0x21E2990 Offset: 0x21E0F90 VA: 0x1821E2990
	protected void OnDisable() { }

	// RVA: 0x21E30B0 Offset: 0x21E16B0 VA: 0x1821E30B0
	private void SanitizeParameters() { }

	// RVA: 0x21E2A80 Offset: 0x21E1080 VA: 0x1821E2A80
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E3300 Offset: 0x21E1900 VA: 0x1821E3300
	public void .ctor() { }

}

