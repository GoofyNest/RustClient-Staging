public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 3106
{	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }

	// Methods

	// RVA: 0x15CCDB0 Offset: 0x15CB3B0 VA: 0x1815CCDB0
	public void .ctor() { }

	// RVA: 0x15CCD30 Offset: 0x15CB330 VA: 0x1815CCD30
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x15CCF70 Offset: 0x15CB570 VA: 0x1815CCF70
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x15CCCC0 Offset: 0x15CB2C0 VA: 0x1815CCCC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CCAA0 Offset: 0x15CB0A0 VA: 0x1815CCAA0
	protected void InvalidateCachedArrays() { }

	// RVA: 0x15CC540 Offset: 0x15CAB40 VA: 0x1815CC540
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x15CC720 Offset: 0x15CAD20 VA: 0x1815CC720
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x15CC3B0 Offset: 0x15CA9B0 VA: 0x1815CC3B0 Slot: 14
	public virtual void Add(string name, string value) { }

	// RVA: 0x15CC940 Offset: 0x15CAF40 VA: 0x1815CC940 Slot: 15
	public virtual string Get(string name) { }

	// RVA: 0x15CC890 Offset: 0x15CAE90 VA: 0x1815CC890 Slot: 16
	public virtual string[] GetValues(string name) { }

	// RVA: 0x15CCB30 Offset: 0x15CB130 VA: 0x1815CCB30 Slot: 17
	public virtual void Set(string name, string value) { }

	// RVA: 0x15CCAE0 Offset: 0x15CB0E0 VA: 0x1815CCAE0 Slot: 18
	public virtual void Remove(string name) { }

	// RVA: 0x15CD100 Offset: 0x15CB700 VA: 0x1815CD100
	public string get_Item(string name) { }

	// RVA: 0x15CD120 Offset: 0x15CB720 VA: 0x1815CD120
	public void set_Item(string name, string value) { }

	// RVA: 0x15CC9F0 Offset: 0x15CAFF0 VA: 0x1815CC9F0 Slot: 19
	public virtual string Get(int index) { }

	// RVA: 0x15CC7E0 Offset: 0x15CADE0 VA: 0x1815CC7E0 Slot: 20
	public virtual string[] GetValues(int index) { }

	// RVA: 0x15CC7D0 Offset: 0x15CADD0 VA: 0x1815CC7D0 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x15C4300 Offset: 0x15C2900 VA: 0x1815C4300
	public string get_Item(int index) { }

	// RVA: 0x15CCFD0 Offset: 0x15CB5D0 VA: 0x1815CCFD0 Slot: 22
	public virtual string[] get_AllKeys() { }

}

