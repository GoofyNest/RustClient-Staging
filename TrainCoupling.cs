public class TrainCoupling // TypeDefIndex: 9770
{	// Fields
	public readonly TrainCar owner; // 0x10
	public readonly bool isFrontCoupling; // 0x18
	public readonly TrainCouplingController controller; // 0x20
	public readonly Transform couplingPoint; // 0x28
	public readonly Transform couplingPivot; // 0x30
	public readonly BaseEntity.Flags flag; // 0x38
	public readonly bool isValid; // 0x3C
	public EntityRef<TrainCar> clientCoupledTo; // 0x40
	public bool clientCoupledToFront; // 0x50

	// Properties
	public bool IsCoupled { get; }
	public bool IsUncoupled { get; }

	// Methods

	// RVA: 0xA119F0 Offset: 0xA0FFF0 VA: 0x180A119F0
	public bool get_IsCoupled() { }

	// RVA: 0xA11A20 Offset: 0xA10020 VA: 0x180A11A20
	public bool get_IsUncoupled() { }

	// RVA: 0xA118E0 Offset: 0xA0FEE0 VA: 0x180A118E0
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller) { }

	// RVA: 0xA11910 Offset: 0xA0FF10 VA: 0x180A11910
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller, Transform couplingPoint, Transform couplingPivot, BaseEntity.Flags flag) { }

	// RVA: 0xA115F0 Offset: 0xA0FBF0 VA: 0x180A115F0
	public void VisualTick() { }

}

