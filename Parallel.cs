public static class Parallel // TypeDefIndex: 5599
{	// Fields
	public static int MaxThreads; // 0x2B11318

	// Methods

	// RVA: -1 Offset: -1
	public static void ForEach<T>(IList<T> data, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2EB0 Offset: 0x5D14B0 VA: 0x1805D2EB0
	|-Parallel.ForEach<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEach<T>(IList<T> data, int threads, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2F40 Offset: 0x5D1540 VA: 0x1805D2F40
	|-Parallel.ForEach<object>
	*/

	// RVA: 0x21BCEC0 Offset: 0x21BB4C0 VA: 0x1821BCEC0
	public static void For(int fromInclusive, int toExclusive, Action<int> action) { }

	// RVA: 0x21BCC70 Offset: 0x21BB270 VA: 0x1821BCC70
	public static void For(int fromInclusive, int toExclusive, int threads, Action<int> action) { }

	// RVA: 0x21BCB90 Offset: 0x21BB190 VA: 0x1821BCB90
	public static void Call(Action<int, int> action) { }

	// RVA: 0x21BC960 Offset: 0x21BAF60 VA: 0x1821BC960
	public static void Call(int threads, Action<int, int> action) { }

	[IteratorStateMachineAttribute] // RVA: 0xB6850 Offset: 0xB5C50 VA: 0x1800B6850
	// RVA: 0x21BCC00 Offset: 0x21BB200 VA: 0x1821BCC00
	public static IEnumerator Coroutine(Action action) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class Parallel.<>c__DisplayClass2_0<T> // TypeDefIndex: 5600
{	// Fields
	public Action<T> action; // 0x0
	public IList<T> data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-Parallel.<>c__DisplayClass2_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ForEach>b__0(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C7340 Offset: 0x19C5940 VA: 0x1819C7340
	|-Parallel.<>c__DisplayClass2_0<object>.<ForEach>b__0
	*/

}

private sealed class Parallel.<>c__DisplayClass4_0 // TypeDefIndex: 5601
{	// Fields
	public int chunk_size; // 0x10
	public int toExclusive; // 0x14
	public Action<int> action; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21BE0F0 Offset: 0x21BC6F0 VA: 0x1821BE0F0
	internal void <For>b__0(int thread_id) { }

}

private sealed class Parallel.<>c__DisplayClass6_0 // TypeDefIndex: 5602
{	// Fields
	public Action<int, int> action; // 0x10
	public int threads; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21BE1A0 Offset: 0x21BC7A0 VA: 0x1821BE1A0
	internal void <Call>b__0(int thread_id) { }

}

private sealed class Parallel.<Coroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5603
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action action; // 0x20
	private IAsyncResult <asyncResult>5__2; // 0x28

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

	// RVA: 0x21BDF50 Offset: 0x21BC550 VA: 0x1821BDF50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21BE0A0 Offset: 0x21BC6A0 VA: 0x1821BE0A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}
