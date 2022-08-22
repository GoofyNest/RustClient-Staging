public class Explosion_Bloom : MonoBehaviour // TypeDefIndex: 11490
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Explosion_Bloom.Settings settings; // 0x18
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private Shader m_Shader; // 0x30
	private Material m_Material; // 0x38
	private const int kMaxIterations = 16;
	private RenderTexture[] m_blurBuffer1; // 0x40
	private RenderTexture[] m_blurBuffer2; // 0x48
	private int m_Threshold; // 0x50
	private int m_Curve; // 0x54
	private int m_PrefilterOffs; // 0x58
	private int m_SampleScale; // 0x5C
	private int m_Intensity; // 0x60
	private int m_BaseTex; // 0x64

	// Properties
	public Shader shader { get; }
	public Material material { get; }
	public static bool supportsDX11 { get; }

	// Methods

	// RVA: 0x8D14C0 Offset: 0x8CFAC0 VA: 0x1808D14C0
	public Shader get_shader() { }

	// RVA: 0x8D1390 Offset: 0x8CF990 VA: 0x1808D1390
	public Material get_material() { }

	// RVA: 0x8D0530 Offset: 0x8CEB30 VA: 0x1808D0530
	public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect) { }

	// RVA: 0x8D0470 Offset: 0x8CEA70 VA: 0x1808D0470
	public static Material CheckShaderAndCreateMaterial(Shader s) { }

	// RVA: 0x8D1550 Offset: 0x8CFB50 VA: 0x1808D1550
	public static bool get_supportsDX11() { }

	// RVA: 0x8D03E0 Offset: 0x8CE9E0 VA: 0x1808D03E0
	private void Awake() { }

	// RVA: 0x8D0960 Offset: 0x8CEF60 VA: 0x1808D0960
	private void OnEnable() { }

	// RVA: 0x8D08B0 Offset: 0x8CEEB0 VA: 0x1808D08B0
	private void OnDisable() { }

	// RVA: 0x8D09B0 Offset: 0x8CEFB0 VA: 0x1808D09B0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x8D1300 Offset: 0x8CF900 VA: 0x1808D1300
	public void .ctor() { }

}

public struct Explosion_Bloom.Settings // TypeDefIndex: 11491
{	// Fields
	[SerializeField] // RVA: 0xB6BA0 Offset: 0xB5FA0 VA: 0x1800B6BA0
	[TooltipAttribute] // RVA: 0xB6BA0 Offset: 0xB5FA0 VA: 0x1800B6BA0
	public float threshold; // 0x0
	[SerializeField] // RVA: 0xB6D20 Offset: 0xB6120 VA: 0x1800B6D20
	[RangeAttribute] // RVA: 0xB6D20 Offset: 0xB6120 VA: 0x1800B6D20
	[TooltipAttribute] // RVA: 0xB6D20 Offset: 0xB6120 VA: 0x1800B6D20
	public float softKnee; // 0x4
	[SerializeField] // RVA: 0xB6F80 Offset: 0xB6380 VA: 0x1800B6F80
	[RangeAttribute] // RVA: 0xB6F80 Offset: 0xB6380 VA: 0x1800B6F80
	[TooltipAttribute] // RVA: 0xB6F80 Offset: 0xB6380 VA: 0x1800B6F80
	public float radius; // 0x8
	[SerializeField] // RVA: 0xB70B0 Offset: 0xB64B0 VA: 0x1800B70B0
	[TooltipAttribute] // RVA: 0xB70B0 Offset: 0xB64B0 VA: 0x1800B70B0
	public float intensity; // 0xC
	[SerializeField] // RVA: 0xB7210 Offset: 0xB6610 VA: 0x1800B7210
	[TooltipAttribute] // RVA: 0xB7210 Offset: 0xB6610 VA: 0x1800B7210
	public bool highQuality; // 0x10
	[SerializeField] // RVA: 0xB7340 Offset: 0xB6740 VA: 0x1800B7340
	[TooltipAttribute] // RVA: 0xB7340 Offset: 0xB6740 VA: 0x1800B7340
	public bool antiFlicker; // 0x11

	// Properties
	public float thresholdGamma { get; set; }
	public float thresholdLinear { get; set; }
	public static Explosion_Bloom.Settings defaultSettings { get; }

	// Methods

	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_thresholdGamma(float value) { }

	// RVA: 0xF9FA0 Offset: 0xF93A0 VA: 0x1800F9FA0
	public float get_thresholdGamma() { }

