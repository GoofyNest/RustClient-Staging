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

	// RVA: 0x1A90750 Offset: 0x1A8ED50 VA: 0x181A90750
	private void Start() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void SetDropDoorOpen(bool isOpen) { }

	// RVA: 0x1A907B0 Offset: 0x1A8EDB0 VA: 0x181A907B0
	private void Update() { }

	// RVA: 0x1A905E0 Offset: 0x1A8EBE0 VA: 0x181A905E0
	private void LateUpdate() { }

	// RVA: 0x1A90500 Offset: 0x1A8EB00 VA: 0x181A90500
	private void EnableBlurredRotorBlades(bool enabled) { }

	// RVA: 0x1A90920 Offset: 0x1A8EF20 VA: 0x181A90920
	public void .ctor() { }

}

