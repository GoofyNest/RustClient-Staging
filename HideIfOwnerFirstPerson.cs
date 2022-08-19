public class HideIfOwnerFirstPerson : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged // TypeDefIndex: 9501
{	// Fields
	public GameObject[] disableGameObjects; // 0x20
	public bool worldModelEffect; // 0x28
	protected bool lastHidden; // 0x29
	private Dictionary<Renderer, ShadowCastingMode> previousValues; // 0x30

	// Properties
	public bool IsHidden { get; }

	// Methods

	// RVA: 0x73ABF0 Offset: 0x7391F0 VA: 0x18073ABF0
	public bool get_IsHidden() { }

	// RVA: 0x73A0A0 Offset: 0x7386A0 VA: 0x18073A0A0
	public void OnEnable() { }

	// RVA: 0x739FF0 Offset: 0x7385F0 VA: 0x180739FF0
	public void OnDisable() { }

	// RVA: 0x73A1E0 Offset: 0x7387E0 VA: 0x18073A1E0 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x73A430 Offset: 0x738A30 VA: 0x18073A430
	public void SetHidden(bool shouldHide) { }

	// RVA: 0x73A870 Offset: 0x738E70 VA: 0x18073A870
	public bool ShouldHide() { }

	// RVA: 0x73A5A0 Offset: 0x738BA0 VA: 0x18073A5A0
	private void SetShadowsOnly(GameObject root) { }

	// RVA: 0x73A270 Offset: 0x738870 VA: 0x18073A270
	private void RevertShadowsOnly(GameObject root) { }

	// RVA: 0x73AB80 Offset: 0x739180 VA: 0x18073AB80
	public void .ctor() { }

}

