public class RendererGrid : SingletonComponent<RendererGrid>, IClientComponent // TypeDefIndex: 9919
{	// Fields
	public static bool Paused; // 0x0
	public GameObjectRef BatchPrefab; // 0x18
	public float CellSize; // 0x20
	public float MaxMilliseconds; // 0x24
	public const float MinTimeBetweenRefreshes = 1;
	private WorldSpaceGrid<RendererCell> grid; // 0x28
	private Stopwatch watch; // 0x30

	// Properties
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x94EDB0 Offset: 0x94D3B0 VA: 0x18094EDB0
	protected void OnEnable() { }

	// RVA: 0x94EEB0 Offset: 0x94D4B0 VA: 0x18094EEB0
	public static void RefreshAll() { }

	// RVA: 0x94F010 Offset: 0x94D610 VA: 0x18094F010
	public void Refresh() { }

	// RVA: 0x94E900 Offset: 0x94CF00 VA: 0x18094E900
	public RendererGroup Add(Vector3 position, RendererBatch batch) { }

	// RVA: 0x94F0C0 Offset: 0x94D6C0 VA: 0x18094F0C0
	public void Remove(RendererCell cell) { }

	// RVA: 0x94EC30 Offset: 0x94D230 VA: 0x18094EC30
	private void Init() { }

	// RVA: 0x94EB70 Offset: 0x94D170 VA: 0x18094EB70
	public MeshRendererBatch CreateInstance() { }

	// RVA: 0x94EE20 Offset: 0x94D420 VA: 0x18094EE20
	public void RecycleInstance(MeshRendererBatch instance) { }

	// RVA: 0x94ECF0 Offset: 0x94D2F0 VA: 0x18094ECF0
	public int MeshCount() { }

	// RVA: 0x94EAB0 Offset: 0x94D0B0 VA: 0x18094EAB0
	public int BatchedMeshCount() { }

	// RVA: 0x94F2E0 Offset: 0x94D8E0 VA: 0x18094F2E0
	public int VertexCount() { }

	// RVA: 0x94F440 Offset: 0x94DA40 VA: 0x18094F440
	public bool get_NeedsTimeout() { }

	// RVA: 0x94F230 Offset: 0x94D830 VA: 0x18094F230
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA8060 Offset: 0xA7460 VA: 0x1800A8060
	// RVA: 0x94F270 Offset: 0x94D870 VA: 0x18094F270
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x94F3A0 Offset: 0x94D9A0 VA: 0x18094F3A0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class RendererGrid.<UpdateCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9920
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RendererGrid <>4__this; // 0x20
	private int <x>5__2; // 0x28
	private int <z>5__3; // 0x2C
	private RendererCell <cell>5__4; // 0x30
	private IEnumerator <enumerator>5__5; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x956ED0 Offset: 0x9554D0 VA: 0x180956ED0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x957270 Offset: 0x955870 VA: 0x180957270 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

