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

	// RVA: 0x8D42D0 Offset: 0x8D28D0 VA: 0x1808D42D0
	private void Start() { }

	// RVA: 0x8D3EB0 Offset: 0x8D24B0 VA: 0x1808D3EB0
	public void LateUpdateBlink() { }

	// RVA: 0x8D3D70 Offset: 0x8D2370 VA: 0x1808D3D70
	public void CloseEyes() { }

	// RVA: 0x8D4300 Offset: 0x8D2900 VA: 0x1808D4300
	public void .ctor() { }

}

