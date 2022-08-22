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

	// RVA: 0x74DDE0 Offset: 0x74C3E0 VA: 0x18074DDE0
	public static float get_MaxRefreshDistance() { }

	// RVA: 0x74DCB0 Offset: 0x74C2B0 VA: 0x18074DCB0
	public bool get_Initialized() { }

	// RVA: 0x74DD40 Offset: 0x74C340 VA: 0x18074DD40
	public float get_MaxMilliseconds() { }

	// RVA: 0x74D5E0 Offset: 0x74BBE0 VA: 0x18074D5E0
	protected void OnEnable() { }

	// RVA: 0x74D6E0 Offset: 0x74BCE0 VA: 0x18074D6E0
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x74D900 Offset: 0x74BF00 VA: 0x18074D900
	public void Refresh(bool force = False) { }

	// RVA: 0x74DCC0 Offset: 0x74C2C0 VA: 0x18074DCC0
	public FoliageCell get_Item(Vector3 worldPos) { }

	// RVA: 0x74D2C0 Offset: 0x74B8C0 VA: 0x18074D2C0
	private void Init() { }

	// RVA: 0x74D140 Offset: 0x74B740 VA: 0x18074D140
	public FoliageGridBatch CreateInstance() { }

	// RVA: 0x74D650 Offset: 0x74BC50 VA: 0x18074D650
	public void RecycleInstance(FoliageGridBatch instance) { }

	// RVA: 0x74CFB0 Offset: 0x74B5B0 VA: 0x18074CFB0
	public void AddPlacement(FoliagePlacement placement) { }

	// RVA: 0x74D490 Offset: 0x74BA90 VA: 0x18074D490
	public int MeshCount() { }

	// RVA: 0x74D090 Offset: 0x74B690 VA: 0x18074D090
	public int BatchedMeshCount() { }

	// RVA: 0x74DB20 Offset: 0x74C120 VA: 0x18074DB20
	public int VertexCount() { }

	// RVA: 0x74DE80 Offset: 0x74C480 VA: 0x18074DE80
	public bool get_NeedsTimeout() { }

	// RVA: 0x74DA70 Offset: 0x74C070 VA: 0x18074DA70
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2E30 Offset: 0xA2230 VA: 0x1800A2E30
	// RVA: 0x74DAB0 Offset: 0x74C0B0 VA: 0x18074DAB0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x74D540 Offset: 0x74BB40 VA: 0x18074D540
	private bool NeedsUpdate() { }

	// RVA: 0x74D200 Offset: 0x74B800 VA: 0x18074D200
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x74DBD0 Offset: 0x74C1D0 VA: 0x18074DBD0
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

	// RVA: 0x763E80 Offset: 0x762480 VA: 0x180763E80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x764710 Offset: 0x762D10 VA: 0x180764710 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

