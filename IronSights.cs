public class IronSights : MonoBehaviour // TypeDefIndex: 11444
{	public bool Enabled; // 0x18
	[HeaderAttribute] // RVA: 0xB0AF0 Offset: 0xAFEF0 VA: 0x1800B0AF0
	public IronsightAimPoint aimPoint; // 0x20
	public float fieldOfViewOffset; // 0x28
	public float zoomFactor; // 0x2C
	[HeaderAttribute] // RVA: 0xB0B50 Offset: 0xAFF50 VA: 0x1800B0B50
	public float introSpeed; // 0x30
	public AnimationCurve introCurve; // 0x38
	public float outroSpeed; // 0x40
	public AnimationCurve outroCurve; // 0x48
	[HeaderAttribute] // RVA: 0xAA1A0 Offset: 0xA95A0 VA: 0x1800AA1A0
	public SoundDefinition upSound; // 0x50
	public SoundDefinition downSound; // 0x58
	[HeaderAttribute] // RVA: 0xB0C10 Offset: 0xB0010 VA: 0x1800B0C10
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


	public void OnEnable() { }

	public void Update() { }

	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	private float GetUltrawideOffset() { }

	public void SetIronsightsEnabled(bool b) { }

	public void SetEnabled(bool val) { }

	public float GetFOVOffset(float fFOV) { }

	public float GetDelta() { }

	public void .ctor() { }

}

