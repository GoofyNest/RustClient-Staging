private enum RBTree.NodeColor<K> // TypeDefIndex: 4287
{	public int value__; // 0x0
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;

}

private struct RBTree.Node<K> // TypeDefIndex: 4288
{	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal RBTree.NodeColor<K> _nodeColor; // 0x0

}

private struct RBTree.NodePath<K> // TypeDefIndex: 4289
{	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0


	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	|-RBTree.NodePath<int>..ctor
	|-RBTree.NodePath<object>..ctor
	*/

}

private sealed class RBTree.TreePage<K> // TypeDefIndex: 4290
{	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	internal int InUseCount { get; set; }
	internal int PageId { get; set; }


	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A890 Offset: 0x1788E90 VA: 0x18178A890
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x178A7B0 Offset: 0x1788DB0 VA: 0x18178A7B0
	|-RBTree.TreePage<object>..ctor
	*/

	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A660 Offset: 0x1788C60 VA: 0x18178A660
	|-RBTree.TreePage<int>.AllocSlot
	|-RBTree.TreePage<object>.AllocSlot
	*/

	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	|-RBTree.TreePage<int>.get_InUseCount
	|-RBTree.TreePage<object>.get_InUseCount
	*/

	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x69D790 Offset: 0x69BD90 VA: 0x18069D790
	|-RBTree.TreePage<int>.set_InUseCount
	|-RBTree.TreePage<object>.set_InUseCount
	*/

	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C710 Offset: 0x79AD10 VA: 0x18079C710
	|-RBTree.TreePage<int>.get_PageId
	|-RBTree.TreePage<object>.get_PageId
	*/

	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C770 Offset: 0x79AD70 VA: 0x18079C770
	|-RBTree.TreePage<int>.set_PageId
	|-RBTree.TreePage<object>.set_PageId
	*/

}

internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 4291
{	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A9E0 Offset: 0x209DE0 VA: 0x18020A9E0
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20A880 Offset: 0x209C80 VA: 0x18020A880
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A8D0 Offset: 0x209CD0 VA: 0x18020A8D0
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x20AA30 Offset: 0x209E30 VA: 0x18020AA30
	|-RBTree.RBTreeEnumerator<object>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A440 Offset: 0x209840 VA: 0x18020A440
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x20A590 Offset: 0x209990 VA: 0x18020A590
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	*/

	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AE160 Offset: 0x1AD560 VA: 0x1801AE160
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	|-RBTree.RBTreeEnumerator<object>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A7D0 Offset: 0x209BD0 VA: 0x18020A7D0
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20A850 Offset: 0x209C50 VA: 0x18020A850
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20A760 Offset: 0x209B60 VA: 0x18020A760
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x20A6F0 Offset: 0x209AF0 VA: 0x18020A6F0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	*/

}

