public class AlignedLineDrawerDecal : AlignedLineDrawer, INotifyLOD // TypeDefIndex: 8879
{	// Fields
	public DeferredDecal decalComponent; // 0x60
	private static Dictionary<Color, Material> colouredVariants; // 0x0
	private Color cachedColour; // 0x68
	private bool isLodShowing; // 0x78

	// Methods

	// RVA: 0xAA2A00 Offset: 0xAA1000 VA: 0x180AA2A00 Slot: 5
	protected override void AssignMesh() { }

	// RVA: 0xAA2D60 Offset: 0xAA1360 VA: 0x180AA2D60 Slot: 6
	public override void SetColour(Color c) { }

	// RVA: 0xAA2B20 Offset: 0xAA1120 VA: 0x180AA2B20
	private Material GetColourMaterial(Color c) { }

	// RVA: 0xAA2E50 Offset: 0xAA1450 VA: 0x180AA2E50 Slot: 8
	public void Show() { }

	// RVA: 0xAA2CD0 Offset: 0xAA12D0 VA: 0x180AA2CD0 Slot: 9
	public void Hide() { }

	// RVA: 0xAA2F70 Offset: 0xAA1570 VA: 0x180AA2F70
	public void .ctor() { }

	// RVA: 0xAA2F10 Offset: 0xAA1510 VA: 0x180AA2F10
	private static void .cctor() { }

}

