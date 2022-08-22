public class TreadAnimator : MonoBehaviour, IClientComponent // TypeDefIndex: 8864
{	// Fields
	public Animator mainBodyAnimator; // 0x18
	public Transform[] wheelBones; // 0x20
	public Vector3[] vecShocksOffsetPosition; // 0x28
	public Vector3[] wheelBoneOrigin; // 0x30
	public float wheelBoneDistMax; // 0x38
	public Renderer treadRenderer; // 0x40
	public Material leftTread; // 0x48
	public Material rightTread; // 0x50
	public TreadEffects treadEffects; // 0x58
	public float traceThickness; // 0x60
	public float heightFudge; // 0x64
	public bool useWheelYOrigin; // 0x68
	public Vector2 treadTextureDirection; // 0x6C
	public bool isMetallic; // 0x74
	private float angularVelocity; // 0x78
	private Vector3 lastForward; // 0x7C
	private Vector3 currentVelocity; // 0x88
	private Vector3 lastPos; // 0x94
	public float angularTreadConstant; // 0xA0
	public float treadConstant; // 0xA4
	public float wheelSpinConstant; // 0xA8
	private float wheelAngle; // 0xAC
	private float treadMovementL; // 0xB0
	private float treadMovementR; // 0xB4
	public float traceLineMin; // 0xB8
	public float traceLineMax; // 0xBC
	public float maxShockDist; // 0xC0
	private int cachedMask; // 0xC4

	// Methods

	// RVA: 0xA17F80 Offset: 0xA16580 VA: 0x180A17F80
	public void Awake() { }

	// RVA: 0xA192A0 Offset: 0xA178A0 VA: 0x180A192A0
	public void Update() { }

	// RVA: 0xA18340 Offset: 0xA16940 VA: 0x180A18340
	public void CalculateVelocity() { }

	// RVA: 0xA186A0 Offset: 0xA16CA0 VA: 0x180A186A0
	public Vector3 GetCurrentVelocity() { }

	// RVA: 0xA18690 Offset: 0xA16C90 VA: 0x180A18690
	public float GetAngularSpeed() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900
	public float GetSpeed(bool rightSide) { }

	// RVA: 0xA17D50 Offset: 0xA16350 VA: 0x180A17D50
	private void AnimateWheelsTreads() { }

	// RVA: 0xA188A0 Offset: 0xA16EA0 VA: 0x180A188A0
	public void UpdateHeights() { }

	// RVA: 0xA19370 Offset: 0xA17970 VA: 0x180A19370
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA186C0 Offset: 0xA16CC0 VA: 0x180A186C0
	private void <AnimateWheelsTreads>g__AnimateTreadWheel|30_0(ref float treadMovement, ref Material treadMat, bool left, ref TreadAnimator.<>c__DisplayClass30_0 ) { }

}

private struct TreadAnimator.<>c__DisplayClass30_0 // TypeDefIndex: 8865
{	// Fields
	public float forwardSpeed; // 0x0
	public float angularSpeed; // 0x4
	public TreadAnimator <>4__this; // 0x8

}

