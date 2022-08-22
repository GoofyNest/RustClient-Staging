public class RandomItemDispenser : PrefabAttribute, IServerComponent // TypeDefIndex: 9674
{	// Fields
	public RandomItemDispenser.RandomItemChance[] Chances; // 0x98
	public bool OnlyAwardOne; // 0xA0

	// Methods

	// RVA: 0x6A7840 Offset: 0x6A5E40 VA: 0x1806A7840 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6A78A0 Offset: 0x6A5EA0 VA: 0x1806A78A0
	public void .ctor() { }

}

public struct RandomItemDispenser.RandomItemChance // TypeDefIndex: 9675
{	// Fields
	public ItemDefinition Item; // 0x0
	public int Amount; // 0x8
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Chance; // 0xC

}

