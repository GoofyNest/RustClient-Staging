internal class ScreenSpaceAmbientObscurance : PostEffectsBase // TypeDefIndex: 8201
{	// Fields
	[RangeAttribute] // RVA: 0x84500 Offset: 0x83900 VA: 0x180084500
	public float intensity; // 0x28
	[RangeAttribute] // RVA: 0x858C0 Offset: 0x84CC0 VA: 0x1800858C0
	public float radius; // 0x2C
	[RangeAttribute] // RVA: 0x84500 Offset: 0x83900 VA: 0x180084500
	public int blurIterations; // 0x30
	[RangeAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	public float blurFilterDistance; // 0x34
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public int downsample; // 0x38
	public Texture2D rand; // 0x40
	public Shader aoShader; // 0x48
	private Material aoMaterial; // 0x50

	// Methods

	// RVA: 0x21E5C70 Offset: 0x21E4270 VA: 0x1821E5C70 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E5CD0 Offset: 0x21E42D0 VA: 0x1821E5CD0
	private void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21E5D80 Offset: 0x21E4380 VA: 0x1821E5D80
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E6470 Offset: 0x21E4A70 VA: 0x1821E6470
	public void .ctor() { }

}

public class ScreenSpaceAmbientOcclusion : MonoBehaviour // TypeDefIndex: 8202
{	// Fields
	public float m_Radius; // 0x18
	public ScreenSpaceAmbientOcclusion.SSAOSamples m_SampleCount; // 0x1C
	public float m_OcclusionIntensity; // 0x20
	public int m_Blur; // 0x24
	public int m_Downsampling; // 0x28
	public float m_OcclusionAttenuation; // 0x2C
	public float m_MinZ; // 0x30
	public Shader m_SSAOShader; // 0x38
	private Material m_SSAOMaterial; // 0x40
	public Texture2D m_RandomTexture; // 0x48
	private bool m_Supported; // 0x50

	// Methods

	// RVA: 0x21E64B0 Offset: 0x21E4AB0 VA: 0x1821E64B0
	private static Material CreateMaterial(Shader shader) { }

	// RVA: 0x21E66B0 Offset: 0x21E4CB0 VA: 0x1821E66B0
	private static void DestroyMaterial(Material mat) { }

	// RVA: 0x21E6740 Offset: 0x21E4D40 VA: 0x1821E6740
	private void OnDisable() { }

	// RVA: 0x21E7020 Offset: 0x21E5620 VA: 0x1821E7020
	private void Start() { }

	// RVA: 0x21E67D0 Offset: 0x21E4DD0 VA: 0x1821E67D0
	private void OnEnable() { }

	// RVA: 0x21E6560 Offset: 0x21E4B60 VA: 0x1821E6560
	private void CreateMaterials() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21E6830 Offset: 0x21E4E30 VA: 0x1821E6830
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E70E0 Offset: 0x21E56E0 VA: 0x1821E70E0
	public void .ctor() { }

}

public enum ScreenSpaceAmbientOcclusion.SSAOSamples // TypeDefIndex: 8203
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceAmbientOcclusion.SSAOSamples Low = 0;
	public const ScreenSpaceAmbientOcclusion.SSAOSamples Medium = 1;
	public const ScreenSpaceAmbientOcclusion.SSAOSamples High = 2;

}

public enum ScreenSpaceReflectionPreset // TypeDefIndex: 11800
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionPreset Lower = 0;
	public const ScreenSpaceReflectionPreset Low = 1;
	public const ScreenSpaceReflectionPreset Medium = 2;
	public const ScreenSpaceReflectionPreset High = 3;
	public const ScreenSpaceReflectionPreset Higher = 4;
	public const ScreenSpaceReflectionPreset Ultra = 5;
	public const ScreenSpaceReflectionPreset Overkill = 6;
	public const ScreenSpaceReflectionPreset Custom = 7;

}

