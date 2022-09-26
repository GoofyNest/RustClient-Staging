public class GrowableGeneProperties : ScriptableObject // TypeDefIndex: 11247
{
	[ArrayIndexIsEnum] 
	public GrowableGeneProperties.GeneWeight[] Weights; 


	public void .ctor() { }

}

public struct GrowableGeneProperties.GeneWeight // TypeDefIndex: 11248
{
	public float BaseWeight; 
	public float[] SlotWeights; 
	public float CrossBreedingWeight; 

}

