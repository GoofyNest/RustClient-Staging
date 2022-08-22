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

	// RVA: 0x14C1AB0 Offset: 0x14C00B0 VA: 0x1814C1AB0
	public static Match get_Empty() { }

	// RVA: 0x14C18D0 Offset: 0x14BFED0 VA: 0x1814C18D0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x14C1540 Offset: 0x14BFB40 VA: 0x1814C1540 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x14C1B10 Offset: 0x14C0110 VA: 0x1814C1B10 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x14C14B0 Offset: 0x14BFAB0 VA: 0x1814C14B0
	public Match NextMatch() { }

	// RVA: 0x14C1150 Offset: 0x14BF750 VA: 0x1814C1150 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x14C1300 Offset: 0x14BF900 VA: 0x1814C1300
	internal string LastGroupToStringImpl() { }

	// RVA: 0x14C0CC0 Offset: 0x14BF2C0 VA: 0x1814C0CC0 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x14C0FF0 Offset: 0x14BF5F0 VA: 0x1814C0FF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x14C1500 Offset: 0x14BFB00 VA: 0x1814C1500 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x14C1260 Offset: 0x14BF860 VA: 0x1814C1260 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x14C1330 Offset: 0x14BF930 VA: 0x1814C1330 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x14C13F0 Offset: 0x14BF9F0 VA: 0x1814C13F0 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x14C1600 Offset: 0x14BFC00 VA: 0x1814C1600 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x14C1840 Offset: 0x14BFE40 VA: 0x1814C1840
	private static void .cctor() { }

	// RVA: 0x14C1A80 Offset: 0x14C0080 VA: 0x1814C1A80
	internal void .ctor() { }

}

