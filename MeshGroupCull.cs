public class MeshGroupCull : LODComponent // TypeDefIndex: 9941
{	// Fields
	public float Distance; // 0x80
	private Renderer[] meshRenderers; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x962900 Offset: 0x960F00 VA: 0x180962900 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x962950 Offset: 0x960F50 VA: 0x180962950 Slot: 13
	protected override void Show() { }

	// RVA: 0x962880 Offset: 0x960E80 VA: 0x180962880 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A80 Offset: 0x4C6080 VA: 0x1804C7A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9629D0 Offset: 0x960FD0 VA: 0x1809629D0
	public void .ctor() { }

}

