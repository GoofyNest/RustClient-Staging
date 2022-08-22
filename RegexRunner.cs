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

	// RVA: 0x16B8C90 Offset: 0x16B7290 VA: 0x1816B8C90
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x16B9040 Offset: 0x16B7640 VA: 0x1816B9040
	private void StartTimeoutWatch() { }

	// RVA: 0x16B80F0 Offset: 0x16B66F0 VA: 0x1816B80F0
	protected void CheckTimeout() { }

	// RVA: 0x16B8310 Offset: 0x16B6910 VA: 0x1816B8310
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x16B8770 Offset: 0x16B6D70 VA: 0x1816B8770
	private void InitMatch() { }

	// RVA: 0x16B9070 Offset: 0x16B7670 VA: 0x1816B9070
	private Match TidyMatch(bool quick) { }

	// RVA: 0x16B8620 Offset: 0x16B6C20 VA: 0x1816B8620
	protected void EnsureStorage() { }

	// RVA: 0x16B89E0 Offset: 0x16B6FE0 VA: 0x1816B89E0
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B8AD0 Offset: 0x16B70D0 VA: 0x1816B8AD0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x16B8570 Offset: 0x16B6B70 VA: 0x1816B8570
	protected void DoubleTrack() { }

	// RVA: 0x16B84C0 Offset: 0x16B6AC0 VA: 0x1816B84C0
	protected void DoubleStack() { }

	// RVA: 0x16B8410 Offset: 0x16B6A10 VA: 0x1816B8410
	protected void DoubleCrawl() { }

	// RVA: 0x16B8200 Offset: 0x16B6800 VA: 0x1816B8200
	protected void Crawl(int i) { }

	// RVA: 0x16B8C50 Offset: 0x16B7250 VA: 0x1816B8C50
	protected int Popcrawl() { }

	// RVA: 0x16B82F0 Offset: 0x16B68F0 VA: 0x1816B82F0
	protected int Crawlpos() { }

	// RVA: 0x16B8060 Offset: 0x16B6660 VA: 0x1816B8060
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x16B90D0 Offset: 0x16B76D0 VA: 0x1816B90D0
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x16B91F0 Offset: 0x16B77F0 VA: 0x1816B91F0
	protected void Uncapture() { }

	// RVA: 0x16B8BC0 Offset: 0x16B71C0 VA: 0x1816B8BC0
	protected bool IsMatched(int cap) { }

	// RVA: 0x16B8BF0 Offset: 0x16B71F0 VA: 0x1816B8BF0
	protected int MatchIndex(int cap) { }

	// RVA: 0x16B8C20 Offset: 0x16B7220 VA: 0x1816B8C20
	protected int MatchLength(int cap) { }

}

