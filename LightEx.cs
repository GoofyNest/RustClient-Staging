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

	// RVA: 0x4EF490 Offset: 0x4EDA90 VA: 0x1804EF490
	protected void Awake() { }

	// RVA: 0x4EFB20 Offset: 0x4EE120 VA: 0x1804EFB20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x4EFA90 Offset: 0x4EE090 VA: 0x1804EFA90 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x4EF6E0 Offset: 0x4EDCE0 VA: 0x1804EF6E0 Slot: 4
	public override void DeltaUpdate(float deltaTime) { }

	// RVA: 0x4EFC70 Offset: 0x4EE270 VA: 0x1804EFC70
	protected void OnValidate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool CheckConflict(GameObject go) { }

	// RVA: 0x4EFC80 Offset: 0x4EE280 VA: 0x1804EFC80
	public void .ctor() { }

}

