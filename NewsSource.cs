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

	// RVA: 0x9D1660 Offset: 0x9CFC60 VA: 0x1809D1660
	public void Awake() { }

	// RVA: 0x9D17C0 Offset: 0x9CFDC0 VA: 0x1809D17C0
	public void OnEnable() { }

	// RVA: 0x9D25A0 Offset: 0x9D0BA0 VA: 0x1809D25A0
	public void SetStory(SteamNewsSource.Story story) { }

	// RVA: 0x9D1850 Offset: 0x9CFE50 VA: 0x1809D1850
	private void ParseBbcode(ref NewsSource.ParagraphBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	// RVA: 0x9D16B0 Offset: 0x9CFCB0 VA: 0x1809D16B0
	private static string[] GetBulletPoints(string listContent) { }

	// RVA: 0x9D1320 Offset: 0x9CF920 VA: 0x1809D1320
	private void AppendParagraph(ref NewsSource.ParagraphBuilder currentParagraph) { }

	// RVA: 0x9D1260 Offset: 0x9CF860 VA: 0x1809D1260
	private void AppendImage(ref NewsSource.ParagraphBuilder currentParagraph, string url) { }

	// RVA: 0x9D14E0 Offset: 0x9CFAE0 VA: 0x1809D14E0
	private void AppendYouTube(ref NewsSource.ParagraphBuilder currentParagraph, string videoId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x9D28C0 Offset: 0x9D0EC0 VA: 0x1809D28C0
	private static void .cctor() { }

}

private struct NewsSource.ParagraphBuilder // TypeDefIndex: 11128
{	// Fields
	public StringBuilder StringBuilder; // 0x0
	public List<string> Links; // 0x8

	// Methods

	// RVA: 0x9EAE20 Offset: 0x9E9420 VA: 0x1809EAE20
	public static NewsSource.ParagraphBuilder New() { }

	// RVA: 0xFB210 Offset: 0xFA610 VA: 0x1800FB210
	public void AppendLine() { }

	// RVA: 0xFB230 Offset: 0xFA630 VA: 0x1800FB230
	public void Append(string text) { }

}

private sealed class NewsSource.<>c__DisplayClass12_0 // TypeDefIndex: 11129
{	// Fields
	public SteamNewsSource.Story story; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	internal void <SetStory>b__0() { }

	// RVA: 0x9EB940 Offset: 0x9E9F40 VA: 0x1809EB940
	internal Manifest.NewsInfo.BlogInfo <SetStory>g__GetBlogPost|1() { }

}

private sealed class NewsSource.<>c // TypeDefIndex: 11130
{	// Fields
	public static readonly NewsSource.<>c <>9; // 0x0
	public static Func<Manifest.NewsInfo.BlogInfo, string> <>9__12_2; // 0x8

	// Methods

	// RVA: 0x9EBB80 Offset: 0x9EA180 VA: 0x1809EBB80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B100 Offset: 0x939700 VA: 0x18093B100
	internal string <SetStory>b__12_2(Manifest.NewsInfo.BlogInfo b) { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11131
{	// Fields
	public string videoUrl; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9EBB00 Offset: 0x9EA100 VA: 0x1809EBB00
	internal void <AppendYouTube>b__0() { }

}

