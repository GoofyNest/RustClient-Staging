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

	// RVA: 0x15CCEF0 Offset: 0x15CB4F0 VA: 0x1815CCEF0
	protected void .ctor() { }

	// RVA: 0x15CCDB0 Offset: 0x15CB3B0 VA: 0x1815CCDB0
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x15CCD70 Offset: 0x15CB370 VA: 0x1815CCD70
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15CCD40 Offset: 0x15CB340 VA: 0x1815CCD40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CB9F0 Offset: 0x15C9FF0 VA: 0x1815CB9F0 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CC0B0 Offset: 0x15CA6B0 VA: 0x1815CC0B0 Slot: 11
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x15CC7A0 Offset: 0x15CADA0 VA: 0x1815CC7A0
	private void Reset() { }

	// RVA: 0x15CC860 Offset: 0x15CAE60 VA: 0x1815CC860
	private void Reset(int capacity) { }

	// RVA: 0x15CB890 Offset: 0x15C9E90 VA: 0x1815CB890
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	protected bool get_IsReadOnly() { }

	// RVA: 0x15CB0F0 Offset: 0x15C96F0 VA: 0x1815CB0F0
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x15CB580 Offset: 0x15C9B80 VA: 0x1815CB580
	protected void BaseRemove(string name) { }

	// RVA: 0x15CB470 Offset: 0x15C9A70 VA: 0x1815CB470
	protected object BaseGet(string name) { }

	// RVA: 0x15CB7C0 Offset: 0x15C9DC0 VA: 0x1815CB7C0
	protected void BaseSet(string name, object value) { }

	// RVA: 0x15CB490 Offset: 0x15C9A90 VA: 0x1815CB490
	protected object BaseGet(int index) { }

	// RVA: 0x15CB380 Offset: 0x15C9980 VA: 0x1815CB380
	protected string BaseGetKey(int index) { }

	// RVA: 0x15CB960 Offset: 0x15C9F60 VA: 0x1815CB960 Slot: 12
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1521990 Offset: 0x151FF90 VA: 0x181521990 Slot: 13
	public virtual int get_Count() { }

	// RVA: 0x15CC930 Offset: 0x15CAF30 VA: 0x1815CC930 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x15CCC20 Offset: 0x15CB220 VA: 0x1815CCC20 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15CB270 Offset: 0x15C9870 VA: 0x1815CB270
	protected string[] BaseGetAllKeys() { }

	// RVA: 0x15CCC90 Offset: 0x15CB290 VA: 0x1815CCC90
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

	// RVA: 0x15CD1D0 Offset: 0x15CB7D0 VA: 0x1815CD1D0
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x15CD070 Offset: 0x15CB670 VA: 0x1815CD070 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x15CD140 Offset: 0x15CB740 VA: 0x1815CD140 Slot: 6
	public void Reset() { }

	// RVA: 0x15CD230 Offset: 0x15CB830 VA: 0x1815CD230 Slot: 5
	public object get_Current() { }

}

