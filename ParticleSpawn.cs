public class ParticleSpawn : SingletonComponent<ParticleSpawn>, IClientComponent // TypeDefIndex: 10359
{	public GameObjectRef[] Prefabs; // 0x18
	public int PatchCount; // 0x20
	public int PatchSize; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <Origin>k__BackingField; // 0x28
	private ParticlePatch[] patches; // 0x38

	public Vector3 Origin { get; set; }


	public static float Distance(Vector3 pos) { }

	public static void RefreshAll(bool force = False) { }

	public static void RemoveAll(bool force = False) { }

	public void Remove(bool force = False) { }

	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	private void Refresh_ContextMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_Origin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Origin(Vector3 value) { }

	protected override void Awake() { }

	private void InitPatches() { }

	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCCD80 Offset: 0xCC180 VA: 0x1800CCD80
	private IEnumerator UpdateCoroutine() { }

	public void .ctor() { }

}

private sealed class ParticleSpawn.<UpdateCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10360
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ParticleSpawn <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

