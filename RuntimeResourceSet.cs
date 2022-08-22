internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 499
{	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0xFF5DB0 Offset: 0xFF43B0 VA: 0x180FF5DB0
	internal void .ctor(string fileName) { }

	// RVA: 0xFF5CB0 Offset: 0xFF42B0 VA: 0x180FF5CB0
	internal void .ctor(Stream stream) { }

	// RVA: 0xFF4DB0 Offset: 0xFF33B0 VA: 0x180FF4DB0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFF4FC0 Offset: 0xFF35C0 VA: 0x180FF4FC0 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF4FC0 Offset: 0xFF35C0 VA: 0x180FF4FC0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF4F20 Offset: 0xFF3520 VA: 0x180FF4F20
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFF5A40 Offset: 0xFF4040 VA: 0x180FF5A40 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0xFF59B0 Offset: 0xFF3FB0 VA: 0x180FF59B0 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0xFF4FD0 Offset: 0xFF35D0 VA: 0x180FF4FD0 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0xFF4FF0 Offset: 0xFF35F0 VA: 0x180FF4FF0 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0xFF5010 Offset: 0xFF3610 VA: 0x180FF5010
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0xFF5AC0 Offset: 0xFF40C0 VA: 0x180FF5AC0
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

}

