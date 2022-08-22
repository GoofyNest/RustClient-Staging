public abstract class BaseTextEvent : MetaEvent // TypeDefIndex: 7531
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Text>k__BackingField; // 0x20

	public string Text { get; set; }


	public void .ctor(MidiEventType eventType) { }

	public void .ctor(MidiEventType eventType, string text) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Text(string value) { }

	protected sealed override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

}

