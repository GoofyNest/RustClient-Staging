public class ViewmodelSway : MonoBehaviour // TypeDefIndex: 11465
{	// Fields
	public float positionalSwaySpeed; // 0x18
	public float positionalSwayAmount; // 0x1C
	public float rotationSwaySpeed; // 0x20
	public float rotationSwayAmount; // 0x24
	internal Vector3 lastPosition; // 0x28
	internal Vector3 smoothedVelocity; // 0x34
	internal Vector3 lastRotation; // 0x40
	internal Vector3 smoothedRotation; // 0x4C
	public float rotateAmountTest; // 0x58

	// Methods

	// RVA: 0x7FBEB0 Offset: 0x7FA4B0 VA: 0x1807FBEB0
	public void Apply(ref CachedTransform<BaseViewModel> vm, BasePlayer player) { }

	// RVA: 0x7FB200 Offset: 0x7F9800 VA: 0x1807FB200
	private void ApplyPositionalSway(ref CachedTransform<BaseViewModel> vm, bool aiming, BasePlayer player) { }

	// RVA: 0x7FB6E0 Offset: 0x7F9CE0 VA: 0x1807FB6E0
	private void ApplyRotationSway(ref CachedTransform<BaseViewModel> vm, bool aiming) { }

	// RVA: 0x7FBF90 Offset: 0x7FA590 VA: 0x1807FBF90
	public void .ctor() { }

}

