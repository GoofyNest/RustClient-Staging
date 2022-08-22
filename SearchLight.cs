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

	// RVA: 0x4A60A0 Offset: 0x4A46A0 VA: 0x1804A60A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4A6FD0 Offset: 0x4A55D0 VA: 0x1804A6FD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x4A6770 Offset: 0x4A4D70 VA: 0x1804A6770 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4A6860 Offset: 0x4A4E60 VA: 0x1804A6860 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x4A65F0 Offset: 0x4A4BF0 VA: 0x1804A65F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4A6EB0 Offset: 0x4A54B0 VA: 0x1804A6EB0
	public void Update() { }

	// RVA: 0x4A6A10 Offset: 0x4A5010 VA: 0x1804A6A10
	private void UpdateAimpoint() { }

	[BaseEntity.Menu] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.Description] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.Icon] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	// RVA: 0x4A6EE0 Offset: 0x4A54E0 VA: 0x1804A6EE0
	public void UseLight(BasePlayer player) { }

	// RVA: 0x4A66E0 Offset: 0x4A4CE0 VA: 0x1804A66E0
	public bool Menu_UseLight_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.Description] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.Icon] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	// RVA: 0x4A69C0 Offset: 0x4A4FC0 VA: 0x1804A69C0
	public void StopUseLight(BasePlayer player) { }

	// RVA: 0x4A6650 Offset: 0x4A4C50 VA: 0x1804A6650
	public bool Menu_StopUseLight_ShowIf(BasePlayer player) { }

	// RVA: 0x4A6F30 Offset: 0x4A5530 VA: 0x1804A6F30
	public void .ctor() { }

}

public static class SearchLight.SearchLightFlags // TypeDefIndex: 8444
{	// Fields
	public const BaseEntity.Flags PlayerUsing = 2048;

}

