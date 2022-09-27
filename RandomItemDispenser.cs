public class RandomItemDispenser : PrefabAttribute, IServerComponent // TypeDefIndex: 11381
{
	public RandomItemDispenser.RandomItemChance[] Chances; 
	public bool OnlyAwardOne; 


	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct RandomItemDispenser.RandomItemChance // TypeDefIndex: 11382
{
	public ItemDefinition Item; 
	public int Amount; 
	[RangeAttribute] 
	public float Chance; 

}

