public class SprayCanSkinSelect : UIDialog // TypeDefIndex: 10911
{	// Fields
	public IconSkinPicker skinPicker; // 0x30
	private Action<bool, int> onSkinSelected; // 0x38
	private ItemBlueprint cachedBlueprint; // 0x40
	private BaseEntity targetEntity; // 0x48

	// Methods

	// RVA: 0xA81890 Offset: 0xA7FE90 VA: 0x180A81890
	private void Update() { }

	// RVA: 0xA81710 Offset: 0xA7FD10 VA: 0x180A81710
	public void Setup(ItemBlueprint blueprint, SprayCan spray, BaseEntity ent, Action<bool, int> callback) { }

	// RVA: 0xA817F0 Offset: 0xA7FDF0 VA: 0x180A817F0
	private void SkinChangedEvent() { }

	// RVA: 0xA816E0 Offset: 0xA7FCE0 VA: 0x180A816E0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

