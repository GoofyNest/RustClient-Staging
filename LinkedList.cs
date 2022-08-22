public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3116
{	// Fields
	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149A50 Offset: 0x148E50 VA: 0x180149A50
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149BC0 Offset: 0x148FC0 VA: 0x180149BC0
	|-LinkedList.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149C40 Offset: 0x149040 VA: 0x180149C40
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x149C60 Offset: 0x149060 VA: 0x180149C60
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149C20 Offset: 0x149020 VA: 0x180149C20
	|-LinkedList.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	|-LinkedList.Enumerator<ItemCraftTask>.get_Current
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.get_Current
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.get_Current
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x116F10 Offset: 0x116310 VA: 0x180116F10
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149780 Offset: 0x148B80 VA: 0x180149780
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149640 Offset: 0x148A40 VA: 0x180149640
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1498C0 Offset: 0x148CC0 VA: 0x1801498C0
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147EB0 Offset: 0x1472B0 VA: 0x180147EB0
	|-LinkedList.Enumerator<ItemCraftTask>.MoveNext
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.MoveNext
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.MoveNext
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x148940 Offset: 0x147D40 VA: 0x180148940
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x148410 Offset: 0x147810 VA: 0x180148410
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.MoveNext
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1490C0 Offset: 0x1484C0 VA: 0x1801490C0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148DC0 Offset: 0x1481C0 VA: 0x180148DC0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x149020 Offset: 0x148420 VA: 0x180149020
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-LinkedList.Enumerator<ItemCraftTask>.Dispose
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.Dispose
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.Dispose
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.Dispose
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.Dispose
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.Dispose
	|-LinkedList.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149A10 Offset: 0x148E10 VA: 0x180149A10
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x1499F0 Offset: 0x148DF0 VA: 0x1801499F0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x149A30 Offset: 0x148E30 VA: 0x180149A30
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1499E0 Offset: 0x148DE0 VA: 0x1801499E0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x1499C0 Offset: 0x148DC0 VA: 0x1801499C0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x1499D0 Offset: 0x148DD0 VA: 0x1801499D0
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

}

