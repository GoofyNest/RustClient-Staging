public class DecorSpawn : MonoBehaviour, IClientComponent // TypeDefIndex: 10338
{	public static List<DecorSpawn> Instances; // 0x0
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


	public static void SetEnabled(bool b) { }

	public static void RefreshAll(bool force = False) { }

	public static void RemoveAll(bool force = False) { }

	public void Remove(bool force = False) { }

	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB880 Offset: 0xCAC80 VA: 0x1800CB880
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCBB30 Offset: 0xCAF30 VA: 0x1800CBB30
	private void Refresh_ContextMenu() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	private void InitPatches() { }

	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCBD20 Offset: 0xCB120 VA: 0x1800CBD20
	private IEnumerator UpdateCoroutine() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class DecorSpawn.<UpdateCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10339
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DecorSpawn <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

