internal sealed class SortedSet.Node<T> // TypeDefIndex: 3144
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T <Item>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E660 Offset: 0x1E2CC60 VA: 0x181E2E660
	|-SortedSet.Node<KeyValuePair<long, object>>..ctor
	|-SortedSet.Node<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1E2E6F0 Offset: 0x1E2CCF0 VA: 0x181E2E6F0
	|-SortedSet.Node<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DE00 Offset: 0x1E2C400 VA: 0x181E2DE00
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNonNullRed
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNonNullRed
	|-SortedSet.Node<object>.IsNonNullRed
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DE90 Offset: 0x1E2C490 VA: 0x181E2DE90
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNullOrBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNullOrBlack
	|-SortedSet.Node<object>.IsNullOrBlack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE6040 Offset: 0xFE4640 VA: 0x180FE6040
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Item
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-SortedSet.Node<object>.get_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E910 Offset: 0x1E2CF10 VA: 0x181E2E910
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Item
	|
	|-RVA: 0x1E2E930 Offset: 0x1E2CF30 VA: 0x181E2E930
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	|-SortedSet.Node<object>.set_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Left
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-SortedSet.Node<object>.get_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Left
	|
	|-RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	|-SortedSet.Node<object>.set_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Right
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedSet.Node<object>.get_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Right
	|
	|-RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	|-SortedSet.Node<object>.set_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Color
	|
	|-RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	|-SortedSet.Node<object>.get_Color
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Color
	|
	|-RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
	|-SortedSet.Node<object>.set_Color
	*/

	// RVA: -1 Offset: -1
	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E8B0 Offset: 0x1E2CEB0 VA: 0x181E2E8B0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsBlack
	|-SortedSet.Node<object>.get_IsBlack
	*/

	// RVA: -1 Offset: -1
	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E8E0 Offset: 0x1E2CEE0 VA: 0x181E2E8E0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsRed
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsRed
	|-SortedSet.Node<object>.get_IsRed
	*/

	// RVA: -1 Offset: -1
	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E770 Offset: 0x1E2CD70 VA: 0x181E2E770
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is2Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is2Node
	|-SortedSet.Node<object>.get_Is2Node
	*/

	// RVA: -1 Offset: -1
	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E820 Offset: 0x1E2CE20 VA: 0x181E2E820
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is4Node
	|-SortedSet.Node<object>.get_Is4Node
	*/

	// RVA: -1 Offset: -1
	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DC80 Offset: 0x1E2C280 VA: 0x181E2DC80
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorBlack
	|-SortedSet.Node<object>.ColorBlack
	*/

	// RVA: -1 Offset: -1
	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DCB0 Offset: 0x1E2C2B0 VA: 0x181E2DCB0
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorRed
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorRed
	|-SortedSet.Node<object>.ColorRed
	*/

	// RVA: -1 Offset: -1
	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DCE0 Offset: 0x1E2C2E0 VA: 0x181E2DCE0
	|-SortedSet.Node<KeyValuePair<long, object>>.GetRotation
	|-SortedSet.Node<KeyValuePair<object, object>>.GetRotation
	|-SortedSet.Node<object>.GetRotation
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DD90 Offset: 0x1E2C390 VA: 0x181E2DD90
	|-SortedSet.Node<KeyValuePair<long, object>>.GetSibling
	|-SortedSet.Node<KeyValuePair<object, object>>.GetSibling
	|-SortedSet.Node<object>.GetSibling
	*/

	// RVA: -1 Offset: -1
	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E5B0 Offset: 0x1E2CBB0 VA: 0x181E2E5B0
	|-SortedSet.Node<KeyValuePair<long, object>>.Split4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.Split4Node
	|-SortedSet.Node<object>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E410 Offset: 0x1E2CA10 VA: 0x181E2E410
	|-SortedSet.Node<KeyValuePair<long, object>>.Rotate
	|-SortedSet.Node<KeyValuePair<object, object>>.Rotate
	|-SortedSet.Node<object>.Rotate
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E180 Offset: 0x1E2C780 VA: 0x181E2E180
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeft
	|-SortedSet.Node<object>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E050 Offset: 0x1E2C650 VA: 0x181E2E050
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeftRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeftRight
	|-SortedSet.Node<object>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E360 Offset: 0x1E2C960 VA: 0x181E2E360
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRight
	|-SortedSet.Node<object>.RotateRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E230 Offset: 0x1E2C830 VA: 0x181E2E230
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRightLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRightLeft
	|-SortedSet.Node<object>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DF20 Offset: 0x1E2C520 VA: 0x181E2DF20
	|-SortedSet.Node<KeyValuePair<long, object>>.Merge2Nodes
	|-SortedSet.Node<KeyValuePair<object, object>>.Merge2Nodes
	|-SortedSet.Node<object>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2DFD0 Offset: 0x1E2C5D0 VA: 0x181E2DFD0
	|-SortedSet.Node<KeyValuePair<long, object>>.ReplaceChild
	|-SortedSet.Node<KeyValuePair<object, object>>.ReplaceChild
	|-SortedSet.Node<object>.ReplaceChild
	*/

}

