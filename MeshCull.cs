public class MeshCull : LODComponent, IBatchingHandler // TypeDefIndex: 9940
{	// Fields
	public float Distance; // 0x80
	private RendererBatch meshBatch; // 0x88
	private Renderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private int curlod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x960DE0 Offset: 0x95F3E0 VA: 0x180960DE0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7B60D0 Offset: 0x7B46D0 VA: 0x1807B60D0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x960E70 Offset: 0x95F470 VA: 0x180960E70 Slot: 13
	protected override void Show() { }

	// RVA: 0x960D10 Offset: 0x95F310 VA: 0x180960D10 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7B6580 Offset: 0x7B4B80 VA: 0x1807B6580 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x960C80 Offset: 0x95F280 VA: 0x180960C80 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x961000 Offset: 0x95F600 VA: 0x180961000
	public void .ctor() { }

}

