public class MeshLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9942
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public MeshLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private MeshRenderer meshRenderer; // 0x90
	private MeshFilter meshFilter; // 0x98
	private ShadowCastingMode meshShadowMode; // 0xA0
	private int curlod; // 0xA4
	private bool force; // 0xA8
	private bool isSmall; // 0xA9

	// Methods

	// RVA: 0x9630F0 Offset: 0x9616F0 VA: 0x1809630F0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x962E60 Offset: 0x961460 VA: 0x180962E60 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x963510 Offset: 0x961B10 VA: 0x180963510 Slot: 13
	protected override void Show() { }

	// RVA: 0x963070 Offset: 0x961670 VA: 0x180963070 Slot: 14
	protected override void Hide() { }

	// RVA: 0x962FF0 Offset: 0x9615F0 VA: 0x180962FF0 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x963290 Offset: 0x961890 VA: 0x180963290 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x963320 Offset: 0x961920 VA: 0x180963320 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x962E70 Offset: 0x961470 VA: 0x180962E70 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x962B40 Offset: 0x961140 VA: 0x180962B40 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x963590 Offset: 0x961B90 VA: 0x180963590
	public void .ctor() { }

}

public class MeshLOD.State // TypeDefIndex: 9943
{	// Fields
	public float distance; // 0x10
	public Mesh mesh; // 0x18

	// Methods

	// RVA: 0x9706E0 Offset: 0x96ECE0 VA: 0x1809706E0
	public void Show(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode) { }

	// RVA: 0x9705B0 Offset: 0x96EBB0 VA: 0x1809705B0
	public void Hide(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode, bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

