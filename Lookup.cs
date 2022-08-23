internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 3227
{	internal TKey key; // 0x0
	internal int hashCode; // 0x0
	internal TElement[] elements; // 0x0
	internal int count; // 0x0
	internal Lookup.Grouping<TKey, TElement> hashNext; // 0x0
	internal Lookup.Grouping<TKey, TElement> next; // 0x0

	public TKey Key { get; }
	private int System.Collections.Generic.ICollection<TElement>.Count { get; }
	private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }


	internal void Add(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175F460 Offset: 0x175DA60 VA: 0x18175F460
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.Add
	|
	|-RVA: 0x175F560 Offset: 0x175DB60 VA: 0x18175F560
	|-Lookup.Grouping<InventoryDefId, object>.Add
	|
	|-RVA: 0x175F8F0 Offset: 0x175DEF0 VA: 0x18175F8F0
	|-Lookup.Grouping<Int32Enum, object>.Add
	|
	|-RVA: 0x175F640 Offset: 0x175DC40 VA: 0x18175F640
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x175F810 Offset: 0x175DE10 VA: 0x18175F810
	|-Lookup.Grouping<uint, object>.Add
	|
	|-RVA: 0x175F720 Offset: 0x175DD20 VA: 0x18175F720
	|-Lookup.Grouping<Vector2Int, Resolution>.Add
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD1130 Offset: 0xD0530 VA: 0x1800D1130
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FA60 Offset: 0x175E060 VA: 0x18175FA60
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.GetEnumerator
	|
	|-RVA: 0x175F9D0 Offset: 0x175DFD0 VA: 0x18175F9D0
	|-Lookup.Grouping<InventoryDefId, object>.GetEnumerator
	|-Lookup.Grouping<Int32Enum, object>.GetEnumerator
	|-Lookup.Grouping<object, object>.GetEnumerator
	|-Lookup.Grouping<uint, object>.GetEnumerator
	|-Lookup.Grouping<Vector2Int, Resolution>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650A10 Offset: 0x164F010 VA: 0x181650A10
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.get_Key
	|-Lookup.Grouping<InventoryDefId, object>.get_Key
	|-Lookup.Grouping<Int32Enum, object>.get_Key
	|-Lookup.Grouping<uint, object>.get_Key
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	|-Lookup.Grouping<object, object>.get_Key
	|-Lookup.Grouping<Vector2Int, Resolution>.get_Key
	*/

	private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.get_Count
	*/

	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D7D00 Offset: 0x4D6300 VA: 0x1804D7D00
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	*/

	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FAF0 Offset: 0x175E0F0 VA: 0x18175FAF0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FBB0 Offset: 0x175E1B0 VA: 0x18175FBB0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FC30 Offset: 0x175E230 VA: 0x18175FC30
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FB70 Offset: 0x175E170 VA: 0x18175FB70
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FBF0 Offset: 0x175E1F0 VA: 0x18175FBF0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FB30 Offset: 0x175E130 VA: 0x18175FB30
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FD30 Offset: 0x175E330 VA: 0x18175FD30
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FC70 Offset: 0x175E270 VA: 0x18175FC70
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FCF0 Offset: 0x175E2F0 VA: 0x18175FCF0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FD70 Offset: 0x175E370 VA: 0x18175FD70
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FCB0 Offset: 0x175E2B0 VA: 0x18175FCB0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FDB0 Offset: 0x175E3B0 VA: 0x18175FDB0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FEA0 Offset: 0x175E4A0 VA: 0x18175FEA0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FDF0 Offset: 0x175E3F0 VA: 0x18175FDF0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FE70 Offset: 0x175E470 VA: 0x18175FE70
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FE20 Offset: 0x175E420 VA: 0x18175FE20
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FEF0 Offset: 0x175E4F0 VA: 0x18175FEF0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x175FF20 Offset: 0x175E520 VA: 0x18175FF20
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760090 Offset: 0x175E690 VA: 0x181760090
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1760050 Offset: 0x175E650 VA: 0x181760050
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1760010 Offset: 0x175E610 VA: 0x181760010
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FF90 Offset: 0x175E590 VA: 0x18175FF90
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FFD0 Offset: 0x175E5D0 VA: 0x18175FFD0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FF50 Offset: 0x175E550 VA: 0x18175FF50
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17600D0 Offset: 0x175E6D0 VA: 0x1817600D0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760110 Offset: 0x175E710 VA: 0x181760110
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760180 Offset: 0x175E780 VA: 0x181760180
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760140 Offset: 0x175E740 VA: 0x181760140
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17601F0 Offset: 0x175E7F0 VA: 0x1817601F0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760230 Offset: 0x175E830 VA: 0x181760230
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17602B0 Offset: 0x175E8B0 VA: 0x1817602B0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17602F0 Offset: 0x175E8F0 VA: 0x1817602F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17601B0 Offset: 0x175E7B0 VA: 0x1817601B0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760270 Offset: 0x175E870 VA: 0x181760270
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.Insert
	*/

	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760470 Offset: 0x175EA70 VA: 0x181760470
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17603B0 Offset: 0x175E9B0 VA: 0x1817603B0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17603F0 Offset: 0x175E9F0 VA: 0x1817603F0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760430 Offset: 0x175EA30 VA: 0x181760430
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760370 Offset: 0x175E970 VA: 0x181760370
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760330 Offset: 0x175E930 VA: 0x181760330
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760680 Offset: 0x175EC80 VA: 0x181760680
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17607C0 Offset: 0x175EDC0 VA: 0x1817607C0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760540 Offset: 0x175EB40 VA: 0x181760540
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760730 Offset: 0x175ED30 VA: 0x181760730
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17604B0 Offset: 0x175EAB0 VA: 0x1817604B0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17605D0 Offset: 0x175EBD0 VA: 0x1817605D0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760890 Offset: 0x175EE90 VA: 0x181760890
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x17608D0 Offset: 0x175EED0 VA: 0x1817608D0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760850 Offset: 0x175EE50 VA: 0x181760850
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760950 Offset: 0x175EF50 VA: 0x181760950
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760990 Offset: 0x175EF90 VA: 0x181760990
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760910 Offset: 0x175EF10 VA: 0x181760910
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BC10 Offset: 0xD5A210 VA: 0x180D5BC10
	|-Lookup.Grouping<InventoryDefId, InventoryItem>..ctor
	|-Lookup.Grouping<InventoryDefId, object>..ctor
	|-Lookup.Grouping<Int32Enum, object>..ctor
	|-Lookup.Grouping<object, object>..ctor
	|-Lookup.Grouping<uint, object>..ctor
	|-Lookup.Grouping<Vector2Int, Resolution>..ctor
	*/

}

