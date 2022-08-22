public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 497
{	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20


	protected void .ctor() { }

	internal void .ctor(bool junk) { }

	private void CommonInit() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual IDictionaryEnumerator GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private IDictionaryEnumerator GetEnumeratorHelper() { }

	public virtual string GetString(string name) { }

	public virtual string GetString(string name, bool ignoreCase) { }

	public virtual object GetObject(string name) { }

	public virtual object GetObject(string name, bool ignoreCase) { }

	private object GetObjectInternal(string name) { }

	private object GetCaseInsensitiveObjectInternal(string name) { }

}

