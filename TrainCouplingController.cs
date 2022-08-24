public class TrainCouplingController // TypeDefIndex: 9771
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <PreChangeTrackSpeed>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <PreChangeCoupledBackwards>k__BackingField; // 0x14
	public const BaseEntity.Flags Flag_CouplingFront = 256;
	public const BaseEntity.Flags Flag_CouplingRear = 512;
	public readonly TrainCoupling frontCoupling; // 0x18
	public readonly TrainCoupling rearCoupling; // 0x20
	private readonly TrainCar owner; // 0x28
	[ServerVar] // RVA: 0x95950 Offset: 0x94D50 VA: 0x180095950
	public static float max_couple_speed; // 0x0

	public bool IsCoupled { get; }
	public bool IsFrontCoupled { get; }
	public bool IsRearCoupled { get; }
	public float PreChangeTrackSpeed { get; set; }
	public bool PreChangeCoupledBackwards { get; set; }


	public bool get_IsCoupled() { }

	public bool get_IsFrontCoupled() { }

	public bool get_IsRearCoupled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_PreChangeTrackSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_PreChangeTrackSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_PreChangeCoupledBackwards() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_PreChangeCoupledBackwards(bool value) { }

	public void .ctor(TrainCar owner) { }

	private static void .cctor() { }

}

