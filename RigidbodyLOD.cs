public class RigidbodyLOD : LODComponent // TypeDefIndex: 9954
{	// Fields
	public float Distance; // 0x80
	private Rigidbody rigidbody; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool kinematic; // 0x95

	// Methods

	// RVA: 0x4C7A00 Offset: 0x4C6000 VA: 0x1804C7A00 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x4C7B30 Offset: 0x4C6130 VA: 0x1804C7B30 Slot: 13
	protected override void Show() { }

	// RVA: 0x4C7960 Offset: 0x4C5F60 VA: 0x1804C7960 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A80 Offset: 0x4C6080 VA: 0x1804C7A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x4C7BD0 Offset: 0x4C61D0 VA: 0x1804C7BD0
	public void .ctor() { }

}

