public abstract class MetaEvent : MidiEvent // TypeDefIndex: 7516
{	// Methods

	// RVA: 0x139C160 Offset: 0x139A760 VA: 0x18139C160
	protected void .ctor() { }

	// RVA: 0x1396390 Offset: 0x1394990 VA: 0x181396390
	internal void .ctor(MidiEventType eventType) { }

	// RVA: 0x139C140 Offset: 0x139A740 VA: 0x18139C140 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, int size);

}

