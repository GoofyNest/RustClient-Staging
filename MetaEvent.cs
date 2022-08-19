public abstract class MetaEvent : MidiEvent // TypeDefIndex: 7516
{	// Methods

	// RVA: 0x139BEA0 Offset: 0x139A4A0 VA: 0x18139BEA0
	protected void .ctor() { }

	// RVA: 0x13960D0 Offset: 0x13946D0 VA: 0x1813960D0
	internal void .ctor(MidiEventType eventType) { }

	// RVA: 0x139BE80 Offset: 0x139A480 VA: 0x18139BE80 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, int size);

}

