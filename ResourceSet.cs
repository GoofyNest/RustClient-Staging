public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 497
{	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0xFF3FF0 Offset: 0xFF25F0 VA: 0x180FF3FF0
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(bool junk) { }

	// RVA: 0xFF35B0 Offset: 0xFF1BB0 VA: 0x180FF35B0
	private void CommonInit() { }

	// RVA: 0xFF3610 Offset: 0xFF1C10 VA: 0x180FF3610 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFE4ED0 Offset: 0xFE34D0 VA: 0x180FE4ED0 Slot: 4
	public void Dispose() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0xFF3A10 Offset: 0xFF2010 VA: 0x180FF3A10 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF3A10 Offset: 0xFF2010 VA: 0x180FF3A10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF3980 Offset: 0xFF1F80 VA: 0x180FF3980
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFF3BE0 Offset: 0xFF21E0 VA: 0x180FF3BE0 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFF3D80 Offset: 0xFF2380 VA: 0x180FF3D80 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0xFF3A20 Offset: 0xFF2020 VA: 0x180FF3A20 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0xFF3AF0 Offset: 0xFF20F0 VA: 0x180FF3AF0 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0xFF3A20 Offset: 0xFF2020 VA: 0x180FF3A20
	private object GetObjectInternal(string name) { }

	// RVA: 0xFF36B0 Offset: 0xFF1CB0 VA: 0x180FF36B0
	private object GetCaseInsensitiveObjectInternal(string name) { }

}

