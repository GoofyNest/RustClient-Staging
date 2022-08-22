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
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_searchString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	private void set_searchString(string value) { }

	// RVA: 0x80B6E0 Offset: 0x809CE0 VA: 0x18080B6E0
	protected void OnEnable() { }

	// RVA: 0x80B630 Offset: 0x809C30 VA: 0x18080B630
	protected void OnDisable() { }

	// RVA: 0x80B770 Offset: 0x809D70 VA: 0x18080B770 Slot: 4
	public void OnItemIconChanged() { }

	// RVA: 0x80BA20 Offset: 0x80A020 VA: 0x18080BA20
	internal void Setup(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x80B860 Offset: 0x809E60 VA: 0x18080B860
	public void Select() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

