public class RepairBench : StorageContainer // TypeDefIndex: 8633
{	// Fields
	public float maxConditionLostOnRepair; // 0x3D0
	public GameObjectRef skinchangeEffect; // 0x3D8
	public const float REPAIR_COST_FRACTION = 0,2;

	// Methods

	// RVA: 0x9537A0 Offset: 0x951DA0 VA: 0x1809537A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9538D0 Offset: 0x951ED0 VA: 0x1809538D0
	public void TryRepair() { }

	// RVA: 0x9531B0 Offset: 0x9517B0 VA: 0x1809531B0
	public void ChangeSkinTo(int id) { }

	// RVA: 0x953770 Offset: 0x951D70 VA: 0x180953770
	public static float GetRepairFraction(Item itemToRepair) { }

	// RVA: 0x953890 Offset: 0x951E90 VA: 0x180953890
	public static float RepairCostFraction(Item itemToRepair) { }

	// RVA: 0x953200 Offset: 0x951800 VA: 0x180953200
	public static void GetRepairCostList(ItemBlueprint bp, List<ItemAmount> allIngredients) { }

	// RVA: 0x953910 Offset: 0x951F10 VA: 0x180953910
	public void .ctor() { }

}

