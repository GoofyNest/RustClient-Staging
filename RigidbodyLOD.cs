public class RigidbodyLOD : LODComponent // TypeDefIndex: 9954
{	// Fields
	public float Distance; // 0x80
	private Rigidbody rigidbody; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool kinematic; // 0x95

	// Methods

	// RVA: 0x4C7990 Offset: 0x4C5F90 VA: 0x1804C7990 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x4C7AC0 Offset: 0x4C60C0 VA: 0x1804C7AC0 Slot: 13
	protected override void Show() { }

	// RVA: 0x4C78F0 Offset: 0x4C5EF0 VA: 0x1804C78F0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A10 Offset: 0x4C6010 VA: 0x1804C7A10 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C78C0 Offset: 0x4C5EC0 VA: 0x1804C78C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x4C7B60 Offset: 0x4C6160 VA: 0x1804C7B60
	public void .ctor() { }

}

