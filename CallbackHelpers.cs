internal static class CallbackHelpers // TypeDefIndex: 2556
{

internal static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback) { }

internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass5_0 // TypeDefIndex: 2557
{
	public MonoRemoteCertificateValidationCallback callback; 


public void .ctor() { }

internal bool <MonoToPublic>b__0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass8_0 // TypeDefIndex: 2558
{
	public MonoLocalCertificateSelectionCallback callback; 


public void .ctor() { }

internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

