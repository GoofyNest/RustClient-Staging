public sealed class UnknownMetaEvent : MetaEvent // TypeDefIndex: 7551
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private readonly byte <StatusByte>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private byte[] <Data>k__BackingField; // 0x28

	public byte StatusByte { get; }
	public byte[] Data { get; set; }


	internal void .ctor(byte statusByte) { }

	internal void .ctor(byte statusByte, byte[] data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public byte get_StatusByte() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Data(byte[] value) { }

	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	protected override MidiEvent CloneEvent() { }

	public override string ToString() { }

}

