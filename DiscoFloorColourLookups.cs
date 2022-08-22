public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent // TypeDefIndex: 9440
{	// Fields
	public float[] InOutLookup; // 0x98
	public float[] RadialLookup; // 0xA0
	public float[] RippleLookup; // 0xA8
	public float[] CheckerLookup; // 0xB0
	public float[] BlockLookup; // 0xB8
	public Gradient[] ColourGradients; // 0xC0

	// Methods

	// RVA: 0x9877A0 Offset: 0x985DA0 VA: 0x1809877A0
	public float[] GetLookup(DiscoFloorMesh.PatternType pattern) { }

	// RVA: 0x9876A0 Offset: 0x985CA0 VA: 0x1809876A0
	public Gradient GetColourGradient(int index) { }

	// RVA: 0x987740 Offset: 0x985D40 VA: 0x180987740 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9877E0 Offset: 0x985DE0 VA: 0x1809877E0
	public void .ctor() { }

}

