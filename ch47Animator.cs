public class ch47Animator : MonoBehaviour // TypeDefIndex: 8856
{	// Fields
	public Animator animator; // 0x18
	public bool bottomDoorOpen; // 0x20
	public bool landingGearDown; // 0x21
	public bool leftDoorOpen; // 0x22
	public bool rightDoorOpen; // 0x23
	public bool rearDoorOpen; // 0x24
	public bool rearDoorExtensionOpen; // 0x25
	public Transform rearRotorBlade; // 0x28
	public Transform frontRotorBlade; // 0x30
	public float rotorBladeSpeed; // 0x38
	public float wheelTurnSpeed; // 0x3C
	public float wheelTurnAngle; // 0x40
	public SkinnedMeshRenderer[] blurredRotorBlades; // 0x48
	public SkinnedMeshRenderer[] RotorBlades; // 0x50
	private bool blurredRotorBladesEnabled; // 0x58
	public float blurSpeedThreshold; // 0x5C

	// Methods

	// RVA: 0x1A7D220 Offset: 0x1A7B820 VA: 0x181A7D220
	private void Start() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void SetDropDoorOpen(bool isOpen) { }

	// RVA: 0x1A7D280 Offset: 0x1A7B880 VA: 0x181A7D280
	private void Update() { }

	// RVA: 0x1A7D0B0 Offset: 0x1A7B6B0 VA: 0x181A7D0B0
	private void LateUpdate() { }

	// RVA: 0x1A7CFD0 Offset: 0x1A7B5D0 VA: 0x181A7CFD0
	private void EnableBlurredRotorBlades(bool enabled) { }

	// RVA: 0x1A7D3F0 Offset: 0x1A7B9F0 VA: 0x181A7D3F0
	public void .ctor() { }

}

