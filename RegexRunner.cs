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

	// RVA: 0x16B6880 Offset: 0x16B4E80 VA: 0x1816B6880
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x16B6C30 Offset: 0x16B5230 VA: 0x1816B6C30
	private void StartTimeoutWatch() { }

	// RVA: 0x16B5CE0 Offset: 0x16B42E0 VA: 0x1816B5CE0
	protected void CheckTimeout() { }

	// RVA: 0x16B5F00 Offset: 0x16B4500 VA: 0x1816B5F00
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x16B6360 Offset: 0x16B4960 VA: 0x1816B6360
	private void InitMatch() { }

	// RVA: 0x16B6C60 Offset: 0x16B5260 VA: 0x1816B6C60
	private Match TidyMatch(bool quick) { }

	// RVA: 0x16B6210 Offset: 0x16B4810 VA: 0x1816B6210
	protected void EnsureStorage() { }

	// RVA: 0x16B65D0 Offset: 0x16B4BD0 VA: 0x1816B65D0
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B66C0 Offset: 0x16B4CC0 VA: 0x1816B66C0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B6160 Offset: 0x16B4760 VA: 0x1816B6160
	protected void DoubleTrack() { }

	// RVA: 0x16B60B0 Offset: 0x16B46B0 VA: 0x1816B60B0
	protected void DoubleStack() { }

	// RVA: 0x16B6000 Offset: 0x16B4600 VA: 0x1816B6000
	protected void DoubleCrawl() { }

	// RVA: 0x16B5DF0 Offset: 0x16B43F0 VA: 0x1816B5DF0
	protected void Crawl(int i) { }

	// RVA: 0x16B6840 Offset: 0x16B4E40 VA: 0x1816B6840
	protected int Popcrawl() { }

	// RVA: 0x16B5EE0 Offset: 0x16B44E0 VA: 0x1816B5EE0
	protected int Crawlpos() { }

	// RVA: 0x16B5C50 Offset: 0x16B4250 VA: 0x1816B5C50
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x16B6CC0 Offset: 0x16B52C0 VA: 0x1816B6CC0
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x16B6DE0 Offset: 0x16B53E0 VA: 0x1816B6DE0
	protected void Uncapture() { }

	// RVA: 0x16B67B0 Offset: 0x16B4DB0 VA: 0x1816B67B0
	protected bool IsMatched(int cap) { }

	// RVA: 0x16B67E0 Offset: 0x16B4DE0 VA: 0x1816B67E0
	protected int MatchIndex(int cap) { }

	// RVA: 0x16B6810 Offset: 0x16B4E10 VA: 0x1816B6810
	protected int MatchLength(int cap) { }

}

