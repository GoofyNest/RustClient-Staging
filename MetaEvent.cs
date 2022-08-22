public abstract class MetaEvent : MidiEvent // TypeDefIndex: 7516
{	// Methods

	// RVA: 0x139B260 Offset: 0x1399860 VA: 0x18139B260
	protected void .ctor() { }

	// RVA: 0x1395490 Offset: 0x1393A90 VA: 0x181395490
	internal void .ctor(MidiEventType eventType) { }

	// RVA: 0x139B240 Offset: 0x1399840 VA: 0x18139B240 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, int size);

}

