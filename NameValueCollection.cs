public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 3106
{	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }

	// Methods

	// RVA: 0x15CDCE0 Offset: 0x15CC2E0 VA: 0x1815CDCE0
	public void .ctor() { }

	// RVA: 0x15CDC60 Offset: 0x15CC260 VA: 0x1815CDC60
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x15CDEA0 Offset: 0x15CC4A0 VA: 0x1815CDEA0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15CDBF0 Offset: 0x15CC1F0 VA: 0x1815CDBF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CD9D0 Offset: 0x15CBFD0 VA: 0x1815CD9D0
	protected void InvalidateCachedArrays() { }

	// RVA: 0x15CD470 Offset: 0x15CBA70 VA: 0x1815CD470
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x15CD650 Offset: 0x15CBC50 VA: 0x1815CD650
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x15CD2E0 Offset: 0x15CB8E0 VA: 0x1815CD2E0 Slot: 14
	public virtual void Add(string name, string value) { }

	// RVA: 0x15CD870 Offset: 0x15CBE70 VA: 0x1815CD870 Slot: 15
	public virtual string Get(string name) { }

	// RVA: 0x15CD7C0 Offset: 0x15CBDC0 VA: 0x1815CD7C0 Slot: 16
	public virtual string[] GetValues(string name) { }

	// RVA: 0x15CDA60 Offset: 0x15CC060 VA: 0x1815CDA60 Slot: 17
	public virtual void Set(string name, string value) { }

	// RVA: 0x15CDA10 Offset: 0x15CC010 VA: 0x1815CDA10 Slot: 18
	public virtual void Remove(string name) { }

	// RVA: 0x15CE030 Offset: 0x15CC630 VA: 0x1815CE030
	public string get_Item(string name) { }

	// RVA: 0x15CE050 Offset: 0x15CC650 VA: 0x1815CE050
	public void set_Item(string name, string value) { }

	// RVA: 0x15CD920 Offset: 0x15CBF20 VA: 0x1815CD920 Slot: 19
	public virtual string Get(int index) { }

	// RVA: 0x15CD710 Offset: 0x15CBD10 VA: 0x1815CD710 Slot: 20
	public virtual string[] GetValues(int index) { }

	// RVA: 0x15CD700 Offset: 0x15CBD00 VA: 0x1815CD700 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x15C5230 Offset: 0x15C3830 VA: 0x1815C5230
	public string get_Item(int index) { }

	// RVA: 0x15CDF00 Offset: 0x15CC500 VA: 0x1815CDF00 Slot: 22
	public virtual string[] get_AllKeys() { }

}

