internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 499
{	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0xFF5050 Offset: 0xFF3650 VA: 0x180FF5050
	internal void .ctor(string fileName) { }

	// RVA: 0xFF4F50 Offset: 0xFF3550 VA: 0x180FF4F50
	internal void .ctor(Stream stream) { }

	// RVA: 0xFF4050 Offset: 0xFF2650 VA: 0x180FF4050 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFF4260 Offset: 0xFF2860 VA: 0x180FF4260 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF4260 Offset: 0xFF2860 VA: 0x180FF4260 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF41C0 Offset: 0xFF27C0 VA: 0x180FF41C0
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFF4CE0 Offset: 0xFF32E0 VA: 0x180FF4CE0 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0xFF4C50 Offset: 0xFF3250 VA: 0x180FF4C50 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0xFF4270 Offset: 0xFF2870 VA: 0x180FF4270 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0xFF4290 Offset: 0xFF2890 VA: 0x180FF4290 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0xFF42B0 Offset: 0xFF28B0 VA: 0x180FF42B0
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0xFF4D60 Offset: 0xFF3360 VA: 0x180FF4D60
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

}

