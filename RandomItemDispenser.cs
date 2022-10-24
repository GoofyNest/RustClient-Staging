public class RandomItemDispenser : PrefabAttribute, IServerComponent // TypeDefIndex: 11399
{
	public RandomItemDispenser.RandomItemChance[] Chances; 
	public bool OnlyAwardOne; 


	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct RandomItemDispenser.RandomItemChance // TypeDefIndex: 11400
{
	public ItemDefinition Item; 
	public int Amount; 
	[RangeAttribute] 
	public float Chance; 

}

