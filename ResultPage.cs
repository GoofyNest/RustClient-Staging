public struct ResultPage : IDisposable // TypeDefIndex: 5281
{	// Fields
	internal UGCQueryHandle_t Handle; // 0x0
	public int ResultCount; // 0x8
	public int TotalCount; // 0xC
	public bool CachedData; // 0x10
	internal bool ReturnsKeyValueTags; // 0x11
	internal bool ReturnsDefaultStats; // 0x12
	internal bool ReturnsMetadata; // 0x13
	internal bool ReturnsChildren; // 0x14
	internal bool ReturnsAdditionalPreviews; // 0x15

	// Properties
	public IEnumerable<Item> Entries { get; }

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x9F810 Offset: 0x9EC10 VA: 0x18009F810
	// RVA: 0x224B30 Offset: 0x223F30 VA: 0x180224B30
	public IEnumerable<Item> get_Entries() { }

	// RVA: 0x224B20 Offset: 0x223F20 VA: 0x180224B20
	private ulong GetStat(uint index, ItemStatistic stat) { }

	// RVA: 0x224AD0 Offset: 0x223ED0 VA: 0x180224AD0 Slot: 4
	public void Dispose() { }

}

private sealed class ResultPage.<get_Entries>d__10 : IEnumerable<Item>, IEnumerable, IEnumerator<Item>, IEnumerator, IDisposable // TypeDefIndex: 5282
{	// Fields
	private int <>1__state; // 0x10
	private Item <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x150
	public ResultPage <>4__this; // 0x158
	public ResultPage <>3__<>4__this; // 0x170
	private SteamUGCDetails_t <details>5__2; // 0x188
	private uint <i>5__3; // 0x210

	// Properties
	private Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0E70 Offset: 0x19DF470 VA: 0x1819E0E70
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19E04D0 Offset: 0x19DEAD0 VA: 0x1819E04D0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x176D430 Offset: 0x176BA30 VA: 0x18176D430 Slot: 6
	private Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0D50 Offset: 0x19DF350 VA: 0x1819E0D50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0DA0 Offset: 0x19DF3A0 VA: 0x1819E0DA0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0CA0 Offset: 0x19DF2A0 VA: 0x1819E0CA0 Slot: 4
	private IEnumerator<Item> System.Collections.Generic.IEnumerable<Steamworks.Ugc.Item>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0CA0 Offset: 0x19DF2A0 VA: 0x1819E0CA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

