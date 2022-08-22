public class BigWheelGame : SpinnerWheel // TypeDefIndex: 8744
{	// Fields
	public HitNumber[] hitNumbers; // 0x540
	public GameObject indicator; // 0x548
	public GameObjectRef winEffect; // 0x550

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 173
	public override bool AllowPlayerSpins() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 170
	public override bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x5116F0 Offset: 0x50FCF0 VA: 0x1805116F0
	public HitNumber GetCurrentHitType() { }

	[ContextMenu] // RVA: 0xBDF80 Offset: 0xBD380 VA: 0x1800BDF80
	// RVA: 0x5118B0 Offset: 0x50FEB0 VA: 0x1805118B0
	private void LoadHitNumbers() { }

	// RVA: 0x511900 Offset: 0x50FF00 VA: 0x180511900
	public void .ctor() { }

}

