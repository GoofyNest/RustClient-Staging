public abstract class SysExEvent : MidiEvent // TypeDefIndex: 7519
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte[] <Data>k__BackingField; // 0x20

	public byte[] Data { get; set; }


	protected void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Data(byte[] value) { }

	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

