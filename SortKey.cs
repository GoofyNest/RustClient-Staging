public class SortKey // TypeDefIndex: 733
{	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x1386320 Offset: 0x1384920 VA: 0x181386320
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1386A10 Offset: 0x1385010 VA: 0x181386A10
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x1386A90 Offset: 0x1385090 VA: 0x181386A90
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x13864F0 Offset: 0x1384AF0 VA: 0x1813864F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13866A0 Offset: 0x1384CA0 VA: 0x1813866A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1386730 Offset: 0x1384D30 VA: 0x181386730 Slot: 3
	public override string ToString() { }

	// RVA: 0x1386A60 Offset: 0x1385060 VA: 0x181386A60
	internal void .ctor() { }

}

