public class NewsSource : MonoBehaviour // TypeDefIndex: 11127
{	private static readonly Regex BbcodeParse; // 0x0
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


	public void Awake() { }

	public void OnEnable() { }

	public void SetStory(SteamNewsSource.Story story) { }

	private void ParseBbcode(ref NewsSource.ParagraphBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	private static string[] GetBulletPoints(string listContent) { }

	private void AppendParagraph(ref NewsSource.ParagraphBuilder currentParagraph) { }

	private void AppendImage(ref NewsSource.ParagraphBuilder currentParagraph, string url) { }

	private void AppendYouTube(ref NewsSource.ParagraphBuilder currentParagraph, string videoId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct NewsSource.ParagraphBuilder // TypeDefIndex: 11128
{	public StringBuilder StringBuilder; // 0x0
	public List<string> Links; // 0x8


	public static NewsSource.ParagraphBuilder New() { }

	public void AppendLine() { }

	public void Append(string text) { }

}

private sealed class NewsSource.<>c__DisplayClass12_0 // TypeDefIndex: 11129
{	public SteamNewsSource.Story story; // 0x10


	public void .ctor() { }

	internal void <SetStory>b__0() { }

	internal Manifest.NewsInfo.BlogInfo <SetStory>g__GetBlogPost|1() { }

}

private sealed class NewsSource.<>c // TypeDefIndex: 11130
{	public static readonly NewsSource.<>c <>9; // 0x0
	public static Func<Manifest.NewsInfo.BlogInfo, string> <>9__12_2; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <SetStory>b__12_2(Manifest.NewsInfo.BlogInfo b) { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11131
{	public string videoUrl; // 0x10


	public void .ctor() { }

	internal void <AppendYouTube>b__0() { }

}

