public class EyeController : MonoBehaviour // TypeDefIndex: 9346
{	// Fields
	public const float MaxLookDot = 0,8;
	public bool debug; // 0x18
	public Transform LeftEye; // 0x20
	public Transform RightEye; // 0x28
	public Transform EyeTransform; // 0x30
	public Vector3 Fudge; // 0x38
	public Vector3 FlickerRange; // 0x44
	private Transform Focus; // 0x50
	private float FocusUpdateTime; // 0x58
	private Vector3 Flicker; // 0x5C
	private Vector3 FlickerTarget; // 0x68
	private float TimeToUpdateFlicker; // 0x74
	private float FlickerSpeed; // 0x78

	// Methods

	// RVA: 0x8D47B0 Offset: 0x8D2DB0 VA: 0x1808D47B0
	public void UpdateEyes() { }

	// RVA: 0x8D44E0 Offset: 0x8D2AE0 VA: 0x1808D44E0
	private void UpdateEye(Transform eye, Vector3 LookAt) { }

	// RVA: 0x8D4B10 Offset: 0x8D3110 VA: 0x1808D4B10
	private void UpdateFlicker() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void UpdateFocus(Vector3 defaultLookAtPos) { }

	// RVA: 0x8D4D70 Offset: 0x8D3370 VA: 0x1808D4D70
	public void .ctor() { }

}

