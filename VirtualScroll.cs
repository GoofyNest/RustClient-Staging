public class VirtualScroll : MonoBehaviour // TypeDefIndex: 12001
{	// Fields
	public int ItemHeight; // 0x18
	public int ItemSpacing; // 0x1C
	public RectOffset Padding; // 0x20
	[TooltipAttribute] // RVA: 0xCB030 Offset: 0xCA430 VA: 0x1800CB030
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

	// RVA: 0x79A520 Offset: 0x798B20 VA: 0x18079A520
	public void Awake() { }

	// RVA: 0x79AE10 Offset: 0x799410 VA: 0x18079AE10
	public void OnDestroy() { }

	// RVA: 0x79AEA0 Offset: 0x7994A0 VA: 0x18079AEA0
	private void OnScrollChanged(Vector2 pos) { }

	// RVA: 0x79B3C0 Offset: 0x7999C0 VA: 0x18079B3C0
	public void SetDataSource(VirtualScroll.IDataSource source, bool forceRebuild = False) { }

	// RVA: 0x79B540 Offset: 0x799B40 VA: 0x18079B540
	private int get_BlockHeight() { }

	// RVA: 0x79ABB0 Offset: 0x7991B0 VA: 0x18079ABB0
	public void FullRebuild() { }

	// RVA: 0x79A9F0 Offset: 0x798FF0 VA: 0x18079A9F0
	public void DataChanged() { }

	// RVA: 0x79AEB0 Offset: 0x7994B0 VA: 0x18079AEB0
	public void Rebuild() { }

	// RVA: 0x79B130 Offset: 0x799730 VA: 0x18079B130
	private void RecycleOutOfRange(int startVisible, float endVisible) { }

	// RVA: 0x79B320 Offset: 0x799920 VA: 0x18079B320
	private void Recycle(int key) { }

	// RVA: 0x79A6B0 Offset: 0x798CB0 VA: 0x18079A6B0
	private void BuildItem(int i) { }

	// RVA: 0x79AC70 Offset: 0x799270 VA: 0x18079AC70
	private GameObject GetItem() { }

	// RVA: 0x79B490 Offset: 0x799A90 VA: 0x18079B490
	public void .ctor() { }

}

private sealed class VirtualScroll.<>c__DisplayClass20_0 // TypeDefIndex: 12003
{	// Fields
	public int startVisible; // 0x10
	public float endVisible; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A280 Offset: 0x798880 VA: 0x18079A280
	internal bool <RecycleOutOfRange>b__0(int x) { }

}

private sealed class VirtualScroll.<>c // TypeDefIndex: 12004
{	// Fields
	public static readonly VirtualScroll.<>c <>9; // 0x0
	public static Func<int, int> <>9__20_1; // 0x8

	// Methods

	// RVA: 0x79A400 Offset: 0x798A00 VA: 0x18079A400
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x79A120 Offset: 0x798720 VA: 0x18079A120
	internal int <RecycleOutOfRange>b__20_1(int x) { }

}

