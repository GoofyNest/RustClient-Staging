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

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_SortOrder() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IImageEffect[] get_Effects() { }

	// RVA: 0x106DC50 Offset: 0x106C250 VA: 0x18106DC50 Slot: 4
	public virtual void Start() { }

	// RVA: 0x106DB60 Offset: 0x106C160 VA: 0x18106DB60 Slot: 5
	public virtual void OnDisable() { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	public bool get_layerEnabled() { }

	// RVA: 0x106DDF0 Offset: 0x106C3F0 VA: 0x18106DDF0
	public void set_layerEnabled(bool value) { }

	// RVA: 0x106DDE0 Offset: 0x106C3E0 VA: 0x18106DDE0
	public void .ctor() { }

}

