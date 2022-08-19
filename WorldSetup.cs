public class WorldSetup : SingletonComponent<WorldSetup> // TypeDefIndex: 10571
{	// Fields
	public bool AutomaticallySetup; // 0x18
	public GameObject terrain; // 0x20
	public GameObject decorPrefab; // 0x28
	public GameObject grassPrefab; // 0x30
	public GameObject spawnPrefab; // 0x38
	private TerrainMeta terrainMeta; // 0x40
	public uint EditorSeed; // 0x48
	public uint EditorSalt; // 0x4C
	public uint EditorSize; // 0x50
	public string EditorUrl; // 0x58
	internal List<ProceduralObject> ProceduralObjects; // 0x60
	internal List<MonumentNode> MonumentNodes; // 0x68

	// Methods

	// RVA: 0x902CA0 Offset: 0x9012A0 VA: 0x180902CA0
	private void OnValidate() { }

	// RVA: 0x902660 Offset: 0x900C60 VA: 0x180902660 Slot: 6
	protected override void Awake() { }

	// RVA: 0x902B70 Offset: 0x901170 VA: 0x180902B70
	protected void CreateObject(GameObject prefab) { }

	[IteratorStateMachineAttribute] // RVA: 0xDB950 Offset: 0xDAD50 VA: 0x1800DB950
	// RVA: 0x902C30 Offset: 0x901230 VA: 0x180902C30
	public IEnumerator InitCoroutine() { }

	// RVA: 0x902B10 Offset: 0x901110 VA: 0x180902B10
	private void CancelSetup(string msg) { }

	// RVA: 0x902D70 Offset: 0x901370 VA: 0x180902D70
	public void .ctor() { }

}

private sealed class WorldSetup.<>c // TypeDefIndex: 10572
{	// Fields
	public static readonly WorldSetup.<>c <>9; // 0x0
	public static Action<string> <>9__15_0; // 0x8
	public static Action<string> <>9__15_1; // 0x10

	// Methods

	// RVA: 0x8EE180 Offset: 0x8EC780 VA: 0x1808EE180
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8EDFB0 Offset: 0x8EC5B0 VA: 0x1808EDFB0
	internal void <InitCoroutine>b__15_0(string str) { }

	// RVA: 0x8EDFB0 Offset: 0x8EC5B0 VA: 0x1808EDFB0
	internal void <InitCoroutine>b__15_1(string str) { }

}

private sealed class WorldSetup.<InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10573
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorldSetup <>4__this; // 0x20
	private ProceduralComponent[] <components>5__2; // 0x28
	private Timing <downloadTimer>5__3; // 0x30
	private Timing <loadTimer>5__4; // 0x40
	private Timing <receiveTimer>5__5; // 0x50
	private Timing <spawnTimer>5__6; // 0x60
	private Timing <procgenTimer>5__7; // 0x70
	private Timing <saveTimer>5__8; // 0x80
	private Timing <checksumTimer>5__9; // 0x90
	private Timing <finalizeTimer>5__10; // 0xA0
	private Timing <cleaningTimer>5__11; // 0xB0
	private UnityWebRequest <request>5__12; // 0xC0
	private IEnumerator <worldSpawn>5__13; // 0xC8
	private int <i>5__14; // 0xD0
	private ProceduralComponent <component>5__15; // 0xD8
	private uint <seed>5__16; // 0xE0

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

	// RVA: 0x8E96C0 Offset: 0x8E7CC0 VA: 0x1808E96C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8EC720 Offset: 0x8EAD20 VA: 0x1808EC720 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

