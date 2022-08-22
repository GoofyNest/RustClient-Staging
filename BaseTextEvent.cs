public abstract class BaseTextEvent : MetaEvent // TypeDefIndex: 7531
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Text>k__BackingField; // 0x20

	// Properties
	public string Text { get; set; }

	// Methods

	// RVA: 0x1396390 Offset: 0x1394990 VA: 0x181396390
	public void .ctor(MidiEventType eventType) { }

	// RVA: 0x13963C0 Offset: 0x13949C0 VA: 0x1813963C0
	public void .ctor(MidiEventType eventType, string text) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Text(string value) { }

	// RVA: 0x1396250 Offset: 0x1394850 VA: 0x181396250 Slot: 6
	protected sealed override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

}

