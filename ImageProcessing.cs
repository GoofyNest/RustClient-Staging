public static class ImageProcessing // TypeDefIndex: 10281
{	// Fields
	private static byte[] signaturePNG; // 0x0
	private static byte[] signatureIHDR; // 0x8

	// Methods

	// RVA: 0x80CFE0 Offset: 0x80B5E0 VA: 0x18080CFE0
	public static void GaussianBlur2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80CE40 Offset: 0x80B440 VA: 0x18080CE40
	public static void GaussianBlur2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80C650 Offset: 0x80AC50 VA: 0x18080C650
	public static void Average2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80C7E0 Offset: 0x80ADE0 VA: 0x18080C7E0
	public static void Average2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80DC70 Offset: 0x80C270 VA: 0x18080DC70
	public static void Upsample2D(float[] src, int srclen1, int srclen2, float[] dst, int dstlen1, int dstlen2) { }

	// RVA: 0x80DB40 Offset: 0x80C140 VA: 0x18080DB40
	public static void Upsample2D(float[] src, int srclen1, int srclen2, int srclen3, float[] dst, int dstlen1, int dstlen2, int dstlen3) { }

	// RVA: 0x80C980 Offset: 0x80AF80 VA: 0x18080C980
	public static void Dilate2D(int[] src, int len1, int len2, int srcmask, int radius, Action<int, int> action) { }

	// RVA: 0x80CAD0 Offset: 0x80B0D0 VA: 0x18080CAD0
	public static void FloodFill2D(int x, int y, int[] data, int len1, int len2, int mask_any, int mask_not, Func<int, int> action) { }

	// RVA: 0x80D750 Offset: 0x80BD50 VA: 0x18080D750
	public static bool IsValidPNG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80D390 Offset: 0x80B990 VA: 0x18080D390
	public static bool IsValidJPG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80D330 Offset: 0x80B930 VA: 0x18080D330
	public static bool IsClear(Color32[] data) { }

	// RVA: 0x80DD90 Offset: 0x80C390 VA: 0x18080DD90
	private static void .cctor() { }

}

private sealed class ImageProcessing.<>c__DisplayClass1_0 // TypeDefIndex: 10282
{	// Fields
	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public int len3; // 0x20
	public float[] dst; // 0x28
	public Action<int> <>9__0; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x820970 Offset: 0x81EF70 VA: 0x180820970
	internal void <GaussianBlur2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass2_0 // TypeDefIndex: 10283
{	// Fields
	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public float[] dst; // 0x20
	public Action<int> <>9__0; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x820C30 Offset: 0x81F230 VA: 0x180820C30
	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass3_0 // TypeDefIndex: 10284
{	// Fields
	public int len1; // 0x10
	public int len2; // 0x14
	public float[] src; // 0x18
	public int len3; // 0x20
	public float[] dst; // 0x28
	public Action<int> <>9__0; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x820E50 Offset: 0x81F450 VA: 0x180820E50
	internal void <Average2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass4_0 // TypeDefIndex: 10285
{	// Fields
	public int srclen1; // 0x10
	public int srclen2; // 0x14
	public float[] src; // 0x18
	public float[] dst; // 0x20
	public int dstlen2; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x821100 Offset: 0x81F700 VA: 0x180821100
	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass5_0 // TypeDefIndex: 10286
{	// Fields
	public int srclen1; // 0x10
	public int srclen2; // 0x14
	public float[] src; // 0x18
	public int srclen3; // 0x20
	public float[] dst; // 0x28
	public int dstlen2; // 0x30
	public int dstlen3; // 0x34

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x821540 Offset: 0x81FB40 VA: 0x180821540
	internal void <Upsample2D>b__0(int x) { }

}

private sealed class ImageProcessing.<>c__DisplayClass6_0 // TypeDefIndex: 10287
{	// Fields
	public int radius; // 0x10
	public int[] src; // 0x18
	public int len2; // 0x20
	public int srcmask; // 0x24
	public Action<int, int> action; // 0x28
	public int len1; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x821A10 Offset: 0x820010 VA: 0x180821A10
	internal void <Dilate2D>b__0(int x) { }

	// RVA: 0x821BB0 Offset: 0x8201B0 VA: 0x180821BB0
	internal void <Dilate2D>b__1(int y) { }

}

