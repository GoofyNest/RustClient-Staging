public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent // TypeDefIndex: 9440
{	// Fields
	public float[] InOutLookup; // 0x98
	public float[] RadialLookup; // 0xA0
	public float[] RippleLookup; // 0xA8
	public float[] CheckerLookup; // 0xB0
	public float[] BlockLookup; // 0xB8
	public Gradient[] ColourGradients; // 0xC0

	// Methods

	// RVA: 0x987690 Offset: 0x985C90 VA: 0x180987690
	public float[] GetLookup(DiscoFloorMesh.PatternType pattern) { }

	// RVA: 0x987590 Offset: 0x985B90 VA: 0x180987590
	public Gradient GetColourGradient(int index) { }

	// RVA: 0x987630 Offset: 0x985C30 VA: 0x180987630 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9876D0 Offset: 0x985CD0 VA: 0x1809876D0
	public void .ctor() { }

}

