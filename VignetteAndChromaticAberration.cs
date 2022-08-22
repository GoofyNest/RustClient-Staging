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

	// RVA: 0x21E9DB0 Offset: 0x21E83B0 VA: 0x1821E9DB0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1073E80 Offset: 0x1072480 VA: 0x181073E80 Slot: 5
	public bool IsActive() { }

	// RVA: 0x21E9EB0 Offset: 0x21E84B0 VA: 0x1821E9EB0 Slot: 6
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21EA560 Offset: 0x21E8B60 VA: 0x1821EA560
	public void .ctor() { }

}

public enum VignetteAndChromaticAberration.AberrationMode // TypeDefIndex: 8217
{	// Fields
	public int value__; // 0x0
	public const VignetteAndChromaticAberration.AberrationMode Simple = 0;
	public const VignetteAndChromaticAberration.AberrationMode Advanced = 1;

}

