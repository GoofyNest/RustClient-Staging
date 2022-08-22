public class TriggerAchievement : TriggerBase // TypeDefIndex: 10017
{	// Fields
	public string statToIncrease; // 0x30
	public string achievementOnEnter; // 0x38
	public string requiredVehicleName; // 0x40
	[TooltipAttribute] // RVA: 0xB0200 Offset: 0xAF600 VA: 0x1800B0200
	public bool serverSide; // 0x48
	private List<ulong> triggeredPlayers; // 0x50

	// Methods

	// RVA: 0xA1F980 Offset: 0xA1DF80 VA: 0x180A1F980
	public void OnPuzzleReset() { }

	// RVA: 0xA1F980 Offset: 0xA1DF80 VA: 0x180A1F980
	public void Reset() { }

	// RVA: 0xA1F690 Offset: 0xA1DC90 VA: 0x180A1F690 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA1F7D0 Offset: 0xA1DDD0 VA: 0x180A1F7D0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA1F9D0 Offset: 0xA1DFD0 VA: 0x180A1F9D0
	public void .ctor() { }

}

