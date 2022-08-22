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

	// RVA: 0xA1CFD0 Offset: 0xA1B5D0 VA: 0x180A1CFD0
	public int get_CulledLOD() { }

	// RVA: 0xA1CFA0 Offset: 0xA1B5A0 VA: 0x180A1CFA0
	public int get_BillboardLOD() { }

	// RVA: 0xA1CB80 Offset: 0xA1B180 VA: 0x180A1CB80
	public bool IsMesh(int lod) { }

	// RVA: 0xA1C940 Offset: 0xA1AF40 VA: 0x180A1C940 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0xA1C620 Offset: 0xA1AC20 VA: 0x180A1C620 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0xA1C5A0 Offset: 0xA1ABA0 VA: 0x180A1C5A0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0xA1CDE0 Offset: 0xA1B3E0 VA: 0x180A1CDE0 Slot: 13
	protected override void Show() { }

	// RVA: 0xA1C880 Offset: 0xA1AE80 VA: 0x180A1C880 Slot: 14
	protected override void Hide() { }

	// RVA: 0xA1C830 Offset: 0xA1AE30 VA: 0x180A1C830 Slot: 15
	protected override void Hide(bool shadowsVisible) { }

	// RVA: 0xA1CAF0 Offset: 0xA1B0F0 VA: 0x180A1CAF0 Slot: 16
	protected override bool IsLODHiding() { }

	// RVA: 0xA1CBB0 Offset: 0xA1B1B0 VA: 0x180A1CBB0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0xA1C6A0 Offset: 0xA1ACA0 VA: 0x180A1C6A0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0xA1C3C0 Offset: 0xA1A9C0 VA: 0x180A1C3C0 Slot: 17
	protected override bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0xA1C380 Offset: 0xA1A980 VA: 0x180A1C380 Slot: 21
	public int CompareTo(TreeLOD other) { }

	// RVA: 0xA1CF40 Offset: 0xA1B540 VA: 0x180A1CF40
	public void .ctor() { }

	// RVA: 0xA1CE90 Offset: 0xA1B490 VA: 0x180A1CE90
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

	// RVA: 0xA08B30 Offset: 0xA07130 VA: 0x180A08B30
	public void Show() { }

	// RVA: 0xA08A60 Offset: 0xA07060 VA: 0x180A08A60
	public void Hide(bool shadowsVisible = False) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class TreeLOD.<>c // TypeDefIndex: 9958
{	// Fields
	public static readonly TreeLOD.<>c <>9; // 0x2B30

	// Methods

	// RVA: 0xA23910 Offset: 0xA21F10 VA: 0x180A23910
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA238D0 Offset: 0xA21ED0 VA: 0x180A238D0
	internal int <.cctor>b__23_0(TreeLOD x, TreeLOD y) { }

}

