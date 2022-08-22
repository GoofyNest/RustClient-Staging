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

	// RVA: 0x8FFA20 Offset: 0x8FE020 VA: 0x1808FFA20
	protected void OnEnable() { }

	// RVA: 0x8FFA90 Offset: 0x8FE090 VA: 0x1808FFA90
	public static void RefreshAll() { }

	// RVA: 0x8FFB60 Offset: 0x8FE160 VA: 0x1808FFB60
	public void Refresh() { }

	// RVA: 0x8FF400 Offset: 0x8FDA00 VA: 0x1808FF400
	public static void Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x8FF930 Offset: 0x8FDF30 VA: 0x1808FF930
	private void Init() { }

	// RVA: 0x8FFE60 Offset: 0x8FE460 VA: 0x1808FFE60
	public bool get_NeedsTimeout() { }

	// RVA: 0x8FFD10 Offset: 0x8FE310 VA: 0x1808FFD10
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xB3410 Offset: 0xB2810 VA: 0x1800B3410
	// RVA: 0x8FFD50 Offset: 0x8FE350 VA: 0x1808FFD50
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x8FF870 Offset: 0x8FDE70 VA: 0x1808FF870
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x8FFDC0 Offset: 0x8FE3C0 VA: 0x1808FFDC0
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

	// RVA: 0x8EE3C0 Offset: 0x8EC9C0 VA: 0x1808EE3C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8EE7A0 Offset: 0x8ECDA0 VA: 0x1808EE7A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

