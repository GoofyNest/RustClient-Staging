public class WorldGrid : SingletonComponent<WorldGrid>, IClientComponent // TypeDefIndex: 10083
{	public static bool Paused; // 0x0
	public float CellSize; // 0x18
	public float MaxMilliseconds; // 0x1C
	public const float MaxRefreshDistance = 500;
	public const float MinTimeBetweenRefreshes = 1;
	private List<GameObject> tempInstances; // 0x20
	private WorldSpaceGrid<WorldCell> grid; // 0x28
	private Vector2i curCell; // 0x30
	private Stopwatch watch; // 0x38

	public bool NeedsTimeout { get; }


	protected void OnEnable() { }

	public static void RefreshAll() { }

	public void Refresh() { }

	public static void Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	private void Init() { }

	public bool get_NeedsTimeout() { }

	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xB2EE0 Offset: 0xB22E0 VA: 0x1800B2EE0
	private IEnumerator UpdateCoroutine() { }

	private Vector2i GetCurrentCellCoordinates() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorldGrid.<UpdateCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10084
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorldGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private int <maxLeaveX>5__3; // 0x30
	private int <minLeaveZ>5__4; // 0x34
	private int <maxLeaveZ>5__5; // 0x38
	private int <x>5__6; // 0x3C
	private int <z>5__7; // 0x40

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

