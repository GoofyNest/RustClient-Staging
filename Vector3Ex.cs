public static class Vector3Ex // TypeDefIndex: 6612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1930 Offset: 0x1BAFF30 VA: 0x181BB1930
	public static Vector3 WithX(Vector3 v, float x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BD940 Offset: 0x14BBF40 VA: 0x1814BD940
	public static Vector3 WithY(Vector3 v, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1970 Offset: 0x1BAFF70 VA: 0x181BB1970
	public static Vector3 WithZ(Vector3 v, float z) { }

	// RVA: 0x1BB19F0 Offset: 0x1BAFFF0 VA: 0x181BB19F0
	public static Vector3 XZ(Vector3 v) { }

	// RVA: 0x1BB0830 Offset: 0x1BAEE30 VA: 0x181BB0830
	public static float Distance2D(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB0E10 Offset: 0x1BAF410 VA: 0x181BB0E10
	public static float HeightDelta(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB0620 Offset: 0x1BAEC20 VA: 0x181BB0620
	public static Vector3 Direction2D(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB0760 Offset: 0x1BAED60 VA: 0x181BB0760
	public static Vector3 Direction(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB1470 Offset: 0x1BAFA70 VA: 0x181BB1470
	public static Vector3 Range(float x, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1510 Offset: 0x1BAFB10 VA: 0x181BB1510
	public static Vector3 Scale(Vector3 vector, float x, float y, float z) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB16C0 Offset: 0x1BAFCC0 VA: 0x181BB16C0
	public static Vector3 SnapTo(Vector3 vector, float snapValue) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0E90 Offset: 0x1BAF490 VA: 0x181BB0E90
	public static Vector3 Inverse(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1570 Offset: 0x1BAFB70 VA: 0x181BB1570
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0CD0 Offset: 0x1BAF2D0 VA: 0x181BB0CD0
	public static void FastRenormalize(Vector3 n, float scale = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1840 Offset: 0x1BAFE40 VA: 0x181BB1840
	public static void ToDirectionAndMagnitude(Vector3 value, out Vector3 direction, out float magnitude) { }

	// RVA: 0x1BB0500 Offset: 0x1BAEB00 VA: 0x181BB0500
	public static Vector3 BlendNormals(Vector3 n1, Vector3 n2) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0EE0 Offset: 0x1BAF4E0 VA: 0x181BB0EE0
	public static bool IsNaNOrInfinity(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0990 Offset: 0x1BAEF90 VA: 0x181BB0990
	public static float DotRadians(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0940 Offset: 0x1BAEF40 VA: 0x181BB0940
	public static float DotDegrees(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0F80 Offset: 0x1BAF580 VA: 0x181BB0F80
	public static float Magnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1770 Offset: 0x1BAFD70 VA: 0x181BB1770
	public static float SqrMagnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1000 Offset: 0x1BAF600 VA: 0x181BB1000
	public static float MagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB17A0 Offset: 0x1BAFDA0 VA: 0x181BB17A0
	public static float SqrMagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1080 Offset: 0x1BAF680 VA: 0x181BB1080
	public static float MagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB17D0 Offset: 0x1BAFDD0 VA: 0x181BB17D0
	public static float SqrMagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1100 Offset: 0x1BAF700 VA: 0x181BB1100
	public static float MagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1800 Offset: 0x1BAFE00 VA: 0x181BB1800
	public static float SqrMagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB19B0 Offset: 0x1BAFFB0 VA: 0x181BB19B0
	public static Vector3 XY3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB19F0 Offset: 0x1BAFFF0 VA: 0x181BB19F0
	public static Vector3 XZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1A70 Offset: 0x1BB0070 VA: 0x181BB1A70
	public static Vector3 YZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACACE0 Offset: 0xAC92E0 VA: 0x180ACACE0
	public static Vector2 XY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAD10 Offset: 0xAC9310 VA: 0x180ACAD10
	public static Vector2 XZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAD80 Offset: 0xAC9380 VA: 0x180ACAD80
	public static Vector2 YZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAD50 Offset: 0xAC9350 VA: 0x180ACAD50
	public static Vector2 YX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACADC0 Offset: 0xAC93C0 VA: 0x180ACADC0
	public static Vector2 ZX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACAE00 Offset: 0xAC9400 VA: 0x180ACAE00
	public static Vector2 ZY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1A30 Offset: 0x1BB0030 VA: 0x181BB1A30
	public static Vector3 XZ3D(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1270 Offset: 0x1BAF870 VA: 0x181BB1270
	public static float Max(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1190 Offset: 0x1BAF790 VA: 0x181BB1190
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB1210 Offset: 0x1BAF810 VA: 0x181BB1210
	public static float Max(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0320 Offset: 0x1BAE920 VA: 0x181BB0320
	public static Vector4 Abs(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB03D0 Offset: 0x1BAE9D0 VA: 0x181BB03D0
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0480 Offset: 0x1BAEA80 VA: 0x181BB0480
	public static Vector2 Abs(Vector2 v) { }

	// RVA: 0x1BB1300 Offset: 0x1BAF900 VA: 0x181BB1300
	public static Vector3 Parse(string p) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0CF0 Offset: 0x1BAF2F0 VA: 0x181BB0CF0
	public static Vector3 GetWithInaccuracy(Vector3 o, float maxAngle) { }

}

