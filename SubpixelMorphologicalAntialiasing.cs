public sealed class SubpixelMorphologicalAntialiasing // TypeDefIndex: 11808
{	[TooltipAttribute] // RVA: 0x76460 Offset: 0x75860 VA: 0x180076460
	public SubpixelMorphologicalAntialiasing.Quality quality; // 0x10


	public bool IsSupported() { }

	internal void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum SubpixelMorphologicalAntialiasing.Pass // TypeDefIndex: 11809
{	public int value__; // 0x0
	public const SubpixelMorphologicalAntialiasing.Pass EdgeDetection = 0;
	public const SubpixelMorphologicalAntialiasing.Pass BlendWeights = 3;
	public const SubpixelMorphologicalAntialiasing.Pass NeighborhoodBlending = 6;

}

public enum SubpixelMorphologicalAntialiasing.Quality // TypeDefIndex: 11810
{	public int value__; // 0x0
	public const SubpixelMorphologicalAntialiasing.Quality Low = 0;
	public const SubpixelMorphologicalAntialiasing.Quality Medium = 1;
	public const SubpixelMorphologicalAntialiasing.Quality High = 2;

}

