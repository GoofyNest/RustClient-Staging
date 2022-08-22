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

	// RVA: 0x8D1AE0 Offset: 0x8D00E0 VA: 0x1808D1AE0
	public Shader get_shader() { }

	// RVA: 0x8D19B0 Offset: 0x8CFFB0 VA: 0x1808D19B0
	public Material get_material() { }

	// RVA: 0x8D0B50 Offset: 0x8CF150 VA: 0x1808D0B50
	public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect) { }

	// RVA: 0x8D0A90 Offset: 0x8CF090 VA: 0x1808D0A90
	public static Material CheckShaderAndCreateMaterial(Shader s) { }

	// RVA: 0x8D1B70 Offset: 0x8D0170 VA: 0x1808D1B70
	public static bool get_supportsDX11() { }

	// RVA: 0x8D0A00 Offset: 0x8CF000 VA: 0x1808D0A00
	private void Awake() { }

	// RVA: 0x8D0F80 Offset: 0x8CF580 VA: 0x1808D0F80
	private void OnEnable() { }

	// RVA: 0x8D0ED0 Offset: 0x8CF4D0 VA: 0x1808D0ED0
	private void OnDisable() { }

	// RVA: 0x8D0FD0 Offset: 0x8CF5D0 VA: 0x1808D0FD0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x8D1920 Offset: 0x8CFF20 VA: 0x1808D1920
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

	// RVA: 0x8D7450 Offset: 0x8D5A50 VA: 0x1808D7450
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

	// RVA: 0x8D04B0 Offset: 0x8CEAB0 VA: 0x1808D04B0
	private void Start() { }

	// RVA: 0x8D0160 Offset: 0x8CE760 VA: 0x1808D0160
	private void OnGUI() { }

	// RVA: 0x8CFF90 Offset: 0x8CE590 VA: 0x1808CFF90
	private void ChangeCurrent(int delta) { }

	// RVA: 0x8D06D0 Offset: 0x8CECD0 VA: 0x1808D06D0
	public void .ctor() { }

}

public class ExplosionDemoReactivator : MonoBehaviour // TypeDefIndex: 11493
{	// Fields
	public float TimeDelayToReactivate; // 0x18

	// Methods

	// RVA: 0x8D0810 Offset: 0x8CEE10 VA: 0x1808D0810
	private void Start() { }

	// RVA: 0x8D0740 Offset: 0x8CED40 VA: 0x1808D0740
	private void Reactivate() { }

	// RVA: 0x8D0860 Offset: 0x8CEE60 VA: 0x1808D0860
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

	// RVA: 0x8D08C0 Offset: 0x8CEEC0 VA: 0x1808D08C0
	private void Start() { }

	// RVA: 0x8D0870 Offset: 0x8CEE70 VA: 0x1808D0870
	private void Init() { }

	// RVA: 0x8D0910 Offset: 0x8CEF10 VA: 0x1808D0910
	private void Update() { }

	// RVA: 0x8D08A0 Offset: 0x8CEEA0 VA: 0x1808D08A0
	private void OnTriggerEnter(Collider coll) { }

	// RVA: 0x8D08B0 Offset: 0x8CEEB0 VA: 0x1808D08B0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x8D09E0 Offset: 0x8CEFE0 VA: 0x1808D09E0
	public void .ctor() { }

}

public class ExplosionsFPS : MonoBehaviour // TypeDefIndex: 11495
{	// Fields
	private readonly GUIStyle guiStyleHeader; // 0x18
	private float timeleft; // 0x20
	private float fps; // 0x24
	private int frames; // 0x28

	// Methods

	// RVA: 0x8D2120 Offset: 0x8D0720 VA: 0x1808D2120
	private void Awake() { }

	// RVA: 0x8D21B0 Offset: 0x8D07B0 VA: 0x1808D21B0
	private void OnGUI() { }

	// RVA: 0x8D2290 Offset: 0x8D0890 VA: 0x1808D2290
	private void Update() { }

	// RVA: 0x8D22F0 Offset: 0x8D08F0 VA: 0x1808D22F0
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

	// RVA: 0x8D1BA0 Offset: 0x8D01A0 VA: 0x1808D1BA0
	private void Awake() { }

	// RVA: 0x8D1E30 Offset: 0x8D0430 VA: 0x1808D1E30
	private void Update() { }

	// RVA: 0x8D2030 Offset: 0x8D0630 VA: 0x1808D2030
	public void .ctor() { }

}

public class ExplosionsDeactivateRendererByTime : MonoBehaviour // TypeDefIndex: 11497
{	// Fields
	public float TimeDelay; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8D2040 Offset: 0x8D0640 VA: 0x1808D2040
	private void Awake() { }

