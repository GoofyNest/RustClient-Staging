public class IronSights : MonoBehaviour // TypeDefIndex: 11440
{	// Fields
	public bool Enabled; // 0x18
	[HeaderAttribute] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	public IronsightAimPoint aimPoint; // 0x20
	public float fieldOfViewOffset; // 0x28
	public float zoomFactor; // 0x2C
	[HeaderAttribute] // RVA: 0xB0910 Offset: 0xAFD10 VA: 0x1800B0910
	public float introSpeed; // 0x30
	public AnimationCurve introCurve; // 0x38
	public float outroSpeed; // 0x40
	public AnimationCurve outroCurve; // 0x48
	[HeaderAttribute] // RVA: 0xA9FF0 Offset: 0xA93F0 VA: 0x1800A9FF0
	public SoundDefinition upSound; // 0x50
	public SoundDefinition downSound; // 0x58
	[HeaderAttribute] // RVA: 0xB09D0 Offset: 0xAFDD0 VA: 0x1800B09D0
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

	// RVA: 0xA24070 Offset: 0xA22670 VA: 0x180A24070
	public void OnEnable() { }

	// RVA: 0xA24C00 Offset: 0xA23200 VA: 0x180A24C00
	public void Update() { }

	// RVA: 0xA241E0 Offset: 0xA227E0 VA: 0x180A241E0
	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	// RVA: 0xA23F00 Offset: 0xA22500 VA: 0x180A23F00
	private float GetUltrawideOffset() { }

	// RVA: 0xA240D0 Offset: 0xA226D0 VA: 0x180A240D0
	public void SetIronsightsEnabled(bool b) { }

	// RVA: 0xA240D0 Offset: 0xA226D0 VA: 0x180A240D0
	public void SetEnabled(bool val) { }

	// RVA: 0xA23D50 Offset: 0xA22350 VA: 0x180A23D50
	public float GetFOVOffset(float fFOV) { }

	// RVA: 0x5C33A0 Offset: 0x5C19A0 VA: 0x1805C33A0
	public float GetDelta() { }

	// RVA: 0xA24E90 Offset: 0xA23490 VA: 0x180A24E90
	public void .ctor() { }

}

