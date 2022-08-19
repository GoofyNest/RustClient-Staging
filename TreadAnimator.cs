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

	// RVA: 0xA17CC0 Offset: 0xA162C0 VA: 0x180A17CC0
	public void Awake() { }

	// RVA: 0xA18FE0 Offset: 0xA175E0 VA: 0x180A18FE0
	public void Update() { }

	// RVA: 0xA18080 Offset: 0xA16680 VA: 0x180A18080
	public void CalculateVelocity() { }

	// RVA: 0xA183E0 Offset: 0xA169E0 VA: 0x180A183E0
	public Vector3 GetCurrentVelocity() { }

	// RVA: 0xA183D0 Offset: 0xA169D0 VA: 0x180A183D0
	public float GetAngularSpeed() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900
	public float GetSpeed(bool rightSide) { }

	// RVA: 0xA17A90 Offset: 0xA16090 VA: 0x180A17A90
	private void AnimateWheelsTreads() { }

	// RVA: 0xA185E0 Offset: 0xA16BE0 VA: 0x180A185E0
	public void UpdateHeights() { }

	// RVA: 0xA190B0 Offset: 0xA176B0 VA: 0x180A190B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA18400 Offset: 0xA16A00 VA: 0x180A18400
	private void <AnimateWheelsTreads>g__AnimateTreadWheel|30_0(ref float treadMovement, ref Material treadMat, bool left, ref TreadAnimator.<>c__DisplayClass30_0 ) { }

}

private struct TreadAnimator.<>c__DisplayClass30_0 // TypeDefIndex: 8865
{	// Fields
	public float forwardSpeed; // 0x0
	public float angularSpeed; // 0x4
	public TreadAnimator <>4__this; // 0x8

}

