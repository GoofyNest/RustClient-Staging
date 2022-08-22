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

	// RVA: 0xA11500 Offset: 0xA0FB00 VA: 0x180A11500
	public bool get_IsCoupled() { }

	// RVA: 0xA11530 Offset: 0xA0FB30 VA: 0x180A11530
	public bool get_IsUncoupled() { }

	// RVA: 0xA113F0 Offset: 0xA0F9F0 VA: 0x180A113F0
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller) { }

	// RVA: 0xA11420 Offset: 0xA0FA20 VA: 0x180A11420
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller, Transform couplingPoint, Transform couplingPivot, BaseEntity.Flags flag) { }

	// RVA: 0xA11100 Offset: 0xA0F700 VA: 0x180A11100
	public void VisualTick() { }

}

