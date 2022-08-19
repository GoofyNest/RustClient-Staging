public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 3102
{	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x15CCC30 Offset: 0x15CB230 VA: 0x1815CCC30
	protected void .ctor() { }

	// RVA: 0x15CCAF0 Offset: 0x15CB0F0 VA: 0x1815CCAF0
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x15CCAB0 Offset: 0x15CB0B0 VA: 0x1815CCAB0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15CCA80 Offset: 0x15CB080 VA: 0x1815CCA80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CB730 Offset: 0x15C9D30 VA: 0x1815CB730 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CBDF0 Offset: 0x15CA3F0 VA: 0x1815CBDF0 Slot: 11
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x15CC4E0 Offset: 0x15CAAE0 VA: 0x1815CC4E0
	private void Reset() { }

	// RVA: 0x15CC5A0 Offset: 0x15CABA0 VA: 0x1815CC5A0
	private void Reset(int capacity) { }

	// RVA: 0x15CB5D0 Offset: 0x15C9BD0 VA: 0x1815CB5D0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	protected bool get_IsReadOnly() { }

	// RVA: 0x15CAE30 Offset: 0x15C9430 VA: 0x1815CAE30
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x15CB2C0 Offset: 0x15C98C0 VA: 0x1815CB2C0
	protected void BaseRemove(string name) { }

	// RVA: 0x15CB1B0 Offset: 0x15C97B0 VA: 0x1815CB1B0
	protected object BaseGet(string name) { }

	// RVA: 0x15CB500 Offset: 0x15C9B00 VA: 0x1815CB500
	protected void BaseSet(string name, object value) { }

	// RVA: 0x15CB1D0 Offset: 0x15C97D0 VA: 0x1815CB1D0
	protected object BaseGet(int index) { }

	// RVA: 0x15CB0C0 Offset: 0x15C96C0 VA: 0x1815CB0C0
	protected string BaseGetKey(int index) { }

	// RVA: 0x15CB6A0 Offset: 0x15C9CA0 VA: 0x1815CB6A0 Slot: 12
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x15216D0 Offset: 0x151FCD0 VA: 0x1815216D0 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x15CC670 Offset: 0x15CAC70 VA: 0x1815CC670 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x15CC960 Offset: 0x15CAF60 VA: 0x1815CC960 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15CAFB0 Offset: 0x15C95B0 VA: 0x1815CAFB0
	protected string[] BaseGetAllKeys() { }

	// RVA: 0x15CC9D0 Offset: 0x15CAFD0 VA: 0x1815CC9D0
	private static void .cctor() { }

}

internal class NameObjectCollectionBase.NameObjectEntry // TypeDefIndex: 3103
{	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(string name, object value) { }

}

internal class NameObjectCollectionBase.NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 3104
{	// Fields
	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x15CCF10 Offset: 0x15CB510 VA: 0x1815CCF10
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x15CCDB0 Offset: 0x15CB3B0 VA: 0x1815CCDB0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x15CCE80 Offset: 0x15CB480 VA: 0x1815CCE80 Slot: 6
	public void Reset() { }

	// RVA: 0x15CCF70 Offset: 0x15CB570 VA: 0x1815CCF70 Slot: 5
	public object get_Current() { }

}

