public class SearchLight : IOEntity // TypeDefIndex: 8443
{	// Fields
	private Option __menuOption_StopUseLight; // 0x288
	private Option __menuOption_UseLight; // 0x2E0
	public GameObject pitchObject; // 0x338
	public GameObject yawObject; // 0x340
	public GameObject eyePoint; // 0x348
	public SoundPlayer turnLoop; // 0x350
	public bool needsBuildingPrivilegeToUse; // 0x358
	private Vector3 aimDir; // 0x35C
	private bool wasMoving; // 0x368

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x4A6030 Offset: 0x4A4630 VA: 0x1804A6030 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4A6F60 Offset: 0x4A5560 VA: 0x1804A6F60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x4A6700 Offset: 0x4A4D00 VA: 0x1804A6700 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4A67F0 Offset: 0x4A4DF0 VA: 0x1804A67F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x4A6580 Offset: 0x4A4B80 VA: 0x1804A6580 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4A6E40 Offset: 0x4A5440 VA: 0x1804A6E40
	public void Update() { }

	// RVA: 0x4A69A0 Offset: 0x4A4FA0 VA: 0x1804A69A0
	private void UpdateAimpoint() { }

	[BaseEntity.Menu] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.Description] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.Icon] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	// RVA: 0x4A6E70 Offset: 0x4A5470 VA: 0x1804A6E70
	public void UseLight(BasePlayer player) { }

	// RVA: 0x4A6670 Offset: 0x4A4C70 VA: 0x1804A6670
	public bool Menu_UseLight_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.Description] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.Icon] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	// RVA: 0x4A6950 Offset: 0x4A4F50 VA: 0x1804A6950
	public void StopUseLight(BasePlayer player) { }

	// RVA: 0x4A65E0 Offset: 0x4A4BE0 VA: 0x1804A65E0
	public bool Menu_StopUseLight_ShowIf(BasePlayer player) { }

	// RVA: 0x4A6EC0 Offset: 0x4A54C0 VA: 0x1804A6EC0
	public void .ctor() { }

}

public static class SearchLight.SearchLightFlags // TypeDefIndex: 8444
{	// Fields
	public const BaseEntity.Flags PlayerUsing = 2048;

}

