public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1389
{	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(bool trash) { }

	// RVA: 0x1462480 Offset: 0x1460A80 VA: 0x181462480
	public void .ctor() { }

	// RVA: 0x14625F0 Offset: 0x1460BF0 VA: 0x1814625F0
	public void .ctor(int capacity) { }

	// RVA: 0x1462600 Offset: 0x1460C00 VA: 0x181462600
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xE7790 Offset: 0xE6B90 VA: 0x1800E7790
	// RVA: 0x1462880 Offset: 0x1460E80 VA: 0x181462880
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1462530 Offset: 0x1460B30 VA: 0x181462530
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	// RVA: 0x1462950 Offset: 0x1460F50 VA: 0x181462950
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1462570 Offset: 0x1460B70 VA: 0x181462570
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x14625B0 Offset: 0x1460BB0 VA: 0x1814625B0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x14624A0 Offset: 0x1460AA0 VA: 0x1814624A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1461040 Offset: 0x145F640 VA: 0x181461040
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x14600D0 Offset: 0x145E6D0 VA: 0x1814600D0 Slot: 21
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x14600F0 Offset: 0x145E6F0 VA: 0x1814600F0 Slot: 22
	public virtual void Clear() { }

	// RVA: 0x1460240 Offset: 0x145E840 VA: 0x181460240 Slot: 23
	public virtual object Clone() { }

	// RVA: 0x1460510 Offset: 0x145EB10 VA: 0x181460510 Slot: 24
	public virtual bool Contains(object key) { }

	// RVA: 0x1460360 Offset: 0x145E960 VA: 0x181460360 Slot: 25
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1460650 Offset: 0x145EC50 VA: 0x181460650
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1460530 Offset: 0x145EB30 VA: 0x181460530
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x14606F0 Offset: 0x145ECF0 VA: 0x1814606F0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1460960 Offset: 0x145EF60 VA: 0x181460960
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1462AF0 Offset: 0x14610F0 VA: 0x181462AF0 Slot: 27
	public virtual object get_Item(object key) { }

	// RVA: 0x14631C0 Offset: 0x14617C0 VA: 0x1814631C0 Slot: 28
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1462A10 Offset: 0x1461010 VA: 0x181462A10
	private void expand() { }

	// RVA: 0x1462FE0 Offset: 0x14615E0 VA: 0x181462FE0
	private void rehash() { }

	// RVA: 0x1462450 Offset: 0x1460A50 VA: 0x181462450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1463010 Offset: 0x1461610 VA: 0x181463010
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x14623C0 Offset: 0x14609C0 VA: 0x1814623C0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1460A00 Offset: 0x145F000 VA: 0x181460A00 Slot: 29
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1460A90 Offset: 0x145F090 VA: 0x181460A90 Slot: 30
	protected virtual int GetHash(object key) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 31
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x14616F0 Offset: 0x145FCF0 VA: 0x1814616F0 Slot: 32
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1462D10 Offset: 0x1461310 VA: 0x181462D10 Slot: 33
	public virtual ICollection get_Keys() { }

	// RVA: 0x1462E10 Offset: 0x1461410 VA: 0x181462E10 Slot: 34
	public virtual ICollection get_Values() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1461090 Offset: 0x145F690 VA: 0x181461090
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1462EA0 Offset: 0x14614A0 VA: 0x181462EA0
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1462040 Offset: 0x1460640 VA: 0x181462040 Slot: 35
	public virtual void Remove(object key) { }

	// RVA: 0x1462DA0 Offset: 0x14613A0 VA: 0x181462DA0 Slot: 36
	public virtual object get_SyncRoot() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 37
	public virtual int get_Count() { }

	// RVA: 0x1462320 Offset: 0x1460920 VA: 0x181462320
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1460B10 Offset: 0x145F110 VA: 0x181460B10 Slot: 38
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1461810 Offset: 0x145FE10 VA: 0x181461810 Slot: 39
	public virtual void OnDeserialization(object sender) { }

}

private struct Hashtable.bucket // TypeDefIndex: 1390
{	// Fields
	public object key; // 0x0
	public object val; // 0x8
	public int hash_coll; // 0x10

}