	// RVA: 0xFA020 Offset: 0xF9420 VA: 0x1800FA020
	public void set_thresholdLinear(float value) { }

	// RVA: 0xFA010 Offset: 0xF9410 VA: 0x1800FA010
	public float get_thresholdLinear() { }

	// RVA: 0x8D6E30 Offset: 0x8D5430 VA: 0x1808D6E30
	public static Explosion_Bloom.Settings get_defaultSettings() { }

}

public class ExplosionDemoGUI : MonoBehaviour // TypeDefIndex: 11492
{	// Fields
	public GameObject[] Prefabs; // 0x18
	public float reactivateTime; // 0x20
	public Light Sun; // 0x28
	private int currentNomber; // 0x30
	private GameObject currentInstance; // 0x38
	private GUIStyle guiStyleHeader; // 0x40
	private float sunIntensity; // 0x48
	private float dpiScale; // 0x4C

	// Methods

	// RVA: 0x8CFE90 Offset: 0x8CE490 VA: 0x1808CFE90
	private void Start() { }

	// RVA: 0x8CFB40 Offset: 0x8CE140 VA: 0x1808CFB40
	private void OnGUI() { }

	// RVA: 0x8CF970 Offset: 0x8CDF70 VA: 0x1808CF970
	private void ChangeCurrent(int delta) { }

	// RVA: 0x8D00B0 Offset: 0x8CE6B0 VA: 0x1808D00B0
	public void .ctor() { }

}

public class ExplosionDemoReactivator : MonoBehaviour // TypeDefIndex: 11493
{	// Fields
	public float TimeDelayToReactivate; // 0x18

	// Methods

	// RVA: 0x8D01F0 Offset: 0x8CE7F0 VA: 0x1808D01F0
	private void Start() { }

	// RVA: 0x8D0120 Offset: 0x8CE720 VA: 0x1808D0120
	private void Reactivate() { }

	// RVA: 0x8D0240 Offset: 0x8CE840 VA: 0x1808D0240
	public void .ctor() { }

}

public class ExplosionPlatformActivator : MonoBehaviour // TypeDefIndex: 11494
{	// Fields
	public GameObject Effect; // 0x18
	public float TimeDelay; // 0x20
	public float DefaultRepeatTime; // 0x24
	public float NearRepeatTime; // 0x28
	private float currentTime; // 0x2C
	private float currentRepeatTime; // 0x30
	private bool canUpdate; // 0x34

	// Methods

	// RVA: 0x8D02A0 Offset: 0x8CE8A0 VA: 0x1808D02A0
	private void Start() { }

	// RVA: 0x8D0250 Offset: 0x8CE850 VA: 0x1808D0250
	private void Init() { }

	// RVA: 0x8D02F0 Offset: 0x8CE8F0 VA: 0x1808D02F0
	private void Update() { }

	// RVA: 0x8D0280 Offset: 0x8CE880 VA: 0x1808D0280
	private void OnTriggerEnter(Collider coll) { }

	// RVA: 0x8D0290 Offset: 0x8CE890 VA: 0x1808D0290
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x8D03C0 Offset: 0x8CE9C0 VA: 0x1808D03C0
	public void .ctor() { }

}

public class ExplosionsFPS : MonoBehaviour // TypeDefIndex: 11495
{	// Fields
	private readonly GUIStyle guiStyleHeader; // 0x18
	private float timeleft; // 0x20
	private float fps; // 0x24
	private int frames; // 0x28

	// Methods

	// RVA: 0x8D1B00 Offset: 0x8D0100 VA: 0x1808D1B00
	private void Awake() { }

	// RVA: 0x8D1B90 Offset: 0x8D0190 VA: 0x1808D1B90
	private void OnGUI() { }

	// RVA: 0x8D1C70 Offset: 0x8D0270 VA: 0x1808D1C70
	private void Update() { }

	// RVA: 0x8D1CD0 Offset: 0x8D02D0 VA: 0x1808D1CD0
	public void .ctor() { }

}

public class ExplosionsBillboard : MonoBehaviour // TypeDefIndex: 11496
{	// Fields
	public Camera Camera; // 0x18
	public bool Active; // 0x20
	public bool AutoInitCamera; // 0x21
	private GameObject myContainer; // 0x28
	private Transform t; // 0x30
	private Transform camT; // 0x38
	private Transform contT; // 0x40

	// Methods

