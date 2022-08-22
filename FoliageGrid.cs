public class FoliageGrid : SingletonComponent<FoliageGrid>, IClientComponent // TypeDefIndex: 9871
{	// Fields
	public static bool Paused; // 0x0
	public GameObjectRef BatchPrefab; // 0x18
	public float CellSize; // 0x20
	public LayerSelect FoliageLayer; // 0x24
	public ShadowCastingMode FoliageShadows; // 0x28
	internal ListHashSet<FoliagePlacement> Placements; // 0x30
	private WorldSpaceGrid<FoliageCell> grid; // 0x38
	private Vector2i curCell; // 0x40
	private Vector3 prevPosition; // 0x48
	private Stopwatch watch; // 0x58

	// Properties
	public static float MaxRefreshDistance { get; }
	public bool Initialized { get; }
	public float MaxMilliseconds { get; }
	public FoliageCell Item { get; }
	public bool NeedsTimeout { get; }

	// Methods

	// RVA: 0x74DD80 Offset: 0x74C380 VA: 0x18074DD80
	public static float get_MaxRefreshDistance() { }

	// RVA: 0x74DC50 Offset: 0x74C250 VA: 0x18074DC50
	public bool get_Initialized() { }

	// RVA: 0x74DCE0 Offset: 0x74C2E0 VA: 0x18074DCE0
	public float get_MaxMilliseconds() { }

	// RVA: 0x74D580 Offset: 0x74BB80 VA: 0x18074D580
	protected void OnEnable() { }

	// RVA: 0x74D680 Offset: 0x74BC80 VA: 0x18074D680
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x74D8A0 Offset: 0x74BEA0 VA: 0x18074D8A0
	public void Refresh(bool force = False) { }

	// RVA: 0x74DC60 Offset: 0x74C260 VA: 0x18074DC60
	public FoliageCell get_Item(Vector3 worldPos) { }

	// RVA: 0x74D260 Offset: 0x74B860 VA: 0x18074D260
	private void Init() { }

	// RVA: 0x74D0E0 Offset: 0x74B6E0 VA: 0x18074D0E0
	public FoliageGridBatch CreateInstance() { }

	// RVA: 0x74D5F0 Offset: 0x74BBF0 VA: 0x18074D5F0
	public void RecycleInstance(FoliageGridBatch instance) { }

	// RVA: 0x74CF50 Offset: 0x74B550 VA: 0x18074CF50
	public void AddPlacement(FoliagePlacement placement) { }

	// RVA: 0x74D430 Offset: 0x74BA30 VA: 0x18074D430
	public int MeshCount() { }

	// RVA: 0x74D030 Offset: 0x74B630 VA: 0x18074D030
	public int BatchedMeshCount() { }

	// RVA: 0x74DAC0 Offset: 0x74C0C0 VA: 0x18074DAC0
	public int VertexCount() { }

	// RVA: 0x74DE20 Offset: 0x74C420 VA: 0x18074DE20
	public bool get_NeedsTimeout() { }

	// RVA: 0x74DA10 Offset: 0x74C010 VA: 0x18074DA10
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2E30 Offset: 0xA2230 VA: 0x1800A2E30
	// RVA: 0x74DA50 Offset: 0x74C050 VA: 0x18074DA50
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x74D4E0 Offset: 0x74BAE0 VA: 0x18074D4E0
	private bool NeedsUpdate() { }

	// RVA: 0x74D1A0 Offset: 0x74B7A0 VA: 0x18074D1A0
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x74DB70 Offset: 0x74C170 VA: 0x18074DB70
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class FoliageGrid.<UpdateCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9872
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FoliageGrid <>4__this; // 0x20
	private Vector2i <newCell>5__2; // 0x28
	private List<FoliageCell> <cells>5__3; // 0x30
	private List<IEnumerator> <enumerators>5__4; // 0x38
	private int <i>5__5; // 0x40

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

	// RVA: 0x763E20 Offset: 0x762420 VA: 0x180763E20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7646B0 Offset: 0x762CB0 VA: 0x1807646B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

