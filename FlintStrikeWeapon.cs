public class FlintStrikeWeapon : BaseProjectile // TypeDefIndex: 9464
{	// Fields
	public float successFraction; // 0x378
	public RecoilProperties strikeRecoil; // 0x380
	private bool _didSparkThisFrame; // 0x388
	private bool _isStriking; // 0x389
	private int strikes; // 0x38C

	// Methods

	// RVA: 0x792DD0 Offset: 0x7913D0 VA: 0x180792DD0 Slot: 163
	public override RecoilProperties GetRecoil() { }

	// RVA: 0x792AD0 Offset: 0x7910D0 VA: 0x180792AD0 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x792DE0 Offset: 0x7913E0 VA: 0x180792DE0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x792F70 Offset: 0x791570 VA: 0x180792F70 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x793120 Offset: 0x791720 VA: 0x180793120
	public void .ctor() { }

}

