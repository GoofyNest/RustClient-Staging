public class DiscoFloorMesh : MonoBehaviour, IClientComponent // TypeDefIndex: 9441
{	// Fields
	public int GridRows; // 0x18
	public int GridColumns; // 0x1C
	public float GridSize; // 0x20
	[RangeAttribute] // RVA: 0x981E0 Offset: 0x975E0 VA: 0x1800981E0
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

	// RVA: 0x987A00 Offset: 0x986000 VA: 0x180987A00
	public void BuildMesh() { }

	// RVA: 0x988280 Offset: 0x986880 VA: 0x180988280
	public int get_NumTiles() { }

	// RVA: 0x987A00 Offset: 0x986000 VA: 0x180987A00
	private void SetupRuntimeMesh() { }

	// RVA: 0x987940 Offset: 0x985F40 VA: 0x180987940
	public void ApplyColourGradient(Gradient gradient, float offset, DiscoFloorMesh.PatternType pattern, DiscoFloorColourLookups lookups) { }

	// RVA: 0x987730 Offset: 0x985D30 VA: 0x180987730
	private void ApplyColourGradient(Gradient gradient, float offset, float[] colourLookup) { }

	// RVA: 0x987FB0 Offset: 0x9865B0 VA: 0x180987FB0
	public void SetColour(Color c) { }

	// RVA: 0x987D30 Offset: 0x986330 VA: 0x180987D30
	public Color SampleColor(DiscoFloorMesh.Corner corner) { }

	// RVA: 0x987BF0 Offset: 0x9861F0 VA: 0x180987BF0
	private Color SampleColor(int index1, int index2, int index3) { }

	// RVA: 0x987AD0 Offset: 0x9860D0 VA: 0x180987AD0
	private void GetCornerTileIndexes(DiscoFloorMesh.Corner corner, out int index1, out int index2, out int index3) { }

	// RVA: 0x9880A0 Offset: 0x9866A0 VA: 0x1809880A0
	public void ToggleEmission(bool state) { }

	// RVA: 0x9881D0 Offset: 0x9867D0 VA: 0x1809881D0
	public void .ctor() { }

	// RVA: 0x988180 Offset: 0x986780 VA: 0x180988180
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

