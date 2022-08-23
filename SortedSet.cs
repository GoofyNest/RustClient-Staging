internal sealed class SortedSet.Node<T> // TypeDefIndex: 3144
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T <Item>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private NodeColor <Color>k__BackingField; // 0x0

	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }


	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2EF80 Offset: 0x1E2D580 VA: 0x181E2EF80
	|-SortedSet.Node<KeyValuePair<long, object>>..ctor
	|-SortedSet.Node<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1E2F010 Offset: 0x1E2D610 VA: 0x181E2F010
	|-SortedSet.Node<object>..ctor
	*/

	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E720 Offset: 0x1E2CD20 VA: 0x181E2E720
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNonNullRed
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNonNullRed
	|-SortedSet.Node<object>.IsNonNullRed
	*/

	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E7B0 Offset: 0x1E2CDB0 VA: 0x181E2E7B0
	|-SortedSet.Node<KeyValuePair<long, object>>.IsNullOrBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNullOrBlack
	|-SortedSet.Node<object>.IsNullOrBlack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE6BE0 Offset: 0xFE51E0 VA: 0x180FE6BE0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Item
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	|-SortedSet.Node<object>.get_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2F230 Offset: 0x1E2D830 VA: 0x181E2F230
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Item
	|
	|-RVA: 0x1E2F250 Offset: 0x1E2D850 VA: 0x181E2F250
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	|-SortedSet.Node<object>.set_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Left
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Left
	|
	|-RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	|-SortedSet.Node<object>.set_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7EEAB0 Offset: 0x7ED0B0 VA: 0x1807EEAB0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Right
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-SortedSet.Node<object>.get_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7EEAC0 Offset: 0x7ED0C0 VA: 0x1807EEAC0
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Right
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Right
	|
	|-RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	|-SortedSet.Node<object>.set_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82C3D0 Offset: 0x82A9D0 VA: 0x18082C3D0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Color
	|
	|-RVA: 0x997BE0 Offset: 0x9961E0 VA: 0x180997BE0
	|-SortedSet.Node<object>.get_Color
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82C400 Offset: 0x82AA00 VA: 0x18082C400
	|-SortedSet.Node<KeyValuePair<long, object>>.set_Color
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Color
	|
	|-RVA: 0x997BF0 Offset: 0x9961F0 VA: 0x180997BF0
	|-SortedSet.Node<object>.set_Color
	*/

	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2F1D0 Offset: 0x1E2D7D0 VA: 0x181E2F1D0
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsBlack
	|-SortedSet.Node<object>.get_IsBlack
	*/

	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2F200 Offset: 0x1E2D800 VA: 0x181E2F200
	|-SortedSet.Node<KeyValuePair<long, object>>.get_IsRed
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsRed
	|-SortedSet.Node<object>.get_IsRed
	*/

	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2F090 Offset: 0x1E2D690 VA: 0x181E2F090
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is2Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is2Node
	|-SortedSet.Node<object>.get_Is2Node
	*/

	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2F140 Offset: 0x1E2D740 VA: 0x181E2F140
	|-SortedSet.Node<KeyValuePair<long, object>>.get_Is4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is4Node
	|-SortedSet.Node<object>.get_Is4Node
	*/

	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E5A0 Offset: 0x1E2CBA0 VA: 0x181E2E5A0
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorBlack
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorBlack
	|-SortedSet.Node<object>.ColorBlack
	*/

	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E5D0 Offset: 0x1E2CBD0 VA: 0x181E2E5D0
	|-SortedSet.Node<KeyValuePair<long, object>>.ColorRed
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorRed
	|-SortedSet.Node<object>.ColorRed
	*/

	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E600 Offset: 0x1E2CC00 VA: 0x181E2E600
	|-SortedSet.Node<KeyValuePair<long, object>>.GetRotation
	|-SortedSet.Node<KeyValuePair<object, object>>.GetRotation
	|-SortedSet.Node<object>.GetRotation
	*/

	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E6B0 Offset: 0x1E2CCB0 VA: 0x181E2E6B0
	|-SortedSet.Node<KeyValuePair<long, object>>.GetSibling
	|-SortedSet.Node<KeyValuePair<object, object>>.GetSibling
	|-SortedSet.Node<object>.GetSibling
	*/

	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2EED0 Offset: 0x1E2D4D0 VA: 0x181E2EED0
	|-SortedSet.Node<KeyValuePair<long, object>>.Split4Node
	|-SortedSet.Node<KeyValuePair<object, object>>.Split4Node
	|-SortedSet.Node<object>.Split4Node
	*/

	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2ED30 Offset: 0x1E2D330 VA: 0x181E2ED30
	|-SortedSet.Node<KeyValuePair<long, object>>.Rotate
	|-SortedSet.Node<KeyValuePair<object, object>>.Rotate
	|-SortedSet.Node<object>.Rotate
	*/

	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2EAA0 Offset: 0x1E2D0A0 VA: 0x181E2EAA0
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeft
	|-SortedSet.Node<object>.RotateLeft
	*/

	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E970 Offset: 0x1E2CF70 VA: 0x181E2E970
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateLeftRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeftRight
	|-SortedSet.Node<object>.RotateLeftRight
	*/

	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2EC80 Offset: 0x1E2D280 VA: 0x181E2EC80
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRight
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRight
	|-SortedSet.Node<object>.RotateRight
	*/

	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2EB50 Offset: 0x1E2D150 VA: 0x181E2EB50
	|-SortedSet.Node<KeyValuePair<long, object>>.RotateRightLeft
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRightLeft
	|-SortedSet.Node<object>.RotateRightLeft
	*/

	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E840 Offset: 0x1E2CE40 VA: 0x181E2E840
	|-SortedSet.Node<KeyValuePair<long, object>>.Merge2Nodes
	|-SortedSet.Node<KeyValuePair<object, object>>.Merge2Nodes
	|-SortedSet.Node<object>.Merge2Nodes
	*/

	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E8F0 Offset: 0x1E2CEF0 VA: 0x181E2E8F0
	|-SortedSet.Node<KeyValuePair<long, object>>.ReplaceChild
	|-SortedSet.Node<KeyValuePair<object, object>>.ReplaceChild
	|-SortedSet.Node<object>.ReplaceChild
	*/

}

