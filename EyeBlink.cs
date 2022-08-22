public class EyeBlink : MonoBehaviour // TypeDefIndex: 9345
{	// Fields
	public Transform LeftEye; // 0x18
	public Transform LeftEyelid; // 0x20
	public Vector3 LeftEyeOffset; // 0x28
	public Transform RightEye; // 0x38
	public Transform RightEyelid; // 0x40
	public Vector3 RightEyeOffset; // 0x48
	public Vector3 ClosedEyelidPosition; // 0x54
	public Vector3 ClosedEyelidRotation; // 0x60
	public Vector2 TimeWithoutBlinking; // 0x6C
	public float BlinkSpeed; // 0x74
	public Vector3 LeftEyeInitial; // 0x78
	public Vector3 RightEyeInitial; // 0x84
	private TimeUntil BlinkCountdown; // 0x90

	// Methods

	// RVA: 0x8D43E0 Offset: 0x8D29E0 VA: 0x1808D43E0
	private void Start() { }

	// RVA: 0x8D3FC0 Offset: 0x8D25C0 VA: 0x1808D3FC0
	public void LateUpdateBlink() { }

	// RVA: 0x8D3E80 Offset: 0x8D2480 VA: 0x1808D3E80
	public void CloseEyes() { }

	// RVA: 0x8D4410 Offset: 0x8D2A10 VA: 0x1808D4410
	public void .ctor() { }

}