	// RVA: 0x8D2090 Offset: 0x8D0690 VA: 0x1808D2090
	private void DeactivateRenderer() { }

	// RVA: 0x8D20C0 Offset: 0x8D06C0 VA: 0x1808D20C0
	private void OnEnable() { }

	// RVA: 0x5718F0 Offset: 0x56FEF0 VA: 0x1805718F0
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

	// RVA: 0x8D2360 Offset: 0x8D0960 VA: 0x1808D2360
	private void Awake() { }

	// RVA: 0x8D23F0 Offset: 0x8D09F0 VA: 0x1808D23F0
	private void OnEnable() { }

	// RVA: 0x8D2410 Offset: 0x8D0A10 VA: 0x1808D2410
	private void Update() { }

	// RVA: 0x8D2480 Offset: 0x8D0A80 VA: 0x1808D2480
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

	// RVA: 0x5718F0 Offset: 0x56FEF0 VA: 0x1805718F0
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

	// RVA: 0x8D24E0 Offset: 0x8D0AE0 VA: 0x1808D24E0
	private void Awake() { }

	// RVA: 0x8D2510 Offset: 0x8D0B10 VA: 0x1808D2510
	private void OnEnable() { }

	// RVA: 0x8D2540 Offset: 0x8D0B40 VA: 0x1808D2540
	private void Update() { }

	// RVA: 0x8D2670 Offset: 0x8D0C70 VA: 0x1808D2670
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

	// RVA: 0x8D27B0 Offset: 0x8D0DB0 VA: 0x1808D27B0
	private void Start() { }

	// RVA: 0x8D2790 Offset: 0x8D0D90 VA: 0x1808D2790
	private void OnEnable() { }

	// RVA: 0x8D2920 Offset: 0x8D0F20 VA: 0x1808D2920
	private void Update() { }

	// RVA: 0x8D29F0 Offset: 0x8D0FF0 VA: 0x1808D29F0
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

	// RVA: 0x8D2A90 Offset: 0x8D1090 VA: 0x1808D2A90
	private void Start() { }

	// RVA: 0x8D2A70 Offset: 0x8D1070 VA: 0x1808D2A70
	private void OnEnable() { }

	// RVA: 0x8D2BD0 Offset: 0x8D11D0 VA: 0x1808D2BD0
	private void Update() { }

	// RVA: 0x8D2C50 Offset: 0x8D1250 VA: 0x1808D2C50
	public void .ctor() { }

}

public class ExplosionsShaderQueue : MonoBehaviour // TypeDefIndex: 11503
{	// Fields
	public int AddQueue; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8D2DF0 Offset: 0x8D13F0 VA: 0x1808D2DF0
	private void Start() { }

	// RVA: 0x8D2D70 Offset: 0x8D1370 VA: 0x1808D2D70
	private void SetProjectorQueue() { }

	// RVA: 0x8D2CE0 Offset: 0x8D12E0 VA: 0x1808D2CE0
	private void OnDisable() { }

	// RVA: 0x8D2EE0 Offset: 0x8D14E0 VA: 0x1808D2EE0
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

	// RVA: 0x8D3390 Offset: 0x8D1990 VA: 0x1808D3390
	private void Start() { }

	// RVA: 0x8D2EF0 Offset: 0x8D14F0 VA: 0x1808D2EF0
	private void InitDefaultVariables() { }

	// RVA: 0x8D3310 Offset: 0x8D1910 VA: 0x1808D3310
	private void Play() { }

	// RVA: 0x8D32A0 Offset: 0x8D18A0 VA: 0x1808D32A0
	private void PlayDelay() { }

	// RVA: 0x8D3270 Offset: 0x8D1870 VA: 0x1808D3270
	private void OnEnable() { }

	// RVA: 0x8D3220 Offset: 0x8D1820 VA: 0x1808D3220
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB8830 Offset: 0xB7C30 VA: 0x1800B8830
	// RVA: 0x8D3400 Offset: 0x8D1A00 VA: 0x1808D3400
	private IEnumerator UpdateCorutine() { }

	// RVA: 0x8D3470 Offset: 0x8D1A70 VA: 0x1808D3470
	private void UpdateFrame() { }

	// RVA: 0x8D35A0 Offset: 0x8D1BA0 VA: 0x1808D35A0
	private void Update() { }

	// RVA: 0x8D3170 Offset: 0x8D1770 VA: 0x1808D3170
	private void OnDestroy() { }

	// RVA: 0x8D3770 Offset: 0x8D1D70 VA: 0x1808D3770
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

	// RVA: 0x8DA010 Offset: 0x8D8610 VA: 0x1808DA010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8DA2C0 Offset: 0x8D88C0 VA: 0x1808DA2C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

