public class Match : Group // TypeDefIndex: 2620
{	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal int[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x14C0B80 Offset: 0x14BF180 VA: 0x1814C0B80
	public static Match get_Empty() { }

	// RVA: 0x14C09A0 Offset: 0x14BEFA0 VA: 0x1814C09A0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x14C0610 Offset: 0x14BEC10 VA: 0x1814C0610 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x14C0BE0 Offset: 0x14BF1E0 VA: 0x1814C0BE0 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x14C0580 Offset: 0x14BEB80 VA: 0x1814C0580
	public Match NextMatch() { }

	// RVA: 0x14C0220 Offset: 0x14BE820 VA: 0x1814C0220 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x14C03D0 Offset: 0x14BE9D0 VA: 0x1814C03D0
	internal string LastGroupToStringImpl() { }

	// RVA: 0x14BFD90 Offset: 0x14BE390 VA: 0x1814BFD90 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x14C00C0 Offset: 0x14BE6C0 VA: 0x1814C00C0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x14C05D0 Offset: 0x14BEBD0 VA: 0x1814C05D0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x14C0330 Offset: 0x14BE930 VA: 0x1814C0330 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x14C0400 Offset: 0x14BEA00 VA: 0x1814C0400 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x14C04C0 Offset: 0x14BEAC0 VA: 0x1814C04C0 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x14C06D0 Offset: 0x14BECD0 VA: 0x1814C06D0 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x14C0910 Offset: 0x14BEF10 VA: 0x1814C0910
	private static void .cctor() { }

	// RVA: 0x14C0B50 Offset: 0x14BF150 VA: 0x1814C0B50
	internal void .ctor() { }

}

