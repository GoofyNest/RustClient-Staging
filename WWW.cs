public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
{
[ObsoleteAttribute] // RVA: 0xB5000 Offset: 0xB4400 VA: 0x1800B5000
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
	private UnityWebRequest _uwr; // 0x10

	public string error { get; }
	public bool isDone { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }


	public static string UnEscapeURL(string s) { }

	public static string UnEscapeURL(string s, Encoding e) { }

	public void .ctor(string url) { }

	public void .ctor(string url, WWWForm form) { }

	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	public string get_error() { }

	public bool get_isDone() { }

	public string get_text() { }

	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	public Texture2D get_texture() { }

	public string get_url() { }

	public override bool get_keepWaiting() { }

	public void Dispose() { }

	private bool WaitUntilDoneIfPossible() { }

}

