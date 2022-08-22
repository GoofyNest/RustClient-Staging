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

	// RVA: 0x843C80 Offset: 0x842280 VA: 0x180843C80
	public static void SetEnabled(bool b) { }

	// RVA: 0x843810 Offset: 0x841E10 VA: 0x180843810
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x843AE0 Offset: 0x8420E0 VA: 0x180843AE0
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x8433C0 Offset: 0x8419C0 VA: 0x1808433C0
	public void Remove(bool force = False) { }

	// RVA: 0x843980 Offset: 0x841F80 VA: 0x180843980
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	// RVA: 0x8437B0 Offset: 0x841DB0 VA: 0x1808437B0
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	// RVA: 0x843950 Offset: 0x841F50 VA: 0x180843950
	private void Refresh_ContextMenu() { }

	// RVA: 0x8436D0 Offset: 0x841CD0 VA: 0x1808436D0
	protected void OnEnable() { }

	// RVA: 0x843620 Offset: 0x841C20 VA: 0x180843620
	protected void OnDisable() { }

	// RVA: 0x843440 Offset: 0x841A40 VA: 0x180843440
	private void InitPatches() { }

	// RVA: 0x8433C0 Offset: 0x8419C0 VA: 0x1808433C0
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCB940 Offset: 0xCAD40 VA: 0x1800CB940
	// RVA: 0x843CF0 Offset: 0x8422F0 VA: 0x180843CF0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x843DD0 Offset: 0x8423D0 VA: 0x180843DD0
	public void .ctor() { }

	// RVA: 0x843D60 Offset: 0x842360 VA: 0x180843D60
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

	// RVA: 0x8590D0 Offset: 0x8576D0 VA: 0x1808590D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8592A0 Offset: 0x8578A0 VA: 0x1808592A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