	// RVA: 0x8D1580 Offset: 0x8CFB80 VA: 0x1808D1580
	private void Awake() { }

	// RVA: 0x8D1810 Offset: 0x8CFE10 VA: 0x1808D1810
	private void Update() { }

	// RVA: 0x8D1A10 Offset: 0x8D0010 VA: 0x1808D1A10
	public void .ctor() { }

}

public class ExplosionsDeactivateRendererByTime : MonoBehaviour // TypeDefIndex: 11497
{	// Fields
	public float TimeDelay; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8D1A20 Offset: 0x8D0020 VA: 0x1808D1A20
	private void Awake() { }

	// RVA: 0x8D1A70 Offset: 0x8D0070 VA: 0x1808D1A70
	private void DeactivateRenderer() { }

	// RVA: 0x8D1AA0 Offset: 0x8D00A0 VA: 0x1808D1AA0
	private void OnEnable() { }

	// RVA: 0x571960 Offset: 0x56FF60 VA: 0x180571960
	public void .ctor() { }

}

public class ExplosionsLightCurves : MonoBehaviour // TypeDefIndex: 11498
{	// Fields
	public AnimationCurve LightCurve; // 0x18
	public float GraphTimeMultiplier; // 0x20
	public float GraphIntensityMultiplier; // 0x24
	private bool canUpdate; // 0x28
	private float startTime; // 0x2C
	private Light lightSource; // 0x30

	// Methods

	// RVA: 0x8D1D40 Offset: 0x8D0340 VA: 0x1808D1D40
	private void Awake() { }

	// RVA: 0x8D1DD0 Offset: 0x8D03D0 VA: 0x1808D1DD0
	private void OnEnable() { }

	// RVA: 0x8D1DF0 Offset: 0x8D03F0 VA: 0x1808D1DF0
	private void Update() { }

	// RVA: 0x8D1E60 Offset: 0x8D0460 VA: 0x1808D1E60
	public void .ctor() { }

}

public class ExplosionsParticleSystemScaler : MonoBehaviour // TypeDefIndex: 11499
{	// Fields
	public float particlesScale; // 0x18

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Update() { }

	// RVA: 0x571960 Offset: 0x56FF60 VA: 0x180571960
	public void .ctor() { }

}

public class ExplosionsScaleCurves : MonoBehaviour // TypeDefIndex: 11500
{	// Fields
	public AnimationCurve ScaleCurveX; // 0x18
	public AnimationCurve ScaleCurveY; // 0x20
	public AnimationCurve ScaleCurveZ; // 0x28
	public Vector3 GraphTimeMultiplier; // 0x30
	public Vector3 GraphScaleMultiplier; // 0x3C
	private float startTime; // 0x48
	private Transform t; // 0x50
	private float evalX; // 0x58
	private float evalY; // 0x5C
	private float evalZ; // 0x60

	// Methods

	// RVA: 0x8D1EC0 Offset: 0x8D04C0 VA: 0x1808D1EC0
	private void Awake() { }

	// RVA: 0x8D1EF0 Offset: 0x8D04F0 VA: 0x1808D1EF0
	private void OnEnable() { }

	// RVA: 0x8D1F20 Offset: 0x8D0520 VA: 0x1808D1F20
	private void Update() { }

	// RVA: 0x8D2050 Offset: 0x8D0650 VA: 0x1808D2050
	public void .ctor() { }

}

public class ExplosionsShaderColorGradient : MonoBehaviour // TypeDefIndex: 11501
{	// Fields
	public string ShaderProperty; // 0x18
	public int MaterialID; // 0x20
	public Gradient Color; // 0x28
	public float TimeMultiplier; // 0x30
	private bool canUpdate; // 0x34
	private Material matInstance; // 0x38
	private int propertyID; // 0x40
	private float startTime; // 0x44
	private Color oldColor; // 0x48

	// Methods

	// RVA: 0x8D2190 Offset: 0x8D0790 VA: 0x1808D2190
	private void Start() { }

	// RVA: 0x8D2170 Offset: 0x8D0770 VA: 0x1808D2170
	private void OnEnable() { }

	// RVA: 0x8D2300 Offset: 0x8D0900 VA: 0x1808D2300
	private void Update() { }

	// RVA: 0x8D23D0 Offset: 0x8D09D0 VA: 0x1808D23D0
	public void .ctor() { }

}

