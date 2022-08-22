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

	// RVA: 0xA18470 Offset: 0xA16A70 VA: 0x180A18470
	public void Awake() { }

	// RVA: 0xA19790 Offset: 0xA17D90 VA: 0x180A19790
	public void Update() { }

	// RVA: 0xA18830 Offset: 0xA16E30 VA: 0x180A18830
	public void CalculateVelocity() { }

	// RVA: 0xA18B90 Offset: 0xA17190 VA: 0x180A18B90
	public Vector3 GetCurrentVelocity() { }

	// RVA: 0xA18B80 Offset: 0xA17180 VA: 0x180A18B80
	public float GetAngularSpeed() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890
	public float GetSpeed(bool rightSide) { }

	// RVA: 0xA18240 Offset: 0xA16840 VA: 0x180A18240
	private void AnimateWheelsTreads() { }

	// RVA: 0xA18D90 Offset: 0xA17390 VA: 0x180A18D90
	public void UpdateHeights() { }

	// RVA: 0xA19860 Offset: 0xA17E60 VA: 0x180A19860
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA18BB0 Offset: 0xA171B0 VA: 0x180A18BB0
	private void <AnimateWheelsTreads>g__AnimateTreadWheel|30_0(ref float treadMovement, ref Material treadMat, bool left, ref TreadAnimator.<>c__DisplayClass30_0 ) { }

}

private struct TreadAnimator.<>c__DisplayClass30_0 // TypeDefIndex: 8865
{	// Fields
	public float forwardSpeed; // 0x0
	public float angularSpeed; // 0x4
	public TreadAnimator <>4__this; // 0x8

}

