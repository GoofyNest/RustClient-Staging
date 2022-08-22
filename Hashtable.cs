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

	// RVA: 0x1462740 Offset: 0x1460D40 VA: 0x181462740
	public void .ctor() { }

	// RVA: 0x14628B0 Offset: 0x1460EB0 VA: 0x1814628B0
	public void .ctor(int capacity) { }

	// RVA: 0x14628C0 Offset: 0x1460EC0 VA: 0x1814628C0
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xE7790 Offset: 0xE6B90 VA: 0x1800E7790
	// RVA: 0x1462B40 Offset: 0x1461140 VA: 0x181462B40
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x14627F0 Offset: 0x1460DF0 VA: 0x1814627F0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	// RVA: 0x1462C10 Offset: 0x1461210 VA: 0x181462C10
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1462830 Offset: 0x1460E30 VA: 0x181462830
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1462870 Offset: 0x1460E70 VA: 0x181462870
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1462760 Offset: 0x1460D60 VA: 0x181462760
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1461300 Offset: 0x145F900 VA: 0x181461300
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1460390 Offset: 0x145E990 VA: 0x181460390 Slot: 21
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x14603B0 Offset: 0x145E9B0 VA: 0x1814603B0 Slot: 22
	public virtual void Clear() { }

	// RVA: 0x1460500 Offset: 0x145EB00 VA: 0x181460500 Slot: 23
	public virtual object Clone() { }

	// RVA: 0x14607D0 Offset: 0x145EDD0 VA: 0x1814607D0 Slot: 24
	public virtual bool Contains(object key) { }

	// RVA: 0x1460620 Offset: 0x145EC20 VA: 0x181460620 Slot: 25
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1460910 Offset: 0x145EF10 VA: 0x181460910
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x14607F0 Offset: 0x145EDF0 VA: 0x1814607F0
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x14609B0 Offset: 0x145EFB0 VA: 0x1814609B0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1460C20 Offset: 0x145F220 VA: 0x181460C20
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1462DB0 Offset: 0x14613B0 VA: 0x181462DB0 Slot: 27
	public virtual object get_Item(object key) { }

	// RVA: 0x1463480 Offset: 0x1461A80 VA: 0x181463480 Slot: 28
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1462CD0 Offset: 0x14612D0 VA: 0x181462CD0
	private void expand() { }

	// RVA: 0x14632A0 Offset: 0x14618A0 VA: 0x1814632A0
	private void rehash() { }

	// RVA: 0x1462710 Offset: 0x1460D10 VA: 0x181462710
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x14632D0 Offset: 0x14618D0 VA: 0x1814632D0
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1462680 Offset: 0x1460C80 VA: 0x181462680 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1460CC0 Offset: 0x145F2C0 VA: 0x181460CC0 Slot: 29
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1460D50 Offset: 0x145F350 VA: 0x181460D50 Slot: 30
	protected virtual int GetHash(object key) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 31
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x14619B0 Offset: 0x145FFB0 VA: 0x1814619B0 Slot: 32
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1462FD0 Offset: 0x14615D0 VA: 0x181462FD0 Slot: 33
	public virtual ICollection get_Keys() { }

	// RVA: 0x14630D0 Offset: 0x14616D0 VA: 0x1814630D0 Slot: 34
	public virtual ICollection get_Values() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1461350 Offset: 0x145F950 VA: 0x181461350
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1463160 Offset: 0x1461760 VA: 0x181463160
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1462300 Offset: 0x1460900 VA: 0x181462300 Slot: 35
	public virtual void Remove(object key) { }

	// RVA: 0x1463060 Offset: 0x1461660 VA: 0x181463060 Slot: 36
	public virtual object get_SyncRoot() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 37
	public virtual int get_Count() { }

	// RVA: 0x14625E0 Offset: 0x1460BE0 VA: 0x1814625E0
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1460DD0 Offset: 0x145F3D0 VA: 0x181460DD0 Slot: 38
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1461AD0 Offset: 0x14600D0 VA: 0x181461AD0 Slot: 39
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

	// RVA: 0x1464B90 Offset: 0x1463190 VA: 0x181464B90 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1464D80 Offset: 0x1463380 VA: 0x181464D80 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840 Slot: 11
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

	// RVA: 0x146D8D0 Offset: 0x146BED0 VA: 0x18146D8D0 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146DAD0 Offset: 0x146C0D0 VA: 0x18146DAD0 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC8D80 Offset: 0xBC7380 VA: 0x180BC8D80 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840 Slot: 11
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

	// RVA: 0x146C090 Offset: 0x146A690 VA: 0x18146C090
	internal void .ctor(Hashtable table) { }

	// RVA: 0x146C0C0 Offset: 0x146A6C0 VA: 0x18146C0C0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146BE20 Offset: 0x146A420 VA: 0x18146BE20 Slot: 38
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146C260 Offset: 0x146A860 VA: 0x18146C260 Slot: 37
	public override int get_Count() { }

	// RVA: 0x146C290 Offset: 0x146A890 VA: 0x18146C290 Slot: 31
	public override bool get_IsReadOnly() { }

	// RVA: 0x146C2C0 Offset: 0x146A8C0 VA: 0x18146C2C0 Slot: 27
	public override object get_Item(object key) { }

	// RVA: 0x146C520 Offset: 0x146AB20 VA: 0x18146C520 Slot: 28
	public override void set_Item(object key, object value) { }

	// RVA: 0x146C3F0 Offset: 0x146A9F0 VA: 0x18146C3F0 Slot: 36
	public override object get_SyncRoot() { }

	// RVA: 0x146B840 Offset: 0x1469E40 VA: 0x18146B840 Slot: 21
	public override void Add(object key, object value) { }

	// RVA: 0x146B940 Offset: 0x1469F40 VA: 0x18146B940 Slot: 22
	public override void Clear() { }

	// RVA: 0x146BCC0 Offset: 0x146A2C0 VA: 0x18146BCC0 Slot: 24
	public override bool Contains(object key) { }

	// RVA: 0x146BC10 Offset: 0x146A210 VA: 0x18146BC10 Slot: 25
	public override bool ContainsKey(object key) { }

	// RVA: 0x146BCF0 Offset: 0x146A2F0 VA: 0x18146BCF0 Slot: 26
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146BA20 Offset: 0x146A020 VA: 0x18146BA20 Slot: 23
	public override object Clone() { }

	// RVA: 0x146BDF0 Offset: 0x146A3F0 VA: 0x18146BDF0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x146BDF0 Offset: 0x146A3F0 VA: 0x18146BDF0 Slot: 29
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x146C2F0 Offset: 0x146A8F0 VA: 0x18146C2F0 Slot: 33
	public override ICollection get_Keys() { }

	// RVA: 0x146C420 Offset: 0x146AA20 VA: 0x18146C420 Slot: 34
	public override ICollection get_Values() { }

	// RVA: 0x146BFA0 Offset: 0x146A5A0 VA: 0x18146BFA0 Slot: 35
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

	// RVA: 0x1460070 Offset: 0x145E670 VA: 0x181460070
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 10
	public object Clone() { }

	// RVA: 0x1460290 Offset: 0x145E890 VA: 0x181460290 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x145FE20 Offset: 0x145E420 VA: 0x18145FE20 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x14601E0 Offset: 0x145E7E0 VA: 0x1814601E0 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x14600E0 Offset: 0x145E6E0 VA: 0x1814600E0 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1460310 Offset: 0x145E910 VA: 0x181460310 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x145FF90 Offset: 0x145E590 VA: 0x18145FF90 Slot: 16
	public virtual void Reset() { }

}

