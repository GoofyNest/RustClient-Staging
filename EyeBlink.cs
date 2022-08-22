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

	// RVA: 0x8D48F0 Offset: 0x8D2EF0 VA: 0x1808D48F0
	private void Start() { }

	// RVA: 0x8D44D0 Offset: 0x8D2AD0 VA: 0x1808D44D0
	public void LateUpdateBlink() { }

	// RVA: 0x8D4390 Offset: 0x8D2990 VA: 0x1808D4390
	public void CloseEyes() { }

	// RVA: 0x8D4920 Offset: 0x8D2F20 VA: 0x1808D4920
	public void .ctor() { }

}

