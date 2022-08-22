public class FlintStrikeWeapon : BaseProjectile // TypeDefIndex: 9464
{	// Fields
	public float successFraction; // 0x378
	public RecoilProperties strikeRecoil; // 0x380
	private bool _didSparkThisFrame; // 0x388
	private bool _isStriking; // 0x389
	private int strikes; // 0x38C

	// Methods

	// RVA: 0x792DF0 Offset: 0x7913F0 VA: 0x180792DF0 Slot: 163
	public override RecoilProperties GetRecoil() { }

	// RVA: 0x792AF0 Offset: 0x7910F0 VA: 0x180792AF0 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x792E00 Offset: 0x791400 VA: 0x180792E00 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x792F90 Offset: 0x791590 VA: 0x180792F90 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x793140 Offset: 0x791740 VA: 0x180793140
	public void .ctor() { }

}

