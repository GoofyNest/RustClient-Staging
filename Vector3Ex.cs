public static class Vector3Ex // TypeDefIndex: 6612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1BF0 Offset: 0x1BB01F0 VA: 0x181BB1BF0
	public static Vector3 WithX(Vector3 v, float x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BDC00 Offset: 0x14BC200 VA: 0x1814BDC00
	public static Vector3 WithY(Vector3 v, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1C30 Offset: 0x1BB0230 VA: 0x181BB1C30
	public static Vector3 WithZ(Vector3 v, float z) { }

	// RVA: 0x1BB1CB0 Offset: 0x1BB02B0 VA: 0x181BB1CB0
	public static Vector3 XZ(Vector3 v) { }

	// RVA: 0x1BB0AF0 Offset: 0x1BAF0F0 VA: 0x181BB0AF0
	public static float Distance2D(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB10D0 Offset: 0x1BAF6D0 VA: 0x181BB10D0
	public static float HeightDelta(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB08E0 Offset: 0x1BAEEE0 VA: 0x181BB08E0
	public static Vector3 Direction2D(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB0A20 Offset: 0x1BAF020 VA: 0x181BB0A20
	public static Vector3 Direction(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB1730 Offset: 0x1BAFD30 VA: 0x181BB1730
	public static Vector3 Range(float x, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB17D0 Offset: 0x1BAFDD0 VA: 0x181BB17D0
	public static Vector3 Scale(Vector3 vector, float x, float y, float z) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1980 Offset: 0x1BAFF80 VA: 0x181BB1980
	public static Vector3 SnapTo(Vector3 vector, float snapValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1150 Offset: 0x1BAF750 VA: 0x181BB1150
	public static Vector3 Inverse(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1830 Offset: 0x1BAFE30 VA: 0x181BB1830
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0F90 Offset: 0x1BAF590 VA: 0x181BB0F90
	public static void FastRenormalize(Vector3 n, float scale = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1B00 Offset: 0x1BB0100 VA: 0x181BB1B00
	public static void ToDirectionAndMagnitude(Vector3 value, out Vector3 direction, out float magnitude) { }

	// RVA: 0x1BB07C0 Offset: 0x1BAEDC0 VA: 0x181BB07C0
	public static Vector3 BlendNormals(Vector3 n1, Vector3 n2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB11A0 Offset: 0x1BAF7A0 VA: 0x181BB11A0
	public static bool IsNaNOrInfinity(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0C50 Offset: 0x1BAF250 VA: 0x181BB0C50
	public static float DotRadians(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0C00 Offset: 0x1BAF200 VA: 0x181BB0C00
	public static float DotDegrees(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1240 Offset: 0x1BAF840 VA: 0x181BB1240
	public static float Magnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1A30 Offset: 0x1BB0030 VA: 0x181BB1A30
	public static float SqrMagnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB12C0 Offset: 0x1BAF8C0 VA: 0x181BB12C0
	public static float MagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1A60 Offset: 0x1BB0060 VA: 0x181BB1A60
	public static float SqrMagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1340 Offset: 0x1BAF940 VA: 0x181BB1340
	public static float MagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1A90 Offset: 0x1BB0090 VA: 0x181BB1A90
	public static float SqrMagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB13C0 Offset: 0x1BAF9C0 VA: 0x181BB13C0
	public static float MagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1AC0 Offset: 0x1BB00C0 VA: 0x181BB1AC0
	public static float SqrMagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1C70 Offset: 0x1BB0270 VA: 0x181BB1C70
	public static Vector3 XY3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1CB0 Offset: 0x1BB02B0 VA: 0x181BB1CB0
	public static Vector3 XZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1D30 Offset: 0x1BB0330 VA: 0x181BB1D30
	public static Vector3 YZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAFA0 Offset: 0xAC95A0 VA: 0x180ACAFA0
	public static Vector2 XY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAFD0 Offset: 0xAC95D0 VA: 0x180ACAFD0
	public static Vector2 XZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB040 Offset: 0xAC9640 VA: 0x180ACB040
	public static Vector2 YZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB010 Offset: 0xAC9610 VA: 0x180ACB010
	public static Vector2 YX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB080 Offset: 0xAC9680 VA: 0x180ACB080
	public static Vector2 ZX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACB0C0 Offset: 0xAC96C0 VA: 0x180ACB0C0
	public static Vector2 ZY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1CF0 Offset: 0x1BB02F0 VA: 0x181BB1CF0
	public static Vector3 XZ3D(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1530 Offset: 0x1BAFB30 VA: 0x181BB1530
	public static float Max(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1450 Offset: 0x1BAFA50 VA: 0x181BB1450
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB14D0 Offset: 0x1BAFAD0 VA: 0x181BB14D0
	public static float Max(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB05E0 Offset: 0x1BAEBE0 VA: 0x181BB05E0
	public static Vector4 Abs(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0690 Offset: 0x1BAEC90 VA: 0x181BB0690
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0740 Offset: 0x1BAED40 VA: 0x181BB0740
	public static Vector2 Abs(Vector2 v) { }

	// RVA: 0x1BB15C0 Offset: 0x1BAFBC0 VA: 0x181BB15C0
	public static Vector3 Parse(string p) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0FB0 Offset: 0x1BAF5B0 VA: 0x181BB0FB0
	public static Vector3 GetWithInaccuracy(Vector3 o, float maxAngle) { }

}