public enum ScreenSpaceReflectionResolution // TypeDefIndex: 11801
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionResolution Downsampled = 0;
	public const ScreenSpaceReflectionResolution FullSize = 1;
	public const ScreenSpaceReflectionResolution Supersampled = 2;

}

public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset> // TypeDefIndex: 11802
{	// Methods

	// RVA: 0x11DCDE0 Offset: 0x11DB3E0 VA: 0x1811DCDE0
	public void .ctor() { }

}

public sealed class ScreenSpaceReflectionResolutionParameter : ParameterOverride<ScreenSpaceReflectionResolution> // TypeDefIndex: 11803
{	// Methods

	// RVA: 0x11DCE20 Offset: 0x11DB420 VA: 0x1811DCE20
	public void .ctor() { }

}

public sealed class ScreenSpaceReflections : PostProcessEffectSettings // TypeDefIndex: 11804
{	// Fields
	[TooltipAttribute] // RVA: 0x75740 Offset: 0x74B40 VA: 0x180075740
	public ScreenSpaceReflectionPresetParameter preset; // 0x30
	[RangeAttribute] // RVA: 0x75920 Offset: 0x74D20 VA: 0x180075920
	[TooltipAttribute] // RVA: 0x75920 Offset: 0x74D20 VA: 0x180075920
	public IntParameter maximumIterationCount; // 0x38
	[TooltipAttribute] // RVA: 0x75A90 Offset: 0x74E90 VA: 0x180075A90
	public ScreenSpaceReflectionResolutionParameter resolution; // 0x40
	[RangeAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	[TooltipAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public FloatParameter thickness; // 0x48
	[TooltipAttribute] // RVA: 0x75EE0 Offset: 0x752E0 VA: 0x180075EE0
	public FloatParameter maximumMarchDistance; // 0x50
	[RangeAttribute] // RVA: 0x76020 Offset: 0x75420 VA: 0x180076020
	[TooltipAttribute] // RVA: 0x76020 Offset: 0x75420 VA: 0x180076020
	public FloatParameter distanceFade; // 0x58
	[RangeAttribute] // RVA: 0x76150 Offset: 0x75550 VA: 0x180076150
	[TooltipAttribute] // RVA: 0x76150 Offset: 0x75550 VA: 0x180076150
	public FloatParameter vignette; // 0x60

	// Methods

	// RVA: 0x11DEC40 Offset: 0x11DD240 VA: 0x1811DEC40 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x11DEDB0 Offset: 0x11DD3B0 VA: 0x1811DEDB0
	public void .ctor() { }

}

internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections> // TypeDefIndex: 11805
{	// Fields
	private RenderTexture m_Resolve; // 0x20
	private RenderTexture m_History; // 0x28
	private int[] m_MipIDs; // 0x30
	private readonly ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets; // 0x38

	// Methods

	// RVA: 0x6F3610 Offset: 0x6F1C10 VA: 0x1806F3610 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x11DCE60 Offset: 0x11DB460 VA: 0x1811DCE60
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	// RVA: 0x11DD100 Offset: 0x11DB700 VA: 0x1811DD100 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11DD060 Offset: 0x11DB660 VA: 0x1811DD060 Slot: 7
	public override void Release() { }

	// RVA: 0x11DE810 Offset: 0x11DCE10 VA: 0x1811DE810
	public void .ctor() { }

}

private class ScreenSpaceReflectionsRenderer.QualityPreset // TypeDefIndex: 11806
{	// Fields
	public int maximumIterationCount; // 0x10
	public float thickness; // 0x14
	public ScreenSpaceReflectionResolution downsampling; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private enum ScreenSpaceReflectionsRenderer.Pass // TypeDefIndex: 11807
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionsRenderer.Pass Test = 0;
	public const ScreenSpaceReflectionsRenderer.Pass Resolve = 1;
	public const ScreenSpaceReflectionsRenderer.Pass Reproject = 2;
	public const ScreenSpaceReflectionsRenderer.Pass Composite = 3;

}

