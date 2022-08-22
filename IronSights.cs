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

	// RVA: 0xA24330 Offset: 0xA22930 VA: 0x180A24330
	public void OnEnable() { }

	// RVA: 0xA24EC0 Offset: 0xA234C0 VA: 0x180A24EC0
	public void Update() { }

	// RVA: 0xA244A0 Offset: 0xA22AA0 VA: 0x180A244A0
	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	// RVA: 0xA241C0 Offset: 0xA227C0 VA: 0x180A241C0
	private float GetUltrawideOffset() { }

	// RVA: 0xA24390 Offset: 0xA22990 VA: 0x180A24390
	public void SetIronsightsEnabled(bool b) { }

	// RVA: 0xA24390 Offset: 0xA22990 VA: 0x180A24390
	public void SetEnabled(bool val) { }

	// RVA: 0xA24010 Offset: 0xA22610 VA: 0x180A24010
	public float GetFOVOffset(float fFOV) { }

	// RVA: 0x5C33A0 Offset: 0x5C19A0 VA: 0x1805C33A0
	public float GetDelta() { }

	// RVA: 0xA25150 Offset: 0xA23750 VA: 0x180A25150
	public void .ctor() { }

}

