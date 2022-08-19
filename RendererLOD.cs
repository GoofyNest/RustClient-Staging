public class RendererLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9952
{	// Fields
	public RendererLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool isSmall; // 0x95

	// Methods

	// RVA: 0x9513C0 Offset: 0x94F9C0 VA: 0x1809513C0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x951890 Offset: 0x94FE90 VA: 0x180951890 Slot: 13
	protected override void Show() { }

	// RVA: 0x951360 Offset: 0x94F960 VA: 0x180951360 Slot: 14
	protected override void Hide() { }

	// RVA: 0x951300 Offset: 0x94F900 VA: 0x180951300 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x951650 Offset: 0x94FC50 VA: 0x180951650 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x9516E0 Offset: 0x94FCE0 VA: 0x1809516E0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x951180 Offset: 0x94F780 VA: 0x180951180 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x950F70 Offset: 0x94F570 VA: 0x180950F70 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x9518F0 Offset: 0x94FEF0 VA: 0x1809518F0
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

	// RVA: 0x956000 Offset: 0x954600 VA: 0x180956000
	public void Show(RendererBatch batch, bool forceShadowsOff = False) { }

	// RVA: 0x955EB0 Offset: 0x9544B0 VA: 0x180955EB0
	public void Hide(RendererBatch batch, bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

