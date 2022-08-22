public class IconSkin : MonoBehaviour, IItemIconChanged, IClientComponent // TypeDefIndex: 9192
{	public Image icon; // 0x18
	public Text text; // 0x20
	public Action<int> onChanged; // 0x28
	internal ItemDefinition item; // 0x30
	internal int skinId; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <searchString>k__BackingField; // 0x40

	public string searchString { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string get_searchString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_searchString(string value) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void OnItemIconChanged() { }

	internal void Setup(ItemDefinition item, int skinid, string text, bool canUse) { }

	public void Select() { }

	public void .ctor() { }

}

