public static class ImageProcessing // TypeDefIndex: 10281
{	// Fields
	private static byte[] signaturePNG; // 0x0
	private static byte[] signatureIHDR; // 0x8

	// Methods

	// RVA: 0x80CED0 Offset: 0x80B4D0 VA: 0x18080CED0
	public static void GaussianBlur2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80CD30 Offset: 0x80B330 VA: 0x18080CD30
	public static void GaussianBlur2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80C540 Offset: 0x80AB40 VA: 0x18080C540
	public static void Average2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80C6D0 Offset: 0x80ACD0 VA: 0x18080C6D0
	public static void Average2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80DB60 Offset: 0x80C160 VA: 0x18080DB60
	public static void Upsample2D(float[] src, int srclen1, int srclen2, float[] dst, int dstlen1, int dstlen2) { }

	// RVA: 0x80DA30 Offset: 0x80C030 VA: 0x18080DA30
	public static void Upsample2D(float[] src, int srclen1, int srclen2, int srclen3, float[] dst, int dstlen1, int dstlen2, int dstlen3) { }

	// RVA: 0x80C870 Offset: 0x80AE70 VA: 0x18080C870
	public static void Dilate2D(int[] src, int len1, int len2, int srcmask, int radius, Action<int, int> action) { }

	// RVA: 0x80C9C0 Offset: 0x80AFC0 VA: 0x18080C9C0
	public static void FloodFill2D(int x, int y, int[] data, int len1, int len2, int mask_any, int mask_not, Func<int, int> action) { }

	// RVA: 0x80D640 Offset: 0x80BC40 VA: 0x18080D640
	public static bool IsValidPNG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80D280 Offset: 0x80B880 VA: 0x18080D280
	public static bool IsValidJPG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80D220 Offset: 0x80B820 VA: 0x18080D220
	public static bool IsClear(Color32[] data) { }

	// RVA: 0x80DC80 Offset: 0x80C280 VA: 0x18080DC80
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

	// RVA: 0x820860 Offset: 0x81EE60 VA: 0x180820860
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

	// RVA: 0x820B20 Offset: 0x81F120 VA: 0x180820B20
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

	// RVA: 0x820D40 Offset: 0x81F340 VA: 0x180820D40
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

	// RVA: 0x820FF0 Offset: 0x81F5F0 VA: 0x180820FF0
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

	// RVA: 0x821430 Offset: 0x81FA30 VA: 0x180821430
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

	// RVA: 0x821900 Offset: 0x81FF00 VA: 0x180821900
	internal void <Dilate2D>b__0(int x) { }

	// RVA: 0x821AA0 Offset: 0x8200A0 VA: 0x180821AA0
	internal void <Dilate2D>b__1(int y) { }

}

