public abstract class NoteEvent : ChannelEvent // TypeDefIndex: 7543
{
	public SevenBitNumber NoteNumber { get; set; }
	public SevenBitNumber Velocity { get; set; }


	protected void .ctor(MidiEventType eventType) { }

	public SevenBitNumber get_NoteNumber() { }

	public void set_NoteNumber(SevenBitNumber value) { }

	public SevenBitNumber get_Velocity() { }

	public void set_Velocity(SevenBitNumber value) { }

	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

