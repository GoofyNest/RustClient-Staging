internal sealed class InfTree // TypeDefIndex: 6952
{	// Fields
	internal static readonly int[] fixed_tl; // 0x0
	internal static readonly int[] fixed_td; // 0x8
	internal static readonly int[] cplens; // 0x10
	internal static readonly int[] cplext; // 0x18
	internal static readonly int[] cpdist; // 0x20
	internal static readonly int[] cpdext; // 0x28
	internal int[] hn; // 0x10
	internal int[] v; // 0x18
	internal int[] c; // 0x20
	internal int[] r; // 0x28
	internal int[] u; // 0x30
	internal int[] x; // 0x38

	// Methods

	// RVA: 0x21CF5D0 Offset: 0x21CDBD0 VA: 0x1821CF5D0
	private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v) { }

	// RVA: 0x21D0180 Offset: 0x21CE780 VA: 0x1821D0180
	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z) { }

	// RVA: 0x21D02E0 Offset: 0x21CE8E0 VA: 0x1821D02E0
	internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z) { }

	// RVA: 0x21D0600 Offset: 0x21CEC00 VA: 0x1821D0600
	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z) { }

	// RVA: 0x21D07B0 Offset: 0x21CEDB0 VA: 0x1821D07B0
	private void initWorkArea(int vsize) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21CF410 Offset: 0x21CDA10 VA: 0x1821CF410
	private static void .cctor() { }

}
