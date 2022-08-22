public class PrefabPoolWarmup // TypeDefIndex: 11426
{	// Methods

	// RVA: 0x9A1DD0 Offset: 0x9A03D0 VA: 0x1809A1DD0
	public static void Run() { }

	[IteratorStateMachineAttribute] // RVA: 0xB0150 Offset: 0xAF550 VA: 0x1800B0150
	// RVA: 0x9A1D30 Offset: 0x9A0330 VA: 0x1809A1D30
	public static IEnumerator Run(float deltaTime, Action<string> statusFunction, string format) { }

	// RVA: 0x9A18A0 Offset: 0x99FEA0 VA: 0x1809A18A0
	public static string[] GetAssetList() { }

	// RVA: 0x9A1AA0 Offset: 0x9A00A0 VA: 0x1809A1AA0
	private static void PrefabWarmup(string path) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class PrefabPoolWarmup.<Run>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11427
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float deltaTime; // 0x20
	public Action<string> statusFunction; // 0x28
	public string format; // 0x30
	private string[] <prewarmAssets>5__2; // 0x38
	private Stopwatch <sw>5__3; // 0x40
	private int <i>5__4; // 0x48

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

	// RVA: 0x9A8F30 Offset: 0x9A7530 VA: 0x1809A8F30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9A9290 Offset: 0x9A7890 VA: 0x1809A9290 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PrefabPoolWarmup.<>c // TypeDefIndex: 11428
{	// Fields
	public static readonly PrefabPoolWarmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, bool> <>9__2_0; // 0x8
	public static Func<GameManifest.PrefabProperties, string> <>9__2_1; // 0x10

	// Methods

	// RVA: 0x9A9350 Offset: 0x9A7950 VA: 0x1809A9350
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9A92E0 Offset: 0x9A78E0 VA: 0x1809A92E0
	internal bool <GetAssetList>b__2_0(GameManifest.PrefabProperties x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAssetList>b__2_1(GameManifest.PrefabProperties x) { }

}

