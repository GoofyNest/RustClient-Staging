public class TrainCouplingController // TypeDefIndex: 9771
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <PreChangeTrackSpeed>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <PreChangeCoupledBackwards>k__BackingField; // 0x14
	public const BaseEntity.Flags Flag_CouplingFront = 256;
	public const BaseEntity.Flags Flag_CouplingRear = 512;
	public readonly TrainCoupling frontCoupling; // 0x18
	public readonly TrainCoupling rearCoupling; // 0x20
	private readonly TrainCar owner; // 0x28
	[ServerVar] // RVA: 0x95830 Offset: 0x94C30 VA: 0x180095830
	public static float max_couple_speed; // 0x0

	// Properties
	public bool IsCoupled { get; }
	public bool IsFrontCoupled { get; }
	public bool IsRearCoupled { get; }
	public float PreChangeTrackSpeed { get; set; }
	public bool PreChangeCoupledBackwards { get; set; }

	// Methods

	// RVA: 0xA10D50 Offset: 0xA0F350 VA: 0x180A10D50
	public bool get_IsCoupled() { }

	// RVA: 0xA10DA0 Offset: 0xA0F3A0 VA: 0x180A10DA0
	public bool get_IsFrontCoupled() { }

	// RVA: 0xA10DD0 Offset: 0xA0F3D0 VA: 0x180A10DD0
	public bool get_IsRearCoupled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA10E10 Offset: 0xA0F410 VA: 0x180A10E10
	public float get_PreChangeTrackSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA10E30 Offset: 0xA0F430 VA: 0x180A10E30
	private void set_PreChangeTrackSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	public bool get_PreChangeCoupledBackwards() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA10E20 Offset: 0xA0F420 VA: 0x180A10E20
	private void set_PreChangeCoupledBackwards(bool value) { }

	// RVA: 0xA10C20 Offset: 0xA0F220 VA: 0x180A10C20
	public void .ctor(TrainCar owner) { }

	// RVA: 0xA10BE0 Offset: 0xA0F1E0 VA: 0x180A10BE0
	private static void .cctor() { }

}

