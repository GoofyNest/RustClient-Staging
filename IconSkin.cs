public class IconSkin : MonoBehaviour, IItemIconChanged, IClientComponent // TypeDefIndex: 9192
{	// Fields
	public Image icon; // 0x18
	public Text text; // 0x20
	public Action<int> onChanged; // 0x28
	internal ItemDefinition item; // 0x30
	internal int skinId; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <searchString>k__BackingField; // 0x40

	// Properties
	public string searchString { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_searchString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_searchString(string value) { }

	// RVA: 0x80B150 Offset: 0x809750 VA: 0x18080B150
	protected void OnEnable() { }

	// RVA: 0x80B0A0 Offset: 0x8096A0 VA: 0x18080B0A0
	protected void OnDisable() { }

	// RVA: 0x80B1E0 Offset: 0x8097E0 VA: 0x18080B1E0 Slot: 4
	public void OnItemIconChanged() { }

	// RVA: 0x80B490 Offset: 0x809A90 VA: 0x18080B490
	internal void Setup(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x80B2D0 Offset: 0x8098D0 VA: 0x18080B2D0
	public void Select() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

