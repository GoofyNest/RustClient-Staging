internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 3227
{	// Fields
	internal TKey key; // 0x0
	internal int hashCode; // 0x0
	internal TElement[] elements; // 0x0
	internal int count; // 0x0
	internal Lookup.Grouping<TKey, TElement> hashNext; // 0x0
	internal Lookup.Grouping<TKey, TElement> next; // 0x0

	// Properties
	public TKey Key { get; }
	private int System.Collections.Generic.ICollection<TElement>.Count { get; }
	private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void Add(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175F320 Offset: 0x175D920 VA: 0x18175F320
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.Add
	|
	|-RVA: 0x175F420 Offset: 0x175DA20 VA: 0x18175F420
	|-Lookup.Grouping<InventoryDefId, object>.Add
	|
	|-RVA: 0x175F7B0 Offset: 0x175DDB0 VA: 0x18175F7B0
	|-Lookup.Grouping<Int32Enum, object>.Add
	|
	|-RVA: 0x175F500 Offset: 0x175DB00 VA: 0x18175F500
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x175F6D0 Offset: 0x175DCD0 VA: 0x18175F6D0
	|-Lookup.Grouping<uint, object>.Add
	|
	|-RVA: 0x175F5E0 Offset: 0x175DBE0 VA: 0x18175F5E0
	|-Lookup.Grouping<Vector2Int, Resolution>.Add
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD1130 Offset: 0xD0530 VA: 0x1800D1130
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175F920 Offset: 0x175DF20 VA: 0x18175F920
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.GetEnumerator
	|
	|-RVA: 0x175F890 Offset: 0x175DE90 VA: 0x18175F890
	|-Lookup.Grouping<InventoryDefId, object>.GetEnumerator
	|-Lookup.Grouping<Int32Enum, object>.GetEnumerator
	|-Lookup.Grouping<object, object>.GetEnumerator
	|-Lookup.Grouping<uint, object>.GetEnumerator
	|-Lookup.Grouping<Vector2Int, Resolution>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16508D0 Offset: 0x164EED0 VA: 0x1816508D0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
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

	// RVA: -1 Offset: -1 Slot: 12
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

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175F9B0 Offset: 0x175DFB0 VA: 0x18175F9B0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FA70 Offset: 0x175E070 VA: 0x18175FA70
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FAF0 Offset: 0x175E0F0 VA: 0x18175FAF0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FA30 Offset: 0x175E030 VA: 0x18175FA30
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175FAB0 Offset: 0x175E0B0 VA: 0x18175FAB0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x175F9F0 Offset: 0x175DFF0 VA: 0x18175F9F0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FBF0 Offset: 0x175E1F0 VA: 0x18175FBF0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FB30 Offset: 0x175E130 VA: 0x18175FB30
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FBB0 Offset: 0x175E1B0 VA: 0x18175FBB0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FC30 Offset: 0x175E230 VA: 0x18175FC30
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FB70 Offset: 0x175E170 VA: 0x18175FB70
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x175FC70 Offset: 0x175E270 VA: 0x18175FC70
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FD60 Offset: 0x175E360 VA: 0x18175FD60
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FCB0 Offset: 0x175E2B0 VA: 0x18175FCB0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FD30 Offset: 0x175E330 VA: 0x18175FD30
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x175FCE0 Offset: 0x175E2E0 VA: 0x18175FCE0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FDB0 Offset: 0x175E3B0 VA: 0x18175FDB0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x175FDE0 Offset: 0x175E3E0 VA: 0x18175FDE0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FF50 Offset: 0x175E550 VA: 0x18175FF50
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FF10 Offset: 0x175E510 VA: 0x18175FF10
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FED0 Offset: 0x175E4D0 VA: 0x18175FED0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FE50 Offset: 0x175E450 VA: 0x18175FE50
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FE90 Offset: 0x175E490 VA: 0x18175FE90
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x175FE10 Offset: 0x175E410 VA: 0x18175FE10
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175FF90 Offset: 0x175E590 VA: 0x18175FF90
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x175FFD0 Offset: 0x175E5D0 VA: 0x18175FFD0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760040 Offset: 0x175E640 VA: 0x181760040
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1760000 Offset: 0x175E600 VA: 0x181760000
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17600B0 Offset: 0x175E6B0 VA: 0x1817600B0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17600F0 Offset: 0x175E6F0 VA: 0x1817600F0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760170 Offset: 0x175E770 VA: 0x181760170
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17601B0 Offset: 0x175E7B0 VA: 0x1817601B0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760070 Offset: 0x175E670 VA: 0x181760070
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1760130 Offset: 0x175E730 VA: 0x181760130
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760330 Offset: 0x175E930 VA: 0x181760330
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760270 Offset: 0x175E870 VA: 0x181760270
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17602B0 Offset: 0x175E8B0 VA: 0x1817602B0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17602F0 Offset: 0x175E8F0 VA: 0x1817602F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1760230 Offset: 0x175E830 VA: 0x181760230
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17601F0 Offset: 0x175E7F0 VA: 0x1817601F0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760540 Offset: 0x175EB40 VA: 0x181760540
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760680 Offset: 0x175EC80 VA: 0x181760680
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760400 Offset: 0x175EA00 VA: 0x181760400
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17605F0 Offset: 0x175EBF0 VA: 0x1817605F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760370 Offset: 0x175E970 VA: 0x181760370
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1760490 Offset: 0x175EA90 VA: 0x181760490
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760750 Offset: 0x175ED50 VA: 0x181760750
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760790 Offset: 0x175ED90 VA: 0x181760790
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760710 Offset: 0x175ED10 VA: 0x181760710
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760810 Offset: 0x175EE10 VA: 0x181760810
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1760850 Offset: 0x175EE50 VA: 0x181760850
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x17607D0 Offset: 0x175EDD0 VA: 0x1817607D0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BAD0 Offset: 0xD5A0D0 VA: 0x180D5BAD0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>..ctor
	|-Lookup.Grouping<InventoryDefId, object>..ctor
	|-Lookup.Grouping<Int32Enum, object>..ctor
	|-Lookup.Grouping<object, object>..ctor
	|-Lookup.Grouping<uint, object>..ctor
	|-Lookup.Grouping<Vector2Int, Resolution>..ctor
	*/

}

private sealed class Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 3228
{	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public Lookup.Grouping<TKey, TElement> <>4__this; // 0x0
	private int <i>5__1; // 0x0

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
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>..ctor
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
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

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B860 Offset: 0x1769E60 VA: 0x18176B860
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x176B990 Offset: 0x1769F90 VA: 0x18176B990
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.MoveNext
	|
	|-RVA: 0x176BA20 Offset: 0x176A020 VA: 0x18176BA20
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
	|
	|-RVA: 0x176B900 Offset: 0x1769F00 VA: 0x18176B900
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B2D0 Offset: 0x17698D0 VA: 0x18176B2D0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176B220 Offset: 0x1769820 VA: 0x18176B220
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176BBA0 Offset: 0x176A1A0 VA: 0x18176BBA0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BBF0 Offset: 0x176A1F0 VA: 0x18176BBF0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BB50 Offset: 0x176A150 VA: 0x18176BB50
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BB00 Offset: 0x176A100 VA: 0x18176BB00
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BAB0 Offset: 0x176A0B0 VA: 0x18176BAB0
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176BC40 Offset: 0x176A240 VA: 0x18176BC40
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176BC90 Offset: 0x176A290 VA: 0x18176BC90
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176BCE0 Offset: 0x176A2E0 VA: 0x18176BCE0
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class Lookup.<GetEnumerator>d__12<TKey, TElement> : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator // TypeDefIndex: 3229
{	// Fields
	private int <>1__state; // 0x0
	private IGrouping<TKey, TElement> <>2__current; // 0x0
	public Lookup<TKey, TElement> <>4__this; // 0x0
	private Lookup.Grouping<TKey, TElement> <g>5__1; // 0x0

	// Properties
	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FEF0 Offset: 0x164E4F0 VA: 0x18164FEF0
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>..ctor
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>..ctor
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>..ctor
	|-Lookup.<GetEnumerator>d__12<object, object>..ctor
	|-Lookup.<GetEnumerator>d__12<uint, object>..ctor
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
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

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1769F90 Offset: 0x1768590 VA: 0x181769F90
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.MoveNext
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<uint, object>.MoveNext
	|
	|-RVA: 0x176A040 Offset: 0x1768640 VA: 0x18176A040
	|-Lookup.<GetEnumerator>d__12<object, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
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
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A280 Offset: 0x1768880 VA: 0x18176A280
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A190 Offset: 0x1768790 VA: 0x18176A190
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A1E0 Offset: 0x17687E0 VA: 0x18176A1E0
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A0F0 Offset: 0x17686F0 VA: 0x18176A0F0
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A230 Offset: 0x1768830 VA: 0x18176A230
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176A140 Offset: 0x1768740 VA: 0x18176A140
	|-Lookup.<GetEnumerator>d__12<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
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

