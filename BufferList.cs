public struct BufferList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4795
{	// Fields
	private readonly BufferList<T> list; // 0x0
	private int index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F5500 Offset: 0x1F4900 VA: 0x1801F5500
	|-BufferList.Enumerator<FoliageKey>..ctor
	|-BufferList.Enumerator<InstancingKey>..ctor
	|-BufferList.Enumerator<InvokeAction>..ctor
	|-BufferList.Enumerator<RendererKey>..ctor
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>..ctor
	|-BufferList.Enumerator<object>..ctor
	|-BufferList.Enumerator<float>..ctor
	|-BufferList.Enumerator<uint>..ctor
	|-BufferList.Enumerator<ulong>..ctor
	|-BufferList.Enumerator<Matrix4x4>..ctor
	|-BufferList.Enumerator<ViewModelDrawEvent>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4F10 Offset: 0x1F4310 VA: 0x1801F4F10
	|-BufferList.Enumerator<BasePlayer>.MoveNext
	|-BufferList.Enumerator<FoliageKey>.MoveNext
	|-BufferList.Enumerator<InstancingKey>.MoveNext
	|-BufferList.Enumerator<InvokeAction>.MoveNext
	|-BufferList.Enumerator<RendererKey>.MoveNext
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNext
	|-BufferList.Enumerator<object>.MoveNext
	|-BufferList.Enumerator<float>.MoveNext
	|-BufferList.Enumerator<uint>.MoveNext
	|-BufferList.Enumerator<ulong>.MoveNext
	|-BufferList.Enumerator<Collider>.MoveNext
	|-BufferList.Enumerator<Matrix4x4>.MoveNext
	|-BufferList.Enumerator<ViewModelDrawEvent>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4FB0 Offset: 0x1F43B0 VA: 0x1801F4FB0
	|-BufferList.Enumerator<FoliageKey>.Reset
	|-BufferList.Enumerator<InstancingKey>.Reset
	|-BufferList.Enumerator<InvokeAction>.Reset
	|-BufferList.Enumerator<RendererKey>.Reset
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.Reset
	|-BufferList.Enumerator<object>.Reset
	|-BufferList.Enumerator<float>.Reset
	|-BufferList.Enumerator<uint>.Reset
	|-BufferList.Enumerator<ulong>.Reset
	|-BufferList.Enumerator<Matrix4x4>.Reset
	|-BufferList.Enumerator<ViewModelDrawEvent>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F5530 Offset: 0x1F4930 VA: 0x1801F5530
	|-BufferList.Enumerator<BasePlayer>.get_Current
	|-BufferList.Enumerator<Collider>.get_Current
	|-BufferList.Enumerator<FoliageKey>.get_Current
	|-BufferList.Enumerator<object>.get_Current
	|-BufferList.Enumerator<float>.get_Current
	|-BufferList.Enumerator<uint>.get_Current
	|-BufferList.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x1F5540 Offset: 0x1F4940 VA: 0x1801F5540
	|-BufferList.Enumerator<InstancingKey>.get_Current
	|-BufferList.Enumerator<InvokeAction>.get_Current
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	|
	|-RVA: 0x1F5560 Offset: 0x1F4960 VA: 0x1801F5560
	|-BufferList.Enumerator<RendererKey>.get_Current
	|
	|-RVA: 0x1F55A0 Offset: 0x1F49A0 VA: 0x1801F55A0
	|-BufferList.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x1F5580 Offset: 0x1F4980 VA: 0x1801F5580
	|-BufferList.Enumerator<ViewModelDrawEvent>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4FC0 Offset: 0x1F43C0 VA: 0x1801F4FC0
	|-BufferList.Enumerator<FoliageKey>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5060 Offset: 0x1F4460 VA: 0x1801F5060
	|-BufferList.Enumerator<InstancingKey>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5250 Offset: 0x1F4650 VA: 0x1801F5250
	|-BufferList.Enumerator<RendererKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5360 Offset: 0x1F4760 VA: 0x1801F5360
	|-BufferList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F53A0 Offset: 0x1F47A0 VA: 0x1801F53A0
	|-BufferList.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5110 Offset: 0x1F4510 VA: 0x1801F5110
	|-BufferList.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5440 Offset: 0x1F4840 VA: 0x1801F5440
	|-BufferList.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F51A0 Offset: 0x1F45A0 VA: 0x1801F51A0
	|-BufferList.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-BufferList.Enumerator<BasePlayer>.Dispose
	|-BufferList.Enumerator<FoliageKey>.Dispose
	|-BufferList.Enumerator<InstancingKey>.Dispose
	|-BufferList.Enumerator<InvokeAction>.Dispose
	|-BufferList.Enumerator<RendererKey>.Dispose
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.Dispose
	|-BufferList.Enumerator<object>.Dispose
	|-BufferList.Enumerator<float>.Dispose
	|-BufferList.Enumerator<uint>.Dispose
	|-BufferList.Enumerator<ulong>.Dispose
	|-BufferList.Enumerator<Collider>.Dispose
	|-BufferList.Enumerator<Matrix4x4>.Dispose
	|-BufferList.Enumerator<ViewModelDrawEvent>.Dispose
	*/

}

