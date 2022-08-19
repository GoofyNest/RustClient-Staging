public static class ManagedNoise // TypeDefIndex: 10288
{	// Fields
	private static readonly int[] hash; // 0x0
	private const int hashMask = 255;
	private const double sqrt2 = 1,4142135623731;
	private const double rsqrt2 = 0,707106781186548;
	private const double squaresToTriangles = 0,211324865405187;
	private const double trianglesToSquares = 0,366025403784439;
	private const double simplexScale1D = 2,40740740740741;
	private const double simplexScale2D = 32,9907739830396;
	private const double gradientScale2D = 4;
	private static double[] gradients1D; // 0x8
	private const int gradientsMask1D = 1;
	private static double[] gradients2Dx; // 0x10
	private static double[] gradients2Dy; // 0x18
	private const int gradientsMask2D = 7;

	// Methods

	// RVA: 0x5618B0 Offset: 0x55FEB0 VA: 0x1805618B0
	public static double Simplex1D(double x) { }

	// RVA: 0x5615E0 Offset: 0x55FBE0 VA: 0x1805615E0
	public static double Simplex1D(double x, out double dx) { }

	// RVA: 0x561AF0 Offset: 0x5600F0 VA: 0x180561AF0
	public static double Simplex2D(double x, double y) { }

	// RVA: 0x5621F0 Offset: 0x5607F0 VA: 0x1805621F0
	public static double Simplex2D(double x, double y, out double dx, out double dy) { }

	// RVA: 0x562E30 Offset: 0x561430 VA: 0x180562E30
	public static double Turbulence(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560760 Offset: 0x55ED60 VA: 0x180560760
	public static double Billow(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560F40 Offset: 0x55F540 VA: 0x180560F40
	public static double Ridge(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x5614B0 Offset: 0x55FAB0 VA: 0x1805614B0
	public static double Sharp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x562A60 Offset: 0x561060 VA: 0x180562A60
	public static double TurbulenceIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560370 Offset: 0x55E970 VA: 0x180560370
	public static double BillowIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560B40 Offset: 0x55F140 VA: 0x180560B40
	public static double RidgeIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x5610D0 Offset: 0x55F6D0 VA: 0x1805610D0
	public static double SharpIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x562C20 Offset: 0x561220 VA: 0x180562C20
	public static double TurbulenceWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x560540 Offset: 0x55EB40 VA: 0x180560540
	public static double BillowWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x560D10 Offset: 0x55F310 VA: 0x180560D10
	public static double RidgeWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x561290 Offset: 0x55F890 VA: 0x180561290
	public static double SharpWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x5608D0 Offset: 0x55EED0 VA: 0x1805608D0
	public static double Jordan(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp, double damp, double damp_scale) { }

	// RVA: 0x5608C0 Offset: 0x55EEC0 VA: 0x1805608C0
	private static int Floor(double x) { }

	// RVA: 0x560350 Offset: 0x55E950 VA: 0x180560350
	private static double Abs(double x) { }

	// RVA: 0x5610B0 Offset: 0x55F6B0 VA: 0x1805610B0
	private static double Saturate(double x) { }

	// RVA: 0x562F50 Offset: 0x561550 VA: 0x180562F50
	private static void .cctor() { }

}

