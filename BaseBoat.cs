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

	// RVA: 0x7A1CD0 Offset: 0x7A02D0 VA: 0x1807A1CD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A2390 Offset: 0x7A0990 VA: 0x1807A2390 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A21C0 Offset: 0x7A07C0 VA: 0x1807A21C0
	public bool InDryDock() { }

	// RVA: 0x7A2230 Offset: 0x7A0830 VA: 0x1807A2230 Slot: 112
	public override float MaxVelocity() { }

	[BaseEntity.Menu] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[BaseEntity.Menu.Description] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[BaseEntity.Menu.Icon] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	// RVA: 0x7A2240 Offset: 0x7A0840 VA: 0x1807A2240 Slot: 194
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0x7A1C10 Offset: 0x7A0210 VA: 0x1807A1C10 Slot: 195
	public virtual bool EngineInWater() { }

	// RVA: 0x7A2280 Offset: 0x7A0880 VA: 0x1807A2280 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x7A1FF0 Offset: 0x7A05F0 VA: 0x1807A1FF0
	public static float GetWaterDepth(Vector3 pos) { }

	// RVA: 0x7A2370 Offset: 0x7A0970 VA: 0x1807A2370
	public void .ctor() { }

}

