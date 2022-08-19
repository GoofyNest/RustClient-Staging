public class DeployVolumeCapsule : DeployVolume // TypeDefIndex: 9846
{	// Fields
	public Vector3 center; // 0xB0
	public float radius; // 0xBC
	public float height; // 0xC0

	// Methods

	// RVA: 0x973880 Offset: 0x971E80 VA: 0x180973880 Slot: 8
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1) { }

	// RVA: 0x973D90 Offset: 0x972390 VA: 0x180973D90
	public void .ctor() { }

}

