private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 3234
{	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__1; // 0x0
	private int[] <map>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FEF0 Offset: 0x164E4F0 VA: 0x18164FEF0
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
	// RVA: -1 Offset: -1 Slot: 5
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

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A760 Offset: 0x1768D60 VA: 0x18176A760
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.MoveNext
	|
	|-RVA: 0x176B000 Offset: 0x1769600 VA: 0x18176B000
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.MoveNext
	|
	|-RVA: 0x176AA90 Offset: 0x1769090 VA: 0x18176AA90
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.MoveNext
	|
	|-RVA: 0x176AE70 Offset: 0x1769470 VA: 0x18176AE70
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176A900 Offset: 0x1768F00 VA: 0x18176A900
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x176A450 Offset: 0x1768A50 VA: 0x18176A450
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x176A2D0 Offset: 0x17688D0 VA: 0x18176A2D0
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.MoveNext
	|
	|-RVA: 0x176A5E0 Offset: 0x1768BE0 VA: 0x18176A5E0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x176ACE0 Offset: 0x17692E0 VA: 0x18176ACE0
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B2D0 Offset: 0x17698D0 VA: 0x18176B2D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xDECE20 Offset: 0xDEB420 VA: 0x180DECE20
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B240 Offset: 0x1769840 VA: 0x18176B240
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB3C030 Offset: 0xB3A630 VA: 0x180B3C030
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B220 Offset: 0x1769820 VA: 0x18176B220
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B520 Offset: 0x1769B20 VA: 0x18176B520
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B3E0 Offset: 0x17699E0 VA: 0x18176B3E0
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B390 Offset: 0x1769990 VA: 0x18176B390
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B2F0 Offset: 0x17698F0 VA: 0x18176B2F0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B570 Offset: 0x1769B70 VA: 0x18176B570
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B340 Offset: 0x1769940 VA: 0x18176B340
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B430 Offset: 0x1769A30 VA: 0x18176B430
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B480 Offset: 0x1769A80 VA: 0x18176B480
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B4D0 Offset: 0x1769AD0 VA: 0x18176B4D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B7C0 Offset: 0x1769DC0 VA: 0x18176B7C0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B730 Offset: 0x1769D30 VA: 0x18176B730
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B610 Offset: 0x1769C10 VA: 0x18176B610
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B5C0 Offset: 0x1769BC0 VA: 0x18176B5C0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B6E0 Offset: 0x1769CE0 VA: 0x18176B6E0
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B810 Offset: 0x1769E10 VA: 0x18176B810
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