private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 1391
{	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x14648D0 Offset: 0x1462ED0 VA: 0x1814648D0 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1464AC0 Offset: 0x14630C0 VA: 0x181464AC0 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580 Slot: 11
	public virtual int get_Count() { }

}

private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 1392
{	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x146D610 Offset: 0x146BC10 VA: 0x18146D610 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146D810 Offset: 0x146BE10 VA: 0x18146D810 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC8AC0 Offset: 0xBC70C0 VA: 0x180BC8AC0 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580 Slot: 11
	public virtual int get_Count() { }

}

private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 1393
{	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }

	// Methods

	// RVA: 0x146BDD0 Offset: 0x146A3D0 VA: 0x18146BDD0
	internal void .ctor(Hashtable table) { }

	// RVA: 0x146BE00 Offset: 0x146A400 VA: 0x18146BE00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146BB60 Offset: 0x146A160 VA: 0x18146BB60 Slot: 38
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146BFA0 Offset: 0x146A5A0 VA: 0x18146BFA0 Slot: 37
	public override int get_Count() { }

	// RVA: 0x146BFD0 Offset: 0x146A5D0 VA: 0x18146BFD0 Slot: 31
	public override bool get_IsReadOnly() { }

	// RVA: 0x146C000 Offset: 0x146A600 VA: 0x18146C000 Slot: 27
	public override object get_Item(object key) { }

	// RVA: 0x146C260 Offset: 0x146A860 VA: 0x18146C260 Slot: 28
	public override void set_Item(object key, object value) { }

	// RVA: 0x146C130 Offset: 0x146A730 VA: 0x18146C130 Slot: 36
	public override object get_SyncRoot() { }

	// RVA: 0x146B580 Offset: 0x1469B80 VA: 0x18146B580 Slot: 21
	public override void Add(object key, object value) { }

	// RVA: 0x146B680 Offset: 0x1469C80 VA: 0x18146B680 Slot: 22
	public override void Clear() { }

	// RVA: 0x146BA00 Offset: 0x146A000 VA: 0x18146BA00 Slot: 24
	public override bool Contains(object key) { }

	// RVA: 0x146B950 Offset: 0x1469F50 VA: 0x18146B950 Slot: 25
	public override bool ContainsKey(object key) { }

	// RVA: 0x146BA30 Offset: 0x146A030 VA: 0x18146BA30 Slot: 26
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146B760 Offset: 0x1469D60 VA: 0x18146B760 Slot: 23
	public override object Clone() { }

	// RVA: 0x146BB30 Offset: 0x146A130 VA: 0x18146BB30 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x146BB30 Offset: 0x146A130 VA: 0x18146BB30 Slot: 29
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x146C030 Offset: 0x146A630 VA: 0x18146C030 Slot: 33
	public override ICollection get_Keys() { }

	// RVA: 0x146C160 Offset: 0x146A760 VA: 0x18146C160 Slot: 34
	public override ICollection get_Values() { }

	// RVA: 0x146BCE0 Offset: 0x146A2E0 VA: 0x18146BCE0 Slot: 35
	public override void Remove(object key) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 39
	public override void OnDeserialization(object sender) { }

}

private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1394
{	// Fields
	private Hashtable hashtable; // 0x10
	private int bucket; // 0x18
	private int version; // 0x1C
	private bool current; // 0x20
	private int getObjectRetType; // 0x24
	private object currentKey; // 0x28
	private object currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x145FDB0 Offset: 0x145E3B0 VA: 0x18145FDB0
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 10
	public object Clone() { }

	// RVA: 0x145FFD0 Offset: 0x145E5D0 VA: 0x18145FFD0 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x145FB60 Offset: 0x145E160 VA: 0x18145FB60 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x145FF20 Offset: 0x145E520 VA: 0x18145FF20 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x145FE20 Offset: 0x145E420 VA: 0x18145FE20 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1460050 Offset: 0x145E650 VA: 0x181460050 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x145FCD0 Offset: 0x145E2D0 VA: 0x18145FCD0 Slot: 16
	public virtual void Reset() { }

}

