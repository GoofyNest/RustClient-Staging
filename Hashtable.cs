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

	// RVA: 0x1461810 Offset: 0x145FE10 VA: 0x181461810
	public void .ctor() { }

	// RVA: 0x1461980 Offset: 0x145FF80 VA: 0x181461980
	public void .ctor(int capacity) { }

	// RVA: 0x1461990 Offset: 0x145FF90 VA: 0x181461990
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xE7790 Offset: 0xE6B90 VA: 0x1800E7790
	// RVA: 0x1461C10 Offset: 0x1460210 VA: 0x181461C10
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x14618C0 Offset: 0x145FEC0 VA: 0x1814618C0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xE7800 Offset: 0xE6C00 VA: 0x1800E7800
	// RVA: 0x1461CE0 Offset: 0x14602E0 VA: 0x181461CE0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1461900 Offset: 0x145FF00 VA: 0x181461900
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1461940 Offset: 0x145FF40 VA: 0x181461940
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1461830 Offset: 0x145FE30 VA: 0x181461830
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14603D0 Offset: 0x145E9D0 VA: 0x1814603D0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x145F460 Offset: 0x145DA60 VA: 0x18145F460 Slot: 21
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x145F480 Offset: 0x145DA80 VA: 0x18145F480 Slot: 22
	public virtual void Clear() { }

	// RVA: 0x145F5D0 Offset: 0x145DBD0 VA: 0x18145F5D0 Slot: 23
	public virtual object Clone() { }

	// RVA: 0x145F8A0 Offset: 0x145DEA0 VA: 0x18145F8A0 Slot: 24
	public virtual bool Contains(object key) { }

	// RVA: 0x145F6F0 Offset: 0x145DCF0 VA: 0x18145F6F0 Slot: 25
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x145F9E0 Offset: 0x145DFE0 VA: 0x18145F9E0
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x145F8C0 Offset: 0x145DEC0 VA: 0x18145F8C0
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x145FA80 Offset: 0x145E080 VA: 0x18145FA80 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x145FCF0 Offset: 0x145E2F0 VA: 0x18145FCF0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1461E80 Offset: 0x1460480 VA: 0x181461E80 Slot: 27
	public virtual object get_Item(object key) { }

	// RVA: 0x1462550 Offset: 0x1460B50 VA: 0x181462550 Slot: 28
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1461DA0 Offset: 0x14603A0 VA: 0x181461DA0
	private void expand() { }

	// RVA: 0x1462370 Offset: 0x1460970 VA: 0x181462370
	private void rehash() { }

	// RVA: 0x14617E0 Offset: 0x145FDE0 VA: 0x1814617E0
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x14623A0 Offset: 0x14609A0 VA: 0x1814623A0
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1461750 Offset: 0x145FD50 VA: 0x181461750 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x145FD90 Offset: 0x145E390 VA: 0x18145FD90 Slot: 29
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x145FE20 Offset: 0x145E420 VA: 0x18145FE20 Slot: 30
	protected virtual int GetHash(object key) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 31
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1460A80 Offset: 0x145F080 VA: 0x181460A80 Slot: 32
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x14620A0 Offset: 0x14606A0 VA: 0x1814620A0 Slot: 33
	public virtual ICollection get_Keys() { }

	// RVA: 0x14621A0 Offset: 0x14607A0 VA: 0x1814621A0 Slot: 34
	public virtual ICollection get_Values() { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x1460420 Offset: 0x145EA20 VA: 0x181460420
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1462230 Offset: 0x1460830 VA: 0x181462230
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x14613D0 Offset: 0x145F9D0 VA: 0x1814613D0 Slot: 35
	public virtual void Remove(object key) { }

	// RVA: 0x1462130 Offset: 0x1460730 VA: 0x181462130 Slot: 36
	public virtual object get_SyncRoot() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 37
	public virtual int get_Count() { }

	// RVA: 0x14616B0 Offset: 0x145FCB0 VA: 0x1814616B0
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x145FEA0 Offset: 0x145E4A0 VA: 0x18145FEA0 Slot: 38
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1460BA0 Offset: 0x145F1A0 VA: 0x181460BA0 Slot: 39
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

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x1463C60 Offset: 0x1462260 VA: 0x181463C60 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1463E50 Offset: 0x1462450 VA: 0x181463E50 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30 Slot: 11
	public virtual int get_Count() { }

}

