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

	// RVA: 0xA1CAE0 Offset: 0xA1B0E0 VA: 0x180A1CAE0
	public int get_CulledLOD() { }

	// RVA: 0xA1CAB0 Offset: 0xA1B0B0 VA: 0x180A1CAB0
	public int get_BillboardLOD() { }

	// RVA: 0xA1C690 Offset: 0xA1AC90 VA: 0x180A1C690
	public bool IsMesh(int lod) { }

	// RVA: 0xA1C450 Offset: 0xA1AA50 VA: 0x180A1C450 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0xA1C130 Offset: 0xA1A730 VA: 0x180A1C130 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0xA1C0B0 Offset: 0xA1A6B0 VA: 0x180A1C0B0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0xA1C8F0 Offset: 0xA1AEF0 VA: 0x180A1C8F0 Slot: 13
	protected override void Show() { }

	// RVA: 0xA1C390 Offset: 0xA1A990 VA: 0x180A1C390 Slot: 14
	protected override void Hide() { }

	// RVA: 0xA1C340 Offset: 0xA1A940 VA: 0x180A1C340 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0xA1C600 Offset: 0xA1AC00 VA: 0x180A1C600 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0xA1C6C0 Offset: 0xA1ACC0 VA: 0x180A1C6C0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0xA1C1B0 Offset: 0xA1A7B0 VA: 0x180A1C1B0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0xA1BED0 Offset: 0xA1A4D0 VA: 0x180A1BED0 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0xA1BE90 Offset: 0xA1A490 VA: 0x180A1BE90 Slot: 21
	public int CompareTo(TreeLOD other) { }

	// RVA: 0xA1CA50 Offset: 0xA1B050 VA: 0x180A1CA50
	public void .ctor() { }

	// RVA: 0xA1C9A0 Offset: 0xA1AFA0 VA: 0x180A1C9A0
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

	// RVA: 0xA08640 Offset: 0xA06C40 VA: 0x180A08640
	public void Show() { }

	// RVA: 0xA08570 Offset: 0xA06B70 VA: 0x180A08570
	public void Hide(bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class TreeLOD.<>c // TypeDefIndex: 9958
{	// Fields
	public static readonly TreeLOD.<>c <>9; // 0x2D3A

	// Methods

	// RVA: 0xA23420 Offset: 0xA21A20 VA: 0x180A23420
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA233E0 Offset: 0xA219E0 VA: 0x180A233E0
	internal int <.cctor>b__23_0(TreeLOD x, TreeLOD y) { }

}

