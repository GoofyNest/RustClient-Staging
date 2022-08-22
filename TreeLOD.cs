public class TreeLOD : LODComponent, IComparable<TreeLOD> // TypeDefIndex: 9956
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public TreeLOD.State[] States; // 0x80
	private int requestedlod; // 0x88
	private int curlod; // 0x8C
	private bool force; // 0x90
	public static Comparison<TreeLOD> Comparison; // 0x0

	// Properties
	public int CulledLOD { get; }
	public int BillboardLOD { get; }

	// Methods

	// RVA: 0xA1C820 Offset: 0xA1AE20 VA: 0x180A1C820
	public int get_CulledLOD() { }

	// RVA: 0xA1C7F0 Offset: 0xA1ADF0 VA: 0x180A1C7F0
	public int get_BillboardLOD() { }

	// RVA: 0xA1C3D0 Offset: 0xA1A9D0 VA: 0x180A1C3D0
	public bool IsMesh(int lod) { }

	// RVA: 0xA1C190 Offset: 0xA1A790 VA: 0x180A1C190 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0xA1BE70 Offset: 0xA1A470 VA: 0x180A1BE70 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0xA1BDF0 Offset: 0xA1A3F0 VA: 0x180A1BDF0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0xA1C630 Offset: 0xA1AC30 VA: 0x180A1C630 Slot: 13
	protected override void Show() { }

	// RVA: 0xA1C0D0 Offset: 0xA1A6D0 VA: 0x180A1C0D0 Slot: 14
	protected override void Hide() { }

	// RVA: 0xA1C080 Offset: 0xA1A680 VA: 0x180A1C080 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0xA1C340 Offset: 0xA1A940 VA: 0x180A1C340 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0xA1C400 Offset: 0xA1AA00 VA: 0x180A1C400 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0xA1BEF0 Offset: 0xA1A4F0 VA: 0x180A1BEF0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0xA1BC10 Offset: 0xA1A210 VA: 0x180A1BC10 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0xA1BBD0 Offset: 0xA1A1D0 VA: 0x180A1BBD0 Slot: 21
	public int CompareTo(TreeLOD other) { }

	// RVA: 0xA1C790 Offset: 0xA1AD90 VA: 0x180A1C790
	public void .ctor() { }

	// RVA: 0xA1C6E0 Offset: 0xA1ACE0 VA: 0x180A1C6E0
	private static void .cctor() { }

}

public class TreeLOD.State // TypeDefIndex: 9957
{	// Fields
	public float distance; // 0x10
	public Renderer renderer; // 0x18
	public MeshFilter filter; // 0x20
	public ShadowCastingMode shadowMode; // 0x28
	public bool isImpostor; // 0x2C

	// Methods

	// RVA: 0xA08380 Offset: 0xA06980 VA: 0x180A08380
	public void Show() { }

	// RVA: 0xA082B0 Offset: 0xA068B0 VA: 0x180A082B0
	public void Hide(bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class TreeLOD.<>c // TypeDefIndex: 9958
{	// Fields
	public static readonly TreeLOD.<>c <>9; // 0x2D3A

	// Methods

	// RVA: 0xA23160 Offset: 0xA21760 VA: 0x180A23160
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA23120 Offset: 0xA21720 VA: 0x180A23120
	internal int <.cctor>b__23_0(TreeLOD x, TreeLOD y) { }

}

