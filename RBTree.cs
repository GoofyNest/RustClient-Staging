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
	|-RVA: 0xF8950 Offset: 0xF7D50 VA: 0x1800F8950
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
	|-RVA: 0x178C940 Offset: 0x178AF40 VA: 0x18178C940
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x178C860 Offset: 0x178AE60 VA: 0x18178C860
	|-RBTree.TreePage<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C710 Offset: 0x178AD10 VA: 0x18178C710
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
	|-RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	|-RBTree.TreePage<int>.set_InUseCount
	|-RBTree.TreePage<object>.set_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	|-RBTree.TreePage<int>.get_PageId
	|-RBTree.TreePage<object>.get_PageId
	*/

	// RVA: -1 Offset: -1
	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
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
	|-RVA: 0x20AE30 Offset: 0x20A230 VA: 0x18020AE30
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20ACD0 Offset: 0x20A0D0 VA: 0x18020ACD0
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20AD20 Offset: 0x20A120 VA: 0x18020AD20
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20AE80 Offset: 0x20A280 VA: 0x18020AE80
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A890 Offset: 0x209C90 VA: 0x18020A890
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x20A9E0 Offset: 0x209DE0 VA: 0x18020A9E0
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AE4E0 Offset: 0x1AD8E0 VA: 0x1801AE4E0
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	|-RBTree.RBTreeEnumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20AC20 Offset: 0x20A020 VA: 0x18020AC20
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20ACA0 Offset: 0x20A0A0 VA: 0x18020ACA0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20ABB0 Offset: 0x209FB0 VA: 0x18020ABB0
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x20AB40 Offset: 0x209F40 VA: 0x18020AB40
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	*/

}

