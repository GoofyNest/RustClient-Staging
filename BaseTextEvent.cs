public abstract class BaseTextEvent : MetaEvent // TypeDefIndex: 7531
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Text>k__BackingField; // 0x20

	// Properties
	public string Text { get; set; }

	// Methods

	// RVA: 0x1395490 Offset: 0x1393A90 VA: 0x181395490
	public void .ctor(MidiEventType eventType) { }

	// RVA: 0x13954C0 Offset: 0x1393AC0 VA: 0x1813954C0
	public void .ctor(MidiEventType eventType, string text) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Text(string value) { }

	// RVA: 0x1395350 Offset: 0x1393950 VA: 0x181395350 Slot: 6
	protected sealed override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

}

