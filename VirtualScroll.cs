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

	// RVA: 0x79A540 Offset: 0x798B40 VA: 0x18079A540
	public void Awake() { }

	// RVA: 0x79AE30 Offset: 0x799430 VA: 0x18079AE30
	public void OnDestroy() { }

	// RVA: 0x79AEC0 Offset: 0x7994C0 VA: 0x18079AEC0
	private void OnScrollChanged(Vector2 pos) { }

	// RVA: 0x79B3E0 Offset: 0x7999E0 VA: 0x18079B3E0
	public void SetDataSource(VirtualScroll.IDataSource source, bool forceRebuild = False) { }

	// RVA: 0x79B560 Offset: 0x799B60 VA: 0x18079B560
	private int get_BlockHeight() { }

	// RVA: 0x79ABD0 Offset: 0x7991D0 VA: 0x18079ABD0
	public void FullRebuild() { }

	// RVA: 0x79AA10 Offset: 0x799010 VA: 0x18079AA10
	public void DataChanged() { }

	// RVA: 0x79AED0 Offset: 0x7994D0 VA: 0x18079AED0
	public void Rebuild() { }

	// RVA: 0x79B150 Offset: 0x799750 VA: 0x18079B150
	private void RecycleOutOfRange(int startVisible, float endVisible) { }

	// RVA: 0x79B340 Offset: 0x799940 VA: 0x18079B340
	private void Recycle(int key) { }

	// RVA: 0x79A6D0 Offset: 0x798CD0 VA: 0x18079A6D0
	private void BuildItem(int i) { }

	// RVA: 0x79AC90 Offset: 0x799290 VA: 0x18079AC90
	private GameObject GetItem() { }

	// RVA: 0x79B4B0 Offset: 0x799AB0 VA: 0x18079B4B0
	public void .ctor() { }

}

private sealed class VirtualScroll.<>c__DisplayClass20_0 // TypeDefIndex: 12003
{	// Fields
	public int startVisible; // 0x10
	public float endVisible; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A2A0 Offset: 0x7988A0 VA: 0x18079A2A0
	internal bool <RecycleOutOfRange>b__0(int x) { }

}

private sealed class VirtualScroll.<>c // TypeDefIndex: 12004
{	// Fields
	public static readonly VirtualScroll.<>c <>9; // 0x0
	public static Func<int, int> <>9__20_1; // 0x8

	// Methods

	// RVA: 0x79A420 Offset: 0x798A20 VA: 0x18079A420
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A140 Offset: 0x798740 VA: 0x18079A140
	internal int <RecycleOutOfRange>b__20_1(int x) { }

}

