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

	// RVA: 0x9EAAB0 Offset: 0x9E90B0 VA: 0x1809EAAB0 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x9EAAF0 Offset: 0x9E90F0 VA: 0x1809EAAF0
	private bool IsPlayerOnKayak(BasePlayer p) { }

	// RVA: 0x9EABB0 Offset: 0x9E91B0 VA: 0x1809EABB0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x9EB0A0 Offset: 0x9E96A0 VA: 0x1809EB0A0 Slot: 161
	protected override bool get_CanAttack() { }

	// RVA: 0x9EB0A0 Offset: 0x9E96A0 VA: 0x1809EB0A0 Slot: 162
	protected override bool get_CanThrow() { }

	// RVA: 0x9EB080 Offset: 0x9E9680 VA: 0x1809EB080
	public void .ctor() { }

	// RVA: 0x9EB000 Offset: 0x9E9600 VA: 0x1809EB000
	private static void .cctor() { }

}

