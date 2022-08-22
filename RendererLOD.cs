public class RendererLOD : LODComponent, IBatchingHandler // TypeDefIndex: 9952
{	// Fields
	public RendererLOD.State[] States; // 0x80
	private RendererBatch meshBatch; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private bool isSmall; // 0x95

	// Methods

	// RVA: 0x9519E0 Offset: 0x94FFE0 VA: 0x1809519E0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x951EB0 Offset: 0x9504B0 VA: 0x180951EB0 Slot: 13
	protected override void Show() { }

	// RVA: 0x951980 Offset: 0x94FF80 VA: 0x180951980 Slot: 14
	protected override void Hide() { }

	// RVA: 0x951920 Offset: 0x94FF20 VA: 0x180951920 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x951C70 Offset: 0x950270 VA: 0x180951C70 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x951D00 Offset: 0x950300 VA: 0x180951D00 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x9517A0 Offset: 0x94FDA0 VA: 0x1809517A0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x951590 Offset: 0x94FB90 VA: 0x180951590 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x951F10 Offset: 0x950510 VA: 0x180951F10
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

	// RVA: 0x956610 Offset: 0x954C10 VA: 0x180956610
	public void Show(RendererBatch batch, bool forceShadowsOff = False) { }

	// RVA: 0x9564C0 Offset: 0x954AC0 VA: 0x1809564C0
	public void Hide(RendererBatch batch, bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

