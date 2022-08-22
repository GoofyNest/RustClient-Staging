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

	// RVA: 0x94F3D0 Offset: 0x94D9D0 VA: 0x18094F3D0
	protected void OnEnable() { }

	// RVA: 0x94F4D0 Offset: 0x94DAD0 VA: 0x18094F4D0
	public static void RefreshAll() { }

	// RVA: 0x94F630 Offset: 0x94DC30 VA: 0x18094F630
	public void Refresh() { }

	// RVA: 0x94EF20 Offset: 0x94D520 VA: 0x18094EF20
	public RendererGroup Add(Vector3 position, RendererBatch batch) { }

	// RVA: 0x94F6E0 Offset: 0x94DCE0 VA: 0x18094F6E0
	public void Remove(RendererCell cell) { }

	// RVA: 0x94F250 Offset: 0x94D850 VA: 0x18094F250
	private void Init() { }

	// RVA: 0x94F190 Offset: 0x94D790 VA: 0x18094F190
	public MeshRendererBatch CreateInstance() { }

	// RVA: 0x94F440 Offset: 0x94DA40 VA: 0x18094F440
	public void RecycleInstance(MeshRendererBatch instance) { }

	// RVA: 0x94F310 Offset: 0x94D910 VA: 0x18094F310
	public int MeshCount() { }

	// RVA: 0x94F0D0 Offset: 0x94D6D0 VA: 0x18094F0D0
	public int BatchedMeshCount() { }

	// RVA: 0x94F900 Offset: 0x94DF00 VA: 0x18094F900
	public int VertexCount() { }

	// RVA: 0x94FA60 Offset: 0x94E060 VA: 0x18094FA60
	public bool get_NeedsTimeout() { }

	// RVA: 0x94F850 Offset: 0x94DE50 VA: 0x18094F850
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA9430 Offset: 0xA8830 VA: 0x1800A9430
	// RVA: 0x94F890 Offset: 0x94DE90 VA: 0x18094F890
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x94F9C0 Offset: 0x94DFC0 VA: 0x18094F9C0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x9574E0 Offset: 0x955AE0 VA: 0x1809574E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x957880 Offset: 0x955E80 VA: 0x180957880 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