public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3145
{	// Fields
	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231070 Offset: 0x230470 VA: 0x180231070
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..ctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x230FF0 Offset: 0x2303F0 VA: 0x180230FF0
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231050 Offset: 0x230450 VA: 0x180231050
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..ctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x231060 Offset: 0x230460 VA: 0x180231060
	|-SortedSet.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230FD0 Offset: 0x2303D0 VA: 0x180230FD0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x230F90 Offset: 0x230390 VA: 0x180230F90
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x230FB0 Offset: 0x2303B0 VA: 0x180230FB0
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230F60 Offset: 0x230360 VA: 0x180230F60
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x230F80 Offset: 0x230380 VA: 0x180230F80
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x230F70 Offset: 0x230370 VA: 0x180230F70
	|-SortedSet.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230040 Offset: 0x22F440 VA: 0x180230040
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Initialize
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Initialize
	|
	|-RVA: 0x230050 Offset: 0x22F450 VA: 0x180230050
	|-SortedSet.Enumerator<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2300C0 Offset: 0x22F4C0 VA: 0x1802300C0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.MoveNext
	|
	|-RVA: 0x230110 Offset: 0x22F510 VA: 0x180230110
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x2300B0 Offset: 0x22F4B0 VA: 0x1802300B0
	|-SortedSet.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Dispose
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Dispose
	|-SortedSet.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231120 Offset: 0x230520 VA: 0x180231120
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_Current
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x231250 Offset: 0x230650 VA: 0x180231250
	|-SortedSet.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230A90 Offset: 0x22FE90 VA: 0x180230A90
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230D70 Offset: 0x230170 VA: 0x180230D70
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x230E90 Offset: 0x230290 VA: 0x180230E90
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231360 Offset: 0x230760 VA: 0x180231360
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<object>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230140 Offset: 0x22F540 VA: 0x180230140
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Reset
	|
	|-RVA: 0x230150 Offset: 0x22F550 VA: 0x180230150
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Reset
	|
	|-RVA: 0x230130 Offset: 0x22F530 VA: 0x180230130
	|-SortedSet.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x230970 Offset: 0x22FD70 VA: 0x180230970
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x230820 Offset: 0x22FC20 VA: 0x180230820
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x230A40 Offset: 0x22FE40 VA: 0x180230A40
	|-SortedSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C070 Offset: 0x1E2A670 VA: 0x181E2C070
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..cctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1E2C190 Offset: 0x1E2A790 VA: 0x181E2C190
	|-SortedSet.Enumerator<object>..cctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass52_0<T> // TypeDefIndex: 3146
{	// Fields
	public int index; // 0x0
	public int count; // 0x0
	public T[] array; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E363F0 Offset: 0x1E349F0 VA: 0x181E363F0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<long, object>>.<CopyTo>b__0
	|
	|-RVA: 0x1E36360 Offset: 0x1E34960 VA: 0x181E36360
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>.<CopyTo>b__0
	|
	|-RVA: 0x1E362D0 Offset: 0x1E348D0 VA: 0x181E362D0
	|-SortedSet.<>c__DisplayClass52_0<object>.<CopyTo>b__0
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_0<T> // TypeDefIndex: 3147
{	// Fields
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<object>..ctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_1<T> // TypeDefIndex: 3148
{	// Fields
	public object[] objects; // 0x0
	public SortedSet.<>c__DisplayClass53_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_1<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36490 Offset: 0x1E34A90 VA: 0x181E36490
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<long, object>>.<System.Collections.ICollection.CopyTo>b__0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x1E36590 Offset: 0x1E34B90 VA: 0x181E36590
	|-SortedSet.<>c__DisplayClass53_1<object>.<System.Collections.ICollection.CopyTo>b__0
	*/

}

