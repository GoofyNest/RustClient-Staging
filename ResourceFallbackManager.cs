internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable // TypeDefIndex: 489
{	// Fields
	private CultureInfo m_startingCulture; // 0x10
	private CultureInfo m_neutralResourcesCulture; // 0x18
	private bool m_useParents; // 0x20

	// Methods

	// RVA: 0xFED2C0 Offset: 0xFEB8C0 VA: 0x180FED2C0
	internal void .ctor(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	// RVA: 0xFED250 Offset: 0xFEB850 VA: 0x180FED250 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x95ED0 Offset: 0x952D0 VA: 0x180095ED0
	// RVA: 0xFED250 Offset: 0xFEB850 VA: 0x180FED250 Slot: 4
	public IEnumerator<CultureInfo> GetEnumerator() { }

}

private sealed class ResourceFallbackManager.<GetEnumerator>d__5 : IEnumerator<CultureInfo>, IDisposable, IEnumerator // TypeDefIndex: 490
{	// Fields
	private int <>1__state; // 0x10
	private CultureInfo <>2__current; // 0x18
	public ResourceFallbackManager <>4__this; // 0x20
	private CultureInfo <currentCulture>5__1; // 0x28
	private bool <reachedNeutralResourcesCulture>5__2; // 0x30

	// Properties
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFF7570 Offset: 0xFF5B70 VA: 0x180FF7570 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFF77B0 Offset: 0xFF5DB0 VA: 0x180FF77B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

