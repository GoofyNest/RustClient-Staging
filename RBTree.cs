private enum RBTree.NodeColor<K> // TypeDefIndex: 4287
{	// Fields
	public int value__; // 0x0
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;

}

private struct RBTree.Node<K> // TypeDefIndex: 4288
{	// Fields
	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal RBTree.NodeColor<K> _nodeColor; // 0x0

}

private struct RBTree.NodePath<K> // TypeDefIndex: 4289
{	// Fields
	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	|-RBTree.NodePath<int>..ctor
	|-RBTree.NodePath<object>..ctor
	*/

}

private sealed class RBTree.TreePage<K> // TypeDefIndex: 4290
{	// Fields
	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	// Properties
	internal int InUseCount { get; set; }
	internal int PageId { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178CC00 Offset: 0x178B200 VA: 0x18178CC00
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x178CB20 Offset: 0x178B120 VA: 0x18178CB20
	|-RBTree.TreePage<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C9D0 Offset: 0x178AFD0 VA: 0x18178C9D0
	|-RBTree.TreePage<int>.AllocSlot
	|-RBTree.TreePage<object>.AllocSlot
	*/

	// RVA: -1 Offset: -1
	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	|-RBTree.TreePage<int>.get_InUseCount
	|-RBTree.TreePage<object>.get_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	|-RBTree.TreePage<int>.set_InUseCount
	|-RBTree.TreePage<object>.set_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	|-RBTree.TreePage<int>.get_PageId
	|-RBTree.TreePage<object>.get_PageId
	*/

	// RVA: -1 Offset: -1
	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	|-RBTree.TreePage<int>.set_PageId
	|-RBTree.TreePage<object>.set_PageId
	*/

}

internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 4291
{	// Fields
	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Properties
	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20ADB0 Offset: 0x20A1B0 VA: 0x18020ADB0
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20AC50 Offset: 0x20A050 VA: 0x18020AC50
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20ACA0 Offset: 0x20A0A0 VA: 0x18020ACA0
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20AE00 Offset: 0x20A200 VA: 0x18020AE00
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A810 Offset: 0x209C10 VA: 0x18020A810
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x20A960 Offset: 0x209D60 VA: 0x18020A960
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AE460 Offset: 0x1AD860 VA: 0x1801AE460
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	|-RBTree.RBTreeEnumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20ABA0 Offset: 0x209FA0 VA: 0x18020ABA0
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20AC20 Offset: 0x20A020 VA: 0x18020AC20
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20AB30 Offset: 0x209F30 VA: 0x18020AB30
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x20AAC0 Offset: 0x209EC0 VA: 0x18020AAC0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	*/

}

