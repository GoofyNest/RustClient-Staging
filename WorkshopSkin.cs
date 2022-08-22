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

	// RVA: 0xE86520 Offset: 0xE84B20 VA: 0x180E86520
	public static string GetStatus() { }

	// RVA: 0xE87B60 Offset: 0xE86160 VA: 0x180E87B60
	public static int get_QueuedCount() { }

	// RVA: 0xE87AC0 Offset: 0xE860C0 VA: 0x180E87AC0
	public static int get_LoadedCount() { }

	// RVA: 0xE864A0 Offset: 0xE84AA0 VA: 0x180E864A0
	public static Skin GetSkin(ulong workshopId) { }

	// RVA: 0xE86420 Offset: 0xE84A20 VA: 0x180E86420
	public static IWorkshopContent GetItem(ulong workshopId) { }

	// RVA: 0xE85CF0 Offset: 0xE842F0 VA: 0x180E85CF0
	public static void Apply(GameObject gameobj, ulong workshopId, Action callback) { }

	// RVA: 0xE87600 Offset: 0xE85C00 VA: 0x180E87600
	public static void Reset(GameObject gameobj) { }

	// RVA: 0xE87560 Offset: 0xE85B60 VA: 0x180E87560
	public static void Prepare(GameObject gameobj) { }

	// RVA: 0xE874E0 Offset: 0xE85AE0 VA: 0x180E874E0
	protected void OnDestroy() { }

	// RVA: 0xE85E10 Offset: 0xE84410 VA: 0x180E85E10
	private void Apply(ulong workshopId, Action callback) { }

	// RVA: 0xE86270 Offset: 0xE84870 VA: 0x180E86270
	private void EnqueueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE86FD0 Offset: 0xE855D0 VA: 0x180E86FD0
	private static void LoadFromWorkshop(ulong workshopId) { }

	// RVA: 0xE86150 Offset: 0xE84750 VA: 0x180E86150
	private void DequeueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE87350 Offset: 0xE85950 VA: 0x180E87350
	private static void LoadOrUnloadSkinAssets(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC8F70 Offset: 0xC8370 VA: 0x1800C8F70
	// RVA: 0xE86F80 Offset: 0xE85580 VA: 0x180E86F80
	private static IEnumerator ItemQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC9140 Offset: 0xC8540 VA: 0x1800C9140
	// RVA: 0xE876A0 Offset: 0xE85CA0 VA: 0x180E876A0
	private static IEnumerator SkinQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC91E0 Offset: 0xC85E0 VA: 0x1800C91E0
	// RVA: 0xE872F0 Offset: 0xE858F0 VA: 0x180E872F0
	private static IEnumerator LoadItem(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC9610 Offset: 0xC8A10 VA: 0x1800C9610
	// RVA: 0xE87480 Offset: 0xE85A80 VA: 0x180E87480
	private static IEnumerator LoadSkin(ulong workshopId) { }

	// RVA: 0xE863E0 Offset: 0xE849E0 VA: 0x180E863E0
	private static int GetBundleIndex(ulong workshopId) { }

	// RVA: 0xE85BB0 Offset: 0xE841B0 VA: 0x180E85BB0
	private void ApplySkin(Skin skin, ulong workshopId) { }

	// RVA: 0xE876F0 Offset: 0xE85CF0 VA: 0x180E876F0
	private void UpdateSkinReference(Skin skin, ulong workshopId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xE878A0 Offset: 0xE85EA0 VA: 0x180E878A0
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

	// RVA: 0xE7ADE0 Offset: 0xE793E0 VA: 0x180E7ADE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7AF60 Offset: 0xE79560 VA: 0x180E7AF60 Slot: 8
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

	// RVA: 0xE80470 Offset: 0xE7EA70 VA: 0x180E80470 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE805F0 Offset: 0xE7EBF0 VA: 0x180E805F0 Slot: 8
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

	// RVA: 0xE7CDF0 Offset: 0xE7B3F0 VA: 0x180E7CDF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7D5A0 Offset: 0xE7BBA0 VA: 0x180E7D5A0 Slot: 8
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

	// RVA: 0xE7DBE0 Offset: 0xE7C1E0 VA: 0x180E7DBE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7E0D0 Offset: 0xE7C6D0 VA: 0x180E7E0D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class WorkshopSkin : WorkshopSkinBase // TypeDefIndex: 10779
{	// Methods

	// RVA: 0x8FEC70 Offset: 0x8FD270 VA: 0x1808FEC70
	public void .ctor() { }

}

