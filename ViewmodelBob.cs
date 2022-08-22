public class ViewmodelBob : MonoBehaviour // TypeDefIndex: 11457
{	// Fields
	public float bobSpeedWalk; // 0x18
	public float bobSpeedRun; // 0x1C
	public float bobAmountWalk; // 0x20
	public float bobAmountRun; // 0x24
	public float leftOffsetRun; // 0x28
	internal float bobAmountRotateYaw; // 0x2C
	internal float bobAmountRotateRoll; // 0x30
	internal Vector3 velocity; // 0x34
	internal Vector3 bobOffset; // 0x40
	internal float bobRotateYaw; // 0x4C
	internal float bobRotateRoll; // 0x50
	internal float bobCycle; // 0x54
	internal ViewmodelBob.BobSettings smoothedBob; // 0x58

	// Methods

	// RVA: 0x7F7870 Offset: 0x7F5E70 VA: 0x1807F7870
	private ViewmodelBob.BobSettings WorkoutBobSettings(Vector3 newVelocity, float fov, bool isRunning, bool OnGround, bool isAiming, bool isDucked, bool isMounted) { }

	// RVA: 0x7F7450 Offset: 0x7F5A50 VA: 0x1807F7450
	public void Apply(ref CachedTransform<BaseViewModel> vm, float fov, BasePlayer player) { }

	// RVA: 0x7F6D20 Offset: 0x7F5320 VA: 0x1807F6D20
	private void ApplySettings(ref CachedTransform<BaseViewModel> vm, ViewmodelBob.BobSettings settings) { }

	// RVA: 0x7F7AF0 Offset: 0x7F60F0 VA: 0x1807F7AF0
	public void .ctor() { }

}

public struct ViewmodelBob.BobSettings // TypeDefIndex: 11458
{	// Fields
	public float bobSpeed; // 0x0
	public float bobAmount; // 0x4
	public float offsetLateral; // 0x8
	public float bobRotate; // 0xC
	public float effectAmount; // 0x10

}

