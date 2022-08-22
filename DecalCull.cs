public class DecalCull : LODComponent // TypeDefIndex: 9926
{	// Fields
	public float Distance; // 0x80
	private DeferredDecal decal; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x83FC30 Offset: 0x83E230 VA: 0x18083FC30 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x83FC80 Offset: 0x83E280 VA: 0x18083FC80 Slot: 13
	protected override void Show() { }

	// RVA: 0x83FC00 Offset: 0x83E200 VA: 0x18083FC00 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A10 Offset: 0x4C6010 VA: 0x1804C7A10 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C78C0 Offset: 0x4C5EC0 VA: 0x1804C78C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x83FCB0 Offset: 0x83E2B0 VA: 0x18083FCB0
	public void .ctor() { }

}

