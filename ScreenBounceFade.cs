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

	// RVA: 0x4A3CE0 Offset: 0x4A22E0 VA: 0x1804A3CE0 Slot: 4
	public override void Setup() { }

	// RVA: 0x4A37E0 Offset: 0x4A1DE0 VA: 0x1804A37E0 Slot: 5
	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: 0x4A3D10 Offset: 0x4A2310 VA: 0x1804A3D10
	public void .ctor() { }

}

