public static class ImageProcessing // TypeDefIndex: 10281
{	// Fields
	private static byte[] signaturePNG; // 0x0
	private static byte[] signatureIHDR; // 0x8

	// Methods

	// RVA: 0x80D570 Offset: 0x80BB70 VA: 0x18080D570
	public static void GaussianBlur2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80D3D0 Offset: 0x80B9D0 VA: 0x18080D3D0
	public static void GaussianBlur2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80CBE0 Offset: 0x80B1E0 VA: 0x18080CBE0
	public static void Average2D(float[] data, int len1, int len2, int iterations = 1) { }

	// RVA: 0x80CD70 Offset: 0x80B370 VA: 0x18080CD70
	public static void Average2D(float[] data, int len1, int len2, int len3, int iterations = 1) { }

	// RVA: 0x80E200 Offset: 0x80C800 VA: 0x18080E200
	public static void Upsample2D(float[] src, int srclen1, int srclen2, float[] dst, int dstlen1, int dstlen2) { }

	// RVA: 0x80E0D0 Offset: 0x80C6D0 VA: 0x18080E0D0
	public static void Upsample2D(float[] src, int srclen1, int srclen2, int srclen3, float[] dst, int dstlen1, int dstlen2, int dstlen3) { }

	// RVA: 0x80CF10 Offset: 0x80B510 VA: 0x18080CF10
	public static void Dilate2D(int[] src, int len1, int len2, int srcmask, int radius, Action<int, int> action) { }

	// RVA: 0x80D060 Offset: 0x80B660 VA: 0x18080D060
	public static void FloodFill2D(int x, int y, int[] data, int len1, int len2, int mask_any, int mask_not, Func<int, int> action) { }

	// RVA: 0x80DCE0 Offset: 0x80C2E0 VA: 0x18080DCE0
	public static bool IsValidPNG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80D920 Offset: 0x80BF20 VA: 0x18080D920
	public static bool IsValidJPG(byte[] data, int maxWidth, int maxHeight) { }

	// RVA: 0x80D8C0 Offset: 0x80BEC0 VA: 0x18080D8C0
	public static bool IsClear(Color32[] data) { }

	// RVA: 0x80E320 Offset: 0x80C920 VA: 0x18080E320
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

	// RVA: 0x820F00 Offset: 0x81F500 VA: 0x180820F00
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

	// RVA: 0x8211C0 Offset: 0x81F7C0 VA: 0x1808211C0
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

	// RVA: 0x8213E0 Offset: 0x81F9E0 VA: 0x1808213E0
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

	// RVA: 0x821690 Offset: 0x81FC90 VA: 0x180821690
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

	// RVA: 0x821AD0 Offset: 0x8200D0 VA: 0x180821AD0
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

	// RVA: 0x821FA0 Offset: 0x8205A0 VA: 0x180821FA0
	internal void <Dilate2D>b__0(int x) { }

	// RVA: 0x822140 Offset: 0x820740 VA: 0x180822140
	internal void <Dilate2D>b__1(int y) { }

}

