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

	// RVA: 0x7D62A0 Offset: 0x7D48A0 VA: 0x1807D62A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D6960 Offset: 0x7D4F60 VA: 0x1807D6960 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D6790 Offset: 0x7D4D90 VA: 0x1807D6790
	public bool InDryDock() { }

	// RVA: 0x7D6800 Offset: 0x7D4E00 VA: 0x1807D6800 Slot: 112
	public override float MaxVelocity() { }

	[BaseEntity.Menu] // RVA: 0xB4970 Offset: 0xB3D70 VA: 0x1800B4970
	[BaseEntity.Menu.Description] // RVA: 0xB4970 Offset: 0xB3D70 VA: 0x1800B4970
	[BaseEntity.Menu.Icon] // RVA: 0xB4970 Offset: 0xB3D70 VA: 0x1800B4970
	[BaseEntity.Menu.ShowIf] // RVA: 0xB4970 Offset: 0xB3D70 VA: 0x1800B4970
	// RVA: 0x7D6810 Offset: 0x7D4E10 VA: 0x1807D6810 Slot: 194
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0x7D61E0 Offset: 0x7D47E0 VA: 0x1807D61E0 Slot: 195
	public virtual bool EngineInWater() { }

	// RVA: 0x7D6850 Offset: 0x7D4E50 VA: 0x1807D6850 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x7D65C0 Offset: 0x7D4BC0 VA: 0x1807D65C0
	public static float GetWaterDepth(Vector3 pos) { }

	// RVA: 0x7D6940 Offset: 0x7D4F40 VA: 0x1807D6940
	public void .ctor() { }

}

