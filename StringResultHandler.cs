internal class StringResultHandler : SearchResultHandler<string> // TypeDefIndex: 630
{	// Fields
	private bool _includeFiles; // 0x10
	private bool _includeDirs; // 0x11

	// Methods

	// RVA: 0x16219D0 Offset: 0x161FFD0 VA: 0x1816219D0
	internal void .ctor(bool includeFiles, bool includeDirs) { }

	// RVA: 0x1621900 Offset: 0x161FF00 VA: 0x181621900 Slot: 4
	internal override bool IsResultIncluded(SearchResult result) { }

	// RVA: 0x9573C0 Offset: 0x9559C0 VA: 0x1809573C0 Slot: 5
	internal override string CreateObject(SearchResult result) { }

}

