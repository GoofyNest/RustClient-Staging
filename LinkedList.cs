public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 3116
{	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149870 Offset: 0x148C70 VA: 0x180149870
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x1499E0 Offset: 0x148DE0 VA: 0x1801499E0
	|-LinkedList.Enumerator<object>..ctor
	*/

	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149A60 Offset: 0x148E60 VA: 0x180149A60
	|-LinkedList.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x149A80 Offset: 0x148E80 VA: 0x180149A80
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x149A40 Offset: 0x148E40 VA: 0x180149A40
	|-LinkedList.Enumerator<object>..ctor
	*/

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

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495A0 Offset: 0x1489A0 VA: 0x1801495A0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149460 Offset: 0x148860 VA: 0x180149460
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1496E0 Offset: 0x148AE0 VA: 0x1801496E0
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147CD0 Offset: 0x1470D0 VA: 0x180147CD0
	|-LinkedList.Enumerator<ItemCraftTask>.MoveNext
	|-LinkedList.Enumerator<NotesBuilder.NoteDescriptor>.MoveNext
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.MoveNext
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x148760 Offset: 0x147B60 VA: 0x180148760
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x148230 Offset: 0x147630 VA: 0x180148230
	|-LinkedList.Enumerator<KeyValuePair<uint, FileStorage.CacheData>>.MoveNext
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.MoveNext
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148EE0 Offset: 0x1482E0 VA: 0x180148EE0
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148BE0 Offset: 0x147FE0 VA: 0x180148BE0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148E40 Offset: 0x148240 VA: 0x180148E40
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/

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

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149830 Offset: 0x148C30 VA: 0x180149830
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x149810 Offset: 0x148C10 VA: 0x180149810
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x149850 Offset: 0x148C50 VA: 0x180149850
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149800 Offset: 0x148C00 VA: 0x180149800
	|-LinkedList.Enumerator<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x1497E0 Offset: 0x148BE0 VA: 0x1801497E0
	|-LinkedList.Enumerator<KeyValuePair<uint, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x1497F0 Offset: 0x148BF0 VA: 0x1801497F0
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

}

