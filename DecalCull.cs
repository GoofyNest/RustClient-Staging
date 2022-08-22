public class DecalCull : LODComponent // TypeDefIndex: 9926
{	// Fields
	public float Distance; // 0x80
	private DeferredDecal decal; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x83F6E0 Offset: 0x83DCE0 VA: 0x18083F6E0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x83F730 Offset: 0x83DD30 VA: 0x18083F730 Slot: 13
	protected override void Show() { }

	// RVA: 0x83F6B0 Offset: 0x83DCB0 VA: 0x18083F6B0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A80 Offset: 0x4C6080 VA: 0x1804C7A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x83F760 Offset: 0x83DD60 VA: 0x18083F760
	public void .ctor() { }

}

