public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
{
// Namespace: UnityEngine
[ObsoleteAttribute] // RVA: 0xB4D70 Offset: 0xB4170 VA: 0x1800B4D70
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
	// Fields
	private UnityWebRequest _uwr; // 0x10

	// Properties
	public string error { get; }
	public bool isDone { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x231AB30 Offset: 0x2319130 VA: 0x18231AB30
	public static string UnEscapeURL(string s) { }

	// RVA: 0x231AB60 Offset: 0x2319160 VA: 0x18231AB60
	public static string UnEscapeURL(string s, Encoding e) { }

	// RVA: 0x231AC50 Offset: 0x2319250 VA: 0x18231AC50
	public void .ctor(string url) { }

	// RVA: 0x231AF10 Offset: 0x2319510 VA: 0x18231AF10
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x231ACB0 Offset: 0x23192B0 VA: 0x18231ACB0
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x231AF90 Offset: 0x2319590 VA: 0x18231AF90
	public string get_error() { }

	// RVA: 0x231B0A0 Offset: 0x23196A0 VA: 0x18231B0A0
	public bool get_isDone() { }

	// RVA: 0x231B0F0 Offset: 0x23196F0 VA: 0x18231B0F0
	public string get_text() { }

	// RVA: 0x231A9D0 Offset: 0x2318FD0 VA: 0x18231A9D0
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x231B170 Offset: 0x2319770 VA: 0x18231B170
	public Texture2D get_texture() { }

	// RVA: 0x231B270 Offset: 0x2319870 VA: 0x18231B270
	public string get_url() { }

	// RVA: 0x231B0C0 Offset: 0x23196C0 VA: 0x18231B0C0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x231AAF0 Offset: 0x23190F0 VA: 0x18231AAF0 Slot: 8
	public void Dispose() { }

	// RVA: 0x231AB70 Offset: 0x2319170 VA: 0x18231AB70
	private bool WaitUntilDoneIfPossible() { }

}

