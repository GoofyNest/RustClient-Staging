public class TrainCouplingController // TypeDefIndex: 9771
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <PreChangeTrackSpeed>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <PreChangeCoupledBackwards>k__BackingField; // 0x14
	public const BaseEntity.Flags Flag_CouplingFront = 256;
	public const BaseEntity.Flags Flag_CouplingRear = 512;
	public readonly TrainCoupling frontCoupling; // 0x18
	public readonly TrainCoupling rearCoupling; // 0x20
	private readonly TrainCar owner; // 0x28
	[ServerVar] // RVA: 0x958B0 Offset: 0x94CB0 VA: 0x1800958B0
	public static float max_couple_speed; // 0x0

	// Properties
	public bool IsCoupled { get; }
	public bool IsFrontCoupled { get; }
	public bool IsRearCoupled { get; }
	public float PreChangeTrackSpeed { get; set; }
	public bool PreChangeCoupledBackwards { get; set; }

	// Methods

	// RVA: 0xA11500 Offset: 0xA0FB00 VA: 0x180A11500
	public bool get_IsCoupled() { }

	// RVA: 0xA11550 Offset: 0xA0FB50 VA: 0x180A11550
	public bool get_IsFrontCoupled() { }

	// RVA: 0xA11580 Offset: 0xA0FB80 VA: 0x180A11580
	public bool get_IsRearCoupled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA115C0 Offset: 0xA0FBC0 VA: 0x180A115C0
	public float get_PreChangeTrackSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA115E0 Offset: 0xA0FBE0 VA: 0x180A115E0
	private void set_PreChangeTrackSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	public bool get_PreChangeCoupledBackwards() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA115D0 Offset: 0xA0FBD0 VA: 0x180A115D0
	private void set_PreChangeCoupledBackwards(bool value) { }

	// RVA: 0xA113D0 Offset: 0xA0F9D0 VA: 0x180A113D0
	public void .ctor(TrainCar owner) { }

	// RVA: 0xA11390 Offset: 0xA0F990 VA: 0x180A11390
	private static void .cctor() { }

}

