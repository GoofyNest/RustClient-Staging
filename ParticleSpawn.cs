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

	// RVA: 0x879010 Offset: 0x877610 VA: 0x180879010
	public static float Distance(Vector3 pos) { }

	// RVA: 0x8794F0 Offset: 0x877AF0 VA: 0x1808794F0
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x879740 Offset: 0x877D40 VA: 0x180879740
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x879150 Offset: 0x877750 VA: 0x180879150
	public void Remove(bool force = False) { }

	// RVA: 0x8795A0 Offset: 0x877BA0 VA: 0x1808795A0
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	// RVA: 0x879420 Offset: 0x877A20 VA: 0x180879420
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	// RVA: 0x879570 Offset: 0x877B70 VA: 0x180879570
	private void Refresh_ContextMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79B7E0 Offset: 0x799DE0 VA: 0x18079B7E0
	public Vector3 get_Origin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC590 Offset: 0x4BAB90 VA: 0x1804BC590
	private void set_Origin(Vector3 value) { }

	// RVA: 0x878F90 Offset: 0x877590 VA: 0x180878F90 Slot: 6
	protected override void Awake() { }

	// RVA: 0x8792E0 Offset: 0x8778E0 VA: 0x1808792E0
	private void InitPatches() { }

	// RVA: 0x879150 Offset: 0x877750 VA: 0x180879150
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCCD80 Offset: 0xCC180 VA: 0x1800CCD80
	// RVA: 0x8797C0 Offset: 0x877DC0 VA: 0x1808797C0
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x879830 Offset: 0x877E30 VA: 0x180879830
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

	// RVA: 0x891800 Offset: 0x88FE00 VA: 0x180891800 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x891C20 Offset: 0x890220 VA: 0x180891C20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

