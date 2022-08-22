public class NewsSource : MonoBehaviour // TypeDefIndex: 11127
{	// Fields
	private static readonly Regex BbcodeParse; // 0x0
	public RustText title; // 0x18
	public RustText date; // 0x20
	public RustText authorName; // 0x28
	public HttpImage coverImage; // 0x30
	public RectTransform container; // 0x38
	public Button button; // 0x40
	public RustText paragraphTemplate; // 0x48
	public HttpImage imageTemplate; // 0x50
	public HttpImage youtubeTemplate; // 0x58
	private static readonly string[] BulletSeparators; // 0x8

	// Methods

	// RVA: 0x9D1E10 Offset: 0x9D0410 VA: 0x1809D1E10
	public void Awake() { }

	// RVA: 0x9D1F70 Offset: 0x9D0570 VA: 0x1809D1F70
	public void OnEnable() { }

	// RVA: 0x9D2D50 Offset: 0x9D1350 VA: 0x1809D2D50
	public void SetStory(SteamNewsSource.Story story) { }

	// RVA: 0x9D2000 Offset: 0x9D0600 VA: 0x1809D2000
	private void ParseBbcode(ref NewsSource.ParagraphBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	// RVA: 0x9D1E60 Offset: 0x9D0460 VA: 0x1809D1E60
	private static string[] GetBulletPoints(string listContent) { }

	// RVA: 0x9D1AD0 Offset: 0x9D00D0 VA: 0x1809D1AD0
	private void AppendParagraph(ref NewsSource.ParagraphBuilder currentParagraph) { }

	// RVA: 0x9D1A10 Offset: 0x9D0010 VA: 0x1809D1A10
	private void AppendImage(ref NewsSource.ParagraphBuilder currentParagraph, string url) { }

	// RVA: 0x9D1C90 Offset: 0x9D0290 VA: 0x1809D1C90
	private void AppendYouTube(ref NewsSource.ParagraphBuilder currentParagraph, string videoId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x9D3070 Offset: 0x9D1670 VA: 0x1809D3070
	private static void .cctor() { }

}

private struct NewsSource.ParagraphBuilder // TypeDefIndex: 11128
{	// Fields
	public StringBuilder StringBuilder; // 0x0
	public List<string> Links; // 0x8

	// Methods

	// RVA: 0x9EB5D0 Offset: 0x9E9BD0 VA: 0x1809EB5D0
	public static NewsSource.ParagraphBuilder New() { }

	// RVA: 0xFB190 Offset: 0xFA590 VA: 0x1800FB190
	public void AppendLine() { }

	// RVA: 0xFB1B0 Offset: 0xFA5B0 VA: 0x1800FB1B0
	public void Append(string text) { }

}

private sealed class NewsSource.<>c__DisplayClass12_0 // TypeDefIndex: 11129
{	// Fields
	public SteamNewsSource.Story story; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9EC050 Offset: 0x9EA650 VA: 0x1809EC050
	internal void <SetStory>b__0() { }

	// RVA: 0x9EC0F0 Offset: 0x9EA6F0 VA: 0x1809EC0F0
	internal Manifest.NewsInfo.BlogInfo <SetStory>g__GetBlogPost|1() { }

}

private sealed class NewsSource.<>c // TypeDefIndex: 11130
{	// Fields
	public static readonly NewsSource.<>c <>9; // 0x0
	public static Func<Manifest.NewsInfo.BlogInfo, string> <>9__12_2; // 0x8

	// Methods

	// RVA: 0x9EC330 Offset: 0x9EA930 VA: 0x1809EC330
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B720 Offset: 0x939D20 VA: 0x18093B720
	internal string <SetStory>b__12_2(Manifest.NewsInfo.BlogInfo b) { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11131
{	// Fields
	public string videoUrl; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9EC2B0 Offset: 0x9EA8B0 VA: 0x1809EC2B0
	internal void <AppendYouTube>b__0() { }

}

