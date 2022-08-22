public static class Parallel // TypeDefIndex: 5599
{	public static int MaxThreads; // 0x3193


	public static void ForEach<T>(IList<T> data, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E40 Offset: 0x5D1440 VA: 0x1805D2E40
	|-Parallel.ForEach<object>
	*/

	public static void ForEach<T>(IList<T> data, int threads, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2ED0 Offset: 0x5D14D0 VA: 0x1805D2ED0
	|-Parallel.ForEach<object>
	*/

	public static void For(int fromInclusive, int toExclusive, Action<int> action) { }

	public static void For(int fromInclusive, int toExclusive, int threads, Action<int> action) { }

	public static void Call(Action<int, int> action) { }

	public static void Call(int threads, Action<int, int> action) { }

	[IteratorStateMachineAttribute] // RVA: 0xB68F0 Offset: 0xB5CF0 VA: 0x1800B68F0
	public static IEnumerator Coroutine(Action action) { }

	private static void .cctor() { }

}

private sealed class Parallel.<>c__DisplayClass2_0<T> // TypeDefIndex: 5600
{	public Action<T> action; // 0x0
	public IList<T> data; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-Parallel.<>c__DisplayClass2_0<object>..ctor
	*/

	internal void <ForEach>b__0(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B49C0 Offset: 0x19B2FC0 VA: 0x1819B49C0
	|-Parallel.<>c__DisplayClass2_0<object>.<ForEach>b__0
	*/

}

private sealed class Parallel.<>c__DisplayClass4_0 // TypeDefIndex: 5601
{	public int chunk_size; // 0x10
	public int toExclusive; // 0x14
	public Action<int> action; // 0x18


	public void .ctor() { }

	internal void <For>b__0(int thread_id) { }

}

private sealed class Parallel.<>c__DisplayClass6_0 // TypeDefIndex: 5602
{	public Action<int, int> action; // 0x10
	public int threads; // 0x18


	public void .ctor() { }

	internal void <Call>b__0(int thread_id) { }

}

private sealed class Parallel.<Coroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5603
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action action; // 0x20
	private IAsyncResult <asyncResult>5__2; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

