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

	// RVA: 0xFE4810 Offset: 0xFE2E10 VA: 0x180FE4810
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0xFE4720 Offset: 0xFE2D20 VA: 0x180FE4720
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0xFE0D90 Offset: 0xFDF390 VA: 0x180FE0D90
	private bool CheckPath(string path) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0xFE1220 Offset: 0xFDF820 VA: 0x180FE1220 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE1350 Offset: 0xFDF950 VA: 0x180FE1350
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE1030 Offset: 0xFDF630 VA: 0x180FE1030 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0xFE34F0 Offset: 0xFE1AF0 VA: 0x180FE34F0
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3B00 Offset: 0xFE2100 VA: 0x180FE3B00
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE29D0 Offset: 0xFE0FD0 VA: 0x180FE29D0
	private TimeSpan ParseTime(string s) { }

	// RVA: 0xFE2D60 Offset: 0xFE1360 VA: 0x180FE2D60
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFE3FC0 Offset: 0xFE25C0 VA: 0x180FE3FC0
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFE31F0 Offset: 0xFE17F0 VA: 0x180FE31F0
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE43E0 Offset: 0xFE29E0 VA: 0x180FE43E0
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3410 Offset: 0xFE1A10 VA: 0x180FE3410
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE4590 Offset: 0xFE2B90 VA: 0x180FE4590
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE38F0 Offset: 0xFE1EF0 VA: 0x180FE38F0
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0xFE3E10 Offset: 0xFE2410 VA: 0x180FE3E10
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE0F70 Offset: 0xFDF570 VA: 0x180FE0F70
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0xFE0E90 Offset: 0xFDF490 VA: 0x180FE0E90
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0xFE10E0 Offset: 0xFDF6E0 VA: 0x180FE10E0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

