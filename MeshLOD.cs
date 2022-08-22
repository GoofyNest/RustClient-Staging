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

	// RVA: 0x963200 Offset: 0x961800 VA: 0x180963200 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x962F70 Offset: 0x961570 VA: 0x180962F70 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x963620 Offset: 0x961C20 VA: 0x180963620 Slot: 13
	protected override void Show() { }

	// RVA: 0x963180 Offset: 0x961780 VA: 0x180963180 Slot: 14
	protected override void Hide() { }

	// RVA: 0x963100 Offset: 0x961700 VA: 0x180963100 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x9633A0 Offset: 0x9619A0 VA: 0x1809633A0 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x963430 Offset: 0x961A30 VA: 0x180963430 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x962F80 Offset: 0x961580 VA: 0x180962F80 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x962C50 Offset: 0x961250 VA: 0x180962C50 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x9636A0 Offset: 0x961CA0 VA: 0x1809636A0
	public void .ctor() { }

}

public class MeshLOD.State // TypeDefIndex: 9943
{	// Fields
	public float distance; // 0x10
	public Mesh mesh; // 0x18

	// Methods

	// RVA: 0x9707F0 Offset: 0x96EDF0 VA: 0x1809707F0
	public void Show(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode) { }

	// RVA: 0x9706C0 Offset: 0x96ECC0 VA: 0x1809706C0
	public void Hide(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode, bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

