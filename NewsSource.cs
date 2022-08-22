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

	// RVA: 0x9D1920 Offset: 0x9CFF20 VA: 0x1809D1920
	public void Awake() { }

	// RVA: 0x9D1A80 Offset: 0x9D0080 VA: 0x1809D1A80
	public void OnEnable() { }

	// RVA: 0x9D2860 Offset: 0x9D0E60 VA: 0x1809D2860
	public void SetStory(SteamNewsSource.Story story) { }

	// RVA: 0x9D1B10 Offset: 0x9D0110 VA: 0x1809D1B10
	private void ParseBbcode(ref NewsSource.ParagraphBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	// RVA: 0x9D1970 Offset: 0x9CFF70 VA: 0x1809D1970
	private static string[] GetBulletPoints(string listContent) { }

	// RVA: 0x9D15E0 Offset: 0x9CFBE0 VA: 0x1809D15E0
	private void AppendParagraph(ref NewsSource.ParagraphBuilder currentParagraph) { }

	// RVA: 0x9D1520 Offset: 0x9CFB20 VA: 0x1809D1520
	private void AppendImage(ref NewsSource.ParagraphBuilder currentParagraph, string url) { }

	// RVA: 0x9D17A0 Offset: 0x9CFDA0 VA: 0x1809D17A0
	private void AppendYouTube(ref NewsSource.ParagraphBuilder currentParagraph, string videoId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x9D2B80 Offset: 0x9D1180 VA: 0x1809D2B80
	private static void .cctor() { }

}

private struct NewsSource.ParagraphBuilder // TypeDefIndex: 11128
{	// Fields
	public StringBuilder StringBuilder; // 0x0
	public List<string> Links; // 0x8

	// Methods

	// RVA: 0x9EB0E0 Offset: 0x9E96E0 VA: 0x1809EB0E0
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

	// RVA: 0x9EBB60 Offset: 0x9EA160 VA: 0x1809EBB60
	internal void <SetStory>b__0() { }

	// RVA: 0x9EBC00 Offset: 0x9EA200 VA: 0x1809EBC00
	internal Manifest.NewsInfo.BlogInfo <SetStory>g__GetBlogPost|1() { }

}

private sealed class NewsSource.<>c // TypeDefIndex: 11130
{	// Fields
	public static readonly NewsSource.<>c <>9; // 0x0
	public static Func<Manifest.NewsInfo.BlogInfo, string> <>9__12_2; // 0x8

	// Methods

	// RVA: 0x9EBE40 Offset: 0x9EA440 VA: 0x1809EBE40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B210 Offset: 0x939810 VA: 0x18093B210
	internal string <SetStory>b__12_2(Manifest.NewsInfo.BlogInfo b) { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11131
{	// Fields
	public string videoUrl; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9EBDC0 Offset: 0x9EA3C0 VA: 0x1809EBDC0
	internal void <AppendYouTube>b__0() { }

}

