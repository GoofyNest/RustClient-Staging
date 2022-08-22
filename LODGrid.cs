public class LODGrid : SingletonComponent<LODGrid>, IClientComponent // TypeDefIndex: 9934
{	// Fields
	public static bool Paused; // 0x0
	public float CellSize; // 0x18
	public float MaxMilliseconds; // 0x1C
	public const float MaxRefreshDistance = 500;
	public static float TreeMeshDistance; // 0x4
	public const float MinTimeBetweenRefreshes = 1;
	private bool treeRefreshRequest; // 0x20
	private Vector3 treeRefreshPosition; // 0x24
	private List<TreeLOD> treeQueue; // 0x30
	private ListHashSet<TreeLOD> treeMeshes; // 0x38
	private WorldSpaceGrid<LODCell> grid; // 0x40
	private Vector2i curCell; // 0x48
	private Stopwatch watch; // 0x50

	// Properties
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x685180 Offset: 0x683780 VA: 0x180685180
	protected void OnEnable() { }

	// RVA: 0x6851F0 Offset: 0x6837F0 VA: 0x1806851F0
	public static void RefreshAll() { }

	// RVA: 0x685470 Offset: 0x683A70 VA: 0x180685470
	public void Refresh() { }

	// RVA: 0x685370 Offset: 0x683970 VA: 0x180685370
	public static void Refresh(ILOD component, Transform transform, ref LODCell cell) { }

	// RVA: 0x684C90 Offset: 0x683290 VA: 0x180684C90
	public static void Add(ILOD component, Transform transform, ref LODCell cell) { }

	// RVA: 0x685640 Offset: 0x683C40 VA: 0x180685640
	public static void Remove(ILOD component, Transform transform, ref LODCell cell) { }

	// RVA: 0x684B30 Offset: 0x683130 VA: 0x180684B30
	public static void AddTreeMesh(TreeLOD component) { }

	// RVA: 0x685540 Offset: 0x683B40 VA: 0x180685540
	public static void RemoveTreeMesh(TreeLOD component) { }

	// RVA: 0x6850C0 Offset: 0x6836C0 VA: 0x1806850C0
	private void Init() { }

	// RVA: 0x685950 Offset: 0x683F50 VA: 0x180685950
	private void UpdateTreeMeshes() { }

	// RVA: 0x686050 Offset: 0x684650 VA: 0x180686050
	public bool get_NeedsTimeout() { }

	// RVA: 0x6858A0 Offset: 0x683EA0 VA: 0x1806858A0
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xAA040 Offset: 0xA9440 VA: 0x1800AA040
	// RVA: 0x6858E0 Offset: 0x683EE0 VA: 0x1806858E0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x685000 Offset: 0x683600 VA: 0x180685000
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x685F50 Offset: 0x684550 VA: 0x180685F50
	public void .ctor() { }

	// RVA: 0x685F00 Offset: 0x684500 VA: 0x180685F00
	private static void .cctor() { }

}

private sealed class LODGrid.<UpdateCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9935
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LODGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private int <maxLeaveX>5__3; // 0x30
	private int <minLeaveZ>5__4; // 0x34
	private int <maxLeaveZ>5__5; // 0x38
	private int <x>5__6; // 0x3C
	private int <z>5__7; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x691110 Offset: 0x68F710 VA: 0x180691110 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x691510 Offset: 0x68FB10 VA: 0x180691510 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

