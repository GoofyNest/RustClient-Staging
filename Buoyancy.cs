public class Buoyancy : ListComponent<Buoyancy>, IServerComponent // TypeDefIndex: 9701
{	// Fields
	public BuoyancyPoint[] points; // 0x18
	public GameObjectRef[] waterImpacts; // 0x20
	public Rigidbody rigidBody; // 0x28
	public float buoyancyScale; // 0x30
	public bool doEffects; // 0x34
	public float flowMovementScale; // 0x38
	public float requiredSubmergedFraction; // 0x3C
	public bool useUnderwaterDrag; // 0x40
	[RangeAttribute] // RVA: 0x84490 Offset: 0x83890 VA: 0x180084490
	public float underwaterDrag; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <timeOutOfWater>k__BackingField; // 0x48
	public Action<bool> SubmergedChanged; // 0x50
	public BaseEntity forEntity; // 0x58
	public float submergedFraction; // 0x60

	// Properties
	public float timeOutOfWater { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6F0650 Offset: 0x6EEC50 VA: 0x1806F0650
	public float get_timeOutOfWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6F0660 Offset: 0x6EEC60 VA: 0x1806F0660
	private void set_timeOutOfWater(float value) { }

	// RVA: 0x6F05E0 Offset: 0x6EEBE0 VA: 0x1806F05E0
	public void .ctor() { }

}

