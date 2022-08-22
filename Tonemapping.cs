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

	// RVA: 0x21E8870 Offset: 0x21E6E70 VA: 0x1821E8870 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E9690 Offset: 0x21E7C90 VA: 0x1821E9690
	public float UpdateCurve() { }

	// RVA: 0x21E8B50 Offset: 0x21E7150 VA: 0x1821E8B50
	private void OnDisable() { }

	// RVA: 0x21E8A40 Offset: 0x21E7040 VA: 0x1821E8A40
	private bool CreateInternalRenderTexture() { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21E8CE0 Offset: 0x21E72E0 VA: 0x1821E8CE0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E99F0 Offset: 0x21E7FF0 VA: 0x1821E99F0
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

	// RVA: 0x871000 Offset: 0x86F600 VA: 0x180871000
	public void Awake() { }

	// RVA: 0x871050 Offset: 0x86F650 VA: 0x180871050 Slot: 4
	public override void Start() { }

	// RVA: 0x871010 Offset: 0x86F610 VA: 0x180871010
	private void ResetColorGrading() { }

	// RVA: 0x871090 Offset: 0x86F690 VA: 0x180871090
	protected void Update() { }

	// RVA: 0x8711B0 Offset: 0x86F7B0 VA: 0x1808711B0
	public void .ctor() { }

}

public class TonemappingColorGrading : MonoBehaviour // TypeDefIndex: 11655
{	// Fields
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation; // 0x18
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private TonemappingColorGrading.TonemappingSettings m_Tonemapping; // 0x30
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private TonemappingColorGrading.ColorGradingSettings m_ColorGrading; // 0x60
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private TonemappingColorGrading.LUTSettings m_Lut; // 0xF8
	private Texture2D m_IdentityLut; // 0x110
	private RenderTexture m_InternalLut; // 0x118
	private Texture2D m_CurveTexture; // 0x120
	private Texture2D m_TonemapperCurve; // 0x128
	private float m_TonemapperCurveRange; // 0x130
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Shader m_Shader; // 0x138
	private Material m_Material; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <validRenderTextureFormat>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x1128360 Offset: 0x1126960 VA: 0x181128360
	public TonemappingColorGrading.EyeAdaptationSettings get_eyeAdaptation() { }

	// RVA: 0x1128AA0 Offset: 0x11270A0 VA: 0x181128AA0
	public void set_eyeAdaptation(TonemappingColorGrading.EyeAdaptationSettings value) { }

	// RVA: 0x11289C0 Offset: 0x1126FC0 VA: 0x1811289C0
	public TonemappingColorGrading.TonemappingSettings get_tonemapping() { }

	// RVA: 0x1128AF0 Offset: 0x11270F0 VA: 0x181128AF0
	public void set_tonemapping(TonemappingColorGrading.TonemappingSettings value) { }

	// RVA: 0x11281C0 Offset: 0x11267C0 VA: 0x1811281C0
	public TonemappingColorGrading.ColorGradingSettings get_colorGrading() { }

	// RVA: 0x1128A00 Offset: 0x1127000 VA: 0x181128A00
	public void set_colorGrading(TonemappingColorGrading.ColorGradingSettings value) { }

	// RVA: 0x1128680 Offset: 0x1126C80 VA: 0x181128680
	public TonemappingColorGrading.LUTSettings get_lut() { }

	// RVA: 0x1128AC0 Offset: 0x11270C0 VA: 0x181128AC0
	public void set_lut(TonemappingColorGrading.LUTSettings value) { }

	// RVA: 0x1128380 Offset: 0x1126980 VA: 0x181128380
	private Texture2D get_identityLut() { }

	// RVA: 0x1128480 Offset: 0x1126A80 VA: 0x181128480
	private RenderTexture get_internalLutRt() { }

	// RVA: 0x1128240 Offset: 0x1126840 VA: 0x181128240
	private Texture2D get_curveTexture() { }

	// RVA: 0x1128870 Offset: 0x1126E70 VA: 0x181128870
	private Texture2D get_tonemapperCurve() { }

