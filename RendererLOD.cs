public class RendererLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9952
{	// Fields
	public RendererLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool isSmall; // 0x95

	// Methods

	// RVA: 0x9514D0 Offset: 0x94FAD0 VA: 0x1809514D0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x9519A0 Offset: 0x94FFA0 VA: 0x1809519A0 Slot: 13
	protected override void Show() { }

	// RVA: 0x951470 Offset: 0x94FA70 VA: 0x180951470 Slot: 14
	protected override void Hide() { }

	// RVA: 0x951410 Offset: 0x94FA10 VA: 0x180951410 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x951760 Offset: 0x94FD60 VA: 0x180951760 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x9517F0 Offset: 0x94FDF0 VA: 0x1809517F0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x951290 Offset: 0x94F890 VA: 0x180951290 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x951080 Offset: 0x94F680 VA: 0x180951080 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x951A00 Offset: 0x950000 VA: 0x180951A00
	public void .ctor() { }

}

public class RendererLOD.State // TypeDefIndex: 9953
{	// Fields
	public float distance; // 0x10
	public Renderer renderer; // 0x18
	public MeshFilter filter; // 0x20
	public ShadowCastingMode shadowMode; // 0x28
	public bool isImpostor; // 0x2C

	// Methods

	// RVA: 0x956110 Offset: 0x954710 VA: 0x180956110
	public void Show(RendererBatch batch, bool forceShadowsOff = False) { }

	// RVA: 0x955FC0 Offset: 0x9545C0 VA: 0x180955FC0
	public void Hide(RendererBatch batch, bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

