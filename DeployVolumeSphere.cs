public class DeployVolumeSphere : DeployVolume // TypeDefIndex: 9850
{	// Fields
	public Vector3 center; // 0xB0
	public float radius; // 0xBC

	// Methods

	// RVA: 0x975B00 Offset: 0x974100 VA: 0x180975B00 Slot: 8
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1) { }

	// RVA: 0x975DE0 Offset: 0x9743E0 VA: 0x180975DE0 Slot: 9
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1) { }

	// RVA: 0x976080 Offset: 0x974680 VA: 0x180976080
	public void .ctor() { }

}

