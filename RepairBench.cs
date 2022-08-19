public class RepairBench : StorageContainer // TypeDefIndex: 8633
{	// Fields
	public float maxConditionLostOnRepair; // 0x3D0
	public GameObjectRef skinchangeEffect; // 0x3D8
	public const float REPAIR_COST_FRACTION = 0,2;

	// Methods

	// RVA: 0x953190 Offset: 0x951790 VA: 0x180953190 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9532C0 Offset: 0x9518C0 VA: 0x1809532C0
	public void TryRepair() { }

	// RVA: 0x952BA0 Offset: 0x9511A0 VA: 0x180952BA0
	public void ChangeSkinTo(int id) { }

	// RVA: 0x953160 Offset: 0x951760 VA: 0x180953160
	public static float GetRepairFraction(Item itemToRepair) { }

	// RVA: 0x953280 Offset: 0x951880 VA: 0x180953280
	public static float RepairCostFraction(Item itemToRepair) { }

	// RVA: 0x952BF0 Offset: 0x9511F0 VA: 0x180952BF0
	public static void GetRepairCostList(ItemBlueprint bp, List<ItemAmount> allIngredients) { }

	// RVA: 0x953300 Offset: 0x951900 VA: 0x180953300
	public void .ctor() { }

}

