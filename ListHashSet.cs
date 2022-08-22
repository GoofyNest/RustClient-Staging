public struct ListHashSet.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4809
{	// Fields
	private readonly BufferList<T> list; // 0x0
	private int index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ListHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x211070 Offset: 0x210470 VA: 0x180211070
	|-ListHashSet.Enumerator<InvokeAction>..ctor
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>..ctor
	|-ListHashSet.Enumerator<object>..ctor
	|-ListHashSet.Enumerator<ViewModelDrawEvent>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210FB0 Offset: 0x2103B0 VA: 0x180210FB0
	|-ListHashSet.Enumerator<DecayEntity>.MoveNext
	|-ListHashSet.Enumerator<Gib>.MoveNext
	|-ListHashSet.Enumerator<NeedsKeyboard>.MoveNext
	|-ListHashSet.Enumerator<Group>.MoveNext
	|-ListHashSet.Enumerator<PlayerModel>.MoveNext
	|-ListHashSet.Enumerator<PositionLerp>.MoveNext
	|-ListHashSet.Enumerator<ScrollRectDisable>.MoveNext
	|-ListHashSet.Enumerator<object>.MoveNext
	|-ListHashSet.Enumerator<UIBlueprints>.MoveNext
	|-ListHashSet.Enumerator<UIChat>.MoveNext
	|-ListHashSet.Enumerator<UIEscapeCapture>.MoveNext
	|-ListHashSet.Enumerator<UI_LocalVoice>.MoveNext
	|
	|-RVA: 0x1F4F10 Offset: 0x1F4310 VA: 0x1801F4F10
	|-ListHashSet.Enumerator<InvokeAction>.MoveNext
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNext
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F4FB0 Offset: 0x1F43B0 VA: 0x1801F4FB0
	|-ListHashSet.Enumerator<InvokeAction>.Reset
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.Reset
	|-ListHashSet.Enumerator<object>.Reset
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F5530 Offset: 0x1F4930 VA: 0x1801F5530
	|-ListHashSet.Enumerator<DecayEntity>.get_Current
	|-ListHashSet.Enumerator<Gib>.get_Current
	|-ListHashSet.Enumerator<NeedsKeyboard>.get_Current
	|-ListHashSet.Enumerator<Group>.get_Current
	|-ListHashSet.Enumerator<PlayerModel>.get_Current
	|-ListHashSet.Enumerator<PositionLerp>.get_Current
	|-ListHashSet.Enumerator<ScrollRectDisable>.get_Current
	|-ListHashSet.Enumerator<UIBlueprints>.get_Current
	|-ListHashSet.Enumerator<UIChat>.get_Current
	|-ListHashSet.Enumerator<UIEscapeCapture>.get_Current
	|-ListHashSet.Enumerator<UI_LocalVoice>.get_Current
	|-ListHashSet.Enumerator<object>.get_Current
	|
	|-RVA: 0x2110B0 Offset: 0x2104B0 VA: 0x1802110B0
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.get_Current
	|
	|-RVA: 0x1F5540 Offset: 0x1F4940 VA: 0x1801F5540
	|-ListHashSet.Enumerator<InvokeAction>.get_Current
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F5060 Offset: 0x1F4460 VA: 0x1801F5060
	|-ListHashSet.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1F5360 Offset: 0x1F4760 VA: 0x1801F5360
	|-ListHashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x210FC0 Offset: 0x2103C0 VA: 0x180210FC0
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-ListHashSet.Enumerator<DecayEntity>.Dispose
	|-ListHashSet.Enumerator<Gib>.Dispose
	|-ListHashSet.Enumerator<InvokeAction>.Dispose
	|-ListHashSet.Enumerator<NeedsKeyboard>.Dispose
	|-ListHashSet.Enumerator<Group>.Dispose
	|-ListHashSet.Enumerator<PlayerModel>.Dispose
	|-ListHashSet.Enumerator<PositionLerp>.Dispose
	|-ListHashSet.Enumerator<ScrollRectDisable>.Dispose
	|-ListHashSet.Enumerator<SpecialPurposeCamera.RenderEntry>.Dispose
	|-ListHashSet.Enumerator<object>.Dispose
	|-ListHashSet.Enumerator<UIBlueprints>.Dispose
	|-ListHashSet.Enumerator<UIChat>.Dispose
	|-ListHashSet.Enumerator<UIEscapeCapture>.Dispose
	|-ListHashSet.Enumerator<UI_LocalVoice>.Dispose
	|-ListHashSet.Enumerator<ViewModelDrawEvent>.Dispose
	*/

}

