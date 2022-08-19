public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 497
{	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0xFF3D30 Offset: 0xFF2330 VA: 0x180FF3D30
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(bool junk) { }

	// RVA: 0xFF32F0 Offset: 0xFF18F0 VA: 0x180FF32F0
	private void CommonInit() { }

	// RVA: 0xFF3350 Offset: 0xFF1950 VA: 0x180FF3350 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10 Slot: 4
	public void Dispose() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0xFF3750 Offset: 0xFF1D50 VA: 0x180FF3750 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF3750 Offset: 0xFF1D50 VA: 0x180FF3750 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF36C0 Offset: 0xFF1CC0 VA: 0x180FF36C0
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFF3920 Offset: 0xFF1F20 VA: 0x180FF3920 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFF3AC0 Offset: 0xFF20C0 VA: 0x180FF3AC0 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0xFF3760 Offset: 0xFF1D60 VA: 0x180FF3760 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0xFF3830 Offset: 0xFF1E30 VA: 0x180FF3830 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0xFF3760 Offset: 0xFF1D60 VA: 0x180FF3760
	private object GetObjectInternal(string name) { }

	// RVA: 0xFF33F0 Offset: 0xFF19F0 VA: 0x180FF33F0
	private object GetCaseInsensitiveObjectInternal(string name) { }

}

