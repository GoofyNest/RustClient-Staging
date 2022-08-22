public class HideIfOwnerFirstPerson : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged // TypeDefIndex: 9501
{	// Fields
	public GameObject[] disableGameObjects; // 0x20
	public bool worldModelEffect; // 0x28
	protected bool lastHidden; // 0x29
	private Dictionary<Renderer, ShadowCastingMode> previousValues; // 0x30

	// Properties
	public bool IsHidden { get; }

	// Methods

	// RVA: 0x73AD00 Offset: 0x739300 VA: 0x18073AD00
	public bool get_IsHidden() { }

	// RVA: 0x73A1B0 Offset: 0x7387B0 VA: 0x18073A1B0
	public void OnEnable() { }

	// RVA: 0x73A100 Offset: 0x738700 VA: 0x18073A100
	public void OnDisable() { }

	// RVA: 0x73A2F0 Offset: 0x7388F0 VA: 0x18073A2F0 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x73A540 Offset: 0x738B40 VA: 0x18073A540
	public void SetHidden(bool shouldHide) { }

	// RVA: 0x73A980 Offset: 0x738F80 VA: 0x18073A980
	public bool ShouldHide() { }

	// RVA: 0x73A6B0 Offset: 0x738CB0 VA: 0x18073A6B0
	private void SetShadowsOnly(GameObject root) { }

	// RVA: 0x73A380 Offset: 0x738980 VA: 0x18073A380
	private void RevertShadowsOnly(GameObject root) { }

	// RVA: 0x73AC90 Offset: 0x739290 VA: 0x18073AC90
	public void .ctor() { }

}

