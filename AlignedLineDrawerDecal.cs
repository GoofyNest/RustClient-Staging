public class AlignedLineDrawerDecal : AlignedLineDrawer, INotifyLOD // TypeDefIndex: 8879
{	// Fields
	public DeferredDecal decalComponent; // 0x60
	private static Dictionary<Color, Material> colouredVariants; // 0x0
	private Color cachedColour; // 0x68
	private bool isLodShowing; // 0x78

	// Methods

	// RVA: 0xAA2CC0 Offset: 0xAA12C0 VA: 0x180AA2CC0 Slot: 5
	protected override void AssignMesh() { }

	// RVA: 0xAA3020 Offset: 0xAA1620 VA: 0x180AA3020 Slot: 6
	public override void SetColour(Color c) { }

	// RVA: 0xAA2DE0 Offset: 0xAA13E0 VA: 0x180AA2DE0
	private Material GetColourMaterial(Color c) { }

	// RVA: 0xAA3110 Offset: 0xAA1710 VA: 0x180AA3110 Slot: 8
	public void Show() { }

	// RVA: 0xAA2F90 Offset: 0xAA1590 VA: 0x180AA2F90 Slot: 9
	public void Hide() { }

	// RVA: 0xAA3230 Offset: 0xAA1830 VA: 0x180AA3230
	public void .ctor() { }

	// RVA: 0xAA31D0 Offset: 0xAA17D0 VA: 0x180AA31D0
	private static void .cctor() { }

}

