public class MeshGroupCull : LODComponent // TypeDefIndex: 9941
{	// Fields
	public float Distance; // 0x80
	private Renderer[] meshRenderers; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x962F10 Offset: 0x961510 VA: 0x180962F10 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x962F60 Offset: 0x961560 VA: 0x180962F60 Slot: 13
	protected override void Show() { }

	// RVA: 0x962E90 Offset: 0x961490 VA: 0x180962E90 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A10 Offset: 0x4C6010 VA: 0x1804C7A10 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C78C0 Offset: 0x4C5EC0 VA: 0x1804C78C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x962FE0 Offset: 0x9615E0 VA: 0x180962FE0
	public void .ctor() { }

}

