public class DecorSpawn : MonoBehaviour, IClientComponent // TypeDefIndex: 10334
{	// Fields
	public static List<DecorSpawn> Instances; // 0x0
	private static bool Enabled; // 0x8
	public SpawnFilter Filter; // 0x18
	public string ResourceFolder; // 0x20
	public uint Seed; // 0x28
	public float ObjectCutoff; // 0x2C
	public float ObjectTapering; // 0x30
	public int ObjectsPerPatch; // 0x34
	public float ClusterRadius; // 0x38
	public int ClusterSizeMin; // 0x3C
	public int ClusterSizeMax; // 0x40
	public int PatchCount; // 0x44
	public int PatchSize; // 0x48
	public bool LOD; // 0x4C
	internal Transform Anchor; // 0x50
	internal Prefab[] Prefabs; // 0x58
	private DecorPatch[] patches; // 0x60

	// Methods

	// RVA: 0x8441D0 Offset: 0x8427D0 VA: 0x1808441D0
	public static void SetEnabled(bool b) { }

	// RVA: 0x843D60 Offset: 0x842360 VA: 0x180843D60
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x844030 Offset: 0x842630 VA: 0x180844030
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x843910 Offset: 0x841F10 VA: 0x180843910
	public void Remove(bool force = False) { }

	// RVA: 0x843ED0 Offset: 0x8424D0 VA: 0x180843ED0
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	// RVA: 0x843D00 Offset: 0x842300 VA: 0x180843D00
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	// RVA: 0x843EA0 Offset: 0x8424A0 VA: 0x180843EA0
	private void Refresh_ContextMenu() { }

	// RVA: 0x843C20 Offset: 0x842220 VA: 0x180843C20
	protected void OnEnable() { }

	// RVA: 0x843B70 Offset: 0x842170 VA: 0x180843B70
	protected void OnDisable() { }

	// RVA: 0x843990 Offset: 0x841F90 VA: 0x180843990
	private void InitPatches() { }

	// RVA: 0x843910 Offset: 0x841F10 VA: 0x180843910
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCB940 Offset: 0xCAD40 VA: 0x1800CB940
	// RVA: 0x844240 Offset: 0x842840 VA: 0x180844240
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x844320 Offset: 0x842920 VA: 0x180844320
	public void .ctor() { }

	// RVA: 0x8442B0 Offset: 0x8428B0 VA: 0x1808442B0
	private static void .cctor() { }

}

private sealed class DecorSpawn.<UpdateCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10335
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DecorSpawn <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x859620 Offset: 0x857C20 VA: 0x180859620 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8597F0 Offset: 0x857DF0 VA: 0x1808597F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

