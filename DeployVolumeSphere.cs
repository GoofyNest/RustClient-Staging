public class DeployVolumeSphere : DeployVolume // TypeDefIndex: 9850
{	// Fields
	public Vector3 center; // 0xB0
	public float radius; // 0xBC

	// Methods

	// RVA: 0x975600 Offset: 0x973C00 VA: 0x180975600 Slot: 8
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1) { }

	// RVA: 0x9758E0 Offset: 0x973EE0 VA: 0x1809758E0 Slot: 9
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1) { }

	// RVA: 0x975B80 Offset: 0x974180 VA: 0x180975B80
	public void .ctor() { }

}

