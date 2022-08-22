public class FlintStrikeWeapon : BaseProjectile // TypeDefIndex: 9464
{	// Fields
	public float successFraction; // 0x378
	public RecoilProperties strikeRecoil; // 0x380
	private bool _didSparkThisFrame; // 0x388
	private bool _isStriking; // 0x389
	private int strikes; // 0x38C

	// Methods

	// RVA: 0x792EE0 Offset: 0x7914E0 VA: 0x180792EE0 Slot: 163
	public override RecoilProperties GetRecoil() { }

	// RVA: 0x792BE0 Offset: 0x7911E0 VA: 0x180792BE0 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x792EF0 Offset: 0x7914F0 VA: 0x180792EF0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x793080 Offset: 0x791680 VA: 0x180793080 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x793230 Offset: 0x791830 VA: 0x180793230
	public void .ctor() { }

}

