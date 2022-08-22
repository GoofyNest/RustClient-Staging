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

	// RVA: 0xA11010 Offset: 0xA0F610 VA: 0x180A11010
	public bool get_IsCoupled() { }

	// RVA: 0xA11060 Offset: 0xA0F660 VA: 0x180A11060
	public bool get_IsFrontCoupled() { }

	// RVA: 0xA11090 Offset: 0xA0F690 VA: 0x180A11090
	public bool get_IsRearCoupled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA110D0 Offset: 0xA0F6D0 VA: 0x180A110D0
	public float get_PreChangeTrackSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA110F0 Offset: 0xA0F6F0 VA: 0x180A110F0
	private void set_PreChangeTrackSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA110C0 Offset: 0xA0F6C0 VA: 0x180A110C0
	public bool get_PreChangeCoupledBackwards() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA110E0 Offset: 0xA0F6E0 VA: 0x180A110E0
	private void set_PreChangeCoupledBackwards(bool value) { }

	// RVA: 0xA10EE0 Offset: 0xA0F4E0 VA: 0x180A10EE0
	public void .ctor(TrainCar owner) { }

	// RVA: 0xA10EA0 Offset: 0xA0F4A0 VA: 0x180A10EA0
	private static void .cctor() { }

}

