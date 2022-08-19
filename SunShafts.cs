public class SunShafts : PostEffectsBase // TypeDefIndex: 8205
{	// Fields
	public SunShafts.SunShaftsResolution resolution; // 0x28
	public SunShafts.ShaftsScreenBlendMode screenBlendMode; // 0x2C
	public Transform sunTransform; // 0x30
	public int radialBlurIterations; // 0x38
	public Color sunColor; // 0x3C
	public Color sunThreshold; // 0x4C
	public float sunShaftBlurRadius; // 0x5C
	public float sunShaftIntensity; // 0x60
	public float maxRadius; // 0x64
	public bool useDepthTexture; // 0x68
	public Shader sunShaftsShader; // 0x70
	private Material sunShaftsMaterial; // 0x78
	public Shader simpleClearShader; // 0x80
	private Material simpleClearMaterial; // 0x88

	// Methods

	// RVA: 0x21E70A0 Offset: 0x21E56A0 VA: 0x1821E70A0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E7130 Offset: 0x21E5730 VA: 0x1821E7130
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E7B70 Offset: 0x21E6170 VA: 0x1821E7B70
	public void .ctor() { }

}

public enum SunShafts.SunShaftsResolution // TypeDefIndex: 8206
{	// Fields
	public int value__; // 0x0
	public const SunShafts.SunShaftsResolution Low = 0;
	public const SunShafts.SunShaftsResolution Normal = 1;
	public const SunShafts.SunShaftsResolution High = 2;

}

public enum SunShafts.ShaftsScreenBlendMode // TypeDefIndex: 8207
{	// Fields
	public int value__; // 0x0
	public const SunShafts.ShaftsScreenBlendMode Screen = 0;
	public const SunShafts.ShaftsScreenBlendMode Add = 1;

}

