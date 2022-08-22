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

	// RVA: 0x1A90A10 Offset: 0x1A8F010 VA: 0x181A90A10
	private void Start() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void SetDropDoorOpen(bool isOpen) { }

	// RVA: 0x1A90A70 Offset: 0x1A8F070 VA: 0x181A90A70
	private void Update() { }

	// RVA: 0x1A908A0 Offset: 0x1A8EEA0 VA: 0x181A908A0
	private void LateUpdate() { }

	// RVA: 0x1A907C0 Offset: 0x1A8EDC0 VA: 0x181A907C0
	private void EnableBlurredRotorBlades(bool enabled) { }

	// RVA: 0x1A90BE0 Offset: 0x1A8F1E0 VA: 0x181A90BE0
	public void .ctor() { }

}

