internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 1138
{	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0xFE52B0 Offset: 0xFE38B0 VA: 0x180FE52B0
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0xFE51C0 Offset: 0xFE37C0 VA: 0x180FE51C0
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0xFE1830 Offset: 0xFDFE30 VA: 0x180FE1830
	private bool CheckPath(string path) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0xFE1CC0 Offset: 0xFE02C0 VA: 0x180FE1CC0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE1DF0 Offset: 0xFE03F0 VA: 0x180FE1DF0
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE1AD0 Offset: 0xFE00D0 VA: 0x180FE1AD0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0xFE3F90 Offset: 0xFE2590 VA: 0x180FE3F90
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE45A0 Offset: 0xFE2BA0 VA: 0x180FE45A0
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3470 Offset: 0xFE1A70 VA: 0x180FE3470
	private TimeSpan ParseTime(string s) { }

	// RVA: 0xFE3800 Offset: 0xFE1E00 VA: 0x180FE3800
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFE4A60 Offset: 0xFE3060 VA: 0x180FE4A60
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFE3C90 Offset: 0xFE2290 VA: 0x180FE3C90
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE4E80 Offset: 0xFE3480 VA: 0x180FE4E80
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3EB0 Offset: 0xFE24B0 VA: 0x180FE3EB0
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE5030 Offset: 0xFE3630 VA: 0x180FE5030
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE4390 Offset: 0xFE2990 VA: 0x180FE4390
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0xFE48B0 Offset: 0xFE2EB0 VA: 0x180FE48B0
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE1A10 Offset: 0xFE0010 VA: 0x180FE1A10
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0xFE1930 Offset: 0xFDFF30 VA: 0x180FE1930
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0xFE1B80 Offset: 0xFE0180 VA: 0x180FE1B80 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