private sealed class Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 3228
{	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public Lookup.Grouping<TKey, TElement> <>4__this; // 0x0
	private int <i>5__1; // 0x0

	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650030 Offset: 0x164E630 VA: 0x181650030
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.IDisposable.Dispose
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B9A0 Offset: 0x1769FA0 VA: 0x18176B9A0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x176BAD0 Offset: 0x176A0D0 VA: 0x18176BAD0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.MoveNext
	|
	|-RVA: 0x176BB60 Offset: 0x176A160 VA: 0x18176BB60
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
	|
	|-RVA: 0x176BA40 Offset: 0x176A040 VA: 0x18176BA40
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B410 Offset: 0x1769A10 VA: 0x18176B410
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B360 Offset: 0x1769960 VA: 0x18176B360
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176BCE0 Offset: 0x176A2E0 VA: 0x18176BCE0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BD30 Offset: 0x176A330 VA: 0x18176BD30
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BC90 Offset: 0x176A290 VA: 0x18176BC90
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BC40 Offset: 0x176A240 VA: 0x18176BC40
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BBF0 Offset: 0x176A1F0 VA: 0x18176BBF0
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BD80 Offset: 0x176A380 VA: 0x18176BD80
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176BDD0 Offset: 0x176A3D0 VA: 0x18176BDD0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176BE20 Offset: 0x176A420 VA: 0x18176BE20
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class Lookup.<GetEnumerator>d__12<TKey, TElement> : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator // TypeDefIndex: 3229
{	private int <>1__state; // 0x0
	private IGrouping<TKey, TElement> <>2__current; // 0x0
	public Lookup<TKey, TElement> <>4__this; // 0x0
	private Lookup.Grouping<TKey, TElement> <g>5__1; // 0x0

	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650030 Offset: 0x164E630 VA: 0x181650030
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>..ctor
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>..ctor
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>..ctor
	|-Lookup.<GetEnumerator>d__12<object, object>..ctor
	|-Lookup.<GetEnumerator>d__12<uint, object>..ctor
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<object, object>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.IDisposable.Dispose
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A0D0 Offset: 0x17686D0 VA: 0x18176A0D0
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.MoveNext
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<uint, object>.MoveNext
	|
	|-RVA: 0x176A180 Offset: 0x1768780 VA: 0x18176A180
	|-Lookup.<GetEnumerator>d__12<object, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A3C0 Offset: 0x17689C0 VA: 0x18176A3C0
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A2D0 Offset: 0x17688D0 VA: 0x18176A2D0
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A320 Offset: 0x1768920 VA: 0x18176A320
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A230 Offset: 0x1768830 VA: 0x18176A230
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A370 Offset: 0x1768970 VA: 0x18176A370
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A280 Offset: 0x1768880 VA: 0x18176A280
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

