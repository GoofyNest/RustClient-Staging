public class RandomItemDispenser : PrefabAttribute, IServerComponent // TypeDefIndex: 9674
{	public RandomItemDispenser.RandomItemChance[] Chances; // 0x98
	public bool OnlyAwardOne; // 0xA0


	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct RandomItemDispenser.RandomItemChance // TypeDefIndex: 9675
{	public ItemDefinition Item; // 0x0
	public int Amount; // 0x8
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float Chance; // 0xC

}

