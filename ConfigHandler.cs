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

	// RVA: 0xFE4550 Offset: 0xFE2B50 VA: 0x180FE4550
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0xFE4460 Offset: 0xFE2A60 VA: 0x180FE4460
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0xFE0AD0 Offset: 0xFDF0D0 VA: 0x180FE0AD0
	private bool CheckPath(string path) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0xFE0F60 Offset: 0xFDF560 VA: 0x180FE0F60 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE1090 Offset: 0xFDF690 VA: 0x180FE1090
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE0D70 Offset: 0xFDF370 VA: 0x180FE0D70 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0xFE3230 Offset: 0xFE1830 VA: 0x180FE3230
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3840 Offset: 0xFE1E40 VA: 0x180FE3840
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE2710 Offset: 0xFE0D10 VA: 0x180FE2710
	private TimeSpan ParseTime(string s) { }

	// RVA: 0xFE2AA0 Offset: 0xFE10A0 VA: 0x180FE2AA0
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFE3D00 Offset: 0xFE2300 VA: 0x180FE3D00
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0xFE2F30 Offset: 0xFE1530 VA: 0x180FE2F30
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE4120 Offset: 0xFE2720 VA: 0x180FE4120
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3150 Offset: 0xFE1750 VA: 0x180FE3150
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE42D0 Offset: 0xFE28D0 VA: 0x180FE42D0
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE3630 Offset: 0xFE1C30 VA: 0x180FE3630
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0xFE3B50 Offset: 0xFE2150 VA: 0x180FE3B50
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0xFE0CB0 Offset: 0xFDF2B0 VA: 0x180FE0CB0
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0xFE0BD0 Offset: 0xFDF1D0 VA: 0x180FE0BD0
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0xFE0E20 Offset: 0xFDF420 VA: 0x180FE0E20 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }

}

