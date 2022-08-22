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
	|-RVA: 0x15E9140 Offset: 0x15E7740 VA: 0x1815E9140
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
	|-RVA: 0x176CC10 Offset: 0x176B210 VA: 0x18176CC10
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.MoveNext
	|
	|-RVA: 0x176D4B0 Offset: 0x176BAB0 VA: 0x18176D4B0
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.MoveNext
	|
	|-RVA: 0x176CF40 Offset: 0x176B540 VA: 0x18176CF40
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.MoveNext
	|
	|-RVA: 0x176D320 Offset: 0x176B920 VA: 0x18176D320
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176CDB0 Offset: 0x176B3B0 VA: 0x18176CDB0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x176C900 Offset: 0x176AF00 VA: 0x18176C900
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x176C780 Offset: 0x176AD80 VA: 0x18176C780
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.MoveNext
	|
	|-RVA: 0x176CA90 Offset: 0x176B090 VA: 0x18176CA90
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x176D190 Offset: 0x176B790 VA: 0x18176D190
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176D780 Offset: 0x176BD80 VA: 0x18176D780
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xDEC370 Offset: 0xDEA970 VA: 0x180DEC370
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176D6F0 Offset: 0x176BCF0 VA: 0x18176D6F0
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB114F0 Offset: 0xB0FAF0 VA: 0x180B114F0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB3BB60 Offset: 0xB3A160 VA: 0x180B3BB60
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176D6D0 Offset: 0x176BCD0 VA: 0x18176D6D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176D9D0 Offset: 0x176BFD0 VA: 0x18176D9D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D890 Offset: 0x176BE90 VA: 0x18176D890
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D840 Offset: 0x176BE40 VA: 0x18176D840
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D7A0 Offset: 0x176BDA0 VA: 0x18176D7A0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176DA20 Offset: 0x176C020 VA: 0x18176DA20
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D7F0 Offset: 0x176BDF0 VA: 0x18176D7F0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D8E0 Offset: 0x176BEE0 VA: 0x18176D8E0
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D930 Offset: 0x176BF30 VA: 0x18176D930
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176D980 Offset: 0x176BF80 VA: 0x18176D980
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DC70 Offset: 0x176C270 VA: 0x18176DC70
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176DBE0 Offset: 0x176C1E0 VA: 0x18176DBE0
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176DAC0 Offset: 0x176C0C0 VA: 0x18176DAC0
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176DA70 Offset: 0x176C070 VA: 0x18176DA70
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176DB90 Offset: 0x176C190 VA: 0x18176DB90
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176DCC0 Offset: 0x176C2C0 VA: 0x18176DCC0
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

