private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 3234
{	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__1; // 0x0
	private int[] <map>5__2; // 0x0
	private int <i>5__3; // 0x0

	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FF30 Offset: 0x164E530 VA: 0x18164FF30
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<double>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A7A0 Offset: 0x1768DA0 VA: 0x18176A7A0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.MoveNext
	|
	|-RVA: 0x176B040 Offset: 0x1769640 VA: 0x18176B040
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.MoveNext
	|
	|-RVA: 0x176AAD0 Offset: 0x17690D0 VA: 0x18176AAD0
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.MoveNext
	|
	|-RVA: 0x176AEB0 Offset: 0x17694B0 VA: 0x18176AEB0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176A940 Offset: 0x1768F40 VA: 0x18176A940
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x176A490 Offset: 0x1768A90 VA: 0x18176A490
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x176A310 Offset: 0x1768910 VA: 0x18176A310
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.MoveNext
	|
	|-RVA: 0x176A620 Offset: 0x1768C20 VA: 0x18176A620
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x176AD20 Offset: 0x1769320 VA: 0x18176AD20
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B310 Offset: 0x1769910 VA: 0x18176B310
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xDECE60 Offset: 0xDEB460 VA: 0x180DECE60
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B280 Offset: 0x1769880 VA: 0x18176B280
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB11B00 Offset: 0xB10100 VA: 0x180B11B00
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB3C170 Offset: 0xB3A770 VA: 0x180B3C170
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B260 Offset: 0x1769860 VA: 0x18176B260
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B560 Offset: 0x1769B60 VA: 0x18176B560
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B420 Offset: 0x1769A20 VA: 0x18176B420
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B3D0 Offset: 0x17699D0 VA: 0x18176B3D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B330 Offset: 0x1769930 VA: 0x18176B330
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B5B0 Offset: 0x1769BB0 VA: 0x18176B5B0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B380 Offset: 0x1769980 VA: 0x18176B380
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B470 Offset: 0x1769A70 VA: 0x18176B470
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B4C0 Offset: 0x1769AC0 VA: 0x18176B4C0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B510 Offset: 0x1769B10 VA: 0x18176B510
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B800 Offset: 0x1769E00 VA: 0x18176B800
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B770 Offset: 0x1769D70 VA: 0x18176B770
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B650 Offset: 0x1769C50 VA: 0x18176B650
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B600 Offset: 0x1769C00 VA: 0x18176B600
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B720 Offset: 0x1769D20 VA: 0x18176B720
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B850 Offset: 0x1769E50 VA: 0x18176B850
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

