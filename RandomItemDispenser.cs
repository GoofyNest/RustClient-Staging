public class RandomItemDispenser : PrefabAttribute, IServerComponent // TypeDefIndex: 11378
{
	public RandomItemDispenser.RandomItemChance[] Chances; 
	public bool OnlyAwardOne; 


	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct RandomItemDispenser.RandomItemChance // TypeDefIndex: 11379
{
	public ItemDefinition Item; 
	public int Amount; 
	[RangeAttribute] 
	public float Chance; 

}

