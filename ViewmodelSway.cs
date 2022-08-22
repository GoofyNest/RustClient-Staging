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

	// RVA: 0x7FBFC0 Offset: 0x7FA5C0 VA: 0x1807FBFC0
	public void Apply(ref CachedTransform<BaseViewModel> vm, BasePlayer player) { }

	// RVA: 0x7FB310 Offset: 0x7F9910 VA: 0x1807FB310
	private void ApplyPositionalSway(ref CachedTransform<BaseViewModel> vm, bool aiming, BasePlayer player) { }

	// RVA: 0x7FB7F0 Offset: 0x7F9DF0 VA: 0x1807FB7F0
	private void ApplyRotationSway(ref CachedTransform<BaseViewModel> vm, bool aiming) { }

	// RVA: 0x7FC0A0 Offset: 0x7FA6A0 VA: 0x1807FC0A0
	public void .ctor() { }

}

