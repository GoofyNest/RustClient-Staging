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

	// RVA: 0x963700 Offset: 0x961D00 VA: 0x180963700 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x963470 Offset: 0x961A70 VA: 0x180963470 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x963B20 Offset: 0x962120 VA: 0x180963B20 Slot: 13
	protected override void Show() { }

	// RVA: 0x963680 Offset: 0x961C80 VA: 0x180963680 Slot: 14
	protected override void Hide() { }

	// RVA: 0x963600 Offset: 0x961C00 VA: 0x180963600 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0x9638A0 Offset: 0x961EA0 VA: 0x1809638A0 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0x963930 Offset: 0x961F30 VA: 0x180963930 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x963480 Offset: 0x961A80 VA: 0x180963480 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x963150 Offset: 0x961750 VA: 0x180963150 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x963BA0 Offset: 0x9621A0 VA: 0x180963BA0
	public void .ctor() { }

}

public class MeshLOD.State // TypeDefIndex: 9943
{	// Fields
	public float distance; // 0x10
	public Mesh mesh; // 0x18

	// Methods

	// RVA: 0x970CF0 Offset: 0x96F2F0 VA: 0x180970CF0
	public void Show(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode) { }

	// RVA: 0x970BC0 Offset: 0x96F1C0 VA: 0x180970BC0
	public void Hide(MeshFilter filter, MeshRenderer renderer, RendererBatch batch, ShadowCastingMode shadowMode, bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

