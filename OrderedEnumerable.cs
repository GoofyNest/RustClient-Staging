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
	|-RVA: 0x1650030 Offset: 0x164E630 VA: 0x181650030
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
	|-RVA: 0x176A8A0 Offset: 0x1768EA0 VA: 0x18176A8A0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.MoveNext
	|
	|-RVA: 0x176B140 Offset: 0x1769740 VA: 0x18176B140
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.MoveNext
	|
	|-RVA: 0x176ABD0 Offset: 0x17691D0 VA: 0x18176ABD0
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.MoveNext
	|
	|-RVA: 0x176AFB0 Offset: 0x17695B0 VA: 0x18176AFB0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176AA40 Offset: 0x1769040 VA: 0x18176AA40
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x176A590 Offset: 0x1768B90 VA: 0x18176A590
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x176A410 Offset: 0x1768A10 VA: 0x18176A410
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.MoveNext
	|
	|-RVA: 0x176A720 Offset: 0x1768D20 VA: 0x18176A720
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x176AE20 Offset: 0x1769420 VA: 0x18176AE20
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B410 Offset: 0x1769A10 VA: 0x18176B410
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xDECF60 Offset: 0xDEB560 VA: 0x180DECF60
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B380 Offset: 0x1769980 VA: 0x18176B380
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
	|-RVA: 0x176B360 Offset: 0x1769960 VA: 0x18176B360
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B660 Offset: 0x1769C60 VA: 0x18176B660
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B520 Offset: 0x1769B20 VA: 0x18176B520
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B4D0 Offset: 0x1769AD0 VA: 0x18176B4D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B430 Offset: 0x1769A30 VA: 0x18176B430
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B6B0 Offset: 0x1769CB0 VA: 0x18176B6B0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B480 Offset: 0x1769A80 VA: 0x18176B480
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B570 Offset: 0x1769B70 VA: 0x18176B570
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B5C0 Offset: 0x1769BC0 VA: 0x18176B5C0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B610 Offset: 0x1769C10 VA: 0x18176B610
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B900 Offset: 0x1769F00 VA: 0x18176B900
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B870 Offset: 0x1769E70 VA: 0x18176B870
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B750 Offset: 0x1769D50 VA: 0x18176B750
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B700 Offset: 0x1769D00 VA: 0x18176B700
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B820 Offset: 0x1769E20 VA: 0x18176B820
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B950 Offset: 0x1769F50 VA: 0x18176B950
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

