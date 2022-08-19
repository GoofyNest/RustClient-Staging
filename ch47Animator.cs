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

	// RVA: 0x1AA6AE0 Offset: 0x1AA50E0 VA: 0x181AA6AE0
	private void Start() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void SetDropDoorOpen(bool isOpen) { }

	// RVA: 0x1AA6B40 Offset: 0x1AA5140 VA: 0x181AA6B40
	private void Update() { }

	// RVA: 0x1AA6970 Offset: 0x1AA4F70 VA: 0x181AA6970
	private void LateUpdate() { }

	// RVA: 0x1AA6890 Offset: 0x1AA4E90 VA: 0x181AA6890
	private void EnableBlurredRotorBlades(bool enabled) { }

	// RVA: 0x1AA6CB0 Offset: 0x1AA52B0 VA: 0x181AA6CB0
	public void .ctor() { }

}

