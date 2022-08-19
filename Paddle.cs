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

	// RVA: 0x9EA7F0 Offset: 0x9E8DF0 VA: 0x1809EA7F0 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x9EA830 Offset: 0x9E8E30 VA: 0x1809EA830
	private bool IsPlayerOnKayak(BasePlayer p) { }

	// RVA: 0x9EA8F0 Offset: 0x9E8EF0 VA: 0x1809EA8F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x9EADE0 Offset: 0x9E93E0 VA: 0x1809EADE0 Slot: 161
	protected override bool get_CanAttack() { }

	// RVA: 0x9EADE0 Offset: 0x9E93E0 VA: 0x1809EADE0 Slot: 162
	protected override bool get_CanThrow() { }

	// RVA: 0x9EADC0 Offset: 0x9E93C0 VA: 0x1809EADC0
	public void .ctor() { }

	// RVA: 0x9EAD40 Offset: 0x9E9340 VA: 0x1809EAD40
	private static void .cctor() { }

}

