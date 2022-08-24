public class RendererGrid : SingletonComponent<RendererGrid>, IClientComponent // TypeDefIndex: 9919
{	public static bool Paused; // 0x0
	public GameObjectRef BatchPrefab; // 0x18
	public float CellSize; // 0x20
	public float MaxMilliseconds; // 0x24
	public const float MinTimeBetweenRefreshes = 1;
	private WorldSpaceGrid<RendererCell> grid; // 0x28
	private Stopwatch watch; // 0x30

	public bool NeedsTimeout { get; }


	protected void OnEnable() { }

	public static void RefreshAll() { }

	public void Refresh() { }

	public RendererGroup Add(Vector3 position, RendererBatch batch) { }

	public void Remove(RendererCell cell) { }

	private void Init() { }

	public MeshRendererBatch CreateInstance() { }

	public void RecycleInstance(MeshRendererBatch instance) { }

	public int MeshCount() { }

	public int BatchedMeshCount() { }

	public int VertexCount() { }

	public bool get_NeedsTimeout() { }

	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA7E50 Offset: 0xA7250 VA: 0x1800A7E50
	private IEnumerator UpdateCoroutine() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class RendererGrid.<UpdateCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9920
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RendererGrid <>4__this; // 0x20
	private int <x>5__2; // 0x28
	private int <z>5__3; // 0x2C
	private RendererCell <cell>5__4; // 0x30
	private IEnumerator <enumerator>5__5; // 0x38

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

