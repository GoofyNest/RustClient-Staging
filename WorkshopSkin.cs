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

	// RVA: 0xE86260 Offset: 0xE84860 VA: 0x180E86260
	public static string GetStatus() { }

	// RVA: 0xE878A0 Offset: 0xE85EA0 VA: 0x180E878A0
	public static int get_QueuedCount() { }

	// RVA: 0xE87800 Offset: 0xE85E00 VA: 0x180E87800
	public static int get_LoadedCount() { }

	// RVA: 0xE861E0 Offset: 0xE847E0 VA: 0x180E861E0
	public static Skin GetSkin(ulong workshopId) { }

	// RVA: 0xE86160 Offset: 0xE84760 VA: 0x180E86160
	public static IWorkshopContent GetItem(ulong workshopId) { }

	// RVA: 0xE85A30 Offset: 0xE84030 VA: 0x180E85A30
	public static void Apply(GameObject gameobj, ulong workshopId, Action callback) { }

	// RVA: 0xE87340 Offset: 0xE85940 VA: 0x180E87340
	public static void Reset(GameObject gameobj) { }

	// RVA: 0xE872A0 Offset: 0xE858A0 VA: 0x180E872A0
	public static void Prepare(GameObject gameobj) { }

	// RVA: 0xE87220 Offset: 0xE85820 VA: 0x180E87220
	protected void OnDestroy() { }

	// RVA: 0xE85B50 Offset: 0xE84150 VA: 0x180E85B50
	private void Apply(ulong workshopId, Action callback) { }

	// RVA: 0xE85FB0 Offset: 0xE845B0 VA: 0x180E85FB0
	private void EnqueueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE86D10 Offset: 0xE85310 VA: 0x180E86D10
	private static void LoadFromWorkshop(ulong workshopId) { }

	// RVA: 0xE85E90 Offset: 0xE84490 VA: 0x180E85E90
	private void DequeueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE87090 Offset: 0xE85690 VA: 0x180E87090
	private static void LoadOrUnloadSkinAssets(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC8EE0 Offset: 0xC82E0 VA: 0x1800C8EE0
	// RVA: 0xE86CC0 Offset: 0xE852C0 VA: 0x180E86CC0
	private static IEnumerator ItemQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC90B0 Offset: 0xC84B0 VA: 0x1800C90B0
	// RVA: 0xE873E0 Offset: 0xE859E0 VA: 0x180E873E0
	private static IEnumerator SkinQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC9180 Offset: 0xC8580 VA: 0x1800C9180
	// RVA: 0xE87030 Offset: 0xE85630 VA: 0x180E87030
	private static IEnumerator LoadItem(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC9580 Offset: 0xC8980 VA: 0x1800C9580
	// RVA: 0xE871C0 Offset: 0xE857C0 VA: 0x180E871C0
	private static IEnumerator LoadSkin(ulong workshopId) { }

	// RVA: 0xE86120 Offset: 0xE84720 VA: 0x180E86120
	private static int GetBundleIndex(ulong workshopId) { }

	// RVA: 0xE858F0 Offset: 0xE83EF0 VA: 0x180E858F0
	private void ApplySkin(Skin skin, ulong workshopId) { }

	// RVA: 0xE87430 Offset: 0xE85A30 VA: 0x180E87430
	private void UpdateSkinReference(Skin skin, ulong workshopId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xE875E0 Offset: 0xE85BE0 VA: 0x180E875E0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE7AB20 Offset: 0xE79120 VA: 0x180E7AB20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE7ACA0 Offset: 0xE792A0 VA: 0x180E7ACA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE801B0 Offset: 0xE7E7B0 VA: 0x180E801B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE80330 Offset: 0xE7E930 VA: 0x180E80330 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE7CB30 Offset: 0xE7B130 VA: 0x180E7CB30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE7D2E0 Offset: 0xE7B8E0 VA: 0x180E7D2E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE7D920 Offset: 0xE7BF20 VA: 0x180E7D920 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE7DE10 Offset: 0xE7C410 VA: 0x180E7DE10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class WorkshopSkin : WorkshopSkinBase // TypeDefIndex: 10779
{	// Methods

	// RVA: 0x8FEB60 Offset: 0x8FD160 VA: 0x1808FEB60
	public void .ctor() { }

}

