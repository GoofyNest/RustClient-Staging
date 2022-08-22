public class ScreenBounceFade : BaseScreenShake // TypeDefIndex: 9367
{	// Fields
	public AnimationCurve bounceScale; // 0x28
	public AnimationCurve bounceSpeed; // 0x30
	public AnimationCurve bounceViewmodel; // 0x38
	public AnimationCurve distanceFalloff; // 0x40
	public AnimationCurve timeFalloff; // 0x48
	private float bounceTime; // 0x50
	private Vector3 bounceVelocity; // 0x54
	public float maxDistance; // 0x60
	public float scale; // 0x64

	// Methods

	// RVA: 0x4A3C70 Offset: 0x4A2270 VA: 0x1804A3C70 Slot: 4
	public override void Setup() { }

	// RVA: 0x4A3770 Offset: 0x4A1D70 VA: 0x1804A3770 Slot: 5
	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: 0x4A3CA0 Offset: 0x4A22A0 VA: 0x1804A3CA0
	public void .ctor() { }

}

