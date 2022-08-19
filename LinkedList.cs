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
	|-RVA: 0x149AD0 Offset: 0x148ED0 VA: 0x180149AD0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149C40 Offset: 0x149040 VA: 0x180149C40
	|-LinkedList.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149CC0 Offset: 0x1490C0 VA: 0x180149CC0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x149CE0 Offset: 0x1490E0 VA: 0x180149CE0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149CA0 Offset: 0x1490A0 VA: 0x180149CA0
	|-LinkedList.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	|-LinkedList.Enumerator<ItemCraftTask>.get_Current
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.get_Current
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.get_Current
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.get_Current
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149800 Offset: 0x148C00 VA: 0x180149800
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1496C0 Offset: 0x148AC0 VA: 0x1801496C0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149940 Offset: 0x148D40 VA: 0x180149940
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147F30 Offset: 0x147330 VA: 0x180147F30
	|-LinkedList.Enumerator<ItemCraftTask>.MoveNext
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.MoveNext
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.MoveNext
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1489C0 Offset: 0x147DC0 VA: 0x1801489C0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x148490 Offset: 0x147890 VA: 0x180148490
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.MoveNext
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149140 Offset: 0x148540 VA: 0x180149140
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148E40 Offset: 0x148240 VA: 0x180148E40
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1490A0 Offset: 0x1484A0 VA: 0x1801490A0
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
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
	|-RVA: 0x149A90 Offset: 0x148E90 VA: 0x180149A90
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x149A70 Offset: 0x148E70 VA: 0x180149A70
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x149AB0 Offset: 0x148EB0 VA: 0x180149AB0
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149A60 Offset: 0x148E60 VA: 0x180149A60
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x149A40 Offset: 0x148E40 VA: 0x180149A40
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x149A50 Offset: 0x148E50 VA: 0x180149A50
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

}

