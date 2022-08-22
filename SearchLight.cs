public class SearchLight : IOEntity // TypeDefIndex: 8443
{	private Option __menuOption_StopUseLight; // 0x288
	private Option __menuOption_UseLight; // 0x2E0
	public GameObject pitchObject; // 0x338
	public GameObject yawObject; // 0x340
	public GameObject eyePoint; // 0x348
	public SoundPlayer turnLoop; // 0x350
	public bool needsBuildingPrivilegeToUse; // 0x358
	private Vector3 aimDir; // 0x35C
	private bool wasMoving; // 0x368

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public override int ConsumptionAmount() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	private void UpdateAimpoint() { }

	[BaseEntity.Menu] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.Description] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.Icon] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x833E0 Offset: 0x827E0 VA: 0x1800833E0
	public void UseLight(BasePlayer player) { }

	public bool Menu_UseLight_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.Description] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.Icon] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x836C0 Offset: 0x82AC0 VA: 0x1800836C0
	public void StopUseLight(BasePlayer player) { }

	public bool Menu_StopUseLight_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public static class SearchLight.SearchLightFlags // TypeDefIndex: 8444
{	public const BaseEntity.Flags PlayerUsing = 2048;

}

