public class ParticleSpawn : SingletonComponent<ParticleSpawn>, IClientComponent // TypeDefIndex: 10359
{	// Fields
	public GameObjectRef[] Prefabs; // 0x18
	public int PatchCount; // 0x20
	public int PatchSize; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <Origin>k__BackingField; // 0x28
	private ParticlePatch[] patches; // 0x38

	// Properties
	public Vector3 Origin { get; set; }

	// Methods

	// RVA: 0x85D8B0 Offset: 0x85BEB0 VA: 0x18085D8B0
	public static float Distance(Vector3 pos) { }

	// RVA: 0x85DD90 Offset: 0x85C390 VA: 0x18085DD90
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x85DFE0 Offset: 0x85C5E0 VA: 0x18085DFE0
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x85D9F0 Offset: 0x85BFF0 VA: 0x18085D9F0
	public void Remove(bool force = False) { }

	// RVA: 0x85DE40 Offset: 0x85C440 VA: 0x18085DE40
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	// RVA: 0x85DCC0 Offset: 0x85C2C0 VA: 0x18085DCC0
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	// RVA: 0x85DE10 Offset: 0x85C410 VA: 0x18085DE10
	private void Refresh_ContextMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0550 Offset: 0x7CEB50 VA: 0x1807D0550
	public Vector3 get_Origin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC600 Offset: 0x4BAC00 VA: 0x1804BC600
	private void set_Origin(Vector3 value) { }

	// RVA: 0x85D830 Offset: 0x85BE30 VA: 0x18085D830 Slot: 6
	protected override void Awake() { }

	// RVA: 0x85DB80 Offset: 0x85C180 VA: 0x18085DB80
	private void InitPatches() { }

	// RVA: 0x85D9F0 Offset: 0x85BFF0 VA: 0x18085D9F0
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCCD80 Offset: 0xCC180 VA: 0x1800CCD80
	// RVA: 0x85E060 Offset: 0x85C660 VA: 0x18085E060
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x85E0D0 Offset: 0x85C6D0 VA: 0x18085E0D0
	public void .ctor() { }

}

private sealed class ParticleSpawn.<UpdateCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10360
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ParticleSpawn <>4__this; // 0x20

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

	// RVA: 0x8760E0 Offset: 0x8746E0 VA: 0x1808760E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x876500 Offset: 0x874B00 VA: 0x180876500 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