public class ExplosionsShaderFloatCurves : MonoBehaviour // TypeDefIndex: 11502
{	// Fields
	public string ShaderProperty; // 0x18
	public int MaterialID; // 0x20
	public AnimationCurve FloatPropertyCurve; // 0x28
	public float GraphTimeMultiplier; // 0x30
	public float GraphScaleMultiplier; // 0x34
	private bool canUpdate; // 0x38
	private Material matInstance; // 0x40
	private int propertyID; // 0x48
	private float startTime; // 0x4C

	// Methods

	// RVA: 0x8D2470 Offset: 0x8D0A70 VA: 0x1808D2470
	private void Start() { }

	// RVA: 0x8D2450 Offset: 0x8D0A50 VA: 0x1808D2450
	private void OnEnable() { }

	// RVA: 0x8D25B0 Offset: 0x8D0BB0 VA: 0x1808D25B0
	private void Update() { }

	// RVA: 0x8D2630 Offset: 0x8D0C30 VA: 0x1808D2630
	public void .ctor() { }

}

public class ExplosionsShaderQueue : MonoBehaviour // TypeDefIndex: 11503
{	// Fields
	public int AddQueue; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8D27D0 Offset: 0x8D0DD0 VA: 0x1808D27D0
	private void Start() { }

	// RVA: 0x8D2750 Offset: 0x8D0D50 VA: 0x1808D2750
	private void SetProjectorQueue() { }

	// RVA: 0x8D26C0 Offset: 0x8D0CC0 VA: 0x1808D26C0
	private void OnDisable() { }

	// RVA: 0x8D28C0 Offset: 0x8D0EC0 VA: 0x1808D28C0
	public void .ctor() { }

}

internal class ExplosionsSpriteSheetAnimation : MonoBehaviour // TypeDefIndex: 11504
{	// Fields
	public int TilesX; // 0x18
	public int TilesY; // 0x1C
	public float AnimationFPS; // 0x20
	public bool IsInterpolateFrames; // 0x24
	public int StartFrameOffset; // 0x28
	public bool IsLoop; // 0x2C
	public float StartDelay; // 0x30
	public AnimationCurve FrameOverTime; // 0x38
	private bool isInizialised; // 0x40
	private int index; // 0x44
	private int count; // 0x48
	private int allCount; // 0x4C
	private float animationLifeTime; // 0x50
	private bool isVisible; // 0x54
	private bool isCorutineStarted; // 0x55
	private Renderer currentRenderer; // 0x58
	private Material instanceMaterial; // 0x60
	private float currentInterpolatedTime; // 0x68
	private float animationStartTime; // 0x6C
	private bool animationStoped; // 0x70

	// Methods

	// RVA: 0x8D2D70 Offset: 0x8D1370 VA: 0x1808D2D70
	private void Start() { }

	// RVA: 0x8D28D0 Offset: 0x8D0ED0 VA: 0x1808D28D0
	private void InitDefaultVariables() { }

	// RVA: 0x8D2CF0 Offset: 0x8D12F0 VA: 0x1808D2CF0
	private void Play() { }

	// RVA: 0x8D2C80 Offset: 0x8D1280 VA: 0x1808D2C80
	private void PlayDelay() { }

	// RVA: 0x8D2C50 Offset: 0x8D1250 VA: 0x1808D2C50
	private void OnEnable() { }

	// RVA: 0x8D2C00 Offset: 0x8D1200 VA: 0x1808D2C00
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB8830 Offset: 0xB7C30 VA: 0x1800B8830
	// RVA: 0x8D2DE0 Offset: 0x8D13E0 VA: 0x1808D2DE0
	private IEnumerator UpdateCorutine() { }

	// RVA: 0x8D2E50 Offset: 0x8D1450 VA: 0x1808D2E50
	private void UpdateFrame() { }

	// RVA: 0x8D2F80 Offset: 0x8D1580 VA: 0x1808D2F80
	private void Update() { }

	// RVA: 0x8D2B50 Offset: 0x8D1150 VA: 0x1808D2B50
	private void OnDestroy() { }

	// RVA: 0x8D3150 Offset: 0x8D1750 VA: 0x1808D3150
	public void .ctor() { }

}

private sealed class ExplosionsSpriteSheetAnimation.<UpdateCorutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11505
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExplosionsSpriteSheetAnimation <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8D99F0 Offset: 0x8D7FF0 VA: 0x1808D99F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9CA0 Offset: 0x8D82A0 VA: 0x1808D9CA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