	// RVA: 0x11287D0 Offset: 0x1126DD0 VA: 0x1811287D0
	public Shader get_shader() { }

	// RVA: 0x11286A0 Offset: 0x1126CA0 VA: 0x1811286A0
	public Material get_material() { }

	// RVA: 0x1128640 Offset: 0x1126C40 VA: 0x181128640
	public bool get_isGammaColorSpace() { }

	// RVA: 0x1128660 Offset: 0x1126C60 VA: 0x181128660
	public int get_lutSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11289E0 Offset: 0x1126FE0 VA: 0x1811289E0
	public bool get_validRenderTextureFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1128B30 Offset: 0x1127130 VA: 0x181128B30
	private void set_validRenderTextureFormat(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11289F0 Offset: 0x1126FF0 VA: 0x1811289F0
	public bool get_validUserLutSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1128B40 Offset: 0x1127140 VA: 0x181128B40
	private void set_validUserLutSize(bool value) { }

	// RVA: 0x1127FB0 Offset: 0x11265B0 VA: 0x181127FB0
	public void SetDirty() { }

	// RVA: 0x1127FC0 Offset: 0x11265C0 VA: 0x181127FC0
	public void SetTonemapperDirty() { }

	// RVA: 0x1126580 Offset: 0x1124B80 VA: 0x181126580
	private void OnEnable() { }

	// RVA: 0x1126240 Offset: 0x1124840 VA: 0x181126240
	private void OnDisable() { }

	// RVA: 0x1127FA0 Offset: 0x11265A0 VA: 0x181127FA0
	private void OnValidate() { }

	// RVA: 0x1125910 Offset: 0x1123F10 VA: 0x181125910
	private static Texture2D GenerateIdentityLut(int dim) { }

	// RVA: 0x1127FD0 Offset: 0x11265D0 VA: 0x181127FD0
	private float StandardIlluminantY(float x) { }

	// RVA: 0x11253C0 Offset: 0x11239C0 VA: 0x1811253C0
	private Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x1125F90 Offset: 0x1124590 VA: 0x181125F90
	private Vector3 GetWhiteBalance() { }

	// RVA: 0x1126140 Offset: 0x1124740 VA: 0x181126140
	private static Color NormalizeColor(Color c) { }

	// RVA: 0x1125BB0 Offset: 0x11241B0 VA: 0x181125BB0
	private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain) { }

	// RVA: 0x1125650 Offset: 0x1123C50 VA: 0x181125650
	private void GenCurveTexture() { }

	// RVA: 0x1125570 Offset: 0x1123B70 VA: 0x181125570
	private bool CheckUserLut() { }

