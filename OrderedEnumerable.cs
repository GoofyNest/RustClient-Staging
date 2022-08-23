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
	|-RVA: 0x164FFF0 Offset: 0x164E5F0 VA: 0x18164FFF0
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
	|-RVA: 0x176A860 Offset: 0x1768E60 VA: 0x18176A860
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.MoveNext
	|
	|-RVA: 0x176B100 Offset: 0x1769700 VA: 0x18176B100
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.MoveNext
	|
	|-RVA: 0x176AB90 Offset: 0x1769190 VA: 0x18176AB90
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.MoveNext
	|
	|-RVA: 0x176AF70 Offset: 0x1769570 VA: 0x18176AF70
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x176AA00 Offset: 0x1769000 VA: 0x18176AA00
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x176A550 Offset: 0x1768B50 VA: 0x18176A550
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x176A3D0 Offset: 0x17689D0 VA: 0x18176A3D0
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.MoveNext
	|
	|-RVA: 0x176A6E0 Offset: 0x1768CE0 VA: 0x18176A6E0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x176ADE0 Offset: 0x17693E0 VA: 0x18176ADE0
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B3D0 Offset: 0x17699D0 VA: 0x18176B3D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xDECF20 Offset: 0xDEB520 VA: 0x180DECF20
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B340 Offset: 0x1769940 VA: 0x18176B340
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB11AC0 Offset: 0xB100C0 VA: 0x180B11AC0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0xB3C130 Offset: 0xB3A730 VA: 0x180B3C130
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B320 Offset: 0x1769920 VA: 0x18176B320
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B620 Offset: 0x1769C20 VA: 0x18176B620
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B4E0 Offset: 0x1769AE0 VA: 0x18176B4E0
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B490 Offset: 0x1769A90 VA: 0x18176B490
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B3F0 Offset: 0x17699F0 VA: 0x18176B3F0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B670 Offset: 0x1769C70 VA: 0x18176B670
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B440 Offset: 0x1769A40 VA: 0x18176B440
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B530 Offset: 0x1769B30 VA: 0x18176B530
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B580 Offset: 0x1769B80 VA: 0x18176B580
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176B5D0 Offset: 0x1769BD0 VA: 0x18176B5D0
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B8C0 Offset: 0x1769EC0 VA: 0x18176B8C0
	|-OrderedEnumerable.<GetEnumerator>d__1<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B830 Offset: 0x1769E30 VA: 0x18176B830
	|-OrderedEnumerable.<GetEnumerator>d__1<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B710 Offset: 0x1769D10 VA: 0x18176B710
	|-OrderedEnumerable.<GetEnumerator>d__1<Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B6C0 Offset: 0x1769CC0 VA: 0x18176B6C0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B7E0 Offset: 0x1769DE0 VA: 0x18176B7E0
	|-OrderedEnumerable.<GetEnumerator>d__1<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176B910 Offset: 0x1769F10 VA: 0x18176B910
	|-OrderedEnumerable.<GetEnumerator>d__1<Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

