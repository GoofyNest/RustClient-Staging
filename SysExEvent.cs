public abstract class SysExEvent : MidiEvent // TypeDefIndex: 7519
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private byte[] <Data>k__BackingField; // 0x20

	// Properties
	public byte[] Data { get; set; }

	// Methods

	// RVA: 0x13960D0 Offset: 0x13946D0 VA: 0x1813960D0
	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Data(byte[] value) { }

	// RVA: 0x13A8790 Offset: 0x13A6D90 VA: 0x1813A8790 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