private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 1392
{	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x146C9A0 Offset: 0x146AFA0 VA: 0x18146C9A0 Slot: 8
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146CBA0 Offset: 0x146B1A0 VA: 0x18146CBA0 Slot: 9
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xBC9250 Offset: 0xBC7850 VA: 0x180BC9250 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30 Slot: 11
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

	// RVA: 0x146B160 Offset: 0x1469760 VA: 0x18146B160
	internal void .ctor(Hashtable table) { }

	// RVA: 0x146B190 Offset: 0x1469790 VA: 0x18146B190
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146AEF0 Offset: 0x14694F0 VA: 0x18146AEF0 Slot: 38
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146B330 Offset: 0x1469930 VA: 0x18146B330 Slot: 37
	public override int get_Count() { }

	// RVA: 0x146B360 Offset: 0x1469960 VA: 0x18146B360 Slot: 31
	public override bool get_IsReadOnly() { }

	// RVA: 0x146B390 Offset: 0x1469990 VA: 0x18146B390 Slot: 27
	public override object get_Item(object key) { }

	// RVA: 0x146B5F0 Offset: 0x1469BF0 VA: 0x18146B5F0 Slot: 28
	public override void set_Item(object key, object value) { }

	// RVA: 0x146B4C0 Offset: 0x1469AC0 VA: 0x18146B4C0 Slot: 36
	public override object get_SyncRoot() { }

	// RVA: 0x146A910 Offset: 0x1468F10 VA: 0x18146A910 Slot: 21
	public override void Add(object key, object value) { }

	// RVA: 0x146AA10 Offset: 0x1469010 VA: 0x18146AA10 Slot: 22
	public override void Clear() { }

	// RVA: 0x146AD90 Offset: 0x1469390 VA: 0x18146AD90 Slot: 24
	public override bool Contains(object key) { }

	// RVA: 0x146ACE0 Offset: 0x14692E0 VA: 0x18146ACE0 Slot: 25
	public override bool ContainsKey(object key) { }

	// RVA: 0x146ADC0 Offset: 0x14693C0 VA: 0x18146ADC0 Slot: 26
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x146AAF0 Offset: 0x14690F0 VA: 0x18146AAF0 Slot: 23
	public override object Clone() { }

	// RVA: 0x146AEC0 Offset: 0x14694C0 VA: 0x18146AEC0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x146AEC0 Offset: 0x14694C0 VA: 0x18146AEC0 Slot: 29
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x146B3C0 Offset: 0x14699C0 VA: 0x18146B3C0 Slot: 33
	public override ICollection get_Keys() { }

	// RVA: 0x146B4F0 Offset: 0x1469AF0 VA: 0x18146B4F0 Slot: 34
	public override ICollection get_Values() { }

	// RVA: 0x146B070 Offset: 0x1469670 VA: 0x18146B070 Slot: 35
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

	// RVA: 0x145F140 Offset: 0x145D740 VA: 0x18145F140
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 10
	public object Clone() { }

	// RVA: 0x145F360 Offset: 0x145D960 VA: 0x18145F360 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x145EEF0 Offset: 0x145D4F0 VA: 0x18145EEF0 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x145F2B0 Offset: 0x145D8B0 VA: 0x18145F2B0 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x145F1B0 Offset: 0x145D7B0 VA: 0x18145F1B0 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x145F3E0 Offset: 0x145D9E0 VA: 0x18145F3E0 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x145F060 Offset: 0x145D660 VA: 0x18145F060 Slot: 16
	public virtual void Reset() { }

}

