public static class Vector3Ex // TypeDefIndex: 6612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB23E0 Offset: 0x1BB09E0 VA: 0x181BB23E0
	public static Vector3 WithX(Vector3 v, float x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BCCD0 Offset: 0x14BB2D0 VA: 0x1814BCCD0
	public static Vector3 WithY(Vector3 v, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2420 Offset: 0x1BB0A20 VA: 0x181BB2420
	public static Vector3 WithZ(Vector3 v, float z) { }

	// RVA: 0x1BB24A0 Offset: 0x1BB0AA0 VA: 0x181BB24A0
	public static Vector3 XZ(Vector3 v) { }

	// RVA: 0x1BB12E0 Offset: 0x1BAF8E0 VA: 0x181BB12E0
	public static float Distance2D(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB18C0 Offset: 0x1BAFEC0 VA: 0x181BB18C0
	public static float HeightDelta(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB10D0 Offset: 0x1BAF6D0 VA: 0x181BB10D0
	public static Vector3 Direction2D(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB1210 Offset: 0x1BAF810 VA: 0x181BB1210
	public static Vector3 Direction(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB1F20 Offset: 0x1BB0520 VA: 0x181BB1F20
	public static Vector3 Range(float x, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1FC0 Offset: 0x1BB05C0 VA: 0x181BB1FC0
	public static Vector3 Scale(Vector3 vector, float x, float y, float z) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2170 Offset: 0x1BB0770 VA: 0x181BB2170
	public static Vector3 SnapTo(Vector3 vector, float snapValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1940 Offset: 0x1BAFF40 VA: 0x181BB1940
	public static Vector3 Inverse(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2020 Offset: 0x1BB0620 VA: 0x181BB2020
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1780 Offset: 0x1BAFD80 VA: 0x181BB1780
	public static void FastRenormalize(Vector3 n, float scale = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB22F0 Offset: 0x1BB08F0 VA: 0x181BB22F0
	public static void ToDirectionAndMagnitude(Vector3 value, out Vector3 direction, out float magnitude) { }

	// RVA: 0x1BB0FB0 Offset: 0x1BAF5B0 VA: 0x181BB0FB0
	public static Vector3 BlendNormals(Vector3 n1, Vector3 n2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1990 Offset: 0x1BAFF90 VA: 0x181BB1990
	public static bool IsNaNOrInfinity(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1440 Offset: 0x1BAFA40 VA: 0x181BB1440
	public static float DotRadians(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB13F0 Offset: 0x1BAF9F0 VA: 0x181BB13F0
	public static float DotDegrees(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1A30 Offset: 0x1BB0030 VA: 0x181BB1A30
	public static float Magnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2220 Offset: 0x1BB0820 VA: 0x181BB2220
	public static float SqrMagnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1AB0 Offset: 0x1BB00B0 VA: 0x181BB1AB0
	public static float MagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2250 Offset: 0x1BB0850 VA: 0x181BB2250
	public static float SqrMagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1B30 Offset: 0x1BB0130 VA: 0x181BB1B30
	public static float MagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2280 Offset: 0x1BB0880 VA: 0x181BB2280
	public static float SqrMagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1BB0 Offset: 0x1BB01B0 VA: 0x181BB1BB0
	public static float MagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB22B0 Offset: 0x1BB08B0 VA: 0x181BB22B0
	public static float SqrMagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2460 Offset: 0x1BB0A60 VA: 0x181BB2460
	public static Vector3 XY3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB24A0 Offset: 0x1BB0AA0 VA: 0x181BB24A0
	public static Vector3 XZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB2520 Offset: 0x1BB0B20 VA: 0x181BB2520
	public static Vector3 YZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB470 Offset: 0xAC9A70 VA: 0x180ACB470
	public static Vector2 XY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB4A0 Offset: 0xAC9AA0 VA: 0x180ACB4A0
	public static Vector2 XZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB510 Offset: 0xAC9B10 VA: 0x180ACB510
	public static Vector2 YZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB4E0 Offset: 0xAC9AE0 VA: 0x180ACB4E0
	public static Vector2 YX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB550 Offset: 0xAC9B50 VA: 0x180ACB550
	public static Vector2 ZX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB590 Offset: 0xAC9B90 VA: 0x180ACB590
	public static Vector2 ZY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB24E0 Offset: 0x1BB0AE0 VA: 0x181BB24E0
	public static Vector3 XZ3D(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1D20 Offset: 0x1BB0320 VA: 0x181BB1D20
	public static float Max(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1C40 Offset: 0x1BB0240 VA: 0x181BB1C40
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1CC0 Offset: 0x1BB02C0 VA: 0x181BB1CC0
	public static float Max(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0DD0 Offset: 0x1BAF3D0 VA: 0x181BB0DD0
	public static Vector4 Abs(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0E80 Offset: 0x1BAF480 VA: 0x181BB0E80
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0F30 Offset: 0x1BAF530 VA: 0x181BB0F30
	public static Vector2 Abs(Vector2 v) { }

	// RVA: 0x1BB1DB0 Offset: 0x1BB03B0 VA: 0x181BB1DB0
	public static Vector3 Parse(string p) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB17A0 Offset: 0x1BAFDA0 VA: 0x181BB17A0
	public static Vector3 GetWithInaccuracy(Vector3 o, float maxAngle) { }

}

