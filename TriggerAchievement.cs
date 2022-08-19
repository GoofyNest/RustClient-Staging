public class TriggerAchievement : TriggerBase // TypeDefIndex: 10017
{	// Fields
	public string statToIncrease; // 0x30
	public string achievementOnEnter; // 0x38
	public string requiredVehicleName; // 0x40
	[TooltipAttribute] // RVA: 0xB0130 Offset: 0xAF530 VA: 0x1800B0130
	public bool serverSide; // 0x48
	private List<ulong> triggeredPlayers; // 0x50

	// Methods

	// RVA: 0xA1F6C0 Offset: 0xA1DCC0 VA: 0x180A1F6C0
	public void OnPuzzleReset() { }

	// RVA: 0xA1F6C0 Offset: 0xA1DCC0 VA: 0x180A1F6C0
	public void Reset() { }

	// RVA: 0xA1F3D0 Offset: 0xA1D9D0 VA: 0x180A1F3D0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA1F510 Offset: 0xA1DB10 VA: 0x180A1F510 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA1F710 Offset: 0xA1DD10 VA: 0x180A1F710
	public void .ctor() { }

}

