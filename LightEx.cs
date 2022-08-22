public class LightEx : UpdateBehaviour, IClientComponent // TypeDefIndex: 9196
{	// Fields
	public bool alterColor; // 0x20
	public float colorTimeScale; // 0x24
	public Color colorA; // 0x28
	public Color colorB; // 0x38
	public AnimationCurve blendCurve; // 0x48
	public bool loopColor; // 0x50
	public bool alterIntensity; // 0x51
	public float intensityTimeScale; // 0x54
	public AnimationCurve intenseCurve; // 0x58
	public float intensityCurveScale; // 0x60
	public bool loopIntensity; // 0x64
	public bool randomOffset; // 0x65
	public float randomIntensityStartScale; // 0x68
	private float initialRange; // 0x6C
	private Color initialColor; // 0x70
	private float initialIntensity; // 0x80
	private Light lightComponent; // 0x88
	private bool canToggleLight; // 0x90
	private float time; // 0x94
	private LightLOD lightLOD; // 0x98

	// Methods

	// RVA: 0x4EF420 Offset: 0x4EDA20 VA: 0x1804EF420
	protected void Awake() { }

	// RVA: 0x4EFAB0 Offset: 0x4EE0B0 VA: 0x1804EFAB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x4EFA20 Offset: 0x4EE020 VA: 0x1804EFA20 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x4EF670 Offset: 0x4EDC70 VA: 0x1804EF670 Slot: 4
	public override void DeltaUpdate(float deltaTime) { }

	// RVA: 0x4EFC00 Offset: 0x4EE200 VA: 0x1804EFC00
	protected void OnValidate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool CheckConflict(GameObject go) { }

	// RVA: 0x4EFC10 Offset: 0x4EE210 VA: 0x1804EFC10
	public void .ctor() { }

}

