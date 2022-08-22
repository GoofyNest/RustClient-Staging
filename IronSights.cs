public class IronSights : MonoBehaviour // TypeDefIndex: 11440
{	// Fields
	public bool Enabled; // 0x18
	[HeaderAttribute] // RVA: 0xB0980 Offset: 0xAFD80 VA: 0x1800B0980
	public IronsightAimPoint aimPoint; // 0x20
	public float fieldOfViewOffset; // 0x28
	public float zoomFactor; // 0x2C
	[HeaderAttribute] // RVA: 0xB0A10 Offset: 0xAFE10 VA: 0x1800B0A10
	public float introSpeed; // 0x30
	public AnimationCurve introCurve; // 0x38
	public float outroSpeed; // 0x40
	public AnimationCurve outroCurve; // 0x48
	[HeaderAttribute] // RVA: 0xAA090 Offset: 0xA9490 VA: 0x1800AA090
	public SoundDefinition upSound; // 0x50
	public SoundDefinition downSound; // 0x58
	[HeaderAttribute] // RVA: 0xB0A70 Offset: 0xAFE70 VA: 0x1800B0A70
	public IronSightOverride ironsightsOverride; // 0x60
	public bool processUltrawideOffset; // 0x68
	private Animator animator; // 0x70
	private int param_ironsightstrength; // 0x78
	private int param_ironsightsEnabled; // 0x7C
	private float delta; // 0x80
	private float rawDelta; // 0x84
	private float maxDelta; // 0x88
	private Vector3 positionOffset; // 0x8C
	private Quaternion rotationOffset; // 0x98
	private AnimationCurve currentCurve; // 0xA8

	// Methods

	// RVA: 0xA24820 Offset: 0xA22E20 VA: 0x180A24820
	public void OnEnable() { }

	// RVA: 0xA253B0 Offset: 0xA239B0 VA: 0x180A253B0
	public void Update() { }

	// RVA: 0xA24990 Offset: 0xA22F90 VA: 0x180A24990
	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	// RVA: 0xA246B0 Offset: 0xA22CB0 VA: 0x180A246B0
	private float GetUltrawideOffset() { }

	// RVA: 0xA24880 Offset: 0xA22E80 VA: 0x180A24880
	public void SetIronsightsEnabled(bool b) { }

	// RVA: 0xA24880 Offset: 0xA22E80 VA: 0x180A24880
	public void SetEnabled(bool val) { }

	// RVA: 0xA24500 Offset: 0xA22B00 VA: 0x180A24500
	public float GetFOVOffset(float fFOV) { }

	// RVA: 0x5C3330 Offset: 0x5C1930 VA: 0x1805C3330
	public float GetDelta() { }

	// RVA: 0xA25640 Offset: 0xA23C40 VA: 0x180A25640
	public void .ctor() { }

}

