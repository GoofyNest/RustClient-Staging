public class TriggerAchievement : TriggerBase // TypeDefIndex: 10017
{	// Fields
	public string statToIncrease; // 0x30
	public string achievementOnEnter; // 0x38
	public string requiredVehicleName; // 0x40
	[TooltipAttribute] // RVA: 0xB0200 Offset: 0xAF600 VA: 0x1800B0200
	public bool serverSide; // 0x48
	private List<ulong> triggeredPlayers; // 0x50

	// Methods

	// RVA: 0xA1FE70 Offset: 0xA1E470 VA: 0x180A1FE70
	public void OnPuzzleReset() { }

	// RVA: 0xA1FE70 Offset: 0xA1E470 VA: 0x180A1FE70
	public void Reset() { }

	// RVA: 0xA1FB80 Offset: 0xA1E180 VA: 0x180A1FB80 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA1FCC0 Offset: 0xA1E2C0 VA: 0x180A1FCC0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA1FEC0 Offset: 0xA1E4C0 VA: 0x180A1FEC0
	public void .ctor() { }

}

