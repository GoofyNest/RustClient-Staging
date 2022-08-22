public class WorldGrid : SingletonComponent<WorldGrid>, IClientComponent // TypeDefIndex: 10083
{	// Fields
	public static bool Paused; // 0x0
	public float CellSize; // 0x18
	public float MaxMilliseconds; // 0x1C
	public const float MaxRefreshDistance = 500;
	public const float MinTimeBetweenRefreshes = 1;
	private List<GameObject> tempInstances; // 0x20
	private WorldSpaceGrid<WorldCell> grid; // 0x28
	private Vector2i curCell; // 0x30
	private Stopwatch watch; // 0x38

	// Properties
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x900040 Offset: 0x8FE640 VA: 0x180900040
	protected void OnEnable() { }

	// RVA: 0x9000B0 Offset: 0x8FE6B0 VA: 0x1809000B0
	public static void RefreshAll() { }

	// RVA: 0x900180 Offset: 0x8FE780 VA: 0x180900180
	public void Refresh() { }

	// RVA: 0x8FFA20 Offset: 0x8FE020 VA: 0x1808FFA20
	public static void Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x8FFF50 Offset: 0x8FE550 VA: 0x1808FFF50
	private void Init() { }

	// RVA: 0x900480 Offset: 0x8FEA80 VA: 0x180900480
	public bool get_NeedsTimeout() { }

	// RVA: 0x900330 Offset: 0x8FE930 VA: 0x180900330
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xB3410 Offset: 0xB2810 VA: 0x1800B3410
	// RVA: 0x900370 Offset: 0x8FE970 VA: 0x180900370
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x8FFE90 Offset: 0x8FE490 VA: 0x1808FFE90
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x9003E0 Offset: 0x8FE9E0 VA: 0x1809003E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class WorldGrid.<UpdateCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10084
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorldGrid <>4__this; // 0x20
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

	// RVA: 0x8EE9E0 Offset: 0x8ECFE0 VA: 0x1808EE9E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8EEDC0 Offset: 0x8ED3C0 VA: 0x1808EEDC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

