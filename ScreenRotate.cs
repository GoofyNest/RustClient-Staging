public class ScreenRotate : BaseScreenShake // TypeDefIndex: 9369
{	// Fields
	public AnimationCurve Pitch; // 0x28
	public AnimationCurve Yaw; // 0x30
	public AnimationCurve Roll; // 0x38
	public AnimationCurve ViewmodelEffect; // 0x40
	public float scale; // 0x48
	public bool useViewModelEffect; // 0x4C

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public override void Setup() { }

	// RVA: 0x4A4A60 Offset: 0x4A3060 VA: 0x1804A4A60 Slot: 5
	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: 0x4A4DD0 Offset: 0x4A33D0 VA: 0x1804A4DD0
	public void .ctor() { }

}

