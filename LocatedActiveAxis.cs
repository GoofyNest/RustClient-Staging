internal class LocatedActiveAxis : ActiveAxis // TypeDefIndex: 2146
{	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Properties
	internal int Column { get; }

	// Methods

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal int get_Column() { }

	// RVA: 0xB11550 Offset: 0xB0FB50 VA: 0x180B11550
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0xB11520 Offset: 0xB0FB20 VA: 0x180B11520
	internal void Reactivate(KeySequence ks) { }

}
