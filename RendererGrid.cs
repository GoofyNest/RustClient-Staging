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

	// RVA: 0x94EEC0 Offset: 0x94D4C0 VA: 0x18094EEC0
	protected void OnEnable() { }

	// RVA: 0x94EFC0 Offset: 0x94D5C0 VA: 0x18094EFC0
	public static void RefreshAll() { }

	// RVA: 0x94F120 Offset: 0x94D720 VA: 0x18094F120
	public void Refresh() { }

	// RVA: 0x94EA10 Offset: 0x94D010 VA: 0x18094EA10
	public RendererGroup Add(Vector3 position, RendererBatch batch) { }

	// RVA: 0x94F1D0 Offset: 0x94D7D0 VA: 0x18094F1D0
	public void Remove(RendererCell cell) { }

	// RVA: 0x94ED40 Offset: 0x94D340 VA: 0x18094ED40
	private void Init() { }

	// RVA: 0x94EC80 Offset: 0x94D280 VA: 0x18094EC80
	public MeshRendererBatch CreateInstance() { }

	// RVA: 0x94EF30 Offset: 0x94D530 VA: 0x18094EF30
	public void RecycleInstance(MeshRendererBatch instance) { }

	// RVA: 0x94EE00 Offset: 0x94D400 VA: 0x18094EE00
	public int MeshCount() { }

	// RVA: 0x94EBC0 Offset: 0x94D1C0 VA: 0x18094EBC0
	public int BatchedMeshCount() { }

	// RVA: 0x94F3F0 Offset: 0x94D9F0 VA: 0x18094F3F0
	public int VertexCount() { }

	// RVA: 0x94F550 Offset: 0x94DB50 VA: 0x18094F550
	public bool get_NeedsTimeout() { }

	// RVA: 0x94F340 Offset: 0x94D940 VA: 0x18094F340
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA9430 Offset: 0xA8830 VA: 0x1800A9430
	// RVA: 0x94F380 Offset: 0x94D980 VA: 0x18094F380
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x94F4B0 Offset: 0x94DAB0 VA: 0x18094F4B0
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

	// RVA: 0x956FE0 Offset: 0x9555E0 VA: 0x180956FE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x957380 Offset: 0x955980 VA: 0x180957380 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

