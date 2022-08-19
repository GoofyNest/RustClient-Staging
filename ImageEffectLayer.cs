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

	// RVA: 0x106D990 Offset: 0x106BF90 VA: 0x18106D990 Slot: 4
	public virtual void Start() { }

	// RVA: 0x106D8A0 Offset: 0x106BEA0 VA: 0x18106D8A0 Slot: 5
	public virtual void OnDisable() { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	public bool get_layerEnabled() { }

	// RVA: 0x106DB30 Offset: 0x106C130 VA: 0x18106DB30
	public void set_layerEnabled(bool value) { }

	// RVA: 0x106DB20 Offset: 0x106C120 VA: 0x18106DB20
	public void .ctor() { }

}