	// RVA: 0x1125460 Offset: 0x1123A60 VA: 0x181125460
	private bool CheckSmallAdaptiveRt() { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11265D0 Offset: 0x1124BD0 VA: 0x1811265D0
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1125230 Offset: 0x1123830 VA: 0x181125230
	public Texture2D BakeLUT() { }

	// RVA: 0x1128000 Offset: 0x1126600 VA: 0x181128000
	public void .ctor() { }

}

public class TonemappingColorGrading.SettingsGroup : Attribute // TypeDefIndex: 11656
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class TonemappingColorGrading.IndentedGroup : PropertyAttribute // TypeDefIndex: 11657
{	// Methods

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

public class TonemappingColorGrading.ChannelMixer : PropertyAttribute // TypeDefIndex: 11658
{	// Methods

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

public class TonemappingColorGrading.ColorWheelGroup : PropertyAttribute // TypeDefIndex: 11659
{	// Fields
	public int minSizePerWheel; // 0x10
	public int maxSizePerWheel; // 0x14

	// Methods

	// RVA: 0x111E030 Offset: 0x111C630 VA: 0x18111E030
	public void .ctor() { }

	// RVA: 0x111E050 Offset: 0x111C650 VA: 0x18111E050
	public void .ctor(int minSizePerWheel, int maxSizePerWheel) { }

}

public class TonemappingColorGrading.Curve : PropertyAttribute // TypeDefIndex: 11660
{	// Fields
	public Color color; // 0x10

	// Methods

	// RVA: 0x111E9F0 Offset: 0x111CFF0 VA: 0x18111E9F0
	public void .ctor() { }

	// RVA: 0x111E950 Offset: 0x111CF50 VA: 0x18111E950
	public void .ctor(float r, float g, float b, float a) { }

}

public struct TonemappingColorGrading.EyeAdaptationSettings // TypeDefIndex: 11661
{	// Fields
	public bool enabled; // 0x0
	[MinAttribute] // RVA: 0xCBB50 Offset: 0xCAF50 VA: 0x1800CBB50
	[TooltipAttribute] // RVA: 0xCBB50 Offset: 0xCAF50 VA: 0x1800CBB50
	public float middleGrey; // 0x4
	[TooltipAttribute] // RVA: 0xCBDA0 Offset: 0xCB1A0 VA: 0x1800CBDA0
	public float min; // 0x8
	[TooltipAttribute] // RVA: 0xCBE80 Offset: 0xCB280 VA: 0x1800CBE80
	public float max; // 0xC
	[MinAttribute] // RVA: 0xCBF60 Offset: 0xCB360 VA: 0x1800CBF60
	[TooltipAttribute] // RVA: 0xCBF60 Offset: 0xCB360 VA: 0x1800CBF60
	public float speed; // 0x10
	[TooltipAttribute] // RVA: 0xCC140 Offset: 0xCB540 VA: 0x1800CC140
	public bool showDebug; // 0x14

	// Properties
	public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings { get; }

	// Methods

	// RVA: 0x1120010 Offset: 0x111E610 VA: 0x181120010
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
	[TooltipAttribute] // RVA: 0xCC210 Offset: 0xCB610 VA: 0x1800CC210
	public TonemappingColorGrading.Tonemapper tonemapper; // 0x4
	[MinAttribute] // RVA: 0xCC350 Offset: 0xCB750 VA: 0x1800CC350
	[TooltipAttribute] // RVA: 0xCC350 Offset: 0xCB750 VA: 0x1800CC350
	public float exposure; // 0x8
	[TooltipAttribute] // RVA: 0xCC560 Offset: 0xCB960 VA: 0x1800CC560
	public AnimationCurve curve; // 0x10
	[RangeAttribute] // RVA: 0xCC790 Offset: 0xCBB90 VA: 0x1800CC790
	public float neutralBlackIn; // 0x18
	[RangeAttribute] // RVA: 0xCC870 Offset: 0xCBC70 VA: 0x1800CC870
	public float neutralWhiteIn; // 0x1C
	[RangeAttribute] // RVA: 0xCC980 Offset: 0xCBD80 VA: 0x1800CC980
	public float neutralBlackOut; // 0x20
	[RangeAttribute] // RVA: 0xCCA90 Offset: 0xCBE90 VA: 0x1800CCA90
	public float neutralWhiteOut; // 0x24
	[RangeAttribute] // RVA: 0xCB000 Offset: 0xCA400 VA: 0x1800CB000
	public float neutralWhiteLevel; // 0x28
	[RangeAttribute] // RVA: 0xB45A0 Offset: 0xB39A0 VA: 0x1800B45A0
	public float neutralWhiteClip; // 0x2C

	// Properties
	public static TonemappingColorGrading.TonemappingSettings defaultSettings { get; }

	// Methods

	// RVA: 0x1128B50 Offset: 0x1127150 VA: 0x181128B50
	public static TonemappingColorGrading.TonemappingSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.LUTSettings // TypeDefIndex: 11664
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCCDD0 Offset: 0xCC1D0 VA: 0x1800CCDD0
	public Texture texture; // 0x8
	[RangeAttribute] // RVA: 0xCCEC0 Offset: 0xCC2C0 VA: 0x1800CCEC0
	[TooltipAttribute] // RVA: 0xCCEC0 Offset: 0xCC2C0 VA: 0x1800CCEC0
	public float contribution; // 0x10

	// Properties
	public static TonemappingColorGrading.LUTSettings defaultSettings { get; }

	// Methods

	// RVA: 0x1120490 Offset: 0x111EA90 VA: 0x181120490
	public static TonemappingColorGrading.LUTSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ColorWheelsSettings // TypeDefIndex: 11665
{	// Fields
	[ColorUsageAttribute] // RVA: 0xCD030 Offset: 0xCC430 VA: 0x1800CD030
	public Color shadows; // 0x0
	[ColorUsageAttribute] // RVA: 0xCD030 Offset: 0xCC430 VA: 0x1800CD030
	public Color midtones; // 0x10
	[ColorUsageAttribute] // RVA: 0xCD030 Offset: 0xCC430 VA: 0x1800CD030
	public Color highlights; // 0x20

	// Properties
	public static TonemappingColorGrading.ColorWheelsSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111E0A0 Offset: 0x111C6A0 VA: 0x18111E0A0
	public static TonemappingColorGrading.ColorWheelsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.BasicsSettings // TypeDefIndex: 11666
{	// Fields
	[RangeAttribute] // RVA: 0xCD240 Offset: 0xCC640 VA: 0x1800CD240
	[TooltipAttribute] // RVA: 0xCD240 Offset: 0xCC640 VA: 0x1800CD240
	public float temperatureShift; // 0x0
	[RangeAttribute] // RVA: 0xCD410 Offset: 0xCC810 VA: 0x1800CD410
	[TooltipAttribute] // RVA: 0xCD410 Offset: 0xCC810 VA: 0x1800CD410
	public float tint; // 0x4
	[SpaceAttribute] // RVA: 0xCD540 Offset: 0xCC940 VA: 0x1800CD540
	[RangeAttribute] // RVA: 0xCD540 Offset: 0xCC940 VA: 0x1800CD540
	[TooltipAttribute] // RVA: 0xCD540 Offset: 0xCC940 VA: 0x1800CD540
	public float hue; // 0x8
	[RangeAttribute] // RVA: 0xCD6A0 Offset: 0xCCAA0 VA: 0x1800CD6A0
	[TooltipAttribute] // RVA: 0xCD6A0 Offset: 0xCCAA0 VA: 0x1800CD6A0
	public float saturation; // 0xC
	[RangeAttribute] // RVA: 0xCD7F0 Offset: 0xCCBF0 VA: 0x1800CD7F0
	[TooltipAttribute] // RVA: 0xCD7F0 Offset: 0xCCBF0 VA: 0x1800CD7F0
	public float vibrance; // 0x10
	[RangeAttribute] // RVA: 0xCDA00 Offset: 0xCCE00 VA: 0x1800CDA00
	[TooltipAttribute] // RVA: 0xCDA00 Offset: 0xCCE00 VA: 0x1800CDA00
	public float value; // 0x14
	[SpaceAttribute] // RVA: 0xCDB30 Offset: 0xCCF30 VA: 0x1800CDB30
	[RangeAttribute] // RVA: 0xCDB30 Offset: 0xCCF30 VA: 0x1800CDB30
	[TooltipAttribute] // RVA: 0xCDB30 Offset: 0xCCF30 VA: 0x1800CDB30
	public float contrast; // 0x18
	[RangeAttribute] // RVA: 0xCDE40 Offset: 0xCD240 VA: 0x1800CDE40
	[TooltipAttribute] // RVA: 0xCDE40 Offset: 0xCD240 VA: 0x1800CDE40
	public float gain; // 0x1C
	[RangeAttribute] // RVA: 0xCDFF0 Offset: 0xCD3F0 VA: 0x1800CDFF0
	[TooltipAttribute] // RVA: 0xCDFF0 Offset: 0xCD3F0 VA: 0x1800CDFF0
	public float gamma; // 0x20

	// Properties
	public static TonemappingColorGrading.BasicsSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111C000 Offset: 0x111A600 VA: 0x18111C000
	public static TonemappingColorGrading.BasicsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ChannelMixerSettings // TypeDefIndex: 11667
{	// Fields
	public int currentChannel; // 0x0
	public Vector3[] channels; // 0x8

	// Properties
	public static TonemappingColorGrading.ChannelMixerSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111DBF0 Offset: 0x111C1F0 VA: 0x18111DBF0
	public static TonemappingColorGrading.ChannelMixerSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.CurvesSettings // TypeDefIndex: 11668
{	// Fields
	[TonemappingColorGrading.Curve] // RVA: 0xCE170 Offset: 0xCD570 VA: 0x1800CE170
	public AnimationCurve master; // 0x0
	[TonemappingColorGrading.Curve] // RVA: 0xCE240 Offset: 0xCD640 VA: 0x1800CE240
	public AnimationCurve red; // 0x8
	[TonemappingColorGrading.Curve] // RVA: 0xCF730 Offset: 0xCEB30 VA: 0x1800CF730
	public AnimationCurve green; // 0x10
	[TonemappingColorGrading.Curve] // RVA: 0xCF7A0 Offset: 0xCEBA0 VA: 0x1800CF7A0
	public AnimationCurve blue; // 0x18

	// Properties
	public static TonemappingColorGrading.CurvesSettings defaultSettings { get; }
	public static AnimationCurve defaultCurve { get; }

	// Methods

	// RVA: 0x111EB80 Offset: 0x111D180 VA: 0x18111EB80
	public static TonemappingColorGrading.CurvesSettings get_defaultSettings() { }

	// RVA: 0x111EA20 Offset: 0x111D020 VA: 0x18111EA20
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
	[TooltipAttribute] // RVA: 0xCF9D0 Offset: 0xCEDD0 VA: 0x1800CF9D0
	public TonemappingColorGrading.ColorGradingPrecision precision; // 0x4
	[SpaceAttribute] // RVA: 0xCFA30 Offset: 0xCEE30 VA: 0x1800CFA30
	[TonemappingColorGrading.ColorWheelGroup] // RVA: 0xCFA30 Offset: 0xCEE30 VA: 0x1800CFA30
	public TonemappingColorGrading.ColorWheelsSettings colorWheels; // 0x8
	[SpaceAttribute] // RVA: 0xCFB10 Offset: 0xCEF10 VA: 0x1800CFB10
	[TonemappingColorGrading.IndentedGroup] // RVA: 0xCFB10 Offset: 0xCEF10 VA: 0x1800CFB10
	public TonemappingColorGrading.BasicsSettings basics; // 0x38
	[SpaceAttribute] // RVA: 0xCFB10 Offset: 0xCEF10 VA: 0x1800CFB10
	[TonemappingColorGrading.ChannelMixer] // RVA: 0xCFB10 Offset: 0xCEF10 VA: 0x1800CFB10
	public TonemappingColorGrading.ChannelMixerSettings channelMixer; // 0x60
	[SpaceAttribute] // RVA: 0xCFB10 Offset: 0xCEF10 VA: 0x1800CFB10
	[TonemappingColorGrading.IndentedGroup] // RVA: 0xCFB10 Offset: 0xCEF10 VA: 0x1800CFB10
	public TonemappingColorGrading.CurvesSettings curves; // 0x70
	[SpaceAttribute] // RVA: 0xCFE80 Offset: 0xCF280 VA: 0x1800CFE80
	[TooltipAttribute] // RVA: 0xCFE80 Offset: 0xCF280 VA: 0x1800CFE80
	public bool useDithering; // 0x90
	[TooltipAttribute] // RVA: 0xD0070 Offset: 0xCF470 VA: 0x1800D0070
	public bool showDebug; // 0x91

	// Properties
	public static TonemappingColorGrading.ColorGradingSettings defaultSettings { get; }

	// Methods

	// RVA: 0x111DD60 Offset: 0x111C360 VA: 0x18111DD60
	public static TonemappingColorGrading.ColorGradingSettings get_defaultSettings() { }

	// RVA: 0x1BCCF0 Offset: 0x1BC0F0 VA: 0x1801BCCF0
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

