public class MeshGroupCull : LODComponent // TypeDefIndex: 9941
{	// Fields
	public float Distance; // 0x80
	private Renderer[] meshRenderers; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x962A10 Offset: 0x961010 VA: 0x180962A10 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x962A60 Offset: 0x961060 VA: 0x180962A60 Slot: 13
	protected override void Show() { }

	// RVA: 0x962990 Offset: 0x960F90 VA: 0x180962990 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A80 Offset: 0x4C6080 VA: 0x1804C7A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x962AE0 Offset: 0x9610E0 VA: 0x180962AE0
	public void .ctor() { }

}

