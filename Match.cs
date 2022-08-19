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

	// RVA: 0x14C17F0 Offset: 0x14BFDF0 VA: 0x1814C17F0
	public static Match get_Empty() { }

	// RVA: 0x14C1610 Offset: 0x14BFC10 VA: 0x1814C1610
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x14C1280 Offset: 0x14BF880 VA: 0x1814C1280 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x14C1850 Offset: 0x14BFE50 VA: 0x1814C1850 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x14C11F0 Offset: 0x14BF7F0 VA: 0x1814C11F0
	public Match NextMatch() { }

	// RVA: 0x14C0E90 Offset: 0x14BF490 VA: 0x1814C0E90 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x14C1040 Offset: 0x14BF640 VA: 0x1814C1040
	internal string LastGroupToStringImpl() { }

	// RVA: 0x14C0A00 Offset: 0x14BF000 VA: 0x1814C0A00 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x14C0D30 Offset: 0x14BF330 VA: 0x1814C0D30 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x14C1240 Offset: 0x14BF840 VA: 0x1814C1240 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x14C0FA0 Offset: 0x14BF5A0 VA: 0x1814C0FA0 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x14C1070 Offset: 0x14BF670 VA: 0x1814C1070 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x14C1130 Offset: 0x14BF730 VA: 0x1814C1130 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x14C1340 Offset: 0x14BF940 VA: 0x1814C1340 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x14C1580 Offset: 0x14BFB80 VA: 0x1814C1580
	private static void .cctor() { }

	// RVA: 0x14C17C0 Offset: 0x14BFDC0 VA: 0x1814C17C0
	internal void .ctor() { }

}

