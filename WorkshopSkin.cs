public class WorkshopSkin : MonoBehaviour // TypeDefIndex: 7723
{	// Fields
	public static bool AllowApply; // 0x0
	public static bool AllowUnload; // 0x1
	public static float DownloadTimeout; // 0x4
	private static WaitForSeconds waitForSeconds; // 0x8
	private static AssetBundleCreateRequest[] bundleRequests; // 0x10
	private static AssetBundle[] bundles; // 0x18
	private static ListDictionary<ulong, ListHashSet<WorkshopSkin>> RefreshQueue; // 0x20
	private static Queue<ulong> ItemQueue; // 0x28
	private static Queue<ulong> SkinQueue; // 0x30
	private static ListDictionary<ulong, IWorkshopContent> ItemCache; // 0x38
	private static ListDictionary<ulong, Skin> SkinCache; // 0x40
	private ulong RequestedWorkshopID; // 0x18
	private ulong AppliedWorkshopID; // 0x20
	private Action OnRefresh; // 0x28
	private Skin AppliedSkin; // 0x30

	// Properties
	public static int QueuedCount { get; }
	public static int LoadedCount { get; }

	// Methods

	// RVA: 0xE86FD0 Offset: 0xE855D0 VA: 0x180E86FD0
	public static string GetStatus() { }

	// RVA: 0xE88610 Offset: 0xE86C10 VA: 0x180E88610
	public static int get_QueuedCount() { }

	// RVA: 0xE88570 Offset: 0xE86B70 VA: 0x180E88570
	public static int get_LoadedCount() { }

	// RVA: 0xE86F50 Offset: 0xE85550 VA: 0x180E86F50
	public static Skin GetSkin(ulong workshopId) { }

	// RVA: 0xE86ED0 Offset: 0xE854D0 VA: 0x180E86ED0
	public static IWorkshopContent GetItem(ulong workshopId) { }

	// RVA: 0xE867A0 Offset: 0xE84DA0 VA: 0x180E867A0
	public static void Apply(GameObject gameobj, ulong workshopId, Action callback) { }

	// RVA: 0xE880B0 Offset: 0xE866B0 VA: 0x180E880B0
	public static void Reset(GameObject gameobj) { }

	// RVA: 0xE88010 Offset: 0xE86610 VA: 0x180E88010
	public static void Prepare(GameObject gameobj) { }

	// RVA: 0xE87F90 Offset: 0xE86590 VA: 0x180E87F90
	protected void OnDestroy() { }

	// RVA: 0xE868C0 Offset: 0xE84EC0 VA: 0x180E868C0
	private void Apply(ulong workshopId, Action callback) { }

	// RVA: 0xE86D20 Offset: 0xE85320 VA: 0x180E86D20
	private void EnqueueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE87A80 Offset: 0xE86080 VA: 0x180E87A80
	private static void LoadFromWorkshop(ulong workshopId) { }

	// RVA: 0xE86C00 Offset: 0xE85200 VA: 0x180E86C00
	private void DequeueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE87E00 Offset: 0xE86400 VA: 0x180E87E00
	private static void LoadOrUnloadSkinAssets(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC8F70 Offset: 0xC8370 VA: 0x1800C8F70
	// RVA: 0xE87A30 Offset: 0xE86030 VA: 0x180E87A30
	private static IEnumerator ItemQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC9140 Offset: 0xC8540 VA: 0x1800C9140
	// RVA: 0xE88150 Offset: 0xE86750 VA: 0x180E88150
	private static IEnumerator SkinQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC91E0 Offset: 0xC85E0 VA: 0x1800C91E0
	// RVA: 0xE87DA0 Offset: 0xE863A0 VA: 0x180E87DA0
	private static IEnumerator LoadItem(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC9610 Offset: 0xC8A10 VA: 0x1800C9610
	// RVA: 0xE87F30 Offset: 0xE86530 VA: 0x180E87F30
	private static IEnumerator LoadSkin(ulong workshopId) { }

	// RVA: 0xE86E90 Offset: 0xE85490 VA: 0x180E86E90
	private static int GetBundleIndex(ulong workshopId) { }

	// RVA: 0xE86660 Offset: 0xE84C60 VA: 0x180E86660
	private void ApplySkin(Skin skin, ulong workshopId) { }

	// RVA: 0xE881A0 Offset: 0xE867A0 VA: 0x180E881A0
	private void UpdateSkinReference(Skin skin, ulong workshopId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xE88350 Offset: 0xE86950 VA: 0x180E88350
	private static void .cctor() { }

}

private sealed class WorkshopSkin.<ItemQueueCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7724
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

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

	// RVA: 0xE7B890 Offset: 0xE79E90 VA: 0x180E7B890 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7BA10 Offset: 0xE7A010 VA: 0x180E7BA10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<SkinQueueCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7725
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

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

	// RVA: 0xE80F20 Offset: 0xE7F520 VA: 0x180E80F20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE810A0 Offset: 0xE7F6A0 VA: 0x180E810A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadItem>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7726
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ulong workshopId; // 0x20
	private int <index>5__2; // 0x28
	private IWorkshopContent <item>5__3; // 0x30
	private bool <itemInstallStarted>5__4; // 0x38
	private Stopwatch <sw>5__5; // 0x40

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

	// RVA: 0xE7D8A0 Offset: 0xE7BEA0 VA: 0x180E7D8A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7E050 Offset: 0xE7C650 VA: 0x180E7E050 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadSkin>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7727
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ulong workshopId; // 0x20
	private AssetBundle <bundle>5__2; // 0x28
	private IWorkshopContent <item>5__3; // 0x30
	private Skin <skin>5__4; // 0x38
	private ListHashSet<WorkshopSkin> <instances>5__5; // 0x40

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

	// RVA: 0xE7E690 Offset: 0xE7CC90 VA: 0x180E7E690 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7EB80 Offset: 0xE7D180 VA: 0x180E7EB80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class WorkshopSkin : WorkshopSkinBase // TypeDefIndex: 10779
{	// Methods

	// RVA: 0x8FF180 Offset: 0x8FD780 VA: 0x1808FF180
	public void .ctor() { }

}

