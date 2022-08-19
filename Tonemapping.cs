public class Tonemapping : PostEffectsBase // TypeDefIndex: 8211
{	// Fields
	public Tonemapping.TonemapperType type; // 0x28
	public Tonemapping.AdaptiveTexSize adaptiveTextureSize; // 0x2C
	public AnimationCurve remapCurve; // 0x30
	private Texture2D curveTex; // 0x38
	public float exposureAdjustment; // 0x40
	public float middleGrey; // 0x44
	public float white; // 0x48
	public float adaptionSpeed; // 0x4C
	public Shader tonemapper; // 0x50
	public bool validRenderTextureFormat; // 0x58
	private Material tonemapMaterial; // 0x60
	private RenderTexture rt; // 0x68
	private RenderTextureFormat rtFormat; // 0x70

	// Methods

	// RVA: 0x21E7F50 Offset: 0x21E6550 VA: 0x1821E7F50 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E8D70 Offset: 0x21E7370 VA: 0x1821E8D70
	public float UpdateCurve() { }

	// RVA: 0x21E8230 Offset: 0x21E6830 VA: 0x1821E8230
	private void OnDisable() { }

	// RVA: 0x21E8120 Offset: 0x21E6720 VA: 0x1821E8120
	private bool CreateInternalRenderTexture() { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21E83C0 Offset: 0x21E69C0 VA: 0x1821E83C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E90D0 Offset: 0x21E76D0 VA: 0x1821E90D0
	public void .ctor() { }

}

public enum Tonemapping.TonemapperType // TypeDefIndex: 8212
{	// Fields
	public int value__; // 0x0
	public const Tonemapping.TonemapperType SimpleReinhard = 0;
	public const Tonemapping.TonemapperType UserCurve = 1;
	public const Tonemapping.TonemapperType Hable = 2;
	public const Tonemapping.TonemapperType Photographic = 3;
	public const Tonemapping.TonemapperType OptimizedHejiDawson = 4;
	public const Tonemapping.TonemapperType AdaptiveReinhard = 5;
	public const Tonemapping.TonemapperType AdaptiveReinhardAutoWhite = 6;

}

public enum Tonemapping.AdaptiveTexSize // TypeDefIndex: 8213
{	// Fields
	public int value__; // 0x0
	public const Tonemapping.AdaptiveTexSize Square16 = 16;
	public const Tonemapping.AdaptiveTexSize Square32 = 32;
	public const Tonemapping.AdaptiveTexSize Square64 = 64;
	public const Tonemapping.AdaptiveTexSize Square128 = 128;
	public const Tonemapping.AdaptiveTexSize Square256 = 256;
	public const Tonemapping.AdaptiveTexSize Square512 = 512;
	public const Tonemapping.AdaptiveTexSize Square1024 = 1024;

}

public class TonemappingOverlay : ImageEffectLayer // TypeDefIndex: 9137
{	// Fields
	public TonemappingColorGrading tonemapping; // 0x30
	private int screenWidth; // 0x38
	private int screenHeight; // 0x3C

	// Methods

	// RVA: 0x88DBB0 Offset: 0x88C1B0 VA: 0x18088DBB0
	public void Awake() { }

	// RVA: 0x88DC00 Offset: 0x88C200 VA: 0x18088DC00 Slot: 4
	public override void Start() { }

	// RVA: 0x88DBC0 Offset: 0x88C1C0 VA: 0x18088DBC0
	private void ResetColorGrading() { }

	// RVA: 0x88DC40 Offset: 0x88C240 VA: 0x18088DC40
	protected void Update() { }

	// RVA: 0x88DD60 Offset: 0x88C360 VA: 0x18088DD60
	public void .ctor() { }

}

public class TonemappingColorGrading : MonoBehaviour // TypeDefIndex: 11655
{	// Fields
	[SerializeField] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation; // 0x18
	[SerializeField] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	private TonemappingColorGrading.TonemappingSettings m_Tonemapping; // 0x30
	[SerializeField] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	private TonemappingColorGrading.ColorGradingSettings m_ColorGrading; // 0x60
	[SerializeField] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	private TonemappingColorGrading.LUTSettings m_Lut; // 0xF8
	private Texture2D m_IdentityLut; // 0x110
	private RenderTexture m_InternalLut; // 0x118
	private Texture2D m_CurveTexture; // 0x120
	private Texture2D m_TonemapperCurve; // 0x128
	private float m_TonemapperCurveRange; // 0x130
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Shader m_Shader; // 0x138
	private Material m_Material; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <validRenderTextureFormat>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <validUserLutSize>k__BackingField; // 0x149
	private bool m_Dirty; // 0x14A
	private bool m_TonemapperDirty; // 0x14B
	private RenderTexture m_SmallAdaptiveRt; // 0x150
	private RenderTextureFormat m_AdaptiveRtFormat; // 0x158
	private RenderTexture[] rts; // 0x160

	// Properties
	public TonemappingColorGrading.EyeAdaptationSettings eyeAdaptation { get; set; }
	public TonemappingColorGrading.TonemappingSettings tonemapping { get; set; }
	public TonemappingColorGrading.ColorGradingSettings colorGrading { get; set; }
	public TonemappingColorGrading.LUTSettings lut { get; set; }
	private Texture2D identityLut { get; }
	private RenderTexture internalLutRt { get; }
	private Texture2D curveTexture { get; }
	private Texture2D tonemapperCurve { get; }
	public Shader shader { get; }
	public Material material { get; }
	public bool isGammaColorSpace { get; }
	public int lutSize { get; }
	public bool validRenderTextureFormat { get; set; }
	public bool validUserLutSize { get; set; }

	// Methods

	// RVA: 0x1127630 Offset: 0x1125C30 VA: 0x181127630
	public TonemappingColorGrading.EyeAdaptationSettings get_eyeAdaptation() { }

	// RVA: 0x1127D70 Offset: 0x1126370 VA: 0x181127D70
	public void set_eyeAdaptation(TonemappingColorGrading.EyeAdaptationSettings value) { }

	// RVA: 0x1127C90 Offset: 0x1126290 VA: 0x181127C90
	public TonemappingColorGrading.TonemappingSettings get_tonemapping() { }

	// RVA: 0x1127DC0 Offset: 0x11263C0 VA: 0x181127DC0
	public void set_tonemapping(TonemappingColorGrading.TonemappingSettings value) { }

	// RVA: 0x1127490 Offset: 0x1125A90 VA: 0x181127490
	public TonemappingColorGrading.ColorGradingSettings get_colorGrading() { }

	// RVA: 0x1127CD0 Offset: 0x11262D0 VA: 0x181127CD0
	public void set_colorGrading(TonemappingColorGrading.ColorGradingSettings value) { }

	// RVA: 0x1127950 Offset: 0x1125F50 VA: 0x181127950
	public TonemappingColorGrading.LUTSettings get_lut() { }

	// RVA: 0x1127D90 Offset: 0x1126390 VA: 0x181127D90
	public void set_lut(TonemappingColorGrading.LUTSettings value) { }

	// RVA: 0x1127650 Offset: 0x1125C50 VA: 0x181127650
	private Texture2D get_identityLut() { }

	// RVA: 0x1127750 Offset: 0x1125D50 VA: 0x181127750
	private RenderTexture get_internalLutRt() { }

	// RVA: 0x1127510 Offset: 0x1125B10 VA: 0x181127510
	private Texture2D get_curveTexture() { }

	// RVA: 0x1127B40 Offset: 0x1126140 VA: 0x181127B40
	private Texture2D get_tonemapperCurve() { }

	// RVA: 0x1127AA0 Offset: 0x11260A0 VA: 0x181127AA0
	public Shader get_shader() { }

	// RVA: 0x1127970 Offset: 0x1125F70 VA: 0x181127970
	public Material get_material() { }

	// RVA: 0x1127910 Offset: 0x1125F10 VA: 0x181127910
	public bool get_isGammaColorSpace() { }

	// RVA: 0x1127930 Offset: 0x1125F30 VA: 0x181127930
	public int get_lutSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1127CB0 Offset: 0x11262B0 VA: 0x181127CB0
	public bool get_validRenderTextureFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1127E00 Offset: 0x1126400 VA: 0x181127E00
	private void set_validRenderTextureFormat(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1127CC0 Offset: 0x11262C0 VA: 0x181127CC0
	public bool get_validUserLutSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1127E10 Offset: 0x1126410 VA: 0x181127E10
	private void set_validUserLutSize(bool value) { }

	// RVA: 0x1127280 Offset: 0x1125880 VA: 0x181127280
	public void SetDirty() { }

	// RVA: 0x1127290 Offset: 0x1125890 VA: 0x181127290
	public void SetTonemapperDirty() { }

	// RVA: 0x1125850 Offset: 0x1123E50 VA: 0x181125850
	private void OnEnable() { }

	// RVA: 0x1125510 Offset: 0x1123B10 VA: 0x181125510
	private void OnDisable() { }

	// RVA: 0x1127270 Offset: 0x1125870 VA: 0x181127270
	private void OnValidate() { }

	// RVA: 0x1124BE0 Offset: 0x11231E0 VA: 0x181124BE0
	private static Texture2D GenerateIdentityLut(int dim) { }

	// RVA: 0x11272A0 Offset: 0x11258A0 VA: 0x1811272A0
	private float StandardIlluminantY(float x) { }

	// RVA: 0x1124690 Offset: 0x1122C90 VA: 0x181124690
	private Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x1125260 Offset: 0x1123860 VA: 0x181125260
	private Vector3 GetWhiteBalance() { }

	// RVA: 0x1125410 Offset: 0x1123A10 VA: 0x181125410
	private static Color NormalizeColor(Color c) { }

	// RVA: 0x1124E80 Offset: 0x1123480 VA: 0x181124E80
	private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain) { }

	// RVA: 0x1124920 Offset: 0x1122F20 VA: 0x181124920
	private void GenCurveTexture() { }

	// RVA: 0x1124840 Offset: 0x1122E40 VA: 0x181124840
	private bool CheckUserLut() { }

	// RVA: 0x1124730 Offset: 0x1122D30 VA: 0x181124730
	private bool CheckSmallAdaptiveRt() { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x11258A0 Offset: 0x1123EA0 VA: 0x1811258A0
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1124500 Offset: 0x1122B00 VA: 0x181124500
	public Texture2D BakeLUT() { }

	// RVA: 0x11272D0 Offset: 0x11258D0 VA: 0x1811272D0
	public void .ctor() { }

}

public class TonemappingColorGrading.SettingsGroup : Attribute // TypeDefIndex: 11656
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class TonemappingColorGrading.IndentedGroup : PropertyAttribute // TypeDefIndex: 11657
{	// Methods

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public class TonemappingColorGrading.ChannelMixer : PropertyAttribute // TypeDefIndex: 11658
{	// Methods

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public class TonemappingColorGrading.ColorWheelGroup : PropertyAttribute // TypeDefIndex: 11659
{	// Fields
	public int minSizePerWheel; // 0x10
	public int maxSizePerWheel; // 0x14

	// Methods

	// RVA: 0x111D300 Offset: 0x111B900 VA: 0x18111D300
	public void .ctor() { }

	// RVA: 0x111D320 Offset: 0x111B920 VA: 0x18111D320
	public void .ctor(int minSizePerWheel, int maxSizePerWheel) { }

}

public class TonemappingColorGrading.Curve : PropertyAttribute // TypeDefIndex: 11660
{	// Fields
	public Color color; // 0x10

	// Methods

	// RVA: 0x111DCC0 Offset: 0x111C2C0 VA: 0x18111DCC0
	public void .ctor() { }

	// RVA: 0x111DC20 Offset: 0x111C220 VA: 0x18111DC20
	public void .ctor(float r, float g, float b, float a) { }

}

public struct TonemappingColorGrading.EyeAdaptationSettings // TypeDefIndex: 11661
{	// Fields
	public bool enabled; // 0x0
	[MinAttribute] // RVA: 0xCB9F0 Offset: 0xCADF0 VA: 0x1800CB9F0
	[TooltipAttribute] // RVA: 0xCB9F0 Offset: 0xCADF0 VA: 0x1800CB9F0
	public float middleGrey; // 0x4
	[TooltipAttribute] // RVA: 0xCBBD0 Offset: 0xCAFD0 VA: 0x1800CBBD0
	public float min; // 0x8
	[TooltipAttribute] // RVA: 0xCBD80 Offset: 0xCB180 VA: 0x1800CBD80
	public float max; // 0xC
	[MinAttribute] // RVA: 0xCBE60 Offset: 0xCB260 VA: 0x1800CBE60
	[TooltipAttribute] // RVA: 0xCBE60 Offset: 0xCB260 VA: 0x1800CBE60
	public float speed; // 0x10
	[TooltipAttribute] // RVA: 0xCBFC0 Offset: 0xCB3C0 VA: 0x1800CBFC0
	public bool showDebug; // 0x14

	// Properties
	public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111F2E0 Offset: 0x111D8E0 VA: 0x18111F2E0
	public static TonemappingColorGrading.EyeAdaptationSettings get_defaultSettings() { }

}

public enum TonemappingColorGrading.Tonemapper // TypeDefIndex: 11662
{	// Fields
	public int value__; // 0x0
	public const TonemappingColorGrading.Tonemapper ACES = 0;
	public const TonemappingColorGrading.Tonemapper Curve = 1;
	public const TonemappingColorGrading.Tonemapper Hable = 2;
	public const TonemappingColorGrading.Tonemapper HejlDawson = 3;
	public const TonemappingColorGrading.Tonemapper Photographic = 4;
	public const TonemappingColorGrading.Tonemapper Reinhard = 5;
	public const TonemappingColorGrading.Tonemapper Neutral = 6;

}

public struct TonemappingColorGrading.TonemappingSettings // TypeDefIndex: 11663
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCC180 Offset: 0xCB580 VA: 0x1800CC180
	public TonemappingColorGrading.Tonemapper tonemapper; // 0x4
	[MinAttribute] // RVA: 0xCC2C0 Offset: 0xCB6C0 VA: 0x1800CC2C0
	[TooltipAttribute] // RVA: 0xCC2C0 Offset: 0xCB6C0 VA: 0x1800CC2C0
	public float exposure; // 0x8
	[TooltipAttribute] // RVA: 0xCC480 Offset: 0xCB880 VA: 0x1800CC480
	public AnimationCurve curve; // 0x10
	[RangeAttribute] // RVA: 0xCC620 Offset: 0xCBA20 VA: 0x1800CC620
	public float neutralBlackIn; // 0x18
	[RangeAttribute] // RVA: 0xCC790 Offset: 0xCBB90 VA: 0x1800CC790
	public float neutralWhiteIn; // 0x1C
	[RangeAttribute] // RVA: 0xCC820 Offset: 0xCBC20 VA: 0x1800CC820
	public float neutralBlackOut; // 0x20
	[RangeAttribute] // RVA: 0xCC940 Offset: 0xCBD40 VA: 0x1800CC940
	public float neutralWhiteOut; // 0x24
	[RangeAttribute] // RVA: 0xCAF70 Offset: 0xCA370 VA: 0x1800CAF70
	public float neutralWhiteLevel; // 0x28
	[RangeAttribute] // RVA: 0xB4500 Offset: 0xB3900 VA: 0x1800B4500
	public float neutralWhiteClip; // 0x2C

	// Properties
	public static TonemappingColorGrading.TonemappingSettings defaultSettings { get; }

	// Methods

	// RVA: 0x1127E20 Offset: 0x1126420 VA: 0x181127E20
	public static TonemappingColorGrading.TonemappingSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.LUTSettings // TypeDefIndex: 11664
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCCD10 Offset: 0xCC110 VA: 0x1800CCD10
	public Texture texture; // 0x8
	[RangeAttribute] // RVA: 0xCCE30 Offset: 0xCC230 VA: 0x1800CCE30
	[TooltipAttribute] // RVA: 0xCCE30 Offset: 0xCC230 VA: 0x1800CCE30
	public float contribution; // 0x10

	// Properties
	public static TonemappingColorGrading.LUTSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111F760 Offset: 0x111DD60 VA: 0x18111F760
	public static TonemappingColorGrading.LUTSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ColorWheelsSettings // TypeDefIndex: 11665
{	// Fields
	[ColorUsageAttribute] // RVA: 0xCCEE0 Offset: 0xCC2E0 VA: 0x1800CCEE0
	public Color shadows; // 0x0
	[ColorUsageAttribute] // RVA: 0xCCEE0 Offset: 0xCC2E0 VA: 0x1800CCEE0
	public Color midtones; // 0x10
	[ColorUsageAttribute] // RVA: 0xCCEE0 Offset: 0xCC2E0 VA: 0x1800CCEE0
	public Color highlights; // 0x20

	// Properties
	public static TonemappingColorGrading.ColorWheelsSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111D370 Offset: 0x111B970 VA: 0x18111D370
	public static TonemappingColorGrading.ColorWheelsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.BasicsSettings // TypeDefIndex: 11666
{	// Fields
	[RangeAttribute] // RVA: 0xCD1B0 Offset: 0xCC5B0 VA: 0x1800CD1B0
	[TooltipAttribute] // RVA: 0xCD1B0 Offset: 0xCC5B0 VA: 0x1800CD1B0
	public float temperatureShift; // 0x0
	[RangeAttribute] // RVA: 0xCD380 Offset: 0xCC780 VA: 0x1800CD380
	[TooltipAttribute] // RVA: 0xCD380 Offset: 0xCC780 VA: 0x1800CD380
	public float tint; // 0x4
	[SpaceAttribute] // RVA: 0xCD480 Offset: 0xCC880 VA: 0x1800CD480
	[RangeAttribute] // RVA: 0xCD480 Offset: 0xCC880 VA: 0x1800CD480
	[TooltipAttribute] // RVA: 0xCD480 Offset: 0xCC880 VA: 0x1800CD480
	public float hue; // 0x8
	[RangeAttribute] // RVA: 0xCD610 Offset: 0xCCA10 VA: 0x1800CD610
	[TooltipAttribute] // RVA: 0xCD610 Offset: 0xCCA10 VA: 0x1800CD610
	public float saturation; // 0xC
	[RangeAttribute] // RVA: 0xCD730 Offset: 0xCCB30 VA: 0x1800CD730
	[TooltipAttribute] // RVA: 0xCD730 Offset: 0xCCB30 VA: 0x1800CD730
	public float vibrance; // 0x10
	[RangeAttribute] // RVA: 0xCD910 Offset: 0xCCD10 VA: 0x1800CD910
	[TooltipAttribute] // RVA: 0xCD910 Offset: 0xCCD10 VA: 0x1800CD910
	public float value; // 0x14
	[SpaceAttribute] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[RangeAttribute] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	[TooltipAttribute] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	public float contrast; // 0x18
	[RangeAttribute] // RVA: 0xCDCB0 Offset: 0xCD0B0 VA: 0x1800CDCB0
	[TooltipAttribute] // RVA: 0xCDCB0 Offset: 0xCD0B0 VA: 0x1800CDCB0
	public float gain; // 0x1C
	[RangeAttribute] // RVA: 0xCDE80 Offset: 0xCD280 VA: 0x1800CDE80
	[TooltipAttribute] // RVA: 0xCDE80 Offset: 0xCD280 VA: 0x1800CDE80
	public float gamma; // 0x20

	// Properties
	public static TonemappingColorGrading.BasicsSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111B2D0 Offset: 0x11198D0 VA: 0x18111B2D0
	public static TonemappingColorGrading.BasicsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ChannelMixerSettings // TypeDefIndex: 11667
{	// Fields
	public int currentChannel; // 0x0
	public Vector3[] channels; // 0x8

	// Properties
	public static TonemappingColorGrading.ChannelMixerSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111CEC0 Offset: 0x111B4C0 VA: 0x18111CEC0
	public static TonemappingColorGrading.ChannelMixerSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.CurvesSettings // TypeDefIndex: 11668
{	// Fields
	[TonemappingColorGrading.Curve] // RVA: 0xCE0E0 Offset: 0xCD4E0 VA: 0x1800CE0E0
	public AnimationCurve master; // 0x0
	[TonemappingColorGrading.Curve] // RVA: 0xCE180 Offset: 0xCD580 VA: 0x1800CE180
	public AnimationCurve red; // 0x8
	[TonemappingColorGrading.Curve] // RVA: 0xCF6A0 Offset: 0xCEAA0 VA: 0x1800CF6A0
	public AnimationCurve green; // 0x10
	[TonemappingColorGrading.Curve] // RVA: 0xCF710 Offset: 0xCEB10 VA: 0x1800CF710
	public AnimationCurve blue; // 0x18

	// Properties
	public static TonemappingColorGrading.CurvesSettings defaultSettings { get; }
	public static AnimationCurve defaultCurve { get; }

	// Methods

	// RVA: 0x111DE50 Offset: 0x111C450 VA: 0x18111DE50
	public static TonemappingColorGrading.CurvesSettings get_defaultSettings() { }

	// RVA: 0x111DCF0 Offset: 0x111C2F0 VA: 0x18111DCF0
	public static AnimationCurve get_defaultCurve() { }

}

public enum TonemappingColorGrading.ColorGradingPrecision // TypeDefIndex: 11669
{	// Fields
	public int value__; // 0x0
	public const TonemappingColorGrading.ColorGradingPrecision Normal = 16;
	public const TonemappingColorGrading.ColorGradingPrecision High = 32;

}

public struct TonemappingColorGrading.ColorGradingSettings // TypeDefIndex: 11670
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCF860 Offset: 0xCEC60 VA: 0x1800CF860
	public TonemappingColorGrading.ColorGradingPrecision precision; // 0x4
	[SpaceAttribute] // RVA: 0xCF9A0 Offset: 0xCEDA0 VA: 0x1800CF9A0
	[TonemappingColorGrading.ColorWheelGroup] // RVA: 0xCF9A0 Offset: 0xCEDA0 VA: 0x1800CF9A0
	public TonemappingColorGrading.ColorWheelsSettings colorWheels; // 0x8
	[SpaceAttribute] // RVA: 0xCFA50 Offset: 0xCEE50 VA: 0x1800CFA50
	[TonemappingColorGrading.IndentedGroup] // RVA: 0xCFA50 Offset: 0xCEE50 VA: 0x1800CFA50
	public TonemappingColorGrading.BasicsSettings basics; // 0x38
	[SpaceAttribute] // RVA: 0xCFA50 Offset: 0xCEE50 VA: 0x1800CFA50
	[TonemappingColorGrading.ChannelMixer] // RVA: 0xCFA50 Offset: 0xCEE50 VA: 0x1800CFA50
	public TonemappingColorGrading.ChannelMixerSettings channelMixer; // 0x60
	[SpaceAttribute] // RVA: 0xCFA50 Offset: 0xCEE50 VA: 0x1800CFA50
	[TonemappingColorGrading.IndentedGroup] // RVA: 0xCFA50 Offset: 0xCEE50 VA: 0x1800CFA50
	public TonemappingColorGrading.CurvesSettings curves; // 0x70
	[SpaceAttribute] // RVA: 0xCFDF0 Offset: 0xCF1F0 VA: 0x1800CFDF0
	[TooltipAttribute] // RVA: 0xCFDF0 Offset: 0xCF1F0 VA: 0x1800CFDF0
	public bool useDithering; // 0x90
	[TooltipAttribute] // RVA: 0xCFF30 Offset: 0xCF330 VA: 0x1800CFF30
	public bool showDebug; // 0x91

	// Properties
	public static TonemappingColorGrading.ColorGradingSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111D030 Offset: 0x111B630 VA: 0x18111D030
	public static TonemappingColorGrading.ColorGradingSettings get_defaultSettings() { }

	// RVA: 0x1AE640 Offset: 0x1ADA40 VA: 0x1801AE640
	internal void Reset() { }

}

private enum TonemappingColorGrading.Pass // TypeDefIndex: 11671
{	// Fields
	public int value__; // 0x0
	public const TonemappingColorGrading.Pass LutGen = 0;
	public const TonemappingColorGrading.Pass AdaptationLog = 1;
	public const TonemappingColorGrading.Pass AdaptationExpBlend = 2;
	public const TonemappingColorGrading.Pass AdaptationExp = 3;
	public const TonemappingColorGrading.Pass TonemappingOff = 4;
	public const TonemappingColorGrading.Pass TonemappingOff_LUT = 5;
	public const TonemappingColorGrading.Pass TonemappingACES = 6;
	public const TonemappingColorGrading.Pass TonemappingACES_LUT = 7;
	public const TonemappingColorGrading.Pass TonemappingCurve = 8;
	public const TonemappingColorGrading.Pass TonemappingCurve_LUT = 9;
	public const TonemappingColorGrading.Pass TonemappingHable = 10;
	public const TonemappingColorGrading.Pass TonemappingHable_LUT = 11;
	public const TonemappingColorGrading.Pass TonemappingHejlDawson = 12;
	public const TonemappingColorGrading.Pass TonemappingHejlDawson_LUT = 13;
	public const TonemappingColorGrading.Pass TonemappingPhotographic = 14;
	public const TonemappingColorGrading.Pass TonemappingPhotographic_LUT = 15;
	public const TonemappingColorGrading.Pass TonemappingReinhard = 16;
	public const TonemappingColorGrading.Pass TonemappingReinhard_LUT = 17;
	public const TonemappingColorGrading.Pass TonemappingNeutral = 18;
	public const TonemappingColorGrading.Pass TonemappingNeutral_LUT = 19;
	public const TonemappingColorGrading.Pass AdaptationDebug = 20;

}

