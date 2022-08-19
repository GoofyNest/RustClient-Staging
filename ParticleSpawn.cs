public class ParticleSpawn : SingletonComponent<ParticleSpawn>, IClientComponent // TypeDefIndex: 10359
{	// Fields
	public GameObjectRef[] Prefabs; // 0x18
	public int PatchCount; // 0x20
	public int PatchSize; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <Origin>k__BackingField; // 0x28
	private ParticlePatch[] patches; // 0x38

	// Properties
	public Vector3 Origin { get; set; }

	// Methods

	// RVA: 0x85D7A0 Offset: 0x85BDA0 VA: 0x18085D7A0
	public static float Distance(Vector3 pos) { }

	// RVA: 0x85DC80 Offset: 0x85C280 VA: 0x18085DC80
	public static void RefreshAll(bool force = False) { }

	// RVA: 0x85DED0 Offset: 0x85C4D0 VA: 0x18085DED0
	public static void RemoveAll(bool force = False) { }

	// RVA: 0x85D8E0 Offset: 0x85BEE0 VA: 0x18085D8E0
	public void Remove(bool force = False) { }

	// RVA: 0x85DD30 Offset: 0x85C330 VA: 0x18085DD30
	public void Refresh(bool force = False) { }

	[ContextMenu] // RVA: 0xCB460 Offset: 0xCA860 VA: 0x1800CB460
	// RVA: 0x85DBB0 Offset: 0x85C1B0 VA: 0x18085DBB0
	private void RefreshAll_ContextMenu() { }

	[ContextMenu] // RVA: 0xCB640 Offset: 0xCAA40 VA: 0x1800CB640
	// RVA: 0x85DD00 Offset: 0x85C300 VA: 0x18085DD00
	private void Refresh_ContextMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0440 Offset: 0x7CEA40 VA: 0x1807D0440
	public Vector3 get_Origin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC600 Offset: 0x4BAC00 VA: 0x1804BC600
	private void set_Origin(Vector3 value) { }

	// RVA: 0x85D720 Offset: 0x85BD20 VA: 0x18085D720 Slot: 6
	protected override void Awake() { }

	// RVA: 0x85DA70 Offset: 0x85C070 VA: 0x18085DA70
	private void InitPatches() { }

	// RVA: 0x85D8E0 Offset: 0x85BEE0 VA: 0x18085D8E0
	private void FreePatches() { }

	[IteratorStateMachineAttribute] // RVA: 0xCCC70 Offset: 0xCC070 VA: 0x1800CCC70
	// RVA: 0x85DF50 Offset: 0x85C550 VA: 0x18085DF50
	private IEnumerator UpdateCoroutine() { }

	// RVA: 0x85DFC0 Offset: 0x85C5C0 VA: 0x18085DFC0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x875FD0 Offset: 0x8745D0 VA: 0x180875FD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8763F0 Offset: 0x8749F0 VA: 0x1808763F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

