public class Buoyancy : ListComponent<Buoyancy>, IServerComponent // TypeDefIndex: 9701
{	public BuoyancyPoint[] points; // 0x18
	public GameObjectRef[] waterImpacts; // 0x20
	public Rigidbody rigidBody; // 0x28
	public float buoyancyScale; // 0x30
	public bool doEffects; // 0x34
	public float flowMovementScale; // 0x38
	public float requiredSubmergedFraction; // 0x3C
	public bool useUnderwaterDrag; // 0x40
	[RangeAttribute] // RVA: 0x84500 Offset: 0x83900 VA: 0x180084500
	public float underwaterDrag; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <timeOutOfWater>k__BackingField; // 0x48
	public Action<bool> SubmergedChanged; // 0x50
	public BaseEntity forEntity; // 0x58
	public float submergedFraction; // 0x60

	public float timeOutOfWater { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_timeOutOfWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_timeOutOfWater(float value) { }

	public void .ctor() { }

}

