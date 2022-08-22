public class GrowableGeneProperties : ScriptableObject // TypeDefIndex: 9543
{	// Fields
	[ArrayIndexIsEnum] // RVA: 0x76E40 Offset: 0x76240 VA: 0x180076E40
	public GrowableGeneProperties.GeneWeight[] Weights; // 0x18

	// Methods

	// RVA: 0x730B50 Offset: 0x72F150 VA: 0x180730B50
	public void .ctor() { }

}

public struct GrowableGeneProperties.GeneWeight // TypeDefIndex: 9544
{	// Fields
	public float BaseWeight; // 0x0
	public float[] SlotWeights; // 0x8
	public float CrossBreedingWeight; // 0x10

}

