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
	|-RVA: 0x17614D0 Offset: 0x175FAD0 VA: 0x1817614D0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.Add
	|
	|-RVA: 0x17615D0 Offset: 0x175FBD0 VA: 0x1817615D0
	|-Lookup.Grouping<InventoryDefId, object>.Add
	|
	|-RVA: 0x1761960 Offset: 0x175FF60 VA: 0x181761960
	|-Lookup.Grouping<Int32Enum, object>.Add
	|
	|-RVA: 0x17616B0 Offset: 0x175FCB0 VA: 0x1817616B0
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x1761880 Offset: 0x175FE80 VA: 0x181761880
	|-Lookup.Grouping<uint, object>.Add
	|
	|-RVA: 0x1761790 Offset: 0x175FD90 VA: 0x181761790
	|-Lookup.Grouping<Vector2Int, Resolution>.Add
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD1130 Offset: 0xD0530 VA: 0x1800D1130
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761AD0 Offset: 0x17600D0 VA: 0x181761AD0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.GetEnumerator
	|
	|-RVA: 0x1761A40 Offset: 0x1760040 VA: 0x181761A40
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
	|-RVA: 0x1760E40 Offset: 0x175F440 VA: 0x181760E40
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
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-Lookup.Grouping<object, object>.get_Key
	|-Lookup.Grouping<Vector2Int, Resolution>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
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
	|-RVA: 0x1761B60 Offset: 0x1760160 VA: 0x181761B60
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x1761C20 Offset: 0x1760220 VA: 0x181761C20
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x1761CA0 Offset: 0x17602A0 VA: 0x181761CA0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x1761BE0 Offset: 0x17601E0 VA: 0x181761BE0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x1761C60 Offset: 0x1760260 VA: 0x181761C60
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x1761BA0 Offset: 0x17601A0 VA: 0x181761BA0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761DA0 Offset: 0x17603A0 VA: 0x181761DA0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x1761CE0 Offset: 0x17602E0 VA: 0x181761CE0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x1761D60 Offset: 0x1760360 VA: 0x181761D60
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x1761DE0 Offset: 0x17603E0 VA: 0x181761DE0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x1761D20 Offset: 0x1760320 VA: 0x181761D20
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x1761E20 Offset: 0x1760420 VA: 0x181761E20
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761F10 Offset: 0x1760510 VA: 0x181761F10
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1761E60 Offset: 0x1760460 VA: 0x181761E60
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1761EE0 Offset: 0x17604E0 VA: 0x181761EE0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1761E90 Offset: 0x1760490 VA: 0x181761E90
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761F60 Offset: 0x1760560 VA: 0x181761F60
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x1761F90 Offset: 0x1760590 VA: 0x181761F90
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762100 Offset: 0x1760700 VA: 0x181762100
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x17620C0 Offset: 0x17606C0 VA: 0x1817620C0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1762080 Offset: 0x1760680 VA: 0x181762080
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1762000 Offset: 0x1760600 VA: 0x181762000
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1762040 Offset: 0x1760640 VA: 0x181762040
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x1761FC0 Offset: 0x17605C0 VA: 0x181761FC0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762140 Offset: 0x1760740 VA: 0x181762140
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x1762180 Offset: 0x1760780 VA: 0x181762180
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x17621F0 Offset: 0x17607F0 VA: 0x1817621F0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x17621B0 Offset: 0x17607B0 VA: 0x1817621B0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762260 Offset: 0x1760860 VA: 0x181762260
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17622A0 Offset: 0x17608A0 VA: 0x1817622A0
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1762320 Offset: 0x1760920 VA: 0x181762320
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1762360 Offset: 0x1760960 VA: 0x181762360
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x1762220 Offset: 0x1760820 VA: 0x181762220
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x17622E0 Offset: 0x17608E0 VA: 0x1817622E0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17624E0 Offset: 0x1760AE0 VA: 0x1817624E0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1762420 Offset: 0x1760A20 VA: 0x181762420
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1762460 Offset: 0x1760A60 VA: 0x181762460
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17624A0 Offset: 0x1760AA0 VA: 0x1817624A0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17623E0 Offset: 0x17609E0 VA: 0x1817623E0
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x17623A0 Offset: 0x17609A0 VA: 0x1817623A0
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17626F0 Offset: 0x1760CF0 VA: 0x1817626F0
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1762830 Offset: 0x1760E30 VA: 0x181762830
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17625B0 Offset: 0x1760BB0 VA: 0x1817625B0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x17627A0 Offset: 0x1760DA0 VA: 0x1817627A0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1762520 Offset: 0x1760B20 VA: 0x181762520
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1762640 Offset: 0x1760C40 VA: 0x181762640
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762900 Offset: 0x1760F00 VA: 0x181762900
	|-Lookup.Grouping<InventoryDefId, InventoryItem>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1762940 Offset: 0x1760F40 VA: 0x181762940
	|-Lookup.Grouping<InventoryDefId, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x17628C0 Offset: 0x1760EC0 VA: 0x1817628C0
	|-Lookup.Grouping<Int32Enum, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x17629C0 Offset: 0x1760FC0 VA: 0x1817629C0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1762A00 Offset: 0x1761000 VA: 0x181762A00
	|-Lookup.Grouping<uint, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x1762980 Offset: 0x1760F80 VA: 0x181762980
	|-Lookup.Grouping<Vector2Int, Resolution>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
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
	|-RVA: 0x15E8E80 Offset: 0x15E7480 VA: 0x1815E8E80
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
	|-RVA: 0x176DA50 Offset: 0x176C050 VA: 0x18176DA50
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.MoveNext
	|
	|-RVA: 0x176DB80 Offset: 0x176C180 VA: 0x18176DB80
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.MoveNext
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.MoveNext
	|
	|-RVA: 0x176DC10 Offset: 0x176C210 VA: 0x18176DC10
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
	|
	|-RVA: 0x176DAF0 Offset: 0x176C0F0 VA: 0x18176DAF0
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176D4C0 Offset: 0x176BAC0 VA: 0x18176D4C0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x176D410 Offset: 0x176BA10 VA: 0x18176D410
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DD90 Offset: 0x176C390 VA: 0x18176DD90
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176DDE0 Offset: 0x176C3E0 VA: 0x18176DDE0
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176DD40 Offset: 0x176C340 VA: 0x18176DD40
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176DCF0 Offset: 0x176C2F0 VA: 0x18176DCF0
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176DCA0 Offset: 0x176C2A0 VA: 0x18176DCA0
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176DE30 Offset: 0x176C430 VA: 0x18176DE30
	|-Lookup.Grouping.<GetEnumerator>d__7<Vector2Int, Resolution>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176DE80 Offset: 0x176C480 VA: 0x18176DE80
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Lookup.Grouping.<GetEnumerator>d__7<InventoryDefId, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|-Lookup.Grouping.<GetEnumerator>d__7<uint, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x176DED0 Offset: 0x176C4D0 VA: 0x18176DED0
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
	|-RVA: 0x15E8E80 Offset: 0x15E7480 VA: 0x1815E8E80
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
	|-RVA: 0x176C180 Offset: 0x176A780 VA: 0x18176C180
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.MoveNext
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.MoveNext
	|-Lookup.<GetEnumerator>d__12<uint, object>.MoveNext
	|
	|-RVA: 0x176C230 Offset: 0x176A830 VA: 0x18176C230
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
	|-RVA: 0x176C470 Offset: 0x176AA70 VA: 0x18176C470
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176C380 Offset: 0x176A980 VA: 0x18176C380
	|-Lookup.<GetEnumerator>d__12<InventoryDefId, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176C3D0 Offset: 0x176A9D0 VA: 0x18176C3D0
	|-Lookup.<GetEnumerator>d__12<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176C2E0 Offset: 0x176A8E0 VA: 0x18176C2E0
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176C420 Offset: 0x176AA20 VA: 0x18176C420
	|-Lookup.<GetEnumerator>d__12<uint, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x176C330 Offset: 0x176A930 VA: 0x18176C330
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

