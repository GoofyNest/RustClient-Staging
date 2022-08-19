public class ScaleRenderer : MonoBehaviour // TypeDefIndex: 9362
{	// Fields
	public bool useRandomScale; // 0x18
	public float scaleMin; // 0x1C
	public float scaleMax; // 0x20
	private float lastScale; // 0x24
	protected bool hasInitialValues; // 0x28
	public Renderer myRenderer; // 0x30

	// Methods

	// RVA: 0x4A04E0 Offset: 0x49EAE0 VA: 0x1804A04E0
	private bool ScaleDifferent(float newScale) { }

	// RVA: 0x4A0640 Offset: 0x49EC40 VA: 0x1804A0640
	public void Start() { }

	// RVA: 0x4A05A0 Offset: 0x49EBA0 VA: 0x1804A05A0
	public void SetScale(float scale) { }

	// RVA: 0x4A0590 Offset: 0x49EB90 VA: 0x1804A0590 Slot: 4
	public virtual void SetScale_Internal(float scale) { }

	// RVA: 0x4A04F0 Offset: 0x49EAF0 VA: 0x1804A04F0 Slot: 5
	public virtual void SetRendererEnabled(bool isEnabled) { }

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0 Slot: 6
	public virtual void GatherInitialValues() { }

	// RVA: 0x4A04B0 Offset: 0x49EAB0 VA: 0x1804A04B0
	public void .ctor() { }

}

