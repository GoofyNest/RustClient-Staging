public class RepairBench : StorageContainer // TypeDefIndex: 8633
{	// Fields
	public float maxConditionLostOnRepair; // 0x3D0
	public GameObjectRef skinchangeEffect; // 0x3D8
	public const float REPAIR_COST_FRACTION = 0,2;

	// Methods

	// RVA: 0x9532A0 Offset: 0x9518A0 VA: 0x1809532A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9533D0 Offset: 0x9519D0 VA: 0x1809533D0
	public void TryRepair() { }

	// RVA: 0x952CB0 Offset: 0x9512B0 VA: 0x180952CB0
	public void ChangeSkinTo(int id) { }

	// RVA: 0x953270 Offset: 0x951870 VA: 0x180953270
	public static float GetRepairFraction(Item itemToRepair) { }

	// RVA: 0x953390 Offset: 0x951990 VA: 0x180953390
	public static float RepairCostFraction(Item itemToRepair) { }

	// RVA: 0x952D00 Offset: 0x951300 VA: 0x180952D00
	public static void GetRepairCostList(ItemBlueprint bp, List<ItemAmount> allIngredients) { }

	// RVA: 0x953410 Offset: 0x951A10 VA: 0x180953410
	public void .ctor() { }

}

