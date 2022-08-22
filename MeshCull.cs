public class MeshCull : LODComponent, IBatchingHandler // TypeDefIndex: 9940
{	// Fields
	public float Distance; // 0x80
	private RendererBatch meshBatch; // 0x88
	private Renderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private int curlod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x960EF0 Offset: 0x95F4F0 VA: 0x180960EF0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7B61E0 Offset: 0x7B47E0 VA: 0x1807B61E0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x960F80 Offset: 0x95F580 VA: 0x180960F80 Slot: 13
	protected override void Show() { }

	// RVA: 0x960E20 Offset: 0x95F420 VA: 0x180960E20 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7B6690 Offset: 0x7B4C90 VA: 0x1807B6690 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x960D90 Offset: 0x95F390 VA: 0x180960D90 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x961110 Offset: 0x95F710 VA: 0x180961110
	public void .ctor() { }

}

