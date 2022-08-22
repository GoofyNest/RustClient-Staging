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

	// RVA: 0x561840 Offset: 0x55FE40 VA: 0x180561840
	public static double Simplex1D(double x) { }

	// RVA: 0x561570 Offset: 0x55FB70 VA: 0x180561570
	public static double Simplex1D(double x, out double dx) { }

	// RVA: 0x561A80 Offset: 0x560080 VA: 0x180561A80
	public static double Simplex2D(double x, double y) { }

	// RVA: 0x562180 Offset: 0x560780 VA: 0x180562180
	public static double Simplex2D(double x, double y, out double dx, out double dy) { }

	// RVA: 0x562DC0 Offset: 0x5613C0 VA: 0x180562DC0
	public static double Turbulence(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x5606F0 Offset: 0x55ECF0 VA: 0x1805606F0
	public static double Billow(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560ED0 Offset: 0x55F4D0 VA: 0x180560ED0
	public static double Ridge(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x561440 Offset: 0x55FA40 VA: 0x180561440
	public static double Sharp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x5629F0 Offset: 0x560FF0 VA: 0x1805629F0
	public static double TurbulenceIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560300 Offset: 0x55E900 VA: 0x180560300
	public static double BillowIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x560AD0 Offset: 0x55F0D0 VA: 0x180560AD0
	public static double RidgeIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x561060 Offset: 0x55F660 VA: 0x180561060
	public static double SharpIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x562BB0 Offset: 0x5611B0 VA: 0x180562BB0
	public static double TurbulenceWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x5604D0 Offset: 0x55EAD0 VA: 0x1805604D0
	public static double BillowWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x560CA0 Offset: 0x55F2A0 VA: 0x180560CA0
	public static double RidgeWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x561220 Offset: 0x55F820 VA: 0x180561220
	public static double SharpWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x560860 Offset: 0x55EE60 VA: 0x180560860
	public static double Jordan(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp, double damp, double damp_scale) { }

	// RVA: 0x560850 Offset: 0x55EE50 VA: 0x180560850
	private static int Floor(double x) { }

	// RVA: 0x5602E0 Offset: 0x55E8E0 VA: 0x1805602E0
	private static double Abs(double x) { }

	// RVA: 0x561040 Offset: 0x55F640 VA: 0x180561040
	private static double Saturate(double x) { }

	// RVA: 0x562EE0 Offset: 0x5614E0 VA: 0x180562EE0
	private static void .cctor() { }

}

