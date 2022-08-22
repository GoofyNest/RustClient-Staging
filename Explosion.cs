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

	// RVA: 0x8D15D0 Offset: 0x8CFBD0 VA: 0x1808D15D0
	public Shader get_shader() { }

	// RVA: 0x8D14A0 Offset: 0x8CFAA0 VA: 0x1808D14A0
	public Material get_material() { }

	// RVA: 0x8D0640 Offset: 0x8CEC40 VA: 0x1808D0640
	public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect) { }

	// RVA: 0x8D0580 Offset: 0x8CEB80 VA: 0x1808D0580
	public static Material CheckShaderAndCreateMaterial(Shader s) { }

	// RVA: 0x8D1660 Offset: 0x8CFC60 VA: 0x1808D1660
	public static bool get_supportsDX11() { }

	// RVA: 0x8D04F0 Offset: 0x8CEAF0 VA: 0x1808D04F0
	private void Awake() { }

	// RVA: 0x8D0A70 Offset: 0x8CF070 VA: 0x1808D0A70
	private void OnEnable() { }

	// RVA: 0x8D09C0 Offset: 0x8CEFC0 VA: 0x1808D09C0
	private void OnDisable() { }

	// RVA: 0x8D0AC0 Offset: 0x8CF0C0 VA: 0x1808D0AC0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x8D1410 Offset: 0x8CFA10 VA: 0x1808D1410
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

	// RVA: 0x8D6F40 Offset: 0x8D5540 VA: 0x1808D6F40
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

	// RVA: 0x8CFFA0 Offset: 0x8CE5A0 VA: 0x1808CFFA0
	private void Start() { }

	// RVA: 0x8CFC50 Offset: 0x8CE250 VA: 0x1808CFC50
	private void OnGUI() { }

	// RVA: 0x8CFA80 Offset: 0x8CE080 VA: 0x1808CFA80
	private void ChangeCurrent(int delta) { }

	// RVA: 0x8D01C0 Offset: 0x8CE7C0 VA: 0x1808D01C0
	public void .ctor() { }

}

public class ExplosionDemoReactivator : MonoBehaviour // TypeDefIndex: 11493
{	// Fields
	public float TimeDelayToReactivate; // 0x18

	// Methods

	// RVA: 0x8D0300 Offset: 0x8CE900 VA: 0x1808D0300
	private void Start() { }

	// RVA: 0x8D0230 Offset: 0x8CE830 VA: 0x1808D0230
	private void Reactivate() { }

	// RVA: 0x8D0350 Offset: 0x8CE950 VA: 0x1808D0350
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

	// RVA: 0x8D03B0 Offset: 0x8CE9B0 VA: 0x1808D03B0
	private void Start() { }

	// RVA: 0x8D0360 Offset: 0x8CE960 VA: 0x1808D0360
	private void Init() { }

	// RVA: 0x8D0400 Offset: 0x8CEA00 VA: 0x1808D0400
	private void Update() { }

	// RVA: 0x8D0390 Offset: 0x8CE990 VA: 0x1808D0390
	private void OnTriggerEnter(Collider coll) { }

	// RVA: 0x8D03A0 Offset: 0x8CE9A0 VA: 0x1808D03A0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x8D04D0 Offset: 0x8CEAD0 VA: 0x1808D04D0
	public void .ctor() { }

}

public class ExplosionsFPS : MonoBehaviour // TypeDefIndex: 11495
{	// Fields
	private readonly GUIStyle guiStyleHeader; // 0x18
	private float timeleft; // 0x20
	private float fps; // 0x24
	private int frames; // 0x28

	// Methods

	// RVA: 0x8D1C10 Offset: 0x8D0210 VA: 0x1808D1C10
	private void Awake() { }

	// RVA: 0x8D1CA0 Offset: 0x8D02A0 VA: 0x1808D1CA0
	private void OnGUI() { }

	// RVA: 0x8D1D80 Offset: 0x8D0380 VA: 0x1808D1D80
	private void Update() { }

	// RVA: 0x8D1DE0 Offset: 0x8D03E0 VA: 0x1808D1DE0
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

	// RVA: 0x8D1690 Offset: 0x8CFC90 VA: 0x1808D1690
	private void Awake() { }

	// RVA: 0x8D1920 Offset: 0x8CFF20 VA: 0x1808D1920
	private void Update() { }

	// RVA: 0x8D1B20 Offset: 0x8D0120 VA: 0x1808D1B20
	public void .ctor() { }

}

public class ExplosionsDeactivateRendererByTime : MonoBehaviour // TypeDefIndex: 11497
{	// Fields
	public float TimeDelay; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8D1B30 Offset: 0x8D0130 VA: 0x1808D1B30
	private void Awake() { }

