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
	|-RVA: 0x175F420 Offset: 0x175DA20 VA: 0x18175F420
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.Add
	|
	|-RVA: 0x175F520 Offset: 0x175DB20 VA: 0x18175F520
	|-Lookup.Grouping<InventoryDefId, object>.Add
	|
	|-RVA: 0x175F8B0 Offset: 0x175DEB0 VA: 0x18175F8B0
	|-Lookup.Grouping<Int32Enum, object>.Add
	|
	|-RVA: 0x175F600 Offset: 0x175DC00 VA: 0x18175F600
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x175F7D0 Offset: 0x175DDD0 VA: 0x18175F7D0
	|-Lookup.Grouping<uint, object>.Add
	|
	|-RVA: 0x175F6E0 Offset: 0x175DCE0 VA: 0x18175F6E0
	|-Lookup.Grouping<Vector2Int, Resolution>.Add
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD1130 Offset: 0xD0530 VA: 0x1800D1130
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FA20 Offset: 0x175E020 VA: 0x18175FA20
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.GetEnumerator
	|
	|-RVA: 0x175F990 Offset: 0x175DF90 VA: 0x18175F990
	|-Lookup.Grouping<InventoryDefId, object>.GetEnumerator
	|-Lookup.Grouping<Int32Enum, object>.GetEnumerator
	|-Lookup.Grouping<object, object>.GetEnumerator
	|-Lookup.Grouping<uint, object>.GetEnumerator
	|-Lookup.Grouping<Vector2Int, Resolution>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16509D0 Offset: 0x164EFD0 VA: 0x1816509D0
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
	|-RVA: 0x175FAB0 Offset: 0x175E0B0 VA: 0x18175FAB0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FB70 Offset: 0x175E170 VA: 0x18175FB70
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FBF0 Offset: 0x175E1F0 VA: 0x18175FBF0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FB30 Offset: 0x175E130 VA: 0x18175FB30
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FBB0 Offset: 0x175E1B0 VA: 0x18175FBB0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FAF0 Offset: 0x175E0F0 VA: 0x18175FAF0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FCF0 Offset: 0x175E2F0 VA: 0x18175FCF0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FC30 Offset: 0x175E230 VA: 0x18175FC30
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FCB0 Offset: 0x175E2B0 VA: 0x18175FCB0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FD30 Offset: 0x175E330 VA: 0x18175FD30
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FC70 Offset: 0x175E270 VA: 0x18175FC70
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FD70 Offset: 0x175E370 VA: 0x18175FD70
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FE60 Offset: 0x175E460 VA: 0x18175FE60
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FDB0 Offset: 0x175E3B0 VA: 0x18175FDB0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FE30 Offset: 0x175E430 VA: 0x18175FE30
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FDE0 Offset: 0x175E3E0 VA: 0x18175FDE0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FEB0 Offset: 0x175E4B0 VA: 0x18175FEB0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x175FEE0 Offset: 0x175E4E0 VA: 0x18175FEE0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760050 Offset: 0x175E650 VA: 0x181760050
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1760010 Offset: 0x175E610 VA: 0x181760010
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FFD0 Offset: 0x175E5D0 VA: 0x18175FFD0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FF50 Offset: 0x175E550 VA: 0x18175FF50
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FF90 Offset: 0x175E590 VA: 0x18175FF90
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FF10 Offset: 0x175E510 VA: 0x18175FF10
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760090 Offset: 0x175E690 VA: 0x181760090
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x17600D0 Offset: 0x175E6D0 VA: 0x1817600D0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760140 Offset: 0x175E740 VA: 0x181760140
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760100 Offset: 0x175E700 VA: 0x181760100
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17601B0 Offset: 0x175E7B0 VA: 0x1817601B0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17601F0 Offset: 0x175E7F0 VA: 0x1817601F0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760270 Offset: 0x175E870 VA: 0x181760270
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17602B0 Offset: 0x175E8B0 VA: 0x1817602B0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760170 Offset: 0x175E770 VA: 0x181760170
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760230 Offset: 0x175E830 VA: 0x181760230
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.Insert
	*/

	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760430 Offset: 0x175EA30 VA: 0x181760430
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760370 Offset: 0x175E970 VA: 0x181760370
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17603B0 Offset: 0x175E9B0 VA: 0x1817603B0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17603F0 Offset: 0x175E9F0 VA: 0x1817603F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760330 Offset: 0x175E930 VA: 0x181760330
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17602F0 Offset: 0x175E8F0 VA: 0x1817602F0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760640 Offset: 0x175EC40 VA: 0x181760640
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760780 Offset: 0x175ED80 VA: 0x181760780
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760500 Offset: 0x175EB00 VA: 0x181760500
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17606F0 Offset: 0x175ECF0 VA: 0x1817606F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760470 Offset: 0x175EA70 VA: 0x181760470
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760590 Offset: 0x175EB90 VA: 0x181760590
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760850 Offset: 0x175EE50 VA: 0x181760850
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760890 Offset: 0x175EE90 VA: 0x181760890
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760810 Offset: 0x175EE10 VA: 0x181760810
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760910 Offset: 0x175EF10 VA: 0x181760910
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760950 Offset: 0x175EF50 VA: 0x181760950
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x17608D0 Offset: 0x175EED0 VA: 0x1817608D0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
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
	|-RVA: 0x164FFF0 Offset: 0x164E5F0 VA: 0x18164FFF0
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
	|-RVA: 0x176B960 Offset: 0x1769F60 VA: 0x18176B960
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x176BA90 Offset: 0x176A090 VA: 0x18176BA90
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.MoveNext
	|
	|-RVA: 0x176BB20 Offset: 0x176A120 VA: 0x18176BB20
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
	|
	|-RVA: 0x176BA00 Offset: 0x176A000 VA: 0x18176BA00
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B3D0 Offset: 0x17699D0 VA: 0x18176B3D0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B320 Offset: 0x1769920 VA: 0x18176B320
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176BCA0 Offset: 0x176A2A0 VA: 0x18176BCA0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BCF0 Offset: 0x176A2F0 VA: 0x18176BCF0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BC50 Offset: 0x176A250 VA: 0x18176BC50
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BC00 Offset: 0x176A200 VA: 0x18176BC00
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BBB0 Offset: 0x176A1B0 VA: 0x18176BBB0
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BD40 Offset: 0x176A340 VA: 0x18176BD40
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176BD90 Offset: 0x176A390 VA: 0x18176BD90
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176BDE0 Offset: 0x176A3E0 VA: 0x18176BDE0
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
	|-RVA: 0x164FFF0 Offset: 0x164E5F0 VA: 0x18164FFF0
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
	|-RVA: 0x176A090 Offset: 0x1768690 VA: 0x18176A090
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.MoveNext
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<uint, object>.MoveNext
	|
	|-RVA: 0x176A140 Offset: 0x1768740 VA: 0x18176A140
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
	|-RVA: 0x176A380 Offset: 0x1768980 VA: 0x18176A380
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A290 Offset: 0x1768890 VA: 0x18176A290
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A2E0 Offset: 0x17688E0 VA: 0x18176A2E0
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A1F0 Offset: 0x17687F0 VA: 0x18176A1F0
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A330 Offset: 0x1768930 VA: 0x18176A330
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A240 Offset: 0x1768840 VA: 0x18176A240
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

