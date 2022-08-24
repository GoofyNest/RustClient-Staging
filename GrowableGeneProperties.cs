public class GrowableGeneProperties : ScriptableObject // TypeDefIndex: 9543
{
	[ArrayIndexIsEnum] 
	public GrowableGeneProperties.GeneWeight[] Weights; 


	public void .ctor() { }

}

public struct GrowableGeneProperties.GeneWeight // TypeDefIndex: 9544
{
	public float BaseWeight; 
	public float[] SlotWeights; 
	public float CrossBreedingWeight; 

}