	// RVA: 0x8D1B80 Offset: 0x8D0180 VA: 0x1808D1B80
	private void DeactivateRenderer() { }

	// RVA: 0x8D1BB0 Offset: 0x8D01B0 VA: 0x1808D1BB0
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

	// RVA: 0x8D1E50 Offset: 0x8D0450 VA: 0x1808D1E50
	private void Awake() { }

	// RVA: 0x8D1EE0 Offset: 0x8D04E0 VA: 0x1808D1EE0
	private void OnEnable() { }

	// RVA: 0x8D1F00 Offset: 0x8D0500 VA: 0x1808D1F00
	private void Update() { }

	// RVA: 0x8D1F70 Offset: 0x8D0570 VA: 0x1808D1F70
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

	// RVA: 0x8D1FD0 Offset: 0x8D05D0 VA: 0x1808D1FD0
	private void Awake() { }

	// RVA: 0x8D2000 Offset: 0x8D0600 VA: 0x1808D2000
	private void OnEnable() { }

	// RVA: 0x8D2030 Offset: 0x8D0630 VA: 0x1808D2030
	private void Update() { }

	// RVA: 0x8D2160 Offset: 0x8D0760 VA: 0x1808D2160
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

	// RVA: 0x8D22A0 Offset: 0x8D08A0 VA: 0x1808D22A0
	private void Start() { }

	// RVA: 0x8D2280 Offset: 0x8D0880 VA: 0x1808D2280
	private void OnEnable() { }

	// RVA: 0x8D2410 Offset: 0x8D0A10 VA: 0x1808D2410
	private void Update() { }

	// RVA: 0x8D24E0 Offset: 0x8D0AE0 VA: 0x1808D24E0
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

	// RVA: 0x8D2580 Offset: 0x8D0B80 VA: 0x1808D2580
	private void Start() { }

	// RVA: 0x8D2560 Offset: 0x8D0B60 VA: 0x1808D2560
	private void OnEnable() { }

	// RVA: 0x8D26C0 Offset: 0x8D0CC0 VA: 0x1808D26C0
	private void Update() { }

	// RVA: 0x8D2740 Offset: 0x8D0D40 VA: 0x1808D2740
	public void .ctor() { }

}

public class ExplosionsShaderQueue : MonoBehaviour // TypeDefIndex: 11503
{	// Fields
	public int AddQueue; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8D28E0 Offset: 0x8D0EE0 VA: 0x1808D28E0
	private void Start() { }

	// RVA: 0x8D2860 Offset: 0x8D0E60 VA: 0x1808D2860
	private void SetProjectorQueue() { }

	// RVA: 0x8D27D0 Offset: 0x8D0DD0 VA: 0x1808D27D0
	private void OnDisable() { }

	// RVA: 0x8D29D0 Offset: 0x8D0FD0 VA: 0x1808D29D0
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

	// RVA: 0x8D2E80 Offset: 0x8D1480 VA: 0x1808D2E80
	private void Start() { }

	// RVA: 0x8D29E0 Offset: 0x8D0FE0 VA: 0x1808D29E0
	private void InitDefaultVariables() { }

	// RVA: 0x8D2E00 Offset: 0x8D1400 VA: 0x1808D2E00
	private void Play() { }

	// RVA: 0x8D2D90 Offset: 0x8D1390 VA: 0x1808D2D90
	private void PlayDelay() { }

	// RVA: 0x8D2D60 Offset: 0x8D1360 VA: 0x1808D2D60
	private void OnEnable() { }

	// RVA: 0x8D2D10 Offset: 0x8D1310 VA: 0x1808D2D10
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB8830 Offset: 0xB7C30 VA: 0x1800B8830
	// RVA: 0x8D2EF0 Offset: 0x8D14F0 VA: 0x1808D2EF0
	private IEnumerator UpdateCorutine() { }

	// RVA: 0x8D2F60 Offset: 0x8D1560 VA: 0x1808D2F60
	private void UpdateFrame() { }

	// RVA: 0x8D3090 Offset: 0x8D1690 VA: 0x1808D3090
	private void Update() { }

	// RVA: 0x8D2C60 Offset: 0x8D1260 VA: 0x1808D2C60
	private void OnDestroy() { }

	// RVA: 0x8D3260 Offset: 0x8D1860 VA: 0x1808D3260
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

	// RVA: 0x8D9B00 Offset: 0x8D8100 VA: 0x1808D9B00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9DB0 Offset: 0x8D83B0 VA: 0x1808D9DB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

