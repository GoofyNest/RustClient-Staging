public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 497
{	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0xFF4A90 Offset: 0xFF3090 VA: 0x180FF4A90
	protected void .ctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor(bool junk) { }

	// RVA: 0xFF4050 Offset: 0xFF2650 VA: 0x180FF4050
	private void CommonInit() { }

	// RVA: 0xFF40B0 Offset: 0xFF26B0 VA: 0x180FF40B0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970 Slot: 4
	public void Dispose() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0xFF44B0 Offset: 0xFF2AB0 VA: 0x180FF44B0 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF44B0 Offset: 0xFF2AB0 VA: 0x180FF44B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF4420 Offset: 0xFF2A20 VA: 0x180FF4420
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFF4680 Offset: 0xFF2C80 VA: 0x180FF4680 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFF4820 Offset: 0xFF2E20 VA: 0x180FF4820 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0xFF44C0 Offset: 0xFF2AC0 VA: 0x180FF44C0 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0xFF4590 Offset: 0xFF2B90 VA: 0x180FF4590 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0xFF44C0 Offset: 0xFF2AC0 VA: 0x180FF44C0
	private object GetObjectInternal(string name) { }

	// RVA: 0xFF4150 Offset: 0xFF2750 VA: 0x180FF4150
	private object GetCaseInsensitiveObjectInternal(string name) { }

}

