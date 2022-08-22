public struct BufferList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4795
{	private readonly BufferList<T> list; // 0x0
	private int index; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	public void .ctor(BufferList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x214250 Offset: 0x213650 VA: 0x180214250
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

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F6210 Offset: 0x1F5610 VA: 0x1801F6210
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

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F62C0 Offset: 0x1F56C0 VA: 0x1801F62C0
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

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F64D0 Offset: 0x1F58D0 VA: 0x1801F64D0
	|-BufferList.Enumerator<BasePlayer>.get_Current
	|-BufferList.Enumerator<Collider>.get_Current
	|-BufferList.Enumerator<FoliageKey>.get_Current
	|-BufferList.Enumerator<object>.get_Current
	|-BufferList.Enumerator<float>.get_Current
	|-BufferList.Enumerator<uint>.get_Current
	|-BufferList.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x1F64B0 Offset: 0x1F58B0 VA: 0x1801F64B0
	|-BufferList.Enumerator<InstancingKey>.get_Current
	|-BufferList.Enumerator<InvokeAction>.get_Current
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	|
	|-RVA: 0x214280 Offset: 0x213680 VA: 0x180214280
	|-BufferList.Enumerator<RendererKey>.get_Current
	|
	|-RVA: 0x2142C0 Offset: 0x2136C0 VA: 0x1802142C0
	|-BufferList.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x2142A0 Offset: 0x2136A0 VA: 0x1802142A0
	|-BufferList.Enumerator<ViewModelDrawEvent>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x213E00 Offset: 0x213200 VA: 0x180213E00
	|-BufferList.Enumerator<FoliageKey>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F63C0 Offset: 0x1F57C0 VA: 0x1801F63C0
	|-BufferList.Enumerator<InstancingKey>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-BufferList.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x213FE0 Offset: 0x2133E0 VA: 0x180213FE0
	|-BufferList.Enumerator<RendererKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F6380 Offset: 0x1F5780 VA: 0x1801F6380
	|-BufferList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2140F0 Offset: 0x2134F0 VA: 0x1802140F0
	|-BufferList.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x213EA0 Offset: 0x2132A0 VA: 0x180213EA0
	|-BufferList.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x214190 Offset: 0x213590 VA: 0x180214190
	|-BufferList.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x213F30 Offset: 0x213330 VA: 0x180213F30
	|-BufferList.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	*/

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

