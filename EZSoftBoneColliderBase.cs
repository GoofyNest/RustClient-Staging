public abstract class EZSoftBoneColliderBase : MonoBehaviour // TypeDefIndex: 7134
{	// Fields
	public static ListHashSet<EZSoftBoneColliderBase> EnabledColliders; // 0x12660

	// Methods

	// RVA: 0x228FC30 Offset: 0x228E230 VA: 0x18228FC30 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x228FBB0 Offset: 0x228E1B0 VA: 0x18228FBB0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Collide(ref Vector3 position, float spacing);

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x228FD00 Offset: 0x228E300 VA: 0x18228FD00
	private static void .cctor() { }

}

