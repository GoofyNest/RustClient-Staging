public struct SubsurfaceScatteringParams // TypeDefIndex: 10654
{	// Fields
	public bool enabled; // 0x0
	public SubsurfaceScatteringParams.Quality quality; // 0x4
	public bool halfResolution; // 0x8
	public float radiusScale; // 0xC
	public static SubsurfaceScatteringParams Default; // 0x0

	// Methods

	// RVA: 0x7C3E80 Offset: 0x7C2480 VA: 0x1807C3E80
	private static void .cctor() { }

}

public enum SubsurfaceScatteringParams.Quality // TypeDefIndex: 10655
{	// Fields
	public int value__; // 0x0
	public const SubsurfaceScatteringParams.Quality Low = 0;
	public const SubsurfaceScatteringParams.Quality Medium = 1;
	public const SubsurfaceScatteringParams.Quality High = 2;

}

