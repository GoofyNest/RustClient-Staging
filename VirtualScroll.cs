public class VirtualScroll : MonoBehaviour // TypeDefIndex: 12001
{	// Fields
	public int ItemHeight; // 0x18
	public int ItemSpacing; // 0x1C
	public RectOffset Padding; // 0x20
	[TooltipAttribute] // RVA: 0xCB0F0 Offset: 0xCA4F0 VA: 0x1800CB0F0
	public GameObject DataSourceObject; // 0x28
	public GameObject SourceObject; // 0x30
	public ScrollRect ScrollRect; // 0x38
	public RectTransform OverrideContentRoot; // 0x40
	private VirtualScroll.IDataSource dataSource; // 0x48
	private Dictionary<int, GameObject> ActivePool; // 0x50
	private Stack<GameObject> InactivePool; // 0x58

	// Properties
	private int BlockHeight { get; }

	// Methods

	// RVA: 0x79A630 Offset: 0x798C30 VA: 0x18079A630
	public void Awake() { }

	// RVA: 0x79AF20 Offset: 0x799520 VA: 0x18079AF20
	public void OnDestroy() { }

	// RVA: 0x79AFB0 Offset: 0x7995B0 VA: 0x18079AFB0
	private void OnScrollChanged(Vector2 pos) { }

	// RVA: 0x79B4D0 Offset: 0x799AD0 VA: 0x18079B4D0
	public void SetDataSource(VirtualScroll.IDataSource source, bool forceRebuild = False) { }

	// RVA: 0x79B650 Offset: 0x799C50 VA: 0x18079B650
	private int get_BlockHeight() { }

	// RVA: 0x79ACC0 Offset: 0x7992C0 VA: 0x18079ACC0
	public void FullRebuild() { }

	// RVA: 0x79AB00 Offset: 0x799100 VA: 0x18079AB00
	public void DataChanged() { }

	// RVA: 0x79AFC0 Offset: 0x7995C0 VA: 0x18079AFC0
	public void Rebuild() { }

	// RVA: 0x79B240 Offset: 0x799840 VA: 0x18079B240
	private void RecycleOutOfRange(int startVisible, float endVisible) { }

	// RVA: 0x79B430 Offset: 0x799A30 VA: 0x18079B430
	private void Recycle(int key) { }

	// RVA: 0x79A7C0 Offset: 0x798DC0 VA: 0x18079A7C0
	private void BuildItem(int i) { }

	// RVA: 0x79AD80 Offset: 0x799380 VA: 0x18079AD80
	private GameObject GetItem() { }

	// RVA: 0x79B5A0 Offset: 0x799BA0 VA: 0x18079B5A0
	public void .ctor() { }

}

private sealed class VirtualScroll.<>c__DisplayClass20_0 // TypeDefIndex: 12003
{	// Fields
	public int startVisible; // 0x10
	public float endVisible; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A390 Offset: 0x798990 VA: 0x18079A390
	internal bool <RecycleOutOfRange>b__0(int x) { }

}

private sealed class VirtualScroll.<>c // TypeDefIndex: 12004
{	// Fields
	public static readonly VirtualScroll.<>c <>9; // 0x0
	public static Func<int, int> <>9__20_1; // 0x8

	// Methods

	// RVA: 0x79A510 Offset: 0x798B10 VA: 0x18079A510
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A230 Offset: 0x798830 VA: 0x18079A230
	internal int <RecycleOutOfRange>b__20_1(int x) { }

}

