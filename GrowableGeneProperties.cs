public class GrowableGeneProperties : ScriptableObject // TypeDefIndex: 9543
{	// Fields
	[ArrayIndexIsEnum] // RVA: 0x76D20 Offset: 0x76120 VA: 0x180076D20
	public GrowableGeneProperties.GeneWeight[] Weights; // 0x18

	// Methods

	// RVA: 0x730AF0 Offset: 0x72F0F0 VA: 0x180730AF0
	public void .ctor() { }

}

public struct GrowableGeneProperties.GeneWeight // TypeDefIndex: 9544
{	// Fields
	public float BaseWeight; // 0x0
	public float[] SlotWeights; // 0x8
	public float CrossBreedingWeight; // 0x10

}

