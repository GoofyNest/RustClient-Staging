public class VignetteAndChromaticAberration : PostEffectsBase, IImageEffect // TypeDefIndex: 8216
{	// Fields
	public VignetteAndChromaticAberration.AberrationMode mode; // 0x28
	public float intensity; // 0x2C
	public float chromaticAberration; // 0x30
	public float axialAberration; // 0x34
	public float blur; // 0x38
	public float blurSpread; // 0x3C
	public float luminanceDependency; // 0x40
	public float blurDistance; // 0x44
	public Shader vignetteShader; // 0x48
	public Shader separableBlurShader; // 0x50
	public Shader chromAberrationShader; // 0x58
	private Material m_VignetteMaterial; // 0x60
	private Material m_SeparableBlurMaterial; // 0x68
	private Material m_ChromAberrationMaterial; // 0x70

	// Methods

	// RVA: 0x21EA070 Offset: 0x21E8670 VA: 0x1821EA070 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1074140 Offset: 0x1072740 VA: 0x181074140 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21EA170 Offset: 0x21E8770 VA: 0x1821EA170 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21EA820 Offset: 0x21E8E20 VA: 0x1821EA820
	public void .ctor() { }

}

public enum VignetteAndChromaticAberration.AberrationMode // TypeDefIndex: 8217
{	// Fields
	public int value__; // 0x0
	public const VignetteAndChromaticAberration.AberrationMode Simple = 0;
	public const VignetteAndChromaticAberration.AberrationMode Advanced = 1;

}

