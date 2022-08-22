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

	// RVA: 0x843B70 Offset: 0x842170 VA: 0x180843B70
	public static void SetEnabled(bool b) { }

	// RVA: 0x843700 Offset: 0x841D00 VA: 0x180843700
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x8439D0 Offset: 0x841FD0 VA: 0x1808439D0
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x8432B0 Offset: 0x8418B0 VA: 0x1808432B0
	public void Remove(bool force = False) { }

	// RVA: 0x843870 Offset: 0x841E70 VA: 0x180843870
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	// RVA: 0x8436A0 Offset: 0x841CA0 VA: 0x1808436A0
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	// RVA: 0x843840 Offset: 0x841E40 VA: 0x180843840
	private void Refresh_ContextMenu() { }

	// RVA: 0x8435C0 Offset: 0x841BC0 VA: 0x1808435C0
	protected void OnEnable() { }

	// RVA: 0x843510 Offset: 0x841B10 VA: 0x180843510
	protected void OnDisable() { }

	// RVA: 0x843330 Offset: 0x841930 VA: 0x180843330
	private void InitPatches() { }

	// RVA: 0x8432B0 Offset: 0x8418B0 VA: 0x1808432B0
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCB940 Offset: 0xCAD40 VA: 0x1800CB940
	// RVA: 0x843BE0 Offset: 0x8421E0 VA: 0x180843BE0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x843CC0 Offset: 0x8422C0 VA: 0x180843CC0
	public void .ctor() { }

	// RVA: 0x843C50 Offset: 0x842250 VA: 0x180843C50
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

	// RVA: 0x858FC0 Offset: 0x8575C0 VA: 0x180858FC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x859190 Offset: 0x857790 VA: 0x180859190 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

