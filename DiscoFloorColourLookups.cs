public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent // TypeDefIndex: 9440
{	// Fields
	public float[] InOutLookup; // 0x98
	public float[] RadialLookup; // 0xA0
	public float[] RippleLookup; // 0xA8
	public float[] CheckerLookup; // 0xB0
	public float[] BlockLookup; // 0xB8
	public Gradient[] ColourGradients; // 0xC0

	// Methods

	// RVA: 0x987CA0 Offset: 0x9862A0 VA: 0x180987CA0
	public float[] GetLookup(DiscoFloorMesh.PatternType pattern) { }

	// RVA: 0x987BA0 Offset: 0x9861A0 VA: 0x180987BA0
	public Gradient GetColourGradient(int index) { }

	// RVA: 0x987C40 Offset: 0x986240 VA: 0x180987C40 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x987CE0 Offset: 0x9862E0 VA: 0x180987CE0
	public void .ctor() { }

}