public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3145
{	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }


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

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.Dispose
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.Dispose
	|-SortedSet.Enumerator<object>.Dispose
	*/

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

	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x231360 Offset: 0x230760 VA: 0x180231360
	|-SortedSet.Enumerator<KeyValuePair<long, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<KeyValuePair<object, object>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<object>.get_NotStartedOrEnded
	*/

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

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2C990 Offset: 0x1E2AF90 VA: 0x181E2C990
	|-SortedSet.Enumerator<KeyValuePair<long, object>>..cctor
	|-SortedSet.Enumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x1E2CAB0 Offset: 0x1E2B0B0 VA: 0x181E2CAB0
	|-SortedSet.Enumerator<object>..cctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass52_0<T> // TypeDefIndex: 3146
{	public int index; // 0x0
	public int count; // 0x0
	public T[] array; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<object>..ctor
	*/

	internal bool <CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36D10 Offset: 0x1E35310 VA: 0x181E36D10
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<long, object>>.<CopyTo>b__0
	|
	|-RVA: 0x1E36C80 Offset: 0x1E35280 VA: 0x181E36C80
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, object>>.<CopyTo>b__0
	|
	|-RVA: 0x1E36BF0 Offset: 0x1E351F0 VA: 0x181E36BF0
	|-SortedSet.<>c__DisplayClass52_0<object>.<CopyTo>b__0
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_0<T> // TypeDefIndex: 3147
{	public int index; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<object>..ctor
	*/

}

private sealed class SortedSet.<>c__DisplayClass53_1<T> // TypeDefIndex: 3148
{	public object[] objects; // 0x0
	public SortedSet.<>c__DisplayClass53_0<T> CS$<>8__locals1; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<long, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>..ctor
	|-SortedSet.<>c__DisplayClass53_1<object>..ctor
	*/

	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36DB0 Offset: 0x1E353B0 VA: 0x181E36DB0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<long, object>>.<System.Collections.ICollection.CopyTo>b__0
	|-SortedSet.<>c__DisplayClass53_1<KeyValuePair<object, object>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x1E36EB0 Offset: 0x1E354B0 VA: 0x181E36EB0
	|-SortedSet.<>c__DisplayClass53_1<object>.<System.Collections.ICollection.CopyTo>b__0
	*/

}

