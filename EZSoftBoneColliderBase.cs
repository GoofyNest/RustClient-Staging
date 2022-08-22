public abstract class EZSoftBoneColliderBase : MonoBehaviour // TypeDefIndex: 7134
{	// Fields
	public static ListHashSet<EZSoftBoneColliderBase> EnabledColliders; // 0x128C8

	// Methods

	// RVA: 0x228F150 Offset: 0x228D750 VA: 0x18228F150 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x228F0D0 Offset: 0x228D6D0 VA: 0x18228F0D0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Collide(ref Vector3 position, float spacing);

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x228F220 Offset: 0x228D820 VA: 0x18228F220
	private static void .cctor() { }

}

