public class AlignedLineDrawerDecal : AlignedLineDrawer, INotifyLOD // TypeDefIndex: 8879
{	// Fields
	public DeferredDecal decalComponent; // 0x60
	private static Dictionary<Color, Material> colouredVariants; // 0x0
	private Color cachedColour; // 0x68
	private bool isLodShowing; // 0x78

	// Methods

	// RVA: 0xAA3190 Offset: 0xAA1790 VA: 0x180AA3190 Slot: 5
	protected override void AssignMesh() { }

	// RVA: 0xAA34F0 Offset: 0xAA1AF0 VA: 0x180AA34F0 Slot: 6
	public override void SetColour(Color c) { }

	// RVA: 0xAA32B0 Offset: 0xAA18B0 VA: 0x180AA32B0
	private Material GetColourMaterial(Color c) { }

	// RVA: 0xAA35E0 Offset: 0xAA1BE0 VA: 0x180AA35E0 Slot: 8
	public void Show() { }

	// RVA: 0xAA3460 Offset: 0xAA1A60 VA: 0x180AA3460 Slot: 9
	public void Hide() { }

	// RVA: 0xAA3700 Offset: 0xAA1D00 VA: 0x180AA3700
	public void .ctor() { }

	// RVA: 0xAA36A0 Offset: 0xAA1CA0 VA: 0x180AA36A0
	private static void .cctor() { }

}

