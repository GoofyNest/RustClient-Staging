internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 499
{	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0xFF5310 Offset: 0xFF3910 VA: 0x180FF5310
	internal void .ctor(string fileName) { }

	// RVA: 0xFF5210 Offset: 0xFF3810 VA: 0x180FF5210
	internal void .ctor(Stream stream) { }

	// RVA: 0xFF4310 Offset: 0xFF2910 VA: 0x180FF4310 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFF4520 Offset: 0xFF2B20 VA: 0x180FF4520 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF4520 Offset: 0xFF2B20 VA: 0x180FF4520 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF4480 Offset: 0xFF2A80 VA: 0x180FF4480
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFF4FA0 Offset: 0xFF35A0 VA: 0x180FF4FA0 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0xFF4F10 Offset: 0xFF3510 VA: 0x180FF4F10 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0xFF4530 Offset: 0xFF2B30 VA: 0x180FF4530 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0xFF4550 Offset: 0xFF2B50 VA: 0x180FF4550 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0xFF4570 Offset: 0xFF2B70 VA: 0x180FF4570
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0xFF5020 Offset: 0xFF3620 VA: 0x180FF5020
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

}

