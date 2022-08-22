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

	// RVA: 0x74DE90 Offset: 0x74C490 VA: 0x18074DE90
	public static float get_MaxRefreshDistance() { }

	// RVA: 0x74DD60 Offset: 0x74C360 VA: 0x18074DD60
	public bool get_Initialized() { }

	// RVA: 0x74DDF0 Offset: 0x74C3F0 VA: 0x18074DDF0
	public float get_MaxMilliseconds() { }

	// RVA: 0x74D690 Offset: 0x74BC90 VA: 0x18074D690
	protected void OnEnable() { }

	// RVA: 0x74D790 Offset: 0x74BD90 VA: 0x18074D790
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x74D9B0 Offset: 0x74BFB0 VA: 0x18074D9B0
	public void Refresh(bool force = False) { }

	// RVA: 0x74DD70 Offset: 0x74C370 VA: 0x18074DD70
	public FoliageCell get_Item(Vector3 worldPos) { }

	// RVA: 0x74D370 Offset: 0x74B970 VA: 0x18074D370
	private void Init() { }

	// RVA: 0x74D1F0 Offset: 0x74B7F0 VA: 0x18074D1F0
	public FoliageGridBatch CreateInstance() { }

	// RVA: 0x74D700 Offset: 0x74BD00 VA: 0x18074D700
	public void RecycleInstance(FoliageGridBatch instance) { }

	// RVA: 0x74D060 Offset: 0x74B660 VA: 0x18074D060
	public void AddPlacement(FoliagePlacement placement) { }

	// RVA: 0x74D540 Offset: 0x74BB40 VA: 0x18074D540
	public int MeshCount() { }

	// RVA: 0x74D140 Offset: 0x74B740 VA: 0x18074D140
	public int BatchedMeshCount() { }

	// RVA: 0x74DBD0 Offset: 0x74C1D0 VA: 0x18074DBD0
	public int VertexCount() { }

	// RVA: 0x74DF30 Offset: 0x74C530 VA: 0x18074DF30
	public bool get_NeedsTimeout() { }

	// RVA: 0x74DB20 Offset: 0x74C120 VA: 0x18074DB20
	public void ResetTimeout() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2E30 Offset: 0xA2230 VA: 0x1800A2E30
	// RVA: 0x74DB60 Offset: 0x74C160 VA: 0x18074DB60
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x74D5F0 Offset: 0x74BBF0 VA: 0x18074D5F0
	private bool NeedsUpdate() { }

	// RVA: 0x74D2B0 Offset: 0x74B8B0 VA: 0x18074D2B0
	private Vector2i GetCurrentCellCoordinates() { }

	// RVA: 0x74DC80 Offset: 0x74C280 VA: 0x18074DC80
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

	// RVA: 0x763F30 Offset: 0x762530 VA: 0x180763F30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7647C0 Offset: 0x762DC0 VA: 0x1807647C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

