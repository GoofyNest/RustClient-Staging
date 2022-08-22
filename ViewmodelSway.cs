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

	// RVA: 0x7FC550 Offset: 0x7FAB50 VA: 0x1807FC550
	public void Apply(ref CachedTransform<BaseViewModel> vm, BasePlayer player) { }

	// RVA: 0x7FB8A0 Offset: 0x7F9EA0 VA: 0x1807FB8A0
	private void ApplyPositionalSway(ref CachedTransform<BaseViewModel> vm, bool aiming, BasePlayer player) { }

	// RVA: 0x7FBD80 Offset: 0x7FA380 VA: 0x1807FBD80
	private void ApplyRotationSway(ref CachedTransform<BaseViewModel> vm, bool aiming) { }

	// RVA: 0x7FC630 Offset: 0x7FAC30 VA: 0x1807FC630
	public void .ctor() { }

}

