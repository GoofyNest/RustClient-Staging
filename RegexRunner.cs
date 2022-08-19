public abstract class RegexRunner // TypeDefIndex: 2629
{	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int timeout; // 0x70
	private bool ignoreTimeout; // 0x74
	private int timeoutOccursAt; // 0x78
	private const int TimeoutCheckFrequency = 1000;
	private int timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected internal void .ctor() { }

	// RVA: 0x16B89D0 Offset: 0x16B6FD0 VA: 0x1816B89D0
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x16B8D80 Offset: 0x16B7380 VA: 0x1816B8D80
	private void StartTimeoutWatch() { }

	// RVA: 0x16B7E30 Offset: 0x16B6430 VA: 0x1816B7E30
	protected void CheckTimeout() { }

	// RVA: 0x16B8050 Offset: 0x16B6650 VA: 0x1816B8050
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x16B84B0 Offset: 0x16B6AB0 VA: 0x1816B84B0
	private void InitMatch() { }

	// RVA: 0x16B8DB0 Offset: 0x16B73B0 VA: 0x1816B8DB0
	private Match TidyMatch(bool quick) { }

	// RVA: 0x16B8360 Offset: 0x16B6960 VA: 0x1816B8360
	protected void EnsureStorage() { }

	// RVA: 0x16B8720 Offset: 0x16B6D20 VA: 0x1816B8720
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B8810 Offset: 0x16B6E10 VA: 0x1816B8810
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B82B0 Offset: 0x16B68B0 VA: 0x1816B82B0
	protected void DoubleTrack() { }

	// RVA: 0x16B8200 Offset: 0x16B6800 VA: 0x1816B8200
	protected void DoubleStack() { }

	// RVA: 0x16B8150 Offset: 0x16B6750 VA: 0x1816B8150
	protected void DoubleCrawl() { }

	// RVA: 0x16B7F40 Offset: 0x16B6540 VA: 0x1816B7F40
	protected void Crawl(int i) { }

	// RVA: 0x16B8990 Offset: 0x16B6F90 VA: 0x1816B8990
	protected int Popcrawl() { }

	// RVA: 0x16B8030 Offset: 0x16B6630 VA: 0x1816B8030
	protected int Crawlpos() { }

	// RVA: 0x16B7DA0 Offset: 0x16B63A0 VA: 0x1816B7DA0
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x16B8E10 Offset: 0x16B7410 VA: 0x1816B8E10
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x16B8F30 Offset: 0x16B7530 VA: 0x1816B8F30
	protected void Uncapture() { }

	// RVA: 0x16B8900 Offset: 0x16B6F00 VA: 0x1816B8900
	protected bool IsMatched(int cap) { }

	// RVA: 0x16B8930 Offset: 0x16B6F30 VA: 0x1816B8930
	protected int MatchIndex(int cap) { }

	// RVA: 0x16B8960 Offset: 0x16B6F60 VA: 0x1816B8960
	protected int MatchLength(int cap) { }

}

