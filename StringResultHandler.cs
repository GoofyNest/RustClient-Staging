internal class StringResultHandler : SearchResultHandler<string> // TypeDefIndex: 630
{	// Fields
	private bool _includeFiles; // 0x10
	private bool _includeDirs; // 0x11

	// Methods

	// RVA: 0x16343F0 Offset: 0x16329F0 VA: 0x1816343F0
	internal void .ctor(bool includeFiles, bool includeDirs) { }

	// RVA: 0x1634320 Offset: 0x1632920 VA: 0x181634320 Slot: 4
	internal override bool IsResultIncluded(SearchResult result) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0 Slot: 5
	internal override string CreateObject(SearchResult result) { }

}

