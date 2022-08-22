public class ImageEffectLayer : FacepunchBehaviour // TypeDefIndex: 8032
{	// Fields
	protected int sortOrder; // 0x18
	private IImageEffect[] effects; // 0x20
	internal bool _layerEnabled; // 0x28

	// Properties
	public int SortOrder { get; }
	public IImageEffect[] Effects { get; }
	public bool layerEnabled { get; set; }

	// Methods

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_SortOrder() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IImageEffect[] get_Effects() { }

	// RVA: 0x106E6C0 Offset: 0x106CCC0 VA: 0x18106E6C0 Slot: 4
	public virtual void Start() { }

	// RVA: 0x106E5D0 Offset: 0x106CBD0 VA: 0x18106E5D0 Slot: 5
	public virtual void OnDisable() { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	public bool get_layerEnabled() { }

	// RVA: 0x106E860 Offset: 0x106CE60 VA: 0x18106E860
	public void set_layerEnabled(bool value) { }

	// RVA: 0x106E850 Offset: 0x106CE50 VA: 0x18106E850
	public void .ctor() { }

}

