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

	// RVA: 0xA11240 Offset: 0xA0F840 VA: 0x180A11240
	public bool get_IsCoupled() { }

	// RVA: 0xA11270 Offset: 0xA0F870 VA: 0x180A11270
	public bool get_IsUncoupled() { }

	// RVA: 0xA11130 Offset: 0xA0F730 VA: 0x180A11130
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller) { }

	// RVA: 0xA11160 Offset: 0xA0F760 VA: 0x180A11160
	public void .ctor(TrainCar owner, bool isFrontCoupling, TrainCouplingController controller, Transform couplingPoint, Transform couplingPivot, BaseEntity.Flags flag) { }

	// RVA: 0xA10E40 Offset: 0xA0F440 VA: 0x180A10E40
	public void VisualTick() { }

}

