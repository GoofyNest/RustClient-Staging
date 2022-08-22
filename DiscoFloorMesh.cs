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

	// RVA: 0x987B10 Offset: 0x986110 VA: 0x180987B10
	public void BuildMesh() { }

	// RVA: 0x988390 Offset: 0x986990 VA: 0x180988390
	public int get_NumTiles() { }

	// RVA: 0x987B10 Offset: 0x986110 VA: 0x180987B10
	private void SetupRuntimeMesh() { }

	// RVA: 0x987A50 Offset: 0x986050 VA: 0x180987A50
	public void ApplyColourGradient(Gradient gradient, float offset, DiscoFloorMesh.PatternType pattern, DiscoFloorColourLookups lookups) { }

	// RVA: 0x987840 Offset: 0x985E40 VA: 0x180987840
	private void ApplyColourGradient(Gradient gradient, float offset, float[] colourLookup) { }

	// RVA: 0x9880C0 Offset: 0x9866C0 VA: 0x1809880C0
	public void SetColour(Color c) { }

	// RVA: 0x987E40 Offset: 0x986440 VA: 0x180987E40
	public Color SampleColor(DiscoFloorMesh.Corner corner) { }

	// RVA: 0x987D00 Offset: 0x986300 VA: 0x180987D00
	private Color SampleColor(int index1, int index2, int index3) { }

	// RVA: 0x987BE0 Offset: 0x9861E0 VA: 0x180987BE0
	private void GetCornerTileIndexes(DiscoFloorMesh.Corner corner, out int index1, out int index2, out int index3) { }

	// RVA: 0x9881B0 Offset: 0x9867B0 VA: 0x1809881B0
	public void ToggleEmission(bool state) { }

	// RVA: 0x9882E0 Offset: 0x9868E0 VA: 0x1809882E0
	public void .ctor() { }

	// RVA: 0x988290 Offset: 0x986890 VA: 0x180988290
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

