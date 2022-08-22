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

	// RVA: 0x15CBFC0 Offset: 0x15CA5C0 VA: 0x1815CBFC0
	protected void .ctor() { }

	// RVA: 0x15CBE80 Offset: 0x15CA480 VA: 0x1815CBE80
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x15CBE40 Offset: 0x15CA440 VA: 0x1815CBE40
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15CBE10 Offset: 0x15CA410 VA: 0x1815CBE10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CAAC0 Offset: 0x15C90C0 VA: 0x1815CAAC0 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CB180 Offset: 0x15C9780 VA: 0x1815CB180 Slot: 11
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x15CB870 Offset: 0x15C9E70 VA: 0x1815CB870
	private void Reset() { }

	// RVA: 0x15CB930 Offset: 0x15C9F30 VA: 0x1815CB930
	private void Reset(int capacity) { }

	// RVA: 0x15CA960 Offset: 0x15C8F60 VA: 0x1815CA960
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	protected bool get_IsReadOnly() { }

	// RVA: 0x15CA1C0 Offset: 0x15C87C0 VA: 0x1815CA1C0
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x15CA650 Offset: 0x15C8C50 VA: 0x1815CA650
	protected void BaseRemove(string name) { }

	// RVA: 0x15CA540 Offset: 0x15C8B40 VA: 0x1815CA540
	protected object BaseGet(string name) { }

	// RVA: 0x15CA890 Offset: 0x15C8E90 VA: 0x1815CA890
	protected void BaseSet(string name, object value) { }

	// RVA: 0x15CA560 Offset: 0x15C8B60 VA: 0x1815CA560
	protected object BaseGet(int index) { }

	// RVA: 0x15CA450 Offset: 0x15C8A50 VA: 0x1815CA450
	protected string BaseGetKey(int index) { }

	// RVA: 0x15CAA30 Offset: 0x15C9030 VA: 0x1815CAA30 Slot: 12
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1520A60 Offset: 0x151F060 VA: 0x181520A60 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x15CBA00 Offset: 0x15CA000 VA: 0x1815CBA00 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x15CBCF0 Offset: 0x15CA2F0 VA: 0x1815CBCF0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15CA340 Offset: 0x15C8940 VA: 0x1815CA340
	protected string[] BaseGetAllKeys() { }

	// RVA: 0x15CBD60 Offset: 0x15CA360 VA: 0x1815CBD60
	private static void .cctor() { }

}

internal class NameObjectCollectionBase.NameObjectEntry // TypeDefIndex: 3103
{	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
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

	// RVA: 0x15CC2A0 Offset: 0x15CA8A0 VA: 0x1815CC2A0
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x15CC140 Offset: 0x15CA740 VA: 0x1815CC140 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x15CC210 Offset: 0x15CA810 VA: 0x1815CC210 Slot: 6
	public void Reset() { }

	// RVA: 0x15CC300 Offset: 0x15CA900 VA: 0x1815CC300 Slot: 5
	public object get_Current() { }

}

