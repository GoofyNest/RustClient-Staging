public class BaseBoat : BaseVehicle // TypeDefIndex: 8318
{	// Fields
	private Option __menuOption_Menu_Push; // 0x3B8
	public float engineThrust; // 0x410
	public float steeringScale; // 0x414
	public float gasPedal; // 0x418
	public float steering; // 0x41C
	public Transform thrustPoint; // 0x420
	public Transform centerOfMass; // 0x428
	public Buoyancy buoyancy; // 0x430

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7D63B0 Offset: 0x7D49B0 VA: 0x1807D63B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D6A70 Offset: 0x7D5070 VA: 0x1807D6A70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D68A0 Offset: 0x7D4EA0 VA: 0x1807D68A0
	public bool InDryDock() { }

	// RVA: 0x7D6910 Offset: 0x7D4F10 VA: 0x1807D6910 Slot: 112
	public override float MaxVelocity() { }

	[BaseEntity.Menu] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[BaseEntity.Menu.Description] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[BaseEntity.Menu.Icon] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	// RVA: 0x7D6920 Offset: 0x7D4F20 VA: 0x1807D6920 Slot: 194
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0x7D62F0 Offset: 0x7D48F0 VA: 0x1807D62F0 Slot: 195
	public virtual bool EngineInWater() { }

	// RVA: 0x7D6960 Offset: 0x7D4F60 VA: 0x1807D6960 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x7D66D0 Offset: 0x7D4CD0 VA: 0x1807D66D0
	public static float GetWaterDepth(Vector3 pos) { }

	// RVA: 0x7D6A50 Offset: 0x7D5050 VA: 0x1807D6A50
	public void .ctor() { }

}

