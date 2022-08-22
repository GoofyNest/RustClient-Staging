public class HideIfOwnerFirstPerson : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged // TypeDefIndex: 9501
{	// Fields
	public GameObject[] disableGameObjects; // 0x20
	public bool worldModelEffect; // 0x28
	protected bool lastHidden; // 0x29
	private Dictionary<Renderer, ShadowCastingMode> previousValues; // 0x30

	// Properties
	public bool IsHidden { get; }

	// Methods

	// RVA: 0x73AC50 Offset: 0x739250 VA: 0x18073AC50
	public bool get_IsHidden() { }

	// RVA: 0x73A100 Offset: 0x738700 VA: 0x18073A100
	public void OnEnable() { }

	// RVA: 0x73A050 Offset: 0x738650 VA: 0x18073A050
	public void OnDisable() { }

	// RVA: 0x73A240 Offset: 0x738840 VA: 0x18073A240 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x73A490 Offset: 0x738A90 VA: 0x18073A490
	public void SetHidden(bool shouldHide) { }

	// RVA: 0x73A8D0 Offset: 0x738ED0 VA: 0x18073A8D0
	public bool ShouldHide() { }

	// RVA: 0x73A600 Offset: 0x738C00 VA: 0x18073A600
	private void SetShadowsOnly(GameObject root) { }

	// RVA: 0x73A2D0 Offset: 0x7388D0 VA: 0x18073A2D0
	private void RevertShadowsOnly(GameObject root) { }

	// RVA: 0x73ABE0 Offset: 0x7391E0 VA: 0x18073ABE0
	public void .ctor() { }

}

