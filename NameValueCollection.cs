public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 3106
{	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }

	// Methods

	// RVA: 0x15CDA20 Offset: 0x15CC020 VA: 0x1815CDA20
	public void .ctor() { }

	// RVA: 0x15CD9A0 Offset: 0x15CBFA0 VA: 0x1815CD9A0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x15CDBE0 Offset: 0x15CC1E0 VA: 0x1815CDBE0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15CD930 Offset: 0x15CBF30 VA: 0x1815CD930
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CD710 Offset: 0x15CBD10 VA: 0x1815CD710
	protected void InvalidateCachedArrays() { }

	// RVA: 0x15CD1B0 Offset: 0x15CB7B0 VA: 0x1815CD1B0
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x15CD390 Offset: 0x15CB990 VA: 0x1815CD390
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x15CD020 Offset: 0x15CB620 VA: 0x1815CD020 Slot: 14
	public virtual void Add(string name, string value) { }

	// RVA: 0x15CD5B0 Offset: 0x15CBBB0 VA: 0x1815CD5B0 Slot: 15
	public virtual string Get(string name) { }

	// RVA: 0x15CD500 Offset: 0x15CBB00 VA: 0x1815CD500 Slot: 16
	public virtual string[] GetValues(string name) { }

	// RVA: 0x15CD7A0 Offset: 0x15CBDA0 VA: 0x1815CD7A0 Slot: 17
	public virtual void Set(string name, string value) { }

	// RVA: 0x15CD750 Offset: 0x15CBD50 VA: 0x1815CD750 Slot: 18
	public virtual void Remove(string name) { }

	// RVA: 0x15CDD70 Offset: 0x15CC370 VA: 0x1815CDD70
	public string get_Item(string name) { }

	// RVA: 0x15CDD90 Offset: 0x15CC390 VA: 0x1815CDD90
	public void set_Item(string name, string value) { }

	// RVA: 0x15CD660 Offset: 0x15CBC60 VA: 0x1815CD660 Slot: 19
	public virtual string Get(int index) { }

	// RVA: 0x15CD450 Offset: 0x15CBA50 VA: 0x1815CD450 Slot: 20
	public virtual string[] GetValues(int index) { }

	// RVA: 0x15CD440 Offset: 0x15CBA40 VA: 0x1815CD440 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x15C4F70 Offset: 0x15C3570 VA: 0x1815C4F70
	public string get_Item(int index) { }

	// RVA: 0x15CDC40 Offset: 0x15CC240 VA: 0x1815CDC40 Slot: 22
	public virtual string[] get_AllKeys() { }

}

