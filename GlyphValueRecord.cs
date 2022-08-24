internal struct GlyphValueRecord // TypeDefIndex: 4113
{	[NativeNameAttribute] // RVA: 0x88560 Offset: 0x87960 VA: 0x180088560
	[SerializeField] // RVA: 0x88560 Offset: 0x87960 VA: 0x180088560
	private float m_XPlacement; // 0x0
	[NativeNameAttribute] // RVA: 0x888D0 Offset: 0x87CD0 VA: 0x1800888D0
	[SerializeField] // RVA: 0x888D0 Offset: 0x87CD0 VA: 0x1800888D0
	private float m_YPlacement; // 0x4
	[NativeNameAttribute] // RVA: 0x88A10 Offset: 0x87E10 VA: 0x180088A10
	[SerializeField] // RVA: 0x88A10 Offset: 0x87E10 VA: 0x180088A10
	private float m_XAdvance; // 0x8
	[NativeNameAttribute] // RVA: 0x88CC0 Offset: 0x880C0 VA: 0x180088CC0
	[SerializeField] // RVA: 0x88CC0 Offset: 0x880C0 VA: 0x180088CC0
	private float m_YAdvance; // 0xC

	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }


	public float get_xPlacement() { }

	public float get_yPlacement() { }

	public float get_xAdvance() { }

	public float get_yAdvance() { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

}

public struct GlyphValueRecord_Legacy // TypeDefIndex: 6767
{	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC


	internal void .ctor(GlyphValueRecord valueRecord) { }

	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }

}

