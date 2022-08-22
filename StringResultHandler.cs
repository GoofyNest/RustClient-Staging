internal class StringResultHandler : SearchResultHandler<string> // TypeDefIndex: 630
{	// Fields
	private bool _includeFiles; // 0x10
	private bool _includeDirs; // 0x11

	// Methods

	// RVA: 0x16346B0 Offset: 0x1632CB0 VA: 0x1816346B0
	internal void .ctor(bool includeFiles, bool includeDirs) { }

	// RVA: 0x16345E0 Offset: 0x1632BE0 VA: 0x1816345E0 Slot: 4
	internal override bool IsResultIncluded(SearchResult result) { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0 Slot: 5
	internal override string CreateObject(SearchResult result) { }

}

