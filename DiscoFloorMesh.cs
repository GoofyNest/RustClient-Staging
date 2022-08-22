public class DiscoFloorMesh : MonoBehaviour, IClientComponent // TypeDefIndex: 9441
{	// Fields
	public int GridRows; // 0x18
	public int GridColumns; // 0x1C
	public float GridSize; // 0x20
	[RangeAttribute] // RVA: 0x98320 Offset: 0x97720 VA: 0x180098320
	public float TestOffset; // 0x24
	public Color OffColor; // 0x28
	public MeshRenderer Renderer; // 0x38
	public bool DrawInEditor; // 0x40
	public MeshFilter Filter; // 0x48
	public AnimationCurve customCurveX; // 0x50
	public AnimationCurve customCurveY; // 0x58
	private static int powerId; // 0x0
	private Mesh builtMesh; // 0x60
	private Color[] colourArray; // 0x68

	// Properties
	public int NumTiles { get; }

	// Methods

	// RVA: 0x988010 Offset: 0x986610 VA: 0x180988010
	public void BuildMesh() { }

	// RVA: 0x988890 Offset: 0x986E90 VA: 0x180988890
	public int get_NumTiles() { }

	// RVA: 0x988010 Offset: 0x986610 VA: 0x180988010
	private void SetupRuntimeMesh() { }

	// RVA: 0x987F50 Offset: 0x986550 VA: 0x180987F50
	public void ApplyColourGradient(Gradient gradient, float offset, DiscoFloorMesh.PatternType pattern, DiscoFloorColourLookups lookups) { }

	// RVA: 0x987D40 Offset: 0x986340 VA: 0x180987D40
	private void ApplyColourGradient(Gradient gradient, float offset, float[] colourLookup) { }

	// RVA: 0x9885C0 Offset: 0x986BC0 VA: 0x1809885C0
	public void SetColour(Color c) { }

	// RVA: 0x988340 Offset: 0x986940 VA: 0x180988340
	public Color SampleColor(DiscoFloorMesh.Corner corner) { }

	// RVA: 0x988200 Offset: 0x986800 VA: 0x180988200
	private Color SampleColor(int index1, int index2, int index3) { }

	// RVA: 0x9880E0 Offset: 0x9866E0 VA: 0x1809880E0
	private void GetCornerTileIndexes(DiscoFloorMesh.Corner corner, out int index1, out int index2, out int index3) { }

	// RVA: 0x9886B0 Offset: 0x986CB0 VA: 0x1809886B0
	public void ToggleEmission(bool state) { }

	// RVA: 0x9887E0 Offset: 0x986DE0 VA: 0x1809887E0
	public void .ctor() { }

	// RVA: 0x988790 Offset: 0x986D90 VA: 0x180988790
	private static void .cctor() { }

}

public enum DiscoFloorMesh.PatternType // TypeDefIndex: 9442
{	// Fields
	public int value__; // 0x0
	public const DiscoFloorMesh.PatternType InOut = 0;
	public const DiscoFloorMesh.PatternType Radial = 1;
	public const DiscoFloorMesh.PatternType Ripple = 2;
	public const DiscoFloorMesh.PatternType Checker = 3;
	public const DiscoFloorMesh.PatternType Block = 4;

}

public enum DiscoFloorMesh.Corner // TypeDefIndex: 9443
{	// Fields
	public int value__; // 0x0
	public const DiscoFloorMesh.Corner TopLeft = 0;
	public const DiscoFloorMesh.Corner TopRight = 1;
	public const DiscoFloorMesh.Corner BottomLeft = 2;
	public const DiscoFloorMesh.Corner BottomRight = 3;

}

