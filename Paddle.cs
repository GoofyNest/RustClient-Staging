public class Paddle : BaseMelee // TypeDefIndex: 9472
{	// Fields
	public float animPaddleCooldown; // 0x2E0
	public GameObjectRef kayakSeat; // 0x2E8
	public float animationLerpSpeed; // 0x2F0
	private static int param_Paddling; // 0x0
	private static int param_right; // 0x4
	private static int param_forward; // 0x8
	private Vector3 smoothedAnimDirection; // 0x2F4

	// Properties
	protected override bool CanAttack { get; }
	protected override bool CanThrow { get; }

	// Methods

	// RVA: 0x9EAFA0 Offset: 0x9E95A0 VA: 0x1809EAFA0 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x9EAFE0 Offset: 0x9E95E0 VA: 0x1809EAFE0
	private bool IsPlayerOnKayak(BasePlayer p) { }

	// RVA: 0x9EB0A0 Offset: 0x9E96A0 VA: 0x1809EB0A0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x9EB590 Offset: 0x9E9B90 VA: 0x1809EB590 Slot: 161
	protected override bool get_CanAttack() { }

	// RVA: 0x9EB590 Offset: 0x9E9B90 VA: 0x1809EB590 Slot: 162
	protected override bool get_CanThrow() { }

	// RVA: 0x9EB570 Offset: 0x9E9B70 VA: 0x1809EB570
	public void .ctor() { }

	// RVA: 0x9EB4F0 Offset: 0x9E9AF0 VA: 0x1809EB4F0
	private static void .cctor() { }

}

