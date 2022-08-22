public sealed class SubpixelMorphologicalAntialiasing // TypeDefIndex: 11808
{	// Fields
	[TooltipAttribute] // RVA: 0x76460 Offset: 0x75860 VA: 0x180076460
	public SubpixelMorphologicalAntialiasing.Quality quality; // 0x10

	// Methods

	// RVA: 0x11E0930 Offset: 0x11DEF30 VA: 0x1811E0930
	public bool IsSupported() { }

	// RVA: 0x11E0980 Offset: 0x11DEF80 VA: 0x1811E0980
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x11E0F80 Offset: 0x11DF580 VA: 0x1811E0F80
	public void .ctor() { }

}

private enum SubpixelMorphologicalAntialiasing.Pass // TypeDefIndex: 11809
{	// Fields
	public int value__; // 0x0
	public const SubpixelMorphologicalAntialiasing.Pass EdgeDetection = 0;
	public const SubpixelMorphologicalAntialiasing.Pass BlendWeights = 3;
	public const SubpixelMorphologicalAntialiasing.Pass NeighborhoodBlending = 6;

}

public enum SubpixelMorphologicalAntialiasing.Quality // TypeDefIndex: 11810
{	// Fields
	public int value__; // 0x0
	public const SubpixelMorphologicalAntialiasing.Quality Low = 0;
	public const SubpixelMorphologicalAntialiasing.Quality Medium = 1;
	public const SubpixelMorphologicalAntialiasing.Quality High = 2;

}

