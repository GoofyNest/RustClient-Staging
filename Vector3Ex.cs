public static class Vector3Ex // TypeDefIndex: 6612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1AF0 Offset: 0x1BB00F0 VA: 0x181BB1AF0
	public static Vector3 WithX(Vector3 v, float x) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14BD940 Offset: 0x14BBF40 VA: 0x1814BD940
	public static Vector3 WithY(Vector3 v, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1B30 Offset: 0x1BB0130 VA: 0x181BB1B30
	public static Vector3 WithZ(Vector3 v, float z) { }

	// RVA: 0x1BB1BB0 Offset: 0x1BB01B0 VA: 0x181BB1BB0
	public static Vector3 XZ(Vector3 v) { }

	// RVA: 0x1BB09F0 Offset: 0x1BAEFF0 VA: 0x181BB09F0
	public static float Distance2D(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB0FD0 Offset: 0x1BAF5D0 VA: 0x181BB0FD0
	public static float HeightDelta(Vector3 a, Vector3 b) { }

	// RVA: 0x1BB07E0 Offset: 0x1BAEDE0 VA: 0x181BB07E0
	public static Vector3 Direction2D(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB0920 Offset: 0x1BAEF20 VA: 0x181BB0920
	public static Vector3 Direction(Vector3 aimAt, Vector3 aimFrom) { }

	// RVA: 0x1BB1630 Offset: 0x1BAFC30 VA: 0x181BB1630
	public static Vector3 Range(float x, float y) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB16D0 Offset: 0x1BAFCD0 VA: 0x181BB16D0
	public static Vector3 Scale(Vector3 vector, float x, float y, float z) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1880 Offset: 0x1BAFE80 VA: 0x181BB1880
	public static Vector3 SnapTo(Vector3 vector, float snapValue) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1050 Offset: 0x1BAF650 VA: 0x181BB1050
	public static Vector3 Inverse(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1730 Offset: 0x1BAFD30 VA: 0x181BB1730
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB0E90 Offset: 0x1BAF490 VA: 0x181BB0E90
	public static void FastRenormalize(Vector3 n, float scale = 1) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1A00 Offset: 0x1BB0000 VA: 0x181BB1A00
	public static void ToDirectionAndMagnitude(Vector3 value, out Vector3 direction, out float magnitude) { }

	// RVA: 0x1BB06C0 Offset: 0x1BAECC0 VA: 0x181BB06C0
	public static Vector3 BlendNormals(Vector3 n1, Vector3 n2) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB10A0 Offset: 0x1BAF6A0 VA: 0x181BB10A0
	public static bool IsNaNOrInfinity(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB0B50 Offset: 0x1BAF150 VA: 0x181BB0B50
	public static float DotRadians(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB0B00 Offset: 0x1BAF100 VA: 0x181BB0B00
	public static float DotDegrees(Vector3 a, Vector3 b) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1140 Offset: 0x1BAF740 VA: 0x181BB1140
	public static float Magnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1930 Offset: 0x1BAFF30 VA: 0x181BB1930
	public static float SqrMagnitude2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB11C0 Offset: 0x1BAF7C0 VA: 0x181BB11C0
	public static float MagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1960 Offset: 0x1BAFF60 VA: 0x181BB1960
	public static float SqrMagnitudeXY(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1240 Offset: 0x1BAF840 VA: 0x181BB1240
	public static float MagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1990 Offset: 0x1BAFF90 VA: 0x181BB1990
	public static float SqrMagnitudeXZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB12C0 Offset: 0x1BAF8C0 VA: 0x181BB12C0
	public static float MagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB19C0 Offset: 0x1BAFFC0 VA: 0x181BB19C0
	public static float SqrMagnitudeYZ(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1B70 Offset: 0x1BB0170 VA: 0x181BB1B70
	public static Vector3 XY3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1BB0 Offset: 0x1BB01B0 VA: 0x181BB1BB0
	public static Vector3 XZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1C30 Offset: 0x1BB0230 VA: 0x181BB1C30
	public static Vector3 YZ3D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACACE0 Offset: 0xAC92E0 VA: 0x180ACACE0
	public static Vector2 XY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAD10 Offset: 0xAC9310 VA: 0x180ACAD10
	public static Vector2 XZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAD80 Offset: 0xAC9380 VA: 0x180ACAD80
	public static Vector2 YZ2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAD50 Offset: 0xAC9350 VA: 0x180ACAD50
	public static Vector2 YX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACADC0 Offset: 0xAC93C0 VA: 0x180ACADC0
	public static Vector2 ZX2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xACAE00 Offset: 0xAC9400 VA: 0x180ACAE00
	public static Vector2 ZY2D(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1BF0 Offset: 0x1BB01F0 VA: 0x181BB1BF0
	public static Vector3 XZ3D(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1430 Offset: 0x1BAFA30 VA: 0x181BB1430
	public static float Max(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB1350 Offset: 0x1BAF950 VA: 0x181BB1350
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB13D0 Offset: 0x1BAF9D0 VA: 0x181BB13D0
	public static float Max(Vector2 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB04E0 Offset: 0x1BAEAE0 VA: 0x181BB04E0
	public static Vector4 Abs(Vector4 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB0590 Offset: 0x1BAEB90 VA: 0x181BB0590
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB0640 Offset: 0x1BAEC40 VA: 0x181BB0640
	public static Vector2 Abs(Vector2 v) { }

	// RVA: 0x1BB14C0 Offset: 0x1BAFAC0 VA: 0x181BB14C0
	public static Vector3 Parse(string p) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BB0EB0 Offset: 0x1BAF4B0 VA: 0x181BB0EB0
	public static Vector3 GetWithInaccuracy(Vector3 o, float maxAngle) { }

}

